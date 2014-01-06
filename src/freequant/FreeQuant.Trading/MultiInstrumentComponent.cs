// Type: SmartQuant.Trading.MultiInstrumentComponent
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public abstract class MultiInstrumentComponent : ComponentBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected MultiInstrumentComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMarketData(Instrument instrument, IMarketData data)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnBar(Instrument instrument, Bar bar)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnBarOpen(Instrument instrument, Bar bar)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnTrade(Instrument instrument, Trade trade)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnQuote(Instrument instrument, Quote quote)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFundamental(Instrument instrument, Fundamental fundamental)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionOpened(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionClosed(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionValueChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnNewOrder(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOrderPartiallyFilled(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOrderStatusChanged(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOrderDone(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOrderFilled(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOrderCancelled(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOrderRejected(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnProviderConnected(IProvider provider)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnProviderDisconnected(IProvider provider)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnProviderError(IProvider provider, int id, int code, string message)
    {
    }
  }
}
