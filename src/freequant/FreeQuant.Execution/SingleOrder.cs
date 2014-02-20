using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.ComponentModel;

namespace FreeQuant.Execution
{
	public class SingleOrder : NewOrderSingle, IOrder
	{
		private Instrument instrument;
		private ExecutionReportList reports;
		private OrderCancelRejectList rejects;
		private NewOrderSingle replaceOrder;

		[Category("Attributes")]
//    [TypeConverter(typeof (YnBX8yTrxmEviTy8uc))]
		[Description("Execution provider")]
		[ReadOnly(true)]
		public IExecutionProvider Provider { get; set; }

		[Description("Portfolio")]
		[ReadOnly(true)]
		[Category("Attributes")]
		public Portfolio Portfolio { get; set; }

		[ReadOnly(true)]
		[Category("Attributes")]
		[Description("Instrument")]
		public Instrument Instrument
		{
			get
			{
				if (this.instrument == null)
					this.instrument = InstrumentManager.Instruments[this.Symbol];
				return this.instrument;
			}
			set
			{
				this.instrument = value;
				if (this.instrument != null)
				{
					this.Symbol = this.instrument.Symbol;
					this.SecurityType = this.instrument.SecurityType;
					this.SecurityExchange = this.instrument.SecurityExchange;
					this.SecurityID = this.instrument.SecurityID;
					this.SecurityIDSource = this.instrument.SecurityIDSource;
					this.Currency = this.instrument.Currency;
					this.MaturityDate = this.instrument.MaturityDate;
					this.MaturityMonthYear = this.instrument.MaturityMonthYear;
					this.StrikePrice = this.instrument.StrikePrice;
					this.PutOrCall = ((FIXInstrument)this.instrument).PutOrCall;
					if (!this.instrument.ContainsField(15))
					{
						this.Currency = Framework.Configuration.DefaultCurrency;
					}
					if (!this.instrument.ContainsField(207))
					{
						this.SecurityExchange = Framework.Configuration.DefaultExchange;
					}
				}
			}
		}

		[Category("Misc")]
		public bool Persistent { get; set; }

		[Browsable(false)]
		public bool IsStopLimitReady { get; set; }

		[Browsable(false)]
		public NewOrderSingle ReplaceOrder
		{
			get
			{
				return this.replaceOrder;
			}
		}

		[Browsable(false)]
		[FIXField("37", EFieldOption.Optional)]
		public string OrderID
		{
			get
			{
				return this.GetStringValue(37);
			}
			set
			{
				this.SetStringValue(37, value);
			}
		}

		[Browsable(false)]
		public ExecutionReportList Reports
		{
			get
			{
				return this.reports;
			}
		}

		[Browsable(false)]
		public OrderCancelRejectList Rejects
		{
			get
			{
				return this.rejects;
			}
		}

		[Browsable(false)]
		public bool IsNew
		{
			get
			{
				return this.OrdStatus == OrdStatus.New;
			}
		}

		[Browsable(false)]
		public bool IsPartiallyFilled
		{
			get
			{
				return this.OrdStatus == OrdStatus.PartiallyFilled;
			}
		}

		[Browsable(false)]
		public bool IsFilled
		{
			get
			{
				return this.OrdStatus == OrdStatus.Filled;
			}
		}

		[Browsable(false)]
		public bool IsDoneForDay
		{
			get
			{
				return this.OrdStatus == OrdStatus.DoneForDay;
			}
		}

		[Browsable(false)]
		public bool IsCancelled
		{
			get
			{
				return this.OrdStatus == OrdStatus.Cancelled;
			}
		}

		[Browsable(false)]
		public bool IsReplaced
		{
			get
			{
				return this.OrdStatus == OrdStatus.Replaced;
			}
		}

		[Browsable(false)]
		public bool IsPendingCancel
		{
			get
			{
				return this.OrdStatus == OrdStatus.PendingCancel;
			}
		}

		[Browsable(false)]
		public bool IsStopped
		{
			get
			{
				return this.OrdStatus == OrdStatus.Stopped;
			}
		}

