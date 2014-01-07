// Type: OpenQuant.Projects.UI.StrategyMonitorWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Shared.Logs;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  internal class StrategyMonitorWindow : StrategyMonitorWindow
  {
    private IContainer components;

    public virtual string SolutionName
    {
      get
      {
        return Global.ProjectManager.ActiveSolution.Name;
      }
    }

    public StrategyMonitorWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    }
  }
}
