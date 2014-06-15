using System;
using System.Windows.Forms;

namespace FreeQuant
{
    public class Win32Window : IWin32Window
    {
        public IntPtr Handle { get; private set; }

        public Win32Window(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
