using System;

namespace FreeQuant
{
	public class RuntimeErrorEventArgs : EventArgs
	{
		private RuntimeError error;

		public RuntimeError Error { get { return error;	} }

		public RuntimeErrorEventArgs(RuntimeError error)
		{
			this.error = error;
		}
	}
}
