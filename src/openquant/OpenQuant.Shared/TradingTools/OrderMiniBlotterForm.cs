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
    internal partial class OrderMiniBlotterForm : Form
    {
        public double LimitPrice
        {
            get
            {
                return (double)this.nudLimitPrice.Value;
            }
        }

        public double StopPrice
        {
            get
            {
                return (double)this.nudStopPrice.Value;
            }
        }

        public int Qty
        {
            get
            {
                return (int)this.nudQty.Value;
            }
        }

        public FreeQuant.FIX.TimeInForce TimeInForce
        {
            get
            {
                return APITypeConverter.TimeInForce.Convert((OpenQuant.API.TimeInForce)this.cbxTIFs.SelectedItem);
            }
        }

        public byte Route
        {
            get
            {
                if (this.cbxRoutes != null && this.cbxRoutes.SelectedIndex >= 0)
                    return ((RouteItem)this.cbxRoutes.SelectedItem).ID;
                else
                    return (byte)0;
            }
        }

        public OrderMiniBlotterForm()
        {
            this.InitializeComponent();
            this.nudLimitPrice.Minimum = new Decimal(-1, -1, -1, true, (byte)0);
            this.nudLimitPrice.Maximum = new Decimal(-1, -1, -1, false, (byte)0);
            this.nudStopPrice.Minimum = new Decimal(-1, -1, -1, true, (byte)0);
            this.nudStopPrice.Maximum = new Decimal(-1, -1, -1, false, (byte)0);
        }

        public void Init(Instrument instrument, OrdType ordType, Side side, byte route)
        {
            this.Text = string.Format("{0} - {1} {2}", instrument, side, ordType);
            int decimalPlaces = PriceFormatHelper.GetDecimalPlaces(instrument);
            Decimal num1 = (Decimal)Math.Pow(0.1, (double)decimalPlaces);
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
                            this.nudLimitPrice.Value = (Decimal)instrument.Quote.Ask;
                            this.nudStopPrice.Value = (Decimal)instrument.Quote.Ask;
                            break;
                        case Side.Sell:
                            this.nudLimitPrice.Value = (Decimal)instrument.Quote.Bid;
                            this.nudStopPrice.Value = (Decimal)instrument.Quote.Bid;
                            break;
                        default:
                            throw new NotSupportedException("Not supported order side - " + ((object)side).ToString());
                    }
                    this.cbxTIFs.BeginUpdate();
                    this.cbxTIFs.Items.Clear();
                    foreach (OpenQuant.API.TimeInForce timeInForce in Enum.GetValues(typeof (OpenQuant.API.TimeInForce)))
                        this.cbxTIFs.Items.Add((object)timeInForce);
                    this.cbxTIFs.SelectedItem = (object)OpenQuant.API.TimeInForce.Day;
                    this.cbxTIFs.EndUpdate();
                    if ((int)route > 0)
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
                        this.groupBox1.Controls.Add((Control)label);
                        this.cbxRoutes = new ComboBox();
                        this.cbxRoutes.DropDownStyle = ComboBoxStyle.DropDownList;
                        this.cbxRoutes.Location = new Point(104, 144);
                        this.cbxRoutes.Size = new Size(98, 21);
                        this.cbxRoutes.Sorted = true;
                        this.groupBox1.Controls.Add((Control)this.cbxRoutes);
                        this.cbxRoutes.BeginUpdate();
                        this.cbxRoutes.Items.Clear();
                        IEnumerator enumerator = ((ProviderList)ProviderManager.ExecutionProviders).GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                IExecutionProvider iexecutionProvider = (IExecutionProvider)enumerator.Current;
                                RouteItem routeItem = new RouteItem(iexecutionProvider.Name, iexecutionProvider.Id);
                                this.cbxRoutes.Items.Add((object)routeItem);
                                if ((int)((IProvider)iexecutionProvider).Id == (int)route)
                                    this.cbxRoutes.SelectedItem = (object)routeItem;
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
                        this.cbxRoutes = (ComboBox)null;
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
