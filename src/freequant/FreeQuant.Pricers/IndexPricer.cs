// Type: SmartQuant.Pricers.IndexPricer
// Assembly: SmartQuant.Pricers, Version=1.0.5036.28349, Culture=neutral, PublicKeyToken=null
// MVID: B5619836-F92D-4F05-87FC-59ACDBEC6C4D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Pricers.dll

using deZgvqpY4MQTDmgNxy;
using oqvZcLyyH5L6j7Q2Ce;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Pricers
{
  public class IndexPricer : IPricer
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndexPricer()
    {
      nLGExKeI8bcCnxjjkZ.YOWMADbz5DMDT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Price(Instrument instrument)
    {
      double num = 0.0;
      foreach (Leg leg in (FIXGroupList) instrument.Legs)
      {
        switch (leg.LegSide)
        {
          case '1':
          case '3':
            num += leg.LegRatioQty * leg.Instrument.Price();
            continue;
          case '2':
          case '5':
            num -= leg.LegRatioQty * leg.Instrument.Price();
            continue;
          default:
            throw new ApplicationException(YFr4aDi8cYtC1CTC1J.rIdf61NpS(0) + (object) instrument.Symbol + YFr4aDi8cYtC1CTC1J.rIdf61NpS(42) + (string) (object) leg.LegSide + YFr4aDi8cYtC1CTC1J.rIdf61NpS(86) + leg.Instrument.Symbol);
        }
      }
      return num;
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
      double num = 0.0;
      foreach (Leg leg in (FIXGroupList) instrument.Legs)
      {
        switch (leg.LegSide)
        {
          case '1':
          case '3':
            num += leg.LegRatioQty * leg.Instrument.Price(dateTime);
            continue;
          case '2':
          case '5':
            num -= leg.LegRatioQty * leg.Instrument.Price();
            continue;
          default:
            throw new ApplicationException(YFr4aDi8cYtC1CTC1J.rIdf61NpS(108) + (object) instrument.Symbol + YFr4aDi8cYtC1CTC1J.rIdf61NpS(150) + (string) (object) leg.LegSide + YFr4aDi8cYtC1CTC1J.rIdf61NpS(194) + leg.Instrument.Symbol);
        }
      }
      return num;
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
