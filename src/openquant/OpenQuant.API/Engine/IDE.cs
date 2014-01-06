using OpenQuant.API;
using System;
using System.IO;

namespace OpenQuant.API.Engine
{
  public static class IDE
  {
    private static StrategyMode mode = StrategyMode.Simulation;
    private static SolutionInfo solutionInfo = (SolutionInfo) null;
    private static Scenario scenario = (Scenario) null;

    public static DirectoryInfo SolutionsDirectory { get; private set; }

    public static DirectoryInfo ProjectsDirectory { get; private set; }

    public static DirectoryInfo ScriptsDirectory { get; private set; }

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
        IDE.ModeChangeRequested((object) value, EventArgs.Empty);
      }
    }

    public static Solution Solution { get; set; }

    public static SolutionInfo SolutionInfo
    {
      get
      {
        if (IDE.SolutionInfoRequested != null)
          IDE.SolutionInfoRequested((object) null, EventArgs.Empty);
        return IDE.solutionInfo;
      }
    }

    public static Scenario Scenario
    {
      get
      {
        if (IDE.ScenarioRequested != null)
          IDE.ScenarioRequested((object) null, EventArgs.Empty);
        return IDE.scenario;
      }
    }

    public static event EventHandler ModeChangeRequested;

    public static event EventHandler OpenSolutionRequested;

    public static event EventHandler CloseSolutionRequested;

    public static event EventHandler StartSolutionRequested;

    public static event EventHandler StopSolutionRequested;

    public static event EventHandler BuildSolutionRequested;

    public static event EventHandler SolutionInfoRequested;

    public static event EventHandler ScenarioRequested;

    public static event EventHandler StartScriptRequested;

    public static event EventHandler StopScriptRequested;

    static IDE()
    {
    }

    private static void Init(DirectoryInfo solutionsDirectory, DirectoryInfo projectsDirectory, DirectoryInfo scriptsDirectory)
    {
      IDE.SolutionsDirectory = solutionsDirectory;
      IDE.ProjectsDirectory = projectsDirectory;
      IDE.ScriptsDirectory = scriptsDirectory;
    }

    public static bool OpenSolution(string name)
    {
      FileInfo fileInfo = new FileInfo(IDE.SolutionsDirectory.FullName + "\\" + name + "\\" + name + ".oqs");
      if (!fileInfo.Exists)
        return false;
      if (IDE.OpenSolutionRequested != null)
        IDE.OpenSolutionRequested((object) fileInfo, EventArgs.Empty);
      return true;
    }

    public static void CloseSolution()
    {
      if (IDE.CloseSolutionRequested == null)
        return;
      IDE.CloseSolutionRequested((object) null, EventArgs.Empty);
    }

    public static void BuildSolution()
    {
      if (IDE.BuildSolutionRequested == null)
        return;
      IDE.BuildSolutionRequested((object) null, EventArgs.Empty);
    }

    public static void StartSolution()
    {
      if (IDE.StartSolutionRequested == null)
        return;
      IDE.StartSolutionRequested((object) null, EventArgs.Empty);
    }

    public static void StopSolution()
    {
      if (IDE.StopSolutionRequested == null)
        return;
      IDE.StopSolutionRequested((object) null, EventArgs.Empty);
    }

    public static void StartScript(ScriptInfo scriptInfo)
    {
      if (IDE.StartScriptRequested == null)
        return;
      IDE.StartScriptRequested((object) scriptInfo, EventArgs.Empty);
    }

    public static void StopScript(ScriptInfo scriptInfo)
    {
      if (IDE.StopScriptRequested == null)
        return;
      IDE.StopScriptRequested((object) scriptInfo, EventArgs.Empty);
    }
  }
}
