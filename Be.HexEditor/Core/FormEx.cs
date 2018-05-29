using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Be.HexEditor.Core
{
    public partial class FormEx : Form
    {
        // DPI at design time
        public const float DpiAtDesign = 96F;
        [DefaultValue(0), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float DpiOld { get; set; } = 0;
        [DefaultValue(0), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float DpiNew { get; set; } = 0;

        // Flag to set whether this window is being moved by user
        bool isBeingMoved = false;

        // Flag to set whether this window will be adjusted later
        bool willBeAdjusted = false;

        // Method for adjustment
        ResizeMethod method = ResizeMethod.Immediate;

        enum ResizeMethod
        {
            Immediate,
            Delayed
        }

        enum DelayedState
        {
            Initial,
            Waiting,
            Resized,
            Aborted
        }

        public FormEx()
        {
            //this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            Font = SystemFonts.MessageBoxFont;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Load += new System.EventHandler(MainForm_Load);
            ResizeBegin += new System.EventHandler(MainForm_ResizeBegin);
            ResizeEnd += new System.EventHandler(MainForm_ResizeEnd);
            Move += new System.EventHandler(MainForm_Move);
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            if (!Util.DesignMode)
                AdjustWindowInitial();
        }

        // Adjust location, size and font size of Controls according to new DPI.
        void AdjustWindowInitial()
        {
            // Hold initial DPI used at loading this window.
            DpiOld = CurrentAutoScaleDimensions.Width;

            // Check current DPI.
            DpiNew = GetDpiWindowMonitor();

            AdjustWindow();
        }

        // Catch window message of DPI change.
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Check if Windows 8.1 or newer and if not, ignore message.
            if (!IsEightOneOrNewer())
                return;

            const int WM_DPICHANGED = 0x02e0; // 0x02E0 from WinUser.h

            if (m.Msg == WM_DPICHANGED)
            {
                // wParam
                short lo = NativeMethods.GetLoWord(m.WParam.ToInt32());

                // lParam
                NativeMethods.RECT r = (NativeMethods.RECT)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.RECT));

                // Hold new DPI as target for adjustment.
                DpiNew = lo;

                switch (method)
                {
                    case ResizeMethod.Immediate:
                        if (DpiOld != lo)
                        {
                            MoveWindow();
                            AdjustWindow();
                        }
                        break;

                    case ResizeMethod.Delayed:
                        if (DpiOld != lo)
                        {
                            if (isBeingMoved)
                            {
                                willBeAdjusted = true;
                            }
                            else
                            {
                                AdjustWindow();
                            }
                        }
                        else
                        {
                            if (willBeAdjusted)
                            {
                                willBeAdjusted = false;
                            }
                        }
                        break;
                }
            }
        }

        // Detect user began moving this window.
        void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            isBeingMoved = true;
        }

        // Detect user ended moving this window.
        void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            isBeingMoved = false;
        }

        // Detect this window is moved.
        void MainForm_Move(object sender, EventArgs e)
        {
            if (willBeAdjusted && IsLocationGood())
            {
                willBeAdjusted = false;

                AdjustWindow();
            }
        }

        // Get new location of this window after DPI change.
        void MoveWindow()
        {
            if (Util.DesignMode)
                return;

            if (DpiOld == 0)
                return; // Abort.

            float factor = DpiNew / DpiOld;

            // Prepare new rectangles shrinked or expanded sticking four corners.
            int widthDiff = (int)(ClientSize.Width * factor) - ClientSize.Width;
            int heightDiff = (int)(ClientSize.Height * factor) - ClientSize.Height;

            List<NativeMethods.RECT> rectList = new List<NativeMethods.RECT>
            {

                // Left-Top corner
                new NativeMethods.RECT
                {
                    left = Bounds.Left,
                    top = Bounds.Top,
                    right = Bounds.Right + widthDiff,
                    bottom = Bounds.Bottom + heightDiff
                },

                // Right-Top corner
                new NativeMethods.RECT
                {
                    left = Bounds.Left - widthDiff,
                    top = Bounds.Top,
                    right = Bounds.Right,
                    bottom = Bounds.Bottom + heightDiff
                },

                // Left-Bottom corner
                new NativeMethods.RECT
                {
                    left = Bounds.Left,
                    top = Bounds.Top - heightDiff,
                    right = Bounds.Right + widthDiff,
                    bottom = Bounds.Bottom
                },

                // Right-Bottom corner
                new NativeMethods.RECT
                {
                    left = Bounds.Left - widthDiff,
                    top = Bounds.Top - heightDiff,
                    right = Bounds.Right,
                    bottom = Bounds.Bottom
                }
            };

            // Get handle to monitor that has the largest intersection with each rectangle.
            for (int i = 0; i <= rectList.Count - 1; i++)
            {
                NativeMethods.RECT rectBuf = rectList[i];

                IntPtr handleMonitor = NativeMethods.MonitorFromRect(ref rectBuf, NativeMethods.MONITOR_DEFAULTTONULL);

                if (handleMonitor != IntPtr.Zero)
                {
                    // Check if at least Left-Top corner or Right-Top corner is inside monitors.
                    IntPtr handleLeftTop = NativeMethods.MonitorFromPoint(new NativeMethods.POINT(rectBuf.left, rectBuf.top), NativeMethods.MONITOR_DEFAULTTONULL);
                    IntPtr handleRightTop = NativeMethods.MonitorFromPoint(new NativeMethods.POINT(rectBuf.right, rectBuf.top), NativeMethods.MONITOR_DEFAULTTONULL);

                    if ((handleLeftTop != IntPtr.Zero) || (handleRightTop != IntPtr.Zero))
                    {
                        // Check if DPI of the monitor matches.
                        if (GetDpiSpecifiedMonitor(handleMonitor) == DpiNew)
                        {
                            // Move this window.
                            Location = new Point(rectBuf.left, rectBuf.top);

                            break;
                        }
                    }
                }
            }
        }

        // Check if current location of this window is good for delayed adjustment.
        bool IsLocationGood()
        {
            if (DpiOld == 0)
                return false; // Abort.

            float factor = DpiNew / DpiOld;

            // Prepare new rectangle shrinked or expanded sticking Left-Top corner.
            int widthDiff = (int)(ClientSize.Width * factor) - ClientSize.Width;
            int heightDiff = (int)(ClientSize.Height * factor) - ClientSize.Height;

            NativeMethods.RECT rect = new NativeMethods.RECT()
            {
                left = Bounds.Left,
                top = Bounds.Top,
                right = Bounds.Right + widthDiff,
                bottom = Bounds.Bottom + heightDiff
            };

            // Get handle to monitor that has the largest intersection with the rectangle.
            IntPtr handleMonitor = NativeMethods.MonitorFromRect(ref rect, NativeMethods.MONITOR_DEFAULTTONULL);

            if (handleMonitor != IntPtr.Zero)
            {
                // Check if DPI of the monitor matches.
                if (GetDpiSpecifiedMonitor(handleMonitor) == DpiNew)
                {
                    return true;
                }
            }

            return false;
        }

        float _factor;
        [DefaultValue(1), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float Factor
        {
            get => _factor;
            private set
            {
                if (_factor == value)
                    return;
                _factor = value;

                FactorChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler FactorChanged;

        // Adjust this window.
        protected virtual void AdjustWindow()
        {
            if (Util.DesignMode)
                return;

            if ((DpiOld == 0) || (DpiOld == DpiNew))
                return; // Abort.

            float factor = DpiNew / DpiOld;

            //MessageBox.Show(string.Format("new{0}, old{1}, factor: {2}", dpiNew, dpiOld, factor));

            DpiOld = DpiNew;

            // Adjust location and size of Controls (except location of this window itself).
            Scale(new SizeF(factor, factor));

            // Adjust Font size of Controls.
            AdjustFont(factor);
        }

        protected virtual void AdjustFont(float factor)
        {
            if (Util.DesignMode)
                return;

            var dic = GetChildControlFontSizes(this);

            CoreUtil.ScaleFont(this, factor);

            foreach (var item in dic)
            {
                // not affected by parent font?
                if (item.Key.Font.Size == item.Value)
                {
                    CoreUtil.ScaleFont(item.Key, factor);
                    continue;
                }
            }
        }

        // Get child Controls in a specified Control.
        Dictionary<Control, float> GetChildControlFontSizes(Control parent)
        {
            var dic = new Dictionary<Control, float>();
            FillChildControlFontSizes(dic, parent);
            return dic;
        }

        void FillChildControlFontSizes(Dictionary<Control, float> dic, Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                dic.Add(child, child.Font.Size);
                FillChildControlFontSizes(dic, child);
            }
        }


        #region DPI

        // Get DPI of monitor containing this window by GetDpiForMonitor.
        float GetDpiWindowMonitor()
        {
            // Get handle to this window.
            IntPtr handleWindow = Process.GetCurrentProcess().MainWindowHandle;

            // Get handle to monitor.
            IntPtr handleMonitor = NativeMethods.MonitorFromWindow(handleWindow, NativeMethods.MONITOR_DEFAULTTOPRIMARY);

            // Get DPI.
            return GetDpiSpecifiedMonitor(handleMonitor);
        }

        // Get DPI of a specified monitor by GetDpiForMonitor.
        float GetDpiSpecifiedMonitor(IntPtr handleMonitor)
        {
            // Check if GetDpiForMonitor function is available.
            if (!IsEightOneOrNewer())
                return CurrentAutoScaleDimensions.Width;

            int result = NativeMethods.GetDpiForMonitor(handleMonitor, NativeMethods.Monitor_DPI_Type.MDT_Default, out uint dpiX, out uint dpiY);

            if (result != 0) // If not S_OK (= 0)
            {
                throw new Exception("Failed to get DPI of monitor containing this window.");
            }

            return (float)dpiX;
        }

        // Get DPI for all monitors by GetDeviceCaps.
        static float GetDpiDeviceMonitor()
        {
            int dpiX = 0;
            IntPtr screen = IntPtr.Zero;

            try
            {
                screen = NativeMethods.GetDC(IntPtr.Zero);
                dpiX = NativeMethods.GetDeviceCaps(screen, NativeMethods.LOGPIXELSX);
            }
            finally
            {
                if (screen != IntPtr.Zero)
                {
                    NativeMethods.ReleaseDC(IntPtr.Zero, screen);
                }
            }

            return (float)dpiX;
        }

        #endregion


        #region OS Version

        // Check if OS is Windows 8.1 or newer.
        static bool IsEightOneOrNewer()
        {
            // To get this value correctly, it is required to include ID of Windows 8.1 in the manifest file.
            return (6.3 <= GetVersion());
        }

        // Get OS version in Double.
        private static double GetVersion()
        {
            OperatingSystem os = Environment.OSVersion;

            return os.Version.Major + ((double)os.Version.Minor / 10);
        }

        #endregion

    }
}
