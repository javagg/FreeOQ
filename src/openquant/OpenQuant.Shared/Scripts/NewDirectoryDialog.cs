using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Scripts
{
  class NewDirectoryDialog : Form
  {
    private DirectoryInfo directory;
    private List<char> invalidChars;
        private IContainer components = null;
    private Button btnCancel;
    private Button btnOk;
    private TextBox tbxName;
    private Label label1;

    public string FolderName
    {
      get
      {
        return this.tbxName.Text.Trim();
      }
    }

    public NewDirectoryDialog(DirectoryInfo directory)
    {
      this.directory = directory;
      this.invalidChars = new List<char>((IEnumerable<char>) Path.GetInvalidPathChars());
      this.InitializeComponent();
      this.UpdateOkButtonStatus();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK && Directory.Exists(string.Format("{0}\\{1}", (object) this.directory, (object) this.FolderName)))
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "Folder with the same name already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }

    private void UpdateOkButtonStatus()
    {
      this.btnOk.Enabled = this.FolderName != string.Empty;
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
      this.SuspendLayout();
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new Point(180, 65);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(69, 22);
      this.btnCancel.TabIndex = 15;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOk.Location = new Point(105, 65);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(69, 22);
      this.btnOk.TabIndex = 14;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.tbxName.Location = new Point(12, 32);
      this.tbxName.Name = "tbxName";
      this.tbxName.Size = new Size(237, 20);
      this.tbxName.TabIndex = 11;
      this.tbxName.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.tbxName.KeyPress += new KeyPressEventHandler(this.tbxName_KeyPress);
      this.label1.Location = new Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(102, 20);
      this.label1.TabIndex = 8;
      this.label1.Text = "Type name here:";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(263, 99);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.tbxName);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewDirectoryDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "New Folder";
      this.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
