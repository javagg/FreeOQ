// Type: SmartQuant.Instruments.Pricer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class Pricer : IPricer
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pricer()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Price(Instrument instrument)
    {
      if (instrument.Trade.DateTime != DateTime.MinValue && instrument.Trade.DateTime >= instrument.Bar.DateTime)
        return instrument.Trade.Price;
      if (instrument.Bar.DateTime != DateTime.MinValue)
        return instrument.Bar.Close;
      Daily last = instrument.GetDailySeries().Last;
      if (last != null)
        return last.Close;
      else
        return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Volatility(Instrument instrument)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Delta(Instrument instrument)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Gamma(Instrument instrument)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Theta(Instrument instrument)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Vega(Instrument instrument)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Rho(Instrument instrument)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Price(Instrument instrument, DateTime dateTime)
    {
      return instrument.GetDailySeries()[dateTime.Date, EIndexOption.Prev].Close;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Volatility(Instrument instrument, DateTime dateTime1, DateTime dateTime2)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Delta(Instrument instrument, DateTime dateTime)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Gamma(Instrument instrument, DateTime dateTime)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Theta(Instrument instrument, DateTime dateTime)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Vega(Instrument instrument, DateTime dateTime)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Rho(Instrument instrument, DateTime dateTime)
    {
      return 0.0;
    }
  }
}
