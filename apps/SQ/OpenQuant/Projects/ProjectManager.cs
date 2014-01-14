// Type: OpenQuant.Projects.ProjectManager
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects.UI;
using OpenQuant.Projects.Xml;
using OpenQuant.Shared.Compiler;
using SmartQuant.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Projects
{
  internal class ProjectManager
  {
    private const string FILE_NAME_RECENT_PROJECTS = "recent.xml";
    private Solution activeSolution;
    private SolutionInfoList recentSolutions;

    public Solution ActiveSolution
    {
      get
      {
        return this.activeSolution;
      }
    }

    public SolutionInfoList RecentSolutions
    {
      get
      {
        SolutionInfoList solutionInfoList = new SolutionInfoList();
        for (int index = 0; index < this.recentSolutions.Count && index < Global.Options.Solutions.ShowRecentSolutions; ++index)
          solutionInfoList.Add(this.recentSolutions[index]);
        return solutionInfoList;
      }
    }

    public SolutionInfo LastLoadedSolution
    {
      get
      {
        foreach (SolutionInfo solutionInfo in (List<SolutionInfo>) this.recentSolutions)
        {
          if (solutionInfo.File.Exists)
            return solutionInfo;
        }
        return (SolutionInfo) null;
      }
    }

    public event EventHandler SolutionOpened;

    public event EventHandler SolutionClosed;

    public event EventHandler ProjectAdded;

    public event EventHandler ProjectRemoved;

    public event EventHandler RecentSolutionsUpdated;

    public ProjectManager()
    {
      this.recentSolutions = new SolutionInfoList();
      this.LoadRecentSolutions();
    }

    public FileInfo GetCodeTemplate(CodeLang codeLang)
    {
      return new FileInfo(string.Format("{0}\\{1}", (object) Global.Setup.Folders.Templates.FullName, (object) this.GetCodeFileName(codeLang)));
    }

    public FileInfo GetScenarioTemplate(CodeLang codeLang)
    {
      return new FileInfo(string.Format("{0}\\{1}", (object) Global.Setup.Folders.Templates.FullName, (object) this.GetScenarioFileName(codeLang)));
    }

    public string GetCodeFileName(CodeLang codeLang)
    {
      switch (codeLang - 1)
      {
        case 0:
          return "code.cs";
        case 1:
          return "code.vb";
        default:
          throw new ArgumentException(string.Format("Unknown code language - {0}", (object) codeLang));
      }
    }

    public string GetScenarioFileName(CodeLang codeLang)
    {
      switch (codeLang - 1)
      {
        case 0:
          return "scenario.cs";
        case 1:
          return "scenario.vb";
        default:
          throw new ArgumentException(string.Format("Unknown code language - {0}", (object) codeLang));
      }
    }

    public void CloseActiveSolution()
    {
      if (this.activeSolution == null)
        return;
      this.activeSolution.Close();
      this.activeSolution = (Solution) null;
      if (this.SolutionClosed == null)
        return;
      this.SolutionClosed((object) this, EventArgs.Empty);
    }

    public void Open(FileInfo file)
    {
      if (file.Extension == ".oqp")
      {
        NewSolutionDialog newSolutionDialog = new NewSolutionDialog(Global.Setup.Folders.Solutions, file.Name.Split(new char[1]
        {
          '.'
        })[0]);
        if (newSolutionDialog.ShowDialog() != DialogResult.OK)
          return;
        FileInfo file1 = new FileInfo(Global.Setup.Folders.Solutions.FullName + "\\" + newSolutionDialog.SolutionName + "\\" + newSolutionDialog.SolutionName + ".oqs");
        Solution solution = new Solution(file1, newSolutionDialog.SolutionName);
        StrategyProject project = StrategyProject.Open(file);
        solution.AddProject(project);
        solution.Save();
        file = file1;
      }
      this.CloseActiveSolution();
      this.activeSolution = new Solution(file);
      if (this.activeSolution.ScenarioFile == null)
        this.activeSolution.Save();
      if (this.SolutionOpened != null)
        this.SolutionOpened((object) this, EventArgs.Empty);
      this.UpdateRecentProjects();
    }

    public void CreateNewSolution()
    {
      NewSolutionDialog newSolutionDialog = new NewSolutionDialog(Global.Setup.Folders.Solutions, (string) null);
      if (newSolutionDialog.ShowDialog() != DialogResult.OK)
        return;
      FileInfo file = new FileInfo(Global.Setup.Folders.Solutions.FullName + "\\" + newSolutionDialog.SolutionName + "\\" + newSolutionDialog.SolutionName + ".oqs");
      new Solution(file, newSolutionDialog.SolutionName).Save();
      this.CloseActiveSolution();
      this.activeSolution = new Solution(file);
      if (this.SolutionOpened != null)
        this.SolutionOpened((object) this, EventArgs.Empty);
      this.UpdateRecentProjects();
    }

    public void AddExistingProject(FileInfo file)
    {
      StrategyProject project = StrategyProject.Open(file);
      if (this.activeSolution.Projects.ContainsKey(project.Name))
      {
        int num = (int) MessageBox.Show((IWin32Window) null, "The solution already contains selected project", "Can not add project", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.activeSolution.AddProject(project);
        this.activeSolution.Save();
        if (this.ProjectAdded == null)
          return;
        this.ProjectAdded((object) project, EventArgs.Empty);
      }
    }

    public void AddNewProject(FileInfo projectFile, CodeLang codeLang, string name, string description)
    {
      StrategyProject project = StrategyProject.Create(projectFile, codeLang, name, description);
      this.activeSolution.AddProject(project);
      this.activeSolution.Save();
      if (this.ProjectAdded == null)
        return;
      this.ProjectAdded((object) project, EventArgs.Empty);
    }

    public void CreateNewProject(FileInfo solutionFile, string solutionName, FileInfo projectFile, CodeLang codeLang, string name, string description)
    {
      this.CloseActiveSolution();
      this.activeSolution = new Solution(solutionFile, solutionName);
      this.activeSolution.AddProject(StrategyProject.Create(projectFile, codeLang, name, description));
      this.activeSolution.Save();
      this.UpdateRecentProjects();
      if (this.SolutionOpened == null)
        return;
      this.SolutionOpened((object) this, EventArgs.Empty);
    }

    public void Remove(StrategyProject project)
    {
      this.activeSolution.RemoveProject(project);
      this.activeSolution.Save();
      if (this.ProjectRemoved == null)
        return;
      this.ProjectRemoved((object) project, EventArgs.Empty);
    }

    private void UpdateRecentProjects()
    {
      SolutionInfo solutionInfo = new SolutionInfo(this.activeSolution);
      this.recentSolutions.Remove(solutionInfo);
      this.recentSolutions.Add(solutionInfo);
      this.recentSolutions.SortByDates();
      while (this.recentSolutions.Count > Global.Options.Solutions.MaxRecentSolutions)
        this.recentSolutions.RemoveAt(this.recentSolutions.Count - 1);
      this.SaveRecentSolutions();
      if (this.RecentSolutionsUpdated == null)
        return;
      this.RecentSolutionsUpdated((object) this, EventArgs.Empty);
    }

    private void SaveRecentSolutions()
    {
      RecentSolutionsXmlDocument solutionsXmlDocument = new RecentSolutionsXmlDocument();
      foreach (SolutionInfo info in (List<SolutionInfo>) this.recentSolutions)
        solutionsXmlDocument.Solutions.Add(info);
      solutionsXmlDocument.Save(this.GetRecentSolutionsFileName());
    }

    private void LoadRecentSolutions()
    {
      string solutionsFileName = this.GetRecentSolutionsFileName();
      if (File.Exists(solutionsFileName))
      {
        RecentSolutionsXmlDocument solutionsXmlDocument = new RecentSolutionsXmlDocument();
        solutionsXmlDocument.Load(solutionsFileName);
        foreach (RecentSolutionXmlNode recentSolutionXmlNode in (ListXmlNode<RecentSolutionXmlNode>) solutionsXmlDocument.Solutions)
          this.recentSolutions.Add(new SolutionInfo(recentSolutionXmlNode.Path.GetValue(Global.Setup.Folders.Solutions), recentSolutionXmlNode.Name.Value, recentSolutionXmlNode.Description.Value, recentSolutionXmlNode.DateModified.Value));
        this.recentSolutions.SortByDates();
      }
      else
      {
        foreach (FileInfo file in Global.Setup.Folders.Solutions.GetFiles("*.oqs", SearchOption.AllDirectories))
          this.recentSolutions.Add(new SolutionInfo(file, Path.GetFileNameWithoutExtension(file.Name), string.Empty, DateTime.Now));
      }
    }

    private string GetRecentSolutionsFileName()
    {
      return string.Format("{0}\\{1}", (object) Global.Setup.Folders.Solutions.FullName, (object) "recent.xml");
    }
  }
}
