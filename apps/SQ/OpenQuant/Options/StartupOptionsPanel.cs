// Type: OpenQuant.Options.StartupOptionsPanel
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Shared.Options;
using OpenQuant.Startup;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Options
{
  internal class StartupOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private Label label1;
    private ComboBox cbxStartupActions;
    private CheckBox chbCheckForUpdates;

    public StartupOptionsPanel()
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
      this.label1 = new Label();
      this.cbxStartupActions = new ComboBox();
      this.chbCheckForUpdates = new CheckBox();
      ((Control) this).SuspendLayout();
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(66, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "At startup:";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxStartupActions.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxStartupActions.FormattingEnabled = true;
      this.cbxStartupActions.Location = new Point(8, 32);
      this.cbxStartupActions.Name = "cbxStartupActions";
      this.cbxStartupActions.Size = new Size(241, 21);
      this.cbxStartupActions.TabIndex = 1;
      this.cbxStartupActions.SelectedIndexChanged += new EventHandler(this.cbxStartupActions_SelectedIndexChanged);
      this.chbCheckForUpdates.Location = new Point(16, 72);
      this.chbCheckForUpdates.Name = "chbCheckForUpdates";
      this.chbCheckForUpdates.Size = new Size(154, 20);
      this.chbCheckForUpdates.TabIndex = 2;
      this.chbCheckForUpdates.Text = "Check for updates";
      this.chbCheckForUpdates.UseVisualStyleBackColor = true;
      this.chbCheckForUpdates.CheckedChanged += new EventHandler(this.chbCheckForUpdates_CheckedChanged);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((Control) this).Controls.Add((Control) this.chbCheckForUpdates);
      ((Control) this).Controls.Add((Control) this.cbxStartupActions);
      ((Control) this).Controls.Add((Control) this.label1);
      ((Control) this).Name = "StartupOptionsPanel";
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      this.cbxStartupActions.BeginUpdate();
      this.cbxStartupActions.Items.Clear();
      foreach (StartupAction action in Enum.GetValues(typeof (StartupAction)))
        this.cbxStartupActions.Items.Add((object) new StartupActionItem(action));
      this.cbxStartupActions.SelectedItem = (object) Global.Options.Environment.Startup.Action;
      this.cbxStartupActions.EndUpdate();
      this.chbCheckForUpdates.Checked = Global.Options.Environment.Startup.CheckForUpdates;
    }

    protected virtual void OnCommitChanges()
    {
      Global.Options.Environment.Startup.Action = ((StartupActionItem) this.cbxStartupActions.SelectedItem).Action;
      Global.Options.Environment.Startup.CheckForUpdates = this.chbCheckForUpdates.Checked;
      Global.Options.Environment.Startup.Save();
    }

    private void cbxStartupActions_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void chbCheckForUpdates_CheckedChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }
  }
}
