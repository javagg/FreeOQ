using OpenQuant.Shared;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.TradingTools
{
  internal class OrderMiniBlotterForm : Form
  {
    private IContainer components;
    private Button btnCancel;
    private Button btnSend;
    private GroupBox groupBox1;
    private Label label3;
    private Label label2;
    private Label label1;
    private NumericUpDown nudQty;
    private NumericUpDown nudStopPrice;
    private NumericUpDown nudLimitPrice;
    private Label label4;
    private ComboBox cbxTIFs;
    private ComboBox cbxRoutes;

    public double LimitPrice
    {
      get
      {
        return (double) this.nudLimitPrice.Value;
      }
    }

    public double StopPrice
    {
      get
      {
        return (double) this.nudStopPrice.Value;
      }
    }

    public int Qty
    {
      get
      {
        return (int) this.nudQty.Value;
      }
    }

		public FreeQuant.FIX.TimeInForce TimeInForce
    {
      get
      {
        return APITypeConverter.TimeInForce.Convert((OpenQuant.API.TimeInForce) this.cbxTIFs.SelectedItem);
      }
    }

    public byte Route
    {
      get
      {
        if (this.cbxRoutes != null && this.cbxRoutes.SelectedIndex >= 0)
          return ((RouteItem) this.cbxRoutes.SelectedItem).ID;
        else
          return (byte) 0;
      }
    }

    public OrderMiniBlotterForm()
    {
      this.InitializeComponent();
      this.nudLimitPrice.Minimum = new Decimal(-1, -1, -1, true, (byte) 0);
      this.nudLimitPrice.Maximum = new Decimal(-1, -1, -1, false, (byte) 0);
      this.nudStopPrice.Minimum = new Decimal(-1, -1, -1, true, (byte) 0);
      this.nudStopPrice.Maximum = new Decimal(-1, -1, -1, false, (byte) 0);
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
      this.btnSend = new Button();
      this.groupBox1 = new GroupBox();
      this.cbxTIFs = new ComboBox();
      this.label4 = new Label();
      this.nudQty = new NumericUpDown();
      this.nudStopPrice = new NumericUpDown();
      this.nudLimitPrice = new NumericUpDown();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox1.SuspendLayout();
      this.nudQty.BeginInit();
      this.nudStopPrice.BeginInit();
      this.nudLimitPrice.BeginInit();
      this.SuspendLayout();
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(132, 158);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(64, 22);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      this.btnSend.DialogResult = DialogResult.OK;
      this.btnSend.Location = new Point(62, 158);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new Size(64, 22);
      this.btnSend.TabIndex = 7;
      this.btnSend.Text = "Send";
      this.groupBox1.Controls.Add((Control) this.cbxTIFs);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.nudQty);
      this.groupBox1.Controls.Add((Control) this.nudStopPrice);
      this.groupBox1.Controls.Add((Control) this.nudLimitPrice);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(221, 143);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Order Details";
      this.cbxTIFs.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxTIFs.FormattingEnabled = true;
      this.cbxTIFs.Location = new Point(104, 112);
      this.cbxTIFs.Name = "cbxTIFs";
      this.cbxTIFs.Size = new Size(98, 21);
      this.cbxTIFs.Sorted = true;
      this.cbxTIFs.TabIndex = 17;
      this.label4.Location = new Point(16, 112);
      this.label4.Name = "label4";
      this.label4.Size = new Size(75, 20);
      this.label4.TabIndex = 16;
      this.label4.Text = "Time In Force";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.nudQty.Location = new Point(104, 80);
      NumericUpDown numericUpDown1 = this.nudQty;
      int[] bits1 = new int[4];
      bits1[0] = 1000000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.nudQty.Name = "nudQty";
      this.nudQty.Size = new Size(98, 20);
      this.nudQty.TabIndex = 15;
      this.nudQty.TextAlign = HorizontalAlignment.Right;
      this.nudQty.ThousandsSeparator = true;
      NumericUpDown numericUpDown2 = this.nudQty;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Value = num2;
      this.nudStopPrice.DecimalPlaces = 2;
      this.nudStopPrice.Increment = new Decimal(new int[4]
      {
        1,
        0,
        0,
        131072
      });
      this.nudStopPrice.Location = new Point(104, 48);
      NumericUpDown numericUpDown3 = this.nudStopPrice;
      int[] bits3 = new int[4];
      bits3[0] = 10000000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Maximum = num3;
      this.nudStopPrice.Name = "nudStopPrice";
      this.nudStopPrice.Size = new Size(98, 20);
      this.nudStopPrice.TabIndex = 14;
      this.nudStopPrice.TextAlign = HorizontalAlignment.Right;
      this.nudStopPrice.ThousandsSeparator = true;
      this.nudLimitPrice.DecimalPlaces = 2;
      this.nudLimitPrice.Increment = new Decimal(new int[4]
      {
        1,
        0,
        0,
        131072
      });
      this.nudLimitPrice.Location = new Point(104, 16);
      NumericUpDown numericUpDown4 = this.nudLimitPrice;
      int[] bits4 = new int[4];
      bits4[0] = 10000000;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Maximum = num4;
      this.nudLimitPrice.Name = "nudLimitPrice";
      this.nudLimitPrice.Size = new Size(98, 20);
      this.nudLimitPrice.TabIndex = 13;
      this.nudLimitPrice.TextAlign = HorizontalAlignment.Right;
      this.nudLimitPrice.ThousandsSeparator = true;
      this.label3.Location = new Point(16, 80);
      this.label3.Name = "label3";
      this.label3.Size = new Size(61, 20);
      this.label3.TabIndex = 12;
      this.label3.Text = "Qty";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(16, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(60, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Stop Price";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(60, 20);
      this.label1.TabIndex = 10;
      this.label1.Text = "Limit Price";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.btnSend;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(241, 189);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnSend);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OrderMiniBlotterForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Order Blotter";
      this.groupBox1.ResumeLayout(false);
      this.nudQty.EndInit();
      this.nudStopPrice.EndInit();
      this.nudLimitPrice.EndInit();
      this.ResumeLayout(false);
    }

    public void Init(Instrument instrument, OrdType ordType, Side side, byte route)
    {
      this.Text = string.Format("{0} - {1} {2}", instrument, side, ordType);
      int decimalPlaces = PriceFormatHelper.GetDecimalPlaces(instrument);
      Decimal num1 = (Decimal) Math.Pow(0.1, (double) decimalPlaces);
      this.nudLimitPrice.DecimalPlaces = decimalPlaces;
      this.nudStopPrice.DecimalPlaces = decimalPlaces;
      this.nudLimitPrice.Increment = num1;
      this.nudStopPrice.Increment = num1;
      this.nudLimitPrice.Enabled = false;
      this.nudStopPrice.Enabled = false;
      switch (ordType)
      {
		case OrdType.Market:
          switch (side)
          {
						case Side.Buy:
              this.nudLimitPrice.Value = (Decimal) instrument.Quote.Ask;
              this.nudStopPrice.Value = (Decimal) instrument.Quote.Ask;
              break;
						case Side.Sell:
              this.nudLimitPrice.Value = (Decimal) instrument.Quote.Bid;
              this.nudStopPrice.Value = (Decimal) instrument.Quote.Bid;
              break;
            default:
              throw new NotSupportedException("Not supported order side - " + ((object) side).ToString());
          }
          this.cbxTIFs.BeginUpdate();
          this.cbxTIFs.Items.Clear();
          foreach (OpenQuant.API.TimeInForce timeInForce in Enum.GetValues(typeof (OpenQuant.API.TimeInForce)))
            this.cbxTIFs.Items.Add((object) timeInForce);
          this.cbxTIFs.SelectedItem = (object) OpenQuant.API.TimeInForce.Day;
          this.cbxTIFs.EndUpdate();
          if ((int) route > 0)
          {
            OrderMiniBlotterForm orderMiniBlotterForm = this;
            int num2 = orderMiniBlotterForm.Height + 32;
            orderMiniBlotterForm.Height = num2;
            Button button1 = this.btnSend;
            int num3 = button1.Top + 32;
            button1.Top = num3;
            Button button2 = this.btnCancel;
            int num4 = button2.Top + 32;
            button2.Top = num4;
            GroupBox groupBox = this.groupBox1;
            int num5 = groupBox.Height + 32;
            groupBox.Height = num5;
            Label label = new Label();
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Location = new Point(16, 144);
            label.Size = new Size(70, 20);
            label.Text = "Route";
            this.groupBox1.Controls.Add((Control) label);
            this.cbxRoutes = new ComboBox();
            this.cbxRoutes.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxRoutes.Location = new Point(104, 144);
            this.cbxRoutes.Size = new Size(98, 21);
            this.cbxRoutes.Sorted = true;
            this.groupBox1.Controls.Add((Control) this.cbxRoutes);
            this.cbxRoutes.BeginUpdate();
            this.cbxRoutes.Items.Clear();
            IEnumerator enumerator = ((ProviderList) ProviderManager.ExecutionProviders).GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                IExecutionProvider iexecutionProvider = (IExecutionProvider) enumerator.Current;
                RouteItem routeItem = new RouteItem(iexecutionProvider.Name, iexecutionProvider.Id);
                this.cbxRoutes.Items.Add((object) routeItem);
                if ((int) ((IProvider) iexecutionProvider).Id == (int) route)
                  this.cbxRoutes.SelectedItem = (object) routeItem;
              }
            }
            finally
            {
              IDisposable disposable = enumerator as IDisposable;
              if (disposable != null)
                disposable.Dispose();
            }
            if (this.cbxRoutes.Items.Count > 0 && this.cbxRoutes.SelectedItem == null)
              this.cbxRoutes.SelectedIndex = 0;
            this.cbxRoutes.EndUpdate();
            break;
          }
          else
          {
            this.cbxRoutes = (ComboBox) null;
            break;
          }
				case OrdType.Limit:
          this.nudLimitPrice.Enabled = true;
					goto case OrdType.Market;
				case OrdType.Stop:
          this.nudStopPrice.Enabled = true;
					goto case OrdType.Market;
				case OrdType.StopLimit:
          this.nudLimitPrice.Enabled = true;
          this.nudStopPrice.Enabled = true;
					goto case OrdType.Market;
        default:
          throw new NotSupportedException("Not supported order type - " + ordType.ToString());
      }
    }
  }
}
