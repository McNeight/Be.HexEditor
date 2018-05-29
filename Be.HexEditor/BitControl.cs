using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Be.Byte;

namespace Be.HexEditor
{
    public partial class BitControl : UserControl
    {
        List<RichTextBox> _txtBits = new List<RichTextBox>();

        public event EventHandler BitChanged;

        protected virtual void OnBitChanged(EventArgs e)
        {
            BitChanged?.Invoke(this, e);
        }

        Panel _innerBorderHeaderPanel;

        Panel _innerBorderPanel;

        public BitControl()
        {
            _innerBorderHeaderPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(3, 1, 3, 1)
            };

            _innerBorderPanel = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(3, 1, 3, 1)
            };

            InitializeComponent();

            pnBitsEditor.BackColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;


            pnBitsHeader.Controls.Add(_innerBorderHeaderPanel);

            bool first = true;
            Size size = new Size();
            int pos = 5;
            for (int i = 7; i > -1; i--)
            {
                Label lbl = new Label
                {
                    Tag = i,
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Consolas", SystemFonts.MessageBoxFont.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Margin = new System.Windows.Forms.Padding(0),

                    Name = "lbl" + i.ToString(),

                    //lbl.Size = new System.Drawing.Size(14, 14);

                    AutoSize = true,
                    Text = i.ToString()
                };
                lbl.Enter += new System.EventHandler(txt_Enter);
                lbl.KeyDown += new System.Windows.Forms.KeyEventHandler(txt_KeyDown);
                _innerBorderHeaderPanel.Controls.Add(lbl);

                if (first)
                {
                    size = lbl.Size;
                    lbl.AutoSize = false;
                    first = false;
                }

                lbl.Size = size;
                lbl.Left = pos;
                lbl.Top = 3;
                pos += size.Width;
            }

            pnBitsEditor.Controls.Add(_innerBorderPanel);
            pos = 8;
            for (int i = 7; i > -1; i--)
            {
                RichTextBox txt = new RichTextBox
                {
                    Tag = i,
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Font = new System.Drawing.Font("Consolas", SystemFonts.MessageBoxFont.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Margin = new System.Windows.Forms.Padding(0),

                    MaxLength = 1,
                    Multiline = false,
                    Name = "txt" + i.ToString(),
                    //txt.Size = new System.Drawing.Size(14, 14);
                    Size = size,
                    Left = pos,
                    Top = 6
                };
                pos += size.Width;
                txt.TabIndex = 10 - i + 7;
                txt.Text = "0";
                txt.Visible = false;
                txt.SelectionChanged += new System.EventHandler(txt_SelectionChanged);
                txt.Enter += new System.EventHandler(txt_Enter);
                txt.KeyDown += new System.Windows.Forms.KeyEventHandler(txt_KeyDown);
                _innerBorderPanel.Controls.Add(txt);
                _txtBits.Add(txt);
            }
            UpdateView();
        }

        BitInfo _bitInfo;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BitInfo BitInfo
        {
            get => _bitInfo;
            set
            {
                _bitInfo = value;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            foreach (RichTextBox txt in _txtBits)
                txt.TextChanged -= new EventHandler(txt_TextChanged);

            if (_bitInfo == null)
            {
                foreach (RichTextBox txt in _txtBits)
                {
                    txt.Text = string.Empty;
                }
                pnBitsEditor.Visible = lblValue.Visible = lblBit.Visible = pnBitsHeader.Visible = false;

                return;
            }
            else
            {
                foreach (RichTextBox txt in _txtBits)
                    txt.Visible = true;
                pnBitsEditor.Visible = lblValue.Visible = lblBit.Visible = pnBitsHeader.Visible = true;
            }

            foreach (RichTextBox txt in _txtBits)
            {
                int bit = (int)txt.Tag;
                txt.Text = _bitInfo.GetBitAsString(bit);
            }

            foreach (RichTextBox txt in _txtBits)
                txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        static int GetBitSetInt(byte b, int pos)
        {
            if (IsBitSet(b, pos))
                return 1;
            else
                return 0;
        }

        static bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        static byte SetBit(byte b, int BitNumber)
        {
            //Kleine Fehlerbehandlung
            if (BitNumber < 8 && BitNumber > -1)
            {
                return (byte)(b | (byte)(0x01 << BitNumber));
            }
            else
            {
                throw new InvalidOperationException(
                "Der Wert für BitNumber " + BitNumber.ToString() + " war nicht im zulässigen Bereich! (BitNumber = (min)0 - (max)7)");
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            RichTextBox txt = (RichTextBox)sender;
            int index = (int)txt.Tag;
            bool value = txt.Text != "0";
            BitInfo[index] = value;
            OnBitChanged(EventArgs.Empty);

            NavigateRight((RichTextBox)sender);
        }

        void NavigateLeft(RichTextBox txt)
        {
            int indexOf = _txtBits.IndexOf(txt);

            NavigateTo(indexOf - 1);
        }

        void NavigateRight(RichTextBox txt)
        {
            int indexOf = _txtBits.IndexOf(txt);

            NavigateTo(indexOf + 1);
        }

        void NavigateTo(int indexOf)
        {
            if (indexOf > _txtBits.Count - 1 || indexOf < 0)
                return;

            bool txtFocus = false;
            foreach (RichTextBox txt in _txtBits)
            {
                if (txt.Focused)
                {
                    txtFocus = true;
                    break;
                }
            }

            if (!txtFocus)
                return;

            RichTextBox selectBox = _txtBits[indexOf];
            selectBox.Focus();
        }

        void txt_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox txt = (RichTextBox)sender;

            List<Keys> bitKeys = new List<Keys>() { Keys.D0, Keys.D1 };

            RichTextBox txt7 = _txtBits[0];
            if (txt7.SelectionLength > 1)
                txt7.SelectionLength = 1;

            bool modifiersNone = e.Modifiers == Keys.None;
            bool updateBit = modifiersNone && bitKeys.Contains(e.KeyCode);

            e.Handled = e.SuppressKeyPress = !updateBit;

            if (!updateBit && modifiersNone)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        NavigateLeft(txt);
                        break;
                    case Keys.Right:
                        NavigateRight(txt);
                        break;
                    case Keys.Home:
                        NavigateTo(0);
                        break;
                    case Keys.End:
                        NavigateTo(7);
                        break;
                }
            }
        }

        void txt_SelectionChanged(object sender, EventArgs e)
        {
            RichTextBox txt = (RichTextBox)sender;
            UpdateSelection(txt);
        }

        static void UpdateSelection(RichTextBox txt)
        {
            txt.SelectionStart = 0;
            if (txt.SelectionLength == 0)
                txt.SelectionLength = 1;
        }

        void txt_Enter(object sender, EventArgs e)
        {
            RichTextBox txt = (RichTextBox)sender;
            UpdateSelection(txt);
        }
    }
}
