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

		public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price) : base()
		{
			this.OrdType = OrdType.Limit;
			this.Provider = provider;
			this.Portfolio = portfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
		}

		public LimitOrder(Instrument instrument, Side side, double qty, double price, string text) : base()
		{
			this.OrdType = OrdType.Limit;
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.Text = text;
		}

		public LimitOrder(Instrument instrument, Side side, double qty, double price) : base()
		{
			this.OrdType = OrdType.Limit;
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
		}

		public LimitOrder(string symbol, Side side, double qty, double price, string text) : base()
		{
			this.OrdType = OrdType.Limit;
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
				throw new ArgumentException(symbol);
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.Text = text;
		}

		public LimitOrder(string symbol, Side side, double qty, double price) : base()
		{
			this.OrdType = OrdType.Limit;
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
				throw new ArgumentException(symbol);
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
		}

		private LimitOrder() : base()
		{
		}
	}
}
