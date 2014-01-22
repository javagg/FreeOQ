using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class TrailingStopLimitOrder : SingleOrder
  {
    
		public TrailingStopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double delta, double stopPrice, double limitPrice):base()
    {
      this.OrdType = OrdType.TrailingStopLimit;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.TrailingAmt = delta;
      this.StopPx = stopPrice;
      this.Price = limitPrice;
    }

    
		public TrailingStopLimitOrder(Instrument instrument, Side side, double qty, double delta, double stopPrice, double limitPrice): this(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, delta, stopPrice, limitPrice)
    {
    }
  }
}
