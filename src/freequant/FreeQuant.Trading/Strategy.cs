using FreeQuant;
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
//using FreeQuant.Trading.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class Strategy : StrategyBase
  {
    private CrossEntry CX2pXhZQGN;
    private CrossExit hP7pPwnfQ7;
    private CrossEntry HeHpDewVKD;
    private CrossExit A6MpF2380O;
    private Entry iTOpL59SMK;
    private Exit KpSp3MfDuQ;
    private MoneyManager vicpsU5DyG;
    private RiskManager m8Hp4wyAlm;
    private ExposureManager ayRpJCTRPY;
    private Dictionary<Instrument, Entry> entries;
    private Dictionary<Instrument, Exit> exits;
    private Dictionary<Instrument, MoneyManager> moneyManagers;
		private Dictionary<Instrument, RiskManager> riskManagers; 

    [Browsable(false)]
    public MetaStrategy MetaStrategy
    {
       get
      {
        return this.MetaStrategyBase as MetaStrategy;
      }
    }

//    [Editor(typeof (Tk9X5M9uphPQxcsRCM), typeof (UITypeEditor))]
//    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public CrossEntry CrossEntry
    {
       get
      {
        if (this.metaStrategyBase == null || !this.metaStrategyBase.ahdWYv7joQ)
          return this.CX2pXhZQGN;
        else
          return this.HeHpDewVKD;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.CX2pXhZQGN != null)
        {
          this.CX2pXhZQGN.Disconnect();
          this.CX2pXhZQGN.StrategyBase = (StrategyBase) null;
        }
        this.CX2pXhZQGN = value;
        if (this.CX2pXhZQGN != null)
        {
          this.CX2pXhZQGN.StrategyBase = (StrategyBase) this;
          this.CX2pXhZQGN.Connect();
        }
        this.EmitComponentChanged(ComponentType.CrossEntry);
      }
    }

//    [Editor(typeof (jsfU1gQFmKSovu57Rq), typeof (UITypeEditor))]
//    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public CrossExit CrossExit
    {
       get
      {
        if (this.metaStrategyBase == null || !this.metaStrategyBase.ahdWYv7joQ)
          return this.hP7pPwnfQ7;
        else
          return this.A6MpF2380O;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.hP7pPwnfQ7 != null)
        {
          this.hP7pPwnfQ7.Disconnect();
          this.hP7pPwnfQ7.StrategyBase = (StrategyBase) null;
        }
        this.hP7pPwnfQ7 = value;
        if (this.hP7pPwnfQ7 != null)
        {
          this.hP7pPwnfQ7.StrategyBase = (StrategyBase) this;
          this.hP7pPwnfQ7.Connect();
        }
        this.EmitComponentChanged(ComponentType.CrossExit);
      }
    }

//    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
//    [Editor(typeof (KZiZE1UfPtfe4jp4N9), typeof (UITypeEditor))]
    public Entry Entry
    {
       get
      {
        return this.iTOpL59SMK;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.iTOpL59SMK != null)
        {
          this.iTOpL59SMK.Disconnect();
          this.iTOpL59SMK.StrategyBase = (StrategyBase) null;
        }
        this.iTOpL59SMK = value;
        if (this.iTOpL59SMK != null)
        {
          this.iTOpL59SMK.StrategyBase = (StrategyBase) this;
          this.iTOpL59SMK.Connect();
        }
        this.EmitComponentChanged(ComponentType.Entry);
      }
    }

//    [Editor(typeof (EDRqyRpkyAnMCaEZHgV), typeof (UITypeEditor))]
//    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public Exit Exit
    {
       get
      {
        return this.KpSp3MfDuQ;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.KpSp3MfDuQ != null)
        {
          this.KpSp3MfDuQ.Disconnect();
          this.KpSp3MfDuQ.StrategyBase = (StrategyBase) null;
        }
        this.KpSp3MfDuQ = value;
        if (this.KpSp3MfDuQ != null)
        {
          this.KpSp3MfDuQ.StrategyBase = (StrategyBase) this;
          this.KpSp3MfDuQ.Connect();
        }
        this.EmitComponentChanged(ComponentType.Exit);
      }
    }

