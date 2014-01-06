// Type: SmartQuant.Trading.StrategyBase
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using C80OUTlO59SMK8pSMf;
using FGi1Lg83X2hZQGNHP7;
using hfCuV4IXYwXRuD5XiF;
using l3Z5ZAp2dkqyZZDck9P;
using Mm6yRCZTRPYOms3fjc;
using OiroEMuJxAu5mVwsn1;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Series;
using SmartQuant.Services;
using SmartQuant.Testing;
using SmartQuant.Trading.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Trading
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
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Editor(typeof (UnfQ7EceHewVKDD6M2), typeof (UITypeEditor))]
    public ReportManager ReportManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.reportManager;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(600));
        if (this.reportManager != null)
          this.reportManager.Disconnect();
        this.reportManager = value;
        if (this.reportManager != null)
          this.reportManager.Connect();
        this.EmitComponentChanged(ComponentType.ReportManager);
      }
    }

    [TypeConverter(typeof (ComponentTypeConverter))]
    [Editor(typeof (AuQhicqU5DyG28HwyA), typeof (UITypeEditor))]
    [Category("Components")]
    public MarketManager MarketManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.marketManager;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(672));
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.metaStrategyBase;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] internal set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(744));
        this.metaStrategyBase = value;
      }
    }

    [Category("Naming")]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.name;
      }
    }

    [Category("Naming")]
    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.description;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(816));
        this.description = value;
      }
    }

    [DefaultValue(true)]
    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(888));
        this.isEnabled = value;
        this.EmitEnabledChanged();
      }
    }

    [DefaultValue(true)]
    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isActive;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.isActive = value;
      }
    }

    public Hashtable Global
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.global;
      }
    }

    [DefaultValue(false)]
    [Description("Enable or disable gathering statistics for each instrument")]
    public bool StatisticsPerInstrumentEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.statisticsPerInstrumentEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.statisticsPerInstrumentEnabled = value;
      }
    }

    [Browsable(false)]
    public List<ComponentType> ComponentTypeList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.componentTypeList;
      }
    }

    [Category("Providers")]
    [DefaultValue(null)]
    [TypeConverter(typeof (ProviderTypeConverter))]
    [Editor(typeof (ExecutionProviderTypeEditor), typeof (UITypeEditor))]
    public IExecutionProvider ExecutionProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.executionProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(960));
        this.executionProvider = value;
        this.EmitProviderChanged();
      }
    }

    [DefaultValue(null)]
    [TypeConverter(typeof (ProviderTypeConverter))]
    [Category("Providers")]
    [Editor(typeof (MarketDataProviderTypeEditor), typeof (UITypeEditor))]
    public IMarketDataProvider MarketDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.marketDataProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1032));
        this.marketDataProvider = value;
        this.EmitProviderChanged();
      }
    }

    [DefaultValue(null)]
    [Category("Providers")]
    public INewsProvider NewsProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.newsProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1104));
        this.newsProvider = value;
      }
    }

    [Category("Services")]
    [Editor(typeof (ebqyRmnD9vAJyOsaUc), typeof (UITypeEditor))]
    [DefaultValue(null)]
    [TypeConverter(typeof (MN5euIxWQEAnqU3XOr))]
    public IExecutionService ExecutionService
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.executionService;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1176));
        this.executionService = value;
      }
    }

    [Browsable(false)]
    public LiveTester Tester
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tester;
      }
    }

    [Editor(typeof (HIchUSrZnOXCxW67vf), typeof (UITypeEditor))]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.portfolio;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1248));
        this.portfolio = value;
        this.EmitPortfolioChanged();
      }
    }

    [Browsable(false)]
    public StopList Stops
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.stops;
      }
    }

    [Browsable(false)]
    public TriggerList Triggers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.triggers;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.metaStrategyBase.Bars;
      }
    }

    [Browsable(false)]
    public OrderTable Orders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected StrategyBase(string name, string description)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.metaStrategyBase = (MetaStrategyBase) null;
      this.name = name;
      this.description = description;
      this.isEnabled = true;
      this.isActive = true;
      this.ReportManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(440), (object) this) as ReportManager;
      this.MarketManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(520), (object) this) as MarketManager;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnInit()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnStrategyStop()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ztfTe4jp4()
    {
      this.isActive = true;
      this.global.Clear();
      this.stops.Clear();
      this.activeStops.Clear();
      if (this.JEmpWIimOt != null)
        this.JEmpWIimOt((object) this, EventArgs.Empty);
      this.triggers.Clear();
      if (this.DGvp78okLv != null)
        this.DGvp78okLv((object) this, EventArgs.Empty);
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
          portfolio.Name = string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1320), (object) this.name, (object) key.Symbol);
          if (this.metaStrategyBase.MetaStrategyMode == MetaStrategyMode.Live && !this.metaStrategyBase.ResetPortfolio)
            portfolio.Account.Deposit(this.portfolio.GetAccountValue(), this.portfolio.Account.Currency, Clock.Now, USaG3GpjZagj1iVdv4u.Y4misFk9D9(1342));
          LiveTester liveTester = new LiveTester(portfolio);
          liveTester.FollowChanges = true;
          this.portfolios.Add(key, portfolio);
          this.testers.Add(key, liveTester);
          this.tester.FriendlyTesters.Add(key, liveTester);
        }
      }
      this.barSliceManager.InstrumentsCount = this.marketManager.Instruments.Count;
      this.barSliceManager.QGUpQklb9a();
      this.OnInit();
      this.reportManager.Tester = this.tester;
      if (this.MetaStrategyBase.dBEWaCEkLk)
        return;
      this.reportManager.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void AddStop(StopBase stop)
    {
      this.stops.Add((IStop) stop);
      this.activeStops[stop.Instrument].Add(stop);
      if (this.ynApAPhUd7 == null)
        return;
      this.ynApAPhUd7(new StopEventArgs((IStop) stop));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void BSDIytBhT([In] StopBase obj0)
    {
      if (obj0.Status != StopStatus.Active)
        this.activeStops[obj0.Instrument].Remove(obj0);
      if (this.gFbpjXoNEx == null)
        return;
      this.gFbpjXoNEx(new StopEventArgs((IStop) obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pS59UsfU1()
    {
      foreach (StopBase stopBase in this.stops)
        stopBase.Disconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void YFmhKSovu([In] Trigger obj0)
    {
      this.triggers.Add(obj0);
      if (this.RjapR37OfO == null)
        return;
      this.RjapR37OfO(new TriggerEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void l7R1qp1JA([In] Trigger obj0)
    {
      if (this.GZ5pihuIx6 == null)
        return;
      this.GZ5pihuIx6(new TriggerEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Xr8Cv9Ogt()
    {
      foreach (Trigger trigger in this.triggers)
        trigger.rKEA9ZLnkT();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void sX9KD5lfC()
    {
      if (this.statisticsPerInstrumentEnabled)
      {
        foreach (LiveTester liveTester in this.testers.Values)
          liveTester.Disconnect();
      }
      this.tester.Disconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void VgOXd6ZUI()
    {
      StrategyComponentManager.ClearComponentCache((object) this);
      this.metaStrategyBase = (MetaStrategyBase) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void EeVPQ0YHG()
    {
      this.tester.SaveSettings();
      this.tester.DisableComponents();
      this.tester.FollowChanges = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void s4VDgj1ao()
    {
      this.tester.RestoreSettings();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void cXaFP441d([In] double obj0, [In] SmartQuant.Instruments.Currency obj1, [In] DateTime obj2, [In] string obj3)
    {
      this.portfolio.Account.Deposit(obj0, obj1, obj2, obj3);
      foreach (Portfolio portfolio in this.portfolios.Values)
        portfolio.Account.Deposit(obj0, obj1, obj2, obj3);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void qZcLyn7Uf([In] double obj0, [In] SmartQuant.Instruments.Currency obj1, [In] DateTime obj2, [In] string obj3)
    {
      this.portfolio.Account.Withdraw(obj0, obj1, obj2, obj3);
      foreach (Portfolio portfolio in this.portfolios.Values)
        portfolio.Account.Withdraw(obj0, obj1, obj2, obj3);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(Instrument instrument)
    {
      if (this.activeInstruments.Contains(instrument))
        return;
      this.activeInstruments.Add(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(string symbol)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.AddInstrument(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveInstrument(Instrument instrument)
    {
      if (!this.activeInstruments.Contains(instrument))
        return;
      this.activeInstruments.Remove(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveInstrument(string symbol)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        return;
      this.RemoveInstrument(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInstrumentActive(Instrument instrument)
    {
      return this.activeInstruments.Contains(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitProviderChanged()
    {
      if (this.dfCzM9nkh == null)
        return;
      this.dfCzM9nkh((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitPortfolioChanged()
    {
      if (this.HCRpkIgJZ0 == null)
        return;
      this.HCRpkIgJZ0((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitEnabledChanged()
    {
      if (this.eAbppUwn6O == null)
        return;
      this.eAbppUwn6O((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitComponentChanged(ComponentType componentType)
    {
      if (this.hn5p6Upr60 == null)
        return;
      this.hn5p6Upr60((object) this, new ComponentTypeEventArgs(componentType));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitStopAdded(StopBase stop)
    {
      if (this.ynApAPhUd7 == null)
        return;
      this.ynApAPhUd7(new StopEventArgs((IStop) stop));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnProviderConnected(IProvider provider)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnProviderDisconnected(IProvider provider)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnProviderError(IProvider provider, int id, int code, string message)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Jwd3xKdmx([In] IProvider obj0)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1392), (object) this.name, (object) obj0.Name));
      this.OnProviderConnected(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void QNbsERb0O([In] IProvider obj0)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1474), (object) this.name, (object) obj0.Name));
      this.OnProviderDisconnected(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void sHL4bMMk2([In] IProvider obj0, [In] int obj1, [In] int obj2, [In] string obj3)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1562), (object) this.name, (object) obj0.Name, (object) obj1, (object) obj2, (object) obj3));
      this.OnProviderError(obj0, obj1, obj2, obj3);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnServiceStatusChanged(IService service)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnServiceError(IService service, ServiceErrorType errorType, string text)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void aEsJWgP7S([In] IService obj0)
    {
      if (!this.isActive)
        return;
      this.OnServiceStatusChanged(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void A3V0urrUY([In] IService obj0, [In] ServiceErrorType obj1, [In] string obj2)
    {
      if (!this.isActive)
        return;
      this.OnServiceError(obj0, obj1, obj2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewClientOrder(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void acOvnqFOo([In] SingleOrder obj0)
    {
      if (!this.isActive)
        return;
      this.OnNewClientOrder(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RM9EmoIgF([In] ExecutionReport obj0)
    {
      this.MetaStrategyBase.mhsWZDndbE(this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewTrade(Instrument instrument, Trade trade)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewQuote(Instrument instrument, Quote quote)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewFundamental(Instrument instrument, Fundamental fundamental)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewBarOpen(Instrument instrument, Bar bar)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewBar(Instrument instrument, Bar bar)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewBarSlice(long barSize)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void gSQVAlpOg([In] Instrument obj0, [In] Trade obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1642), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewTrade(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void miSxH6BDd([In] Instrument obj0, [In] Quote obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1714), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewQuote(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void NEl89GHdA([In] Instrument obj0, [In] MarketDepth obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1786), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewMarketDepth(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void s05cSUaYk([In] Instrument obj0, [In] Fundamental obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1870), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewFundamental(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void a4glMfvIc([In] Instrument obj0, [In] CorporateAction obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(1954), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewCorporateAction(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void vUSqZnOXC([In] Instrument obj0, [In] Bar obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(2046), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      this.OnNewBarOpen(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void JW6Z7vfHf([In] Instrument obj0, [In] Bar obj1)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(2122), (object) this.Name, (object) obj0.Symbol, (object) obj1));
      if (obj1.BarType == BarType.Time)
        this.barSliceManager.zQGp56LHjL(obj0, obj1);
      else
        this.OnNewBar(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void xuVn4XYwX([In] long obj0)
    {
      if (!this.isActive)
        return;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(2190), (object) this.Name, (object) obj0));
      BarSlice barSlice = this.barSliceManager.jPpp2uI7Tx(obj0);
      if (barSlice == null)
        return;
      foreach (KeyValuePair<Instrument, Bar> keyValuePair in barSlice.Table)
        this.OnNewBar(keyValuePair.Key, keyValuePair.Value);
      this.OnNewBarSlice(obj0);
      barSlice.kxEiMHhItO();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewOrder(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnExecutionReport(SingleOrder order, ExecutionReport report)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderPartiallyFilled(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderStatusChanged(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderFilled(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderCancelled(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderRejected(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderDone(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void fuDu5XiFd([In] SingleOrder obj0)
    {
      Instrument instrument = obj0.Instrument;
      if (obj0.Text != "")
        this.orders.Add(instrument, obj0.Text, obj0);
      this.OnNewOrder(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void a9XY5Muph([In] SingleOrder obj0, [In] ExecutionReport obj1)
    {
      this.OnExecutionReport(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void zQxocsRCM([In] SingleOrder obj0)
    {
      this.OnOrderPartiallyFilled(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void VLka0XAdb([In] SingleOrder obj0)
    {
      this.OnOrderStatusChanged(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void h8htoZ5ih([In] SingleOrder obj0)
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnTransactionAdded(Transaction transaction)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPositionOpened(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPositionClosed(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPositionChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPortfolioValueChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void CpbdZ1YMZ([In] Transaction obj0)
    {
      if (!this.isActive)
        return;
      this.portfolio.Add(obj0);
      if (!this.statisticsPerInstrumentEnabled)
        return;
      this.portfolios[obj0.Instrument].Add(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wFewIKaO9([In] object obj0, [In] TransactionEventArgs obj1)
    {
      this.OnTransactionAdded(obj1.Transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tqpmkcdnl([In] object obj0, [In] PositionEventArgs obj1)
    {
      this.OnPositionOpened(obj1.Position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qmsfx90ud([In] object obj0, [In] PositionEventArgs obj1)
    {
      this.OnPositionChanged(obj1.Position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iIIeZBW7d([In] object obj0, [In] PositionEventArgs obj1)
    {
      this.OnPositionClosed(obj1.Position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zqRghd2Zu([In] object obj0, [In] PositionEventArgs obj1)
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClosePosition(Instrument instrument, string text)
    {
      this.ClosePosition(instrument, 0.0, ComponentType.RiskManager, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClosePosition(Instrument instrument)
    {
      this.ClosePosition(instrument, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClosePortfolio(string text)
    {
      PositionList positionList = new PositionList();
      foreach (Position position in this.portfolio.Positions)
        positionList.Add(position);
      foreach (Position position in positionList)
        this.ClosePosition(position.Instrument, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClosePortfolio()
    {
      this.ClosePortfolio("");
    }

    public abstract IComponentBase GetComponent(ComponentType type);

    public abstract void SetComponent(ComponentType type, IComponentBase component);
  }
}
