using FreeQuant.Providers;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.API.Design
{
  internal class AltSourceForm : Form
  {
    private IContainer components;
    private ComboBox cbxAltSources;
    private Button btnCancel;
    private Button btnOK;

    public string AltSource
    {
      get
      {
        return this.cbxAltSources.Text.Trim();
      }
    }

    public AltSourceForm()
    {
      this.InitializeComponent();
      this.cbxAltSources.BeginUpdate();
      this.cbxAltSources.Items.Clear();
      foreach (IProvider provider in ProviderManager.Providers)
        this.cbxAltSources.Items.Add((object) provider.Name);
      this.cbxAltSources.EndUpdate();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new Container();
            this.cbxAltSources = new ComboBox();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.SuspendLayout();
      this.cbxAltSources.FormattingEnabled = true;
      this.cbxAltSources.Location = new Point(12, 28);
      this.cbxAltSources.Name = "cbxAltSources";
      this.cbxAltSources.Size = new Size(149, 21);
      this.cbxAltSources.Sorted = true;
      this.cbxAltSources.TabIndex = 0;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(93, 64);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(50, 22);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(37, 64);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(50, 22);
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(175, 98);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.cbxAltSources);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AltSourceForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Select AltSource";
      this.ResumeLayout(false);
    }
  }
}
