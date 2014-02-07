using System;

namespace FreeQuant.Data
{
	public class BarArrayEventArgs : EventArgs
	{
		public BarArray BarArray {	get; private set;	}

		public BarArrayEventArgs(BarArray bars)
		{
			this.BarArray = bars;
		}
	}
}
