using FreeQuant;
using FreeQuant.Charting;
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Optimization;
using FreeQuant.Providers;
using FreeQuant.Series;
using FreeQuant.Services;
using FreeQuant.Simulation;
using FreeQuant.Testing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;


namespace FreeQuant.Trading
{
  public abstract class MetaStrategyBase : IOptimizable
  {
    protected const string CATEGORY_NAMING = "Naming";
    protected const string CATEGORY_COMPONENTS = "Components";
    protected const string CATEGORY_PORTFOLIO = "Portfolio";
    protected const string CATEGORY_DATA_PERSISTENT = "Data Persistent";
    public static readonly MetaStrategyBase.FIXModes FIX_MODES;
    protected string name;
    protected MetaStrategyMode metaStrategyMode;
    protected SimulationManager simulationManager;
    protected ReportManager reportManager;
    protected OptimizationManager optimizationManager;
    protected MetaMoneyManager metaMoneyManager;
    protected StrategyList strategies;
    protected Portfolio portfolio;
    protected LiveTester tester;
    protected Optimizer optimizer;
    protected EOptimizerType optimizerType;
    protected Simulator simulator;
    protected bool isRunning;
    protected bool isOptimizing;
    protected ArrayList optimizationParemeters;
    protected Hashtable drawingPrimitives;
    protected StopList portfolioStopList;
    protected List<ComponentType> componentTypeList;
    protected bool resetPortfolio;
    protected bool saveOrders;
    protected Dictionary<Instrument, Portfolio> portfolios;
    protected Dictionary<Instrument, LiveTester> testers;
    protected bool statisticsPerInstrumentEnabled;
    protected bool executionServicesEnabled;
    private J8EmIiFmOtaja37OfO wufWtLkISI;
    private cLHjLO4PpuI7TxofSw ftRWdJyyOv;
    private TGZcynM7UfxwdxKdmx XY4Ww3QE51;
    private FZ0WAbPUwn6OHn5Upr J37WmrcrSi;
    private ALxag60bMZlMBTZjqL zVLWf0C4Mc;
    private Dictionary<IProvider, List<StrategyBase>> wH2We9sYJA;
    private Dictionary<IMarketDataProvider, Dictionary<Instrument, List<StrategyBase>>> vXRWgwkIPm;
    private Dictionary<SingleOrder, StrategyBase> DKMWNa8OX5;
    private Dictionary<IService, List<StrategyBase>> sbiWzb0PxN;
    private Dictionary<IExecutionService, List<StrategyBase>> EdxRkK8EdT;
    private int a0bRpgOve7;

