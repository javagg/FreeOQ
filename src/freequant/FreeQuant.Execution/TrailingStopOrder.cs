using RZ1j9O1DCcsDf19ge6;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class TrailingStopOrder : SingleOrder
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingStopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double delta)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.TrailingStop;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.TrailingAmt = delta;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingStopOrder(Instrument instrument, Side side, double qty, double delta)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      this.\u002Ector(ProviderManager.DefaultExecutionProvider, PortfolioManager.DefaultPortfolio, instrument, side, qty, delta);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TrailingStopOrder()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
