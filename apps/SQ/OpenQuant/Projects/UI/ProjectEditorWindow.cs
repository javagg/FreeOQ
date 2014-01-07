// Type: OpenQuant.Projects.UI.ProjectEditorWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Options;
using SmartQuant.Docking.WinForms;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class ProjectEditorWindow : EditorWindow
  {
    private IContainer components;

    public virtual object PropertyObject
    {
      get
      {
        if (((DockControl) this).get_Key() is ProjectEditorKey)
          return (object) new StrategySettingsTypeDescriptor(((ProjectEditorKey) ((DockControl) this).get_Key()).Project.StrategySettings);
        else
          return (object) null;
      }
    }

    protected virtual BuildOptions BuildOptions
    {
      get
      {
        return Global.Options.Solutions.Build;
      }
    }

    protected virtual EditorOptions EditorOptions
    {
      get
      {
        return Global.Options.Solutions.Editor;
      }
    }

    public ProjectEditorWindow()
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

    protected virtual void UpdateTitle()
    {
      if (this.get_File() == null)
        return;
      if (((DockControl) this).get_Key() is ProjectEditorKey)
        ((Control) this).Text = string.Format("{0} ({1})", (object) this.get_File().Name, (object) ((ProjectEditorKey) ((DockControl) this).get_Key()).Project.Name);
      else
        ((Control) this).Text = this.get_File().Name;
      if (!this.get_IsChanged())
        return;
      ProjectEditorWindow projectEditorWindow = this;
      string str = ((Control) projectEditorWindow).Text + "*";
      ((Control) projectEditorWindow).Text = str;
    }
  }
}
