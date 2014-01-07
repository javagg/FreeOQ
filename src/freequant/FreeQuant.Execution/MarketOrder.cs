using LI7wYoxjcQSGYmaiNa;
using RZ1j9O1DCcsDf19ge6;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class MarketOrder : SingleOrder
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Market;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Market;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder(Instrument instrument, Side side, double qty, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Market;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder(Instrument instrument, Side side, double qty)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Market;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder(string symbol, Side side, double qty, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Market;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(2378) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(2468));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketOrder(string symbol, Side side, double qty)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Market;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(2538) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(2628));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MarketOrder()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
