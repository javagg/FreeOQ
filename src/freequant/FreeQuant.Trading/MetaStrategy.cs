
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class MetaStrategy : MetaStrategyBase
  {
    private MetaExposureManager k7bROYTXtn;
    private MetaRiskManager kXJRQmVtwY;
    private ExecutionManager XSvR57mV5s;
    private SignalList aNKR2wRnBL;

    [Category("Components")]
//    [TypeConverter(typeof (ComponentTypeConverter))]
//    [Editor(typeof (VloQkVmhmpyuVfn267), typeof (UITypeEditor))]
    public MetaExposureManager MetaExposureManager
    {
      get
      {
        return this.k7bROYTXtn;
      }
      set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException();
        if (this.k7bROYTXtn != null)
        {
          this.k7bROYTXtn.Disconnect();
          this.k7bROYTXtn.MetaStrategyBase = (MetaStrategyBase) null;
        }
        this.k7bROYTXtn = value;
        if (this.k7bROYTXtn != null)
        {
          this.k7bROYTXtn.MetaStrategyBase = (MetaStrategyBase) this;
          this.k7bROYTXtn.Connect();
        }
        this.EmitComponentChanged(ComponentType.MetaExposureManager);
      }
    }

    [Category("Components")]
//    [TypeConverter(typeof (ComponentTypeConverter))]
//    [Editor(typeof (j8JpaTe5oUu0XrCDGc), typeof (UITypeEditor))]
    public MetaRiskManager MetaRiskManager
    {
      get
      {
        return this.kXJRQmVtwY;
      }
      set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException();
        if (this.kXJRQmVtwY != null)
        {
          this.kXJRQmVtwY.Disconnect();
          this.kXJRQmVtwY.MetaStrategyBase = (MetaStrategyBase) null;
        }
        this.kXJRQmVtwY = value;
        if (this.kXJRQmVtwY != null)
        {
          this.kXJRQmVtwY.MetaStrategyBase = (MetaStrategyBase) this;
          this.kXJRQmVtwY.Connect();
        }
        this.EmitComponentChanged(ComponentType.MetaRiskManager);
      }
    }

