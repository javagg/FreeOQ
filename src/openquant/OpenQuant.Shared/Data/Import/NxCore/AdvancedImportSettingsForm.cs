// Type: OpenQuant.Shared.Data.Import.NxCore.AdvancedImportSettingsForm
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class AdvancedImportSettingsForm : Form
  {
    private AdvancedImportSettings settings;
        private IContainer components = null;
    private CheckBox chbAsync;
    private Label label1;
    private NumericUpDown nudMaxBufferSize;
    private Button btnOK;
    private Button btnCancel;

    public AdvancedImportSettingsForm()
    {
      this.InitializeComponent();
      this.nudMaxBufferSize.Minimum = new Decimal(1);
      this.nudMaxBufferSize.Maximum = new Decimal(int.MaxValue);
    }

    public void Init(AdvancedImportSettings settings)
    {
      this.settings = settings;
    }

    protected override void OnShown(EventArgs e)
    {
      this.chbAsync.Checked = this.settings.WriteDataAsync;
      this.nudMaxBufferSize.Value = (Decimal) this.settings.MaxBufferSize;
      this.UpdateControls();
      base.OnShown(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        this.settings.WriteDataAsync = this.chbAsync.Checked;
        this.settings.MaxBufferSize = (int) this.nudMaxBufferSize.Value;
      }
      base.OnFormClosing(e);
    }

    private void chbAsync_CheckedChanged(object sender, EventArgs e)
    {
      this.UpdateControls();
    }

    private void UpdateControls()
    {
      this.nudMaxBufferSize.Enabled = this.chbAsync.Checked;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.chbAsync = new CheckBox();
      this.label1 = new Label();
      this.nudMaxBufferSize = new NumericUpDown();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.nudMaxBufferSize.BeginInit();
      this.SuspendLayout();
      this.chbAsync.Location = new Point(20, 24);
      this.chbAsync.Name = "chbAsync";
      this.chbAsync.Size = new Size(175, 20);
      this.chbAsync.TabIndex = 0;
      this.chbAsync.Text = "Write data asynchronously";
      this.chbAsync.UseVisualStyleBackColor = true;
      this.chbAsync.CheckedChanged += new EventHandler(this.chbAsync_CheckedChanged);
      this.label1.Location = new Point(28, 56);
      this.label1.Name = "label1";
      this.label1.Size = new Size(87, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Max buffer size";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown numericUpDown = this.nudMaxBufferSize;
      int[] bits = new int[4];
      bits[0] = 1000;
      Decimal num = new Decimal(bits);
      numericUpDown.Increment = num;
      this.nudMaxBufferSize.Location = new Point(134, 56);
      this.nudMaxBufferSize.Name = "nudMaxBufferSize";
      this.nudMaxBufferSize.Size = new Size(99, 20);
      this.nudMaxBufferSize.TabIndex = 2;
      this.nudMaxBufferSize.TextAlign = HorizontalAlignment.Right;
      this.nudMaxBufferSize.ThousandsSeparator = true;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(59, 117);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(71, 25);
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(140, 117);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(71, 25);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(266, 159);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.nudMaxBufferSize);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.chbAsync);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AdvancedImportSettingsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Advanced Settings";
      this.nudMaxBufferSize.EndInit();
      this.ResumeLayout(false);
    }
  }
}
