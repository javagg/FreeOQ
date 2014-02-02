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

    
		public Exit():base()
    {
    }

    
    public virtual SingleOrder EmitSignal(Signal signal)
    {
      return this.Strategy.BgvpSPpUAD(signal);
    }

    
    public virtual SingleOrder LongExit(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return null;
      Signal signal = new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text);
      if (!this.HasPosition || this.Position.Side != PositionSide.Long)
      {
        signal.Status = SignalStatus.Rejected;
        signal.Rejecter = ComponentType.Exit;
      }
      return this.Strategy.BgvpSPpUAD(signal);
    }

    
    public virtual SingleOrder LongExit(Instrument instrument)
    {
      return this.LongExit(instrument, this.Strategy.Name);
    }

    
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

    
    public virtual SingleOrder ShortExit(Instrument instrument)
    {
      return this.ShortExit(instrument, this.Strategy.Name);
    }

    
    public virtual SingleOrder LongExit(string text)
    {
      return this.LongExit(this.instrument, text);
    }

    
    public virtual SingleOrder LongExit()
    {
      return this.LongExit(this.instrument);
    }

    
    public virtual SingleOrder ShortExit(string text)
    {
      return this.ShortExit(this.instrument, text);
    }

    
    public virtual void ShortExit()
    {
      this.ShortExit(this.instrument);
    }

    
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

    
    public virtual SingleOrder LongExit(Instrument instrument, double price)
    {
      return this.LongExit(instrument, price,  this.Strategy.Name);
    }

    
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

    
    public virtual SingleOrder ShortExit(Instrument instrument, double price)
    {
      return this.ShortExit(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder LongExit(double price, string text)
    {
      return this.LongExit(this.instrument, price, text);
    }

    
    public virtual SingleOrder LongExit(double price)
    {
      return this.LongExit(this.instrument, price);
    }

    
    public virtual SingleOrder ShortExit(double price, string text)
    {
      return this.ShortExit(this.instrument, price, text);
    }

    
    public virtual void ShortExit(double price)
    {
      this.ShortExit(this.instrument, price);
    }

    
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

    
    public virtual SingleOrder LongExit(Instrument instrument, FillOnBarMode mode)
    {
      return this.LongExit(instrument, mode,  this.Strategy.Name);
    }

    
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

    
    public virtual SingleOrder ShortExit(Instrument instrument, FillOnBarMode mode)
    {
      return this.ShortExit(instrument, mode,  this.Strategy.Name);
    }

    
    public virtual SingleOrder LongExit(FillOnBarMode mode, string text)
    {
      return this.LongExit(this.instrument, mode, text);
    }

    
    public virtual SingleOrder LongExit(FillOnBarMode mode)
    {
      return this.LongExit(this.instrument, mode);
    }

    
    public virtual SingleOrder ShortExit(FillOnBarMode mode, string text)
    {
      return this.ShortExit(this.instrument, mode, text);
    }

    
    public virtual void ShortExit(FillOnBarMode mode)
    {
      this.ShortExit(this.instrument, mode);
    }

    
    public virtual SingleOrder Buy(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Buy, instrument, text));
    }

    
    public virtual SingleOrder Buy(Instrument instrument)
    {
      return this.Buy(instrument, this.Strategy.Name);
    }

    
    public virtual SingleOrder Buy(string text)
    {
      return this.Buy(this.instrument, text);
    }

    
    public virtual SingleOrder Buy()
    {
      return this.Buy(this.instrument);
    }

    
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

    
    public virtual SingleOrder Buy(Instrument instrument, double price)
    {
      return this.Buy(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder Buy(double price, string text)
    {
      return this.Buy(this.instrument, price, text);
    }

    
    public virtual SingleOrder Buy(double price)
    {
      return this.Buy(this.instrument, price);
    }

    
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

    
    public virtual SingleOrder Buy(Instrument instrument, FillOnBarMode mode)
    {
      return this.Buy(instrument, mode, this.Strategy.Name);
    }

    
    public virtual SingleOrder Buy(string text, FillOnBarMode mode)
    {
      return this.Buy(this.instrument, mode, text);
    }

    
    public virtual SingleOrder Buy(FillOnBarMode mode)
    {
      return this.Buy(this.instrument, mode);
    }

    
    public virtual SingleOrder BuyLimit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Limit, SignalSide.Buy, instrument, text)
      {
        LimitPrice = price
      });
    }

    
    public virtual SingleOrder BuyLimit(Instrument instrument, double price)
    {
      return this.BuyLimit(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder BuyLimit(double price, string text)
    {
      return this.BuyLimit(this.instrument, price, text);
    }

    
    public virtual SingleOrder BuyLimit(double price)
    {
      return this.BuyLimit(this.instrument, price);
    }

    
    public virtual SingleOrder BuyStop(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Stop, SignalSide.Buy, instrument, text)
      {
        StopPrice = price
      });
    }

    
    public virtual SingleOrder BuyStop(Instrument instrument, double price)
    {
      return this.BuyStop(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder BuyStop(double price, string text)
    {
      return this.BuyStop(this.instrument, price, text);
    }

    
    public virtual SingleOrder BuyStop(double price)
    {
      return this.BuyStop(this.instrument, price);
    }

    
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

    
    public virtual SingleOrder BuyStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.BuyStopLimit(instrument, stopPrice, limitPrice, this.Strategy.Name);
    }

    
    public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice, string text)
    {
      return this.BuyStopLimit(this.instrument, stopPrice, limitPrice, text);
    }

    
    public virtual SingleOrder BuyStopLimit(double stopPrice, double limitPrice)
    {
      return this.BuyStopLimit(this.instrument, stopPrice, limitPrice);
    }

    
    public virtual SingleOrder BuyTrailingStop(double delta, string text)
    {
      if (!this.Strategy.IsInstrumentActive(this.instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.TrailingStop, SignalSide.Buy, this.instrument, text)
      {
        StopPrice = delta
      });
    }

    
    public virtual SingleOrder BuyTrailingStop(double delta)
    {
			return this.BuyTrailingStop(delta, string.Format("toioi", (object) this.Strategy.Name));
    }

    
    public virtual SingleOrder Sell(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.Sell, instrument, text));
    }

    
    public virtual SingleOrder Sell(Instrument instrument)
    {
      return this.Sell(instrument,  this.Strategy.Name);
    }

    
    public virtual SingleOrder Sell(string text)
    {
      return this.Sell(this.instrument, text);
    }

    
    public virtual SingleOrder Sell()
    {
      return this.Sell(this.instrument);
    }

    
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

    
    public virtual SingleOrder Sell(Instrument instrument, double price)
    {
      return this.Sell(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder Sell(double price, string text)
    {
      return this.Sell(this.instrument, price, text);
    }

    
    public virtual SingleOrder Sell(double price)
    {
      return this.Sell(this.instrument, price);
    }

    
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

    
    public virtual SingleOrder Sell(Instrument instrument, FillOnBarMode mode)
    {
      return this.Sell(instrument, mode, this.Strategy.Name);
    }

    
    public virtual SingleOrder Sell(string text, FillOnBarMode mode)
    {
      return this.Sell(this.instrument, mode, text);
    }

    
    public virtual SingleOrder Sell(FillOnBarMode mode)
    {
      return this.Sell(this.instrument, mode);
    }

    
    public virtual SingleOrder SellLimit(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Limit, SignalSide.Sell, instrument, text)
      {
        LimitPrice = price
      });
    }

    
    public virtual SingleOrder SellLimit(Instrument instrument, double price)
    {
      return this.SellLimit(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder SellLimit(double price, string text)
    {
      return this.SellLimit(this.instrument, price, text);
    }

    
    public virtual SingleOrder SellLimit(double price)
    {
      return this.SellLimit(this.instrument, price);
    }

    
    public virtual SingleOrder SellStop(Instrument instrument, double price, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Stop, SignalSide.Sell, instrument, text)
      {
        StopPrice = price
      });
    }

    
    public virtual SingleOrder SellStop(Instrument instrument, double price)
    {
      return this.SellStop(instrument, price, this.Strategy.Name);
    }

    
    public virtual SingleOrder SellStop(double price, string text)
    {
      return this.SellStop(this.instrument, price, text);
    }

    
    public virtual SingleOrder SellStop(double price)
    {
      return this.SellStop(this.instrument, price);
    }

    
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

    
    public virtual SingleOrder SellStopLimit(Instrument instrument, double stopPrice, double limitPrice)
    {
      return this.SellStopLimit(instrument, stopPrice, limitPrice, this.Strategy.Name);
    }

    
    public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice, string text)
    {
      return this.SellStopLimit(this.instrument, stopPrice, limitPrice, text);
    }

    
    public virtual SingleOrder SellStopLimit(double stopPrice, double limitPrice)
    {
      return this.SellStopLimit(this.instrument, stopPrice, limitPrice);
    }

    
    public virtual SingleOrder SellTrailingStop(double delta, string text)
    {
      if (!this.Strategy.IsInstrumentActive(this.instrument))
        return (SingleOrder) null;
      return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.TrailingStop, SignalSide.Sell, this.instrument, text)
      {
        StopPrice = delta
      });
    }

    
    public virtual SingleOrder SellTrailingStop(double delta)
    {
			return this.SellTrailingStop(delta, string.Format("ity", (object) this.Strategy.Name));
    }

    
    public virtual SingleOrder SellShort(Instrument instrument, string text)
    {
      if (!this.Strategy.IsInstrumentActive(instrument))
        return (SingleOrder) null;
      else
        return this.Strategy.BgvpSPpUAD(new Signal(Clock.Now, ComponentType.Exit, SignalType.Market, SignalSide.SellShort, instrument, text));
    }

    
    public virtual SingleOrder SellShort(Instrument instrument)
    {
      return this.SellShort(instrument, this.Strategy.Name);
    }

    
    public virtual SingleOrder SellShort(string text)
    {
      return this.SellShort(this.instrument, text);
    }

    
    public virtual SingleOrder SellShort()
    {
      return this.SellShort(this.instrument);
    }

    
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

    
    public virtual SingleOrder SellShort(Instrument instrument, FillOnBarMode mode)
    {
      return this.Sell(instrument, mode, this.Strategy.Name);
    }

    
    public virtual SingleOrder SellShort(string text, FillOnBarMode mode)
    {
      return this.SellShort(this.instrument, mode, text);
    }

    
    public virtual SingleOrder SellShort(FillOnBarMode mode)
    {
      return this.SellShort(this.instrument, mode);
    }
  }
}
