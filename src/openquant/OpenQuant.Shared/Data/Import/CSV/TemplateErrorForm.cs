// Type: OpenQuant.Shared.Data.Import.CSV.TemplateErrorForm
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  internal class TemplateErrorForm : Form
  {
    private TextBox tbxErrors;
    private Button btnOk;
        private IContainer components = null;

    public TemplateErrorForm()
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
      this.tbxErrors = new TextBox();
      this.btnOk = new Button();
      this.SuspendLayout();
      this.tbxErrors.BackColor = SystemColors.Window;
      this.tbxErrors.Location = new Point(8, 8);
      this.tbxErrors.Multiline = true;
      this.tbxErrors.Name = "tbxErrors";
      this.tbxErrors.ReadOnly = true;
      this.tbxErrors.ScrollBars = ScrollBars.Both;
      this.tbxErrors.Size = new Size(440, 216);
      this.tbxErrors.TabIndex = 0;
      this.tbxErrors.Text = "";
      this.tbxErrors.WordWrap = false;
      this.btnOk.DialogResult = DialogResult.Cancel;
      this.btnOk.Location = new Point(200, 232);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(72, 24);
      this.btnOk.TabIndex = 1;
      this.btnOk.Text = "OK";
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnOk;
      this.ClientSize = new Size(458, 269);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.tbxErrors);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TemplateErrorForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Template Errors";
      this.ResumeLayout(false);
    }

    public void SetErrors(string[] lines)
    {
      this.tbxErrors.Clear();
      foreach (string str in lines)
        this.tbxErrors.AppendText(str + Environment.NewLine);
    }
  }
}
