using OpenQuant.Shared;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Properties;
using QWhale.Editor.TextSource;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Scripts
{
    public partial class ScriptEditorWindow : EditorWindow
  {

    public override object PropertyObject
    {
      get
      {
        return (object) null;
      }
    }

    protected virtual ScriptsOptions ScriptsOptions
    {
      get
      {
        return (ScriptsOptions) null;
      }
    }

    public ScriptEditorWindow()
    {
      this.InitializeComponent();
    }

    protected override void OnInit()
    {
      base.OnInit();
      Global.ScriptManager.Starting += new EventHandler<ScriptRunnerEventArgs>(this.ScriptManager_Starting);
      Global.ScriptManager.Stopped += new EventHandler<ScriptRunnerEventArgs>(this.ScriptManager_Stopped);
      this.UpdateToolbarButtons();
    }

    protected override void OnClosed(EventArgs e)
    {
      Global.ScriptManager.Starting -= new EventHandler<ScriptRunnerEventArgs>(this.ScriptManager_Starting);
      Global.ScriptManager.Stopped -= new EventHandler<ScriptRunnerEventArgs>(this.ScriptManager_Stopped);
      base.OnClosed(e);
    }

    private void ScriptManager_Starting(object sender, ScriptRunnerEventArgs e)
    {
      if (!new ScriptKey(this.File).Equals((object) e.Runner.Key))
        return;
      this.UpdateToolbarButtons();
    }

    private void ScriptManager_Stopped(object sender, ScriptRunnerEventArgs e)
    {
      if (!new ScriptKey(this.File).Equals((object) e.Runner.Key))
        return;
      this.UpdateToolbarButtons();
    }

    private void tsbBuild_Click(object sender, EventArgs e)
    {
      Global.ScriptManager.Build(this.File, this.BuildOptions);
    }

    private void tsbRun_Click(object sender, EventArgs e)
    {
      Global.ScriptManager.Run(this.File, this.BuildOptions, this.ScriptsOptions);
    }

    private void tsbStop_Click(object sender, EventArgs e)
    {
      Global.ScriptManager.Stop(this.File);
    }

    private void UpdateToolbarButtons()
    {
      Action action = (Action) (() =>
      {
        if (Global.ScriptManager.IsScriptRunning(this.File))
        {
          this.tsbBuild.Enabled = false;
          this.tsbRun.Enabled = false;
          this.tsbStop.Enabled = true;
        }
        else
        {
          this.tsbBuild.Enabled = true;
          this.tsbRun.Enabled = true;
          this.tsbStop.Enabled = false;
        }
      });
      if (this.InvokeRequired)
        this.Invoke((Delegate) action);
      else
        action();
    }
  }
}
