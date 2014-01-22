using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Execution
{
  public class SingleOrder : NewOrderSingle, IOrder
  {
    private const string sxcKgOuC2 = "Strategy";
    private const string QMYYWI0RX = "Simulation";
    private IExecutionProvider nFKVI6u5c;
    private Portfolio S0WvHnyPg;
    private Instrument C9gt8Rtlw;
    private ExecutionReportList zOvnD0v17;
    private OrderCancelRejectList mPrWSRdPO;
    private bool FsOs8elgL;
    private bool LW91eligg;
    private NewOrderSingle WNHbo8cie;

    [Category("Attributes")]
//    [TypeConverter(typeof (YnBX8yTrxmEviTy8uc))]
    [Description("Execution provider")]
    [ReadOnly(true)]
    public IExecutionProvider Provider
    {
      get
      {
        return this.nFKVI6u5c;
      }
      set
      {
        this.nFKVI6u5c = value;
      }
    }

    [Description("Portfolio")]
    [ReadOnly(true)]
    [Category("Attributes")]
    public Portfolio Portfolio
    {
      get
      {
        return this.S0WvHnyPg;
      }
      set
      {
        this.S0WvHnyPg = value;
      }
    }

    [ReadOnly(true)]
    [Category("Attributes")]
    [Description("Instrument")]
    public Instrument Instrument
    {
      get
      {
        if (this.C9gt8Rtlw == null)
          this.C9gt8Rtlw = InstrumentManager.Instruments[this.Symbol];
        return this.C9gt8Rtlw;
      }
      set
      {
        this.C9gt8Rtlw = value;
        if (this.C9gt8Rtlw == null)
          return;
        this.Symbol = this.C9gt8Rtlw.Symbol;
        this.SecurityType = this.C9gt8Rtlw.SecurityType;
        this.SecurityExchange = this.C9gt8Rtlw.SecurityExchange;
        this.SecurityID = this.C9gt8Rtlw.SecurityID;
        this.SecurityIDSource = this.C9gt8Rtlw.SecurityIDSource;
        this.Currency = this.C9gt8Rtlw.Currency;
        this.MaturityDate = this.C9gt8Rtlw.MaturityDate;
        this.MaturityMonthYear = this.C9gt8Rtlw.MaturityMonthYear;
        this.StrikePrice = this.C9gt8Rtlw.StrikePrice;
        this.PutOrCall = ((FIXInstrument) this.C9gt8Rtlw).PutOrCall;
        if (!this.C9gt8Rtlw.ContainsField(15))
          this.Currency = Framework.Configuration.DefaultCurrency;
        if (this.C9gt8Rtlw.ContainsField(207))
          return;
        this.SecurityExchange = Framework.Configuration.DefaultExchange;
      }
    }

    [Category("Misc")]
    public bool Persistent
    {
      get
      {
        return this.FsOs8elgL;
      }
      set
      {
        this.FsOs8elgL = value;
      }
    }

    [Browsable(false)]
    public bool IsStopLimitReady
    {
      get
      {
        return this.LW91eligg;
      }
      set
      {
        this.LW91eligg = value;
      }
    }

    [Browsable(false)]
    public NewOrderSingle ReplaceOrder
    {
      get
      {
        return this.WNHbo8cie;
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
        return this.zOvnD0v17;
      }
    }

    [Browsable(false)]
    public OrderCancelRejectList Rejects
    {
      get
      {
        return this.mPrWSRdPO;
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
        if (!this.IsFilled && !this.IsCancelled && !this.IsRejected)
          return this.IsExpired;
        else
          return true;
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

   
		public SingleOrder():base()
    {
      this.zOvnD0v17 = new ExecutionReportList();
      this.mPrWSRdPO = new OrderCancelRejectList();
      this.WNHbo8cie = new NewOrderSingle();
      this.ClOrdID = OrderManager.Xgea6ywFN();
      this.OrdStatus = OrdStatus.PendingNew;
      this.HandlInst = '1';
      this.TimeInForce = TimeInForce.Day;
      this.Currency = Framework.Configuration.DefaultCurrency;
      this.Persistent = false;
      this.IsSent = false;
      // ISSUE: reference to a compiler-generated method
//      this.KbABb8YWe(false);
    }

   
    public void Send()
    {
      this.IsSent = true;
      this.TransactTime = Clock.Now;
      OrderManager.GM96fGxEM(this);
    }

   
    public void Cancel()
    {
      OrderManager.mgxNNoGq5(this);
    }

   
    public void Replace()
    {
      OrderManager.MlPSr0K75(this);
    }

   
    internal void mlSRyS5Q1([In] ExecutionReport obj0)
    {
      if ((obj0.OrdStatus == OrdStatus.New || obj0.OrdStatus == OrdStatus.PendingNew) && obj0.ContainsField(37))
        this.OrderID = obj0.OrderID;
      if (obj0.Text == "")
        obj0.Text = this.Text;
      this.CumQty = obj0.CumQty;
      this.LeavesQty = obj0.LeavesQty;
      this.AvgPx = obj0.AvgPx;
      this.OrdStatus = obj0.OrdStatus;
      if (obj0.ExecType == ExecType.PartialFill || obj0.ExecType == ExecType.Fill || obj0.ExecType == ExecType.Trade)
      {
        this.LastPx = obj0.LastPx;
        this.LastQty = obj0.LastQty;
      if (obj0.ContainsField(13))
        {
         double num1 = 0.0;
//         switch (obj0.CommType)
//          {
//            case CommType.PerShare:
//              num1 = obj0.Commission * obj0.LastQty;
//              break;
//            case CommType.Percent:
//              num1 = obj0.Commission * (obj0.LastPx * obj0.LastQty);
//              break;
//            case CommType.Absolute:
//              num1 = obj0.Commission;
//              break;
//          }
          SingleOrder singleOrder = this;
          double num2 = singleOrder.Commission + num1;
          singleOrder.Commission = num2;
        }
      }
      this.zOvnD0v17.Add((FIXGroup) obj0);
//      if (this.P8yUrxmEv == null)
//        return;
//      this.P8yUrxmEv((object) this, new ExecutionReportEventArgs(obj0));
    }

   
    internal void hHemwyJmI([In] OrderCancelReject obj0)
    {
      this.OrdStatus = obj0.OrdStatus;
      this.mPrWSRdPO.Add((FIXGroup) obj0);
//      if (this.yTy78ucml == null)
//        return;
//      this.yTy78ucml((object) this, new OrderCancelRejectEventArgs(obj0));
    }

   
    internal void aPUkn4BIl()
    {
//      if (this.oBtxVWLnB == null)
//        return;
//      this.oBtxVWLnB((object) this, EventArgs.Empty);
    }

//    [SpecialName]
//   
//    string IOrder.ClOrdID()
//    {
//      return this.ClOrdID;
//    }

//    [SpecialName]
//   
//    void IOrder.set_ClOrdID([In] string obj0)
//    {
//      this.ClOrdID = obj0;
//    }
  }
}
