using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
	public class StopLimitOrder : SingleOrder
	{
		public StopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, double stopPx, string text) : base()
		{
			this.OrdType = OrdType.StopLimit;
			this.Provider = provider;
			this.Portfolio = portfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.StopPx = stopPx;
			this.Text = text;
		}

		public StopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, double stopPx) : base()
		{
			this.OrdType = OrdType.StopLimit;
			this.Provider = provider;
			this.Portfolio = portfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.StopPx = stopPx;
		}

		public StopLimitOrder(Instrument instrument, Side side, double qty, double price, double stopPx, string text) : base()
		{
			this.OrdType = OrdType.StopLimit;
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.StopPx = stopPx;
			this.Text = text;
		}

		public StopLimitOrder(Instrument instrument, Side side, double qty, double price, double stopPx) : base()
		{
			this.OrdType = OrdType.StopLimit;
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.StopPx = stopPx;
		}

		public StopLimitOrder(string symbol, Side side, double qty, double price, double stopPx, string text) : base()
		{
			this.OrdType = OrdType.StopLimit;
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
				throw new ArgumentException(symbol);
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.StopPx = stopPx;
			this.Text = text;
		}

		public StopLimitOrder(string symbol, Side side, double qty, double price, double stopPx) : base()
		{
			this.OrdType = OrdType.StopLimit;
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
				throw new ArgumentException(symbol);
			this.Provider = ProviderManager.DefaultExecutionProvider;
			this.Portfolio = PortfolioManager.DefaultPortfolio;
			this.Side = side;
			this.OrderQty = qty;
			this.Price = price;
			this.StopPx = stopPx;
		}

		private StopLimitOrder() : base()
		{
		}
	}
}
