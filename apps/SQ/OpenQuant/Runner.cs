using OpenQuant.API;
using OpenQuant.API.Engine;
using OpenQuant.Config;
using OpenQuant.ObjectMap;
using OpenQuant.Projects;
using OpenQuant.Projects.UI;
using OpenQuant.Shared;
using OpenQuant.Trading;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using SmartQuant.Simulation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant
{
  internal static class Runner
  {
    private static Dictionary<Instrument, bool> requestsWithoutTradesTable = new Dictionary<Instrument, bool>();
    private static SolutionRunner solutionRunner;
    private static StrategyOptimizer strategyOptimizer;
    private static bool isRunning;
    private static bool isOptimizing;
    private static bool isSearchingBestParameters;
    private static bool isScheduling;
    private static Simulator simulator;
    private static IMarketDataProvider marketDataProvider;
    private static IExecutionProvider executionProvider;
    private static ConfigurationMode configurationMode;
    private static Solution solution;
    private static Thread scenarioThread;
    private static MarketDataRequestList solutionRunnerRequests;

    public static bool IsRunning
    {
      get
      {
        return Runner.isRunning;
      }
    }

    public static bool IsOptimizing
    {
      get
      {
        return Runner.isOptimizing;
      }
    }

    public static bool IsSearchingBestParameters
    {
      get
      {
        return Runner.isSearchingBestParameters;
      }
    }

    public static StrategyOptimizer StrategyOptimizer
    {
      get
      {
        return Runner.strategyOptimizer;
      }
    }

    public static event EventHandler Starting;

    public static event EventHandler Started;

    public static event EventHandler Stopping;

    public static event EventHandler Stopped;

    public static event EventHandler OptimizationStarted;

    public static event EventHandler OptimizationStopped;

    public static event EventHandler<RunnerErrorEventArgs> Error;

    static Runner()
    {
      Map.add_StrategyStopRequested(new EventHandler(Runner.Map_StrategyStopRequested));
      Map.add_ProviderConnectRequested(new EventHandler(Runner.Map_ProviderConnectRequested));
      Map.add_ProviderDisconnectRequested(new EventHandler(Runner.Map_ProviderDisconnectRequested));
      Runner.simulator = (ProviderManager.MarketDataSimulator as SimulationDataProvider).Simulator;
      Runner.simulator.StateChanged += new EventHandler(Runner.simulator_StateChanged);
      // ISSUE: method pointer
      Configuration.add_ConfigurationModeChanging(new ConfigurationModeChangingEventHandler((object) null, __methodptr(OQ_CONFIGURATION_ConfigurationModeChanging)));
    }

    private static void Map_ProviderConnectRequested(object sender, EventArgs e)
    {
      Global.get_ProviderHelper().Connect(sender as IProvider);
    }

    private static void Map_ProviderDisconnectRequested(object sender, EventArgs e)
    {
      Global.get_ProviderHelper().Disconnect(sender as IProvider);
    }

    private static void Map_StrategyStopRequested(object sender, EventArgs e)
    {
      if (!Runner.isRunning && !Runner.isOptimizing && !Runner.isScheduling)
        return;
      Runner.Stop(false);
    }

    private static void OQ_CONFIGURATION_ConfigurationModeChanging(object sender, ConfigurationModeChangingEventArgs args)
    {
      if (!Runner.isRunning)
        return;
      int num = (int) MessageBox.Show((IWin32Window) Global.MainForm, "Can not change mode because the strategy is running", "Can not change mode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) args).Cancel = true;
    }

    private static void strategyOptimizer_ObjectiveCalled(object sender, EventArgs e)
    {
      Runner.isRunning = true;
      Runner.Do();
    }

    private static void simulator_StateChanged(object sender, EventArgs e)
    {
      if (!Runner.isRunning || Runner.configurationMode != null)
        return;
      switch (Runner.simulator.CurrentState)
      {
        case SimulatorState.Stopped:
          Runner.isRunning = false;
          break;
        case SimulatorState.Running:
          if (Runner.isSearchingBestParameters && Runner.isOptimizing && Runner.isScheduling)
            break;
          Runner.EmitStarted();
          break;
      }
    }

    public static void Start(Solution solution)
    {
      Runner.InitSolutionInfo(solution);
      solution.Scenario.add_StartRequested(new EventHandler(Runner.Scenario_StartRequested));
      solution.Scenario.add_StopRequested(new EventHandler(Runner.Scenario_StopRequested));
      Runner.solution = solution;
      Runner.EmitStarting();
      Runner.scenarioThread = new Thread(new ThreadStart(Runner.RunScenario));
      Runner.scenarioThread.Start();
    }

    private static void RunScenario()
    {
      Runner.isScheduling = true;
      try
      {
        Runner.SetModeToScenario();
        Runner.solution.Scenario.Run();
      }
      catch (ThreadAbortException ex)
      {
        Thread.ResetAbort();
      }
      catch (Exception ex)
      {
        Global.MainForm.Invoke((Delegate) (() =>
        {
          ProjectErrorDialog local_0 = new ProjectErrorDialog();
          local_0.SetError(new StrategyError(Clock.Now, ex));
          local_0.AllowIgnore = false;
          int temp_23 = (int) local_0.ShowDialog((IWin32Window) Global.MainForm);
        }));
      }
      Runner.EmitStopped();
      Runner.isScheduling = false;
    }

    private static void SetModeToScenario()
    {
      typeof (Scenario).GetProperty("Mode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty).SetValue((object) Runner.solution.Scenario, (object) Configuration.get_ActiveMode(), (object[]) null);
    }

    private static void SetActiveMode(StrategyMode mode)
    {
      switch ((int) mode)
      {
        case 0:
          Configuration.set_ActiveMode((ConfigurationMode) 0);
          break;
        case 1:
          Configuration.set_ActiveMode((ConfigurationMode) 1);
          break;
        case 2:
          Configuration.set_ActiveMode((ConfigurationMode) 2);
          break;
      }
    }

    private static void Scenario_StartRequested(object sender, EventArgs e)
    {
      if (!Runner.isScheduling)
        return;
      if (sender != null)
      {
        Runner.SetActiveMode((StrategyMode) sender);
        Runner.SetModeToScenario();
      }
      if (Runner.solution.Scenario.get_ResetOnStart())
        Runner.solutionRunner = Runner.solution.GetSolutionRunner(Runner.solution.Scenario.get_Solution());
      Runner.ApplySolutionInfo(Runner.solution.Scenario.get_Solution());
      Runner.isRunning = true;
      Thread thread = new Thread(new ThreadStart(Runner.Do));
      thread.IsBackground = true;
      thread.Start();
      while (thread.IsAlive)
        Thread.Sleep(1);
    }

    private static void Scenario_StopRequested(object sender, EventArgs e)
    {
      Runner.Stop(false);
    }

    public static void InitSolutionInfo(Solution solution)
    {
      List<Project> list1 = new List<Project>();
      foreach (StrategyProject strategyProject in solution.Projects.Values)
      {
        List<Parameter> list2 = new List<Parameter>();
        bool flag = (bool) ((object) strategyProject.Strategy).GetType().GetField("ReportEnabled", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).GetValue((object) strategyProject.Strategy);
        foreach (StrategyProperty strategyProperty in strategyProject.StrategySettings.StrategyProperties.Values)
        {
          if (strategyProperty.Name == "ReportEnabled")
            flag = (bool) strategyProperty.Value;
          else
            list2.Add(new Parameter(strategyProperty.Name, strategyProperty.Value, strategyProperty.Type));
        }
        Project project = (Project) Activator.CreateInstance(typeof (Project), true);
        project.set_Enabled(strategyProject.Enabled);
        Portfolio portfolio = (Portfolio) ((Hashtable) Map.SQ_OQ_Portfolio)[(object) strategyProject.StrategyRunner.get_Portfolio()];
        typeof (Project).GetMethod("Init", BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) project, new object[4]
        {
          (object) strategyProject.Name,
          (object) portfolio,
          (object) (bool) (flag ? 1 : 0),
          (object) list2
        });
        foreach (Instrument instrument1 in (IEnumerable) strategyProject.StrategySettings.Instruments)
        {
          Instrument instrument2 = (Instrument) ((Hashtable) Map.SQ_OQ_Instrument)[(object) instrument1];
          project.get_Instruments().Add(instrument2);
        }
        list1.Add(project);
      }
      Portfolio portfolio1 = (Portfolio) ((Hashtable) Map.SQ_OQ_Portfolio)[(object) solution.SolutionRunner.get_Portfolio()];
      Solution solution1 = (Solution) Activator.CreateInstance(typeof (Solution), true);
      typeof (Solution).GetMethod("Init", BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) solution1, new object[7]
      {
        (object) solution.Name,
        (object) portfolio1,
        (object) solution.SolutionSettings.StartDate,
        (object) solution.SolutionSettings.StopDate,
        (object) solution.SolutionSettings.Cash,
        (object) (bool) (solution.SolutionSettings.ReportEnabled ? 1 : 0),
        (object) list1
      });
      solution1.set_Requests(Runner.ConvertToAPIRequests(solution.SolutionSettings.Requests));
      IDE.set_Solution(solution1);
    }

    private static void ApplySolutionInfo(Solution solutionInfo)
    {
      ((object) solutionInfo).GetType().GetField("statistics", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).SetValue((object) solutionInfo, (object) null);
      Runner.solution.SolutionSettings.StartDate = solutionInfo.get_StartDate();
      Runner.solution.SolutionSettings.StopDate = solutionInfo.get_StopDate();
      Runner.solution.SolutionSettings.Cash = solutionInfo.get_Cash();
      Runner.solution.SolutionSettings.ReportEnabled = solutionInfo.get_ReportEnabled();
      IEnumerator enumerator1 = solutionInfo.get_Projects().GetEnumerator();
      try
      {
        while (enumerator1.MoveNext())
        {
          Project project = (Project) enumerator1.Current;
          ((object) project).GetType().GetField("statistics", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).SetValue((object) project, (object) null);
          StrategyProject strategyProject = Runner.solution.Projects[project.get_Name()];
          ((object) strategyProject.StrategyRunner.get_Strategy()).GetType().GetField("ReportEnabled", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).SetValue((object) strategyProject.StrategyRunner.get_Strategy(), (object) (bool) (project.get_ReportEnabled() ? 1 : 0));
          IEnumerator enumerator2 = project.get_Parameters().GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              Parameter parameter = (Parameter) enumerator2.Current;
              ((object) strategyProject.StrategyRunner.get_Strategy()).GetType().GetField(parameter.get_Name(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).SetValue((object) strategyProject.StrategyRunner.get_Strategy(), parameter.get_Value());
            }
          }
          finally
          {
            IDisposable disposable = enumerator2 as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
        }
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
    }

    private static DataRequests ConvertToAPIRequests(MarketDataRequestList list)
    {
      DataRequests dataRequests = new DataRequests();
      foreach (MarketDataRequest marketDataRequest in (IEnumerable) list)
      {
        if (marketDataRequest.get_Enabled())
        {
          switch ((int) marketDataRequest.get_RequestType())
          {
            case 0:
              dataRequests.set_HasTradeRequest(true);
              continue;
            case 1:
              dataRequests.set_HasQuoteRequest(true);
              continue;
            case 2:
              dataRequests.set_HasMarketDepthRequest(true);
              continue;
            case 5:
              BarRequest barRequest = marketDataRequest as BarRequest;
              dataRequests.get_BarRequests().Add(new BarRequest(Runner.ConvertBarType(barRequest.get_BarType()), barRequest.get_BarSize(), barRequest.get_IsBarFactoryRequest()));
              continue;
            case 6:
              dataRequests.set_HasDailyRequest(true);
              continue;
            default:
              continue;
          }
        }
      }
      return dataRequests;
    }

    private static MarketDataRequestList ConvertToSolutionRequests(DataRequests requests)
    {
      MarketDataRequestList marketDataRequestList = new MarketDataRequestList();
      IEnumerator enumerator = requests.get_BarRequests().GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          BarRequest barRequest1 = (BarRequest) enumerator.Current;
          BarRequest barRequest2 = new BarRequest(Runner.ConvertBarType(barRequest1.get_BarType()), barRequest1.get_BarSize());
          barRequest2.set_IsBarFactoryRequest(barRequest1.get_IsBarFactoryRequest());
          marketDataRequestList.Add((MarketDataRequest) barRequest2);
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      if (requests.get_HasTradeRequest())
        marketDataRequestList.Add(new MarketDataRequest((RequestType) 0));
      if (requests.get_HasQuoteRequest())
        marketDataRequestList.Add(new MarketDataRequest((RequestType) 1));
      if (requests.get_HasDailyRequest())
        marketDataRequestList.Add(new MarketDataRequest((RequestType) 6));
      if (requests.get_HasMarketDepthRequest())
        marketDataRequestList.Add(new MarketDataRequest((RequestType) 2));
      return marketDataRequestList;
    }

    public static BarType ConvertBarType(BarType barType)
    {
      switch (barType)
      {
        case BarType.Time:
          return (BarType) 0;
        case BarType.Tick:
          return (BarType) 1;
        case BarType.Volume:
          return (BarType) 2;
        case BarType.Range:
          return (BarType) 3;
        default:
          throw new NotImplementedException("BarType is not supported : " + (object) barType);
      }
    }

    public static BarType ConvertBarType(BarType barType)
    {
      switch ((int) barType)
      {
        case 0:
          return BarType.Time;
        case 1:
          return BarType.Tick;
        case 2:
          return BarType.Volume;
        case 3:
          return BarType.Range;
        default:
          throw new NotImplementedException("BarType is not supported : " + (object) barType);
      }
    }

    public static void Start(Solution solution, StrategyOptimizer strategyOptimizer)
    {
      Runner.solution = solution;
      Runner.strategyOptimizer = strategyOptimizer;
      Runner.solutionRunner = strategyOptimizer.get_SolutionRunner();
      Runner.isRunning = true;
      Runner.EmitStarting();
      Runner.EmitOptimizationStarted();
      new Thread(new ThreadStart(Runner.DoOptimization)).Start();
    }

    public static void Stop(bool stopScenario)
    {
      if (Runner.isScheduling && stopScenario)
      {
        Runner.scenarioThread.Abort();
        Runner.isScheduling = false;
      }
      if (!Runner.isRunning)
        return;
      Runner.EmitStopping();
      if (Runner.marketDataProvider == ProviderManager.MarketDataSimulator)
        Runner.simulator.Stop(false);
      else
        Runner.isRunning = false;
    }

    public static void StopOptimization()
    {
      if (!Runner.isOptimizing)
        return;
      Runner.strategyOptimizer.get_Optimizer().Stop();
    }

    public static void TerminateOptimization()
    {
      if (!Runner.isOptimizing)
        return;
      Runner.strategyOptimizer.get_Optimizer().Stop();
      Runner.Stop(true);
    }

    private static void Do()
    {
      if (Runner.solution.Scenario.get_ResetOnStart() && !Runner.solution.Scenario.get_StartOver())
      {
        DataManager.ClearDataArrays();
        ((Hashtable) Map.DrawTable).Clear();
        ((Dictionary<string, OrderedDictionary>) Map.PrintTable).Clear();
        ((Hashtable) Map.OQ_SQ_Stop).Clear();
        ((Hashtable) Map.SQ_OQ_Stop).Clear();
      }
      Runner.marketDataProvider = Configuration.get_Active().get_MarketDataProvider();
      Runner.executionProvider = Configuration.get_Active().get_ExecutionProvider();
      Runner.configurationMode = Configuration.get_ActiveMode();
      Runner.solutionRunner.set_MarketDataProvider(Runner.marketDataProvider);
      Runner.solutionRunner.set_ExecutionProvider(Runner.executionProvider);
      if (Runner.configurationMode == null)
      {
        Clock.ClockMode = ClockMode.Simulation;
        Clock.SetDateTime(Runner.solution.SolutionSettings.StartDate);
        Runner.simulator.Intervals.Clear();
        if (Runner.solution.SolutionSettings.StartDate <= Runner.solution.SolutionSettings.StopDate)
        {
          Runner.simulator.Intervals.Add(Runner.solution.SolutionSettings.StartDate, Runner.solution.SolutionSettings.StopDate);
        }
        else
        {
          string message = "The Solution can not start because StartDate is greater than StopDate";
          int num;
          Global.MainForm.Invoke((Delegate) (() => num = (int) MessageBox.Show((IWin32Window) Global.MainForm, message, "The Solution can not start", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)));
          Runner.isRunning = false;
          if (Runner.configurationMode != null)
            return;
          Clock.ClockMode = ClockMode.Realtime;
          return;
        }
      }
      if (Runner.solution.Scenario.get_ResetOnStart())
      {
        if (!Runner.solution.Scenario.get_StartOver())
        {
          int latency = (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).Latency;
          (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).Latency = 0;
          OrderManager.RemoveOrders(11104, (object) 'S');
          (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).Latency = latency;
          if (Runner.configurationMode == null || Runner.configurationMode == 1)
            OrderManager.OCA.Clear();
          if (!Configuration.get_Active().get_Persistent())
          {
            using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
            {
              while (enumerator.MoveNext())
                enumerator.Current.get_Portfolio().Clear();
            }
            Runner.solutionRunner.get_Portfolio().Clear();
            Configuration.get_Active().get_Portfolio().Clear();
            Runner.solutionRunner.get_Portfolio().Account.Currency = SmartQuant.Instruments.CurrencyManager.DefaultCurrency;
            Configuration.get_Active().get_Portfolio().Account.Currency = SmartQuant.Instruments.CurrencyManager.DefaultCurrency;
          }
        }
        using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            StrategyRunner current = enumerator.Current;
            if (current.get_Enabled())
            {
              if (current.get_Instruments().Count == 0)
              {
                string message = string.Format("The Strategy {0} can not start because it has no selected instruments.{1}{1}You should add instruments to the Strategy.", (object) current.get_StrategyName(), (object) Environment.NewLine);
                int num;
                Global.MainForm.Invoke((Delegate) (() => num = (int) MessageBox.Show((IWin32Window) Global.MainForm, message, "The Strategy can not start", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)));
                Runner.isRunning = false;
                if (Runner.configurationMode != null)
                  return;
                Clock.ClockMode = ClockMode.Realtime;
                return;
              }
              else
              {
                foreach (Instrument instrument in current.get_Instruments())
                  instrument.Reset();
              }
            }
          }
        }
        Runner.solutionRunner.EnableTester();
        using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
        {
          while (enumerator.MoveNext())
            enumerator.Current.PrepareTester();
        }
        if (Runner.solutionRunner.get_Portfolio().Account.Transactions.Count == 0)
        {
          Runner.solutionRunner.get_Portfolio().Account.Deposit(Runner.solution.SolutionSettings.Cash, Runner.solutionRunner.get_Portfolio().Account.Currency, Clock.Now, "Initial Cash Allocation");
          Runner.solutionRunner.get_Portfolio().Performance.Init();
          if (Runner.solutionRunner.get_Runners().Count > 0)
          {
            int num = 0;
            using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                if (enumerator.Current.get_Enabled())
                  ++num;
              }
            }
            double val = Runner.solution.SolutionSettings.Cash / (double) num;
            using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                StrategyRunner current = enumerator.Current;
                current.get_Portfolio().Account.Deposit(val, Runner.solutionRunner.get_Portfolio().Account.Currency, Clock.Now, "Initial Cash Allocation");
                current.get_Portfolio().Performance.Init();
              }
            }
          }
          Configuration.get_Active().get_Portfolio().Account.Deposit(Runner.solution.SolutionSettings.Cash, Configuration.get_Active().get_Portfolio().Account.Currency, Clock.Now, "Initial Cash Allocation");
          Configuration.get_Active().get_Portfolio().Performance.Init();
        }
      }
      Runner.solutionRunner.get_Portfolio().TransactionAdded += new TransactionEventHandler(Runner.Portfolio_TransactionAdded);
      Global.get_ProviderHelper().Connect((IProvider) Runner.marketDataProvider);
      if (!Runner.marketDataProvider.IsConnected)
      {
        Runner.EmitError("Can not connect to " + Runner.marketDataProvider.Name);
        Runner.isRunning = false;
        Runner.EmitStopping();
        Runner.EmitStopped();
        Runner.solutionRunner.get_Portfolio().TransactionAdded -= new TransactionEventHandler(Runner.Portfolio_TransactionAdded);
      }
      else
      {
        Global.get_ProviderHelper().Connect((IProvider) Runner.executionProvider);
        if (!Runner.executionProvider.IsConnected)
        {
          Runner.EmitError("Can not connect to " + Runner.executionProvider.Name);
          Runner.isRunning = false;
          Runner.EmitStopping();
          Runner.EmitStopped();
          Runner.solutionRunner.get_Portfolio().TransactionAdded -= new TransactionEventHandler(Runner.Portfolio_TransactionAdded);
        }
        else
        {
          try
          {
            Runner.solutionRunner.Online(Runner.solution.Scenario.get_ResetOnStart());
          }
          catch (Exception ex)
          {
            Runner.solutionRunner.Offline();
            Global.MainForm.Invoke((Delegate) (() =>
            {
              ProjectErrorDialog local_0 = new ProjectErrorDialog();
              local_0.SetError(new StrategyError(Clock.Now, ex));
              local_0.AllowIgnore = false;
              int temp_355 = (int) local_0.ShowDialog((IWin32Window) Global.MainForm);
            }));
            Runner.isRunning = false;
            Runner.solutionRunner.get_Portfolio().TransactionAdded -= new TransactionEventHandler(Runner.Portfolio_TransactionAdded);
            Runner.EmitStopping();
            Runner.EmitStopped();
            return;
          }
          using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
          {
            while (enumerator.MoveNext())
              enumerator.Current.add_Error(new EventHandler<StrategyErrorEventArgs>(Runner.strategyRunner_Error));
          }
          Runner.SendRequests();
          if (Runner.marketDataProvider == ProviderManager.MarketDataSimulator)
            Runner.simulator.Start(false);
          else
            Runner.EmitStarted();
          while (Runner.isRunning)
            Thread.Sleep(1);
          Runner.solutionRunner.get_Portfolio().TransactionAdded -= new TransactionEventHandler(Runner.Portfolio_TransactionAdded);
          Runner.solutionRunner.Offline();
          Runner.CancelRequests();
          using (Dictionary<string, StrategyRunner>.ValueCollection.Enumerator enumerator = Runner.solutionRunner.get_Runners().Values.GetEnumerator())
          {
            while (enumerator.MoveNext())
              enumerator.Current.remove_Error(new EventHandler<StrategyErrorEventArgs>(Runner.strategyRunner_Error));
          }
          if (Runner.isOptimizing || Runner.isScheduling)
            return;
          Runner.EmitStopped();
        }
      }
    }

    private static void Portfolio_TransactionAdded(object sender, TransactionEventArgs args)
    {
      Configuration.get_Active().get_Portfolio().Add(args.Transaction.Clone() as Transaction);
    }

    private static void DoOptimization()
    {
      Runner.isOptimizing = true;
      Runner.isSearchingBestParameters = true;
      Runner.strategyOptimizer.add_ObjectiveCalled(new EventHandler(Runner.strategyOptimizer_ObjectiveCalled));
      Runner.strategyOptimizer.get_Optimizer().BestObjectiveReceived += new EventHandler(Runner.Optimizer_BestObjectiveReceived);
      Runner.strategyOptimizer.get_Optimizer().Optimize();
      Runner.strategyOptimizer.remove_ObjectiveCalled(new EventHandler(Runner.strategyOptimizer_ObjectiveCalled));
      Runner.EmitStopped();
      Runner.isOptimizing = false;
      Runner.EmitOptimizationStopped();
    }

    private static void Optimizer_BestObjectiveReceived(object sender, EventArgs e)
    {
      Runner.isSearchingBestParameters = false;
    }

    private static void strategyRunner_Error(object sender, StrategyErrorEventArgs e)
    {
      if (Runner.IgnoreError(e.get_Error()))
        return;
      Runner.Stop(false);
    }

    private static bool IgnoreError(StrategyError error)
    {
      bool ignore = false;
      Global.MainForm.Invoke((Delegate) (() =>
      {
        ProjectErrorDialog local_0 = new ProjectErrorDialog();
        local_0.SetError(error);
        ignore = local_0.ShowDialog((IWin32Window) Global.MainForm) == DialogResult.Ignore;
      }));
      return ignore;
    }

    private static void EmitStarting()
    {
      if (Runner.Starting == null)
        return;
      Runner.Starting((object) typeof (Runner), EventArgs.Empty);
    }

    private static void EmitStarted()
    {
      if (Runner.Started == null)
        return;
      Runner.Started((object) typeof (Runner), EventArgs.Empty);
    }

    private static void EmitStopping()
    {
      if (Runner.Stopping == null)
        return;
      Runner.Stopping((object) typeof (Runner), EventArgs.Empty);
    }

    private static void EmitStopped()
    {
      if (Runner.Stopped == null)
        return;
      Runner.Stopped((object) typeof (Runner), EventArgs.Empty);
    }

    private static void EmitOptimizationStarted()
    {
      if (Runner.OptimizationStarted == null)
        return;
      Runner.OptimizationStarted((object) typeof (Runner), EventArgs.Empty);
    }

    private static void EmitOptimizationStopped()
    {
      if (Runner.OptimizationStopped == null)
        return;
      Runner.OptimizationStopped((object) typeof (Runner), EventArgs.Empty);
    }

    private static void EmitError(string text)
    {
      if (Runner.Error == null)
        return;
      Runner.Error((object) typeof (Runner), new RunnerErrorEventArgs(new RunnerError(text)));
    }

    private static void SendRequests()
    {
      Runner.solutionRunnerRequests = Runner.ConvertToSolutionRequests(Runner.solution.Scenario.get_Solution().get_Requests());
      Runner.marketDataProvider.BarFactory.Items.Clear();
      Runner.marketDataProvider.BarFactory.Reset();
      Runner.marketDataProvider.BarFactory.Enabled = true;
      Runner.marketDataProvider.BarFactory.Input = Runner.solution.SolutionSettings.BarFactoryInput;
      MarketDataRequest marketDataRequest1 = (MarketDataRequest) null;
      bool flag1 = false;
      MarketDataType marketDataType1 = (MarketDataType) 3;
      Runner.requestsWithoutTradesTable.Clear();
      if (Runner.configurationMode == null)
      {
        foreach (Instrument index in Runner.solutionRunner.get_Instruments())
        {
          foreach (MarketDataRequest marketDataRequest2 in (IEnumerable) Runner.solutionRunnerRequests)
          {
            if (marketDataRequest2.get_Enabled())
            {
              if (marketDataRequest2 is BarRequest)
              {
                if (!(marketDataRequest2 as BarRequest).get_IsBarFactoryRequest())
                  Global.get_ProviderHelper().RequestMarketData(Runner.marketDataProvider, index, MarketDataType.Trade, marketDataRequest2.GetSeriesSuffix());
                else if (Runner.solution.SolutionSettings.BarFactoryInput == BarFactoryInput.Trade)
                {
                  if (DataManager.Server.GetDataSeries(index.Symbol + ".Trade") == null && DataManager.Server.GetDataSeries(index.Symbol + "." + marketDataRequest2.GetSeriesSuffix()) != null)
                  {
                    Console.WriteLine("Trade series for " + index.Symbol + " is not found in the historical database. The historical series " + marketDataRequest2.GetName() + " is subscribed instead.");
                    Runner.requestsWithoutTradesTable[index] = true;
                    Global.get_ProviderHelper().RequestMarketData(Runner.marketDataProvider, index, MarketDataType.Trade, marketDataRequest2.GetSeriesSuffix());
                  }
                  else
                    flag1 = true;
                }
                else if (DataManager.Server.GetDataSeries(index.Symbol + ".Quote") == null && DataManager.Server.GetDataSeries(index.Symbol + "." + marketDataRequest2.GetSeriesSuffix()) != null)
                {
                  Console.WriteLine("Quote series for " + index.Symbol + " is not found in the historical database. The historical series " + marketDataRequest2.GetName() + " is subscribed instead.");
                  Runner.requestsWithoutTradesTable[index] = true;
                  Global.get_ProviderHelper().RequestMarketData(Runner.marketDataProvider, index, MarketDataType.Quote, marketDataRequest2.GetSeriesSuffix());
                }
                else
                  flag1 = true;
              }
              else
              {
                if (marketDataRequest2.get_RequestType() == null)
                  marketDataRequest1 = marketDataRequest2;
                Global.get_ProviderHelper().RequestMarketData(Runner.marketDataProvider, index, MarketDataType.Trade, marketDataRequest2.GetSeriesSuffix());
              }
            }
          }
        }
      }
      else
      {
        foreach (MarketDataRequest marketDataRequest2 in (IEnumerable) Runner.solutionRunnerRequests)
        {
          if (marketDataRequest2.get_RequestType() == 2)
          {
            marketDataType1 |= MarketDataType.MarketDepth;
            break;
          }
        }
        foreach (Instrument instrument in Runner.solutionRunner.get_Instruments())
          Global.get_ProviderHelper().RequestMarketData(Runner.marketDataProvider, instrument, marketDataType1);
      }
      if (flag1 && marketDataRequest1 == null)
      {
        MarketDataRequest marketDataRequest2 = new MarketDataRequest();
        MarketDataType marketDataType2 = MarketDataType.Trade;
        if (Runner.solution.SolutionSettings.BarFactoryInput != BarFactoryInput.Trade)
        {
          marketDataType2 = MarketDataType.Quote;
          marketDataRequest2 = new MarketDataRequest((RequestType) 1);
        }
        foreach (Instrument instrument in Runner.solutionRunner.get_Instruments())
          Global.get_ProviderHelper().RequestMarketData(Runner.marketDataProvider, instrument, marketDataType2, marketDataRequest2.GetSeriesSuffix());
      }
      foreach (MarketDataRequest marketDataRequest2 in (IEnumerable) Runner.solutionRunnerRequests)
      {
        if (marketDataRequest2.get_Enabled() && marketDataRequest2 is BarRequest)
        {
          BarRequest barRequest = marketDataRequest2 as BarRequest;
          if (barRequest.get_IsBarFactoryRequest())
          {
            bool flag2 = false;
            foreach (BarFactoryItem barFactoryItem in Runner.marketDataProvider.BarFactory.Items)
            {
              if (barFactoryItem.BarSize == barRequest.get_BarSize() && barFactoryItem.BarType == barRequest.get_BarType())
                flag2 = true;
            }
            if (!flag2)
              Runner.marketDataProvider.BarFactory.Items.Add(new BarFactoryItem(barRequest.get_BarType(), barRequest.get_BarSize(), true));
          }
        }
      }
    }

    private static void CancelRequests()
    {
      Runner.marketDataProvider.BarFactory.Reset();
      MarketDataRequest marketDataRequest1 = (MarketDataRequest) null;
      bool flag = false;
      MarketDataType marketDataType1 = (MarketDataType) 3;
      if (Runner.configurationMode == null)
      {
        foreach (Instrument key in Runner.solutionRunner.get_Instruments())
        {
          foreach (MarketDataRequest marketDataRequest2 in (IEnumerable) Runner.solutionRunnerRequests)
          {
            if (marketDataRequest2.get_Enabled())
            {
              if (marketDataRequest2 is BarRequest)
              {
                if (!(marketDataRequest2 as BarRequest).get_IsBarFactoryRequest() || Runner.requestsWithoutTradesTable.ContainsKey(key))
                  Global.get_ProviderHelper().CancelMarketData(Runner.marketDataProvider, key, MarketDataType.Trade, marketDataRequest2.GetSeriesSuffix());
                else
                  flag = true;
              }
              else
              {
                if (marketDataRequest2.get_RequestType() == null)
                  marketDataRequest1 = marketDataRequest2;
                Global.get_ProviderHelper().CancelMarketData(Runner.marketDataProvider, key, MarketDataType.Trade, marketDataRequest2.GetSeriesSuffix());
              }
            }
          }
        }
      }
      else
      {
        foreach (MarketDataRequest marketDataRequest2 in (IEnumerable) Runner.solutionRunnerRequests)
        {
          if (marketDataRequest2.get_RequestType() == 2)
            marketDataType1 |= MarketDataType.MarketDepth;
        }
        foreach (Instrument instrument in Runner.solutionRunner.get_Instruments())
          Global.get_ProviderHelper().CancelMarketData(Runner.marketDataProvider, instrument, marketDataType1);
      }
      if (!flag || marketDataRequest1 != null)
        return;
      MarketDataRequest marketDataRequest3 = new MarketDataRequest();
      MarketDataType marketDataType2 = MarketDataType.Trade;
      if (Runner.solution.SolutionSettings.BarFactoryInput != BarFactoryInput.Trade)
      {
        marketDataType2 = MarketDataType.Quote;
        marketDataRequest3 = new MarketDataRequest((RequestType) 1);
      }
      foreach (Instrument instrument in Runner.solutionRunner.get_Instruments())
        Global.get_ProviderHelper().CancelMarketData(Runner.marketDataProvider, instrument, marketDataType2, marketDataRequest3.GetSeriesSuffix());
    }
  }
}
