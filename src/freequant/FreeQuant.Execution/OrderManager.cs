using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Services;
using System;
using System.IO;
using System.Collections;

namespace FreeQuant.Execution
{
    public class OrderManager
    {
        private static bool Initialized;
        private static int orderId;
        private static OrderListTable orders;
        private static IOrderServer server;
        private static Hashtable oca;
        private static OrderManager.SellSideService sellSide;

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
                return OrderManager.sellSide;
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
            OrderManager.orderId = 0;
            OrderManager.orders = new OrderListTable();
            OrderManager.oca = new Hashtable();
            OrderManager.sellSide = new OrderManager.SellSideService();
            OrderManager.server = new OrderDbServer();
            OrderManager.Init();
        }

        public static void Reset()
        {
            OrderManager.orders.Clear();
            OrderManager.oca.Clear();
            OrderManager.sellSide.Clear();
        }

        public static void Init()
        {
            if (OrderManager.Initialized)
                return;
            ProviderManager.ExecutionReport += new ExecutionReportEventHandler(OrderManager.OnExecutionReport);
            ProviderManager.OrderCancelReject += new OrderCancelRejectEventHandler(OrderManager.OnOrderCancelReject);
            ProviderManager.Error += new ProviderErrorEventHandler(OrderManager.EmitError);
            ProviderManager.Added += new ProviderEventHandler(OrderManager.OnAdded);

            Type connectionType = null;
            string connectionString = string.Empty;
            switch (Framework.Storage.ServerType)
            {
                case DbServerType.SQLITE:
                    connectionType = Type.GetType("SQLiteConnection");
                    connectionString = string.Format("Data Source={0};Pooling=true;FailIfMissing=false;", Path.Combine(Framework.Installation.DataDir.FullName, "freequant.db"));
                    break;
                default:
                    throw new NotSupportedException("This db is not support yet.");
            }

            // FIXME:for test only
            OrderManager.server = new OrderFileServer();

            OrderManager.server.Open(connectionType, connectionString);
            foreach (IOrder order in OrderManager.server.Load())
            {
                if (order.Instrument != null && order.Provider != null && order.Portfolio != null)
                    OrderManager.orders.Add(order as SingleOrder);
            }
            foreach (SingleOrder singleOrder in OrderManager.orders.All)
            {
                if (!singleOrder.IsDone)
                    singleOrder.Provider.RegisterOrder(singleOrder);
            }
            OrderManager.RemoveDoneOrders = false;
            OrderManager.EnablePartialTransactions = false;
            OrderManager.Initialized = true;
        }

        internal static string GetOrdId()
        {
            lock (typeof(OrderManager))
            {
                string result = DateTime.Now.ToString() + OrderManager.orderId;
                ++OrderManager.orderId;
                return result;
            }
        }

