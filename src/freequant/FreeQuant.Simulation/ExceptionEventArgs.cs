using System;

namespace FreeQuant.Simulation
{
	public class ExceptionEventArgs : EventArgs
	{
		public Exception Exception { get; private set; }

		public ExceptionEventArgs(Exception exception) : base()
		{
			this.Exception = exception;
		}
	}
}
