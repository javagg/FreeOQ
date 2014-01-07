using RZ1j9O1DCcsDf19ge6;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class TrailingStopLimitOrder : SingleOrder
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingStopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double delta, double stopPrice, double limitPrice)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingStopLimitOrder(Instrument instrument, Side side, double qty, double delta, double stopPrice, double limitPrice)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      this.\u002Ector(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, delta, stopPrice, limitPrice);
    }
  }
}
