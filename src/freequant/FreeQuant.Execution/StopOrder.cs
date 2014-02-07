using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;

namespace FreeQuant.Execution
{
	public class StopOrder : SingleOrder
	{
		public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx, string text) : base()
		{
			this.OrdType = OrdType.Stop;
			this.Provider = provider;
			this.Portfolio = portfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.StopPx = stopPx;
			this.Text = text;
		}

		public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx)
			: this(provider, portfolio, instrument, side, qty, stopPx, null)
		{
		}

		public StopOrder(Instrument instrument, Side side, double qty, double stopPx, string text)
			: this(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, stopPx, text)
		{
		}

		public StopOrder(Instrument instrument, Side side, double qty, double stopPx)
			: this(instrument, side, qty, stopPx, null)
		{
		}

		public StopOrder(string symbol, Side side, double qty, double stopPx, string text)
			: this((Instrument)null, side, qty, stopPx, text)
		{
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
			{
				throw new ArgumentException(symbol);
			}
		}

		public StopOrder(string symbol, Side side, double qty, double stopPx)
			: this(symbol, side, qty, stopPx, null)
		{
		}
	}
}
