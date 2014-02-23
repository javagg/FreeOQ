using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  class CustomFormatDialog : Form
  {
    private Label label1;
    private TextBox txtFormat;
    private Button btnOk;
    private Button btnCancel;
    private LinkLabel lnkHelp;
        private IContainer components = null;

    public string Format
    {
      get
      {
        return this.txtFormat.Text.Trim();
      }
      set
      {
        this.txtFormat.Text = value;
      }
    }

    public CustomFormatDialog()
    {
      this.InitializeComponent();
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
      this.label1 = new Label();
      this.txtFormat = new TextBox();
      this.btnOk = new Button();
      this.btnCancel = new Button();
      this.lnkHelp = new LinkLabel();
      this.SuspendLayout();
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(216, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter your date/time format\n(e.g. yyyy-MM-dd, hh:mm:ss, yyyy-MM-dd HH:mm:ss)";
      this.txtFormat.Location = new Point(16, 72);
      this.txtFormat.Name = "txtFormat";
      this.txtFormat.Size = new Size(232, 20);
      this.txtFormat.TabIndex = 1;
      this.txtFormat.TextChanged += new EventHandler(this.txtFormat_TextChanged);
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(62, 100);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(70, 22);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "OK";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(138, 100);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(70, 22);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.lnkHelp.Location = new Point(184, 48);
      this.lnkHelp.Name = "lnkHelp";
      this.lnkHelp.Size = new Size(72, 16);
      this.lnkHelp.TabIndex = 4;
      this.lnkHelp.TabStop = true;
      this.lnkHelp.Text = "Format help";
      this.lnkHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkHelp_LinkClicked);
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(266, 129);
      this.Controls.Add((Control) this.lnkHelp);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.txtFormat);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CustomFormatDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Custom Format";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void txtFormat_TextChanged(object sender, EventArgs e)
    {
      this.UpdateOkButtonStatus();
    }

    private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      CustomFormatHelpDialog formatHelpDialog = new CustomFormatHelpDialog();
      int num = (int) formatHelpDialog.ShowDialog((IWin32Window) this);
      formatHelpDialog.Dispose();
    }

    private void UpdateOkButtonStatus()
    {
      this.btnOk.Enabled = this.Format != "";
    }
  }
}
