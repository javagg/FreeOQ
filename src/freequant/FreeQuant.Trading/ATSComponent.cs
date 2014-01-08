using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}", ComponentType.ATSComponent, Description = "", Name = "Default_ATSComponent")]
  public class ATSComponent : ATSStrategySingleComponent
  {
    public const string GUID = "{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStopStatusChanged(ATSStop stop)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStopCanceled(ATSStop stop)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStopExecuted(ATSStop stop)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop SetStop(Position position, double level, StopType type, StopMode mode)
    {
      ATSStop atsStop = new ATSStop(position, level, type, mode);
      this.Strategy.nPMi9oJHY7(atsStop);
      return atsStop;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop SetStop(double level, StopType type, StopMode mode)
    {
      return this.SetStop(this.Position, level, type, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop SetStop(Position position, DateTime dateTime)
    {
      ATSStop atsStop = new ATSStop(position, dateTime);
      this.Strategy.nPMi9oJHY7(atsStop);
      return atsStop;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop SetStop(DateTime dateTime)
    {
      return this.SetStop(this.Position, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder MarketOrder(Instrument instrument, Side side, double qty, string text)
    {
      MarketOrder marketOrder = new MarketOrder(instrument, side, qty, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) marketOrder);
      return marketOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder SendMarketOrder(Instrument instrument, Side side, double qty, string text)
    {
      MarketOrder marketOrder = new MarketOrder(instrument, side, qty, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) marketOrder);
      marketOrder.Send();
      return marketOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder MarketOrder(Instrument instrument, Side side, double qty)
    {
      MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
      this.Strategy.EB2iXBUSFK((SingleOrder) marketOrder);
      return marketOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder SendMarketOrder(Instrument instrument, Side side, double qty)
    {
      MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
      this.Strategy.EB2iXBUSFK((SingleOrder) marketOrder);
      marketOrder.Send();
      return marketOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder MarketOrder(Side side, double qty, string text)
    {
      return this.MarketOrder(this.Instrument, side, qty, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder SendMarketOrder(Side side, double qty, string text)
    {
      return this.SendMarketOrder(this.Instrument, side, qty, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder MarketOrder(Side side, double qty)
    {
      return this.MarketOrder(this.Instrument, side, qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder SendMarketOrder(Side side, double qty)
    {
      return this.SendMarketOrder(this.Instrument, side, qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price, string text)
    {
      LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) limitOrder);
      return limitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SendLimitOrder(Instrument instrument, Side side, double qty, double price, string text)
    {
      LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) limitOrder);
      limitOrder.Send();
      return limitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price)
    {
      LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
      this.Strategy.EB2iXBUSFK((SingleOrder) limitOrder);
      return limitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SendLimitOrder(Instrument instrument, Side side, double qty, double price)
    {
      LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
      this.Strategy.EB2iXBUSFK((SingleOrder) limitOrder);
      limitOrder.Send();
      return limitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder LimitOrder(Side side, double qty, double price, string text)
    {
      return this.LimitOrder(this.Instrument, side, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SendLimitOrder(Side side, double qty, double price, string text)
    {
      return this.SendLimitOrder(this.Instrument, side, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder LimitOrder(Side side, double qty, double price)
    {
      return this.LimitOrder(this.Instrument, side, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SendLimitOrder(Side side, double qty, double price)
    {
      return this.SendLimitOrder(this.Instrument, side, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price, string text)
    {
      StopOrder stopOrder = new StopOrder(instrument, side, qty, price, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopOrder);
      return stopOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SendStopOrder(Instrument instrument, Side side, double qty, double price, string text)
    {
      StopOrder stopOrder = new StopOrder(instrument, side, qty, price, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopOrder);
      stopOrder.Send();
      return stopOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price)
    {
      StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopOrder);
      return stopOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SendStopOrder(Instrument instrument, Side side, double qty, double price)
    {
      StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopOrder);
      stopOrder.Send();
      return stopOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder StopOrder(Side side, double qty, double price, string text)
    {
      return this.StopOrder(this.Instrument, side, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SendStopOrder(Side side, double qty, double price, string text)
    {
      return this.SendStopOrder(this.Instrument, side, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder StopOrder(Side side, double qty, double price)
    {
      return this.StopOrder(this.Instrument, side, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SendStopOrder(Side side, double qty, double price)
    {
      return this.SendStopOrder(this.Instrument, side, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice, string text)
    {
      StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopLimitOrder);
      return stopLimitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SendStopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice, string text)
    {
      StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice, text);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopLimitOrder);
      stopLimitOrder.Send();
      return stopLimitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
    {
      StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopLimitOrder);
      return stopLimitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SendStopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
    {
      StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopLimitOrder);
      stopLimitOrder.Send();
      return stopLimitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder StopLimitOrder(Side side, double qty, double limitPrice, double stopPrice, string text)
    {
      return this.StopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SendStopLimitOrder(Side side, double qty, double limitPrice, double stopPrice, string text)
    {
      return this.SendStopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder StopLimitOrder(Side side, double qty, double limitPrice, double stopPrice)
    {
      return this.StopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SendStopLimitOrder(Side side, double qty, double limitPrice, double stopPrice)
    {
      return this.SendStopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingStopOrder TrailingStopOrder(Side side, double qty, double delta)
    {
      TrailingStopOrder trailingStopOrder = new TrailingStopOrder(this.instrument, side, qty, delta);
      this.Strategy.EB2iXBUSFK((SingleOrder) trailingStopOrder);
      return trailingStopOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingStopLimitOrder TrailingStopLimitOrder(Side side, double qty, double delta, double stopPrice, double limitPrice)
    {
      TrailingStopLimitOrder trailingStopLimitOrder = new TrailingStopLimitOrder(this.instrument, side, qty, delta, stopPrice, limitPrice);
      this.Strategy.EB2iXBUSFK((SingleOrder) trailingStopLimitOrder);
      return trailingStopLimitOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Buy(Instrument instrument, double Qty, string text)
    {
      return this.SendMarketOrder(instrument, Side.Buy, Qty, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Buy(Instrument instrument, double Qty)
    {
      return this.SendMarketOrder(instrument, Side.Buy, Qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Buy(double Qty, string text)
    {
      return this.SendMarketOrder(Side.Buy, Qty, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Buy(double Qty)
    {
      return this.SendMarketOrder(Side.Buy, Qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Sell(Instrument instrument, double Qty, string text)
    {
      return this.SendMarketOrder(instrument, Side.Sell, Qty, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Sell(Instrument instrument, double Qty)
    {
      return this.SendMarketOrder(instrument, Side.Sell, Qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Sell(double Qty, string text)
    {
      return this.SendMarketOrder(Side.Sell, Qty, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder Sell(double Qty)
    {
      return this.SendMarketOrder(Side.Sell, Qty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder BuyLimit(Instrument instrument, double qty, double price, string text)
    {
      return this.SendLimitOrder(instrument, Side.Buy, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder BuyLimit(Instrument instrument, double qty, double price)
    {
      return this.SendLimitOrder(instrument, Side.Buy, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder BuyLimit(double qty, double price, string text)
    {
      return this.SendLimitOrder(Side.Buy, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder BuyLimit(double qty, double price)
    {
      return this.SendLimitOrder(Side.Buy, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SellLimit(Instrument instrument, double qty, double price, string text)
    {
      return this.SendLimitOrder(instrument, Side.Sell, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SellLimit(Instrument instrument, double qty, double price)
    {
      return this.SendLimitOrder(instrument, Side.Sell, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SellLimit(double qty, double price, string text)
    {
      return this.SendLimitOrder(Side.Sell, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder SellLimit(double qty, double price)
    {
      return this.SendLimitOrder(Side.Sell, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder BuyStop(Instrument instrument, double qty, double price, string text)
    {
      return this.SendStopOrder(instrument, Side.Buy, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder BuyStop(Instrument instrument, double qty, double price)
    {
      return this.SendStopOrder(instrument, Side.Buy, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder BuyStop(double qty, double price, string text)
    {
      return this.SendStopOrder(Side.Buy, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder BuyStop(double qty, double price)
    {
      return this.SendStopOrder(Side.Buy, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SellStop(Instrument instrument, double qty, double price, string text)
    {
      return this.SendStopOrder(instrument, Side.Sell, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SellStop(Instrument instrument, double qty, double price)
    {
      return this.SendStopOrder(instrument, Side.Sell, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SellStop(double qty, double price, string text)
    {
      return this.SendStopOrder(Side.Sell, qty, price, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder SellStop(double qty, double price)
    {
      return this.SendStopOrder(Side.Sell, qty, price);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder BuyStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice, string text)
    {
      return this.SendStopLimitOrder(instrument, Side.Buy, qty, limitPrice, stopPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder BuyStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice)
    {
      return this.SendStopLimitOrder(instrument, Side.Buy, qty, limitPrice, stopPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder BuyStopLimit(double qty, double limitPrice, double stopPrice, string text)
    {
      return this.SendStopLimitOrder(Side.Buy, qty, limitPrice, stopPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder BuyStopLimit(double qty, double limitPrice, double stopPrice)
    {
      return this.SendStopLimitOrder(Side.Buy, qty, limitPrice, stopPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SellStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice, string text)
    {
      return this.SendStopLimitOrder(instrument, Side.Sell, qty, limitPrice, stopPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SellStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice)
    {
      return this.SendStopLimitOrder(instrument, Side.Sell, qty, limitPrice, stopPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SellStopLimit(double qty, double limitPrice, double stopPrice, string text)
    {
      return this.SendStopLimitOrder(Side.Sell, qty, limitPrice, stopPrice, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder SellStopLimit(double qty, double limitPrice, double stopPrice)
    {
      return this.SendStopLimitOrder(Side.Sell, qty, limitPrice, stopPrice);
    }
  }
}
