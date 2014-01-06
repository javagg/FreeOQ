// Type: SmartQuant.Execution.SingleOrder
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using dlvFKIB6u5cF0WHnyP;
using RZ1j9O1DCcsDf19ge6;
using SmartQuant;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Execution
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
    [TypeConverter(typeof (YnBX8yTrxmEviTy8uc))]
    [Description("Execution provider")]
    [ReadOnly(true)]
    public IExecutionProvider Provider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nFKVI6u5c;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nFKVI6u5c = value;
      }
    }

    [Description("Portfolio")]
    [ReadOnly(true)]
    [Category("Attributes")]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.S0WvHnyPg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.S0WvHnyPg = value;
      }
    }

    [ReadOnly(true)]
    [Category("Attributes")]
    [Description("Instrument")]
    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.C9gt8Rtlw == null)
          this.C9gt8Rtlw = InstrumentManager.Instruments[this.Symbol];
        return this.C9gt8Rtlw;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FsOs8elgL;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.FsOs8elgL = value;
      }
    }

    [Browsable(false)]
    public bool IsStopLimitReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LW91eligg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LW91eligg = value;
      }
    }

    [Browsable(false)]
    public NewOrderSingle ReplaceOrder
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WNHbo8cie;
      }
    }

    [Browsable(false)]
    [FIXField("37", EFieldOption.Optional)]
    public string OrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(37);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(37, value);
      }
    }

    [Browsable(false)]
    public ExecutionReportList Reports
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zOvnD0v17;
      }
    }

    [Browsable(false)]
    public OrderCancelRejectList Rejects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mPrWSRdPO;
      }
    }

    [Browsable(false)]
    public bool IsNew
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.New;
      }
    }

    [Browsable(false)]
    public bool IsPartiallyFilled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.PartiallyFilled;
      }
    }

    [Browsable(false)]
    public bool IsFilled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Filled;
      }
    }

    [Browsable(false)]
    public bool IsDoneForDay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.DoneForDay;
      }
    }

    [Browsable(false)]
    public bool IsCancelled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Cancelled;
      }
    }

    [Browsable(false)]
    public bool IsReplaced
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Replaced;
      }
    }

    [Browsable(false)]
    public bool IsPendingCancel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.PendingCancel;
      }
    }

    [Browsable(false)]
    public bool IsStopped
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Stopped;
      }
    }

    [Browsable(false)]
    public bool IsRejected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Rejected;
      }
    }

    [Browsable(false)]
    public bool IsSuspended
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Suspended;
      }
    }

    [Browsable(false)]
    public bool IsPendingNew
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.PendingNew;
      }
    }

    [Browsable(false)]
    public bool IsCalculated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Calculated;
      }
    }

    [Browsable(false)]
    public bool IsExpired
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.Expired;
      }
    }

    [Browsable(false)]
    public bool IsAcceptedForBidding
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.AcceptedForBidding;
      }
    }

    [Browsable(false)]
    public bool IsPendingReplace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrdStatus == OrdStatus.PendingReplace;
      }
    }

    [Browsable(false)]
    public bool IsDone
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdStatus.FromFIX(this.GetCharValue(39));
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(39, FIXOrdStatus.ToFIX(value));
      }
    }

    [ReadOnly(true)]
    [Category("Execution")]
    [FIXField("103", EFieldOption.Optional)]
    public int OrdRejReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(103);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(103, value);
      }
    }

    [Category("Execution")]
    [FIXField("151", EFieldOption.Required)]
    [ReadOnly(true)]
    public double LeavesQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(151);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(151, value);
      }
    }

    [Category("Execution")]
    [ReadOnly(true)]
    [FIXField("14", EFieldOption.Required)]
    public double CumQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(14);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(14, value);
      }
    }

    [Category("Execution")]
    [ReadOnly(true)]
    [FIXField("6", EFieldOption.Required)]
    public double AvgPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(6);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(6, value);
      }
    }

    [Category("Execution")]
    [ReadOnly(true)]
    [FIXField("32", EFieldOption.Optional)]
    public double LastQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(32);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(32, value);
      }
    }

    [ReadOnly(true)]
    [Category("Execution")]
    [FIXField("31", EFieldOption.Optional)]
    public double LastPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(31);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(31, value);
      }
    }

    [Description("Force market order execution")]
    [Category("Simulation")]
    [FIXField("11200", EFieldOption.Optional)]
    public bool ForceMarketOrder
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(11200);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(11200, value);
      }
    }

    [Description("FillOnBar mode")]
    [Category("Simulation")]
    [FIXField("11201", EFieldOption.Optional)]
    public int FillOnBarMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(11201);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(11201, value);
      }
    }

    [Category("Strategy")]
    [Description("Strategy that sends this order")]
    [FIXField("11100", EFieldOption.Optional)]
    public string Strategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(11100);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(11100, value);
      }
    }

    [Category("Strategy")]
    [Description("Strategy component that sends this order")]
    [FIXField("11101", EFieldOption.Optional)]
    public string StrategyComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(11101);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(11101, value);
      }
    }

    [Category("Strategy")]
    [Description("")]
    [FIXField("11102", EFieldOption.Optional)]
    public double StrategyPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(11102);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(11102, value);
      }
    }

    [Description("")]
    [Category("Strategy")]
    [FIXField("11103", EFieldOption.Optional)]
    public bool StrategyFill
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(11103);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(11103, value);
      }
    }

    [Description("")]
    [Category("Strategy")]
    [FIXField("11104", EFieldOption.Optional)]
    public char StrategyMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(11104);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(11104, value);
      }
    }

    public bool IsSent { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public event EventHandler StatusChanged;

    public event ExecutionReportEventHandler ExecutionReport;

    public event OrderCancelRejectEventHandler CancelReject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SingleOrder()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      this.zOvnD0v17 = new ExecutionReportList();
      this.mPrWSRdPO = new OrderCancelRejectList();
      this.WNHbo8cie = new NewOrderSingle();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ClOrdID = OrderManager.Xgea6ywFN();
      this.OrdStatus = OrdStatus.PendingNew;
      this.HandlInst = '1';
      this.TimeInForce = TimeInForce.Day;
      this.Currency = Framework.Configuration.DefaultCurrency;
      this.Persistent = false;
      this.IsSent = false;
      // ISSUE: reference to a compiler-generated method
      this.KbABb8YWe(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Send()
    {
      this.IsSent = true;
      this.TransactTime = Clock.Now;
      OrderManager.GM96fGxEM(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cancel()
    {
      OrderManager.mgxNNoGq5(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Replace()
    {
      OrderManager.MlPSr0K75(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
          switch (obj0.CommType)
          {
            case CommType.PerShare:
              num1 = obj0.Commission * obj0.LastQty;
              break;
            case CommType.Percent:
              num1 = obj0.Commission * (obj0.LastPx * obj0.LastQty);
              break;
            case CommType.Absolute:
              num1 = obj0.Commission;
              break;
          }
          SingleOrder singleOrder = this;
          double num2 = singleOrder.Commission + num1;
          singleOrder.Commission = num2;
        }
      }
      this.zOvnD0v17.Add((FIXGroup) obj0);
      if (this.P8yUrxmEv == null)
        return;
      this.P8yUrxmEv((object) this, new ExecutionReportEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void hHemwyJmI([In] OrderCancelReject obj0)
    {
      this.OrdStatus = obj0.OrdStatus;
      this.mPrWSRdPO.Add((FIXGroup) obj0);
      if (this.yTy78ucml == null)
        return;
      this.yTy78ucml((object) this, new OrderCancelRejectEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void aPUkn4BIl()
    {
      if (this.oBtxVWLnB == null)
        return;
      this.oBtxVWLnB((object) this, EventArgs.Empty);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    string IOrder.get_ClOrdID()
    {
      return this.ClOrdID;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    void IOrder.set_ClOrdID([In] string obj0)
    {
      this.ClOrdID = obj0;
    }
  }
}