//    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
//    [Editor(typeof (PrSe967mJKFdDx0JCT), typeof (UITypeEditor))]
    public MoneyManager MoneyManager
    {
       get
      {
        return this.vicpsU5DyG;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.vicpsU5DyG != null)
        {
          this.vicpsU5DyG.Disconnect();
          this.vicpsU5DyG.StrategyBase = (StrategyBase) null;
        }
        this.vicpsU5DyG = value;
        if (this.vicpsU5DyG != null)
        {
          this.vicpsU5DyG.StrategyBase = (StrategyBase) this;
          this.vicpsU5DyG.Connect();
        }
        this.EmitComponentChanged(ComponentType.MoneyManager);
      }
    }

    [Category("Components")]
//    [TypeConverter(typeof (ComponentTypeConverter))]
//    [Editor(typeof (HsWgP7ySF3VurrUYpc), typeof (UITypeEditor))]
    public RiskManager RiskManager
    {
       get
      {
        return this.m8Hp4wyAlm;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.m8Hp4wyAlm != null)
        {
          this.m8Hp4wyAlm.Disconnect();
          this.m8Hp4wyAlm.StrategyBase = (StrategyBase) null;
        }
        this.m8Hp4wyAlm = value;
        if (this.m8Hp4wyAlm != null)
        {
          this.m8Hp4wyAlm.StrategyBase = (StrategyBase) this;
          this.m8Hp4wyAlm.Connect();
        }
        this.EmitComponentChanged(ComponentType.RiskManager);
      }
    }

    [Category("Components")]
