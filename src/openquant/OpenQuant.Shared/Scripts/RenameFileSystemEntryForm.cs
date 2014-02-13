using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Scripts
{
  class RenameFileSystemEntryForm : Form
  {
    private IContainer components;
    private TextBox tbxName;
    private Button btnOK;
    private Button btnCancel;

    public string EntryName
    {
      get
      {
        return this.tbxName.Text.Trim();
      }
    }

    public RenameFileSystemEntryForm()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tbxName = new TextBox();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.tbxName.Location = new Point(24, 18);
      this.tbxName.Name = "tbxName";
      this.tbxName.Size = new Size(191, 20);
      this.tbxName.TabIndex = 0;
      this.tbxName.TextChanged += new EventHandler(this.tbxName_TextChanged);
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(55, 49);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(62, 22);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(123, 49);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(62, 22);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(241, 81);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.tbxName);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RenameFileSystemEntryForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Rename";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void Init(string entryName)
    {
      this.tbxName.Text = entryName;
      this.UpdateOKButtonStatus();
    }

    private void tbxName_TextChanged(object sender, EventArgs e)
    {
      this.UpdateOKButtonStatus();
    }

    private void UpdateOKButtonStatus()
    {
      this.btnOK.Enabled = !string.IsNullOrEmpty(this.EntryName);
    }
  }
}
