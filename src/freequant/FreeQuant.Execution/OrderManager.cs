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
		private static bool Initialized;
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

		public static bool RemoveDoneOrders { get; set; }

		public static bool EnablePartialTransactions { get; set; }

		public static OrderListTable Orders
		{
			get
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

		static OrderManager()
		{
			OrderManager.Initialized = false;
			OrderManager.a8ycqU2Fn = 0;
			OrderManager.orders = new OrderListTable();
			OrderManager.server = new OrderDbServer();
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
			if (OrderManager.Initialized)
				return;
			ProviderManager.ExecutionReport += new ExecutionReportEventHandler(OrderManager.u4SCsblPj);
			ProviderManager.OrderCancelReject += new OrderCancelRejectEventHandler(OrderManager.EmitOrderCancelReject);
			ProviderManager.Error += new ProviderErrorEventHandler(OrderManager.EmitError);
			ProviderManager.Added += new ProviderEventHandler(OrderManager.nhwqZAwVD);
			Type connectionType = null;
			string connectionString = string.Empty;
			switch (Framework.Storage.ServerType)
			{
				case DbServerType.MS_ACCESS:
					connectionType = Type.GetType("");
					connectionString = string.Format("", (object)Framework.Installation.DataDir.FullName);
					break;
				case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
					connectionType = Type.GetType("");
					connectionString = string.Format("", (object)Framework.Installation.DataDir.FullName);
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
					singleOrder.Provider.RegisterOrder((NewOrderSingle)singleOrder);
			}
			OrderManager.RemoveDoneOrders = false;
			OrderManager.EnablePartialTransactions = false;
			OrderManager.Initialized = true;
		}

		internal static string Xgea6ywFN()
		{
			lock (typeof (OrderManager))
			{
				string local_0 = DateTime.Now.ToString() + OrderManager.a8ycqU2Fn;
				++OrderManager.a8ycqU2Fn;
				return local_0;
			}
		}

		internal static void GM96fGxEM(SingleOrder order)
		{
      if (order.Provider == null)
				throw new ApplicationException("null");
			if (order.Persistent)
				OrderManager.server.AddOrder(order);
			OrderManager.orders.Add(order);
			OrderManager.JEbFt6tfX(order);
			if (order.OCAGroup != "" && (int)order.Provider.Id != 4 && OrderManager.oca.Contains((object)order.OCAGroup))
			{
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = DateTime.Now;
				report.ClOrdID = order.ClOrdID;
				report.OrigClOrdID = order.ClOrdID;
				report.ExecType = ExecType.Rejected;
				report.OrdStatus = OrdStatus.Rejected;
				report.Symbol = order.Symbol;
				report.Side = order.Side;
				report.OrdType = order.OrdType;
				report.Currency = order.Currency;
				report.Text = "" + order.OCAGroup;
				OrderManager.ExecutionReport(null, new ExecutionReportEventArgs(report));
			}
			else
				order.Provider.SendNewOrderSingle((NewOrderSingle)order);
		}

		internal static void mgxNNoGq5(SingleOrder order)
		{
      if (order.Provider == null)
				throw new ApplicationException("");
			OrderCancelRequest request = new OrderCancelRequest();
			request.OrigClOrdID = order.ClOrdID;
			request.ClOrdID = OrderManager.Xgea6ywFN();
			request.Side = order.Side;
			request.TransactTime = Clock.Now;
			request.Symbol = order.Symbol;
			request.SecurityType = order.SecurityType;
			request.SecurityID = order.SecurityID;
			request.SecurityExchange = order.SecurityExchange;
			if (order.ContainsField(37))
				request.OrderID = order.OrderID;
			request.Account = order.Account;
			request.OrderQty = order.OrderQty;
			request.SetStringValue(109, order.GetStringValue(109));
			order.Provider.SendOrderCancelRequest(request);
		}

		internal static void MlPSr0K75(SingleOrder order)
		{
      if (order.Provider == null)
				throw new ApplicationException("null");
			OrderCancelReplaceRequest request = new OrderCancelReplaceRequest();
			request.ClOrdID = OrderManager.Xgea6ywFN();
			request.OrigClOrdID = order.ClOrdID;
			if (order.ContainsField(37))
				request.OrderID = order.OrderID;
			request.Side = order.Side;
			request.OrdType = !order.ReplaceOrder.ContainsField(40) ? order.OrdType : order.ReplaceOrder.OrdType;
			request.TimeInForce = !order.ReplaceOrder.ContainsField(59) ? order.TimeInForce : order.ReplaceOrder.TimeInForce;
			if (order.ReplaceOrder.ContainsField(126))
				request.ExpireTime = order.ReplaceOrder.ExpireTime;
			if (order.ReplaceOrder.ContainsField(44))
				request.Price = order.ReplaceOrder.Price;
			else
				request.Price = order.Price;
			if (order.ReplaceOrder.ContainsField(99))
				request.StopPx = order.ReplaceOrder.StopPx;
			else
				request.StopPx = order.StopPx;
			if (order.ReplaceOrder.ContainsField(10701))
				request.TrailingAmt = order.ReplaceOrder.TrailingAmt;
			else
				request.TrailingAmt = order.TrailingAmt;
			if (order.ReplaceOrder.ContainsField(38))
				request.OrderQty = order.ReplaceOrder.OrderQty;
			else
				request.OrderQty = order.OrderQty;
			request.TransactTime = Clock.Now;
			request.Account = order.Account;
			request.HandlInst = order.HandlInst;
			request.Symbol = order.Symbol;
			request.SecurityType = order.SecurityType;
			request.SecurityExchange = order.SecurityExchange;
			request.SecurityID = order.SecurityID;
			request.Currency = order.Currency;
			request.SetStringValue(109, order.GetStringValue(109));
			order.Provider.SendOrderCancelReplaceRequest(request);
		}

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
						OrderManager.server.Remove((IOrder)order);
				}
				else
					++index;
			}
