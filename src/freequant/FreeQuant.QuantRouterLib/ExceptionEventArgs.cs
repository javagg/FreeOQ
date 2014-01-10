using System;

namespace FreeQuant.QuantRouterLib
{
	public class ExceptionEventArgs : EventArgs
	{
		public Exception Exception { get; private set; }

		public ExceptionEventArgs(Exception exception)
		{
			this.Exception = exception;
		}
	}
}
