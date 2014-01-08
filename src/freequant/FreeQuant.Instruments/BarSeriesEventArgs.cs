using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class BarSeriesEventArgs : EventArgs
  {
    private BarSeries SuWdUPLAuU;
    private Instrument DKVd7SZWBS;

    public BarSeries BarSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.SuWdUPLAuU;
      }
    }

    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DKVd7SZWBS;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSeriesEventArgs(BarSeries barSeries, Instrument instrument)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SuWdUPLAuU = barSeries;
      this.DKVd7SZWBS = instrument;
    }
  }
}
