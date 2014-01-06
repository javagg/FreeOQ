// Type: SmartQuant.Execution.TrailingStopLimitOrder
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using RZ1j9O1DCcsDf19ge6;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System.Runtime.CompilerServices;

namespace SmartQuant.Execution
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