        internal static void SendOrder(SingleOrder order)
        {
            if (order.Provider == null)
                throw new ApplicationException("order.Provider == null");
            if (order.Persistent)
                OrderManager.server.AddOrder(order);
            OrderManager.orders.Add(order);
            OrderManager.EmitNewOrder(order);
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

        internal static void CancelOrder(SingleOrder order)
        {
            if (order.Provider == null)
                throw new ApplicationException("Provider is null");
            OrderCancelRequest request = new OrderCancelRequest();
            request.OrigClOrdID = order.ClOrdID;
            request.ClOrdID = OrderManager.GetOrdId();
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

        internal static void ReplaceOrder(SingleOrder order)
        {
            if (order.Provider == null)
                throw new ApplicationException("null");
            OrderCancelReplaceRequest request = new OrderCancelReplaceRequest();
            request.ClOrdID = OrderManager.GetOrdId();
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
            if (count == OrderManager.orders.Count || OrderManager.OrderListUpdated == null)
                return;
            OrderManager.OrderListUpdated(typeof(OrderManager), EventArgs.Empty);
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

        private static void OnExecutionReport(object sender, ExecutionReportEventArgs e)
        {
            ExecutionReport executionReport = e.ExecutionReport;
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
                if (order.Provider == null)
                    throw new ApplicationException("provider is null");
                OrdStatus ordStatus = order.OrdStatus;
                order.EmitExecutionReport(executionReport);
                if (order.Persistent)
                    OrderManager.server.AddReport(order, executionReport);
                if (OrderManager.ExecutionReport != null)
                    OrderManager.ExecutionReport(sender, new ExecutionReportEventArgs((NewOrderSingle)order, executionReport));
                if (ordStatus != order.OrdStatus)
                {
                    OrderManager.orders.Update(order);
                    order.EmitStatusChanged();
                    OrderManager.EmitOrderStatusChanged(order);
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
                if (!(order.OCAGroup != "") || order.Provider.Id == 4 || order.OrdStatus != OrdStatus.Filled && order.OrdStatus != OrdStatus.Cancelled || OrderManager.oca.Contains((object)order.OCAGroup))
                    return;
                OrderManager.oca.Add(order.OCAGroup, order.OCAGroup);
                foreach (SingleOrder singleOrder in OrderManager.GetOCAGroup(order.OCAGroup))
                {
                    if (singleOrder != order)
                        singleOrder.Cancel();
                }
            }
        }

        private static void OnOrderCancelReject(object sender, OrderCancelRejectEventArgs e)
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
            order.EmitCancelReject(orderCancelReject);
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
                order.EmitStatusChanged();
                OrderManager.EmitOrderStatusChanged(order);
            }
        }

        private static void nf3XP7Xf3(SingleOrder obj0, DateTime obj1, double obj2, double obj3)
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

        private static void YUArMfFNj(SingleOrder order)
        {
            OrderManager.EmitOrderDone(order);
            if (!OrderManager.RemoveDoneOrders)
                return;
            OrderManager.orders.Remove(order);
            OrderManager.EmitOrderRemoved(order);
        }

        private static void EmitError(ProviderErrorEventArgs e)
        {
            if (OrderManager.Error != null)
            {
                OrderManager.Error(e);
            }
        }

        private static void OnAdded(ProviderEventArgs e)
        {
            if (!(e.Provider is IExecutionProvider))
                return;
            IExecutionProvider executionProvider = (IExecutionProvider)e.Provider;
            foreach (SingleOrder singleOrder in OrderManager.orders.All)
            {
                if (singleOrder.Provider == executionProvider && !singleOrder.IsDone)
                    executionProvider.RegisterOrder(singleOrder);
            }
        }

        private static void EmitNewOrder(SingleOrder order)
        {
            if (OrderManager.NewOrder != null)
                OrderManager.NewOrder(new OrderEventArgs(order));
        }

        private static void EmitOrderStatusChanged(SingleOrder order)
        {
            if (OrderManager.OrderStatusChanged == null)
                return;
            OrderManager.OrderStatusChanged(new OrderEventArgs(order));
        }

        private static void EmitOrderDone(SingleOrder order)
        {
            if (OrderManager.OrderDone != null)
                OrderManager.OrderDone(new OrderEventArgs(order));
        }

        private static void EmitOrderRemoved(SingleOrder order)
        {
            if (OrderManager.OrderRemoved != null)
                OrderManager.OrderRemoved(new OrderEventArgs(order));
        }

        public class SellSideService
        {
            private SellSideOrderList orders;
            private int counter;

            public SellSideOrderList Orders
            {
                get
                {
                    return this.orders; 
                }
            }

            public event OrderEventHandler NewOrder;
            public event ExecutionReportEventHandler ExecutionReport;
            public event EventHandler OrderListUpdated;

            internal SellSideService()
            {
                this.orders = new SellSideOrderList();
                this.counter = 1;
                ServiceManager.NewOrderSingle += new NewOrderSingleEventHandler(this.EmitNewOrderSingle);
            }

            public string GetNextOrderID()
            {
                return string.Format("{0}-{1}", DateTime.Now, this.counter++);
            }

            public void SendExecutionReport(IExecutionService service, ExecutionReport report)
            {
                this.orders[report.OrderID].EmitExecutionReport(report);
                service.Send((FIXExecutionReport)report);
                this.EmitExecutionReport(report);
            }

            public void RemoveOrders(int tag, object value)
            {
                int count = this.orders.Count;
                int index = 0;
                while (index < this.orders.Count)
                {
                    SingleOrder singleOrder = this.orders[index];
                    if (singleOrder.ContainsField(tag))
                    {
                        object obj = singleOrder.GetValue(tag);
                        if (obj != null && obj.ToString() == value.ToString())
                        {
                            this.orders.Remove(index);
                            continue;
                        }
                    }
                    ++index;
                }
                if (count <= this.orders.Count)
                    return;
                this.EmitOrderListUpdated();
            }

            internal void Clear()
            {
                this.orders.Clear();
            }

            private void EmitNewOrderSingle(object sender, NewOrderSingleEventArgs e)
            {
                SingleOrder singleOrder = e.Order as SingleOrder;
                if (singleOrder.OrderID == string.Empty)
                    singleOrder.OrderID = this.GetNextOrderID();
                this.orders.Add(singleOrder);
                this.EmitNewOrder(singleOrder);
            }

            private void EmitNewOrder(SingleOrder order)
            {
                if (this.NewOrder != null)
                {
                    this.NewOrder(new OrderEventArgs(order));
                }
            }

            private void EmitExecutionReport(ExecutionReport report)
            {
                if (this.ExecutionReport != null)
                {
                    this.ExecutionReport(this, new ExecutionReportEventArgs(report));
                }
            }

            private void EmitOrderListUpdated()
            {
                if (this.OrderListUpdated != null)
                {
                    this.OrderListUpdated(typeof(OrderManager.SellSideService), EventArgs.Empty);
                }
            }
        }
    }
}
