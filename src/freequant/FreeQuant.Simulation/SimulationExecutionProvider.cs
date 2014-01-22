using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Simulation
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class SimulationExecutionProvider : IExecutionProvider, IProvider
  {
    private const string IpgPGddVVV = "Simulator(execution)";
    private const string XmtPajagWB = "Simulation Execution Provider";
    private const string WgiPvc3Gxa = "http://www.FreeQuant.com";
    private const byte hS1P42nNDo = (byte) 2;
    private const string TaVPU6ItfP = "Information";
    private const string POlPN9ROBL = "Status";
    private const string IUQPZyvfnc = "Fill Data";
    private const string uWeP8DLFPi = "Trigger Data";
    private const string aVwPj3Y8Op = "Fill Mode";
    private const string TbGPuqfyM8 = "Commission & Slippage";
    private bool o8DPY3Gxpl;
    private ProviderStatus SPRPHoKM7h;
    internal Hashtable MyIPdEI7fi;
    private bool OT6PXc09JA;
    private bool jApPIfedlK;
    private bool v5ePSd6q47;
    private bool nHiPwNRjLX;
    private bool aw9Pct01wD;
    private bool sqoP9w7Ra4;
    private FillOnTradeMode pUCPpABgQQ;
    private FillOnQuoteMode ywDPhhBJ3l;
    private FillOnBarMode ECGP5j0y56;
    private bool D7lPieCvRj;
    private bool J7TPAE2NPc;
    private bool NyuPV5MBJC;
    private int hRwPnSQTDn;
    private bool pT8P3oN0AY;
    private ICommissionProvider fgjP2LYVa2;
    private ISlippageProvider oJAPKFfD4m;
    private BarFilter I4hPDNarBO;

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
				return "Title";
      }
    }

    [Category("Information")]
    public byte Id
    {
      get
      {
        return 2;
      }
    }

    [Category("Information")]
    public string URL
    {
      get
      {
				return "URL";
      }
    }

    [Category("Status")]
    public bool IsConnected
    {
      get
      {
        return this.o8DPY3Gxpl;
      }
    }

    [Category("Status")]
    public ProviderStatus Status
    {
      get
      {
        return this.SPRPHoKM7h;
      }
    }

    [DefaultValue(0)]
    [Category("Fill Data")]
    public int Latency
    {
      get
      {
        return this.hRwPnSQTDn;
      }
      set
      {
        this.hRwPnSQTDn = value;
      }
    }

    [DefaultValue(true)]
    [Category("Fill Data")]
    public bool PartialFills
    {
      get
      {
        return this.pT8P3oN0AY;
      }
      set
      {
        this.pT8P3oN0AY = value;
      }
    }

    [Category("Fill Data")]
    [DefaultValue(true)]
    public bool FillOnQuote
    {
      get
      {
        return this.OT6PXc09JA;
      }
      set
      {
        this.OT6PXc09JA = value;
      }
    }

    [DefaultValue(true)]
    [Category("Fill Data")]
    public bool FillOnTrade
    {
      get
      {
        return this.jApPIfedlK;
      }
      set
      {
        this.jApPIfedlK = value;
      }
    }

    [DefaultValue(true)]
    [Category("Fill Data")]
    public bool FillOnBar
    {
      get
      {
        return this.v5ePSd6q47;
      }
      set
      {
        this.v5ePSd6q47 = value;
      }
    }

    [Category("Trigger Data")]
    [DefaultValue(true)]
    public bool TriggerOnQuote
    {
      get
      {
        return this.nHiPwNRjLX;
      }
      set
      {
        this.nHiPwNRjLX = value;
      }
    }

    [DefaultValue(true)]
    [Category("Trigger Data")]
    public bool TriggerOnTrade
    {
      get
      {
        return this.aw9Pct01wD;
      }
      set
      {
        this.aw9Pct01wD = value;
      }
    }

    [Category("Trigger Data")]
    [DefaultValue(true)]
    public bool TriggerOnBar
    {
      get
      {
        return this.sqoP9w7Ra4;
      }
      set
      {
        this.sqoP9w7Ra4 = value;
      }
    }

    [DefaultValue(FillOnTradeMode.LastTrade)]
    [Category("Fill Mode")]
    public FillOnTradeMode FillOnTradeMode
    {
      get
      {
        return this.pUCPpABgQQ;
      }
      set
      {
        this.pUCPpABgQQ = value;
      }
    }

    [Category("Fill Mode")]
    [DefaultValue(FillOnQuoteMode.LastQuote)]
    public FillOnQuoteMode FillOnQuoteMode
    {
      get
      {
        return this.ywDPhhBJ3l;
      }
      set
      {
        this.ywDPhhBJ3l = value;
      }
    }

    [DefaultValue(FillOnBarMode.LastBarClose)]
    [Category("Fill Mode")]
    public FillOnBarMode FillOnBarMode
    {
      get
      {
        return this.ECGP5j0y56;
      }
      set
      {
        this.ECGP5j0y56 = value;
      }
    }

    [DefaultValue(false)]
    [Category("Fill Mode")]
    public bool FillAtStopPrice
    {
      get
      {
        return this.D7lPieCvRj;
      }
      set
      {
        this.D7lPieCvRj = value;
      }
    }

    [Category("Fill Mode")]
    [DefaultValue(false)]
    public bool FillAtLimitPrice
    {
      get
      {
        return this.J7TPAE2NPc;
      }
      set
      {
        this.J7TPAE2NPc = value;
      }
    }

    [DefaultValue(false)]
    [Category("Fill Mode")]
    public bool FillAtWorstQuoteRate
    {
      get
      {
        return this.NyuPV5MBJC;
      }
      set
      {
        this.NyuPV5MBJC = value;
      }
    }

    [Category("Commission & Slippage")]
    public ICommissionProvider CommissionProvider
    {
      get
      {
        return this.fgjP2LYVa2;
      }
      set
      {
        this.fgjP2LYVa2 = value;
      }
    }

    [Browsable(false)]
    public string CommissionProviderStr
    {
      get
      {
        List<string> list = new List<string>();
        if (this.fgjP2LYVa2 != null)
        {
          CultureInfo invariantCulture = CultureInfo.InvariantCulture;
          list.Add(((object) this.fgjP2LYVa2.CommType).ToString());
          list.Add(this.fgjP2LYVa2.Commission.ToString((IFormatProvider) invariantCulture));
          if (this.fgjP2LYVa2 is CommissionProvider)
            list.Add((this.fgjP2LYVa2 as CommissionProvider).MinCommission.ToString((IFormatProvider) invariantCulture));
        }
				return string.Join(",", list.ToArray());
      }
      set
      {
        if (this.fgjP2LYVa2 == null || value == null)
          return;
        string[] strArray = value.Split(new char[1]
        {
          '|'
        });
        if (strArray.Length < 2)
          return;
        if (Enum.IsDefined(typeof (CommType), (object) strArray[0]))
          this.fgjP2LYVa2.CommType = (CommType) Enum.Parse(typeof (CommType), strArray[0]);
        double result1;
        if (double.TryParse(strArray[1], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture, out result1))
          this.fgjP2LYVa2.Commission = result1;
        double result2;
        if (!(this.fgjP2LYVa2 is CommissionProvider) || strArray.Length != 3 || !double.TryParse(strArray[2], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture, out result2))
          return;
        (this.fgjP2LYVa2 as CommissionProvider).MinCommission = result2;
      }
    }

    [Category("Commission & Slippage")]
    public ISlippageProvider SlippageProvider
    {
      get
      {
        return this.oJAPKFfD4m;
      }
      set
      {
        this.oJAPKFfD4m = value;
      }
    }

    [Category("Fill Data")]
    public BarFilter BarFilter
    {
      get
      {
        return this.I4hPDNarBO;
      }
    }

    [Browsable(false)]
    public string BarFilterString
    {
      get
      {
        return this.I4hPDNarBO.ToString();
      }
      set
      {
        this.I4hPDNarBO.Vx1yomJJIf(value);
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
      this.SPRPHoKM7h = ProviderStatus.Unknown;
      this.MyIPdEI7fi = new Hashtable();
      this.OT6PXc09JA = true;
      this.jApPIfedlK = true;
      this.v5ePSd6q47 = true;
      this.nHiPwNRjLX = true;
      this.aw9Pct01wD = true;
      this.sqoP9w7Ra4 = true;
      this.pT8P3oN0AY = true;
      this.fgjP2LYVa2 = (ICommissionProvider) new CommissionProvider();
      this.oJAPKFfD4m = (ISlippageProvider) new SlippageProvider();
      this.I4hPDNarBO = new BarFilter();
      ProviderManager.Add((IProvider) this);
      ProviderManager.ExecutionSimulator = (IExecutionProvider) this;
    }

    
    public void Connect()
    {
      if (this.o8DPY3Gxpl)
        return;
      this.o8DPY3Gxpl = true;
      this.SPRPHoKM7h = ProviderStatus.Connected;
//      if (this.O83PTrO73S != null)
//        this.O83PTrO73S((object) this, EventArgs.Empty);
//      if (this.KcQPO09f1q == null)
//        return;
//      this.KcQPO09f1q((object) this, EventArgs.Empty);
    }

    
    public void Connect(int timeout)
    {
      this.Connect();
      ProviderManager.WaitConnected((IProvider) this, timeout);
    }

    
    public void Disconnect()
    {
//      if (!this.o8DPY3Gxpl)
//        return;
//      while (this.MyIPdEI7fi.Count > 0)
//      {
//        IEnumerator enumerator = this.MyIPdEI7fi.Values.GetEnumerator();
//        try
//        {
////          if (enumerator.MoveNext())
////            ((zo21q6cy3fImtUHATQ) enumerator.Current).XNWFfvowtr();
//        }
//        finally
//        {
//          IDisposable disposable = enumerator as IDisposable;
//          if (disposable != null)
//            disposable.Dispose();
//        }
//      }
//      this.o8DPY3Gxpl = false;
//      this.SPRPHoKM7h = ProviderStatus.Disconnected;
//      if (this.S4dPo3vexS != null)
//        this.S4dPo3vexS((object) this, EventArgs.Empty);
//      if (this.KcQPO09f1q == null)
//        return;
//      this.KcQPO09f1q((object) this, EventArgs.Empty);
    }

    
    public void Shutdown()
    {
      this.Disconnect();
    }

    
    public void SendNewOrderSingle(NewOrderSingle order)
    {
      if (this.o8DPY3Gxpl)
      {
        if (this.hRwPnSQTDn == 0)
          this.lCXP6mCfhb(order);
        else
          Clock.AddReminder(new ReminderEventHandler(this.MxtPRD9hCH), Clock.Now.AddMilliseconds((double) this.hRwPnSQTDn), (object) order);
      }
      else
      {
        ExecutionReport executionReport = new ExecutionReport();
        executionReport.TransactTime = Clock.Now;
        executionReport.ClOrdID = order.ClOrdID;
        executionReport.ExecType = ExecType.Rejected;
        executionReport.OrdStatus = OrdStatus.Rejected;
        executionReport.Symbol = order.Symbol;
        executionReport.SecurityType = order.SecurityType;
        executionReport.SecurityExchange = order.SecurityExchange;
        executionReport.Currency = order.Currency;
        executionReport.Side = order.Side;
        executionReport.OrdType = order.OrdType;
        executionReport.TimeInForce = order.TimeInForce;
        executionReport.OrderQty = order.OrderQty;
        executionReport.Price = order.Price;
        executionReport.StopPx = order.StopPx;
        executionReport.LastPx = 0.0;
        executionReport.LastQty = 0.0;
        executionReport.AvgPx = 0.0;
        executionReport.CumQty = 0.0;
        executionReport.LeavesQty = order.OrderQty;
				executionReport.Text = "text";
        this.JPVPJSWclF(executionReport);
      }
    }

    
    public void SendOrderCancelRequest(OrderCancelRequest request)
    {
      if (this.hRwPnSQTDn == 0)
        this.E3jPCDq9jY(request);
      else
        Clock.AddReminder(new ReminderEventHandler(this.t99PErAC3Y), Clock.Now.AddMilliseconds((double) this.hRwPnSQTDn), (object) request);
    }

    
    public void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
    {
      if (this.hRwPnSQTDn == 0)
        this.M9IPlabLYo(request);
      else
        Clock.AddReminder(new ReminderEventHandler(this.gFqPLKYI6J), Clock.Now.AddMilliseconds((double) this.hRwPnSQTDn), (object) request);
    }

    
    public void SendOrderStatusRequest(OrderStatusRequest request)
    {
      throw new NotImplementedException();
    }

    
    private void MxtPRD9hCH([In] ReminderEventArgs obj0)
    {
      this.lCXP6mCfhb(obj0.Data as NewOrderSingle);
    }

    
    private void t99PErAC3Y([In] ReminderEventArgs obj0)
    {
      this.E3jPCDq9jY(obj0.Data as OrderCancelRequest);
    }

    
    private void gFqPLKYI6J([In] ReminderEventArgs obj0)
    {
      this.M9IPlabLYo(obj0.Data as OrderCancelReplaceRequest);
    }

    
    private void lCXP6mCfhb([In] NewOrderSingle obj0)
    {
      SingleOrder singleOrder = obj0 as SingleOrder;
      if (singleOrder.IsFilled || singleOrder.IsCancelled)
        return;
      if (obj0.OrderQty > 0.0)
      {
        ExecutionReport executionReport = new ExecutionReport();
        executionReport.TransactTime = Clock.Now;
        executionReport.ClOrdID = obj0.ClOrdID;
        executionReport.ExecType = ExecType.New;
        executionReport.OrdStatus = OrdStatus.New;
        executionReport.Symbol = obj0.Symbol;
        executionReport.OrdType = obj0.OrdType;
        executionReport.Side = obj0.Side;
        executionReport.Price = obj0.Price;
        executionReport.StopPx = obj0.StopPx;
        executionReport.TrailingAmt = obj0.TrailingAmt;
        executionReport.OrderQty = obj0.OrderQty;
        executionReport.CumQty = 0.0;
        executionReport.LeavesQty = obj0.OrderQty;
        executionReport.Currency = obj0.Currency;
        executionReport.Text = obj0.Text;
        this.JPVPJSWclF(executionReport);
//        zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = new zo21q6cy3fImtUHATQ(this, (FIXNewOrderSingle) obj0);
      }
      else
      {
        ExecutionReport executionReport = new ExecutionReport();
        executionReport.TransactTime = Clock.Now;
        executionReport.ClOrdID = obj0.ClOrdID;
        executionReport.ExecType = ExecType.Rejected;
        executionReport.OrdStatus = OrdStatus.Rejected;
        executionReport.Symbol = obj0.Symbol;
        executionReport.OrdType = obj0.OrdType;
        executionReport.Side = obj0.Side;
        executionReport.Price = obj0.Price;
        executionReport.StopPx = obj0.StopPx;
        executionReport.TrailingAmt = obj0.TrailingAmt;
        executionReport.OrderQty = obj0.OrderQty;
        executionReport.CumQty = 0.0;
        executionReport.LeavesQty = obj0.OrderQty;
        executionReport.Currency = obj0.Currency;
        executionReport.Text = obj0.Text;
        this.JPVPJSWclF(executionReport);
      }
    }

    
    private void E3jPCDq9jY([In] OrderCancelRequest obj0)
    {
//      zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = this.MyIPdEI7fi[(object) obj0.OrigClOrdID] as zo21q6cy3fImtUHATQ;
//      if (zo21q6cy3fImtUhatq == null)
//        return;
//      zo21q6cy3fImtUhatq.XNWFfvowtr();
    }

    
    private void M9IPlabLYo([In] OrderCancelReplaceRequest obj0)
    {
//      zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = this.MyIPdEI7fi[(object) obj0.OrigClOrdID] as zo21q6cy3fImtUHATQ;
//      if (zo21q6cy3fImtUhatq == null)
//        return;
//      if (obj0.OrderQty > 0.0)
//      {
//        zo21q6cy3fImtUhatq.CfcFBQBLXe((FIXOrderCancelReplaceRequest) obj0);
//      }
//      else
//      {
//        OrderCancelReject orderCancelReject = new OrderCancelReject();
//        orderCancelReject.OrigClOrdID = obj0.OrigClOrdID;
//        orderCancelReject.ClOrdID = obj0.ClOrdID;
//        orderCancelReject.CxlRejResponseTo = CxlRejResponseTo.CancelReplaceRequest;
//        orderCancelReject.CxlRejReason = CxlRejReason.BrokerOption;
//        orderCancelReject.Text = v6F3C32VVUpp2OYb5n.VVyFVqM4b6(4808);
//        orderCancelReject.OrdStatus = zo21q6cy3fImtUhatq.x6qFCwTWN2().OrdStatus;
//        orderCancelReject.TransactTime = Clock.Now;
//        this.FxSP7oxcnT(orderCancelReject);
//      }
    }

    
    public BrokerInfo GetBrokerInfo()
    {
      return new BrokerInfo();
    }

    
    public void RegisterOrder(NewOrderSingle order)
    {
    }

    
    internal void JPVPJSWclF([In] ExecutionReport obj0)
    {
//      if (this.ulMP1Y8D5y == null)
//        return;
//      this.ulMP1Y8D5y((object) this, new ExecutionReportEventArgs(obj0));
    }

    
    internal void FxSP7oxcnT([In] OrderCancelReject obj0)
    {
//      if (this.pfIPbeRjSr == null)
//        return;
//      this.pfIPbeRjSr((object) this, new OrderCancelRejectEventArgs(obj0));
    }

    
    public override string ToString()
    {
      return this.Name;
    }
  }
}
