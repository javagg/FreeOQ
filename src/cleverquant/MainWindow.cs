using System;
using System.Windows.Forms;
using CleverQuant;
using OpenQuant.Trading;
using CleverQuant.Projects;
using OpenQuant.Shared.Plugins;

public partial class MainWindow: Form
{
    public MainWindow()
	{
	}

	private bool BuildProject()
	{
		Console.WriteLine(string.Format("Building solution {0}...", Global.ProjectManager.ActiveSolution.Name));
//		Global.EditorManager.SaveAll();
		BuildErrorCollection buildErrorCollection = Global.ProjectManager.ActiveSolution.Build();
//		Global.get_ToolWindowManager().UpdateProperties();
		if (buildErrorCollection.HasErrors)
		{
			Console.WriteLine("Built with errors.");
//			Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) buildErrorCollection.ToArray());
//			Global.get_ToolWindowManager().ShowErrorList<ErrorListWindow>();
			return false;
		}
		else if (buildErrorCollection.HasWarnings)
		{
			Console.WriteLine("Built with warnings.");
//			Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) buildErrorCollection.ToArray());
			return true;
		}
		else
		{
			Console.WriteLine("Build succeeded.");
			return true;
		}
	}

	private void Run()
	{
	}

	private void OptimizeSolution()
	{
		if (!this.BuildProject())
			return;
//		OptmizationDialog optmizationDialog = new OptmizationDialog();
//		if (optmizationDialog.ShowDialog() != DialogResult.OK)
//			return;
//		Global.get_DockManager().Open(typeof (OptimizationWindow));
		Solution sln = Global.ProjectManager.ActiveSolution;
		StrategyOptimizer strategyOptimizer = new StrategyOptimizer(sln.GetSolutionRunner(sln.Scenario.Solution));

//		Runner.Start(Global.ProjectManager.ActiveSolution, optmizationDialog.StrategyOptimizer);
		Runner.Start(Global.ProjectManager.ActiveSolution, strategyOptimizer);
	}

	private void RunProject()
	{
		if (!this.BuildProject())
			return;
//		Global.get_ToolWindowManager().ClearOutput();
//		if (!Global.ProjectManager.ActiveSolution.Validate() || !IDEHelper.DoRunStrategy())
//			return;
		Runner.Start(Global.ProjectManager.ActiveSolution);
	}

	private void PauseProject()
	{
	}

	private void StopProject()
	{
		Runner.Stop(true);
	}

	private void CloseProject()
	{
		Global.ProjectManager.CloseActiveSolution();
	}

	private void LoadPlugins()
	{
		Global.PluginManager.LoadConfig();
		PluginInfoList plugins = Global.PluginManager.Plugins;
		PluginInfo pluginInfo1 = new PluginInfo((PluginType) 0, "SmartQuant.Transaq.Transaq", "SmartQuant.Transaq");
		plugins.Remove(pluginInfo1);
		PluginInfo pluginInfo2 = new PluginInfo((PluginType) 0, "OpenQuant.Finam.Transaq", "OpenQuant.Finam");
		if (plugins.TryGet(ref pluginInfo2))
			pluginInfo2.x64 = true;
		else
			plugins.Add(pluginInfo2);
		PluginInfo pluginInfo3 = new PluginInfo((PluginType) 0, "OpenQuant.QR.QuantRouterProvider", "OpenQuant.QR");
		plugins.Remove(pluginInfo3);
		PluginInfo pluginInfo4 = new PluginInfo((PluginType) 0, "OpenQuant.QB.QuantBaseProvider", "OpenQuant.QB");
		plugins.Remove(pluginInfo4);
		PluginInfo pluginInfo5 = new PluginInfo((PluginType) 0, "OpenQuant.Ivory.Scorpion", "OpenQuant.Ivory");
		if (!plugins.Contains(pluginInfo5))
			plugins.Add(pluginInfo5);
		PluginInfo pluginInfo6 = new PluginInfo((PluginType) 0, "OpenQuant.IQ.IQFeed", "OpenQuant.IQ");
		if (!plugins.Contains(pluginInfo6))
			plugins.Add(pluginInfo6);
		Global.PluginManager.LoadPlugins();
	}
}
