// Type: OpenQuant.QuantBase.CreateInstrumentsPromptWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.QuantBase
{
  internal class CreateInstrumentsPromptWindow : Form
  {
    private ImportSettings settings;
    private IContainer components;
    private Label label1;
    private RadioButton rbnCreate;
    private RadioButton rbnSkip;
    private ComboBox cbxInstrumentType;
    private Button btnContinue;
    private Button btnCancel;

    public CreateInstrumentsPromptWindow()
    {
      this.InitializeComponent();
      this.cbxInstrumentType.BeginUpdate();
      this.cbxInstrumentType.Items.Clear();
      foreach (InstrumentType instrumentType in Enum.GetValues(typeof (InstrumentType)))
        this.cbxInstrumentType.Items.Add((object) instrumentType);
      this.cbxInstrumentType.EndUpdate();
    }

    public void Init(ImportSettings settings)
    {
      this.settings = settings;
    }

    protected override void OnShown(EventArgs e)
    {
      if (this.settings.CreateNewInstruments)
        this.rbnCreate.Checked = true;
      else
        this.rbnSkip.Checked = true;
      this.cbxInstrumentType.SelectedItem = (object) this.settings.InstrumentType;
      base.OnShown(e);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        this.settings.CreateNewInstruments = this.rbnCreate.Checked;
        this.settings.InstrumentType = (InstrumentType) this.cbxInstrumentType.SelectedItem;
      }
      base.OnFormClosed(e);
    }

    private void rbnCreate_CheckedChanged(object sender, EventArgs e)
    {
      this.cbxInstrumentType.Enabled = this.rbnCreate.Checked;
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
      this.rbnCreate = new RadioButton();
      this.rbnSkip = new RadioButton();
      this.cbxInstrumentType = new ComboBox();
      this.btnContinue = new Button();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(275, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Import of some series requires new instrument creation";
      this.rbnCreate.Checked = true;
      this.rbnCreate.Location = new Point(16, 64);
      this.rbnCreate.Name = "rbnCreate";
      this.rbnCreate.Size = new Size(171, 24);
      this.rbnCreate.TabIndex = 1;
      this.rbnCreate.TabStop = true;
      this.rbnCreate.Text = "create new instruments of type";
      this.rbnCreate.UseVisualStyleBackColor = true;
      this.rbnCreate.CheckedChanged += new EventHandler(this.rbnCreate_CheckedChanged);
      this.rbnSkip.Location = new Point(16, 92);
      this.rbnSkip.Name = "rbnSkip";
      this.rbnSkip.Size = new Size(151, 24);
      this.rbnSkip.TabIndex = 2;
      this.rbnSkip.Text = "skip such series";
      this.rbnSkip.UseVisualStyleBackColor = true;
      this.cbxInstrumentType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxInstrumentType.FormattingEnabled = true;
      this.cbxInstrumentType.Location = new Point(193, 66);
      this.cbxInstrumentType.Name = "cbxInstrumentType";
      this.cbxInstrumentType.Size = new Size(96, 21);
      this.cbxInstrumentType.Sorted = true;
      this.cbxInstrumentType.TabIndex = 3;
      this.btnContinue.DialogResult = DialogResult.OK;
      this.btnContinue.Location = new Point(86, 138);
      this.btnContinue.Name = "btnContinue";
      this.btnContinue.Size = new Size(64, 24);
      this.btnContinue.TabIndex = 4;
      this.btnContinue.Text = "Continue";
      this.btnContinue.UseVisualStyleBackColor = true;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(159, 138);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(64, 24);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnContinue;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(314, 176);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnContinue);
      this.Controls.Add((Control) this.cbxInstrumentType);
      this.Controls.Add((Control) this.rbnSkip);
      this.Controls.Add((Control) this.rbnCreate);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CreateInstrumentsPromptWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Create Instruments";
      this.ResumeLayout(false);
    }
  }
}
