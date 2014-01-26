using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public abstract class SingleInstrumentComponent : ComponentBase
  {
    protected Instrument instrument;

    [Browsable(false)]
    public Instrument Instrument
    {
       get
      {
        return this.instrument;
      }
       set
      {
        this.instrument = value;
      }
    }

    
		protected SingleInstrumentComponent():base()
    {
    }

    
    public virtual void OnMarketData(IMarketData data)
    {
    }

    
    public virtual void OnBar(Bar bar)
    {
    }

    
    public virtual void OnBarOpen(Bar bar)
    {
    }

    
    public virtual void OnTrade(Trade trade)
    {
    }

    
    public virtual void OnQuote(Quote quote)
    {
    }

    
    public virtual void OnMarketDepth(MarketDepth marketDepth)
    {
    }

    
    public virtual void OnFundamental(Fundamental fundamental)
    {
    }

    
    public virtual void OnCorporateAction(CorporateAction corporateAction)
    {
    }

    
    public virtual void OnNews(FIXNews news)
    {
    }

    
    public virtual void OnPositionOpened()
    {
    }

    
    public virtual void OnPositionClosed()
    {
    }

    
    public virtual void OnPositionChanged()
    {
    }

    
    public virtual void OnPositionValueChanged()
    {
    }

    
    public virtual void OnNewOrder(SingleOrder order)
    {
    }

    
    public virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
    }

    
    public virtual void OnOrderPartiallyFilled(SingleOrder order)
    {
    }

    
    public virtual void OnOrderStatusChanged(SingleOrder order)
    {
    }

    
    public virtual void OnOrderDone(SingleOrder order)
    {
    }

    
    public virtual void OnOrderFilled(SingleOrder order)
    {
    }

    
    public virtual void OnOrderCancelled(SingleOrder order)
    {
    }

    
    public virtual void OnOrderRejected(SingleOrder order)
    {
    }
  }
}
