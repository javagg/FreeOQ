using LI7wYoxjcQSGYmaiNa;
using RZ1j9O1DCcsDf19ge6;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class StopOrder : SingleOrder
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Stop;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double stopPx)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Stop;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder(Instrument instrument, Side side, double qty, double stopPx, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Stop;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder(Instrument instrument, Side side, double qty, double stopPx)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Stop;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder(string symbol, Side side, double qty, double stopPx, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Stop;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(320) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(410));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopOrder(string symbol, Side side, double qty, double stopPx)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Stop;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(480) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(570));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.StopPx = stopPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private StopOrder()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
