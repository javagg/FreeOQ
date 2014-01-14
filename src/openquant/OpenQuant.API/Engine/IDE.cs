using OpenQuant.API;
using System;
using System.IO;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  IDE
	///</summary>
	public static class IDE
	{
		private static StrategyMode mode = StrategyMode.Simulation;
		private static SolutionInfo solutionInfo = null;
		private static Scenario scenario = null;

		private static void Init(DirectoryInfo solutionsDirectory, DirectoryInfo projectsDirectory, DirectoryInfo scriptsDirectory)
		{
			IDE.SolutionsDirectory = solutionsDirectory;
			IDE.ProjectsDirectory = projectsDirectory;
			IDE.ScriptsDirectory = scriptsDirectory;
		}

		///<summary>
		///  Gets folder that contains solutions 
		///</summary>
		public static DirectoryInfo SolutionsDirectory { get; private set; }

		///<summary>
		///  Gets folder that contains projects
		///</summary>
		public static DirectoryInfo ProjectsDirectory { get; private set; }

		///<summary>
		///  Gets folder that contains scripts 
		///</summary>
		public static DirectoryInfo ScriptsDirectory { get; private set; }

		///<summary>
		///  Gets Mode
		///</summary>
		public static StrategyMode Mode
		{
			get
			{
				return IDE.mode;
			}
			set
			{
				if (IDE.ModeChangeRequested == null)
					return;
				IDE.ModeChangeRequested((object)value, EventArgs.Empty);
			}
		}

		///<summary>
		///  Gets current running solution. Returns null if no solution is running. 
		///</summary>
		public static Solution Solution { get; set; }

		///<summary>
		///  Gets current opened solution info. Returns null if no solution is opened 
		///</summary>
		public static SolutionInfo SolutionInfo
		{
			get
			{
				if (IDE.SolutionInfoRequested != null)
					IDE.SolutionInfoRequested((object)null, EventArgs.Empty);
				return IDE.solutionInfo;
			}
		}

		///<summary>
		///  Gets current running scenario. Returns null if no solution is running
		///</summary>
		public static Scenario Scenario
		{
			get
			{
				if (IDE.ScenarioRequested != null)
					IDE.ScenarioRequested((object)null, EventArgs.Empty);
				return IDE.scenario;
			}
		}

		///<summary>
		///  Fired when IDE.Mode property is set
		///</summary>
		public static event EventHandler ModeChangeRequested;

		///<summary>
		///  Fired when IDE.OpenSolution method is called
		///</summary>
		public static event EventHandler OpenSolutionRequested;

		///<summary>
		///  Fired when IDE.CloseSolution method is called
		///</summary>
		public static event EventHandler CloseSolutionRequested;

		///<summary>
		///  Fired when IDE.StartSolution method is called
		///</summary>
		public static event EventHandler StartSolutionRequested;

		///<summary>
		///  Fired when IDE.StopSolution method is called
		///</summary>
		public static event EventHandler StopSolutionRequested;

		///<summary>
		///  Fired when IDE.BuildSolution method is called
		///</summary>
		public static event EventHandler BuildSolutionRequested;

		///<summary>
		///  Fired when IDE.SolutionInfo property acquired by user code
		///</summary>
		public static event EventHandler SolutionInfoRequested;

		///<summary>
		///  Fired when IDE.Scenario property acquired by user code
		///</summary>
		public static event EventHandler ScenarioRequested;

		///<summary>
		///  Fired when IDE.StartScript method is called
		///</summary>
		public static event EventHandler StartScriptRequested;

		///<summary>
		///  Fired when IDE.StopScript method is called
		///</summary>
		public static event EventHandler StopScriptRequested;

		///<summary>
		///  Opens solution by name
		///</summary>
		public static bool OpenSolution(string name)
		{
			FileInfo fileInfo = new FileInfo(IDE.SolutionsDirectory.FullName + "\\" + name + "\\" + name + ".oqs");
			if (!fileInfo.Exists)
				return false;
			if (IDE.OpenSolutionRequested != null)
				IDE.OpenSolutionRequested((object)fileInfo, EventArgs.Empty);
			return true;
		}

		///<summary>
		///  Closes current solution
		///</summary>
		public static void CloseSolution()
		{
			if (IDE.CloseSolutionRequested == null)
				return;
			IDE.CloseSolutionRequested((object)null, EventArgs.Empty);
		}

		///<summary>
		///  Builds current solution
		///</summary>
		public static void BuildSolution()
		{
			if (IDE.BuildSolutionRequested == null)
				return;
			IDE.BuildSolutionRequested((object)null, EventArgs.Empty);
		}

		///<summary>
		///  Starts current solution
		///</summary>
		public static void StartSolution()
		{
			if (IDE.StartSolutionRequested == null)
				return;
			IDE.StartSolutionRequested((object)null, EventArgs.Empty);
		}

		///<summary>
		///  Stops current solution
		///</summary>
		public static void StopSolution()
		{
			if (IDE.StopSolutionRequested == null)
				return;
			IDE.StopSolutionRequested((object)null, EventArgs.Empty);
		}

		///<summary>
		///  Starts script using specified ScriptInfo
		///</summary>
		public static void StartScript(ScriptInfo scriptInfo)
		{
			if (IDE.StartScriptRequested == null)
				return;
			IDE.StartScriptRequested((object)scriptInfo, EventArgs.Empty);
		}

		///<summary>
		///  Stops script using specified ScriptInfo
		///</summary>
		public static void StopScript(ScriptInfo scriptInfo)
		{
			if (IDE.StopScriptRequested == null)
				return;
			IDE.StopScriptRequested((object)scriptInfo, EventArgs.Empty);
		}
	}
}
