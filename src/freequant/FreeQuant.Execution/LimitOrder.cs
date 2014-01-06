// Type: SmartQuant.Execution.LimitOrder
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
  public class LimitOrder : SingleOrder
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Limit;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder(IExecutionProvider provider, Portfolio portfolio, Instrument instrument, Side side, double qty, double price)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Limit;
      this.Provider = provider;
      this.Portfolio = portfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder(Instrument instrument, Side side, double qty, double price, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Limit;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder(Instrument instrument, Side side, double qty, double price)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Limit;
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Instrument = instrument;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder(string symbol, Side side, double qty, double price, string text)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Limit;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(0) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(90));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitOrder(string symbol, Side side, double qty, double price)
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = OrdType.Limit;
      this.Instrument = InstrumentManager.Instruments[symbol];
      if (this.Instrument == null)
        throw new ArgumentException(p9eligYgcNHo8cieFV.RdvEpVlLR7(160) + symbol + p9eligYgcNHo8cieFV.RdvEpVlLR7(250));
      this.Provider = ProviderManager.DefaultExecutionProvider;
      this.Portfolio = PortfolioManager.DefaultPortfolio;
      this.Side = side;
      this.OrderQty = qty;
      this.Price = price;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private LimitOrder()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
