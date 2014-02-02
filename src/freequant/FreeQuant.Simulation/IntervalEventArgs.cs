using System;

namespace FreeQuant.Simulation
{
	public class IntervalEventArgs : EventArgs
	{
		public Interval Interval { get; private set; }

		public IntervalEventArgs(Interval interval) : base()
		{
			this.Interval = interval;
		}
	}
}
