using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Simulation;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{94FAFF9D-5281-4c67-A599-B893F1F58B38}", ComponentType.Entry, Description = "", Name = "Default_Entry")]
  public class Entry : StrategySingleComponent
  {
    public const string GUID = "{94FAFF9D-5281-4c67-A599-B893F1F58B38}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Entry()
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
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument)
    {
      return this.LongEntry(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2276) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument)
    {
      return this.ShortEntry(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2300) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(string text)
    {
      return this.LongEntry(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry()
    {
      return this.LongEntry(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(string text)
    {
      return this.ShortEntry(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry()
    {
      return this.ShortEntry(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, double price)
    {
      return this.LongEntry(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2326) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, double price)
    {
      return this.ShortEntry(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2350) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(double price, string text)
    {
      return this.LongEntry(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(double price)
    {
      return this.LongEntry(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(double price, string text)
    {
      return this.ShortEntry(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(double price)
    {
      return this.ShortEntry(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(Instrument instrument, FillOnBarMode mode)
    {
      return this.LongEntry(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2376) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(Instrument instrument, FillOnBarMode mode)
    {
      return this.ShortEntry(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2400) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(FillOnBarMode mode, string text)
    {
      return this.LongEntry(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongEntry(FillOnBarMode mode)
    {
      return this.LongEntry(this.instrument, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(FillOnBarMode mode, string text)
    {
      return this.ShortEntry(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortEntry(FillOnBarMode mode)
    {
      return this.ShortEntry(this.instrument, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument)
    {
      return this.Buy(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2426) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(string text)
    {
      return this.Buy(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy()
    {
      return this.Buy(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, double price)
    {
      return this.Buy(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2438) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(double price, string text)
    {
      return this.Buy(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(double price)
    {
      return this.Buy(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
    {
      return this.Buy(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2450) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(string text, FillOnBarMode mode)
    {
      return this.Buy(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(FillOnBarMode mode)
    {
      return this.Buy(this.instrument, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyMarket(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        QvSj2cjRxv = true
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyMarket(Instrument instrument)
    {
      return this.Buy(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2462) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyMarket(string text)
    {
      return this.Buy(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyMarket()
    {
      return this.Buy(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price, TimeInForce timeInForce, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Limit, SignalSide.Buy, instrument, text)
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
      return this.BuyLimit(instrument, price, timeInForce, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2486) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price)
    {
      return this.BuyLimit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2508) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(double price, TimeInForce timeInForce, string text)
    {
      return this.BuyLimit(this.instrument, price, timeInForce, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(double price, string text)
    {
      return this.BuyLimit(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(double price, TimeInForce timeInForce)
    {
      return this.BuyLimit(this.instrument, price, timeInForce);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(double price)
    {
      return this.BuyLimit(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Stop, SignalSide.Buy, instrument, text)
      {
        StopPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(Instrument instrument, double price)
    {
      return this.BuyStop(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2530) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(double price, string text)
    {
      return this.BuyStop(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(double price)
    {
      return this.BuyStop(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.StopLimit, SignalSide.Buy, instrument, text)
      {
        StopPrice = stopPrice,
        LimitPrice = limitPrice
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.BuyStopLimit(instrument, stopPrice, limitPrice, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2550) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice, string text)
    {
      return this.BuyStopLimit(this.instrument, stopPrice, limitPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice)
    {
      return this.BuyStopLimit(this.instrument, stopPrice, limitPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyTrailingStop(double delta, string text)
    {
      if (!this.Strategy.IsInstrumentActive(this.instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.TrailingStop, SignalSide.Buy, this.instrument, text)
      {
        StopPrice = delta
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyTrailingStop(double delta)
    {
      return this.BuyTrailingStop(delta, string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(2580), (object) this.Strategy.Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument)
    {
      return this.Sell(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2622) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(string text)
    {
      return this.Sell(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell()
    {
      return this.Sell(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, double price)
    {
      return this.Sell(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2636) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(string text, double price)
    {
      return this.Sell(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(double price)
    {
      return this.Sell(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
    {
      return this.Sell(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2650) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(string text, FillOnBarMode mode)
    {
      return this.Sell(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(FillOnBarMode mode)
    {
      return this.Sell(this.instrument, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellMarket(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        QvSj2cjRxv = true
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellMarket(Instrument instrument)
    {
      return this.Sell(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2664) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellMarket(string text)
    {
      return this.Sell(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellMarket()
    {
      return this.Sell(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price, TimeInForce timeInForce, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Limit, SignalSide.Sell, instrument, text)
      {
        LimitPrice = price,
        TimeInForce = timeInForce
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
    {
      return this.SellLimit(instrument, price, TimeInForce.GTC, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price, TimeInForce timeInForce)
    {
      return this.SellLimit(instrument, price, timeInForce, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2690) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price)
    {
      return this.SellLimit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2714) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(double price, TimeInForce timeInForce, string text)
    {
      return this.SellLimit(this.instrument, price, timeInForce, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(double price, string text)
    {
      return this.SellLimit(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(double price, TimeInForce timeInForce)
    {
      return this.SellLimit(this.instrument, price, timeInForce);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(double price)
    {
      return this.SellLimit(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Stop, SignalSide.Sell, instrument, text)
      {
        StopPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(Instrument instrument, double price)
    {
      return this.SellStop(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2738) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(double price, string text)
    {
      return this.SellStop(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(double price)
    {
      return this.SellStop(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.StopLimit, SignalSide.Sell, instrument, text)
      {
        StopPrice = stopPrice,
        LimitPrice = limitPrice
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.SellStopLimit(instrument, stopPrice, limitPrice, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2760) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice, string text)
    {
      return this.SellStopLimit(this.instrument, stopPrice, limitPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice)
    {
      return this.SellStopLimit(this.instrument, stopPrice, limitPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellTrailingStop(double delta, string text)
    {
      if (!this.Strategy.IsInstrumentActive(this.instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.TrailingStop, SignalSide.Sell, this.instrument, text)
      {
        StopPrice = delta
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellTrailingStop(double delta)
    {
      return this.SellTrailingStop(delta, string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(2792), (object) this.Strategy.Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument)
    {
      return this.SellShort(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2836) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(string text)
    {
      return this.SellShort(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort()
    {
      return this.SellShort(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Entry, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
    {
      return this.SellShort(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(2860) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(string text, FillOnBarMode mode)
    {
      return this.SellShort(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(FillOnBarMode mode)
    {
      return this.SellShort(this.instrument, mode);
    }
  }
}
