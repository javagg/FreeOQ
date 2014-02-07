using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
	public class MarketOrder : SingleOrder
	{
		public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, string text) : base()
		{
			this.OrdType = OrdType.Market;
			this.Provider = provider;
			this.Portfolio = portfolio;
			this.Instrument = instrument;
			this.Side = side;
			this.OrderQty = qty;
			this.Text = text;
		}

		public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty)
			: this(provider, portfolio, instrument, side, qty, null)
		{
		}

		public MarketOrder(Instrument instrument, Side side, double qty, string text)
			: this(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, text)
		{
		}

		public MarketOrder(Instrument instrument, Side side, double qty)
			:this(instrument, side, qty, null)
		{
		}

		public MarketOrder(string symbol, Side side, double qty, string text)
			: this((Instrument)null, side, qty, text)
		{
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
			{
				throw new ArgumentException(symbol);
			}
		}

		public MarketOrder(string symbol, Side side, double qty)
			: this(symbol, side, qty, null)
		{
		}
	}
}