//    [Editor(typeof (mb1BObNwTRA0TfMY5S), typeof (UITypeEditor))]
//    [TypeConverter(typeof (ComponentTypeConverter))]
    public ExposureManager ExposureManager
    {
       get
      {
        return this.ayRpJCTRPY;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.ayRpJCTRPY != null)
        {
          this.ayRpJCTRPY.Disconnect();
          this.ayRpJCTRPY.StrategyBase = (StrategyBase) null;
        }
        this.ayRpJCTRPY = value;
        if (this.ayRpJCTRPY != null)
        {
          this.ayRpJCTRPY.StrategyBase = (StrategyBase) this;
          this.ayRpJCTRPY.Connect();
        }
        this.EmitComponentChanged(ComponentType.ExposureManager);
      }
    }

    
    public Strategy(string name, string description)
			: base(name, description) {

			this.CrossExit = StrategyComponentManager.GetComponent("GetComponent", (object) this) as CrossExit;
			this.CrossEntry = StrategyComponentManager.GetComponent("GetComponent", (object) this) as CrossEntry;
			this.Entry = StrategyComponentManager.GetComponent("GetComponent", (object) this) as Entry;
			this.Exit = StrategyComponentManager.GetComponent("GetComponent", (object) this) as Exit;
			this.MoneyManager = StrategyComponentManager.GetComponent("GetComponent", (object) this) as MoneyManager;
			this.RiskManager = StrategyComponentManager.GetComponent("GetComponent", (object) this) as RiskManager;
			this.ExposureManager = StrategyComponentManager.GetComponent("GetComponent", (object) this) as ExposureManager;
      this.entries = new Dictionary<Instrument, Entry>();
      this.exits = new Dictionary<Instrument, Exit>();
      this.moneyManagers = new Dictionary<Instrument, MoneyManager>();
      this.riskManagers = new Dictionary<Instrument, RiskManager>();
      this.componentTypeList.Add(ComponentType.Entry);
      this.componentTypeList.Add(ComponentType.Exit);
      this.componentTypeList.Add(ComponentType.CrossEntry);
      this.componentTypeList.Add(ComponentType.CrossExit);
      this.componentTypeList.Add(ComponentType.RiskManager);
      this.componentTypeList.Add(ComponentType.MoneyManager);
      this.componentTypeList.Add(ComponentType.ExposureManager);
    }

    
		public Strategy(string name): this(name, "")
    {
    }

    
    
    internal Dictionary<Instrument, Entry> GetEntries()
    {
			return this.entries; 
    }

    
    
    internal Dictionary<Instrument, Exit> GetExits()
    {
			return this.exits; 
    }

    
    
    internal Dictionary<Instrument, MoneyManager> GetMoneyManagers()
    {
			return this.moneyManagers;  
    }

    
    
    internal Dictionary<Instrument, RiskManager> GetRiskManagers()
    {
      return this.riskManagers;
    }

    
    protected override void OnInit()
    {
      this.entries.Clear();
      this.exits.Clear();
      this.moneyManagers.Clear();
      this.riskManagers.Clear();

      this.HeHpDewVKD = Activator.CreateInstance(this.CX2pXhZQGN.GetType()) as CrossEntry;
      this.A6MpF2380O = Activator.CreateInstance(this.hP7pPwnfQ7.GetType()) as CrossExit;
      this.HeHpDewVKD.StrategyBase = (StrategyBase) this;
      this.A6MpF2380O.StrategyBase = (StrategyBase) this;
      this.SetProxyProperties((object) this.HeHpDewVKD, (object) this.CX2pXhZQGN);
      this.SetProxyProperties((object) this.A6MpF2380O, (object) this.hP7pPwnfQ7);
      this.HeHpDewVKD.Init();
      this.A6MpF2380O.Init();
      this.ayRpJCTRPY.Init();
      foreach (Instrument instrument in (FIXGroupList) this.marketManager.Instruments)
      {
        this.activeInstruments.Add(instrument);
        Entry entry = Activator.CreateInstance(this.iTOpL59SMK.GetType()) as Entry;
        Exit exit = Activator.CreateInstance(this.KpSp3MfDuQ.GetType()) as Exit;
        MoneyManager moneyManager = Activator.CreateInstance(this.vicpsU5DyG.GetType()) as MoneyManager;
        RiskManager riskManager = Activator.CreateInstance(this.m8Hp4wyAlm.GetType()) as RiskManager;
        entry.StrategyBase = (StrategyBase) this;
        exit.StrategyBase = (StrategyBase) this;
        moneyManager.StrategyBase = (StrategyBase) this;
        riskManager.StrategyBase = (StrategyBase) this;
        entry.Instrument = instrument;
        exit.Instrument = instrument;
        moneyManager.Instrument = instrument;
        riskManager.Instrument = instrument;
        this.SetProxyProperties((object) entry, (object) this.iTOpL59SMK);
        this.SetProxyProperties((object) exit, (object) this.KpSp3MfDuQ);
        this.SetProxyProperties((object) moneyManager, (object) this.vicpsU5DyG);
        this.SetProxyProperties((object) riskManager, (object) this.m8Hp4wyAlm);
        entry.Init();
        exit.Init();
        moneyManager.Init();
        riskManager.Init();
        this.entries.Add(instrument, entry);
        this.exits.Add(instrument, exit);
        this.moneyManagers.Add(instrument, moneyManager);
        this.riskManagers.Add(instrument, riskManager);
      }
    }

    
    protected override void OnStrategyStop()
    {
      this.HeHpDewVKD.OnStrategyStop();
      this.A6MpF2380O.OnStrategyStop();
      foreach (ComponentBase componentBase in this.entries.Values)
        componentBase.OnStrategyStop();
      foreach (ComponentBase componentBase in this.exits.Values)
        componentBase.OnStrategyStop();
      foreach (ComponentBase componentBase in this.moneyManagers.Values)
        componentBase.OnStrategyStop();
      foreach (ComponentBase componentBase in this.riskManagers.Values)
        componentBase.OnStrategyStop();
      this.ayRpJCTRPY.OnStrategyStop();
    }

    
    internal SingleOrder BgvpSPpUAD(Signal obj0)
    {
      obj0.Strategy = this;
      double positionSize = this.moneyManagers[obj0.Instrument].GetPositionSize(obj0);
      if (positionSize > 0.0)
      {
        obj0.Qty = positionSize;
        if (!this.riskManagers[obj0.Instrument].Validate(obj0))
        {
          obj0.Status = SignalStatus.Rejected;
          obj0.Rejecter = ComponentType.RiskManager;
        }
        if (!this.ayRpJCTRPY.Validate(obj0))
        {
          obj0.Status = SignalStatus.Rejected;
          obj0.Rejecter = ComponentType.ExposureManager;
        }
      }
      else
      {
        obj0.Status = SignalStatus.Rejected;
        obj0.Rejecter = ComponentType.MoneyManager;
      }
      return this.MetaStrategy.PFARUMnUwZ(obj0);
    }

    
    protected override void OnNewTrade(Instrument instrument, Trade trade)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.yu56453Z5Z(trade);
      }
      this.A6MpF2380O.OnTrade(instrument, trade);
      this.HeHpDewVKD.OnTrade(instrument, trade);
      this.marketManager.OnTrade(instrument, trade);
      this.exits[instrument].OnTrade(trade);
      this.entries[instrument].OnTrade(trade);
      this.moneyManagers[instrument].OnTrade(trade);
      this.riskManagers[instrument].OnTrade(trade);
    }

    
    protected override void OnNewQuote(Instrument instrument, Quote quote)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.ddk6JqyZZD(quote);
      }
      this.A6MpF2380O.OnQuote(instrument, quote);
      this.HeHpDewVKD.OnQuote(instrument, quote);
      this.marketManager.OnQuote(instrument, quote);
      this.exits[instrument].OnQuote(quote);
      this.entries[instrument].OnQuote(quote);
      this.moneyManagers[instrument].OnQuote(quote);
      this.riskManagers[instrument].OnQuote(quote);
    }

    
    protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
      this.A6MpF2380O.OnMarketDepth(instrument, marketDepth);
      this.HeHpDewVKD.OnMarketDepth(instrument, marketDepth);
      this.marketManager.OnMarketDepth(instrument, marketDepth);
      this.exits[instrument].OnMarketDepth(marketDepth);
      this.entries[instrument].OnMarketDepth(marketDepth);
      this.moneyManagers[instrument].OnMarketDepth(marketDepth);
      this.riskManagers[instrument].OnMarketDepth(marketDepth);
    }

    
    protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
    {
      this.A6MpF2380O.OnFundamental(instrument, fundamental);
      this.HeHpDewVKD.OnFundamental(instrument, fundamental);
      this.exits[instrument].OnFundamental(fundamental);
      this.entries[instrument].OnFundamental(fundamental);
    }

    
    protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
      this.A6MpF2380O.OnCorporateAction(instrument, corporateAction);
      this.HeHpDewVKD.OnCorporateAction(instrument, corporateAction);
      this.marketManager.OnCorporateAction(instrument, corporateAction);
      this.ayRpJCTRPY.OnCorporateAction(instrument, corporateAction);
      this.exits[instrument].OnCorporateAction(corporateAction);
      this.entries[instrument].OnCorporateAction(corporateAction);
      this.moneyManagers[instrument].OnCorporateAction(corporateAction);
      this.riskManagers[instrument].OnCorporateAction(corporateAction);
    }

    
    protected override void OnNewBarOpen(Instrument instrument, Bar bar)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.M2g6st8BRD(bar);
      }
      this.A6MpF2380O.OnBarOpen(instrument, bar);
      this.HeHpDewVKD.OnBarOpen(instrument, bar);
      this.marketManager.OnBarOpen(instrument, bar);
      this.exits[instrument].OnBarOpen(bar);
      this.entries[instrument].OnBarOpen(bar);
      this.moneyManagers[instrument].OnBarOpen(bar);
      this.riskManagers[instrument].OnBarOpen(bar);
    }

    
    protected override void OnNewBar(Instrument instrument, Bar bar)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[instrument]))
      {
        if (stop.Connected)
          stop.t2b63VoTkG(bar);
      }
      this.A6MpF2380O.OnBar(instrument, bar);
      this.HeHpDewVKD.OnBar(instrument, bar);
      this.marketManager.OnBar(instrument, bar);
      this.exits[instrument].OnBar(bar);
      this.entries[instrument].OnBar(bar);
      this.moneyManagers[instrument].OnBar(bar);
      this.riskManagers[instrument].OnBar(bar);
    }

    
    protected override void OnNewBarSlice(long barSize)
    {
      this.A6MpF2380O.OnBarSlice(barSize);
      this.HeHpDewVKD.OnBarSlice(barSize);
      this.marketManager.OnBarSlice(barSize);
    }

    
    protected override void OnProviderConnected(IProvider provider)
    {
      this.A6MpF2380O.OnProviderConnected(provider);
      this.HeHpDewVKD.OnProviderConnected(provider);
      this.marketManager.OnProviderConnected(provider);
    }

    
    protected override void OnProviderDisconnected(IProvider provider)
    {
      this.A6MpF2380O.OnProviderDisconnected(provider);
      this.HeHpDewVKD.OnProviderDisconnected(provider);
      this.marketManager.OnProviderDisconnected(provider);
    }

    
    protected override void OnProviderError(IProvider provider, int id, int code, string message)
    {
      this.A6MpF2380O.OnProviderError(provider, id, code, message);
      this.HeHpDewVKD.OnProviderError(provider, id, code, message);
      this.marketManager.OnProviderError(provider, id, code, message);
    }

    
    protected override void OnPositionOpened(Position position)
    {
      this.A6MpF2380O.OnPositionOpened(position);
      this.HeHpDewVKD.OnPositionOpened(position);
      this.ayRpJCTRPY.OnPositionOpened(position);
      Instrument instrument = position.Instrument;
      this.exits[instrument].OnPositionOpened();
      this.entries[instrument].OnPositionOpened();
      this.moneyManagers[instrument].OnPositionOpened();
      this.riskManagers[instrument].OnPositionOpened();
    }

    
    protected override void OnPositionChanged(Position position)
    {
      this.A6MpF2380O.OnPositionChanged(position);
      this.HeHpDewVKD.OnPositionChanged(position);
      this.ayRpJCTRPY.OnPositionChanged(position);
      Instrument instrument = position.Instrument;
      this.exits[instrument].OnPositionChanged();
      this.entries[instrument].OnPositionChanged();
      this.moneyManagers[instrument].OnPositionChanged();
      this.riskManagers[instrument].OnPositionChanged();
    }

    
    protected override void OnPositionClosed(Position position)
    {
      foreach (Stop stop in new ArrayList((ICollection) this.activeStops[position.Instrument]))
      {
        if (stop.Type == StopType.Time && stop.Status == StopStatus.Active || stop.Connected)
          stop.xbx6LKbgmx(position);
      }
      this.A6MpF2380O.OnPositionClosed(position);
      this.HeHpDewVKD.OnPositionClosed(position);
      this.ayRpJCTRPY.OnPositionClosed(position);
      Instrument instrument = position.Instrument;
      this.exits[instrument].OnPositionClosed();
      this.entries[instrument].OnPositionClosed();
      this.moneyManagers[instrument].OnPositionClosed();
      this.riskManagers[instrument].OnPositionClosed();
    }

    
    protected override void OnPortfolioValueChanged(Position position)
    {
      this.MetaStrategy.MetaRiskManager.OnStrategyPortfolioValueChanged(this);
      if (!this.isActive)
        return;
      this.A6MpF2380O.OnPortfolioValueChanged(position);
      this.HeHpDewVKD.OnPortfolioValueChanged(position);
      this.ayRpJCTRPY.OnPortfolioValueChanged(position);
      Instrument instrument = position.Instrument;
      this.exits[instrument].OnPositionValueChanged();
      this.entries[instrument].OnPositionValueChanged();
      this.moneyManagers[instrument].OnPositionValueChanged();
      this.riskManagers[instrument].OnPositionValueChanged();
    }

    
    public override void ClosePosition(Instrument instrument, double price, ComponentType component, string text)
    {
      Position position = this.portfolio.Positions[instrument];
      if (position == null)
        return;
      switch (position.Side)
      {
        case PositionSide.Long:
          this.BgvpSPpUAD(new Signal(Clock.Now, component, SignalType.Market, SignalSide.Sell, position.Qty, price, instrument, text));
          break;
        case PositionSide.Short:
          this.BgvpSPpUAD(new Signal(Clock.Now, component, SignalType.Market, SignalSide.BuyCover, position.Qty, price, instrument, text));
          break;
      }
    }

    
    protected override void OnNewOrder(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnNewOrder(order);
      this.A6MpF2380O.OnNewOrder(order);
      this.entries[instrument].OnNewOrder(order);
      this.exits[instrument].OnNewOrder(order);
    }

    
    protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnExecutionReport(order, report);
      this.A6MpF2380O.OnExecutionReport(order, report);
      this.entries[instrument].OnExecutionReport(order, report);
      this.exits[instrument].OnExecutionReport(order, report);
    }

    
    protected override void OnOrderPartiallyFilled(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderPartiallyFilled(order);
      this.A6MpF2380O.OnOrderPartiallyFilled(order);
      this.entries[instrument].OnOrderPartiallyFilled(order);
      this.exits[instrument].OnOrderPartiallyFilled(order);
    }

    
    protected override void OnOrderStatusChanged(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderStatusChanged(order);
      this.A6MpF2380O.OnOrderStatusChanged(order);
      this.entries[instrument].OnOrderStatusChanged(order);
      this.exits[instrument].OnOrderStatusChanged(order);
    }

    
    protected override void OnOrderFilled(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderFilled(order);
      this.A6MpF2380O.OnOrderFilled(order);
      this.entries[instrument].OnOrderFilled(order);
      this.exits[instrument].OnOrderFilled(order);
    }

    
    protected override void OnOrderCancelled(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderCancelled(order);
      this.A6MpF2380O.OnOrderCancelled(order);
      this.entries[instrument].OnOrderCancelled(order);
      this.exits[instrument].OnOrderCancelled(order);
    }

    
    protected override void OnOrderRejected(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderRejected(order);
      this.A6MpF2380O.OnOrderRejected(order);
      this.entries[instrument].OnOrderRejected(order);
      this.exits[instrument].OnOrderRejected(order);
    }

    
    protected override void OnOrderDone(SingleOrder order)
    {
      Instrument instrument = order.Instrument;
      this.HeHpDewVKD.OnOrderDone(order);
      this.A6MpF2380O.OnOrderDone(order);
      this.entries[instrument].OnOrderDone(order);
      this.exits[instrument].OnOrderDone(order);
    }

    
    public override IComponentBase GetComponent(ComponentType type)
    {
      switch (type)
      {
        case ComponentType.CrossEntry:
          return (IComponentBase) this.CrossEntry;
        case ComponentType.CrossExit:
          return (IComponentBase) this.CrossExit;
        case ComponentType.MarketManager:
          return (IComponentBase) this.MarketManager;
        case ComponentType.ReportManager:
          return (IComponentBase) this.ReportManager;
        case ComponentType.MoneyManager:
          return (IComponentBase) this.MoneyManager;
        case ComponentType.RiskManager:
          return (IComponentBase) this.RiskManager;
        case ComponentType.Entry:
          return (IComponentBase) this.Entry;
        case ComponentType.Exit:
          return (IComponentBase) this.Exit;
        case ComponentType.ExposureManager:
          return (IComponentBase) this.ExposureManager;
        default:
          throw new InvalidOperationException();
      }
    }

    
    public override void SetComponent(ComponentType type, IComponentBase component)
    {
      switch (type)
      {
        case ComponentType.CrossEntry:
          this.CrossEntry = component as CrossEntry;
          break;
        case ComponentType.CrossExit:
          this.CrossExit = component as CrossExit;
          break;
        case ComponentType.MarketManager:
          this.MarketManager = component as MarketManager;
          break;
        case ComponentType.ReportManager:
          this.ReportManager = component as ReportManager;
          break;
        case ComponentType.MoneyManager:
          this.MoneyManager = component as MoneyManager;
          break;
        case ComponentType.RiskManager:
          this.RiskManager = component as RiskManager;
          break;
        case ComponentType.Entry:
          this.Entry = component as Entry;
          break;
        case ComponentType.Exit:
          this.Exit = component as Exit;
          break;
        case ComponentType.ExposureManager:
          this.ExposureManager = component as ExposureManager;
          break;
        default:
          throw new InvalidOperationException();
      }
    }
  }
}
