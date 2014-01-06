// Type: SmartQuant.Execution.StopLimitOrder
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using LI7wYoxjcQSGYmaiNa;
using RZ1j9O1DCcsDf19ge6;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Execution
{
  public class StopLimitOrder : SingleOrder
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, double stopPx, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.StopLimit;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.StopPx = stopPx;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, double stopPx)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.StopLimit;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.StopPx = stopPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder(Instrument instrument, Side side, double qty, double price, double stopPx, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.StopLimit;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.StopPx = stopPx;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder(Instrument instrument, Side side, double qty, double price, double stopPx)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.StopLimit;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.StopPx = stopPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder(string symbol, Side side, double qty, double price, double stopPx, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.StopLimit;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(2058) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(2148));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.StopPx = stopPx;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopLimitOrder(string symbol, Side side, double qty, double price, double stopPx)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.StopLimit;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(2218) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(2308));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.StopPx = stopPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private StopLimitOrder()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
