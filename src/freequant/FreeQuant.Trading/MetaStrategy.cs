
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Trading.Design;
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
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Editor(typeof (VloQkVmhmpyuVfn267), typeof (UITypeEditor))]
    public MetaExposureManager MetaExposureManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.k7bROYTXtn;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(13008));
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
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Editor(typeof (j8JpaTe5oUu0XrCDGc), typeof (UITypeEditor))]
    public MetaRiskManager MetaRiskManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kXJRQmVtwY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(13080));
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

    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    [Editor(typeof (MfCmgO2d6ZUIseVQ0Y), typeof (UITypeEditor))]
    public ExecutionManager ExecutionManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XSvR57mV5s;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(13152));
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aNKR2wRnBL;
      }
    }

    public event SignalEventHandler SignalAdded;

    public event EventHandler SignalListCleared;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MetaStrategy(string name)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
      this.MetaExposureManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12768), (object) this) as MetaExposureManager;
      this.ExecutionManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12848), (object) this) as ExecutionManager;
      this.MetaRiskManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12928), (object) this) as MetaRiskManager;
      this.aNKR2wRnBL = new SignalList();
      this.componentTypeList.Add(ComponentType.MetaRiskManager);
      this.componentTypeList.Add(ComponentType.MetaExposureManager);
      this.componentTypeList.Add(ComponentType.ExecutionManager);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInit()
    {
      this.aNKR2wRnBL.Clear();
      if (this.JQvRMMGCuq != null)
        this.JQvRMMGCuq((object) this, EventArgs.Empty);
      this.XSvR57mV5s.Init();
      this.optimizationManager.Init();
      this.k7bROYTXtn.Init();
      this.kXJRQmVtwY.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMetaStrategyStop()
    {
      this.k7bROYTXtn.OnStrategyStop();
      this.kXJRQmVtwY.OnStrategyStop();
      this.XSvR57mV5s.OnStrategyStop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
      if (this.iCcRBViVvB != null)
        this.iCcRBViVvB(new SignalEventArgs(obj0));
      if (flag)
        return this.XSvR57mV5s.Execute(obj0);
      else
        return (SingleOrder) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPositionOpened(Position position)
    {
      this.kXJRQmVtwY.OnPositionOpened(position);
      this.k7bROYTXtn.OnPositionOpened(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPositionChanged(Position position)
    {
      this.kXJRQmVtwY.OnPositionChanged(position);
      this.k7bROYTXtn.OnPositionChanged(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPositionClosed(Position position)
    {
      this.kXJRQmVtwY.OnPositionClosed(position);
      this.k7bROYTXtn.OnPositionClosed(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPortfolioValueChanged(Position position)
    {
      this.kXJRQmVtwY.OnPortfolioValueChanged(this.portfolio);
      this.k7bROYTXtn.OnPortfolioValueChanged(this.portfolio);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewBarOpen(Instrument instrument, Bar bar)
    {
      this.kXJRQmVtwY.OnBarOpen(instrument, bar);
      this.k7bROYTXtn.OnBarOpen(instrument, bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewBar(Instrument instrument, Bar bar)
    {
      this.kXJRQmVtwY.OnBar(instrument, bar);
      this.k7bROYTXtn.OnBar(instrument, bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewTrade(Instrument instrument, Trade trade)
    {
      this.kXJRQmVtwY.OnTrade(instrument, trade);
      this.k7bROYTXtn.OnTrade(instrument, trade);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewQuote(Instrument instrument, Quote quote)
    {
      this.kXJRQmVtwY.OnQuote(instrument, quote);
      this.k7bROYTXtn.OnQuote(instrument, quote);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
      this.kXJRQmVtwY.OnMarketDepth(instrument, marketDepth);
      this.k7bROYTXtn.OnMarketDepth(instrument, marketDepth);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
    {
      this.kXJRQmVtwY.OnFundamental(instrument, fundamental);
      this.k7bROYTXtn.OnFundamental(instrument, fundamental);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
      this.kXJRQmVtwY.OnCorporateAction(instrument, corporateAction);
      this.k7bROYTXtn.OnCorporateAction(instrument, corporateAction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnNewOrder(SingleOrder order)
    {
      this.XSvR57mV5s.OnNewOrder(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
      this.XSvR57mV5s.OnExecutionReport(order, report);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderPartiallyFilled(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderPartiallyFilled(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderStatusChanged(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderStatusChanged(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderFilled(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderFilled(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderCancelled(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderCancelled(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderRejected(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderRejected(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnOrderDone(SingleOrder order)
    {
      this.XSvR57mV5s.OnOrderDone(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnProviderConnected(IProvider provider)
    {
      this.kXJRQmVtwY.OnProviderConnected(provider);
      this.k7bROYTXtn.OnProviderConnected(provider);
      this.XSvR57mV5s.OnProviderConnected(provider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnProviderDisconnected(IProvider provider)
    {
      this.kXJRQmVtwY.OnProviderDisconnected(provider);
      this.k7bROYTXtn.OnProviderDisconnected(provider);
      this.XSvR57mV5s.OnProviderDisconnected(provider);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnProviderError(IProvider provider, int id, int code, string message)
    {
      this.kXJRQmVtwY.OnProviderError(provider, id, code, message);
      this.k7bROYTXtn.OnProviderError(provider, id, code, message);
      this.XSvR57mV5s.OnProviderError(provider, id, code, message);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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
