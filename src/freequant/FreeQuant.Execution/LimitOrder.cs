using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;

namespace FreeQuant.Execution
{
	public class LimitOrder : SingleOrder
	{
		public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, string text) : base()
		{
			this.OrdType = OrdType.Limit;
			this.Provider = provider;
			this.Portfolio = portfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.Text = text;
		}

		public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price)
			: this(provider, portfolio, instrument, side, qty, price, null)
		{
		}

		public LimitOrder(Instrument instrument, Side side, double qty, double price, string text)
			: this(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, price, text)
		{
		}

		public LimitOrder(Instrument instrument, Side side, double qty, double price)
			: this(instrument, side, qty, price, null)
		{
		}

		public LimitOrder(string symbol, Side side, double qty, double price, string text)
			:this((Instrument)null, side, qty, price, text)
		{
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
			{
				throw new ArgumentException(symbol);
			}
		}

		public LimitOrder(string symbol, Side side, double qty, double price)
			: this(symbol, side, qty, price, null)
		{
		}

		private LimitOrder() : base()
		{
		}
	}
}