		[Browsable(false)]
		public bool IsRejected
		{
			get
			{
				return this.OrdStatus == OrdStatus.Rejected;
			}
		}

		[Browsable(false)]
		public bool IsSuspended
		{
			get
			{
				return this.OrdStatus == OrdStatus.Suspended;
			}
		}

		[Browsable(false)]
		public bool IsPendingNew
		{
			get
			{
				return this.OrdStatus == OrdStatus.PendingNew;
			}
		}

		[Browsable(false)]
		public bool IsCalculated
		{
			get
			{
				return this.OrdStatus == OrdStatus.Calculated;
			}
		}

		[Browsable(false)]
		public bool IsExpired
		{
			get
			{
				return this.OrdStatus == OrdStatus.Expired;
			}
		}

		[Browsable(false)]
		public bool IsAcceptedForBidding
		{
			get
			{
				return this.OrdStatus == OrdStatus.AcceptedForBidding;
			}
		}

		[Browsable(false)]
		public bool IsPendingReplace
		{
			get
			{
				return this.OrdStatus == OrdStatus.PendingReplace;
			}
		}

		[Browsable(false)]
		public bool IsDone
		{
			get
			{
				return this.IsFilled || this.IsCancelled || this.IsRejected || this.IsExpired;
			}
		}

		[Category("Execution")]
		public OrdStatus OrdStatus
		{
			get
			{
				return FIXOrdStatus.FromFIX(this.GetCharValue(39));
			}
			set
			{
				this.SetCharValue(39, FIXOrdStatus.ToFIX(value));
			}
		}

		[ReadOnly(true)]
		[Category("Execution")]
		[FIXField("103", EFieldOption.Optional)]
		public int OrdRejReason
		{
			get
			{
				return this.GetIntValue(103);
			}
			set
			{
				this.SetIntValue(103, value);
			}
		}

		[Category("Execution")]
		[FIXField("151", EFieldOption.Required)]
		[ReadOnly(true)]
		public double LeavesQty
		{
			get
			{
				return this.GetDoubleValue(151);
			}
			set
			{
				this.SetDoubleValue(151, value);
			}
		}

		[Category("Execution")]
		[ReadOnly(true)]
		[FIXField("14", EFieldOption.Required)]
		public double CumQty
		{
			get
			{
				return this.GetDoubleValue(14);
			}
			set
			{
				this.SetDoubleValue(14, value);
			}
		}

