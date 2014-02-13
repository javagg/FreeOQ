using OpenQuant.Shared.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Scripts
{
  class NewScriptDialog : Form
  {
    private IContainer components;
    private Button btnCancel;
    private Button btnOk;
    private ComboBox cbxCodeLang;
    private TextBox tbxName;
    private Label label3;
    private Label label1;
    private DirectoryInfo directory;
    private List<char> invalidChars;

    public string ScriptName
    {
      get
      {
        return this.tbxName.Text.Trim();
      }
    }

    public CodeLang CodeLang
    {
      get
      {
        return (this.cbxCodeLang.SelectedItem as CodeLangItem).CodeLang;
      }
    }

    public NewScriptDialog(DirectoryInfo directory)
    {
      this.directory = directory;
      this.invalidChars = new List<char>((IEnumerable<char>) Path.GetInvalidPathChars());
      this.InitializeComponent();
      this.cbxCodeLang.Items.Add((object) new CodeLangItem(CodeLang.CSharp));
      this.cbxCodeLang.Items.Add((object) new CodeLangItem(CodeLang.VisualBasic));
      this.cbxCodeLang.SelectedIndex = 0;
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
      this.btnCancel = new Button();
      this.btnOk = new Button();
      this.cbxCodeLang = new ComboBox();
      this.tbxName = new TextBox();
      this.label3 = new Label();
      this.label1 = new Label();
      this.SuspendLayout();
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(231, 64);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(69, 22);
      this.btnCancel.TabIndex = 15;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(156, 64);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(69, 22);
      this.btnOk.TabIndex = 14;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.cbxCodeLang.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxCodeLang.FormattingEnabled = true;
      this.cbxCodeLang.Location = new Point(84, 35);
      this.cbxCodeLang.Name = "cbxCodeLang";
      this.cbxCodeLang.Size = new Size((int) sbyte.MaxValue, 21);
      this.cbxCodeLang.TabIndex = 13;
      this.tbxName.Location = new Point(84, 9);
      this.tbxName.Name = "tbxName";
      this.tbxName.Size = new Size(208, 20);
      this.tbxName.TabIndex = 11;
      this.tbxName.KeyPress += new KeyPressEventHandler(this.tbxName_KeyPress);
      this.tbxName.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.label3.Location = new Point(12, 35);
      this.label3.Name = "label3";
      this.label3.Size = new Size(68, 20);
      this.label3.TabIndex = 10;
      this.label3.Text = "Language";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 20);
      this.label1.TabIndex = 8;
      this.label1.Text = "Name";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(312, 91);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.cbxCodeLang);
      this.Controls.Add((Control) this.tbxName);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewScriptDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "New Script";
      this.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        string str = this.ScriptName + ".cs";
        if (this.CodeLang == CodeLang.VisualBasic)
          str = str + ".vb";
        if (File.Exists(string.Format("{0}\\{1}", (object) this.directory, (object) str)))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Script with the same name already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
        }
      }
      base.OnFormClosing(e);
    }

    private void UpdateOkButtonStatus()
    {
      this.btnOk.Enabled = this.ScriptName != string.Empty;
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
  }
}
