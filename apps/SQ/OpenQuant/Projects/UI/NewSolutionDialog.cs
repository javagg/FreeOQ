// Type: OpenQuant.Projects.UI.NewSolutionDialog
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class NewSolutionDialog : Form
  {
    private DirectoryInfo directory;
    private List<char> invalidChars;
    private IContainer components;
    private Button btnCancel;
    private Button btnOk;
    private TextBox tbxName;
    private Label label1;
    private Label label2;
    private Panel panel;
    private Panel panel1;

    public string SolutionName
    {
      get
      {
        return this.tbxName.Text.Trim();
      }
    }

    public NewSolutionDialog(DirectoryInfo directory, string projectName)
    {
      this.InitializeComponent();
      if (string.IsNullOrEmpty(projectName))
      {
        this.panel.Visible = false;
        NewSolutionDialog newSolutionDialog = this;
        int num = newSolutionDialog.Height - this.panel.Height;
        newSolutionDialog.Height = num;
      }
      else
      {
        this.tbxName.Text = projectName;
        this.tbxName.SelectionStart = 0;
        this.tbxName.SelectionLength = this.tbxName.Text.Length;
      }
      this.directory = directory;
      this.invalidChars = new List<char>((IEnumerable<char>) Path.GetInvalidPathChars());
      this.UpdateOkButtonStatus();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK && Directory.Exists(string.Format("{0}\\{1}", (object) this.directory, (object) this.SolutionName)))
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "Solution with the same name already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }

    private void UpdateOkButtonStatus()
    {
      this.btnOk.Enabled = this.SolutionName != string.Empty;
    }

    private void tbxName_TextChanged(object sender, EventArgs e)
    {
      this.UpdateOkButtonStatus();
    }

    private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!this.invalidChars.Contains(e.KeyChar) && (int) e.KeyChar != 46 || (int) e.KeyChar == 8)
        return;
      e.Handled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnCancel = new Button();
      this.btnOk = new Button();
      this.tbxName = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.panel = new Panel();
      this.panel1 = new Panel();
      this.panel.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(197, 47);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(69, 22);
      this.btnCancel.TabIndex = 15;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(122, 47);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(69, 22);
      this.btnOk.TabIndex = 14;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.tbxName.Location = new Point(58, 11);
      this.tbxName.Name = "tbxName";
      this.tbxName.Size = new Size(208, 20);
      this.tbxName.TabIndex = 11;
      this.tbxName.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.tbxName.KeyPress += new KeyPressEventHandler(this.tbxName_KeyPress);
      this.label1.Location = new Point(16, 11);
      this.label1.Name = "label1";
      this.label1.Size = new Size(36, 20);
      this.label1.TabIndex = 8;
      this.label1.Text = "Name";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(17, 9);
      this.label2.Name = "label2";
      this.label2.Size = new Size(249, 47);
      this.label2.TabIndex = 16;
      this.label2.Text = "The project is in old format and should be opened as a part of a solution. Please type a name of the solution that will hold the project.";
      this.panel.Controls.Add((Control) this.label2);
      this.panel.Dock = DockStyle.Top;
      this.panel.Location = new Point(0, 0);
      this.panel.Name = "panel";
      this.panel.Size = new Size(278, 48);
      this.panel.TabIndex = 17;
      this.panel1.Controls.Add((Control) this.tbxName);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.btnCancel);
      this.panel1.Controls.Add((Control) this.btnOk);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Location = new Point(0, 48);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(278, 76);
      this.panel1.TabIndex = 18;
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(278, 124);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewSolutionDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "New Solution";
      this.panel.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
