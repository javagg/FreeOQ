// Type: OpenQuant.Options.SolutionsOptionsPanel
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using OpenQuant.Shared.Options;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Options
{
  internal class SolutionsOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private GroupBox groupBox1;
    private Label label1;
    private NumericUpDown nudRecentSolutions;
    private GroupBox groupBox2;
    private ComboBox cbxPostRunAction;

    public SolutionsOptionsPanel()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void OnInit()
    {
      this.nudRecentSolutions.Value = (Decimal) Global.Options.Solutions.ShowRecentSolutions;
      this.cbxPostRunAction.BeginUpdate();
      this.cbxPostRunAction.Items.Clear();
      foreach (PostRunAction action in Enum.GetValues(typeof (PostRunAction)))
        this.cbxPostRunAction.Items.Add((object) new PostRunActionItem(action));
      this.cbxPostRunAction.SelectedItem = (object) Global.Options.Solutions.PostRunAction;
      this.cbxPostRunAction.EndUpdate();
    }

    protected virtual void OnCommitChanges()
    {
      Global.Options.Solutions.PostRunAction = (this.cbxPostRunAction.SelectedItem as PostRunActionItem).Action;
      Global.Options.Solutions.ShowRecentSolutions = (int) this.nudRecentSolutions.Value;
      Global.Options.Solutions.Save();
    }

    private void nudRecentProjects_ValueChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void nudRecentProjects_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsNumber(e.KeyChar))
        return;
      this.set_OptionsChanged(true);
    }

    private void cbxPostRunAction_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.label1 = new Label();
      this.nudRecentSolutions = new NumericUpDown();
      this.groupBox2 = new GroupBox();
      this.cbxPostRunAction = new ComboBox();
      this.groupBox1.SuspendLayout();
      this.nudRecentSolutions.BeginInit();
      this.groupBox2.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.nudRecentSolutions);
      this.groupBox1.Location = new Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(384, 64);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Recent solutions";
      this.label1.Location = new Point(72, 24);
      this.label1.Name = "label1";
      this.label1.Size = new Size(137, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "items shown in Start Page";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.nudRecentSolutions.Location = new Point(16, 24);
      this.nudRecentSolutions.Name = "nudRecentSolutions";
      this.nudRecentSolutions.Size = new Size(48, 20);
      this.nudRecentSolutions.TabIndex = 0;
      this.nudRecentSolutions.TextAlign = HorizontalAlignment.Center;
      NumericUpDown numericUpDown = this.nudRecentSolutions;
      int[] bits = new int[4];
      bits[0] = 1;
      Decimal num = new Decimal(bits);
      numericUpDown.Value = num;
      this.nudRecentSolutions.ValueChanged += new EventHandler(this.nudRecentProjects_ValueChanged);
      this.nudRecentSolutions.KeyPress += new KeyPressEventHandler(this.nudRecentProjects_KeyPress);
      this.groupBox2.Controls.Add((Control) this.cbxPostRunAction);
      this.groupBox2.Location = new Point(8, 80);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(384, 64);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "PostRun action";
      this.cbxPostRunAction.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxPostRunAction.FormattingEnabled = true;
      this.cbxPostRunAction.Location = new Point(16, 20);
      this.cbxPostRunAction.Name = "cbxPostRunAction";
      this.cbxPostRunAction.Size = new Size(168, 21);
      this.cbxPostRunAction.TabIndex = 0;
      this.cbxPostRunAction.SelectedIndexChanged += new EventHandler(this.cbxPostRunAction_SelectedIndexChanged);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((Control) this).Controls.Add((Control) this.groupBox2);
      ((Control) this).Controls.Add((Control) this.groupBox1);
      ((Control) this).Name = "ProjectsOptionsPanel";
      this.groupBox1.ResumeLayout(false);
      this.nudRecentSolutions.EndInit();
      this.groupBox2.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }
  }
}
