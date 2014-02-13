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
  public class ScriptEditorWindow : EditorWindow
  {
    private IContainer components;
    private ToolStrip toolStrip;
    private ToolStripButton tsbBuild;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton tsbRun;
    private ToolStripButton tsbStop;

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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.toolStrip = new ToolStrip();
      this.tsbBuild = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.tsbRun = new ToolStripButton();
      this.tsbStop = new ToolStripButton();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      this.textEditor.Braces.BracesOptions = BracesOptions.Highlight | BracesOptions.HighlightBounds | BracesOptions.TempHighlight;
      this.textEditor.Gutter.LineNumbersForeColor = SystemColors.ControlText;
      this.textEditor.Location = new Point(0, 25);
      this.textEditor.Outlining.AllowOutlining = true;
      this.textEditor.Size = new Size(562, 419);
      this.toolStrip.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.tsbBuild,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.tsbRun,
        (ToolStripItem) this.tsbStop
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(562, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "toolStrip1";
      this.tsbBuild.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbBuild.Image = (Image) Resources.script_build;
      this.tsbBuild.ImageTransparentColor = Color.Magenta;
      this.tsbBuild.Name = "tsbBuild";
      this.tsbBuild.Size = new Size(23, 22);
      this.tsbBuild.Text = "Build Script";
      this.tsbBuild.Click += new EventHandler(this.tsbBuild_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      this.tsbRun.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbRun.Image = (Image) Resources.script_run;
      this.tsbRun.ImageTransparentColor = Color.Magenta;
      this.tsbRun.Name = "tsbRun";
      this.tsbRun.Size = new Size(23, 22);
      this.tsbRun.Text = "Run Script";
      this.tsbRun.Click += new EventHandler(this.tsbRun_Click);
      this.tsbStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbStop.Image = (Image) Resources.script_stop;
      this.tsbStop.ImageTransparentColor = Color.Magenta;
      this.tsbStop.Name = "tsbStop";
      this.tsbStop.Size = new Size(23, 22);
      this.tsbStop.Text = "Stop Script";
      this.tsbStop.Click += new EventHandler(this.tsbStop_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.toolStrip);
      this.Name = "ScriptEditorWindow";
      this.Size = new Size(562, 444);
      this.Text = "ScriptEditorDocument";
      this.Controls.SetChildIndex((Control) this.toolStrip, 0);
      this.Controls.SetChildIndex((Control) this.textEditor, 0);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
