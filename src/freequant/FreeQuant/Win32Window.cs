using System;
using System.Windows.Forms;

namespace FreeQuant
{
	public class Win32Window : IWin32Window
	{
		private IntPtr handle;

		public IntPtr Handle { get { return handle; } }

		public Win32Window(IntPtr handle)
		{
			this.handle = handle;
		}
	}
}
