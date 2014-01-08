using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.Instruments;
using FreeQuant.Simulation;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{6FEE0044-0FD2-418d-94E6-400834BEE5D3}", ComponentType.Exit, Description = "", Name = "Default_Exit")]
  public class Exit : StrategySingleComponent
  {
    public const string GUID = "{6FEE0044-0FD2-418d-94E6-400834BEE5D3}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Exit()
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
    public virtual SingleOrder LongExit(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
      if (!this.HasPosition || this.Position.Side != PositionSide.Long)
      {
        signal.Status = SignalStatus.Rejected;
        signal.Rejecter = ComponentType.Exit;
      }
      return this.Strategy.BgvpSPpUAD(signal);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(Instrument instrument)
    {
      return this.LongExit(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13224) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.BuyCover, instrument, text);
      if (!this.HasPosition || this.Position.Side != PositionSide.Short)
      {
        signal.Status = SignalStatus.Rejected;
        signal.Rejecter = ComponentType.Exit;
      }
      return this.Strategy.BgvpSPpUAD(signal);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(Instrument instrument)
    {
      return this.ShortExit(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13246) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(string text)
    {
      return this.LongExit(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit()
    {
      return this.LongExit(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(string text)
    {
      return this.ShortExit(this.instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ShortExit()
    {
      this.ShortExit(this.instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
      signal.StrategyFill = true;
      signal.StrategyPrice = price;
      if (!this.HasPosition || this.Position.Side != PositionSide.Long)
      {
        signal.Status = SignalStatus.Rejected;
        signal.Rejecter = ComponentType.Exit;
      }
      return this.Strategy.BgvpSPpUAD(signal);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(Instrument instrument, double price)
    {
      return this.LongExit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13270) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.BuyCover, instrument, text);
      signal.StrategyFill = true;
      signal.StrategyPrice = price;
      if (!this.HasPosition || this.Position.Side != PositionSide.Short)
      {
        signal.Status = SignalStatus.Rejected;
        signal.Rejecter = ComponentType.Exit;
      }
      return this.Strategy.BgvpSPpUAD(signal);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(Instrument instrument, double price)
    {
      return this.ShortExit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13292) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(double price, string text)
    {
      return this.LongExit(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(double price)
    {
      return this.LongExit(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(double price, string text)
    {
      return this.ShortExit(this.instrument, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ShortExit(double price)
    {
      this.ShortExit(this.instrument, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode)
    {
      return this.LongExit(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13316) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.BuyCover, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode)
    {
      return this.ShortExit(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13338) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(FillOnBarMode mode, string text)
    {
      return this.LongExit(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder LongExit(FillOnBarMode mode)
    {
      return this.LongExit(this.instrument, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder ShortExit(FillOnBarMode mode, string text)
    {
      return this.ShortExit(this.instrument, mode, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ShortExit(FillOnBarMode mode)
    {
      this.ShortExit(this.instrument, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument)
    {
      return this.Buy(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13362) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, double price)
    {
      return this.Buy(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13374) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
    {
      return this.Buy(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13386) + this.Strategy.Name);
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
    public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Limit, SignalSide.Buy, instrument, text)
      {
        LimitPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(Instrument instrument, double price)
    {
      return this.BuyLimit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13398) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyLimit(double price, string text)
    {
      return this.BuyLimit(this.instrument, price, text);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Stop, SignalSide.Buy, instrument, text)
      {
        StopPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStop(Instrument instrument, double price)
    {
      return this.BuyStop(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13420) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.StopLimit, SignalSide.Buy, instrument, text)
      {
        StopPrice = stopPrice,
        LimitPrice = limitPrice
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.BuyStopLimit(instrument, stopPrice, limitPrice, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13440) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.TrailingStop, SignalSide.Buy, this.instrument, text)
      {
        StopPrice = delta
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder BuyTrailingStop(double delta)
    {
      return this.BuyTrailingStop(delta, string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(13470), (object) this.Strategy.Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument)
    {
      return this.Sell(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13512) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        StrategyFill = true,
        StrategyPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, double price)
    {
      return this.Sell(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13526) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(double price, string text)
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
    {
      return this.Sell(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13540) + this.Strategy.Name);
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
    public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Limit, SignalSide.Sell, instrument, text)
      {
        LimitPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(Instrument instrument, double price)
    {
      return this.SellLimit(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13554) + this.Strategy.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellLimit(double price, string text)
    {
      return this.SellLimit(this.instrument, price, text);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Stop, SignalSide.Sell, instrument, text)
      {
        StopPrice = price
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStop(Instrument instrument, double price)
    {
      return this.SellStop(instrument, price, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13578) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.StopLimit, SignalSide.Sell, instrument, text)
      {
        StopPrice = stopPrice,
        LimitPrice = limitPrice
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.SellStopLimit(instrument, stopPrice, limitPrice, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13600) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.TrailingStop, SignalSide.Sell, this.instrument, text)
      {
        StopPrice = delta
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellTrailingStop(double delta)
    {
      return this.SellTrailingStop(delta, string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(13632), (object) this.Strategy.Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.SellShort, instrument, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument)
    {
      return this.SellShort(instrument, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13676) + this.Strategy.Name);
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
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.SellShort, instrument, text)
      {
        Fuwj5CvMiW = true,
        R2djQy947W = mode
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
    {
      return this.Sell(instrument, mode, USaG3GpjZagj1iVdv4u.Y4misFk9D9(13700) + this.Strategy.Name);
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
