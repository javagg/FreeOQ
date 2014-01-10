using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class MarginManager
  {
		private bool enabled; 

    public bool Enabled
    {
       get
      {
        return this.enabled;
      }
      set
      {
        this.enabled = value;
      }
    }

    public MarginManager()
    {
      this.enabled = true;
    }

    public virtual double GetInitialMargin(double Value, Instrument instrument, Side side, DateTime dateTime)
    {
			if (!this.enabled || !(instrument.SecurityType == "FIXTYEEEEE"))
        return 0.0;
      switch (side)
      {
        case Side.Buy:
        case Side.SellShort:
          return Value * 0.5;
        default:
          return 0.0;
      }
    }
  }
}
