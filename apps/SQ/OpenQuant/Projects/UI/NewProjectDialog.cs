// Type: OpenQuant.Projects.UI.NewProjectDialog
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects.UI.Items;
using OpenQuant.Shared.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class NewProjectDialog : Form
  {
    private IContainer components;
    private Button btnOk;
    private Button btnCancel;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox tbxName;
    private TextBox tbxDescription;
    private ComboBox cbxCodeLang;
    private Label label4;
    private TextBox tbxSolutionName;
    private List<char> invalidChars;

    public string ProjectName
    {
      get
      {
        return this.tbxName.Text.Trim();
      }
    }

    public string SolutionName
    {
      get
      {
        return this.tbxSolutionName.Text.Trim();
      }
    }

    public string ProjectDescription
    {
      get
      {
        return this.tbxDescription.Text.Trim();
      }
    }

    public CodeLang CodeLang
    {
      get
      {
        return (this.cbxCodeLang.SelectedItem as CodeLangItem).CodeLang;
      }
    }

    public FileInfo ProjectFile
    {
      get
      {
        return new FileInfo(string.Format("{0}\\{1}\\{1}.{2}", (object) Global.Setup.Folders.Projects.FullName, (object) this.ProjectName, (object) "oqp"));
      }
    }

    public FileInfo SolutionFile
    {
      get
      {
        return new FileInfo(string.Format("{0}\\{1}\\{1}.{2}", (object) Global.Setup.Folders.Solutions.FullName, (object) this.SolutionName, (object) "oqs"));
      }
    }

    public NewProjectDialog(string solutionName)
    {
      this.InitializeComponent();
      if (!string.IsNullOrEmpty(solutionName))
      {
        this.tbxSolutionName.Text = solutionName;
        this.tbxSolutionName.Enabled = false;
      }
      this.invalidChars = new List<char>((IEnumerable<char>) Path.GetInvalidPathChars());
      this.cbxCodeLang.BeginUpdate();
      this.cbxCodeLang.Items.Clear();
      this.cbxCodeLang.Items.Add((object) new CodeLangItem((CodeLang) 1));
      this.cbxCodeLang.Items.Add((object) new CodeLangItem((CodeLang) 2));
      this.cbxCodeLang.SelectedIndex = 0;
      this.cbxCodeLang.EndUpdate();
      this.UpdateOkButtonStatus();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnOk = new Button();
      this.btnCancel = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.tbxName = new TextBox();
      this.tbxDescription = new TextBox();
      this.cbxCodeLang = new ComboBox();
      this.label4 = new Label();
      this.tbxSolutionName = new TextBox();
      this.SuspendLayout();
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(164, 141);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(69, 22);
      this.btnOk.TabIndex = 6;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(239, 141);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(69, 22);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.label1.Location = new Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(68, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Description";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(12, 64);
      this.label3.Name = "label3";
      this.label3.Size = new Size(68, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Language";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.tbxName.Location = new Point(100, 16);
      this.tbxName.Name = "tbxName";
      this.tbxName.Size = new Size(208, 20);
      this.tbxName.TabIndex = 3;
      this.tbxName.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.tbxName.KeyPress += new KeyPressEventHandler(this.tbxName_KeyPress);
      this.tbxDescription.Location = new Point(100, 40);
      this.tbxDescription.Name = "tbxDescription";
      this.tbxDescription.Size = new Size(208, 20);
      this.tbxDescription.TabIndex = 4;
      this.cbxCodeLang.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxCodeLang.FormattingEnabled = true;
      this.cbxCodeLang.Location = new Point(100, 64);
      this.cbxCodeLang.Name = "cbxCodeLang";
      this.cbxCodeLang.Size = new Size((int) sbyte.MaxValue, 21);
      this.cbxCodeLang.TabIndex = 5;
      this.label4.Location = new Point(12, 105);
      this.label4.Name = "label4";
      this.label4.Size = new Size(83, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "Solution Name";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.tbxSolutionName.Location = new Point(100, 105);
      this.tbxSolutionName.Name = "tbxSolutionName";
      this.tbxSolutionName.Size = new Size(208, 20);
      this.tbxSolutionName.TabIndex = 9;
      this.tbxSolutionName.TextChanged += new EventHandler(this.tbxSolutionName_TextChanged);
      this.tbxSolutionName.KeyPress += new KeyPressEventHandler(this.tbxName_KeyPress);
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(320, 175);
      this.Controls.Add((Control) this.tbxSolutionName);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.cbxCodeLang);
      this.Controls.Add((Control) this.tbxDescription);
      this.Controls.Add((Control) this.tbxName);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewProjectDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "New Project";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        if (Directory.Exists(string.Format("{0}\\{1}", (object) Global.Setup.Folders.Projects.FullName, (object) this.ProjectName)))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Project with the same name already exists in your project repository.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
        }
        else if (this.tbxSolutionName.Enabled && Directory.Exists(string.Format("{0}\\{1}", (object) Global.Setup.Folders.Solutions.FullName, (object) this.SolutionName)))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Solution with the same name already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
        }
      }
      base.OnFormClosing(e);
    }

    private void tbxName_TextChanged(object sender, EventArgs e)
    {
      this.UpdateOkButtonStatus();
      if (!this.tbxSolutionName.Enabled)
        return;
      this.tbxSolutionName.Text = this.tbxName.Text;
    }

    private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!this.invalidChars.Contains(e.KeyChar) && (int) e.KeyChar != 46 || (int) e.KeyChar == 8)
        return;
      e.Handled = true;
    }

    private void UpdateOkButtonStatus()
    {
      this.btnOk.Enabled = this.ProjectName != string.Empty && this.SolutionName != string.Empty;
    }

    private void tbxSolutionName_TextChanged(object sender, EventArgs e)
    {
      this.UpdateOkButtonStatus();
    }
  }
}