//    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
//    [Editor(typeof (MfCmgO2d6ZUIseVQ0Y), typeof (UITypeEditor))]
    public ExecutionManager ExecutionManager
    {
      get
      {
        return this.XSvR57mV5s;
      }
      set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException();
        if (this.XSvR57mV5s != null)
        {
          this.XSvR57mV5s.Disconnect();
          this.XSvR57mV5s.MetaStrategyBase = (MetaStrategyBase) null;
        }
        this.XSvR57mV5s = value;
        if (this.XSvR57mV5s != null)
        {
          this.XSvR57mV5s.MetaStrategyBase = (MetaStrategyBase) this;
          this.XSvR57mV5s.Connect();
        }
        this.EmitComponentChanged(ComponentType.ExecutionManager);
      }
    }

    [Browsable(false)]
    public SignalList Signals
    {
      get
      {
        return this.aNKR2wRnBL;
      }
    }

    public event SignalEventHandler SignalAdded;

    public event EventHandler SignalListCleared;

   
		public MetaStrategy(string name): base(name)
    {

			this.MetaExposureManager = StrategyComponentManager.GetComponent("GetComponent", (object) this) as MetaExposureManager;
			this.ExecutionManager = StrategyComponentManager.GetComponent("GetComponent", (object) this) as ExecutionManager;
			this.MetaRiskManager = StrategyComponentManager.GetComponent("GetComponent", (object) this) as MetaRiskManager;
      this.aNKR2wRnBL = new SignalList();
      this.componentTypeList.Add(ComponentType.MetaRiskManager);
      this.componentTypeList.Add(ComponentType.MetaExposureManager);
      this.componentTypeList.Add(ComponentType.ExecutionManager);
    }

   
    protected override void OnInit()
    {
      this.aNKR2wRnBL.Clear();
//      if (this.JQvRMMGCuq != null)
//        this.JQvRMMGCuq((object) this, EventArgs.Empty);
      this.XSvR57mV5s.Init();
      this.optimizationManager.Init();
      this.k7bROYTXtn.Init();
      this.kXJRQmVtwY.Init();
    }

   
    protected override void OnMetaStrategyStop()
    {
      this.k7bROYTXtn.OnStrategyStop();
      this.kXJRQmVtwY.OnStrategyStop();
      this.XSvR57mV5s.OnStrategyStop();
    }

   
    internal SingleOrder PFARUMnUwZ([In] Signal obj0)
    {
      bool flag = false;
      if (obj0.Status == SignalStatus.New)
      {
        if (this.k7bROYTXtn.Validate(obj0))
        {
          obj0.Status = SignalStatus.Accepted;
          flag = true;
        }
        else
        {
          obj0.Status = SignalStatus.Rejected;
          obj0.Rejecter = ComponentType.MetaExposureManager;
        }
      }
      this.aNKR2wRnBL.Add(obj0);
//      if (this.iCcRBViVvB != null)
//        this.iCcRBViVvB(new SignalEventArgs(obj0));
      if (flag)
        return this.XSvR57mV5s.Execute(obj0);
      else
        return (SingleOrder) null;
    }

   
    protected override void OnPositionOpened(Position position)
    {
      this.kXJRQmVtwY.OnPositionOpened(position);
      this.k7bROYTXtn.OnPositionOpened(position);
    }

   
    protected override void OnPositionChanged(Position position)
    {
      this.kXJRQmVtwY.OnPositionChanged(position);
      this.k7bROYTXtn.OnPositionChanged(position);
    }

   
    protected override void OnPositionClosed(Position position)
    {
      this.kXJRQmVtwY.OnPositionClosed(position);
      this.k7bROYTXtn.OnPositionClosed(position);
    }

   
    protected override void OnPortfolioValueChanged(Position position)
    {
      this.kXJRQmVtwY.OnPortfolioValueChanged(this.portfolio);
      this.k7bROYTXtn.OnPortfolioValueChanged(this.portfolio);
    }

   
    protected override void OnNewBarOpen(Instrument instrument, Bar bar)
    {
      this.kXJRQmVtwY.OnBarOpen(instrument, bar);
      this.k7bROYTXtn.OnBarOpen(instrument, bar);
    }

   
    protected override void OnNewBar(Instrument instrument, Bar bar)
    {
      this.kXJRQmVtwY.OnBar(instrument, bar);
      this.k7bROYTXtn.OnBar(instrument, bar);
    }

   
    protected override void OnNewTrade(Instrument instrument, Trade trade)
    {
      this.kXJRQmVtwY.OnTrade(instrument, trade);
      this.k7bROYTXtn.OnTrade(instrument, trade);
    }

   
    protected override void OnNewQuote(Instrument instrument, Quote quote)
    {
      this.kXJRQmVtwY.OnQuote(instrument, quote);
      this.k7bROYTXtn.OnQuote(instrument, quote);
    }

   
    protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
      this.kXJRQmVtwY.OnMarketDepth(instrument, marketDepth);
      this.k7bROYTXtn.OnMarketDepth(instrument, marketDepth);
    }

   
    protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
    {
      this.kXJRQmVtwY.OnFundamental(instrument, fundamental);
      this.k7bROYTXtn.OnFundamental(instrument, fundamental);
    }

   
    protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
      this.kXJRQmVtwY.OnCorporateAction(instrument, corporateAction);
      this.k7bROYTXtn.OnCorporateAction(instrument, corporateAction);
    }

   
    protected override void OnNewOrder(SingleOrder order)
    {
      this.XSvR57mV5s.OnNewOrder(order);
    }

   
    protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
      this.XSvR57mV5s.OnExecutionReport(order, report);
    }

   
    protected override void OnOrderPartiallyFilled(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderPartiallyFilled(order);
    }

   
    protected override void OnOrderStatusChanged(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderStatusChanged(order);
    }

   
    protected override void OnOrderFilled(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderFilled(order);
    }

   
    protected override void OnOrderCancelled(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderCancelled(order);
    }

   
    protected override void OnOrderRejected(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderRejected(order);
    }

   
    protected override void OnOrderDone(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderDone(order);
    }

   
    protected override void OnProviderConnected(IProvider provider)
    {
      this.kXJRQmVtwY.OnProviderConnected(provider);
      this.k7bROYTXtn.OnProviderConnected(provider);
      this.XSvR57mV5s.OnProviderConnected(provider);
    }

   
    protected override void OnProviderDisconnected(IProvider provider)
    {
      this.kXJRQmVtwY.OnProviderDisconnected(provider);
      this.k7bROYTXtn.OnProviderDisconnected(provider);
      this.XSvR57mV5s.OnProviderDisconnected(provider);
    }

   
    protected override void OnProviderError(IProvider provider, int id, int code, string message)
    {
      this.kXJRQmVtwY.OnProviderError(provider, id, code, message);
      this.k7bROYTXtn.OnProviderError(provider, id, code, message);
      this.XSvR57mV5s.OnProviderError(provider, id, code, message);
    }

   
    public override IComponentBase GetComponent(ComponentType type)
    {
      switch (type)
      {
        case ComponentType.MetaExposureManager:
          return (IComponentBase) this.MetaExposureManager;
        case ComponentType.ExecutionManager:
          return (IComponentBase) this.ExecutionManager;
        case ComponentType.MetaRiskManager:
          return (IComponentBase) this.MetaRiskManager;
        default:
          return base.GetComponent(type);
      }
    }

   
    public override void SetComponent(ComponentType type, IComponentBase component)
    {
      switch (type)
      {
        case ComponentType.MetaExposureManager:
          this.MetaExposureManager = component as MetaExposureManager;
          break;
        case ComponentType.ExecutionManager:
          this.ExecutionManager = component as ExecutionManager;
          break;
        case ComponentType.MetaRiskManager:
          this.MetaRiskManager = component as MetaRiskManager;
          break;
        default:
          base.SetComponent(type, component);
          break;
      }
    }
  }
}
