using LI7wYoxjcQSGYmaiNa;
using RZ1j9O1DCcsDf19ge6;
using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Services;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Execution
{
  public class OrderManager
  {
    private static bool c55wGJraV;
    private static int a8ycqU2Fn;
    private static OrderListTable orders;
    private static IOrderServer server;
    private static Hashtable oca;
    private static OrderManager.SellSideService n3PEDYSLi1;

    public static IOrderServer Server
    {
      get
      {
				return OrderManager.server; 
      }
    }

    public static Hashtable OCA
    {
     get
      {
				return OrderManager.oca;  
      }
    }

		public static bool RemoveDoneOrders {   get;   set; }

		public static bool EnablePartialTransactions {  get;   set; }

    public static OrderListTable Orders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return OrderManager.orders; 
      }
    }

    public static OrderManager.SellSideService SellSide
    {
        get
      {
        return OrderManager.n3PEDYSLi1;
      }
    }

    public static event ExecutionReportEventHandler ExecutionReport;

    public static event OrderCancelRejectEventHandler OrderCancelReject;

    public static event OrderEventHandler OrderStatusChanged;

    public static event ProviderErrorEventHandler Error;

    public static event OrderEventHandler NewOrder;

    public static event OrderEventHandler OrderDone;

    public static event OrderEventHandler OrderRemoved;

    public static event EventHandler OrderListUpdated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OrderManager()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      OrderManager.c55wGJraV = false;
      OrderManager.a8ycqU2Fn = 0;
      OrderManager.orders = new OrderListTable();
      OrderManager.server = (IOrderServer) new OrderDbServer();
      OrderManager.oca = new Hashtable();
      OrderManager.n3PEDYSLi1 = new OrderManager.SellSideService();
      OrderManager.Init();
    }


    public static void Reset()
    {
      OrderManager.orders.Clear();
      OrderManager.oca.Clear();
      OrderManager.n3PEDYSLi1.ksHExX7sqh();
    }

    public static void Init()
    {
      if (OrderManager.c55wGJraV)
        return;
      ProviderManager.ExecutionReport += new ExecutionReportEventHandler(OrderManager.u4SCsblPj);
      ProviderManager.OrderCancelReject += new OrderCancelRejectEventHandler(OrderManager.Y5Y2jeOHy);
      ProviderManager.Error += new ProviderErrorEventHandler(OrderManager.wH4Pa5uQx);
      ProviderManager.Added += new ProviderEventHandler(OrderManager.nhwqZAwVD);
      Type connectionType = (Type) null;
      string connectionString = string.Empty;
      switch (Framework.Storage.ServerType)
      {
        case DbServerType.MS_ACCESS:
          connectionType = Type.GetType(p9eligYgcNHo8cieFV.RdvEpVlLR7(2698));
          connectionString = string.Format(p9eligYgcNHo8cieFV.RdvEpVlLR7(2928), (object) Framework.Installation.DataDir.FullName);
          break;
        case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
          connectionType = Type.GetType(p9eligYgcNHo8cieFV.RdvEpVlLR7(3056));
          connectionString = string.Format(p9eligYgcNHo8cieFV.RdvEpVlLR7(3322), (object) Framework.Installation.DataDir.FullName);
          break;
      }
      OrderManager.server.Open(connectionType, connectionString);
      foreach (IOrder order in (FIXGroupList) OrderManager.server.Load())
      {
        if (order.Instrument != null && order.Provider != null && order.Portfolio != null)
          OrderManager.orders.Add(order as SingleOrder);
      }
      foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.orders.All)
      {
        if (!singleOrder.IsDone)
          singleOrder.Provider.RegisterOrder((NewOrderSingle) singleOrder);
      }
      OrderManager.RemoveDoneOrders = false;
      OrderManager.EnablePartialTransactions = false;
      OrderManager.c55wGJraV = true;
    }

    internal static string Xgea6ywFN()
    {
      lock (typeof (OrderManager))
      {
        string local_0 = Clock.Now.ToString(p9eligYgcNHo8cieFV.RdvEpVlLR7(3430)) + (object) OrderManager.a8ycqU2Fn;
        ++OrderManager.a8ycqU2Fn;
        return local_0;
      }
    }

    internal static void GM96fGxEM([In] SingleOrder obj0)
    {
      if (obj0.Provider == null)
        throw new ApplicationException(p9eligYgcNHo8cieFV.RdvEpVlLR7(3526));
      if (obj0.Persistent)
        OrderManager.server.AddOrder((IOrder) obj0);
      OrderManager.orders.Add(obj0);
      OrderManager.JEbFt6tfX(obj0);
      if (obj0.OCAGroup != "" && (int) obj0.Provider.Id != 4 && OrderManager.oca.Contains((object) obj0.OCAGroup))
      {
        ExecutionReport report = new ExecutionReport();
        report.TransactTime = Clock.Now;
        report.ClOrdID = obj0.ClOrdID;
        report.OrigClOrdID = obj0.ClOrdID;
        report.ExecType = ExecType.Rejected;
        report.OrdStatus = OrdStatus.Rejected;
        report.Symbol = obj0.Symbol;
        report.Side = obj0.Side;
        report.OrdType = obj0.OrdType;
        report.Currency = obj0.Currency;
        report.Text = p9eligYgcNHo8cieFV.RdvEpVlLR7(3460) + obj0.OCAGroup + p9eligYgcNHo8cieFV.RdvEpVlLR7(3484);
        OrderManager.u4SCsblPj((object) null, new ExecutionReportEventArgs(report));
      }
      else
        obj0.Provider.SendNewOrderSingle((NewOrderSingle) obj0);
    }

    internal static void mgxNNoGq5([In] SingleOrder obj0)
    {
      if (obj0.Provider == null)
        throw new ApplicationException(p9eligYgcNHo8cieFV.RdvEpVlLR7(3674));
      OrderCancelRequest request = new OrderCancelRequest();
      request.OrigClOrdID = obj0.ClOrdID;
      request.ClOrdID = OrderManager.Xgea6ywFN();
      request.Side = obj0.Side;
      request.TransactTime = Clock.Now;
      request.Symbol = obj0.Symbol;
      request.SecurityType = obj0.SecurityType;
      request.SecurityID = obj0.SecurityID;
      request.SecurityExchange = obj0.SecurityExchange;
      if (obj0.ContainsField(37))
        request.OrderID = obj0.OrderID;
      request.Account = obj0.Account;
      request.OrderQty = obj0.OrderQty;
      request.SetStringValue(109, obj0.GetStringValue(109));
      obj0.Provider.SendOrderCancelRequest(request);
    }

    internal static void MlPSr0K75([In] SingleOrder obj0)
    {
      if (obj0.Provider == null)
        throw new ApplicationException(p9eligYgcNHo8cieFV.RdvEpVlLR7(3826));
      OrderCancelReplaceRequest request = new OrderCancelReplaceRequest();
      request.ClOrdID = OrderManager.Xgea6ywFN();
      request.OrigClOrdID = obj0.ClOrdID;
      if (obj0.ContainsField(37))
        request.OrderID = obj0.OrderID;
      request.Side = obj0.Side;
      request.OrdType = !obj0.ReplaceOrder.ContainsField(40) ? obj0.OrdType : obj0.ReplaceOrder.OrdType;
      request.TimeInForce = !obj0.ReplaceOrder.ContainsField(59) ? obj0.TimeInForce : obj0.ReplaceOrder.TimeInForce;
      if (obj0.ReplaceOrder.ContainsField(126))
        request.ExpireTime = obj0.ReplaceOrder.ExpireTime;
      if (obj0.ReplaceOrder.ContainsField(44))
        request.Price = obj0.ReplaceOrder.Price;
      else
        request.Price = obj0.Price;
      if (obj0.ReplaceOrder.ContainsField(99))
        request.StopPx = obj0.ReplaceOrder.StopPx;
      else
        request.StopPx = obj0.StopPx;
      if (obj0.ReplaceOrder.ContainsField(10701))
        request.TrailingAmt = obj0.ReplaceOrder.TrailingAmt;
      else
        request.TrailingAmt = obj0.TrailingAmt;
      if (obj0.ReplaceOrder.ContainsField(38))
        request.OrderQty = obj0.ReplaceOrder.OrderQty;
      else
        request.OrderQty = obj0.OrderQty;
      request.TransactTime = Clock.Now;
      request.Account = obj0.Account;
      request.HandlInst = obj0.HandlInst;
      request.Symbol = obj0.Symbol;
      request.SecurityType = obj0.SecurityType;
      request.SecurityExchange = obj0.SecurityExchange;
      request.SecurityID = obj0.SecurityID;
      request.Currency = obj0.Currency;
      request.SetStringValue(109, obj0.GetStringValue(109));
      obj0.Provider.SendOrderCancelReplaceRequest(request);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveOrders(int tag, object value)
    {
      int count = OrderManager.orders.Count;
      int index = 0;
      while (index < OrderManager.orders.Count)
      {
        SingleOrder order = OrderManager.orders.All[index] as SingleOrder;
        object obj = order.GetValue(tag);
        if (obj != null && obj.ToString() == value.ToString())
        {
          if (order.OrdStatus != OrdStatus.Cancelled && order.OrdStatus != OrdStatus.PendingCancel && order.OrdStatus != OrdStatus.Filled)
            order.Cancel();
          OrderManager.orders.Remove(order);
          if (order.Persistent)
            OrderManager.server.Remove((IOrder) order);
        }
        else
          ++index;
      }
      if (count == OrderManager.orders.Count || OrderManager.sjIEOdweJO == null)
        return;
      OrderManager.sjIEOdweJO((object) typeof (OrderManager), EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OrderList GetOCAGroup(string name)
    {
      OrderList orderList = new OrderList();
      if (name != "")
      {
        foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.Orders.All)
        {
          if (!singleOrder.IsDone && singleOrder.OCAGroup == name)
            orderList.Add((IOrder) singleOrder);
        }
      }
      return orderList;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void u4SCsblPj([In] object obj0, [In] ExecutionReportEventArgs obj1)
    {
      ExecutionReport executionReport = obj1.ExecutionReport;
      SingleOrder order;
      if (executionReport.ExecType == ExecType.PendingCancel || executionReport.ExecType == ExecType.Cancelled || (executionReport.ExecType == ExecType.PendingReplace || executionReport.ExecType == ExecType.Replace))
      {
        order = OrderManager.orders.All[executionReport.OrigClOrdID] as SingleOrder;
        if (executionReport.ExecType == ExecType.Replace)
        {
          OrderManager.orders.Remove(order);
          order.ClOrdID = executionReport.ClOrdID;
          order.OrdType = executionReport.OrdType;
          order.OrderQty = executionReport.OrderQty;
          if (executionReport.ContainsField(44))
            order.Price = executionReport.Price;
          if (executionReport.ContainsField(99))
            order.StopPx = executionReport.StopPx;
          if (executionReport.ContainsField(10701))
            order.TrailingAmt = executionReport.TrailingAmt;
          if (executionReport.ContainsField(59))
            order.TimeInForce = executionReport.TimeInForce;
          if (executionReport.ContainsField(126))
            order.ExpireTime = executionReport.ExpireTime;
          OrderManager.orders.Add(order);
        }
      }
      else
        order = OrderManager.orders.All[executionReport.ClOrdID] as SingleOrder;
      if (order == null)
      {
        throw new ApplicationException(p9eligYgcNHo8cieFV.RdvEpVlLR7(3978) + ((object) executionReport.ExecType).ToString() + p9eligYgcNHo8cieFV.RdvEpVlLR7(4068) + executionReport.ClOrdID + p9eligYgcNHo8cieFV.RdvEpVlLR7(4094) + executionReport.OrigClOrdID);
      }
      else
      {
        if (order.Provider == null)
          throw new ApplicationException(p9eligYgcNHo8cieFV.RdvEpVlLR7(4128));
        OrdStatus ordStatus = order.OrdStatus;
        order.mlSRyS5Q1(executionReport);
        if (order.Persistent)
          OrderManager.server.AddReport((IOrder) order, (FIXExecutionReport) executionReport);
        if (OrderManager.x5HEE1y1EF != null)
          OrderManager.x5HEE1y1EF(obj0, new ExecutionReportEventArgs((NewOrderSingle) order, executionReport));
        if (ordStatus != order.OrdStatus)
        {
          OrderManager.orders.Update(order);
          order.aPUkn4BIl();
          OrderManager.qrwh0GePg(order);
        }
        if (OrderManager.EnablePartialTransactions && (executionReport.ExecType == ExecType.Fill || executionReport.ExecType == ExecType.PartialFill || executionReport.ExecType == ExecType.Trade))
          OrderManager.nf3XP7Xf3(order, executionReport.TransactTime, executionReport.LastPx, executionReport.LastQty);
        // ISSUE: reference to a compiler-generated method
        if (ordStatus != order.OrdStatus && order.IsDone && !order.zNNTifyph())
        {
          if (!OrderManager.EnablePartialTransactions)
            OrderManager.nf3XP7Xf3(order, executionReport.TransactTime, executionReport.AvgPx, executionReport.CumQty);
          OrderManager.YUArMfFNj(order);
        }
        if (!(order.OCAGroup != "") || (int) order.Provider.Id == 4 || order.OrdStatus != OrdStatus.Filled && order.OrdStatus != OrdStatus.Cancelled || OrderManager.oca.Contains((object) order.OCAGroup))
          return;
        OrderManager.oca.Add((object) order.OCAGroup, (object) order.OCAGroup);
        foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.GetOCAGroup(order.OCAGroup))
        {
          if (singleOrder != order)
            singleOrder.Cancel();
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Y5Y2jeOHy([In] object obj0, [In] OrderCancelRejectEventArgs obj1)
    {
      OrderCancelReject orderCancelReject = obj1.OrderCancelReject;
      SingleOrder order = OrderManager.orders.All[orderCancelReject.OrigClOrdID] as SingleOrder;
      if (orderCancelReject.OrdStatus == OrdStatus.Undefined)
      {
        orderCancelReject.OrdStatus = OrdStatus.New;
        ArrayList arrayList = new ArrayList((ICollection) order.Reports);
        arrayList.Reverse();
        foreach (ExecutionReport executionReport in arrayList)
        {
          switch (executionReport.OrdStatus)
          {
            case OrdStatus.PendingCancel:
            case OrdStatus.PendingNew:
            case OrdStatus.PendingReplace:
              continue;
            default:
              orderCancelReject.OrdStatus = executionReport.OrdStatus;
              goto label_10;
          }
        }
      }
label_10:
      OrdStatus ordStatus = order.OrdStatus;
      order.hHemwyJmI(orderCancelReject);
      if (OrderManager.s4oERsAytu != null)
        OrderManager.s4oERsAytu(obj0, new OrderCancelRejectEventArgs((NewOrderSingle) order, orderCancelReject));
      if (order.IsDone)
      {
        // ISSUE: reference to a compiler-generated method
        if (order.zNNTifyph())
          return;
        if (!OrderManager.EnablePartialTransactions)
          OrderManager.nf3XP7Xf3(order, orderCancelReject.TransactTime, order.AvgPx, order.CumQty);
        OrderManager.YUArMfFNj(order);
      }
      else
      {
        if (ordStatus == order.OrdStatus)
          return;
        OrderManager.orders.Update(order);
        order.aPUkn4BIl();
        OrderManager.qrwh0GePg(order);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void nf3XP7Xf3([In] SingleOrder obj0, [In] DateTime obj1, [In] double obj2, [In] double obj3)
    {
      if (obj0.LastQty <= 0.0 || obj0.Portfolio == null)
        return;
      Transaction transaction = new Transaction();
      transaction.DateTime = obj1;
      transaction.ClOrdID = obj0.ClOrdID;
      transaction.Instrument = obj0.Instrument;
      transaction.Side = obj0.Side;
      transaction.Price = obj2;
      transaction.Qty = obj3;
      transaction.Strategy = obj0.Strategy;
      transaction.Text = obj0.Text;
      FreeQuant.Instruments.Currency currency = (CurrencyManager.Currencies[obj0.Currency] ?? CurrencyManager.Currencies[obj0.Instrument.Currency]) ?? CurrencyManager.DefaultCurrency;
      transaction.Currency = currency;
      transaction.TransactionCost.Set(CommType.Absolute, obj0.Commission);
      obj0.Portfolio.Add(transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void YUArMfFNj([In] SingleOrder obj0)
    {
      // ISSUE: reference to a compiler-generated method
      obj0.KbABb8YWe(true);
      OrderManager.v6A0O8GUY(obj0);
      if (!OrderManager.RemoveDoneOrders)
        return;
      OrderManager.orders.Remove(obj0);
      OrderManager.nONISjMtt(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void wH4Pa5uQx([In] ProviderErrorEventArgs obj0)
    {
      if (OrderManager.mLMEko505A == null)
        return;
      OrderManager.mLMEko505A(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void nhwqZAwVD([In] ProviderEventArgs obj0)
    {
      if (!(obj0.Provider is IExecutionProvider))
        return;
      IExecutionProvider executionProvider = (IExecutionProvider) obj0.Provider;
      foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.orders.All)
      {
        if (singleOrder.Provider == executionProvider && !singleOrder.IsDone)
          executionProvider.RegisterOrder((NewOrderSingle) singleOrder);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void JEbFt6tfX([In] SingleOrder obj0)
    {
      if (OrderManager.arFEeX1wWI == null)
        return;
      OrderManager.arFEeX1wWI(new OrderEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void qrwh0GePg([In] SingleOrder obj0)
    {
      if (OrderManager.UISEmPsva8 == null)
        return;
      OrderManager.UISEmPsva8(new OrderEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void v6A0O8GUY([In] SingleOrder obj0)
    {
      if (OrderManager.v3uETTndAf == null)
        return;
      OrderManager.v3uETTndAf(new OrderEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void nONISjMtt([In] SingleOrder obj0)
    {
      if (OrderManager.JhfEBj1mlh == null)
        return;
      OrderManager.JhfEBj1mlh(new OrderEventArgs(obj0));
    }

    public class SellSideService
    {
      private SellSideOrderList a44Etx1oTg;
      private int pFJEnmStap;

      public SellSideOrderList Orders
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get
        {
          return this.a44Etx1oTg;
        }
      }

      public event OrderEventHandler NewOrder;

      public event ExecutionReportEventHandler ExecutionReport;

      public event EventHandler OrderListUpdated;

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal SellSideService()
      {
        NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.a44Etx1oTg = new SellSideOrderList();
        this.pFJEnmStap = 1;
        ServiceManager.NewOrderSingle += new NewOrderSingleEventHandler(this.pTiEUEnvcs);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetNextOrderID()
      {
        return string.Format(p9eligYgcNHo8cieFV.RdvEpVlLR7(4182), (object) DateTime.Now, (object) this.pFJEnmStap++);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SendExecutionReport(IExecutionService service, ExecutionReport report)
      {
        this.a44Etx1oTg[report.OrderID].mlSRyS5Q1(report);
        service.Send((FIXExecutionReport) report);
        this.aNsEVckbDs(report);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveOrders(int tag, object value)
      {
        int count = this.a44Etx1oTg.Count;
        int index = 0;
        while (index < this.a44Etx1oTg.Count)
        {
          SingleOrder singleOrder = this.a44Etx1oTg[index];
          if (singleOrder.ContainsField(tag))
          {
            object obj = singleOrder.GetValue(tag);
            if (obj != null && obj.ToString() == value.ToString())
            {
              this.a44Etx1oTg.rkS4wTRRF(index);
              continue;
            }
          }
          ++index;
        }
        if (count <= this.a44Etx1oTg.Count)
          return;
        this.lXpEvXnu7N();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal void ksHExX7sqh()
      {
        this.a44Etx1oTg.HKElmrgRF();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void pTiEUEnvcs([In] object obj0, [In] NewOrderSingleEventArgs obj1)
      {
        SingleOrder singleOrder = obj1.Order as SingleOrder;
        if (singleOrder.OrderID == string.Empty)
          singleOrder.OrderID = this.GetNextOrderID();
        this.a44Etx1oTg.YKsdCTvel(singleOrder);
        this.KHCE7c3kVy(singleOrder);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void KHCE7c3kVy([In] SingleOrder obj0)
      {
        if (this.Gt4EWZSr2q == null)
          return;
        this.Gt4EWZSr2q(new OrderEventArgs(obj0));
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void aNsEVckbDs([In] ExecutionReport obj0)
      {
        if (this.fFHEsC37IP == null)
          return;
        this.fFHEsC37IP((object) this, new ExecutionReportEventArgs(obj0));
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void lXpEvXnu7N()
      {
        if (this.GbiE1hC6fD == null)
          return;
        this.GbiE1hC6fD((object) typeof (OrderManager.SellSideService), EventArgs.Empty);
      }
    }
  }
}
