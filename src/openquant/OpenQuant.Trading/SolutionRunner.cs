using OpenQuant.API;
using OpenQuant.API.Logs;
using OpenQuant.ObjectMap;
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
  public class SolutionRunner : IInstrumentSource
  {
    private Dictionary<SmartQuant.Instruments.Instrument, List<StrategyRunner>> instrumentTable = new Dictionary<SmartQuant.Instruments.Instrument, List<StrategyRunner>>();
    private Dictionary<string, StrategyRunner> strategies = new Dictionary<string, StrategyRunner>();
    private IMarketDataProvider marketDataProvider = SmartQuant.Providers.ProviderManager.MarketDataSimulator;
    private IExecutionProvider executionProvider = SmartQuant.Providers.ProviderManager.ExecutionSimulator;
    private List<ATSStop> stops = new List<ATSStop>();
    private List<MarketDataRequest> requests = new List<MarketDataRequest>();
    private SmartQuant.Instruments.Portfolio portfolio;
    private LiveTester tester;
    private bool testerEnabled;
    private TimeIntervalSize testerPeriod;
    private DateTime startDate;
    private DateTime stopDate;
    private double cash;
    private IStrategyLogManager strategyLogManager;
    private StopEventHandler StopAdded;

    public bool TesterEnabled
    {
      get
      {
        return this.testerEnabled;
      }
      set
      {
        this.testerEnabled = value;
      }
    }

    public TimeIntervalSize TesterPeriod
    {
      get
      {
        return this.testerPeriod;
      }
      set
      {
        this.testerPeriod = value;
      }
    }

    public List<MarketDataRequest> Requests
    {
      get
      {
        return this.requests;
      }
    }

    public SmartQuant.Instruments.Portfolio Portfolio
    {
      get
      {
        return this.portfolio;
      }
      set
      {
        this.portfolio = value;
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

    public bool PerformanceEnabled { get; set; }

    public bool CalculatePnL { get; set; }

    public bool CalculateDrawdown { get; set; }

    public TimeSpan UpdatePerformanceInterval { get; set; }

    public bool UpdatePerformanceEnabled { get; set; }

    public LiveTester Tester
    {
      get
      {
        return this.tester;
      }
    }

    public Dictionary<string, StrategyRunner> Runners
    {
      get
      {
        return this.strategies;
      }
    }

    public List<SmartQuant.Instruments.Instrument> Instruments
    {
      get
      {
        return new List<SmartQuant.Instruments.Instrument>((IEnumerable<SmartQuant.Instruments.Instrument>) this.instrumentTable.Keys);
      }
    }

    public List<ATSStop> Stops
    {
      get
      {
        return this.stops;
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

    public void Init(List<MarketDataRequest> requests, List<StrategyRunner> runners, double cash, DateTime startDate, DateTime stopDate)
    {
      this.cash = cash;
      this.startDate = startDate;
      this.stopDate = stopDate;
      this.instrumentTable.Clear();
      this.strategies.Clear();
      this.stops.Clear();
      this.requests = requests;
      foreach (StrategyRunner strategyRunner in runners)
      {
        this.strategies[strategyRunner.StrategyName] = strategyRunner;
        if (strategyRunner.Enabled)
        {
          foreach (SmartQuant.Instruments.Instrument key in strategyRunner.Instruments)
          {
            List<StrategyRunner> list = (List<StrategyRunner>) null;
            if (!this.instrumentTable.TryGetValue(key, out list))
            {
              list = new List<StrategyRunner>();
              this.instrumentTable[key] = list;
            }
            list.Add(strategyRunner);
          }
        }
      }
    }

    public void EnableTester()
    {
      this.tester = new LiveTester(this.portfolio);
      this.tester.set_TimeInterval(this.testerPeriod);
      this.tester.DisableComponents();
      if (!this.testerEnabled)
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

    private void DisableTester()
    {
      this.tester.Disconnect();
    }

    public void Online(bool resetState)
    {
      if (resetState)
        this.stops.Clear();
      DataRequests dataRequests = (DataRequests) null;
      if (resetState)
      {
        dataRequests = this.BuildStrategyRequest();
        Strategy.Global.Clear();
      }
      if (resetState)
        UserCommandManager.Clear();
      if (resetState)
        this.strategyLogManager.Clear();
      foreach (StrategyRunner strategyRunner in this.strategies.Values)
      {
        if (strategyRunner.Enabled)
          strategyRunner.Portfolio.TransactionAdded += new TransactionEventHandler(this.Portfolio_TransactionAdded);
        if (resetState)
        {
          strategyRunner.DataRequests = dataRequests;
          strategyRunner.StartDate = this.startDate;
          strategyRunner.StopDate = this.stopDate;
          strategyRunner.Cash = this.cash;
          strategyRunner.MetaPortfolio = this.portfolio;
          strategyRunner.StrategyLogManager = this.strategyLogManager;
        }
        strategyRunner.Online(resetState);
      }
      this.Connect();
    }

    public void Offline()
    {
      this.DisableTester();
      this.Disconnect();
      foreach (StrategyRunner strategyRunner in this.strategies.Values)
      {
        if (strategyRunner.Enabled)
          strategyRunner.Portfolio.TransactionAdded -= new TransactionEventHandler(this.Portfolio_TransactionAdded);
        strategyRunner.Offline();
      }
    }

    private void Connect()
    {
      // ISSUE: method pointer
      OrderManager.add_NewOrder(new OrderEventHandler((object) this, __methodptr(OrderManager_NewOrder)));
      // ISSUE: method pointer
      OrderManager.add_OrderStatusChanged(new OrderEventHandler((object) this, __methodptr(OrderManager_OrderStatusChanged)));
      // ISSUE: method pointer
      OrderManager.add_OrderDone(new OrderEventHandler((object) this, __methodptr(OrderManager_OrderDone)));
      OrderManager.add_ExecutionReport(new ExecutionReportEventHandler(this.OrderManager_ExecutionReport));
      OrderManager.add_OrderCancelReject(new OrderCancelRejectEventHandler(this.SQ_OrderManager_OrderCancelReject));
      this.marketDataProvider.NewBar += new BarEventHandler(this.marketDataProvider_NewBar);
      this.marketDataProvider.NewBarOpen += new BarEventHandler(this.marketDataProvider_NewBarOpen);
      this.marketDataProvider.NewTrade += new TradeEventHandler(this.marketDataProvider_NewTrade);
      this.marketDataProvider.NewQuote += new QuoteEventHandler(this.marketDataProvider_NewQuote);
      this.marketDataProvider.NewBarSlice += new BarSliceEventHandler(this.marketDataProvider_NewBarSlice);
      this.marketDataProvider.NewMarketDepth += new MarketDepthEventHandler(this.marketDataProvider_NewMarketDepth);
      Map.StopAdded += new EventHandler(this.Map_StopAdded);
      UserCommandManager.NewCommand += new EventHandler<UserCommandEventArgs>(this.UserCommandManager_NewCommand);
      Map.CustomCommandedRaised += new EventHandler(this.Map_CustomCommandedRaised);
      this.portfolio.Monitored = true;
      this.portfolio.Performance.Enabled = this.PerformanceEnabled;
      this.portfolio.Performance.CalculateDrawdown = this.CalculateDrawdown;
      this.portfolio.Performance.CalculatePnL = this.CalculatePnL;
      this.portfolio.Performance.UpdateInterval = this.UpdatePerformanceInterval;
      this.portfolio.Performance.UpdateOnIntervalEnabled = this.UpdatePerformanceEnabled;
    }

    private void Disconnect()
    {
      // ISSUE: method pointer
      OrderManager.remove_NewOrder(new OrderEventHandler((object) this, __methodptr(OrderManager_NewOrder)));
      // ISSUE: method pointer
      OrderManager.remove_OrderStatusChanged(new OrderEventHandler((object) this, __methodptr(OrderManager_OrderStatusChanged)));
      // ISSUE: method pointer
      OrderManager.remove_OrderDone(new OrderEventHandler((object) this, __methodptr(OrderManager_OrderDone)));
      OrderManager.remove_ExecutionReport(new ExecutionReportEventHandler(this.OrderManager_ExecutionReport));
      OrderManager.remove_OrderCancelReject(new OrderCancelRejectEventHandler(this.SQ_OrderManager_OrderCancelReject));
      this.marketDataProvider.NewBar -= new BarEventHandler(this.marketDataProvider_NewBar);
      this.marketDataProvider.NewBarOpen -= new BarEventHandler(this.marketDataProvider_NewBarOpen);
      this.marketDataProvider.NewTrade -= new TradeEventHandler(this.marketDataProvider_NewTrade);
      this.marketDataProvider.NewQuote -= new QuoteEventHandler(this.marketDataProvider_NewQuote);
      this.marketDataProvider.NewBarSlice -= new BarSliceEventHandler(this.marketDataProvider_NewBarSlice);
      this.marketDataProvider.NewMarketDepth -= new MarketDepthEventHandler(this.marketDataProvider_NewMarketDepth);
      Map.StopAdded -= new EventHandler(this.Map_StopAdded);
      UserCommandManager.NewCommand -= new EventHandler<UserCommandEventArgs>(this.UserCommandManager_NewCommand);
      Map.CustomCommandedRaised -= new EventHandler(this.Map_CustomCommandedRaised);
      this.portfolio.Monitored = false;
      foreach (Stop stop in (IEnumerable) Map.OQ_SQ_Stop.Keys)
        stop.Disconnect();
    }

    private void marketDataProvider_NewTrade(object sender, TradeEventArgs args)
    {
      SmartQuant.Instruments.Instrument instrument = args.Instrument as SmartQuant.Instruments.Instrument;
      List<StrategyRunner> list = (List<StrategyRunner>) null;
      if (!this.instrumentTable.TryGetValue(instrument, out list))
        return;
      foreach (StrategyRunner strategyRunner in list)
      {
        if (strategyRunner.Enabled)
          strategyRunner.SetNewTrade(instrument, args.Trade);
      }
    }

    private void marketDataProvider_NewQuote(object sender, QuoteEventArgs args)
    {
      SmartQuant.Instruments.Instrument instrument = args.Instrument as SmartQuant.Instruments.Instrument;
      List<StrategyRunner> list = (List<StrategyRunner>) null;
      if (!this.instrumentTable.TryGetValue(instrument, out list))
        return;
      foreach (StrategyRunner strategyRunner in list)
      {
        if (strategyRunner.Enabled)
          strategyRunner.SetNewQuote(instrument, args.Quote);
      }
    }

    private void marketDataProvider_NewBarOpen(object sender, BarEventArgs args)
    {
      SmartQuant.Instruments.Instrument instrument = args.Instrument as SmartQuant.Instruments.Instrument;
      List<StrategyRunner> list = (List<StrategyRunner>) null;
      if (!this.instrumentTable.TryGetValue(instrument, out list))
        return;
      foreach (StrategyRunner strategyRunner in list)
      {
        if (strategyRunner.Enabled)
          strategyRunner.SetNewBarOpen(instrument, args.Bar);
      }
    }

    private void marketDataProvider_NewBar(object sender, BarEventArgs args)
    {
      SmartQuant.Instruments.Instrument instrument = args.Instrument as SmartQuant.Instruments.Instrument;
      List<StrategyRunner> list = (List<StrategyRunner>) null;
      if (!this.instrumentTable.TryGetValue(instrument, out list))
        return;
      foreach (StrategyRunner strategyRunner in list)
      {
        if (strategyRunner.Enabled)
          strategyRunner.SetNewBar(instrument, args.Bar);
      }
    }

    private void marketDataProvider_NewBarSlice(object sender, BarSliceEventArgs args)
    {
      foreach (StrategyRunner strategyRunner in this.strategies.Values)
      {
        if (strategyRunner.Enabled)
          strategyRunner.SetNewBarSlice(args.BarSize);
      }
    }

    private void marketDataProvider_NewMarketDepth(object sender, MarketDepthEventArgs args)
    {
      SmartQuant.Instruments.Instrument instrument = args.Instrument as SmartQuant.Instruments.Instrument;
      List<StrategyRunner> list = (List<StrategyRunner>) null;
      if (!this.instrumentTable.TryGetValue(instrument, out list))
        return;
      foreach (StrategyRunner strategyRunner in list)
        strategyRunner.SetNewMarketDepth(instrument, args.MarketDepth);
    }

    private void OrderManager_NewOrder(OrderEventArgs args)
    {
      StrategyRunner strategyRunner = (StrategyRunner) null;
      if (!this.strategies.TryGetValue(args.get_Order().get_Strategy(), out strategyRunner) || !strategyRunner.Enabled)
        return;
      strategyRunner.SetNewOrder(args.get_Order());
    }

    private void OrderManager_OrderStatusChanged(OrderEventArgs args)
    {
      StrategyRunner strategyRunner = (StrategyRunner) null;
      if (!this.strategies.TryGetValue(args.get_Order().get_Strategy(), out strategyRunner) || !strategyRunner.Enabled)
        return;
      strategyRunner.SetOrderStatusChanged(args.get_Order());
    }

    private void OrderManager_OrderDone(OrderEventArgs args)
    {
      StrategyRunner strategyRunner = (StrategyRunner) null;
      if (!this.strategies.TryGetValue(args.get_Order().get_Strategy(), out strategyRunner) || !strategyRunner.Enabled)
        return;
      strategyRunner.SetOrderDone(args.get_Order());
    }

    private void OrderManager_ExecutionReport(object sender, ExecutionReportEventArgs args)
    {
      SmartQuant.FIX.ExecutionReport executionReport = args.ExecutionReport;
      if (executionReport.ExecType == ExecType.PartialFill)
      {
        SingleOrder order = ((InstrumentOrderListTable) OrderManager.get_Orders()).get_All().get_Item(executionReport.ClOrdID) as SingleOrder;
        StrategyRunner strategyRunner = (StrategyRunner) null;
        if (this.strategies.TryGetValue(order.get_Strategy(), out strategyRunner) && strategyRunner.Enabled)
          strategyRunner.SetPartiallyFilled(order);
      }
      if ((executionReport.ExecType == ExecType.Fill || executionReport.ExecType == ExecType.Trade) && executionReport.LeavesQty > 0.0)
      {
        SingleOrder order = ((InstrumentOrderListTable) OrderManager.get_Orders()).get_All().get_Item(executionReport.ClOrdID) as SingleOrder;
        StrategyRunner strategyRunner = (StrategyRunner) null;
        if (this.strategies.TryGetValue(order.get_Strategy(), out strategyRunner) && strategyRunner.Enabled)
          strategyRunner.SetPartiallyFilled(order);
      }
      if (executionReport.ExecType != ExecType.Replace)
        return;
      SingleOrder order1 = ((InstrumentOrderListTable) OrderManager.get_Orders()).get_All().get_Item(executionReport.ClOrdID) as SingleOrder;
      StrategyRunner strategyRunner1 = (StrategyRunner) null;
      if (!this.strategies.TryGetValue(order1.get_Strategy(), out strategyRunner1) || !strategyRunner1.Enabled)
        return;
      strategyRunner1.SetOrderReplaced(order1);
    }

    private void SQ_OrderManager_OrderCancelReject(object sender, OrderCancelRejectEventArgs args)
    {
      SingleOrder order = ((InstrumentOrderListTable) OrderManager.get_Orders()).get_All().get_Item(args.OrderCancelReject.OrigClOrdID) as SingleOrder;
      StrategyRunner strategyRunner = (StrategyRunner) null;
      if (!this.strategies.TryGetValue(order.get_Strategy(), out strategyRunner) || !strategyRunner.Enabled)
        return;
      if (args.OrderCancelReject.CxlRejResponseTo == CxlRejResponseTo.CancelReplaceRequest)
        strategyRunner.SetOrderReplaceReject(order);
      else
        strategyRunner.SetOrderCancelReject(order);
    }

    private void Map_StopAdded(object sender, EventArgs args)
    {
      object[] objArray = sender as object[];
      ATSStop stop = objArray[0] as ATSStop;
      this.strategies[objArray[1] as string].SetStopAdded(stop);
      this.stops.Add(stop);
      if (this.StopAdded == null)
        return;
      this.StopAdded.Invoke(new StopEventArgs((IStop) stop));
    }

    private void Portfolio_TransactionAdded(object sender, TransactionEventArgs args)
    {
      this.portfolio.Add(args.Transaction.Clone() as SmartQuant.Instruments.Transaction);
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

    private DataRequests BuildStrategyRequest()
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      bool flag5 = false;
      List<OpenQuant.API.BarRequest> list = new List<OpenQuant.API.BarRequest>();
      foreach (MarketDataRequest marketDataRequest in this.requests)
      {
        if (marketDataRequest.Enabled)
        {
          switch (marketDataRequest.RequestType)
          {
            case RequestType.Trade:
              flag3 = true;
              continue;
            case RequestType.Quote:
              flag2 = true;
              continue;
            case RequestType.MarketDepth:
              flag5 = true;
              continue;
            case RequestType.Bar:
              flag1 = true;
              BarRequest barRequest = marketDataRequest as BarRequest;
              if (barRequest.IsBarFactoryRequest)
                flag3 = true;
              list.Add(new OpenQuant.API.BarRequest(this.ConvertBarType(barRequest.BarType), barRequest.BarSize, barRequest.IsBarFactoryRequest));
              continue;
            case RequestType.Daily:
              flag4 = true;
              continue;
            default:
              continue;
          }
        }
      }
      DataRequests dataRequests = new DataRequests();
      dataRequests.GetType().GetProperty("HasBarRequests", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty).SetValue((object) dataRequests, (object) (bool) (flag1 ? 1 : 0), (object[]) null);
      dataRequests.GetType().GetProperty("HasTradeRequest", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty).SetValue((object) dataRequests, (object) (bool) (flag3 ? 1 : 0), (object[]) null);
      dataRequests.GetType().GetProperty("HasQuoteRequest", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty).SetValue((object) dataRequests, (object) (bool) (flag2 ? 1 : 0), (object[]) null);
      dataRequests.GetType().GetProperty("HasDailyRequest", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty).SetValue((object) dataRequests, (object) (bool) (flag4 ? 1 : 0), (object[]) null);
      dataRequests.GetType().GetProperty("HasMarketDepthRequest", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty).SetValue((object) dataRequests, (object) (bool) (flag5 ? 1 : 0), (object[]) null);
      MethodInfo methodInfo1 = (MethodInfo) null;
      foreach (MethodInfo methodInfo2 in dataRequests.BarRequests.GetType().GetMethods())
      {
        if (methodInfo2.Name == "Add" && methodInfo2.GetParameters().Length == 1)
          methodInfo1 = methodInfo2;
      }
      foreach (OpenQuant.API.BarRequest barRequest in list)
        methodInfo1.Invoke((object) dataRequests.BarRequests, new object[1]
        {
          (object) barRequest
        });
      return dataRequests;
    }

    public OpenQuant.API.BarType ConvertBarType(SmartQuant.Data.BarType barType)
    {
      switch (barType)
      {
        case SmartQuant.Data.BarType.Time:
          return OpenQuant.API.BarType.Time;
        case SmartQuant.Data.BarType.Tick:
          return OpenQuant.API.BarType.Tick;
        case SmartQuant.Data.BarType.Volume:
          return OpenQuant.API.BarType.Volume;
        case SmartQuant.Data.BarType.Range:
          return OpenQuant.API.BarType.Range;
        default:
          throw new NotImplementedException("BarType is not supported : " + (object) barType);
      }
    }

    public void Init(List<MarketDataRequest> requestList, List<StrategyRunner> list)
    {
      throw new NotImplementedException();
    }

    private void Map_CustomCommandedRaised(object sender, EventArgs e)
    {
      Tuple<string, string, object[]> tuple = sender as Tuple<string, string, object[]>;
      List<Strategy> list = new List<Strategy>();
      foreach (StrategyRunner strategyRunner in this.Runners.Values)
      {
        if (tuple.Item1 == null || !(tuple.Item1 != strategyRunner.StrategyName))
        {
          foreach (KeyValuePair<SmartQuant.Instruments.Instrument, Strategy> keyValuePair in strategyRunner.Strategies)
          {
            if (tuple.Item2 == null || !(tuple.Item2 != keyValuePair.Key.Symbol))
              list.Add(keyValuePair.Value);
          }
        }
      }
      foreach (Strategy strategy in list)
        strategy.OnCustomCommand(tuple.Item3);
    }

    private void UserCommandManager_NewCommand(object sender, UserCommandEventArgs e)
    {
      List<StrategyRunner> list = new List<StrategyRunner>();
      if (e.Command.Strategy == null)
      {
        list.AddRange((IEnumerable<StrategyRunner>) this.strategies.Values);
      }
      else
      {
        StrategyRunner strategyRunner;
        if (this.strategies.TryGetValue(e.Command.Strategy, out strategyRunner))
          list.Add(strategyRunner);
      }
      foreach (StrategyRunner strategyRunner in list)
      {
        if (strategyRunner.Enabled)
          strategyRunner.SetUserCommand(e.Command.Command);
      }
    }
  }
}
