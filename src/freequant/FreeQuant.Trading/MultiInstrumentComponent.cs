
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public abstract class MultiInstrumentComponent : ComponentBase
  {

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
