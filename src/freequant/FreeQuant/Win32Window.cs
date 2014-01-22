using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeQuant
{
	public class Win32Window : IWin32Window
	{
		private IntPtr hyrrRfOkb6;

		public IntPtr Handle
		{
			get
			{
				return hyrrRfOkb6;
			}
		}

		public Win32Window(IntPtr handle)
		{
		}
	}
}
