using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class StopOrder : SingleOrder
  {
    
		public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx, string text):base()
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

    
		public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx):base()
    {
      this.OrdType = OrdType.Stop;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
    }

    
		public StopOrder(Instrument instrument, Side side, double qty, double stopPx, string text):base()
    {
      this.OrdType = OrdType.Stop;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
      this.Text = text;
    }

    
		public StopOrder(Instrument instrument, Side side, double qty, double stopPx):base()
    {
      this.OrdType = OrdType.Stop;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
    }

    
		public StopOrder(string symbol, Side side, double qty, double stopPx, string text):base()
    {
      this.OrdType = OrdType.Stop;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(symbol);
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
      this.Text = text;
    }

    
		public StopOrder(string symbol, Side side, double qty, double stopPx):base()
    {
      this.OrdType = OrdType.Stop;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(symbol);
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
    }

    
		private StopOrder():base()
    {
    }
  }
}
