// Type: SmartQuant.Trading.SingleInstrumentComponent
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public abstract class SingleInstrumentComponent : ComponentBase
  {
    protected Instrument instrument;

    [Browsable(false)]
    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.instrument;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.instrument = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SingleInstrumentComponent()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMarketData(IMarketData data)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnBar(Bar bar)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnBarOpen(Bar bar)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnTrade(Trade trade)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnQuote(Quote quote)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMarketDepth(MarketDepth marketDepth)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFundamental(Fundamental fundamental)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCorporateAction(CorporateAction corporateAction)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnNews(FIXNews news)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionOpened()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionClosed()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionChanged()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPositionValueChanged()
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
  }
}