    [Browsable(false)]
    public Dictionary<Instrument, LiveTester> Testers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.testers;
      }
    }

    [Browsable(false)]
    public Dictionary<Instrument, Portfolio> Portfolios
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.portfolios;
      }
    }

    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    [Editor(typeof (UnfQ7EceHewVKDD6M2), typeof (UITypeEditor))]
    public ReportManager ReportManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.reportManager;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11492));
        if (this.reportManager != null)
          this.reportManager.Disconnect();
        this.reportManager = value;
        if (this.reportManager != null)
          this.reportManager.Connect();
        this.EmitComponentChanged(ComponentType.ReportManager);
      }
    }

    [Editor(typeof (mbOf2LE4jkDGBpCa2Y), typeof (UITypeEditor))]
    [Category("Components")]
    [TypeConverter(typeof (ComponentTypeConverter))]
    public SimulationManager SimulationManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.simulationManager;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11564));
        if (this.simulationManager != null)
          this.simulationManager.Disconnect();
        this.simulationManager = value;
        if (this.simulationManager != null)
          this.simulationManager.Connect();
        this.EmitComponentChanged(ComponentType.SimulationManager);
      }
    }

    [Editor(typeof (chsY6falPQStx6bpTI), typeof (UITypeEditor))]
    [TypeConverter(typeof (ComponentTypeConverter))]
    [Category("Components")]
    public OptimizationManager OptimizationManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.optimizationManager;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11636));
        if (this.optimizationManager != null)
        {
          this.optimizationManager.Disconnect();
          this.optimizationManager.MetaStrategyBase = (MetaStrategyBase) null;
        }
        this.optimizationManager = value;
        if (this.optimizationManager != null)
        {
          this.optimizationManager.MetaStrategyBase = this;
          this.optimizationManager.Connect();
        }
        this.EmitComponentChanged(ComponentType.OptimizationManager);
      }
    }

    [Category("Components")]
    [Editor(typeof (tIGBlRd1EZTyP5xVwg), typeof (UITypeEditor))]
    [TypeConverter(typeof (ComponentTypeConverter))]
    public MetaMoneyManager MetaMoneyManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.metaMoneyManager;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11708));
        if (this.metaMoneyManager != null)
        {
          this.metaMoneyManager.Disconnect();
          this.metaMoneyManager.MetaStrategyBase = (MetaStrategyBase) null;
        }
        this.metaMoneyManager = value;
        if (this.metaMoneyManager != null)
        {
          this.metaMoneyManager.MetaStrategyBase = this;
          this.metaMoneyManager.Connect();
        }
        this.EmitComponentChanged(ComponentType.MetaMoneyManager);
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

    [DefaultValue(10)]
    [Description("Maximum connection time to providers in seconds.")]
    public int MaxConnectionTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a0bRpgOve7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value < 1 || value > 60)
          throw new ArgumentOutOfRangeException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11780), USaG3GpjZagj1iVdv4u.Y4misFk9D9(11818));
        this.a0bRpgOve7 = value;
      }
    }

    [DefaultValue(MetaStrategyMode.Simulation)]
    public MetaStrategyMode MetaStrategyMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.metaStrategyMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11886));
        this.metaStrategyMode = value;
        this.EmitChanged();
      }
    }

    [Category("Portfolio")]
    [Editor(typeof (HIchUSrZnOXCxW67vf), typeof (UITypeEditor))]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.portfolio;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11958));
        this.portfolio = value;
        this.EmitChanged();
      }
    }

    [DefaultValue(true)]
    [Category("Data Persistent")]
    [Description("Gets or sets a value indicating whether the portfolio will be cleared when metastrategy start in LIVE mode.")]
    public bool ResetPortfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.resetPortfolio;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.resetPortfolio = value;
      }
    }

    [Description("Gets or sets a value indicating whether orders will be saved in LIVE mode.")]
    [DefaultValue(false)]
    [Category("Data Persistent")]
    public bool SaveOrders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.saveOrders;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.saveOrders = value;
      }
    }

    [Description("Enable or disable gathering statistics for each instrument")]
    [DefaultValue(false)]
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

    [DefaultValue(false)]
    public bool ExecutionServicesEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.executionServicesEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12030));
        this.executionServicesEnabled = value;
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

    [Browsable(false)]
    public Optimizer Optimizer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.optimizer;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12102));
        if (this.optimizer == value)
          return;
        if (this.optimizer != null)
          this.optimizer.BestObjectiveReceived -= new EventHandler(this.S1PWnXiNYV);
        this.optimizer = value;
        this.optimizer.BestObjectiveReceived += new EventHandler(this.S1PWnXiNYV);
      }
    }

    [DefaultValue(EOptimizerType.BruteForce)]
    public EOptimizerType OptimizerType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.optimizerType;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!this.DesignMode)
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12174));
        if (value == this.optimizerType)
          return;
        if (this.optimizer != null)
          this.optimizer.BestObjectiveReceived -= new EventHandler(this.S1PWnXiNYV);
        this.optimizerType = value;
        switch (this.optimizerType)
        {
          case EOptimizerType.SimulatedAnnealing:
            this.optimizer = (Optimizer) new SimulatedAnnealing((IOptimizable) this);
            break;
          case EOptimizerType.BruteForce:
            this.optimizer = (Optimizer) new BruteForce((IOptimizable) this);
            break;
        }
        this.optimizer.BestObjectiveReceived += new EventHandler(this.S1PWnXiNYV);
      }
    }

    [Browsable(false)]
    public StrategyList Strategies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.strategies;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return DataManager.Bars;
      }
    }

    [Browsable(false)]
    public bool DesignMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (!this.isRunning)
          return !this.isOptimizing;
        else
          return false;
      }
    }

    [Browsable(false)]
    internal bool ahdWYv7joQ
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isRunning;
      }
    }

    [Browsable(false)]
    internal bool dBEWaCEkLk
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isOptimizing;
      }
    }

    [Browsable(false)]
    public Hashtable DrawingPrimitives
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.drawingPrimitives;
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

    public event EventHandler Changed;

    public event ComponentTypeEventHandler ComponentChanged;

    public event EventHandler Started;

    public event EventHandler Stopped;

    public event EventHandler Paused;

    public event EventHandler DesignModeChanged;

    public event MetaStrategyErrorEventHandler Error;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MetaStrategyBase()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      MetaStrategyBase.FIX_MODES = new MetaStrategyBase.FIXModes();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected MetaStrategyBase(string name)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.name = name;
      this.strategies = new StrategyList();
      this.SimulationManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11172), (object) this) as SimulationManager;
      this.OptimizationManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11252), (object) this) as OptimizationManager;
      this.ReportManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11332), (object) this) as ReportManager;
      this.MetaMoneyManager = StrategyComponentManager.GetComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11412), (object) this) as MetaMoneyManager;
      this.portfolio = PortfolioManager.Portfolios[name];
      if (this.portfolio == null)
        this.portfolio = new Portfolio(name);
      this.resetPortfolio = true;
      this.tester = new LiveTester(this.portfolio);
      this.tester.FollowChanges = true;
      this.optimizer = (Optimizer) new BruteForce((IOptimizable) this);
      this.optimizer.BestObjectiveReceived += new EventHandler(this.S1PWnXiNYV);
      this.optimizerType = EOptimizerType.BruteForce;
      this.wufWtLkISI = new J8EmIiFmOtaja37OfO(this);
      this.ftRWdJyyOv = new cLHjLO4PpuI7TxofSw(this);
      this.XY4Ww3QE51 = new TGZcynM7UfxwdxKdmx(this);
      this.J37WmrcrSi = new FZ0WAbPUwn6OHn5Upr(this);
      this.zVLWf0C4Mc = new ALxag60bMZlMBTZjqL(this);
      this.wH2We9sYJA = new Dictionary<IProvider, List<StrategyBase>>();
      this.vXRWgwkIPm = new Dictionary<IMarketDataProvider, Dictionary<Instrument, List<StrategyBase>>>();
      this.DKMWNa8OX5 = new Dictionary<SingleOrder, StrategyBase>();
      this.sbiWzb0PxN = new Dictionary<IService, List<StrategyBase>>();
      this.EdxRkK8EdT = new Dictionary<IExecutionService, List<StrategyBase>>();
      this.a0bRpgOve7 = 10;
      this.simulator = (ProviderManager.MarketDataSimulator as SimulationDataProvider).Simulator;
      this.simulator.StateChanged += new EventHandler(this.md8Wiw2OiW);
      this.isRunning = false;
      this.isOptimizing = false;
      this.optimizationParemeters = new ArrayList();
      this.drawingPrimitives = new Hashtable();
      this.portfolioStopList = new StopList();
      this.portfolios = new Dictionary<Instrument, Portfolio>();
      this.testers = new Dictionary<Instrument, LiveTester>();
      this.executionServicesEnabled = false;
      this.componentTypeList = new List<ComponentType>();
      this.componentTypeList.Add(ComponentType.SimulationManager);
      this.componentTypeList.Add(ComponentType.MetaMoneyManager);
      this.componentTypeList.Add(ComponentType.OptimizationManager);
      this.componentTypeList.Add(ComponentType.ReportManager);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(StrategyBase strategy)
    {
      if (!this.DesignMode)
        throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12246));
      this.strategies.sHVpbkHDLx(strategy);
      strategy.MetaStrategyBase = this;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(StrategyBase strategy)
    {
      if (!this.DesignMode)
        throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12318));
      this.strategies.Sg6pybMZlM(strategy);
      strategy.MetaStrategyBase = (MetaStrategyBase) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close()
    {
      this.simulator.StateChanged -= new EventHandler(this.md8Wiw2OiW);
      foreach (StrategyBase strategyBase in this.strategies)
        strategyBase.VgOXd6ZUI();
      StrategyComponentManager.ClearComponentCache((object) this);
      this.Portfolio = (Portfolio) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void XgxWjskRHv([In] PortfolioStop obj0)
    {
      this.portfolioStopList.Add((IStop) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RF4WWZ565m()
    {
      foreach (PortfolioStop portfolioStop in this.portfolioStopList)
        portfolioStop.Disconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopOptimization()
    {
      this.optimizer.Stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnInit()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnMoneyAllocation()
    {
      this.metaMoneyManager.Allocate();
      this.portfolio.Performance.Init();
      foreach (StrategyBase strategyBase in this.strategies)
        strategyBase.Portfolio.Performance.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start(bool doStep)
    {
      DataManager.ClearDataArrays();
      this.drawingPrimitives.Clear();
      this.wH2We9sYJA.Clear();
      this.vXRWgwkIPm.Clear();
      this.DKMWNa8OX5.Clear();
      this.wufWtLkISI.EHNjIxPXeI();
      this.ftRWdJyyOv.CRrjLvZRte();
      this.XY4Ww3QE51.WlPpnQStx6();
      this.sbiWzb0PxN.Clear();
      this.EdxRkK8EdT.Clear();
      this.J37WmrcrSi.PICjBUA7Ya();
      this.zVLWf0C4Mc.G7CjuFqKCk();
      if (this.metaStrategyMode == MetaStrategyMode.Simulation)
      {
        this.simulationManager.Requests.Clear();
        this.simulationManager.Init();
        Clock.ClockMode = ClockMode.Simulation;
        Clock.SetDateTime(this.simulationManager.EntryDate);
        foreach (string request in (CollectionBase) this.simulationManager.StaticRequests)
          this.simulationManager.SendMarketDataRequest(request);
        this.simulator.Intervals.Clear();
        this.simulator.Intervals.Add(this.simulationManager.EntryDate, this.simulationManager.ExitDate);
        this.simulator.SimulationMode = this.simulationManager.Mode;
        this.simulator.SpeedMultiplier = this.simulationManager.SpeedMultiplier;
        this.simulator.Step = this.simulationManager.Step;
        OrderManager.RemoveOrders(11104, (object) MetaStrategyBase.FIX_MODES[this.metaStrategyMode]);
        OrderManager.OCA.Clear();
        OrderManager.SellSide.RemoveOrders(11104, (object) MetaStrategyBase.FIX_MODES[this.metaStrategyMode]);
      }
      if (this.metaStrategyMode == MetaStrategyMode.Simulation || this.metaStrategyMode == MetaStrategyMode.Live && this.resetPortfolio)
      {
        this.portfolio.Clear();
        this.portfolios.Clear();
        this.testers.Clear();
        this.tester.FriendlyTesters.Clear();
      }
      this.tester.Disconnect();
      this.tester.Connect();
      this.tester.Reset();
      bool flag = this.portfolio.Account.Transactions.Count == 0;
      if (flag)
        this.portfolio.Account.Deposit(this.simulationManager.Cash, this.simulationManager.Currency, Clock.Now, USaG3GpjZagj1iVdv4u.Y4misFk9D9(12390));
      this.portfolio.TransactionAdded += new TransactionEventHandler(this.zYSWMuDaZ6);
      this.portfolio.PositionOpened += new PositionEventHandler(this.DBwWbS3fHQ);
      this.portfolio.PositionChanged += new PositionEventHandler(this.dHgWygCawL);
      this.portfolio.PositionClosed += new PositionEventHandler(this.fBgWGZmneO);
      this.portfolio.ValueChanged += new PositionEventHandler(this.lrZWS42MFZ);
      this.portfolio.Monitored = true;
      this.optimizationManager.Init();
      if (!this.isOptimizing)
      {
        this.reportManager.Tester = this.tester;
        this.reportManager.Init();
      }
      this.metaMoneyManager.Init();
      this.OnInit();
      foreach (StrategyBase strategyBase in this.strategies)
      {
        if (strategyBase.IsEnabled)
          strategyBase.ztfTe4jp4();
      }
      if (flag)
        this.OnMoneyAllocation();
      if (this.statisticsPerInstrumentEnabled)
      {
        foreach (LiveTester liveTester in this.testers.Values)
        {
          liveTester.Connect();
          liveTester.Reset();
        }
        foreach (StrategyBase strategyBase in this.strategies)
        {
          if (strategyBase.IsEnabled)
          {
            foreach (Instrument key in (FIXGroupList) strategyBase.MarketManager.Instruments)
            {
              if (!this.portfolios.ContainsKey(key))
              {
                Portfolio portfolio = new Portfolio();
                portfolio.Name = string.Format(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12440), (object) this.name, (object) key.Symbol);
                LiveTester liveTester = new LiveTester(portfolio);
                liveTester.FollowChanges = true;
                this.portfolios.Add(key, portfolio);
                this.testers.Add(key, liveTester);
                this.tester.FriendlyTesters.Add(key, liveTester);
                portfolio.Account.Deposit(this.portfolio.GetAccountValue(), this.portfolio.Account.Currency, Clock.Now, USaG3GpjZagj1iVdv4u.Y4misFk9D9(12462));
              }
            }
          }
        }
      }
      foreach (StrategyBase strategyBase in this.strategies)
      {
        if (strategyBase.IsEnabled)
        {
          switch (this.metaStrategyMode)
          {
            case MetaStrategyMode.Simulation:
              this.XY4Ww3QE51.opTpuIsCq8(ProviderManager.ExecutionSimulator);
              this.wufWtLkISI.q4hj9rUKgj((IProvider) ProviderManager.MarketDataSimulator);
              this.wufWtLkISI.q4hj9rUKgj((IProvider) ProviderManager.ExecutionSimulator);
              this.fkKW08cp5Q((IProvider) ProviderManager.MarketDataSimulator, strategyBase);
              this.fkKW08cp5Q((IProvider) ProviderManager.ExecutionSimulator, strategyBase);
              break;
            case MetaStrategyMode.Live:
              using (Dictionary<Instrument, IExecutionProvider>.ValueCollection.Enumerator enumerator = strategyBase.MarketManager.UyiAAd6ITD.Values.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  IExecutionProvider current = enumerator.Current;
                  this.fkKW08cp5Q((IProvider) current, strategyBase);
                  this.XY4Ww3QE51.opTpuIsCq8(current);
                  this.wufWtLkISI.q4hj9rUKgj((IProvider) current);
                }
                break;
              }
          }
          foreach (KeyValuePair<Instrument, IMarketDataProvider> keyValuePair in strategyBase.MarketManager.jcIApP7GcT)
          {
            Instrument key = keyValuePair.Key;
            switch (this.metaStrategyMode)
            {
              case MetaStrategyMode.Simulation:
                foreach (string str in (CollectionBase) this.simulationManager.Requests)
                  this.ftRWdJyyOv.s8pj3BZbXy(ProviderManager.MarketDataSimulator, key, str);
                this.gKXWX8nbQ1(ProviderManager.MarketDataSimulator, key, strategyBase);
                continue;
              case MetaStrategyMode.Live:
                IMarketDataProvider marketDataProvider = keyValuePair.Value;
                this.ftRWdJyyOv.s8pj3BZbXy(marketDataProvider, key, (string) null);
                this.wufWtLkISI.q4hj9rUKgj((IProvider) marketDataProvider);
                this.fkKW08cp5Q((IProvider) marketDataProvider, strategyBase);
                this.gKXWX8nbQ1(marketDataProvider, key, strategyBase);
                continue;
              default:
                continue;
            }
          }
        }
      }
      this.wufWtLkISI.qGIjh9udFb(this.a0bRpgOve7 * 1000);
      this.ftRWdJyyOv.ONMjs3DrA4();
      this.XY4Ww3QE51.W2BpYr8f5G();
      if (this.executionServicesEnabled)
      {
        foreach (StrategyBase strategyBase in this.strategies)
        {
          switch (this.metaStrategyMode)
          {
            case MetaStrategyMode.Simulation:
              this.FYDWx9TtsR((IService) ServiceManager.ExecutionSimulator, strategyBase);
              continue;
            case MetaStrategyMode.Live:
              if (strategyBase.ExecutionService != null)
              {
                this.FYDWx9TtsR((IService) strategyBase.ExecutionService, strategyBase);
                continue;
              }
              else
                continue;
            default:
              continue;
          }
        }
        this.J37WmrcrSi.D3Cjbhc7hR();
        this.zVLWf0C4Mc.alJjoPx37X();
      }
      this.isRunning = true;
      switch (this.metaStrategyMode)
      {
        case MetaStrategyMode.Simulation:
          if (doStep)
          {
            this.simulator.DoStep(false);
            while (this.isRunning)
              Thread.Sleep(1);
            break;
          }
          else
          {
            this.simulator.Start(true);
            break;
          }
        case MetaStrategyMode.Live:
          this.Y5hW7EWwMM();
          while (this.isRunning)
            Thread.Sleep(1);
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Continue()
    {
      if (this.metaStrategyMode != MetaStrategyMode.Simulation)
        return;
      this.simulator.Continue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoStep()
    {
      if (this.metaStrategyMode != MetaStrategyMode.Simulation)
        return;
      this.simulator.DoStep(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop()
    {
      if (this.metaStrategyMode == MetaStrategyMode.Simulation)
        this.simulator.Stop(false);
      else
        this.LLVWRbKKLm();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnMetaStrategyStop()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LLVWRbKKLm()
    {
      if (this.DesignMode)
        return;
      this.isRunning = false;
      this.wufWtLkISI.onFj1yqJ1t();
      this.ftRWdJyyOv.cahj40CaiV();
      this.XY4Ww3QE51.zWOpo5aIIG();
      if (this.executionServicesEnabled)
      {
        this.J37WmrcrSi.p8JjyqE8BW();
        this.zVLWf0C4Mc.ApOjaGLtYD();
      }
      this.metaMoneyManager.OnStrategyStop();
      this.OnMetaStrategyStop();
      this.portfolio.TransactionAdded -= new TransactionEventHandler(this.zYSWMuDaZ6);
      this.portfolio.PositionOpened -= new PositionEventHandler(this.DBwWbS3fHQ);
      this.portfolio.PositionChanged -= new PositionEventHandler(this.dHgWygCawL);
      this.portfolio.PositionClosed -= new PositionEventHandler(this.fBgWGZmneO);
      this.portfolio.ValueChanged -= new PositionEventHandler(this.lrZWS42MFZ);
      this.portfolio.Monitored = false;
      foreach (Portfolio portfolio in this.portfolios.Values)
        portfolio.Monitored = false;
      this.tester.Disconnect();
      foreach (LiveTester liveTester in this.testers.Values)
        liveTester.Disconnect();
      this.RF4WWZ565m();
      foreach (StrategyBase strategyBase in this.strategies)
      {
        if (strategyBase.IsEnabled)
          strategyBase.Y9KryiX9N();
      }
      this.simulationManager.OnStrategyStop();
      this.optimizationManager.OnStrategyStop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pause()
    {
      if (this.metaStrategyMode != MetaStrategyMode.Simulation)
        return;
      this.simulator.Pause();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void md8Wiw2OiW([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.isRunning || this.metaStrategyMode != MetaStrategyMode.Simulation)
        return;
      switch (this.simulator.CurrentState)
      {
        case SimulatorState.Stopped:
          this.LLVWRbKKLm();
          this.RB1WHrXL2Y();
          break;
        case SimulatorState.Running:
          this.Y5hW7EWwMM();
          break;
        case SimulatorState.Paused:
          this.y5mWUvQDgw();
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitChanged()
    {
      if (this.cTZR6RXBpY == null)
        return;
      this.cTZR6RXBpY((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitComponentChanged(ComponentType componentType)
    {
      if (this.Bb7RAdfEEP == null)
        return;
      this.Bb7RAdfEEP((object) this, new ComponentTypeEventArgs(componentType));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Y5hW7EWwMM()
    {
      if (this.CGGRjb488b == null)
        return;
      this.CGGRjb488b((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RB1WHrXL2Y()
    {
      if (this.mImRWndI7U == null)
        return;
      this.mImRWndI7U((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void y5mWUvQDgw()
    {
      if (this.KjiRRox3yo == null)
        return;
      this.KjiRRox3yo((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ilMWOLBmjv()
    {
      if (this.a1BRiQhS5G == null)
        return;
      this.a1BRiQhS5G((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void tBaWQo3SVu()
    {
      this.tester.SaveSettings();
      this.tester.DisableComponents();
      this.tester.FollowChanges = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void W31W5ysSK0()
    {
      this.tester.RestoreSettings();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Optimize()
    {
      if (this.isRunning)
        throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12512));
      try
      {
        this.isOptimizing = true;
        this.tBaWQo3SVu();
        foreach (StrategyBase strategyBase in this.strategies)
        {
          if (strategyBase.IsEnabled)
            strategyBase.EeVPQ0YHG();
        }
        this.optimizer.Clear();
        this.optimizer.Optimize();
      }
      finally
      {
        this.W31W5ysSK0();
        foreach (StrategyBase strategyBase in this.strategies)
        {
          if (strategyBase.IsEnabled)
            strategyBase.s4VDgj1ao();
        }
        this.isOptimizing = false;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void zeFW20hc2d([In] Instrument obj0, [In] IDrawable obj1, [In] int obj2)
    {
      if (!this.drawingPrimitives.ContainsKey((object) obj0))
      {
        this.drawingPrimitives.Add((object) obj0, (object) new SortedList()
        {
          {
            (object) obj2,
            (object) new ArrayList()
            {
              (object) obj1
            }
          }
        });
      }
      else
      {
        SortedList sortedList = this.drawingPrimitives[(object) obj0] as SortedList;
        if (!sortedList.ContainsKey((object) obj2))
        {
          sortedList.Add((object) obj2, (object) new ArrayList()
          {
            (object) obj1
          });
        }
        else
        {
          ArrayList arrayList = sortedList[(object) obj2] as ArrayList;
          bool flag = true;
          if (obj1 is TimeSeries)
          {
            for (int index = 0; index < arrayList.Count; ++index)
            {
              if (arrayList[index] is TimeSeries && (obj1 as TimeSeries).Name == (arrayList[index] as TimeSeries).Name && (obj1 as TimeSeries).Name != "")
              {
                flag = false;
                break;
              }
            }
          }
          if (!flag)
            return;
          arrayList.Add((object) obj1);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void x6bWBlLIvv([In] Exception obj0)
    {
      if (Trace.IsLevelEnabled(TraceLevel.Error))
        Trace.WriteLine(((object) obj0).ToString());
      MetaStrategyErrorEventArgs args = new MetaStrategyErrorEventArgs(obj0);
      if (this.f4QR7MSgh5 != null)
        this.f4QR7MSgh5(args);
      if (args.Ignore)
        return;
      this.Stop();
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
    protected virtual void OnPositionChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPositionClosed(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPortfolioValueChanged(Position position)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zYSWMuDaZ6([In] object obj0, [In] TransactionEventArgs obj1)
    {
      try
      {
        Transaction transaction = obj1.Transaction;
        if (this.statisticsPerInstrumentEnabled)
          this.portfolios[transaction.Instrument].Add(transaction);
        this.strategies[transaction.Strategy].CpbdZ1YMZ(transaction);
        this.OnTransactionAdded(transaction);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DBwWbS3fHQ([In] object obj0, [In] PositionEventArgs obj1)
    {
      try
      {
        Position position = obj1.Position;
        this.metaMoneyManager.OnPositionOpened(position);
        this.OnPositionOpened(position);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dHgWygCawL([In] object obj0, [In] PositionEventArgs obj1)
    {
      try
      {
        Position position = obj1.Position;
        this.metaMoneyManager.OnPositionChanged(position);
        this.OnPositionChanged(position);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fBgWGZmneO([In] object obj0, [In] PositionEventArgs obj1)
    {
      try
      {
        Position position = obj1.Position;
        this.metaMoneyManager.OnPositionClosed(position);
        this.OnPositionClosed(position);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lrZWS42MFZ([In] object obj0, [In] PositionEventArgs obj1)
    {
      try
      {
        Position position = obj1.Position;
        this.metaMoneyManager.OnPortfolioValueChanged(position.Portfolio);
        this.metaMoneyManager.OnPositionValueChanged(position);
        this.OnPortfolioValueChanged(position);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
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
    internal void vJjWTiUXYj([In] BarEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        Bar bar = obj0.Bar;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.vUSqZnOXC(instrument, bar);
        this.metaMoneyManager.OnBarOpen(instrument, bar);
        this.OnNewBarOpen(instrument, bar);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void o5eWrOl4Ph([In] BarEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        Bar bar = obj0.Bar;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.JW6Z7vfHf(instrument, bar);
        this.metaMoneyManager.OnBar(instrument, bar);
        this.OnNewBar(instrument, bar);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void z63WIUgWPv([In] BarSliceEventArgs obj0)
    {
      try
      {
        long barSize = obj0.BarSize;
        foreach (StrategyBase strategyBase in this.strategies)
        {
          if (strategyBase.IsEnabled)
            strategyBase.xuVn4XYwX(barSize);
        }
        this.OnNewBarSlice(barSize);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void CMFW95B91R([In] TradeEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        Trade trade = obj0.Trade;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.gSQVAlpOg(instrument, trade);
        this.metaMoneyManager.OnTrade(instrument, trade);
        this.OnNewTrade(instrument, trade);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ERTWhrXHxn([In] QuoteEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        Quote quote = obj0.Quote;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.miSxH6BDd(instrument, quote);
        this.metaMoneyManager.OnQuote(instrument, quote);
        this.OnNewQuote(instrument, quote);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RygW1dLdu5([In] MarketDepthEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        MarketDepth marketDepth = obj0.MarketDepth;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.NEl89GHdA(instrument, marketDepth);
        this.metaMoneyManager.OnMarketDepth(instrument, marketDepth);
        this.OnNewMarketDepth(instrument, marketDepth);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void sQ5WCiEY3a([In] FundamentalEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        Fundamental fundamental = obj0.Fundamental;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.s05cSUaYk(instrument, fundamental);
        this.metaMoneyManager.OnFundamental(instrument, fundamental);
        this.OnNewFundamental(instrument, fundamental);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void VugWKRGNRX([In] CorporateActionEventArgs obj0)
    {
      try
      {
        Instrument instrument = obj0.Instrument as Instrument;
        CorporateAction corporateAction = obj0.CorporateAction;
        foreach (StrategyBase strategyBase in this.MU0WP1r0b1(obj0.Provider, instrument))
          strategyBase.a4glMfvIc(instrument, corporateAction);
        this.metaMoneyManager.OnCorporateAction(instrument, corporateAction);
        this.OnNewCorporateAction(instrument, corporateAction);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gKXWX8nbQ1([In] IMarketDataProvider obj0, [In] Instrument obj1, [In] StrategyBase obj2)
    {
      Dictionary<Instrument, List<StrategyBase>> dictionary = (Dictionary<Instrument, List<StrategyBase>>) null;
      if (!this.vXRWgwkIPm.TryGetValue(obj0, out dictionary))
      {
        dictionary = new Dictionary<Instrument, List<StrategyBase>>();
        this.vXRWgwkIPm.Add(obj0, dictionary);
      }
      List<StrategyBase> list = (List<StrategyBase>) null;
      if (!dictionary.TryGetValue(obj1, out list))
      {
        list = new List<StrategyBase>();
        dictionary.Add(obj1, list);
      }
      if (list.Contains(obj2))
        return;
      list.Add(obj2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<StrategyBase> MU0WP1r0b1([In] IMarketDataProvider obj0, [In] Instrument obj1)
    {
      Dictionary<Instrument, List<StrategyBase>> dictionary = (Dictionary<Instrument, List<StrategyBase>>) null;
      List<StrategyBase> list = (List<StrategyBase>) null;
      if (this.vXRWgwkIPm.TryGetValue(obj0, out dictionary))
      {
        if (!dictionary.TryGetValue(obj1, out list))
          list = new List<StrategyBase>();
      }
      else
        list = new List<StrategyBase>();
      return list;
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
    internal void qiPWDy4hl5([In] OrderEventArgs obj0)
    {
      try
      {
        SingleOrder order = obj0.Order;
        StrategyBase strategyBase = (StrategyBase) null;
        if (!this.DKMWNa8OX5.TryGetValue(order, out strategyBase))
          return;
        strategyBase.fuDu5XiFd(order);
        this.OnNewOrder(order);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void pTPWFkTQoi([In] ExecutionReportEventArgs obj0)
    {
      try
      {
        ExecutionReport executionReport = obj0.ExecutionReport;
        SingleOrder singleOrder;
        switch (executionReport.OrdStatus)
        {
          case OrdStatus.Cancelled:
          case OrdStatus.PendingCancel:
          case OrdStatus.PendingReplace:
            singleOrder = OrderManager.Orders.All[executionReport.OrigClOrdID] as SingleOrder;
            break;
          default:
            singleOrder = OrderManager.Orders.All[executionReport.ClOrdID] as SingleOrder;
            break;
        }
        if (singleOrder == null)
          return;
        StrategyBase strategyBase = (StrategyBase) null;
        if (!this.DKMWNa8OX5.TryGetValue(singleOrder, out strategyBase))
          return;
        strategyBase.a9XY5Muph(singleOrder, executionReport);
        this.OnExecutionReport(singleOrder, executionReport);
        if (singleOrder.OrdStatus != OrdStatus.PartiallyFilled)
          return;
        strategyBase.zQxocsRCM(singleOrder);
        this.OnOrderPartiallyFilled(singleOrder);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void KYbWL8Zacm([In] OrderEventArgs obj0)
    {
      try
      {
        SingleOrder order = obj0.Order;
        StrategyBase strategyBase = (StrategyBase) null;
        if (!this.DKMWNa8OX5.TryGetValue(order, out strategyBase))
          return;
        strategyBase.VLka0XAdb(order);
        this.OnOrderStatusChanged(order);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void QWkW3X5uDE([In] OrderEventArgs obj0)
    {
      try
      {
        SingleOrder order = obj0.Order;
        StrategyBase strategyBase = (StrategyBase) null;
        if (!this.DKMWNa8OX5.TryGetValue(order, out strategyBase))
          return;
        strategyBase.h8htoZ5ih(order);
        switch (order.OrdStatus)
        {
          case OrdStatus.Filled:
            this.OnOrderFilled(order);
            break;
          case OrdStatus.Cancelled:
            this.OnOrderCancelled(order);
            break;
          case OrdStatus.Rejected:
            this.OnOrderRejected(order);
            break;
        }
        this.OnOrderDone(order);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
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
    internal void txIWsJO2he([In] ProviderEventArgs obj0)
    {
      try
      {
        IProvider provider = obj0.Provider;
        foreach (StrategyBase strategyBase in this.aI6WvCF8X7(provider))
          strategyBase.Jwd3xKdmx(provider);
        this.metaMoneyManager.OnProviderConnected(provider);
        this.OnProviderConnected(provider);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UdPW4GYdNW([In] ProviderEventArgs obj0)
    {
      try
      {
        IProvider provider = obj0.Provider;
        foreach (StrategyBase strategyBase in this.aI6WvCF8X7(provider))
          strategyBase.QNbsERb0O(provider);
        this.metaMoneyManager.OnProviderDisconnected(provider);
        this.OnProviderDisconnected(provider);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void gLeWJjZWZB([In] ProviderErrorEventArgs obj0)
    {
      try
      {
        IProvider provider = obj0.Error.Provider;
        int id = obj0.Error.Id;
        int code = obj0.Error.Code;
        string message = obj0.Error.Message;
        foreach (StrategyBase strategyBase in this.aI6WvCF8X7(provider))
          strategyBase.sHL4bMMk2(provider, id, code, message);
        this.metaMoneyManager.OnProviderError(provider, id, code, message);
        this.OnProviderError(provider, id, code, message);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fkKW08cp5Q([In] IProvider obj0, [In] StrategyBase obj1)
    {
      List<StrategyBase> list = (List<StrategyBase>) null;
      if (!this.wH2We9sYJA.TryGetValue(obj0, out list))
      {
        list = new List<StrategyBase>();
        this.wH2We9sYJA.Add(obj0, list);
      }
      if (list.Contains(obj1))
        return;
      list.Add(obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<StrategyBase> aI6WvCF8X7([In] IProvider obj0)
    {
      return this.wH2We9sYJA[obj0];
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
    internal void aBSWEaVDQP([In] ServiceEventArgs obj0)
    {
      try
      {
        IService service = obj0.Service;
        foreach (StrategyBase strategyBase in this.Y1oW8BMCy0(service))
          strategyBase.aEsJWgP7S(service);
        this.OnServiceStatusChanged(service);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Rb9WVwNDDG([In] ServiceErrorEventArgs obj0)
    {
      try
      {
        IService service = obj0.Error.Service;
        ServiceErrorType errorType = obj0.Error.ErrorType;
        string text = obj0.Error.Text;
        foreach (StrategyBase strategyBase in this.Y1oW8BMCy0(service))
          strategyBase.A3V0urrUY(service, errorType, text);
        this.OnServiceError(service, errorType, text);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FYDWx9TtsR([In] IService obj0, [In] StrategyBase obj1)
    {
      List<StrategyBase> list;
      if (!this.sbiWzb0PxN.TryGetValue(obj0, out list))
      {
        list = new List<StrategyBase>();
        this.sbiWzb0PxN.Add(obj0, list);
      }
      if (!list.Contains(obj1))
        list.Add(obj1);
      this.J37WmrcrSi.DgojM4ZghC(obj0);
      if (!(obj0 is IExecutionService))
        return;
      IExecutionService key = obj0 as IExecutionService;
      if (!this.EdxRkK8EdT.TryGetValue(key, out list))
      {
        list = new List<StrategyBase>();
        this.EdxRkK8EdT.Add(key, list);
      }
      if (!list.Contains(obj1))
        list.Add(obj1);
      this.zVLWf0C4Mc.J12jYHwSJS(key);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<StrategyBase> Y1oW8BMCy0([In] IService obj0)
    {
      return this.sbiWzb0PxN[obj0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnNewClientOrder(SingleOrder order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void t9wWcw5Scy([In] NewOrderSingleEventArgs obj0)
    {
      try
      {
        SingleOrder order = obj0.Order as SingleOrder;
        order.StrategyMode = MetaStrategyBase.FIX_MODES[this.metaStrategyMode];
        foreach (StrategyBase strategyBase in this.BA5WlUco8U(obj0.Service))
          strategyBase.acOvnqFOo(order);
        this.OnNewClientOrder(order);
      }
      catch (Exception ex)
      {
        this.x6bWBlLIvv(ex);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<StrategyBase> BA5WlUco8U([In] IExecutionService obj0)
    {
      return this.EdxRkK8EdT[obj0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void cWMWqoTObJ([In] StrategyBase obj0, [In] SingleOrder obj1)
    {
      obj1.Portfolio = this.portfolio;
      switch (this.metaStrategyMode)
      {
        case MetaStrategyMode.Simulation:
          obj1.Provider = ProviderManager.ExecutionSimulator;
          break;
        case MetaStrategyMode.Live:
          obj1.Provider = obj0.MarketManager.UyiAAd6ITD[obj1.Instrument];
          if (this.saveOrders)
          {
            obj1.Persistent = true;
            break;
          }
          else
            break;
      }
      obj1.StrategyMode = MetaStrategyBase.FIX_MODES[this.metaStrategyMode];
      this.DKMWNa8OX5.Add(obj1, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void mhsWZDndbE([In] StrategyBase obj0, [In] ExecutionReport obj1)
    {
      IExecutionService service = (IExecutionService) null;
      switch (this.metaStrategyMode)
      {
        case MetaStrategyMode.Simulation:
          service = ServiceManager.ExecutionSimulator;
          break;
        case MetaStrategyMode.Live:
          service = obj0.ExecutionService;
          break;
      }
      OrderManager.SellSide.SendExecutionReport(service, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void S1PWnXiNYV([In] object obj0, [In] EventArgs obj1)
    {
      this.W31W5ysSK0();
      this.isOptimizing = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ArrayList GetOptimizationParameters()
    {
      this.optimizationParemeters.Clear();
      int num = 0;
      foreach (ComponentType type in this.componentTypeList)
      {
        IComponentBase component = this.GetComponent(type);
        string str = (string) (object) type + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(12584);
        foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
        {
          foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
          {
            if (attribute.GetType() == typeof (OptimizationParameterAttribute))
            {
              this.optimizationParemeters.Add((object) (str + propertyInfo.Name));
              ++num;
            }
          }
        }
      }
      foreach (StrategyBase strategyBase in this.strategies)
      {
        if (strategyBase.IsEnabled)
        {
          foreach (ComponentType type in strategyBase.ComponentTypeList)
          {
            IComponentBase component = strategyBase.GetComponent(type);
            string str = (string) (object) type + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(12590);
            foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
            {
              foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
              {
                if (attribute.GetType() == typeof (OptimizationParameterAttribute))
                {
                  this.optimizationParemeters.Add((object) (str + propertyInfo.Name));
                  ++num;
                }
              }
            }
          }
        }
      }
      return this.optimizationParemeters;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Objective()
    {
      this.Start(false);
      return -this.optimizationManager.Objective();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Init(ParamSet paramSet)
    {
      int NParam = 0;
      foreach (ComponentType type in this.componentTypeList)
      {
        IComponentBase component = this.GetComponent(type);
        string str = (string) (object) type + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(12596);
        foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
        {
          if (this.optimizationParemeters.Contains((object) (str + propertyInfo.Name)))
          {
            foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
            {
              if (attribute.GetType() == typeof (OptimizationParameterAttribute))
              {
                OptimizationParameterAttribute parameterAttribute = attribute as OptimizationParameterAttribute;
                paramSet.SetParamName(NParam, str + propertyInfo.Name);
                paramSet.SetParam(NParam, parameterAttribute.LowerBound + (parameterAttribute.UpperBound - parameterAttribute.LowerBound) / 2.0);
                paramSet.SetLowerBound(NParam, parameterAttribute.LowerBound);
                paramSet.SetUpperBound(NParam, parameterAttribute.UpperBound);
                paramSet.SetSteps(NParam, parameterAttribute.Step);
                if (propertyInfo.PropertyType == typeof (int))
                  paramSet.SetParamType(NParam, EParamType.Int);
                else
                  paramSet.SetParamType(NParam, EParamType.Float);
                ++NParam;
              }
            }
          }
        }
      }
      foreach (StrategyBase strategyBase in this.strategies)
      {
        if (strategyBase.IsEnabled)
        {
          foreach (ComponentType type in strategyBase.ComponentTypeList)
          {
            IComponentBase component = strategyBase.GetComponent(type);
            string str = (string) (object) type + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(12602);
            foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
            {
              if (this.optimizationParemeters.Contains((object) (str + propertyInfo.Name)))
              {
                foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
                {
                  if (attribute.GetType() == typeof (OptimizationParameterAttribute))
                  {
                    OptimizationParameterAttribute parameterAttribute = attribute as OptimizationParameterAttribute;
                    paramSet.SetParamName(NParam, str + propertyInfo.Name);
                    paramSet.SetParam(NParam, parameterAttribute.LowerBound + (parameterAttribute.UpperBound - parameterAttribute.LowerBound) / 2.0);
                    paramSet.SetLowerBound(NParam, parameterAttribute.LowerBound);
                    paramSet.SetUpperBound(NParam, parameterAttribute.UpperBound);
                    paramSet.SetSteps(NParam, parameterAttribute.Step);
                    if (propertyInfo.PropertyType == typeof (int))
                      paramSet.SetParamType(NParam, EParamType.Int);
                    else
                      paramSet.SetParamType(NParam, EParamType.Float);
                    ++NParam;
                  }
                }
              }
            }
          }
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(ParamSet paramSet)
    {
      int NParam = 0;
      foreach (ComponentType type in this.componentTypeList)
      {
        IComponentBase component = this.GetComponent(type);
        string str = (string) (object) type + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(12608);
        foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
        {
          if (this.optimizationParemeters.Contains((object) (str + propertyInfo.Name)))
          {
            foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
            {
              if (attribute.GetType() == typeof (OptimizationParameterAttribute))
              {
                if (propertyInfo.PropertyType == typeof (int))
                  propertyInfo.SetValue((object) component, (object) (int) paramSet.GetParam(NParam), (object[]) null);
                if (propertyInfo.PropertyType == typeof (double))
                  propertyInfo.SetValue((object) component, (object) paramSet.GetParam(NParam), (object[]) null);
                ++NParam;
              }
            }
          }
        }
      }
      foreach (StrategyBase strategyBase in this.strategies)
      {
        if (strategyBase.IsEnabled)
        {
          foreach (ComponentType type in strategyBase.ComponentTypeList)
          {
            IComponentBase component = strategyBase.GetComponent(type);
            string str = (string) (object) type + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(12614);
            foreach (PropertyInfo propertyInfo in component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty))
            {
              if (this.optimizationParemeters.Contains((object) (str + propertyInfo.Name)))
              {
                foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
                {
                  if (attribute.GetType() == typeof (OptimizationParameterAttribute))
                  {
                    if (propertyInfo.PropertyType == typeof (int))
                      propertyInfo.SetValue((object) component, (object) (int) paramSet.GetParam(NParam), (object[]) null);
                    if (propertyInfo.PropertyType == typeof (double))
                      propertyInfo.SetValue((object) component, (object) paramSet.GetParam(NParam), (object[]) null);
                    ++NParam;
                  }
                }
              }
            }
          }
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStep()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCircle()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComponentBase GetComponent(ComponentType type)
    {
      switch (type)
      {
        case ComponentType.MetaMoneyManager:
          return (IComponentBase) this.MetaMoneyManager;
        case ComponentType.ReportManager:
          return (IComponentBase) this.ReportManager;
        case ComponentType.OptimizationManager:
          return (IComponentBase) this.OptimizationManager;
        case ComponentType.SimulationManager:
          return (IComponentBase) this.SimulationManager;
        default:
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12620));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetComponent(ComponentType type, IComponentBase component)
    {
      switch (type)
      {
        case ComponentType.MetaMoneyManager:
          this.MetaMoneyManager = component as MetaMoneyManager;
          break;
        case ComponentType.ReportManager:
          this.ReportManager = component as ReportManager;
          break;
        case ComponentType.OptimizationManager:
          this.OptimizationManager = component as OptimizationManager;
          break;
        case ComponentType.SimulationManager:
          this.SimulationManager = component as SimulationManager;
          break;
        default:
          throw new InvalidOperationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(12694));
      }
    }

    public class FIXModes
    {
      private Hashtable yv5RHVaaV7;

      public char this[MetaStrategyMode mode]
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get
        {
          return (char) this.yv5RHVaaV7[(object) mode];
        }
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal FIXModes()
      {
        oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.yv5RHVaaV7 = new Hashtable();
        this.yv5RHVaaV7.Add((object) MetaStrategyMode.Simulation, (object) 'S');
        this.yv5RHVaaV7.Add((object) MetaStrategyMode.Live, (object) 'L');
      }
    }
  }
}
