using OpenQuant.API;
using OpenQuant.API.Logs;
using OpenQuant.ObjectMap;
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Testing;
using FreeQuant.Trading;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace OpenQuant.Trading
{
  public class StrategyRunner : IInstrumentSource
  {
    private IMarketDataProvider marketDataProvider = SmartQuant.Providers.ProviderManager.MarketDataSimulator;
    private IExecutionProvider executionProvider = SmartQuant.Providers.ProviderManager.ExecutionSimulator;
    private BarSliceManager barSliceManager = new BarSliceManager();
    private Dictionary<SmartQuant.Instruments.Instrument, Strategy> strategies = new Dictionary<SmartQuant.Instruments.Instrument, Strategy>();
    private List<SmartQuant.Instruments.Instrument> instruments = new List<SmartQuant.Instruments.Instrument>();
    private List<ATSStop> stops = new List<ATSStop>();
    private Dictionary<SmartQuant.Instruments.Instrument, List<ATSStop>> activeStops = new Dictionary<SmartQuant.Instruments.Instrument, List<ATSStop>>();
    private StopEventHandler StopAdded;
    private Strategy sampleStrategy;
    private SmartQuant.Instruments.Portfolio sq_Portfolio;
    private SmartQuant.Instruments.Portfolio sq_MetaPortfolio;
    private IObjectConverter objectConverter;
    private DateTime startDate;
    private DateTime stopDate;
    private double cash;
    private LiveTester tester;
    private string strategyName;
    private IStrategyLogManager strategyLogManager;
    private bool enabled;
    private bool active;
    private DataRequests dataRequests;

    public DataRequests DataRequests
    {
      get
      {
        return this.dataRequests;
      }
      set
      {
        this.dataRequests = value;
      }
    }

    public bool Enabled
    {
      get
      {
        return this.enabled;
      }
      set
      {
        this.enabled = value;
      }
    }

    public bool Active
    {
      get
      {
        return this.active;
      }
      set
      {
        this.active = value;
        if (!this.enabled)
          return;
        FieldInfo field = typeof (Strategy).GetField("active", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField);
        foreach (Strategy strategy in this.Strategies.Values)
        {
          field.SetValue((object) strategy, (object) (bool) (this.active ? 1 : 0));
          strategy.OnActiveChanged();
        }
      }
    }

    public bool PerformanceEnabled { get; set; }

    public bool CalculatePnL { get; set; }

    public bool CalculateDrawdown { get; set; }

    public bool UpdateOnIntervalEnabled { get; set; }

    public TimeSpan UpdateOnIntervalInterval { get; set; }

    public string StrategyName
    {
      get
      {
        return this.strategyName;
      }
    }

    public IStrategyLogManager StrategyLogManager
    {
      get
      {
        return this.strategyLogManager;
      }
      set
      {
        this.strategyLogManager = value;
      }
    }

    public Dictionary<SmartQuant.Instruments.Instrument, Strategy> Strategies
    {
      get
      {
        return this.strategies;
      }
      set
      {
        this.strategies = value;
      }
    }

    public List<ATSStop> Stops
    {
      get
      {
        return this.stops;
      }
    }

    public DateTime StartDate
    {
      get
      {
        return this.startDate;
      }
      set
      {
        this.startDate = value;
      }
    }

    public DateTime StopDate
    {
      get
      {
        return this.StopDate;
      }
      set
      {
        this.stopDate = value;
      }
    }

    public double Cash
    {
      get
      {
        return this.cash;
      }
      set
      {
        this.cash = value;
      }
    }

    public Strategy Strategy
    {
      get
      {
        return this.sampleStrategy;
      }
      set
      {
        this.Reset();
        this.sampleStrategy = value;
      }
    }

    public IMarketDataProvider MarketDataProvider
    {
      get
      {
        return this.marketDataProvider;
      }
      set
      {
        this.marketDataProvider = value;
      }
    }

    public IExecutionProvider ExecutionProvider
    {
      get
      {
        return this.executionProvider;
      }
      set
      {
        this.executionProvider = value;
      }
    }

    public SmartQuant.Instruments.Portfolio Portfolio
    {
      get
      {
        return this.sq_Portfolio;
      }
      set
      {
        if (this.sq_Portfolio == value)
          return;
        this.sq_Portfolio = value;
      }
    }

    public SmartQuant.Instruments.Portfolio MetaPortfolio
    {
      get
      {
        return this.sq_MetaPortfolio;
      }
      set
      {
        if (this.sq_MetaPortfolio == value)
          return;
        this.sq_MetaPortfolio = value;
      }
    }

    public LiveTester Tester
    {
      get
      {
        return this.tester;
      }
    }

    public List<SmartQuant.Instruments.Instrument> Instruments
    {
      get
      {
        return this.instruments;
      }
    }

    public event StopEventHandler StopAdded
    {
      add
      {
        StopEventHandler stopEventHandler = this.StopAdded;
        StopEventHandler comparand;
        do
        {
          comparand = stopEventHandler;
          stopEventHandler = Interlocked.CompareExchange<StopEventHandler>(ref this.StopAdded, (StopEventHandler) Delegate.Combine((Delegate) comparand, (Delegate) value), comparand);
        }
        while (stopEventHandler != comparand);
      }
      remove
      {
        StopEventHandler stopEventHandler = this.StopAdded;
        StopEventHandler comparand;
        do
        {
          comparand = stopEventHandler;
          stopEventHandler = Interlocked.CompareExchange<StopEventHandler>(ref this.StopAdded, (StopEventHandler) Delegate.Remove((Delegate) comparand, (Delegate) value), comparand);
        }
        while (stopEventHandler != comparand);
      }
    }

    public event EventHandler<StrategyErrorEventArgs> Error;

    public StrategyRunner(string strategyName)
    {
      this.objectConverter = Activator.CreateInstance(Type.GetType("OpenQuant.API.ObjectConverter, OpenQuant.API"), true) as IObjectConverter;
      this.strategyName = strategyName;
      this.Portfolio = PortfolioManager.Portfolios[strategyName] == null ? new SmartQuant.Instruments.Portfolio(strategyName) : PortfolioManager.Portfolios[strategyName];
      this.Portfolio.Clear();
    }

    public void Online(bool resetState)
    {
      this.active = true;
      if (resetState)
      {
        this.strategies.Clear();
        this.stops.Clear();
        this.activeStops.Clear();
        Map.Instruments[this.strategyName] = new List<string>();
      }
      if (!this.enabled)
        return;
      if (resetState)
      {
        string code = (string) this.sampleStrategy.GetType().GetField("Currency", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).GetValue((object) this.sampleStrategy);
        if (CurrencyManager.Currencies.Contains(code))
          this.Portfolio.Account.Currency = CurrencyManager.Currencies[code];
        List<string> list = new List<string>();
        MethodInfo method = typeof (Strategy).GetMethod("Init", BindingFlags.Instance | BindingFlags.NonPublic);
        FieldInfo field1 = typeof (Strategy).GetField("startDate", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
        FieldInfo field2 = typeof (Strategy).GetField("stopDate", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
        FieldInfo field3 = typeof (Strategy).GetField("cash", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
        foreach (SmartQuant.Instruments.Instrument key in this.instruments)
        {
          Strategy strategy = Activator.CreateInstance(this.sampleStrategy.GetType()) as Strategy;
          this.SetProxyProperties((object) strategy, (object) this.sampleStrategy);
          method.Invoke((object) strategy, new object[6]
          {
            (object) this.sq_Portfolio,
            (object) this.sq_MetaPortfolio,
            (object) key,
            (object) this.dataRequests,
            (object) this.strategyName,
            (object) this.strategyLogManager
          });
          field1.SetValue((object) strategy, (object) this.startDate);
          field2.SetValue((object) strategy, (object) this.stopDate);
          field3.SetValue((object) strategy, (object) this.cash);
          this.strategies.Add(key, strategy);
          list.Add(key.Symbol);
        }
        Map.Instruments[this.strategyName] = list;
        foreach (Strategy strategy in this.strategies.Values)
          strategy.OnStrategyStart();
      }
      else
      {
        OpenQuant.API.Portfolio portfolio = Map.SQ_OQ_Portfolio[(object) this.sq_Portfolio] as OpenQuant.API.Portfolio;
        foreach (object obj in this.strategies.Values)
          typeof (Strategy).GetField("portfolio", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).SetValue(obj, (object) portfolio);
      }
      this.Connect();
    }

    public void PrepareTester()
    {
      bool flag = (bool) this.sampleStrategy.GetType().GetField("ReportEnabled", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).GetValue((object) this.sampleStrategy);
      TimeIntervalSize timeIntervalSize = (TimeIntervalSize) this.sampleStrategy.GetType().GetField("TestingPeriod", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).GetValue((object) this.sampleStrategy);
      this.tester = new LiveTester(this.sq_Portfolio);
      this.tester.set_TimeInterval(timeIntervalSize);
      this.tester.DisableComponents();
      if (!flag)
      {
        this.tester.set_AllowRoundTrips(false);
      }
      else
      {
        this.tester.Disconnect();
        this.tester.Connect();
        this.tester.Reset();
        this.tester.set_FollowChanges(true);
        this.tester.set_AllowRoundTrips(true);
        this.AddTesterComponents();
      }
    }

    public void Offline()
    {
      this.Disconnect();
      if (!this.enabled)
        return;
      foreach (Strategy strategy in this.strategies.Values)
      {
        try
        {
          strategy.OnStrategyStop();
        }
        catch
        {
        }
      }
      MethodInfo method = typeof (Strategy).GetMethod("Done", BindingFlags.Instance | BindingFlags.NonPublic);
      foreach (Strategy strategy in this.strategies.Values)
        method.Invoke((object) strategy, (object[]) null);
    }

    private void Reset()
    {
      this.strategies.Clear();
      this.instruments.Clear();
      this.stops.Clear();
      this.activeStops.Clear();
    }

    private void SetProxyProperties(object obj, object proxy)
    {
      foreach (FieldInfo fieldInfo in proxy.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
      {
        if ((fieldInfo.FieldType.IsValueType || fieldInfo.FieldType.IsEnum || fieldInfo.FieldType == typeof (string)) && (fieldInfo.GetCustomAttributes(typeof (ParameterAttribute), true).Length > 0 || fieldInfo.GetCustomAttributes(typeof (OptimizationParameterAttribute), true).Length > 0))
          obj.GetType().GetField(fieldInfo.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).SetValue(obj, fieldInfo.GetValue(proxy));
      }
    }

    public void SetRunningEnabled()
    {
    }

    private void Connect()
    {
      this.sq_Portfolio.TransactionAdded += new TransactionEventHandler(this.portfolio_TransactionAdded);
      this.sq_Portfolio.PositionChanged += new PositionEventHandler(this.portfolio_PositionChanged);
      this.sq_Portfolio.PositionClosed += new PositionEventHandler(this.portfolio_PositionClosed);
      this.sq_Portfolio.PositionOpened += new PositionEventHandler(this.portfolio_PositionOpened);
      this.sq_Portfolio.ValueChanged += new PositionEventHandler(this.portfolio_ValueChanged);
      SmartQuant.Providers.ProviderManager.Connected += new ProviderEventHandler(this.SQ_ProviderManager_Connected);
      SmartQuant.Providers.ProviderManager.Disconnected += new ProviderEventHandler(this.SQ_ProviderManager_Disconnected);
      SmartQuant.Providers.ProviderManager.Error += new ProviderErrorEventHandler(this.SQ_ProviderManager_Error);
      this.sq_Portfolio.Monitored = true;
      this.sq_Portfolio.Performance.Enabled = this.PerformanceEnabled;
      this.sq_Portfolio.Performance.CalculateDrawdown = this.CalculateDrawdown;
      this.sq_Portfolio.Performance.CalculatePnL = this.CalculatePnL;
      this.sq_Portfolio.Performance.UpdateOnIntervalEnabled = this.UpdateOnIntervalEnabled;
      this.sq_Portfolio.Performance.UpdateInterval = this.UpdateOnIntervalInterval;
    }

    private void Disconnect()
    {
      this.sq_Portfolio.TransactionAdded -= new TransactionEventHandler(this.portfolio_TransactionAdded);
      this.sq_Portfolio.PositionChanged -= new PositionEventHandler(this.portfolio_PositionChanged);
      this.sq_Portfolio.PositionClosed -= new PositionEventHandler(this.portfolio_PositionClosed);
      this.sq_Portfolio.PositionOpened -= new PositionEventHandler(this.portfolio_PositionOpened);
      this.sq_Portfolio.ValueChanged -= new PositionEventHandler(this.portfolio_ValueChanged);
      SmartQuant.Providers.ProviderManager.Connected -= new ProviderEventHandler(this.SQ_ProviderManager_Connected);
      SmartQuant.Providers.ProviderManager.Disconnected -= new ProviderEventHandler(this.SQ_ProviderManager_Disconnected);
      SmartQuant.Providers.ProviderManager.Error -= new ProviderErrorEventHandler(this.SQ_ProviderManager_Error);
      this.tester.Disconnect();
      this.sq_Portfolio.Monitored = false;
    }

    public void SetNewTrade(SmartQuant.Instruments.Instrument instrument, SmartQuant.Data.Trade trade)
    {
      try
      {
        if (this.stops.Count != 0)
        {
          List<ATSStop> list = (List<ATSStop>) null;
          if (this.activeStops.TryGetValue(instrument, out list))
          {
            foreach (ATSStop atsStop in new ArrayList((ICollection) list))
            {
              if (atsStop.get_Connected())
                atsStop.OnNewTrade(trade);
            }
          }
        }
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(instrument, out strategy))
          return;
        strategy.OnTrade((OpenQuant.API.Trade) this.objectConverter.Convert(trade));
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetNewQuote(SmartQuant.Instruments.Instrument instrument, SmartQuant.Data.Quote quote)
    {
      try
      {
        if (this.stops.Count != 0)
        {
          List<ATSStop> list = (List<ATSStop>) null;
          if (this.activeStops.TryGetValue(instrument, out list))
          {
            foreach (ATSStop atsStop in new ArrayList((ICollection) list))
            {
              if (atsStop.get_Connected())
                atsStop.OnNewQuote(quote);
            }
          }
        }
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(instrument, out strategy))
          return;
        strategy.OnQuote((OpenQuant.API.Quote) this.objectConverter.Convert(quote));
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetNewBarOpen(SmartQuant.Instruments.Instrument instrument, SmartQuant.Data.Bar bar)
    {
      try
      {
        if (this.stops.Count != 0)
        {
          List<ATSStop> list = (List<ATSStop>) null;
          if (this.activeStops.TryGetValue(instrument, out list))
          {
            foreach (ATSStop atsStop in new ArrayList((ICollection) list))
            {
              if (atsStop.get_Connected())
                atsStop.OnNewBarOpen(bar);
            }
          }
        }
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(instrument, out strategy))
          return;
        strategy.OnBarOpen((OpenQuant.API.Bar) this.objectConverter.Convert(bar));
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetNewBar(SmartQuant.Instruments.Instrument instrument, SmartQuant.Data.Bar bar)
    {
      try
      {
        if (bar.BarType == SmartQuant.Data.BarType.Time)
          this.barSliceManager.AddBar(instrument, bar);
        else
          this.OnNewBar(instrument, bar);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetNewBarSlice(long barSize)
    {
      try
      {
        BarSlice slice = this.barSliceManager.GetSlice(barSize);
        if (slice != null)
        {
          foreach (KeyValuePair<SmartQuant.Instruments.Instrument, SmartQuant.Data.Bar> keyValuePair in slice.Table)
            this.OnNewBar(keyValuePair.Key, keyValuePair.Value);
          slice.Reset();
        }
        foreach (Strategy strategy in this.strategies.Values)
          strategy.OnBarSlice(barSize);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void OnNewBar(SmartQuant.Instruments.Instrument instrument, SmartQuant.Data.Bar bar)
    {
      if (this.stops.Count != 0)
      {
        List<ATSStop> list = (List<ATSStop>) null;
        if (this.activeStops.TryGetValue(instrument, out list))
        {
          foreach (ATSStop atsStop in new ArrayList((ICollection) list))
          {
            if (atsStop.get_Connected())
              atsStop.OnNewBar(bar);
          }
        }
      }
      Strategy strategy = (Strategy) null;
      if (!this.strategies.TryGetValue(instrument, out strategy))
        return;
      strategy.OnBar((OpenQuant.API.Bar) this.objectConverter.Convert(bar));
    }

    public void SetNewMarketDepth(SmartQuant.Instruments.Instrument instrument, MarketDepth depth)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(instrument, out strategy))
          return;
        strategy.OnOrderBookChanged((OrderBookUpdate) this.objectConverter.Convert(depth));
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void portfolio_TransactionAdded(object sender, TransactionEventArgs args)
    {
    }

    private void portfolio_PositionOpened(object sender, PositionEventArgs args)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(args.Position.Instrument, out strategy))
          return;
        strategy.OnPositionOpened();
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void portfolio_PositionChanged(object sender, PositionEventArgs args)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(args.Position.Instrument, out strategy))
          return;
        strategy.OnPositionChanged();
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void portfolio_PositionClosed(object sender, PositionEventArgs args)
    {
      try
      {
        SmartQuant.Instruments.Instrument instrument = args.Position.Instrument;
        if (this.activeStops.ContainsKey(instrument))
        {
          foreach (ATSStop atsStop in new ArrayList((ICollection) this.activeStops[instrument]))
          {
            if (((StopBase) atsStop).get_Type() == 2 && ((StopBase) atsStop).get_Status() == null || atsStop.get_Connected())
              atsStop.OnPositionClosed(args.Position);
          }
        }
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(instrument, out strategy))
          return;
        strategy.OnPositionClosed();
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void portfolio_ValueChanged(object sender, PositionEventArgs args)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(args.Position.Instrument, out strategy))
          return;
        strategy.OnPositionValueChanged();
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetNewOrder(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        strategy.OnNewOrder(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetOrderStatusChanged(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        strategy.OnOrderStatusChanged(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetOrderDone(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        switch (order.get_OrdStatus())
        {
          case OrdStatus.Filled:
            strategy.OnOrderFilled(Map.SQ_OQ_Order[(object) order] as Order);
            break;
          case OrdStatus.Cancelled:
            strategy.OnOrderCancelled(Map.SQ_OQ_Order[(object) order] as Order);
            break;
          case OrdStatus.Rejected:
            strategy.OnOrderRejected(Map.SQ_OQ_Order[(object) order] as Order);
            break;
          case OrdStatus.Expired:
            strategy.OnOrderExpired(Map.SQ_OQ_Order[(object) order] as Order);
            break;
        }
        strategy.OnOrderDone(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetPartiallyFilled(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        strategy.OnOrderPartiallyFilled(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetOrderReplaced(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        strategy.OnOrderReplaced(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetOrderReplaceReject(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        strategy.OnOrderReplaceReject(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetOrderCancelReject(SingleOrder order)
    {
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(order.get_Instrument(), out strategy))
          return;
        strategy.OnOrderCancelReject(Map.SQ_OQ_Order[(object) order] as Order);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void SQ_ProviderManager_Connected(ProviderEventArgs args)
    {
      try
      {
        foreach (Strategy strategy in this.strategies.Values)
          strategy.OnConnected(args.Provider.Name);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void SQ_ProviderManager_Disconnected(ProviderEventArgs args)
    {
      try
      {
        foreach (Strategy strategy in this.strategies.Values)
          strategy.OnDisconnected(args.Provider.Name);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void SQ_ProviderManager_Error(ProviderErrorEventArgs args)
    {
      try
      {
        foreach (Strategy strategy in this.strategies.Values)
          strategy.OnError((OpenQuant.API.ProviderError) this.objectConverter.Convert(args.Error));
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    public void SetStopAdded(ATSStop stop)
    {
      this.stops.Add(stop);
      List<ATSStop> list = (List<ATSStop>) null;
      if (!this.activeStops.TryGetValue(((StopBase) stop).get_Instrument(), out list))
      {
        list = new List<ATSStop>();
        this.activeStops[((StopBase) stop).get_Instrument()] = list;
      }
      list.Add(stop);
      // ISSUE: method pointer
      stop.add_StatusChanged(new StopEventHandler((object) this, __methodptr(stop_StatusChanged)));
      if (this.StopAdded == null)
        return;
      this.StopAdded.Invoke(new StopEventArgs((IStop) stop));
    }

    private void stop_StatusChanged(StopEventArgs args)
    {
      ATSStop atsStop = args.get_Stop() as ATSStop;
      if (((StopBase) atsStop).get_Status() != null)
      {
        this.activeStops[((StopBase) atsStop).get_Instrument()].Remove(atsStop);
        // ISSUE: method pointer
        atsStop.remove_StatusChanged(new StopEventHandler((object) this, __methodptr(stop_StatusChanged)));
      }
      if (((StopBase) atsStop).get_Status() != 1)
        return;
      try
      {
        Strategy strategy = (Strategy) null;
        if (!this.strategies.TryGetValue(((StopBase) atsStop).get_Instrument(), out strategy))
          return;
        strategy.OnStopExecuted(Map.SQ_OQ_Stop[(object) atsStop] as Stop);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }

    private void EmitError(Exception exception)
    {
      StrategyError error = new StrategyError(SmartQuant.Clock.Now, exception);
      if (this.Error == null)
        return;
      this.Error((object) this, new StrategyErrorEventArgs(error));
    }

    private void AddTesterComponents()
    {
      this.tester.EnableComponent("InitialWealth");
      this.tester.EnableComponent("FinalWealth");
      this.tester.EnableComponent("Average Return (%)");
      this.tester.EnableComponent("Average Gain (%)");
      this.tester.EnableComponent("Average Loss (%)");
      this.tester.EnableComponent("Drawdown Average");
      this.tester.EnableComponent("Drawdown Median");
      this.tester.EnableComponent("Average Annual Return (%)");
      this.tester.EnableComponent("Median Annual Return (%)");
      this.tester.EnableComponent("Maximum Annual Return (%)");
      this.tester.EnableComponent("Minimum Annual Return (%)");
      this.tester.EnableComponent("Average Monthly Return (%)");
      this.tester.EnableComponent("Median Monthly Return (%)");
      this.tester.EnableComponent("Maximum Monthly Return (%)");
      this.tester.EnableComponent("Minimum Monthly Return (%)");
      this.tester.EnableComponent("MAR Ratio");
      this.tester.EnableComponent("Modified Sharpe Ratio");
      this.tester.EnableComponent("Sotrino Ratio");
      this.tester.EnableComponent("CompoundAverageReturn");
      this.tester.EnableComponent("Minimum DrawDown");
      this.tester.EnableComponent("StandardDeviation");
      this.tester.EnableComponent("GainStandardDeviation");
      this.tester.EnableComponent("LossStandardDeviation");
      this.tester.EnableComponent("Skewness");
      this.tester.EnableComponent("Kurtosis");
      this.tester.EnableComponent("SharpeRatio");
      this.tester.EnableComponent("VaR95");
      this.tester.EnableComponent("VaR99");
      foreach (string str in new ArrayList()
      {
        (object) "Number Of RoundTrips",
        (object) "Number Of Winning RoundTrips",
        (object) "Number Of Losing RoundTrips",
        (object) "Percent Of Profitable (%)",
        (object) "Value Open RoundTrips",
        (object) "Total PnL Of All RoundTrips",
        (object) "Total PnL Of Winning RoundTrips",
        (object) "Total PnL Of Losing RoundTrips",
        (object) "Profit Per Winning Trade",
        (object) "Average RoundTrip",
        (object) "Largest Winning RoundTrip",
        (object) "Largest Losing RoundTrip",
        (object) "Average Winning RoundTrip",
        (object) "Average Losing RoundTrip",
        (object) "Ratio avg. win / avg. loss",
        (object) "Profit Factor",
        (object) "Maximal Consecutive Winners",
        (object) "Maximal Consecutive Losers",
        (object) "Average Total Efficiency",
        (object) "Average Entry Efficiency",
        (object) "Average Exit Efficiency"
      })
      {
        this.tester.EnableComponent(str);
        this.tester.EnableComponent("(Long) " + str);
        this.tester.EnableComponent("(Short) " + str);
      }
      foreach (string str in new ArrayList()
      {
        (object) "Duration Of Last RoundTrip",
        (object) "Average Duration Of RoundTrips",
        (object) "Duration Of Last Winning RoundTrip",
        (object) "Average Duration Of Winning RoundTrips",
        (object) "Median Duration Of Winning RoundTrips",
        (object) "Maximum Duration Of Winning RoundTrips",
        (object) "Minimum Duration Of Winning RoundTrips",
        (object) "Duration Of Last Losing RoundTrip",
        (object) "Average Duration Of Losing RoundTrips",
        (object) "Median Duration Of Losing RoundTrips",
        (object) "Maximum Duration Of Losing RoundTrips",
        (object) "Minimum Duration Of Losing RoundTrips"
      })
      {
        this.tester.EnableComponent(str);
        this.tester.EnableComponent("(Long) " + str);
        this.tester.EnableComponent("(Short) " + str);
      }
    }

    internal void SetUserCommand(OpenQuant.API.UserCommand command)
    {
      try
      {
        foreach (Strategy strategy in this.strategies.Values)
          strategy.OnUserCommand(command);
      }
      catch (Exception ex)
      {
        this.EmitError(ex);
      }
    }
  }
}
