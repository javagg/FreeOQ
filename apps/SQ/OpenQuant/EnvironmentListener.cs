// Type: OpenQuant.EnvironmentListener
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;
using OpenQuant.API.Engine;
using OpenQuant.Config;
using OpenQuant.Projects;
using OpenQuant.Projects.UI;
using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Scripts;
using System;
using System.IO;
using System.Reflection;

namespace OpenQuant
{
  public static class EnvironmentListener
  {
    static EnvironmentListener()
    {
      IDE.add_StartSolutionRequested(new EventHandler(EnvironmentListener.OQ_Environment_StartRequested));
      IDE.add_StopSolutionRequested(new EventHandler(EnvironmentListener.OQ_Environment_StopRequested));
      IDE.add_BuildSolutionRequested(new EventHandler(EnvironmentListener.OQ_Environment_BuildRequested));
      IDE.add_CloseSolutionRequested(new EventHandler(EnvironmentListener.OQ_Environment_CloseSolutionRequested));
      IDE.add_OpenSolutionRequested(new EventHandler(EnvironmentListener.OQ_Environment_OpenSolutionRequested));
      IDE.add_ModeChangeRequested(new EventHandler(EnvironmentListener.OQ_Environment_ModeChangeRequested));
      IDE.add_SolutionInfoRequested(new EventHandler(EnvironmentListener.OQ_Environment_SolutionInfoRequested));
      IDE.add_ScenarioRequested(new EventHandler(EnvironmentListener.OQ_Environment_ScenarioRequested));
      IDE.add_StartScriptRequested(new EventHandler(EnvironmentListener.OQ_Environment_StartScriptRequested));
      IDE.add_StopScriptRequested(new EventHandler(EnvironmentListener.OQ_Environment_StopScriptRequested));
      Configuration.add_ConfigurationModeChanged(new EventHandler(EnvironmentListener.Configuration_ConfigurationModeChanged));
      Runner.Started += new EventHandler(EnvironmentListener.Runner_Started);
      Runner.Starting += new EventHandler(EnvironmentListener.Runner_Starting);
      Runner.Stopped += new EventHandler(EnvironmentListener.Runner_Stopped);
      Runner.Stopping += new EventHandler(EnvironmentListener.Runner_Stopping);
      Global.ProjectManager.SolutionOpened += new EventHandler(EnvironmentListener.ProjectManager_SolutionOpened);
      Global.ScriptManager.add_Stopped(new EventHandler<ScriptRunnerEventArgs>(EnvironmentListener.ScriptManager_Stopped));
      typeof (IDE).GetMethod("Init", BindingFlags.Static | BindingFlags.NonPublic).Invoke((object) null, new object[3]
      {
        (object) Global.Setup.Folders.Solutions,
        (object) Global.Setup.Folders.Projects,
        (object) Global.Setup.Folders.Scripts
      });
      EnvironmentListener.SetMode();
    }

    private static void ScriptManager_Stopped(object sender, ScriptRunnerEventArgs e)
    {
      foreach (Script script in Global.ScriptManager.GetRunningScripts())
        script.OnScriptStopped(e.get_Runner().get_Key().get_File().FullName);
    }

    private static void ProjectManager_SolutionOpened(object sender, EventArgs e)
    {
      foreach (Script script in Global.ScriptManager.GetRunningScripts())
        script.OnSolutionOpened(Global.ProjectManager.ActiveSolution.Name);
    }

    private static void Runner_Starting(object sender, EventArgs e)
    {
      foreach (Script script in Global.ScriptManager.GetRunningScripts())
        script.OnSolutionStarting();
    }

    private static void Runner_Stopping(object sender, EventArgs e)
    {
      foreach (Script script in Global.ScriptManager.GetRunningScripts())
        script.OnSolutionStopping();
    }

    private static void Runner_Stopped(object sender, EventArgs e)
    {
      foreach (Script script in Global.ScriptManager.GetRunningScripts())
        script.OnSolutionStopped();
    }

    private static void Runner_Started(object sender, EventArgs e)
    {
      foreach (Script script in Global.ScriptManager.GetRunningScripts())
        script.OnSolutionStarted();
    }

