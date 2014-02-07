using System;

namespace FreeQuant.Trading
{
	public class SignalEventArgs : EventArgs
	{
		public Signal Signal { get; private set; }

		public SignalEventArgs(Signal signal) : base()
		{
			this.Signal = signal;
		}
	}
}
