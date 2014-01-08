using System;

namespace FreeQuant.Data
{
	public class BarArrayEventArgs : EventArgs
	{
		private BarArray bars;

		public BarArray BarArray
		{
			get
			{
				return this.bars;
			}
		}

		public BarArrayEventArgs(BarArray bars)
		{
			this.bars = bars;
		}
	}
}