    private static void OQ_Environment_StopScriptRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
      {
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_StopScriptRequested), sender, (object) e);
      }
      else
      {
        FileInfo fileInfo = new FileInfo(Global.Setup.Folders.Scripts.FullName + "\\" + (sender as ScriptInfo).get_Path());
        if (!fileInfo.Exists)
          return;
        Global.ScriptManager.Stop(fileInfo);
      }
    }

    private static void OQ_Environment_StartScriptRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
      {
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_StartScriptRequested), sender, (object) e);
      }
      else
      {
        ScriptInfo scriptInfo = sender as ScriptInfo;
        FileInfo fileInfo = new FileInfo(Global.Setup.Folders.Scripts.FullName + "\\" + scriptInfo.get_Path());
        if (!fileInfo.Exists)
          return;
        Global.ScriptManager.Run(fileInfo, Global.Options.Solutions.Build, Global.Options.Solutions.Scripts, scriptInfo.get_Settings());
      }
    }

    private static void OQ_Environment_SolutionInfoRequested(object sender, EventArgs e)
    {
      SolutionInfo solutionInfo = (SolutionInfo) null;
      if (Global.ProjectManager.ActiveSolution != null)
      {
        solutionInfo = (SolutionInfo) typeof (SolutionInfo).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, (Binder) null, new Type[3]
        {
          typeof (string),
          typeof (FileInfo),
          typeof (FileInfo)
        }, (ParameterModifier[]) null).Invoke(new object[3]
        {
          (object) Global.ProjectManager.ActiveSolution.Name,
          (object) Global.ProjectManager.ActiveSolution.SolutionFile,
          (object) Global.ProjectManager.ActiveSolution.ScenarioFile
        });
        foreach (StrategyProject strategyProject in Global.ProjectManager.ActiveSolution.Projects.Values)
          typeof (SolutionInfo).GetMethod("Add", BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) solutionInfo, new object[3]
          {
            (object) strategyProject.Name,
            (object) strategyProject.ProjectFile,
            (object) strategyProject.CodeFile
          });
      }
      typeof (IDE).GetField("solutionInfo", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField).SetValue((object) null, (object) solutionInfo);
    }

    private static void OQ_Environment_ScenarioRequested(object sender, EventArgs e)
    {
      Scenario scenario = (Scenario) null;
      if (Global.ProjectManager.ActiveSolution != null)
        scenario = Global.ProjectManager.ActiveSolution.Scenario;
      typeof (IDE).GetField("scenario", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField).SetValue((object) null, (object) scenario);
    }

    private static void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      EnvironmentListener.SetMode();
    }

    private static void SetMode()
    {
      StrategyMode strategyMode = (StrategyMode) 0;
      switch ((int) Configuration.get_ActiveMode())
      {
        case 0:
          strategyMode = (StrategyMode) 0;
          break;
        case 1:
          strategyMode = (StrategyMode) 1;
          break;
        case 2:
          strategyMode = (StrategyMode) 2;
          break;
      }
      typeof (IDE).GetField("mode", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField).SetValue((object) null, (object) strategyMode);
    }

    private static void OQ_Environment_ModeChangeRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
      {
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_ModeChangeRequested), sender, (object) e);
      }
      else
      {
        switch ((int) (StrategyMode) sender)
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
        Configuration.set_ActiveMode((ConfigurationMode) sender);
      }
    }

    private static void OQ_Environment_OpenSolutionRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_OpenSolutionRequested), sender, (object) e);
      else
        Global.ProjectManager.Open(sender as FileInfo);
    }

    private static void OQ_Environment_CloseSolutionRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_CloseSolutionRequested), sender, (object) e);
      else
        Global.ProjectManager.CloseActiveSolution();
    }

    private static void OQ_Environment_BuildRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
      {
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_BuildRequested), sender, (object) e);
      }
      else
      {
        if (Global.ProjectManager.ActiveSolution == null)
          return;
        Global.ProjectManager.ActiveSolution.Build();
      }
    }

    private static void OQ_Environment_StopRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
      {
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_StopRequested), sender, (object) e);
      }
      else
      {
        if (!Runner.IsRunning)
          return;
        Runner.Stop(true);
      }
    }

    private static void OQ_Environment_StartRequested(object sender, EventArgs e)
    {
      if (Global.MainForm.InvokeRequired)
      {
        Global.MainForm.Invoke((Delegate) new EventHandler(EnvironmentListener.OQ_Environment_StartRequested), sender, (object) e);
      }
      else
      {
        if (!EnvironmentListener.BuildProject())
          return;
        Global.get_ToolWindowManager().ClearOutput();
        if (!Global.ProjectManager.ActiveSolution.Validate())
          return;
        Runner.Start(Global.ProjectManager.ActiveSolution);
      }
    }

    private static bool BuildProject()
    {
      Global.get_ToolWindowManager().ShowOutput();
      Global.get_ToolWindowManager().ClearOutput();
      Global.get_ToolWindowManager().ClearErrorList();
      Console.WriteLine(string.Format("Building solution {0}...", (object) Global.ProjectManager.ActiveSolution.Name));
      Global.EditorManager.SaveAll();
      BuildErrorCollection buildErrorCollection = Global.ProjectManager.ActiveSolution.Build();
      if (buildErrorCollection.HasErrors)
      {
        Console.WriteLine("Built with errors.");
        Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) buildErrorCollection.ToArray());
        Global.get_ToolWindowManager().ShowErrorList<ErrorListWindow>();
        return false;
      }
      else if (buildErrorCollection.HasWarnings)
      {
        Console.WriteLine("Built with warnings.");
        Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) buildErrorCollection.ToArray());
        return true;
      }
      else
      {
        Console.WriteLine("Build succeeded.");
        return true;
      }
    }

    public static void Init()
    {
    }
  }
}