//      if (count == OrderManager.orders.Count || OrderManager.sjIEOdweJO == null)
//        return;
//      OrderManager.sjIEOdweJO((object) typeof (OrderManager), EventArgs.Empty);
		}

		public static OrderList GetOCAGroup(string name)
		{
			OrderList orderList = new OrderList();
			if (name != "")
			{
				foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.Orders.All)
				{
					if (!singleOrder.IsDone && singleOrder.OCAGroup == name)
						orderList.Add((IOrder)singleOrder);
				}
			}
			return orderList;
		}

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
				throw new ApplicationException(executionReport.ExecType + executionReport.ClOrdID + executionReport.OrigClOrdID);
			}
			else
			{
//        if (order.Provider == null)
//          throw new ApplicationException(p9eligYgcNHo8cieFV.RdvEpVlLR7(4128));
				OrdStatus ordStatus = order.OrdStatus;
				order.mlSRyS5Q1(executionReport);
				if (order.Persistent)
					OrderManager.server.AddReport((IOrder)order, (FIXExecutionReport)executionReport);
//        if (OrderManager.x5HEE1y1EF != null)
//          OrderManager.x5HEE1y1EF(obj0, new ExecutionReportEventArgs((NewOrderSingle) order, executionReport));
				if (ordStatus != order.OrdStatus)
				{
					OrderManager.orders.Update(order);
					order.aPUkn4BIl();
					OrderManager.qrwh0GePg(order);
				}
				if (OrderManager.EnablePartialTransactions && (executionReport.ExecType == ExecType.Fill || executionReport.ExecType == ExecType.PartialFill || executionReport.ExecType == ExecType.Trade))
					OrderManager.nf3XP7Xf3(order, executionReport.TransactTime, executionReport.LastPx, executionReport.LastQty);
				// ISSUE: reference to a compiler-generated method
				if (ordStatus != order.OrdStatus && order.IsDone)
				{
					if (!OrderManager.EnablePartialTransactions)
						OrderManager.nf3XP7Xf3(order, executionReport.TransactTime, executionReport.AvgPx, executionReport.CumQty);
					OrderManager.YUArMfFNj(order);
				}
				if (!(order.OCAGroup != "") || (int)order.Provider.Id == 4 || order.OrdStatus != OrdStatus.Filled && order.OrdStatus != OrdStatus.Cancelled || OrderManager.oca.Contains((object)order.OCAGroup))
					return;
				OrderManager.oca.Add((object)order.OCAGroup, (object)order.OCAGroup);
				foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.GetOCAGroup(order.OCAGroup))
				{
					if (singleOrder != order)
						singleOrder.Cancel();
				}
			}
		}

		private static void EmitOrderCancelReject(object sender, OrderCancelRejectEventArgs e)
		{
			OrderCancelReject orderCancelReject = e.OrderCancelReject;
			SingleOrder order = OrderManager.orders.All[orderCancelReject.OrigClOrdID] as SingleOrder;
			if (orderCancelReject.OrdStatus == OrdStatus.Undefined)
			{
				orderCancelReject.OrdStatus = OrdStatus.New;
				ArrayList arrayList = new ArrayList((ICollection)order.Reports);
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
	      if (OrderManager.OrderCancelReject != null)
	        	OrderManager.OrderCancelReject(sender, new OrderCancelRejectEventArgs(order, orderCancelReject));
			if (order.IsDone)
			{
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

		private static void YUArMfFNj([In] SingleOrder obj0)
		{
			// ISSUE: reference to a compiler-generated method
//      obj0.KbABb8YWe(true);
			OrderManager.v6A0O8GUY(obj0);
			if (!OrderManager.RemoveDoneOrders)
				return;
			OrderManager.orders.Remove(obj0);
			OrderManager.nONISjMtt(obj0);
		}

		private static void EmitError(ProviderErrorEventArgs e)
		{
			if (OrderManager.Error == null)
	        return;
			OrderManager.Error(e);
		}

		private static void nhwqZAwVD([In] ProviderEventArgs obj0)
		{
			if (!(obj0.Provider is IExecutionProvider))
				return;
			IExecutionProvider executionProvider = (IExecutionProvider)obj0.Provider;
			foreach (SingleOrder singleOrder in (FIXGroupList) OrderManager.orders.All)
			{
				if (singleOrder.Provider == executionProvider && !singleOrder.IsDone)
					executionProvider.RegisterOrder((NewOrderSingle)singleOrder);
			}
		}

		private static void JEbFt6tfX([In] SingleOrder obj0)
		{
//      if (OrderManager.arFEeX1wWI == null)
//        return;
//      OrderManager.arFEeX1wWI(new OrderEventArgs(obj0));
		}

		private static void qrwh0GePg([In] SingleOrder obj0)
		{
//      if (OrderManager.UISEmPsva8 == null)
//        return;
//      OrderManager.UISEmPsva8(new OrderEventArgs(obj0));
		}

		private static void v6A0O8GUY([In] SingleOrder obj0)
		{
//      if (OrderManager.v3uETTndAf == null)
//        return;
//      OrderManager.v3uETTndAf(new OrderEventArgs(obj0));
		}

		private static void nONISjMtt([In] SingleOrder obj0)
		{
//      if (OrderManager.JhfEBj1mlh == null)
//        return;
//      OrderManager.JhfEBj1mlh(new OrderEventArgs(obj0));
		}

		public class SellSideService
		{
			private SellSideOrderList a44Etx1oTg;
			private int pFJEnmStap;

			public SellSideOrderList Orders
			{
				get
				{
					return this.a44Etx1oTg;
				}
			}

			public event OrderEventHandler NewOrder;
			public event ExecutionReportEventHandler ExecutionReport;
			public event EventHandler OrderListUpdated;

			internal SellSideService()
			{
				this.a44Etx1oTg = new SellSideOrderList();
				this.pFJEnmStap = 1;
				ServiceManager.NewOrderSingle += new NewOrderSingleEventHandler(this.pTiEUEnvcs);
			}

			public string GetNextOrderID()
			{
				return string.Format("", DateTime.Now, this.pFJEnmStap++);
			}

			public void SendExecutionReport(IExecutionService service, ExecutionReport report)
			{
				this.a44Etx1oTg[report.OrderID].mlSRyS5Q1(report);
				service.Send((FIXExecutionReport)report);
				this.aNsEVckbDs(report);
			}

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

			internal void ksHExX7sqh()
			{
				this.a44Etx1oTg.HKElmrgRF();
			}

			private void pTiEUEnvcs([In] object obj0, [In] NewOrderSingleEventArgs obj1)
			{
				SingleOrder singleOrder = obj1.Order as SingleOrder;
				if (singleOrder.OrderID == string.Empty)
					singleOrder.OrderID = this.GetNextOrderID();
				this.a44Etx1oTg.YKsdCTvel(singleOrder);
				this.KHCE7c3kVy(singleOrder);
			}

			private void KHCE7c3kVy([In] SingleOrder obj0)
			{
//        if (this.Gt4EWZSr2q == null)
//          return;
//        this.Gt4EWZSr2q(new OrderEventArgs(obj0));
			}

			private void aNsEVckbDs(ExecutionReport obj0)
			{
//        if (this.fFHEsC37IP == null)
//          return;
//        this.fFHEsC37IP((object) this, new ExecutionReportEventArgs(obj0));
			}

			private void lXpEvXnu7N()
			{
//        if (this.GbiE1hC6fD == null)
//          return;
//        this.GbiE1hC6fD((object) typeof (OrderManager.SellSideService), EventArgs.Empty);
			}
		}
	}
}
