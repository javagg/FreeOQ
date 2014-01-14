using OpenQuant;
using OpenQuant.API.Engine;
using OpenQuant.API.Logs;
using OpenQuant.Config;
using OpenQuant.Projects.Xml;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Logs;
using OpenQuant.Trading;
using SmartQuant.Instruments;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Projects
{
  internal class Solution
  {
    private string description = "";
    private SolutionRunner solutionRunner = new SolutionRunner();
    public const string FILE_EXT = "oqs";
    public const string PORTFOLIO_SUFFIX = "_Solution";
    private Dictionary<string, StrategyProject> projects;
    private Scenario scenario;
    private SolutionSettings solutionSettings;
    private FileInfo file;
    private FileInfo scenarioFile;
    private CodeLang scenarioLang;
    private string name;

    internal Dictionary<string, StrategyProject> Projects
    {
      get
      {
        return this.projects;
      }
    }

    internal SolutionSettings SolutionSettings
    {
      get
      {
        return this.solutionSettings;
      }
    }

    public FileInfo SolutionFile
    {
      get
      {
        return this.file;
      }
    }

    public FileInfo ScenarioFile
    {
      get
      {
        return this.scenarioFile;
      }
    }

    public CodeLang ScenarioLang
    {
      get
      {
        return this.scenarioLang;
      }
    }

    public Scenario Scenario
    {
      get
      {
        return this.scenario;
      }
    }

    public string Name
    {
      get
      {
        return this.name;
      }
    }

    public string Description
    {
      get
      {
        return this.description;
      }
    }

    public SolutionRunner SolutionRunner
    {
      get
      {
        return this.solutionRunner;
      }
    }

    public Solution(FileInfo file)
      : this(file, "")
    {
    }

    public Solution(FileInfo file, string name)
    {
      this.projects = new Dictionary<string, StrategyProject>();
      this.file = file;
      this.name = name;
      this.scenarioLang = (CodeLang) 1;
      this.solutionSettings = new SolutionSettings();
      this.solutionRunner.set_StrategyLogManager((IStrategyLogManager) new StrategyLogManager());
      if (File.Exists(file.FullName))
        this.Load();
      this.UpdatePortfolios();
    }

    public void Close()
    {
      foreach (StrategyProject strategyProject in this.projects.Values)
        strategyProject.Close();
    }

    public void AddProject(StrategyProject project)
    {
      this.projects.Add(project.Name, project);
      project.StrategyRunner.set_Portfolio(this.GetPortfolio(project.Name));
      project.StrategyRunner.get_Portfolio().Persistent = Configuration.get_Active().get_Persistent();
      this.Consolidate();
    }

    public void RemoveProject(StrategyProject project)
    {
      this.projects.Remove(project.Name);
      this.Consolidate();
    }

    public void UpdatePortfolios()
    {
      this.solutionRunner.set_Portfolio(this.GetPortfolio(this.name, true));
      foreach (StrategyProject strategyProject in this.projects.Values)
        strategyProject.StrategyRunner.set_Portfolio(this.GetPortfolio(strategyProject.Name));
      this.UpdatePortfoliosPersistent();
      this.Consolidate();
    }

    public void UpdatePortfoliosPersistent()
    {
      foreach (StrategyProject strategyProject in this.projects.Values)
        strategyProject.StrategyRunner.get_Portfolio().Persistent = Configuration.get_Active().get_Persistent();
    }

    private void Consolidate()
    {
      this.solutionRunner.get_Portfolio().Clear(false);
      Portfolio[] portfolioList = new Portfolio[this.projects.Values.Count];
      int index = 0;
      foreach (StrategyProject strategyProject in this.projects.Values)
      {
        portfolioList[index] = strategyProject.StrategyRunner.get_Portfolio();
        ++index;
      }
      this.solutionRunner.get_Portfolio().ConsolidateFrom(portfolioList);
    }

    private Portfolio GetPortfolio(string portfolioName)
    {
      return this.GetPortfolio(portfolioName, false);
    }

    private Portfolio GetPortfolio(string portfolioName, bool solutionPortfolio)
    {
      if (solutionPortfolio)
        portfolioName = portfolioName + "_Solution";
      switch ((int) Configuration.get_ActiveMode())
      {
        case 0:
          portfolioName = portfolioName + "_S";
          break;
        case 1:
          portfolioName = portfolioName + "_P";
          break;
        case 2:
          portfolioName = portfolioName + "_L";
          break;
      }
      return PortfolioManager.Portfolios[portfolioName] ?? new Portfolio(portfolioName);
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

    private CompilerErrorCollection Compile()
    {
      this.scenario = (Scenario) null;
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

    public void Load()
    {
      this.scenarioFile = new FileInfo(string.Format("{0}\\{1}", (object) this.file.Directory.FullName, (object) Global.ProjectManager.GetScenarioFileName(this.scenarioLang)));
      if (!this.scenarioFile.Exists)
        this.scenarioFile = Global.ProjectManager.GetScenarioTemplate(this.scenarioLang).CopyTo(this.scenarioFile.FullName);
      SolutionXmlDocument solutionXmlDocument = new SolutionXmlDocument();
      solutionXmlDocument.Load(this.file.FullName);
      this.name = solutionXmlDocument.SolutionName;
      this.scenarioLang = solutionXmlDocument.CodeLang;
      this.solutionSettings.Requests.Clear();
      foreach (RequestXmlNode requestXmlNode in solutionXmlDocument.Requests)
        this.solutionSettings.Requests.Add(requestXmlNode.Request);
      this.solutionSettings.BarFactoryInput = solutionXmlDocument.Requests.BarFactoryInput;
      this.solutionSettings.Cash = solutionXmlDocument.SimulationSettings.Cash;
      this.solutionSettings.StartDate = solutionXmlDocument.SimulationSettings.StartDate;
      this.solutionSettings.StopDate = solutionXmlDocument.SimulationSettings.StopDate;
      this.solutionSettings.TestingPeriod = solutionXmlDocument.TesterSettings.TestingPeriod;
      this.solutionSettings.ReportEnabled = solutionXmlDocument.TesterSettings.ReportEnabled;
      foreach (ProjectXmlNode projectXmlNode in solutionXmlDocument.Projects)
      {
        StrategyProject strategyProject = StrategyProject.Open(projectXmlNode.Path.GetValue(Global.Setup.Folders.Projects));
        strategyProject.Enabled = projectXmlNode.Enabled;
        this.projects.Add(strategyProject.Name, strategyProject);
      }
    }

    public void SaveSettings(string path)
    {
      SolutionXmlDocument solutionXmlDocument = new SolutionXmlDocument();
      solutionXmlDocument.SolutionName = this.name;
      solutionXmlDocument.CodeLang = this.scenarioLang;
      foreach (MarketDataRequest request in (IEnumerable) this.solutionSettings.Requests)
        solutionXmlDocument.Requests.Add(request);
      solutionXmlDocument.Requests.BarFactoryInput = this.solutionSettings.BarFactoryInput;
      solutionXmlDocument.SimulationSettings.Cash = this.solutionSettings.Cash;
      solutionXmlDocument.SimulationSettings.StartDate = this.solutionSettings.StartDate;
      solutionXmlDocument.SimulationSettings.StopDate = this.solutionSettings.StopDate;
      solutionXmlDocument.TesterSettings.ReportEnabled = this.solutionSettings.ReportEnabled;
      solutionXmlDocument.TesterSettings.TestingPeriod = this.solutionSettings.TestingPeriod;
      foreach (StrategyProject strategyProject in this.projects.Values)
      {
        solutionXmlDocument.Projects.Add(new FileInfo(strategyProject.ProjectFile.FullName), strategyProject.Enabled);
        strategyProject.Save();
      }
      solutionXmlDocument.Save(path);
    }

    public void Save()
    {
      if (!this.file.Directory.Exists)
        this.file.Directory.Create();
      this.scenarioFile = new FileInfo(string.Format("{0}\\{1}", (object) this.file.Directory.FullName, (object) Global.ProjectManager.GetScenarioFileName(this.scenarioLang)));
      if (!this.scenarioFile.Exists)
        this.scenarioFile = Global.ProjectManager.GetScenarioTemplate(this.scenarioLang).CopyTo(this.scenarioFile.FullName);
      this.SaveSettings(this.file.FullName);
    }
  }
}
