using FreeQuant;
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Series;
using FreeQuant.Services;
using FreeQuant.Testing;
//using FreeQuant.Trading.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Diagnostics;

namespace FreeQuant.Trading
{
  public abstract class StrategyBase
  {
    protected const string CATEGORY_COMPONENTS = "Components";
    protected const string CATEGORY_PROVIDERS = "Providers";
    protected const string CATEGORY_NAMING = "Naming";
    protected const string CATEGORY_SERVICES = "Services";
    protected MetaStrategyBase metaStrategyBase;
    protected string name;
    protected string description;
    protected ReportManager reportManager;
    protected MarketManager marketManager;
    protected bool isEnabled;
    protected bool isActive;
    protected Portfolio portfolio;
    protected LiveTester tester;
    protected StopList stops;
    protected TriggerList triggers;
    protected IMarketDataProvider marketDataProvider;
    protected IExecutionProvider executionProvider;
    protected INewsProvider newsProvider;
    protected IExecutionService executionService;
    protected OrderTable orders;
    protected Hashtable global;
    protected InstrumentList activeInstruments;
    protected BarSliceManager barSliceManager;
    protected List<ComponentType> componentTypeList;
    protected Dictionary<Instrument, List<StopBase>> activeStops;
    protected Dictionary<Instrument, Portfolio> portfolios;
    protected Dictionary<Instrument, LiveTester> testers;
    protected bool statisticsPerInstrumentEnabled;

    [Category("Components")]
//    [TypeConverter(typeof (ComponentTypeConverter))]
//    [Editor(typeof (UnfQ7EceHewVKDD6M2), typeof (UITypeEditor))]
    public ReportManager ReportManager
    {
       get
      {
        return this.reportManager;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.reportManager != null)
          this.reportManager.Disconnect();
        this.reportManager = value;
        if (this.reportManager != null)
          this.reportManager.Connect();
        this.EmitComponentChanged(ComponentType.ReportManager);
      }
    }

//    [TypeConverter(typeof (ComponentTypeConverter))]
//    [Editor(typeof (AuQhicqU5DyG28HwyA), typeof (UITypeEditor))]
    [Category("Components")]
    public MarketManager MarketManager
    {
       get
      {
        return this.marketManager;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        if (this.marketManager != null)
        {
          this.marketManager.Disconnect();
          this.marketManager.StrategyBase = (StrategyBase) null;
        }
        this.marketManager = value;
        if (this.marketManager != null)
        {
          this.marketManager.StrategyBase = this;
          this.marketManager.Connect();
        }
        this.EmitComponentChanged(ComponentType.MarketManager);
      }
    }

    [Browsable(false)]
    public MetaStrategyBase MetaStrategyBase
    {
       get
      {
        return this.metaStrategyBase;
      }
       internal set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.metaStrategyBase = value;
      }
    }

    [Category("Naming")]
    public string Name
    {
       get
      {
        return this.name;
      }
    }

    [Category("Naming")]
    public string Description
    {
       get
      {
        return this.description;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.description = value;
      }
    }

    [DefaultValue(true)]
    public bool IsEnabled
    {
       get
      {
        return this.isEnabled;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.isEnabled = value;
        this.EmitEnabledChanged();
      }
    }

    [DefaultValue(true)]
    public bool IsActive
    {
       get
      {
        return this.isActive;
      }
       set
      {
        this.isActive = value;
      }
    }

    public Hashtable Global
    {
       get
      {
        return this.global;
      }
    }

    [DefaultValue(false)]
    [Description("Enable or disable gathering statistics for each instrument")]
    public bool StatisticsPerInstrumentEnabled
    {
       get
      {
        return this.statisticsPerInstrumentEnabled;
      }
       set
      {
        this.statisticsPerInstrumentEnabled = value;
      }
    }

    [Browsable(false)]
    public List<ComponentType> ComponentTypeList
    {
       get
      {
        return this.componentTypeList;
      }
    }

    [Category("Providers")]
    [DefaultValue(null)]
//    [TypeConverter(typeof (ProviderTypeConverter))]
//    [Editor(typeof (ExecutionProviderTypeEditor), typeof (UITypeEditor))]
    public IExecutionProvider ExecutionProvider
    {
       get
      {
        return this.executionProvider;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.executionProvider = value;
        this.EmitProviderChanged();
      }
    }

    [DefaultValue(null)]
