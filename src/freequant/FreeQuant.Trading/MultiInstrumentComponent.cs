using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;

namespace FreeQuant.Trading
{
	public abstract class MultiInstrumentComponent : ComponentBase
	{
		public virtual void OnMarketData(Instrument instrument, IMarketData data)
		{
		}

		public virtual void OnBar(Instrument instrument, Bar bar)
		{
		}

		public virtual void OnBarOpen(Instrument instrument, Bar bar)
		{
		}

		public virtual void OnTrade(Instrument instrument, Trade trade)
		{
		}

		public virtual void OnQuote(Instrument instrument, Quote quote)
		{
		}

		public virtual void OnMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
		}

		public virtual void OnFundamental(Instrument instrument, Fundamental fundamental)
		{
		}

		public virtual void OnCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
		}

		public virtual void OnPositionOpened(Position position)
		{
		}

		public virtual void OnPositionClosed(Position position)
		{
		}

		public virtual void OnPositionChanged(Position position)
		{
		}

		public virtual void OnPositionValueChanged(Position position)
		{
		}

		public virtual void OnNewOrder(SingleOrder order)
		{
		}

		public virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
		}

		public virtual void OnOrderPartiallyFilled(SingleOrder order)
		{
		}

		public virtual void OnOrderStatusChanged(SingleOrder order)
		{
		}

		public virtual void OnOrderDone(SingleOrder order)
		{
		}

		public virtual void OnOrderFilled(SingleOrder order)
		{
		}

		public virtual void OnOrderCancelled(SingleOrder order)
		{
		}

		public virtual void OnOrderRejected(SingleOrder order)
		{
		}

		public virtual void OnProviderConnected(IProvider provider)
		{
		}

		public virtual void OnProviderDisconnected(IProvider provider)
		{
		}

		public virtual void OnProviderError(IProvider provider, int id, int code, string message)
		{
		}
	}
}
