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

		public virtual double GetInitialMargin(double value, Instrument instrument, Side side, DateTime datetime)
		{
            // FIXME: SecurityType = ?
            if (!this.Enabled || !(instrument.SecurityType == "?"))
				return 0;
			switch (side)
			{
				case Side.Buy:
				case Side.SellShort:
					return value * 0.5;
				default:
					return 0;
			}
		}
	}
}
