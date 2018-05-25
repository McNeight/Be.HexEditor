using System;
using System.Runtime.InteropServices;

namespace Be.Windows.Forms
{
    internal static class NativeMethods
    {
        // Caret definitions
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ShowCaret(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool DestroyCaret();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool SetCaretPos(int X, int Y);

        // Key definitions
        internal const int WM_KEYDOWN = 0x100;
        internal const int WM_KEYUP = 0x101;
        internal const int WM_CHAR = 0x102;
    }
}
