// Type: SmartQuant.Trading.CrossEntry
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Simulation;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  [StrategyComponent("{664274F3-FDE1-46da-A84F-556E4A0EB170}", ComponentType.CrossEntry, Description = "", Name = "Default_CrossEntry")]
  public class CrossEntry : StrategyMultiComponent
  {
    public const string GUID = "{664274F3-FDE1-46da-A84F-556E4A0EB170}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossEntry()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder EmitSignal(Signal signal)
    {
      return this.Strategy.BgvpSPpUAD(signal);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument)
    {
      return this.LongEntry(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10410) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument)
    {
      return this.ShortEntry(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10434) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, double price)
    {
      return this.LongEntry(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10460) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, double price)
    {
      return this.ShortEntry(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10484) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode)
    {
      return this.LongEntry(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10510) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode)
    {
      return this.ShortEntry(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10534) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument)
    {
      return this.Buy(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10560) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, double price)
    {
      return this.Buy(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10572) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
    {
      return this.Buy(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10584) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyMarket(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        QvSj2cjRxv = true
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyMarket(Instrument instrument)
    {
      return this.Buy(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10596) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Limit, SignalSide.Buy, instrument, text)
      {
        LimitPrice = price,
        TimeInForce = timeInForce
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
    {
      return this.BuyLimit(instrument, price, TimeInForce.GTC, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce)
    {
      return this.BuyLimit(instrument, price, timeInForce, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10620) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price)
    {
      return this.BuyLimit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10642) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Stop, SignalSide.Buy, instrument, text)
      {
        StopPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(Instrument instrument, double price)
    {
      return this.BuyStop(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10664) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.StopLimit, SignalSide.Buy, instrument, text)
      {
        StopPrice = stopPrice,
        LimitPrice = limitPrice
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.BuyStopLimit(instrument, stopPrice, limitPrice, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10684) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyTrailingStop(Instrument instrument, double delta, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.TrailingStop, SignalSide.Buy, instrument, text)
      {
        StopPrice = delta
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyTrailingStop(Instrument instrument, double delta)
    {
      return this.BuyTrailingStop(instrument, delta, string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(10714), (object) this.Strategy.Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument)
    {
      return this.Sell(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10756) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, double price)
    {
      return this.Sell(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10770) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
    {
      return this.Sell(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10784) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellMarket(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        QvSj2cjRxv = true
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellMarket(Instrument instrument)
    {
      return this.Sell(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10798) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Limit, SignalSide.Sell, instrument, text)
      {
        LimitPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price)
    {
      return this.SellLimit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10824) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Stop, SignalSide.Sell, instrument, text)
      {
        StopPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(Instrument instrument, double price)
    {
      return this.SellStop(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10848) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.StopLimit, SignalSide.Sell, instrument, text)
      {
        StopPrice = stopPrice,
        LimitPrice = limitPrice
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.SellStopLimit(instrument, stopPrice, limitPrice, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10870) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellTrailingStop(Instrument instrument, double delta, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.TrailingStop, SignalSide.Sell, instrument, text)
      {
        StopPrice = delta
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellTrailingStop(Instrument instrument, double delta)
    {
      return this.SellTrailingStop(instrument, delta, string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(10902), (object) this.Strategy.Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument)
    {
      return this.SellShort(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10946) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.CrossEntry, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
    {
      return this.SellShort(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(10970) + this.Strategy.Name);
    }
  }
}
