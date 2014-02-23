using FreeQuant.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using IDataObject = FreeQuant.Data.IDataObject;

namespace OpenQuant.Shared.Data.Management
{
  internal class TradeEditor : DataObjectEditor
  {
        private IContainer components = null;
    private NumericUpDown nudPrice;
    private Label label3;
    private Label label2;
    private NumericUpDown nudSize;

    protected override string ObjectName
    {
      get
      {
        return "Trade";
      }
    }

    public TradeEditor()
    {
      this.InitializeComponent();
      this.SetNumericUpDownRange<double>(this.nudPrice);
      this.SetNumericUpDownRange<int>(this.nudSize);
      DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
      this.dtpDateTime.CustomFormat = string.Format("{0} {1}", (object) currentInfo.ShortDatePattern, (object) currentInfo.LongTimePattern);
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
      this.nudPrice = new NumericUpDown();
      this.nudSize = new NumericUpDown();
      this.groupBox1.SuspendLayout();
      this.nudPrice.BeginInit();
      this.nudSize.BeginInit();
      this.SuspendLayout();
      this.label1.Size = new Size(64, 20);
      this.dtpDateTime.Format = DateTimePickerFormat.Custom;
      this.dtpDateTime.Size = new Size(151, 20);
      this.groupBox1.Controls.Add((Control) this.nudSize);
      this.groupBox1.Controls.Add((Control) this.nudPrice);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Size = new Size((int) byte.MaxValue, 101);
      this.groupBox1.Controls.SetChildIndex((Control) this.label2, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label1, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.dtpDateTime, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.label3, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudPrice, 0);
      this.groupBox1.Controls.SetChildIndex((Control) this.nudSize, 0);
      this.label2.Location = new Point(16, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(58, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Price";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(16, 64);
      this.label3.Name = "label3";
      this.label3.Size = new Size(58, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Size";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.nudPrice.Location = new Point(86, 40);
      this.nudPrice.Name = "nudPrice";
      this.nudPrice.Size = new Size(90, 20);
      this.nudPrice.TabIndex = 4;
      this.nudPrice.TextAlign = HorizontalAlignment.Right;
      this.nudPrice.ThousandsSeparator = true;
      this.nudSize.Location = new Point(86, 64);
      this.nudSize.Name = "nudSize";
      this.nudSize.Size = new Size(90, 20);
      this.nudSize.TabIndex = 5;
      this.nudSize.TextAlign = HorizontalAlignment.Right;
      this.nudSize.ThousandsSeparator = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.ClientSize = new Size(263, 141);
      this.Name = "TradeEditor";
      this.groupBox1.ResumeLayout(false);
      this.nudPrice.EndInit();
      this.nudSize.EndInit();
      this.ResumeLayout(false);
    }

    public override IDataObject GetDataObject()
    {
      return (IDataObject) new Trade(this.dtpDateTime.Value, (double) this.nudPrice.Value, (int) this.nudSize.Value);
    }

    protected override void OnInit(IDataObject dataObject, int decimalPlaces)
    {
      if (dataObject != null)
      {
        Trade trade = (Trade) dataObject;
        this.nudPrice.Value = (Decimal) trade.Price;
        this.nudSize.Value = (Decimal) trade.Size;
      }
      this.nudPrice.DecimalPlaces = decimalPlaces;
    }
  }
}
