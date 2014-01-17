using System;
using System.CodeDom.Compiler;
using System.IO;
using OpenQuant.API;
using OpenQuant.API.Engine;
using OpenQuant.Trading;
using System.Collections.Generic;

namespace CleverQuant.Projects
{
    public class Solution
    {
		private Scenario scenario;

		private SolutionSettings solutionSettings;
		private FileInfo file;

		public Solution()
        {
        }
		public BuildErrorCollection Build()
		{
			CompilerErrorCollection collection = this.Compile();
			this.Save();
			BuildErrorCollection buildErrorCollection = new BuildErrorCollection(collection, this);
			foreach (StrategyProject strategyProject in this.projects.Values)
				buildErrorCollection.AddRange((IEnumerable<BuildError>) strategyProject.Build());
			return buildErrorCollection;
		}

		public void Save()
		{
			if (!this.file.Directory.Exists)
				this.file.Directory.Create();
//			this.scenarioFile = new FileInfo(string.Format("{0}\\{1}", (object) this.file.Directory.FullName, (object) Global.ProjectManager.GetScenarioFileName(this.scenarioLang)));
//			if (!this.scenarioFile.Exists)
//				this.scenarioFile = Global.ProjectManager.GetScenarioTemplate(this.scenarioLang).CopyTo(this.scenarioFile.FullName);
//			this.SaveSettings(this.file.FullName);
		}

		public bool Validate()
		{
			bool flag = false;
			foreach (MarketDataRequest marketDataRequest in (IEnumerable) this.solutionSettings.Requests)
			{
				if (marketDataRequest.get_Enabled())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				int num = (int) MessageBox.Show("The Solution can not start because it has no selected requests.\n\n You should add requests to the Solution.", "The Solution can not start", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else
			{
				foreach (StrategyProject strategyProject in this.projects.Values)
				{
					if (!strategyProject.Validate())
						return false;
				}
				return true;
			}
		}

		private CompilerErrorCollection Compile()
		{
			CompilingServices compilingServices = new CompilingServices(this.scenarioLang);
			foreach (BuildReference buildReference in Global.Options.Solutions.Build.GetReferences())
			{
				if (buildReference.get_Valid())
					compilingServices.AddReference(buildReference.get_Path());
			}
			compilingServices.AddFile(this.scenarioFile.FullName);
			CompilerResults compilerResults = compilingServices.Compile();
			if (!compilerResults.Errors.HasErrors)
			{
				foreach (System.Type type in compilerResults.CompiledAssembly.GetTypes())
				{
					if (type.IsSubclassOf(typeof (Scenario)))
					{
						this.scenario = Activator.CreateInstance(type) as Scenario;
						break;
					}
				}
				if (this.scenario == null)
					compilerResults.Errors.Add(new CompilerError(this.scenarioFile.FullName, -1, -1, "", "No strategy found."));
			}
			return compilerResults.Errors;
		}

		public Scenario Scenario
		{
			get
			{
				return this.scenario;
			}
		}

		public SolutionRunner GetSolutionRunner(Solution solutionInfo)
		{
			List<StrategyRunner> list1 = new List<StrategyRunner>();
			foreach (StrategyProject strategyProject in this.projects.Values)
			{
				StrategyRunner strategyRunner = strategyProject.GetStrategyRunner(this.scenario.get_Solution().get_Projects().get_Item(strategyProject.Name));
				list1.Add(strategyRunner);
				strategyRunner.set_Enabled(solutionInfo.get_Projects().get_Item(strategyProject.Name).get_Enabled());
			}
			List<MarketDataRequest> list2 = new List<MarketDataRequest>();
			foreach (MarketDataRequest marketDataRequest in (IEnumerable) this.solutionSettings.Requests)
				list2.Add(marketDataRequest);
			this.solutionRunner.set_TesterEnabled(this.solutionSettings.ReportEnabled);
			this.solutionRunner.set_TesterPeriod(this.solutionSettings.TestingPeriod);
			this.solutionRunner.set_PerformanceEnabled(Configuration.get_Active().get_Portfolio().Performance.Enabled);
			this.solutionRunner.set_CalculatePnL(Configuration.get_Active().get_Portfolio().Performance.CalculatePnL);
			this.solutionRunner.set_CalculateDrawdown(Configuration.get_Active().get_Portfolio().Performance.CalculateDrawdown);
			this.solutionRunner.set_UpdatePerformanceEnabled(Configuration.get_Active().get_Portfolio().Performance.UpdateOnIntervalEnabled);
			this.solutionRunner.set_UpdatePerformanceInterval(Configuration.get_Active().get_Portfolio().Performance.UpdateInterval);
			this.solutionRunner.Init(list2, list1, this.solutionSettings.Cash, this.solutionSettings.StartDate, this.solutionSettings.StopDate);
			return this.solutionRunner;
		}
    }
}

