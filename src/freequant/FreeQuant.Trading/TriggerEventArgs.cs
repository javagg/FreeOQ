using System;

namespace FreeQuant.Trading
{
	public class TriggerEventArgs : EventArgs
	{
		public Trigger Trigger { get; private set; }

		public TriggerEventArgs(Trigger trigger)
		{
			this.Trigger = trigger;
		}
	}
}
