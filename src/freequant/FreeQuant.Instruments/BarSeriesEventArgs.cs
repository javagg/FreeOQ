// Type: SmartQuant.Instruments.BarSeriesEventArgs
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.Series;
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
