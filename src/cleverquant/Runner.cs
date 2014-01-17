using System;
using CleverQuant.Projects;
using System.Threading;
using OpenQuant.Trading;
using System.Collections.Generic;
using OpenQuant.API;
using FreeQuant.Simulation;
using FreeQuant.Providers;

namespace CleverQuant
{
	static class Runner
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
//		private static ConfigurationMode configurationMode;
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
//		public static event EventHandler<RunnerErrorEventArgs> Error;

		public Runner()
        {
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
    }
}

