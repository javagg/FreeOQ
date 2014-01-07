// Type: OpenQuant.Startup.StartPageWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using OpenQuant.Projects.UI;
using OpenQuant.Properties;
using OpenQuant.Shared;
using SmartQuant.Docking.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Startup
{
  internal class StartPageWindow : DockControl
  {
    private const string PROJECT_PREFIX = "project:";
    private const string ITEMS_TAG = "<%ITEMS%>";
    private SolutionInfoList projects;
    private bool isInitializing;
    private IContainer components;
    private WebBrowser browser;

    public StartPageWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void OnInit()
    {
      this.InitTable();
      Global.ProjectManager.RecentSolutionsUpdated += new EventHandler(this.ProjectManager_RecentSolutionsUpdated);
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      Global.ProjectManager.RecentSolutionsUpdated -= new EventHandler(this.ProjectManager_RecentSolutionsUpdated);
      ((DockControl) this).OnClosing(e);
    }

    private void InitTable()
    {
      this.projects = Global.ProjectManager.RecentSolutions;
      string startpage = Resources.startpage;
      List<string> list = new List<string>();
      for (int index = 0; index < this.projects.Count; ++index)
      {
        SolutionInfo solutionInfo = this.projects[index];
        if (solutionInfo.File.Exists)
          list.Add(string.Format("<tr><td><a href='{0}{1}'>{2}</a></td><td>{3}</td><td>{4}</td></tr>", (object) "project:", (object) index, (object) solutionInfo.Name, (object) solutionInfo.DateModified, (object) solutionInfo.File.FullName));
        else
          list.Add(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", (object) solutionInfo.Name, (object) solutionInfo.DateModified, (object) solutionInfo.File.FullName));
      }
      string str = startpage.Replace("<%ITEMS%>", string.Join(Environment.NewLine, list.ToArray()));
      this.isInitializing = true;
      this.browser.DocumentText = str;
      this.isInitializing = false;
    }

    private void ProjectManager_RecentSolutionsUpdated(object sender, EventArgs e)
    {
      this.InitTable();
    }

    private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
    {
      if (this.isInitializing)
        return;
      if (Runner.IsRunning)
      {
        int num = (int) MessageBox.Show((IWin32Window) Global.MainForm, "Another solution is currently running.", "Open Solution", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
      }
      else
      {
        int result;
        if (!int.TryParse(e.Url.OriginalString.Substring("project:".Length), out result))
          return;
        e.Cancel = true;
        Global.get_DockManager().Open(typeof (SolutionExplorerWindow));
        Global.ProjectManager.Open(this.projects[result].File);
      }
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.browser = new WebBrowser();
      ((Control) this).SuspendLayout();
      this.browser.AllowWebBrowserDrop = false;
      this.browser.Dock = DockStyle.Fill;
      this.browser.IsWebBrowserContextMenuEnabled = false;
      this.browser.Location = new Point(0, 0);
      this.browser.MinimumSize = new Size(20, 20);
      this.browser.Name = "browser";
      this.browser.Size = new Size(613, 400);
      this.browser.TabIndex = 2;
      this.browser.WebBrowserShortcutsEnabled = false;
      this.browser.Navigating += new WebBrowserNavigatingEventHandler(this.browser_Navigating);
      ((DockControl) this).set_AllowCollapse(false);
      ((DockControl) this).set_AllowDockBottom(false);
      ((DockControl) this).set_AllowDockCenter(true);
      ((DockControl) this).set_AllowDockLeft(false);
      ((DockControl) this).set_AllowDockRight(false);
      ((DockControl) this).set_AllowDockTop(false);
      ((DockControl) this).set_AllowFloat(false);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.browser);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "StartPageWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(613, 400);
      ((Control) this).Text = "Start Page";
      ((Control) this).ResumeLayout(false);
    }
  }
}
