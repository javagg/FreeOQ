using FreeQuant.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using IDataObject = FreeQuant.Data.IDataObject;

namespace OpenQuant.Shared.Data.Management
{
  internal class DailyEditor : DataObjectEditor
  {
    private IContainer components;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private NumericUpDown nudOpen;
    private NumericUpDown nudVolume;
    private NumericUpDown nudClose;
    private NumericUpDown nudLow;
    private NumericUpDown nudHigh;
    private NumericUpDown nudOpenInt;
    private Label label7;

    protected override string ObjectName
    {
      get
      {
        return "Daily";
      }
    }

    public DailyEditor()
    {
      this.InitializeComponent();
      this.SetNumericUpDownRange<double>(this.nudOpen);
      this.SetNumericUpDownRange<double>(this.nudHigh);
      this.SetNumericUpDownRange<double>(this.nudLow);
      this.SetNumericUpDownRange<double>(this.nudClose);
      this.SetNumericUpDownRange<long>(this.nudVolume);
      this.SetNumericUpDownRange<long>(this.nudOpenInt);
      this.dtpDateTime.CustomFormat = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.nudOpen = new NumericUpDown();
      this.nudHigh = new NumericUpDown();
      this.nudLow = new NumericUpDown();
      this.nudClose = new NumericUpDown();
      this.nudVolume = new NumericUpDown();
      this.label7 = new Label();
      this.nudOpenInt = new NumericUpDown();
      this.groupBox1.SuspendLayout();
      this.nudOpen.BeginInit();
      this.nudHigh.BeginInit();
      this.nudLow.BeginInit();
      this.nudClose.BeginInit();
      this.nudVolume.BeginInit();
      this.nudOpenInt.BeginInit();
      this.SuspendLayout();
      this.label1.Text = "Date";
      this.dtpDateTime.Format = DateTimePickerFormat.Custom;
      this.dtpDateTime.Size = new Size(102, 20);
      this.btnCancel.Location = new Point(115, 8);
      this.btnOk.Location = new Point(52, 8);
      this.groupBox1.Controls.Add((Control) this.nudOpenInt);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.nudVolume);
      this.groupBox1.Controls.Add((Control) this.nudClose);
      this.groupBox1.Controls.Add((Control) this.nudLow);
      this.groupBox1.Controls.Add((Control) this.nudHigh);
      this.groupBox1.Controls.Add((Control) this.nudOpen);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Size = new Size(212, 200);
      this.groupBox1.Controls.SetChildIndex((Control) this.label2, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label1, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.dtpDateTime, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label3, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label4, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label5, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label6, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudOpen, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudHigh, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudLow, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudClose, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudVolume, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label7, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudOpenInt, 0);
      this.label2.Location = new Point(16, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(58, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Open";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(16, 72);
      this.label3.Name = "label3";
      this.label3.Size = new Size(58, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "High";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label4.Location = new Point(16, 96);
      this.label4.Name = "label4";
      this.label4.Size = new Size(58, 20);
      this.label4.TabIndex = 4;
      this.label4.Text = "Low";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.label5.Location = new Point(16, 120);
      this.label5.Name = "label5";
      this.label5.Size = new Size(58, 20);
      this.label5.TabIndex = 5;
      this.label5.Text = "Close";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.label6.Location = new Point(16, 144);
      this.label6.Name = "label6";
      this.label6.Size = new Size(58, 20);
      this.label6.TabIndex = 6;
      this.label6.Text = "Volume";
      this.label6.TextAlign = ContentAlignment.MiddleLeft;
      this.nudOpen.Location = new Point(88, 48);
      this.nudOpen.Name = "nudOpen";
      this.nudOpen.Size = new Size(85, 20);
      this.nudOpen.TabIndex = 7;
      this.nudOpen.TextAlign = HorizontalAlignment.Right;
      this.nudOpen.ThousandsSeparator = true;
      this.nudHigh.Location = new Point(88, 72);
      this.nudHigh.Name = "nudHigh";
      this.nudHigh.Size = new Size(85, 20);
      this.nudHigh.TabIndex = 8;
      this.nudHigh.TextAlign = HorizontalAlignment.Right;
      this.nudHigh.ThousandsSeparator = true;
      this.nudLow.Location = new Point(88, 96);
      this.nudLow.Name = "nudLow";
      this.nudLow.Size = new Size(85, 20);
      this.nudLow.TabIndex = 9;
      this.nudLow.TextAlign = HorizontalAlignment.Right;
      this.nudLow.ThousandsSeparator = true;
      this.nudClose.Location = new Point(88, 120);
      this.nudClose.Name = "nudClose";
      this.nudClose.Size = new Size(85, 20);
      this.nudClose.TabIndex = 10;
      this.nudClose.TextAlign = HorizontalAlignment.Right;
      this.nudClose.ThousandsSeparator = true;
      this.nudVolume.Location = new Point(88, 144);
      this.nudVolume.Name = "nudVolume";
      this.nudVolume.Size = new Size(85, 20);
      this.nudVolume.TabIndex = 11;
      this.nudVolume.TextAlign = HorizontalAlignment.Right;
      this.nudVolume.ThousandsSeparator = true;
      this.label7.Location = new Point(16, 168);
      this.label7.Name = "label7";
      this.label7.Size = new Size(58, 20);
      this.label7.TabIndex = 12;
      this.label7.Text = "OpenInt";
      this.label7.TextAlign = ContentAlignment.MiddleLeft;
      this.nudOpenInt.Location = new Point(88, 168);
      this.nudOpenInt.Name = "nudOpenInt";
      this.nudOpenInt.Size = new Size(85, 20);
      this.nudOpenInt.TabIndex = 13;
      this.nudOpenInt.TextAlign = HorizontalAlignment.Right;
      this.nudOpenInt.ThousandsSeparator = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.ClientSize = new Size(220, 240);
      this.Name = "DailyEditor";
      this.groupBox1.ResumeLayout(false);
      this.nudOpen.EndInit();
      this.nudHigh.EndInit();
      this.nudLow.EndInit();
      this.nudClose.EndInit();
      this.nudVolume.EndInit();
      this.nudOpenInt.EndInit();
      this.ResumeLayout(false);
    }

    protected override void OnInit(IDataObject dataObject, int decimalPlaces)
    {
      if (dataObject != null)
      {
        Daily daily = (Daily) dataObject;
        this.nudOpen.Value = (Decimal) ((Bar) daily).Open;
        this.nudHigh.Value = (Decimal) ((Bar) daily).High;
        this.nudLow.Value = (Decimal) ((Bar) daily).Low;
        this.nudClose.Value = (Decimal) ((Bar) daily).Close;
				this.nudVolume.Value = (Decimal)((Bar)daily).Volume;
        this.nudOpenInt.Value = (Decimal) ((Bar) daily).OpenInt;
      }
      this.nudOpen.DecimalPlaces = decimalPlaces;
      this.nudHigh.DecimalPlaces = decimalPlaces;
      this.nudLow.DecimalPlaces = decimalPlaces;
      this.nudClose.DecimalPlaces = decimalPlaces;
    }

    public override IDataObject GetDataObject()
    {
      return (IDataObject) new Daily(this.dtpDateTime.Value.Date, (double) this.nudOpen.Value, (double) this.nudHigh.Value, (double) this.nudLow.Value, (double) this.nudClose.Value, (long) this.nudVolume.Value, (long) this.nudOpenInt.Value);
    }
  }
}