//    [TypeConverter(typeof (ProviderTypeConverter))]
    [Category("Providers")]
//    [Editor(typeof (MarketDataProviderTypeEditor), typeof (UITypeEditor))]
    public IMarketDataProvider MarketDataProvider
    {
       get
      {
        return this.marketDataProvider;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.marketDataProvider = value;
        this.EmitProviderChanged();
      }
    }

    [DefaultValue(null)]
    [Category("Providers")]
    public INewsProvider NewsProvider
    {
       get
      {
        return this.newsProvider;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.newsProvider = value;
      }
    }

    [Category("Services")]
//    [Editor(typeof (ebqyRmnD9vAJyOsaUc), typeof (UITypeEditor))]
    [DefaultValue(null)]
//    [TypeConverter(typeof (MN5euIxWQEAnqU3XOr))]
    public IExecutionService ExecutionService
    {
       get
      {
        return this.executionService;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.executionService = value;
      }
    }

    [Browsable(false)]
    public LiveTester Tester
    {
       get
      {
        return this.tester;
      }
    }

//    [Editor(typeof (HIchUSrZnOXCxW67vf), typeof (UITypeEditor))]
    public Portfolio Portfolio
    {
       get
      {
        return this.portfolio;
      }
       set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException();
        this.portfolio = value;
        this.EmitPortfolioChanged();
      }
    }

    [Browsable(false)]
    public StopList Stops
    {
       get
      {
        return this.stops;
      }
    }

    [Browsable(false)]
    public TriggerList Triggers
    {
       get
      {
        return this.triggers;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
       get
      {
        return this.metaStrategyBase.Bars;
      }
    }

    [Browsable(false)]
    public OrderTable Orders
    {
       get
      {
        return this.orders;
      }
    }

    public event EventHandler ProviderChanged;

    public event EventHandler PortfolioChanged;

    public event EventHandler EnabledChanged;

    public event ComponentTypeEventHandler ComponentChanged;

    public event StopEventHandler StopAdded;

    public event StopEventHandler StopStatusChanged;

    public event EventHandler StopListCleared;

    public event TriggerEventHandler TriggerAdded;

    public event TriggerEventHandler TriggerStatusChanged;

    public event EventHandler TriggerListCleared;

    
    protected StrategyBase(string name, string description)
    {
      this.metaStrategyBase = (MetaStrategyBase) null;
      this.name = name;
      this.description = description;
      this.isEnabled = true;
      this.isActive = true;
			this.ReportManager = StrategyComponentManager.GetComponent("getcom", (object) this) as ReportManager;
			this.MarketManager = StrategyComponentManager.GetComponent("getcom", (object) this) as MarketManager;
      this.portfolio = PortfolioManager.Portfolios[name];
      if (this.portfolio == null)
        this.portfolio = new Portfolio(name);
      this.tester = new LiveTester(this.portfolio);
      this.stops = new StopList();
      this.triggers = new TriggerList();
      this.marketDataProvider = (IMarketDataProvider) null;
      this.executionProvider = (IExecutionProvider) null;
      this.newsProvider = (INewsProvider) null;
      this.executionService = (IExecutionService) null;
      this.orders = new OrderTable();
      this.global = new Hashtable();
      this.activeInstruments = new InstrumentList();
      this.barSliceManager = new BarSliceManager();
      this.componentTypeList = new List<ComponentType>();
      this.componentTypeList.Add(ComponentType.MarketManager);
      this.componentTypeList.Add(ComponentType.ReportManager);
      this.activeStops = new Dictionary<Instrument, List<StopBase>>();
      this.portfolios = new Dictionary<Instrument, Portfolio>();
      this.testers = new Dictionary<Instrument, LiveTester>();
      this.statisticsPerInstrumentEnabled = false;
    }

    
    protected virtual void OnInit()
    {
    }

    
    protected virtual void OnStrategyStop()
    {
    }

    
    internal void ztfTe4jp4()
    {
      this.isActive = true;
      this.global.Clear();
      this.stops.Clear();
      this.activeStops.Clear();
//      if (this.JEmpWIimOt != null)
//        this.JEmpWIimOt((object) this, EventArgs.Empty);
      this.triggers.Clear();
//      if (this.DGvp78okLv != null)
//        this.DGvp78okLv((object) this, EventArgs.Empty);
      this.activeInstruments.Clear();
      if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Simulation || this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live && this.metaStrategyBase.ResetPortfolio)
      {
        this.portfolio.Clear();
        this.portfolios.Clear();
        this.testers.Clear();
        this.tester.FriendlyTesters.Clear();
      }
      this.portfolio.TransactionAdded += new TransactionEventHandler(this.wFewIKaO9);
      this.portfolio.PositionOpened += new PositionEventHandler(this.tqpmkcdnl);
      this.portfolio.PositionChanged += new PositionEventHandler(this.qmsfx90ud);
      this.portfolio.PositionClosed += new PositionEventHandler(this.iIIeZBW7d);
      this.portfolio.ValueChanged += new PositionEventHandler(this.zqRghd2Zu);
      this.portfolio.Monitored = true;
      this.orders.Clear();
      this.marketManager.Instruments.Clear();
      this.marketManager.jcIApP7GcT.Clear();
      if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live)
      {
        this.marketManager.OM26eKMfqS = this.marketDataProvider;
        this.marketManager.TOY6zSGlVT = this.executionProvider;
      }
      this.marketManager.Init();
      this.tester.Disconnect();
      this.tester.Connect();
      this.tester.Reset();
      if (this.statisticsPerInstrumentEnabled)
      {
        foreach (LiveTester liveTester in this.testers.Values)
        {
          liveTester.Connect();
          liveTester.Reset();
        }
      }
      foreach (Instrument key in (FIXGroupList) this.marketManager.Instruments)
      {
        key.Reset();
        BarSeries barSeries = this.Bars[key];
        this.activeStops[key] = new List<StopBase>();
        if (this.statisticsPerInstrumentEnabled && !this.portfolios.ContainsKey(key))
        {
          Portfolio portfolio = new Portfolio();
					portfolio.Name = string.Format("dfs", (object) this.name, (object) key.Symbol);
          if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live && !this.metaStrategyBase.ResetPortfolio)
						portfolio.Account.Deposit(this.portfolio.GetAccountValue(), this.portfolio.Account.Currency, Clock.Now,"");
          LiveTester liveTester = new LiveTester(portfolio);
          liveTester.FollowChanges = true;
          this.portfolios.Add(key, portfolio);
          this.testers.Add(key, liveTester);
          this.tester.FriendlyTesters.Add(key, liveTester);
        }
      }
      this.barSliceManager.InstrumentsCount = this.marketManager.Instruments.Count;
      this.barSliceManager.Clear();
      this.OnInit();
      this.reportManager.Tester = this.tester;
      if (this.MetaStrategyBase.dBEWaCEkLk)
        return;
      this.reportManager.Init();
    }

    
    internal void Y9KryiX9N()
    {
      this.OnStrategyStop();
      this.marketManager.OnStrategyStop();
      this.portfolio.TransactionAdded -= new TransactionEventHandler(this.wFewIKaO9);
      this.portfolio.PositionOpened -= new PositionEventHandler(this.tqpmkcdnl);
      this.portfolio.PositionChanged -= new PositionEventHandler(this.qmsfx90ud);
      this.portfolio.PositionClosed -= new PositionEventHandler(this.iIIeZBW7d);
      this.portfolio.ValueChanged -= new PositionEventHandler(this.zqRghd2Zu);
      this.portfolio.Monitored = false;
      foreach (Portfolio portfolio in this.portfolios.Values)
        portfolio.Monitored = false;
      this.pS59UsfU1();
      this.Xr8Cv9Ogt();
      this.sX9KD5lfC();
    }

    
    protected void SetProxyProperties(object obj, object proxy)
    {
      foreach (PropertyInfo propertyInfo in proxy.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
      {
        bool flag = false;
        foreach (Attribute attribute in propertyInfo.GetCustomAttributes(true))
        {
          if (attribute.GetType() == typeof (BrowsableAttribute) && !(attribute as BrowsableAttribute).Browsable)
            flag = true;
        }
        if (!flag && propertyInfo.CanRead && propertyInfo.CanWrite)
          obj.GetType().GetProperty(propertyInfo.Name).SetValue(obj, propertyInfo.GetValue(proxy, (object[]) null), (object[]) null);
      }
    }

    
    internal virtual void AddStop(StopBase stop)
    {
      this.stops.Add((IStop) stop);
      this.activeStops[stop.Instrument].Add(stop);
//      if (this.ynApAPhUd7 == null)
//        return;
//      this.ynApAPhUd7(new StopEventArgs((IStop) stop));
    }

    
    internal void BSDIytBhT(StopBase obj0)
    {
      if (obj0.Status != StopStatus.Active)
        this.activeStops[obj0.Instrument].Remove(obj0);
//      if (this.gFbpjXoNEx == null)
//        return;
//      this.gFbpjXoNEx(new StopEventArgs((IStop) obj0));
    }

    
    private void pS59UsfU1()
    {
      foreach (StopBase stopBase in this.stops)
        stopBase.Disconnect();
    }

    
    internal void YFmhKSovu(Trigger obj0)
    {
      this.triggers.Add(obj0);
//      if (this.RjapR37OfO == null)
//        return;
//      this.RjapR37OfO(new TriggerEventArgs(obj0));
    }

    
    internal void l7R1qp1JA(Trigger obj0)
    {
//      if (this.GZ5pihuIx6 == null)
//        return;
//      this.GZ5pihuIx6(new TriggerEventArgs(obj0));
    }

    
    private void Xr8Cv9Ogt()
    {
      foreach (Trigger trigger in this.triggers)
        trigger.rKEA9ZLnkT();
    }

    
    private void sX9KD5lfC()
    {
      if (this.statisticsPerInstrumentEnabled)
      {
        foreach (LiveTester liveTester in this.testers.Values)
          liveTester.Disconnect();
      }
      this.tester.Disconnect();
    }

    
    internal void VgOXd6ZUI()
    {
      StrategyComponentManager.ClearComponentCache((object) this);
      this.metaStrategyBase = (MetaStrategyBase) null;
    }

    
    internal void EeVPQ0YHG()
    {
      this.tester.SaveSettings();
      this.tester.DisableComponents();
      this.tester.FollowChanges = true;
    }

    
    internal void s4VDgj1ao()
    {
      this.tester.RestoreSettings();
    }

    
		internal void cXaFP441d(double obj0, FreeQuant.Instruments.Currency obj1, DateTime obj2, string obj3)
    {
      this.portfolio.Account.Deposit(obj0, obj1, obj2, obj3);
      foreach (Portfolio portfolio in this.portfolios.Values)
        portfolio.Account.Deposit(obj0, obj1, obj2, obj3);
    }

    
    internal void qZcLyn7Uf(double obj0, FreeQuant.Instruments.Currency obj1, DateTime obj2, string obj3)
    {
      this.portfolio.Account.Withdraw(obj0, obj1, obj2, obj3);
      foreach (Portfolio portfolio in this.portfolios.Values)
        portfolio.Account.Withdraw(obj0, obj1, obj2, obj3);
    }

    
    public void AddInstrument(Instrument instrument)
    {
      if (this.activeInstruments.Contains(instrument))
        return;
      this.activeInstruments.Add(instrument);
    }

    
    public void AddInstrument(string symbol)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.AddInstrument(instrument);
    }

    
    public void RemoveInstrument(Instrument instrument)
    {
      if (!this.activeInstruments.Contains(instrument))
        return;
      this.activeInstruments.Remove(instrument);
    }

    
    public void RemoveInstrument(string symbol)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.RemoveInstrument(instrument);
    }

    
    public bool IsInstrumentActive(Instrument instrument)
    {
      return this.activeInstruments.Contains(instrument);
    }

    
    protected void EmitProviderChanged()
    {
//      if (this.dfCzM9nkh == null)
//        return;
//      this.dfCzM9nkh((object) this, EventArgs.Empty);
    }

    
    protected void EmitPortfolioChanged()
    {
//      if (this.HCRpkIgJZ0 == null)
//        return;
//      this.HCRpkIgJZ0((object) this, EventArgs.Empty);
    }

    
    protected void EmitEnabledChanged()
    {
//      if (this.eAbppUwn6O == null)
//        return;
//      this.eAbppUwn6O((object) this, EventArgs.Empty);
    }

    
    protected void EmitComponentChanged(ComponentType componentType)
    {
//      if (this.hn5p6Upr60 == null)
//        return;
//      this.hn5p6Upr60((object) this, new ComponentTypeEventArgs(componentType));
    }

    
    protected void EmitStopAdded(StopBase stop)
    {
//      if (this.ynApAPhUd7 == null)
//        return;
//      this.ynApAPhUd7(new StopEventArgs((IStop) stop));
    }

    
    protected virtual void OnProviderConnected(IProvider provider)
    {
    }

    
    protected virtual void OnProviderDisconnected(IProvider provider)
    {
    }

    
    protected virtual void OnProviderError(IProvider provider, int id, int code, string message)
    {
    }

    
    internal void Jwd3xKdmx(IProvider obj0)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("fsdfs", (object) this.name, (object) obj0.Name));
      this.OnProviderConnected(obj0);
    }

    
    internal void QNbsERb0O(IProvider obj0)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("dffs", (object) this.name, (object) obj0.Name));
      this.OnProviderDisconnected(obj0);
    }

    
    internal void sHL4bMMk2(IProvider obj0, int obj1, int obj2, string obj3)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("ffdssf", (object) this.name, (object) obj0.Name, (object) obj1, (object) obj2, (object) obj3));
			this.OnProviderError(obj0, obj1, obj2, obj3);
    }

    
    protected virtual void OnServiceStatusChanged(IService service)
    {
    }

    
    protected virtual void OnServiceError(IService service, ServiceErrorType errorType, string text)
    {
    }

    
    internal void aEsJWgP7S(IService obj0)
    {
      if (!this.isActive)
        return;
      this.OnServiceStatusChanged(obj0);
    }

    
    internal void A3V0urrUY(IService obj0, ServiceErrorType obj1, string obj2)
    {
      if (!this.isActive)
        return;
      this.OnServiceError(obj0, obj1, obj2);
    }

    
    protected virtual void OnNewClientOrder(SingleOrder order)
    {
    }

    
    internal void acOvnqFOo(SingleOrder obj0)
    {
      if (!this.isActive)
        return;
      this.OnNewClientOrder(obj0);
    }

    
    internal void RM9EmoIgF(ExecutionReport obj0)
    {
      this.MetaStrategyBase.mhsWZDndbE(this, obj0);
    }

    
    protected virtual void OnNewTrade(Instrument instrument, Trade trade)
    {
    }

    
    protected virtual void OnNewQuote(Instrument instrument, Quote quote)
    {
    }

    
    protected virtual void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
    }

    
    protected virtual void OnNewFundamental(Instrument instrument, Fundamental fundamental)
    {
    }

    
    protected virtual void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
    }

    
    protected virtual void OnNewBarOpen(Instrument instrument, Bar bar)
    {
    }

    
    protected virtual void OnNewBar(Instrument instrument, Bar bar)
    {
    }

    
    protected virtual void OnNewBarSlice(long barSize)
    {
    }

    
    internal void gSQVAlpOg(Instrument obj0, Trade obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("dfdf", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewTrade(obj0, obj1);
    }

    
    internal void miSxH6BDd(Instrument obj0, Quote obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("fsfd", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewQuote(obj0, obj1);
    }

    
    internal void NEl89GHdA(Instrument obj0, MarketDepth obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("fds", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewMarketDepth(obj0, obj1);
    }

    
    internal void s05cSUaYk(Instrument obj0, Fundamental obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("fdsdf", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewFundamental(obj0, obj1);
    }

    
    internal void a4glMfvIc(Instrument obj0, CorporateAction obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("fdfs", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewCorporateAction(obj0, obj1);
    }

    
    internal void vUSqZnOXC(Instrument obj0, Bar obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("dfssdf", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewBarOpen(obj0, obj1);
    }

    
    internal void JW6Z7vfHf(Instrument obj0, Bar obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("afads", (object) this.Name, (object) obj0.Symbol, (object) obj1));
      if (obj1.BarType == BarType.Time)
        this.barSliceManager.Add(obj0, obj1);
      else
        this.OnNewBar(obj0, obj1);
    }

    
    internal void xuVn4XYwX(long obj0)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
				Trace.WriteLine(string.Format("dfdfd", (object) this.Name, (object) obj0));
      BarSlice barSlice = this.barSliceManager.GetBarSlice(obj0);
      if (barSlice == null)
        return;
      foreach (KeyValuePair<Instrument, Bar> keyValuePair in barSlice.Table)
        this.OnNewBar(keyValuePair.Key, keyValuePair.Value);
      this.OnNewBarSlice(obj0);
      barSlice.Clear();
    }

    
    protected virtual void OnNewOrder(SingleOrder order)
    {
    }

    
    protected virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
    }

    
    protected virtual void OnOrderPartiallyFilled(SingleOrder order)
    {
    }

    
    protected virtual void OnOrderStatusChanged(SingleOrder order)
    {
    }

    
    protected virtual void OnOrderFilled(SingleOrder order)
    {
    }

    
    protected virtual void OnOrderCancelled(SingleOrder order)
    {
    }

    
    protected virtual void OnOrderRejected(SingleOrder order)
    {
    }

    
    protected virtual void OnOrderDone(SingleOrder order)
    {
    }

    
    internal void fuDu5XiFd(SingleOrder obj0)
    {
      Instrument instrument = obj0.Instrument;
      if (obj0.Text != "")
        this.orders.Add(instrument, obj0.Text, obj0);
      this.OnNewOrder(obj0);
    }

    
    internal void a9XY5Muph(SingleOrder obj0, ExecutionReport obj1)
    {
      this.OnExecutionReport(obj0, obj1);
    }

    
    internal void zQxocsRCM(SingleOrder obj0)
    {
      this.OnOrderPartiallyFilled(obj0);
    }

    
    internal void VLka0XAdb(SingleOrder obj0)
    {
      this.OnOrderStatusChanged(obj0);
    }

    
    internal void h8htoZ5ih(SingleOrder obj0)
    {
      switch (obj0.OrdStatus)
      {
        case OrdStatus.Filled:
          this.OnOrderFilled(obj0);
          break;
        case OrdStatus.Cancelled:
          this.OnOrderCancelled(obj0);
          break;
        case OrdStatus.Rejected:
          this.OnOrderRejected(obj0);
          break;
      }
      this.OnOrderDone(obj0);
    }

    
    protected virtual void OnTransactionAdded(Transaction transaction)
    {
    }

    
    protected virtual void OnPositionOpened(Position position)
    {
    }

    
    protected virtual void OnPositionClosed(Position position)
    {
    }

    
    protected virtual void OnPositionChanged(Position position)
    {
    }

    
    protected virtual void OnPortfolioValueChanged(Position position)
    {
    }

    
    internal void CpbdZ1YMZ(Transaction obj0)
    {
      if (!this.isActive)
        return;
      this.portfolio.Add(obj0);
      if (!this.statisticsPerInstrumentEnabled)
        return;
      this.portfolios[obj0.Instrument].Add(obj0);
    }

    
    private void wFewIKaO9(object obj0, TransactionEventArgs obj1)
    {
      this.OnTransactionAdded(obj1.Transaction);
    }

    
    private void tqpmkcdnl(object obj0, PositionEventArgs obj1)
    {
      this.OnPositionOpened(obj1.Position);
    }

    
    private void qmsfx90ud(object obj0, PositionEventArgs obj1)
    {
      this.OnPositionChanged(obj1.Position);
    }

    
    private void iIIeZBW7d(object obj0, PositionEventArgs obj1)
    {
      this.OnPositionClosed(obj1.Position);
    }

    
    private void zqRghd2Zu(object obj0, PositionEventArgs obj1)
    {
      if (!this.isActive)
        return;
      try
      {
        this.OnPortfolioValueChanged(obj1.Position);
      }
      catch (Exception ex)
      {
        this.metaStrategyBase.x6bWBlLIvv(ex);
      }
    }

    public abstract void ClosePosition(Instrument instrument, double price, ComponentType component, string text);

    
    public void ClosePosition(Instrument instrument, string text)
    {
      this.ClosePosition(instrument, 0.0, ComponentType.RiskManager, text);
    }

    
    public void ClosePosition(Instrument instrument)
    {
      this.ClosePosition(instrument, "");
    }

    
    public void ClosePortfolio(string text)
    {
      PositionList positionList = new PositionList();
      foreach (Position position in this.portfolio.Positions)
        positionList.Add(position);
      foreach (Position position in positionList)
        this.ClosePosition(position.Instrument, text);
    }

    
    public void ClosePortfolio()
    {
      this.ClosePortfolio("");
    }

    public abstract IComponentBase GetComponent(ComponentType type);

    public abstract void SetComponent(ComponentType type, IComponentBase component);
  }
}
