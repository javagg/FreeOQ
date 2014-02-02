using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;

namespace FreeQuant.Trading
{
	[StrategyComponent("{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}", ComponentType.ATSComponent, Description = "", Name = "Default_ATSComponent")]
	public class ATSComponent : ATSStrategySingleComponent
	{
		public const string GUID = "{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}";

		public ATSComponent() : base()
		{
		}

		public virtual void OnStopStatusChanged(ATSStop stop)
		{
		}

		public virtual void OnStopCanceled(ATSStop stop)
		{
		}

		public virtual void OnStopExecuted(ATSStop stop)
		{
		}

		public ATSStop SetStop(Position position, double level, StopType type, StopMode mode)
		{
			ATSStop atsStop = new ATSStop(position, level, type, mode);
			this.Strategy.nPMi9oJHY7(atsStop);
			return atsStop;
		}

		public ATSStop SetStop(double level, StopType type, StopMode mode)
		{
			return this.SetStop(this.Position, level, type, mode);
		}

		public ATSStop SetStop(Position position, DateTime dateTime)
		{
			ATSStop atsStop = new ATSStop(position, dateTime);
			this.Strategy.nPMi9oJHY7(atsStop);
			return atsStop;
		}

		public ATSStop SetStop(DateTime dateTime)
		{
			return this.SetStop(this.Position, dateTime);
		}

