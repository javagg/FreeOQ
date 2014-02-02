using System;

namespace FreeQuant.Trading
{
	public class StopEventArgs : EventArgs
	{
		public IStop Stop { get; private set; }

		public StopEventArgs(IStop stop)
		{
			this.Stop = stop;
		}
	}
}
