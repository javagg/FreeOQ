using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace FreeQuant.Simulation
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class SimulationExecutionProvider : IExecutionProvider
	{
		private const string IpgPGddVVV = "Simulator(execution)";
		private const string XmtPajagWB = "Simulation Execution Provider";
		private const string CURL = "http://www.FreeQuant.com";
		private const byte PROVIDER_ID = 2;
		private const string TaVPU6ItfP = "Information";
		private const string POlPN9ROBL = "Status";
		private const string IUQPZyvfnc = "Fill Data";
		private const string uWeP8DLFPi = "Trigger Data";
		private const string aVwPj3Y8Op = "Fill Mode";
		private const string TbGPuqfyM8 = "Commission & Slippage";
		internal Hashtable MyIPdEI7fi;

		[Category("Information")]
		public string Name
		{
			get
			{
				return "SimulationExecutionProvider";
			}
		}

		[Category("Information")]
		public string Title
		{
			get
			{
				return "SimulationExecutionProvider";
			}
		}

		[Category("Information")]
		public byte Id
		{
			get
			{
				return PROVIDER_ID;
			}
		}

		[Category("Information")]
		public string URL
		{
			get
			{
				return CURL;
			}
		}

		[Category("Status")]
		public bool IsConnected { get; private set; }

		[Category("Status")]
		public ProviderStatus Status { get; private set; }

		[DefaultValue(0)]
		[Category("Fill Data")]
		public int Latency { get; set; }

		[DefaultValue(true)]
		[Category("Fill Data")]
		public bool PartialFills { get; set; }

		[Category("Fill Data")]
		[DefaultValue(true)]
		public bool FillOnQuote { get; set; }

		[DefaultValue(true)]
		[Category("Fill Data")]
		public bool FillOnTrade { get; set; }

		[DefaultValue(true)]
		[Category("Fill Data")]
		public bool FillOnBar { get; set; }

		[Category("Trigger Data")]
		[DefaultValue(true)]
		public bool TriggerOnQuote { get; set; }

		[DefaultValue(true)]
		[Category("Trigger Data")]
		public bool TriggerOnTrade { get; set; }

		[Category("Trigger Data")]
		[DefaultValue(true)]
		public bool TriggerOnBar { get; set; }

		[DefaultValue(FillOnTradeMode.LastTrade)]
		[Category("Fill Mode")]
		public FillOnTradeMode FillOnTradeMode { get; set; }

		[Category("Fill Mode")]
		[DefaultValue(FillOnQuoteMode.LastQuote)]
		public FillOnQuoteMode FillOnQuoteMode { get; set; }

		[DefaultValue(FillOnBarMode.LastBarClose)]
		[Category("Fill Mode")]
		public FillOnBarMode FillOnBarMode { get; set; }

		[DefaultValue(false)]
		[Category("Fill Mode")]
		public bool FillAtStopPrice { get; set; }

		[Category("Fill Mode")]
		[DefaultValue(false)]
		public bool FillAtLimitPrice { get; set; }

		[DefaultValue(false)]
		[Category("Fill Mode")]
		public bool FillAtWorstQuoteRate { get; set; }

		[Category("Commission & Slippage")]
		public ICommissionProvider CommissionProvider { get; set; }

		[Browsable(false)]
		public string CommissionProviderStr
		{
			get
			{
				List<string> list = new List<string>();
				if (this.CommissionProvider != null)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					list.Add(((object)this.CommissionProvider.CommType).ToString());
					list.Add(this.CommissionProvider.Commission.ToString((IFormatProvider)invariantCulture));
					if (this.CommissionProvider is CommissionProvider)
						list.Add((this.CommissionProvider as CommissionProvider).MinCommission.ToString((IFormatProvider)invariantCulture));
				}
				return string.Join(",", list.ToArray());
			}
			set
			{
				if (this.CommissionProvider == null || value == null)
					return;
				string[] strArray = value.Split(new char[1]
				{
					'|'
				});
				if (strArray.Length < 2)
					return;
				if (Enum.IsDefined(typeof(CommType), (object)strArray[0]))
					this.CommissionProvider.CommType = (CommType)Enum.Parse(typeof(CommType), strArray[0]);
				double result1;
				if (double.TryParse(strArray[1], NumberStyles.Float, (IFormatProvider)CultureInfo.InvariantCulture, out result1))
					this.CommissionProvider.Commission = result1;
				double result2;
				if (!(this.CommissionProvider is CommissionProvider) || strArray.Length != 3 || !double.TryParse(strArray[2], NumberStyles.Float, (IFormatProvider)CultureInfo.InvariantCulture, out result2))
					return;
				(this.CommissionProvider as CommissionProvider).MinCommission = result2;
			}
		}

		[Category("Commission & Slippage")]
		public ISlippageProvider SlippageProvider { get; set; }

		[Category("Fill Data")]
		public BarFilter BarFilter { get; private set; }

		[Browsable(false)]
		public string BarFilterString
		{
			get
			{
				return this.BarFilter.ToString();
			}
			set
			{
				this.BarFilter.Vx1yomJJIf(value);
			}
		}

		public event EventHandler Connected;
		public event EventHandler Disconnected;
		public event ProviderErrorEventHandler Error;
		public event EventHandler StatusChanged;
		public event ExecutionReportEventHandler ExecutionReport;
		public event OrderCancelRejectEventHandler OrderCancelReject;

		public SimulationExecutionProvider()
		{
			this.Status = ProviderStatus.Unknown;
			this.MyIPdEI7fi = new Hashtable();
			this.FillOnQuote = true;
			this.FillOnTrade = true;
			this.FillOnBar = true;
			this.TriggerOnQuote = true;
			this.TriggerOnTrade = true;
			this.TriggerOnBar = true;
			this.PartialFills = true;
			this.CommissionProvider = (ICommissionProvider)new CommissionProvider();
			this.SlippageProvider = (ISlippageProvider)new SlippageProvider();
			this.BarFilter = new BarFilter();
			ProviderManager.Add(this);
			ProviderManager.ExecutionSimulator = this;
		}

		public void Connect()
		{
			if (this.IsConnected)
				return;
			this.IsConnected = true;
			this.Status = ProviderStatus.Connected;
			if (this.StatusChanged != null)
				this.StatusChanged(this, EventArgs.Empty);
			if (this.Connected != null)
				this.Connected(this, EventArgs.Empty);
		}

		public void Connect(int timeout)
		{
			this.Connect();
			ProviderManager.WaitConnected(this, timeout);
		}

		public void Disconnect()
		{
			if (!this.IsConnected)
				return;

			while (this.MyIPdEI7fi.Count > 0)
			{
				IEnumerator enumerator = this.MyIPdEI7fi.Values.GetEnumerator();
				try
				{
          if (enumerator.MoveNext())
            ((zo21q6cy3fImtUHATQ) enumerator.Current).XNWFfvowtr();
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
						disposable.Dispose();
				}
			}
			this.IsConnected = false;
			this.Status = ProviderStatus.Disconnected;
			if (this.StatusChanged != null)
				this.StatusChanged(this, EventArgs.Empty);
			if (this.Disconnected != null)
				this.Disconnected(this, EventArgs.Empty);
		}

		public void Shutdown()
		{
			this.Disconnect();
		}

		public void SendNewOrderSingle(NewOrderSingle order)
		{
			if (this.IsConnected)
			{
				if (this.Latency == 0)
					this.lCXP6mCfhb(order);
				else
					Clock.AddReminder(new ReminderEventHandler(this.MxtPRD9hCH), DateTime.Now.AddMilliseconds(this.Latency), order);
			}
			else
			{
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = DateTime.Now;
				report.ClOrdID = order.ClOrdID;
				report.ExecType = ExecType.Rejected;
				report.OrdStatus = OrdStatus.Rejected;
				report.Symbol = order.Symbol;
				report.SecurityType = order.SecurityType;
				report.SecurityExchange = order.SecurityExchange;
				report.Currency = order.Currency;
				report.Side = order.Side;
				report.OrdType = order.OrdType;
				report.TimeInForce = order.TimeInForce;
				report.OrderQty = order.OrderQty;
				report.Price = order.Price;
				report.StopPx = order.StopPx;
				report.LastPx = 0.0;
				report.LastQty = 0.0;
				report.AvgPx = 0.0;
				report.CumQty = 0.0;
				report.LeavesQty = order.OrderQty;
				report.Text = "text";
				this.JPVPJSWclF(report);
			}
		}

		public void SendOrderCancelRequest(OrderCancelRequest request)
		{
			if (this.Latency == 0)
				this.E3jPCDq9jY(request);
			else
				Clock.AddReminder(new ReminderEventHandler(this.t99PErAC3Y), DateTime.Now.AddMilliseconds(this.Latency), request);
		}

		public void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
		{
			if (this.Latency == 0)
				this.M9IPlabLYo(request);
			else
				Clock.AddReminder(new ReminderEventHandler(this.gFqPLKYI6J), DateTime.Now.AddMilliseconds(this.Latency), request);
		}

		public void SendOrderStatusRequest(OrderStatusRequest request)
		{
			throw new NotImplementedException();
		}

		private void MxtPRD9hCH(ReminderEventArgs e)
		{
			this.lCXP6mCfhb(e.Data as NewOrderSingle);
		}

		private void t99PErAC3Y(ReminderEventArgs e)
		{
			this.E3jPCDq9jY(e.Data as OrderCancelRequest);
		}

		private void gFqPLKYI6J(ReminderEventArgs e)
		{
			this.M9IPlabLYo(e.Data as OrderCancelReplaceRequest);
		}

		private void lCXP6mCfhb(NewOrderSingle e)
		{
			SingleOrder singleOrder = e as SingleOrder;
			if (singleOrder.IsFilled || singleOrder.IsCancelled)
				return;
			if (e.OrderQty > 0.0)
			{
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = Clock.Now;
				report.ClOrdID = e.ClOrdID;
				report.ExecType = ExecType.New;
				report.OrdStatus = OrdStatus.New;
				report.Symbol = e.Symbol;
				report.OrdType = e.OrdType;
				report.Side = e.Side;
				report.Price = e.Price;
				report.StopPx = e.StopPx;
				report.TrailingAmt = e.TrailingAmt;
				report.OrderQty = e.OrderQty;
				report.CumQty = 0.0;
				report.LeavesQty = e.OrderQty;
				report.Currency = e.Currency;
				report.Text = e.Text;
				this.JPVPJSWclF(report);
				zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = new zo21q6cy3fImtUHATQ(this, e);
			}
			else
			{
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = DateTime.Now;
				report.ClOrdID = e.ClOrdID;
				report.ExecType = ExecType.Rejected;
				report.OrdStatus = OrdStatus.Rejected;
				report.Symbol = e.Symbol;
				report.OrdType = e.OrdType;
				report.Side = e.Side;
				report.Price = e.Price;
				report.StopPx = e.StopPx;
				report.TrailingAmt = e.TrailingAmt;
				report.OrderQty = e.OrderQty;
				report.CumQty = 0.0;
				report.LeavesQty = e.OrderQty;
				report.Currency = e.Currency;
				report.Text = e.Text;
				this.JPVPJSWclF(report);
			}
		}

		private void E3jPCDq9jY(OrderCancelRequest request)
		{
      zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = this.MyIPdEI7fi[request.OrigClOrdID] as zo21q6cy3fImtUHATQ;
			if (zo21q6cy3fImtUhatq != null)
		      zo21q6cy3fImtUhatq.XNWFfvowtr();
		}

		private void M9IPlabLYo(OrderCancelReplaceRequest request)
		{
      zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = this.MyIPdEI7fi[request.OrigClOrdID] as zo21q6cy3fImtUHATQ;
      if (zo21q6cy3fImtUhatq == null)
        return;
      if (request.OrderQty > 0.0)
      {
        zo21q6cy3fImtUhatq.CfcFBQBLXe((FIXOrderCancelReplaceRequest) request);
      }
      else
      {
        OrderCancelReject orderCancelReject = new OrderCancelReject();
        orderCancelReject.OrigClOrdID = request.OrigClOrdID;
        orderCancelReject.ClOrdID = request.ClOrdID;
        orderCancelReject.CxlRejResponseTo = CxlRejResponseTo.CancelReplaceRequest;
        orderCancelReject.CxlRejReason = CxlRejReason.BrokerOption;
				orderCancelReject.Text = "";
        orderCancelReject.OrdStatus = zo21q6cy3fImtUhatq.x6qFCwTWN2().OrdStatus;
        orderCancelReject.TransactTime = Clock.Now;
        this.FxSP7oxcnT(orderCancelReject);
      }
		}

		public BrokerInfo GetBrokerInfo()
		{
			return new BrokerInfo();
		}

		public void RegisterOrder(NewOrderSingle order)
		{
		}

		internal void JPVPJSWclF(ExecutionReport report)
		{
      if (this.ExecutionReport != null)
      this.ExecutionReport(this, new ExecutionReportEventArgs(report));
		}

		internal void FxSP7oxcnT(OrderCancelReject reject)
		{
      if (this.OrderCancelReject != null)
      this.OrderCancelReject(this, new OrderCancelRejectEventArgs(reject));
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