		public MarketOrder MarketOrder(Instrument instrument, Side side, double qty, string text)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)marketOrder);
			return marketOrder;
		}

		public MarketOrder SendMarketOrder(Instrument instrument, Side side, double qty, string text)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)marketOrder);
			marketOrder.Send();
			return marketOrder;
		}

		public MarketOrder MarketOrder(Instrument instrument, Side side, double qty)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
			this.Strategy.EB2iXBUSFK((SingleOrder)marketOrder);
			return marketOrder;
		}

		public MarketOrder SendMarketOrder(Instrument instrument, Side side, double qty)
		{
			MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
			this.Strategy.EB2iXBUSFK((SingleOrder)marketOrder);
			marketOrder.Send();
			return marketOrder;
		}

		public MarketOrder MarketOrder(Side side, double qty, string text)
		{
			return this.MarketOrder(this.Instrument, side, qty, text);
		}

		public MarketOrder SendMarketOrder(Side side, double qty, string text)
		{
			return this.SendMarketOrder(this.Instrument, side, qty, text);
		}

		public MarketOrder MarketOrder(Side side, double qty)
		{
			return this.MarketOrder(this.Instrument, side, qty);
		}

		public MarketOrder SendMarketOrder(Side side, double qty)
		{
			return this.SendMarketOrder(this.Instrument, side, qty);
		}

		public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)limitOrder);
			return limitOrder;
		}

		public LimitOrder SendLimitOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)limitOrder);
			limitOrder.Send();
			return limitOrder;
		}

		public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
			this.Strategy.EB2iXBUSFK((SingleOrder)limitOrder);
			return limitOrder;
		}

		public LimitOrder SendLimitOrder(Instrument instrument, Side side, double qty, double price)
		{
			LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
			this.Strategy.EB2iXBUSFK((SingleOrder)limitOrder);
			limitOrder.Send();
			return limitOrder;
		}

		public LimitOrder LimitOrder(Side side, double qty, double price, string text)
		{
			return this.LimitOrder(this.Instrument, side, qty, price, text);
		}

		public LimitOrder SendLimitOrder(Side side, double qty, double price, string text)
		{
			return this.SendLimitOrder(this.Instrument, side, qty, price, text);
		}

		public LimitOrder LimitOrder(Side side, double qty, double price)
		{
			return this.LimitOrder(this.Instrument, side, qty, price);
		}

		public LimitOrder SendLimitOrder(Side side, double qty, double price)
		{
			return this.SendLimitOrder(this.Instrument, side, qty, price);
		}

		public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopOrder);
			return stopOrder;
		}

		public StopOrder SendStopOrder(Instrument instrument, Side side, double qty, double price, string text)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopOrder);
			stopOrder.Send();
			return stopOrder;
		}

		public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopOrder);
			return stopOrder;
		}

		public StopOrder SendStopOrder(Instrument instrument, Side side, double qty, double price)
		{
			StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopOrder);
			stopOrder.Send();
			return stopOrder;
		}

		public StopOrder StopOrder(Side side, double qty, double price, string text)
		{
			return this.StopOrder(this.Instrument, side, qty, price, text);
		}

		public StopOrder SendStopOrder(Side side, double qty, double price, string text)
		{
			return this.SendStopOrder(this.Instrument, side, qty, price, text);
		}

		public StopOrder StopOrder(Side side, double qty, double price)
		{
			return this.StopOrder(this.Instrument, side, qty, price);
		}

		public StopOrder SendStopOrder(Side side, double qty, double price)
		{
			return this.SendStopOrder(this.Instrument, side, qty, price);
		}

		public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopLimitOrder);
			return stopLimitOrder;
		}

		public StopLimitOrder SendStopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice, text);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopLimitOrder);
			stopLimitOrder.Send();
			return stopLimitOrder;
		}

		public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopLimitOrder);
			return stopLimitOrder;
		}

		public StopLimitOrder SendStopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
		{
			StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
			this.Strategy.EB2iXBUSFK((SingleOrder)stopLimitOrder);
			stopLimitOrder.Send();
			return stopLimitOrder;
		}

		public StopLimitOrder StopLimitOrder(Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.StopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice, text);
		}

		public StopLimitOrder SendStopLimitOrder(Side side, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice, text);
		}

		public StopLimitOrder StopLimitOrder(Side side, double qty, double limitPrice, double stopPrice)
		{
			return this.StopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice);
		}

		public StopLimitOrder SendStopLimitOrder(Side side, double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(this.Instrument, side, qty, limitPrice, stopPrice);
		}

		public TrailingStopOrder TrailingStopOrder(Side side, double qty, double delta)
		{
			TrailingStopOrder trailingStopOrder = new TrailingStopOrder(this.instrument, side, qty, delta);
			this.Strategy.EB2iXBUSFK((SingleOrder)trailingStopOrder);
			return trailingStopOrder;
		}

		public TrailingStopLimitOrder TrailingStopLimitOrder(Side side, double qty, double delta, double stopPrice, double limitPrice)
		{
			TrailingStopLimitOrder trailingStopLimitOrder = new TrailingStopLimitOrder(this.instrument, side, qty, delta, stopPrice, limitPrice);
			this.Strategy.EB2iXBUSFK((SingleOrder)trailingStopLimitOrder);
			return trailingStopLimitOrder;
		}

		public MarketOrder Buy(Instrument instrument, double Qty, string text)
		{
			return this.SendMarketOrder(instrument, Side.Buy, Qty, text);
		}

		public MarketOrder Buy(Instrument instrument, double Qty)
		{
			return this.SendMarketOrder(instrument, Side.Buy, Qty);
		}

		public MarketOrder Buy(double Qty, string text)
		{
			return this.SendMarketOrder(Side.Buy, Qty, text);
		}

		public MarketOrder Buy(double Qty)
		{
			return this.SendMarketOrder(Side.Buy, Qty);
		}

		public MarketOrder Sell(Instrument instrument, double Qty, string text)
		{
			return this.SendMarketOrder(instrument, Side.Sell, Qty, text);
		}

		public MarketOrder Sell(Instrument instrument, double Qty)
		{
			return this.SendMarketOrder(instrument, Side.Sell, Qty);
		}

		public MarketOrder Sell(double Qty, string text)
		{
			return this.SendMarketOrder(Side.Sell, Qty, text);
		}

		public MarketOrder Sell(double Qty)
		{
			return this.SendMarketOrder(Side.Sell, Qty);
		}

		public LimitOrder BuyLimit(Instrument instrument, double qty, double price, string text)
		{
			return this.SendLimitOrder(instrument, Side.Buy, qty, price, text);
		}

		public LimitOrder BuyLimit(Instrument instrument, double qty, double price)
		{
			return this.SendLimitOrder(instrument, Side.Buy, qty, price);
		}

		public LimitOrder BuyLimit(double qty, double price, string text)
		{
			return this.SendLimitOrder(Side.Buy, qty, price, text);
		}

		public LimitOrder BuyLimit(double qty, double price)
		{
			return this.SendLimitOrder(Side.Buy, qty, price);
		}

		public LimitOrder SellLimit(Instrument instrument, double qty, double price, string text)
		{
			return this.SendLimitOrder(instrument, Side.Sell, qty, price, text);
		}

		public LimitOrder SellLimit(Instrument instrument, double qty, double price)
		{
			return this.SendLimitOrder(instrument, Side.Sell, qty, price);
		}

		public LimitOrder SellLimit(double qty, double price, string text)
		{
			return this.SendLimitOrder(Side.Sell, qty, price, text);
		}

		public LimitOrder SellLimit(double qty, double price)
		{
			return this.SendLimitOrder(Side.Sell, qty, price);
		}

		public StopOrder BuyStop(Instrument instrument, double qty, double price, string text)
		{
			return this.SendStopOrder(instrument, Side.Buy, qty, price, text);
		}

		public StopOrder BuyStop(Instrument instrument, double qty, double price)
		{
			return this.SendStopOrder(instrument, Side.Buy, qty, price);
		}

		public StopOrder BuyStop(double qty, double price, string text)
		{
			return this.SendStopOrder(Side.Buy, qty, price, text);
		}

		public StopOrder BuyStop(double qty, double price)
		{
			return this.SendStopOrder(Side.Buy, qty, price);
		}

		public StopOrder SellStop(Instrument instrument, double qty, double price, string text)
		{
			return this.SendStopOrder(instrument, Side.Sell, qty, price, text);
		}

		public StopOrder SellStop(Instrument instrument, double qty, double price)
		{
			return this.SendStopOrder(instrument, Side.Sell, qty, price);
		}

		public StopOrder SellStop(double qty, double price, string text)
		{
			return this.SendStopOrder(Side.Sell, qty, price, text);
		}

		public StopOrder SellStop(double qty, double price)
		{
			return this.SendStopOrder(Side.Sell, qty, price);
		}

		public StopLimitOrder BuyStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(instrument, Side.Buy, qty, limitPrice, stopPrice, text);
		}

		public StopLimitOrder BuyStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(instrument, Side.Buy, qty, limitPrice, stopPrice);
		}

		public StopLimitOrder BuyStopLimit(double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(Side.Buy, qty, limitPrice, stopPrice, text);
		}

		public StopLimitOrder BuyStopLimit(double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(Side.Buy, qty, limitPrice, stopPrice);
		}

		public StopLimitOrder SellStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(instrument, Side.Sell, qty, limitPrice, stopPrice, text);
		}

		public StopLimitOrder SellStopLimit(Instrument instrument, double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(instrument, Side.Sell, qty, limitPrice, stopPrice);
		}

		public StopLimitOrder SellStopLimit(double qty, double limitPrice, double stopPrice, string text)
		{
			return this.SendStopLimitOrder(Side.Sell, qty, limitPrice, stopPrice, text);
		}

		public StopLimitOrder SellStopLimit(double qty, double limitPrice, double stopPrice)
		{
			return this.SendStopLimitOrder(Side.Sell, qty, limitPrice, stopPrice);
		}
	}
}