		[Category("Execution")]
		[ReadOnly(true)]
		[FIXField("6", EFieldOption.Required)]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleValue(6);
			}
			set
			{
				this.SetDoubleValue(6, value);
			}
		}

		[Category("Execution")]
		[ReadOnly(true)]
		[FIXField("32", EFieldOption.Optional)]
		public double LastQty
		{
			get
			{
				return this.GetDoubleValue(32);
			}
			set
			{
				this.SetDoubleValue(32, value);
			}
		}

		[ReadOnly(true)]
		[Category("Execution")]
		[FIXField("31", EFieldOption.Optional)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleValue(31);
			}
			set
			{
				this.SetDoubleValue(31, value);
			}
		}

		[Description("Force market order execution")]
		[Category("Simulation")]
		[FIXField("11200", EFieldOption.Optional)]
		public bool ForceMarketOrder
		{
			get
			{
				return this.GetBoolValue(11200);
			}
			set
			{
				this.SetBoolValue(11200, value);
			}
		}

		[Description("FillOnBar mode")]
		[Category("Simulation")]
		[FIXField("11201", EFieldOption.Optional)]
		public int FillOnBarMode
		{
			get
			{
				return this.GetIntValue(11201);
			}
			set
			{
				this.SetIntValue(11201, value);
			}
		}

		[Category("Strategy")]
		[Description("Strategy that sends this order")]
		[FIXField("11100", EFieldOption.Optional)]
		public string Strategy
		{
			get
			{
				return this.GetStringValue(11100);
			}
			set
			{
				this.SetStringValue(11100, value);
			}
		}

		[Category("Strategy")]
		[Description("Strategy component that sends this order")]
		[FIXField("11101", EFieldOption.Optional)]
		public string StrategyComponent
		{
			get
			{
				return this.GetStringValue(11101);
			}
			set
			{
				this.SetStringValue(11101, value);
			}
		}

		[Category("Strategy")]
		[Description("")]
		[FIXField("11102", EFieldOption.Optional)]
		public double StrategyPrice
		{
			get
			{
				return this.GetDoubleValue(11102);
			}
			set
			{
				this.SetDoubleValue(11102, value);
			}
		}

		[Description("")]
		[Category("Strategy")]
		[FIXField("11103", EFieldOption.Optional)]
		public bool StrategyFill
		{
			get
			{
				return this.GetBoolValue(11103);
			}
			set
			{
				this.SetBoolValue(11103, value);
			}
		}

		[Description("")]
		[Category("Strategy")]
		[FIXField("11104", EFieldOption.Optional)]
		public char StrategyMode
		{
			get
			{
				return this.GetCharValue(11104);
			}
			set
			{
				this.SetCharValue(11104, value);
			}
		}

		public bool IsSent { get; private set; }

		public event EventHandler StatusChanged;
		public event ExecutionReportEventHandler ExecutionReport;
		public event OrderCancelRejectEventHandler CancelReject;

		public SingleOrder() : base()
		{
			this.reports = new ExecutionReportList();
			this.rejects = new OrderCancelRejectList();
			this.replaceOrder = new NewOrderSingle();

			this.ClOrdID = OrderManager.GetOrdId();
			this.OrdStatus = OrdStatus.PendingNew;
			this.HandlInst = '1';
			this.TimeInForce = TimeInForce.Day;
			this.Currency = Framework.Configuration.DefaultCurrency;
			this.Persistent = false;
			this.IsSent = false;
		}

		public void Send()
		{
			this.IsSent = true;
			this.TransactTime = Clock.Now;
			OrderManager.SendOrder(this);
		}

		public void Cancel()
		{
			OrderManager.CancelOrder(this);
		}

		public void Replace()
		{
			OrderManager.ReplaceOrder(this);
		}

		internal void EmitExecutionReport(ExecutionReport report)
		{
			if ((report.OrdStatus == OrdStatus.New || report.OrdStatus == OrdStatus.PendingNew) && report.ContainsField(37))
				this.OrderID = report.OrderID;
			if (report.Text == "")
				report.Text = this.Text;
			this.CumQty = report.CumQty;
			this.LeavesQty = report.LeavesQty;
			this.AvgPx = report.AvgPx;
			this.OrdStatus = report.OrdStatus;
			if (report.ExecType == ExecType.PartialFill || report.ExecType == ExecType.Fill || report.ExecType == ExecType.Trade)
			{
				this.LastPx = report.LastPx;
				this.LastQty = report.LastQty;
				if (report.ContainsField(13))
				{
					double num1 = 0.0;
//         switch (report.CommType)
//          {
//            case CommType.PerShare:
//              num1 = report.Commission * report.LastQty;
//              break;
//            case CommType.Percent:
//              num1 = report.Commission * (report.LastPx * report.LastQty);
//              break;
//            case CommType.Absolute:
//              num1 = report.Commission;
//              break;
//          }
					SingleOrder singleOrder = this;
					double num2 = singleOrder.Commission + num1;
					singleOrder.Commission = num2;
				}
			}
			this.reports.Add(report);
			if (this.ExecutionReport != null)
			{
				this.ExecutionReport((object)this, new ExecutionReportEventArgs(report));
			}
		}

		internal void EmitCancelReject(OrderCancelReject reject)
		{
			this.OrdStatus = reject.OrdStatus;
			this.rejects.Add(reject);
			if (this.CancelReject != null)
			{
				this.CancelReject(this, new OrderCancelRejectEventArgs(reject));
			}
		}

		internal void EmitStatusChanged()
		{
			if (this.StatusChanged != null)
			{
      this.StatusChanged(this, EventArgs.Empty);
			}
		}

//	    string IOrder.ClOrdID()
//	    {
//	      return this.ClOrdID;
//	    }
//		    void IOrder.set_ClOrdID(string obj0)
//		    {
//		      this.ClOrdID = obj0;
//		    }
	}
}
