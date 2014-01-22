using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class MarketOrder : SingleOrder
  {
		public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, string text):base()
    {

      this.OrdType = OrdType.Market;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Text = text;
    }

		public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty):base()
    {

      this.OrdType = OrdType.Market;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
    }

		public MarketOrder(Instrument instrument, Side side, double qty, string text):base()
    {

      this.OrdType = OrdType.Market;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Text = text;
    }

		public MarketOrder(Instrument instrument, Side side, double qty):base()
    {
      this.OrdType = OrdType.Market;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
    }

		public MarketOrder(string symbol, Side side, double qty, string text):base()
    {

      this.OrdType = OrdType.Market;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(symbol);
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.Text = text;
    }

		public MarketOrder(string symbol, Side side, double qty):base()
    {
      this.OrdType = OrdType.Market;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(symbol);
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
    }

		private MarketOrder():base()
    {

    }
  }
}
