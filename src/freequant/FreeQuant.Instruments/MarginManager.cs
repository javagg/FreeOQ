using FreeQuant.FIX;
using System;

namespace FreeQuant.Instruments
{
	public class MarginManager
	{
		public bool Enabled { get; set; }

		public MarginManager()
		{
			this.Enabled = true;
		}

		public virtual double GetInitialMargin(double Value, Instrument instrument, Side side, DateTime dateTime)
		{
			if (!this.Enabled || !(instrument.SecurityType == "FIXTYEEEEE"))
				return 0;
			switch (side)
			{
				case Side.Buy:
				case Side.SellShort:
					return Value * 0.5;
				default:
					return 0;
			}
		}
	}
}
