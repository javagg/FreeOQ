using System;

namespace FreeQuant.Trading
{
	public class MetaStrategyErrorEventArgs : EventArgs
	{
		public Exception Exception { get; private set; }
		public bool Ignore { get; set; }

		public MetaStrategyErrorEventArgs(Exception exception) : base()
		{
			this.Exception = exception;
			this.Ignore = false;
		}
	}
}
