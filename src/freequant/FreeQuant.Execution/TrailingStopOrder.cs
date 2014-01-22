using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class TrailingStopOrder : SingleOrder
  {
    
		public TrailingStopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double delta):base()
    {

      this.OrdType = OrdType.TrailingStop;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.TrailingAmt = delta;
    }

    
		public TrailingStopOrder(Instrument instrument, Side side, double qty, double delta): this(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, delta)
    {
    }

    
		private TrailingStopOrder():base()
    {
    }
  }
}
