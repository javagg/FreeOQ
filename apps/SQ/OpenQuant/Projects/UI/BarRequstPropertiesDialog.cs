// Type: OpenQuant.Projects.UI.BarRequstPropertiesDialog
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class BarRequstPropertiesDialog : Form
  {
    private IContainer components;
    private Button btnCancel;
    private Button btnOk;
    private ComboBox cbxTypes;
    private Label label1;
    private NumericUpDown nudBarSize;
    private Label label5;
    private CheckBox cbxIsBarFactoryRequest;
    private GroupBox groupBox1;

    public BarType BarType
    {
      get
      {
        return (BarType) this.cbxTypes.SelectedItem;
      }
    }

    public long BarSize
    {
      get
      {
        return (long) this.nudBarSize.Value;
      }
    }

    public bool IsBarFactoryRequest
    {
      get
      {
        return this.cbxIsBarFactoryRequest.Checked;
      }
    }

    public BarRequstPropertiesDialog()
    {
      this.InitializeComponent();
      foreach (BarType barType in Enum.GetValues(typeof (BarType)))
      {
        if (barType != BarType.Dynamic)
          this.cbxTypes.Items.Add((object) barType);
      }
      this.cbxTypes.SelectedItem = (object) DataManager.DefaultBarType;
      this.nudBarSize.Value = (Decimal) DataManager.DefaultBarSize;
      this.cbxIsBarFactoryRequest.Checked = true;
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
      this.cbxTypes = new ComboBox();
      this.label1 = new Label();
      this.nudBarSize = new NumericUpDown();
      this.label5 = new Label();
      this.cbxIsBarFactoryRequest = new CheckBox();
      this.groupBox1 = new GroupBox();
      this.nudBarSize.BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(121, 112);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(53, 23);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(62, 112);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(53, 23);
      this.btnOk.TabIndex = 3;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.cbxTypes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxTypes.Location = new Point(78, 19);
      this.cbxTypes.Name = "cbxTypes";
      this.cbxTypes.Size = new Size(80, 21);
      this.cbxTypes.TabIndex = 0;
      this.label1.Location = new Point(19, 22);
      this.label1.Name = "label1";
      this.label1.Size = new Size(56, 16);
      this.label1.TabIndex = 6;
      this.label1.Text = "Bar type";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.nudBarSize.Location = new Point(78, 44);
      NumericUpDown numericUpDown1 = this.nudBarSize;
      int[] bits1 = new int[4];
      bits1[0] = 1000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.nudBarSize;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.nudBarSize.Name = "nudBarSize";
      this.nudBarSize.Size = new Size(80, 20);
      this.nudBarSize.TabIndex = 1;
      this.nudBarSize.TextAlign = HorizontalAlignment.Right;
      NumericUpDown numericUpDown3 = this.nudBarSize;
      int[] bits3 = new int[4];
      bits3[0] = 60;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.label5.Location = new Point(19, 48);
      this.label5.Name = "label5";
      this.label5.Size = new Size(56, 16);
      this.label5.TabIndex = 4;
      this.label5.Text = "Bar size";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxIsBarFactoryRequest.AutoSize = true;
      this.cbxIsBarFactoryRequest.Location = new Point(22, 74);
      this.cbxIsBarFactoryRequest.Name = "cbxIsBarFactoryRequest";
      this.cbxIsBarFactoryRequest.Size = new Size(132, 17);
      this.cbxIsBarFactoryRequest.TabIndex = 2;
      this.cbxIsBarFactoryRequest.Text = "Build Bars from Trades";
      this.cbxIsBarFactoryRequest.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.cbxIsBarFactoryRequest);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.cbxTypes);
      this.groupBox1.Controls.Add((Control) this.nudBarSize);
      this.groupBox1.Location = new Point(7, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(167, 100);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Settings";
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(182, 140);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.btnCancel);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "BarRequstPropertiesDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Bar Request Properties";
      this.nudBarSize.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
