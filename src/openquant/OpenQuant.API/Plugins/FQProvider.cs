using OpenQuant.API;
using OpenQuant.ObjectMap;
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace OpenQuant.API.Plugins
{
  [TypeDescriptionProvider(typeof(FQProviderTypeDescriptionProvider))]
  internal class FQProvider : IMarketDataProvider, IExecutionProvider, IHistoricalDataProvider, IProvider
  {
    private const string CATEGORY_INFO = "Information";
    private const string CATEGORY_STATUS = "Status";
    private const string CATEGORY_BAR_FACTORY = "Bar Factory";
    private UserProvider provider;
    private IBarFactory barFactory;
    private Dictionary<Order, OrderRecord> orderRecords;
    private Dictionary<string, HistoricalDataRequest> historicalDataRequests;

    internal UserProvider UserProvider
    {
      get
      {
        return this.provider;
      }
    }

    [Browsable(false)]
    public string PropertiesStr
    {
      get
      {
        List<string> list = new List<string>();
        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties((object) this.provider))
        {
          if (!propertyDescriptor.IsReadOnly && propertyDescriptor.IsBrowsable && propertyDescriptor.PropertyType.IsSerializable)
          {
            object obj = propertyDescriptor.GetValue((object) this.provider);
            if (obj != null)
              list.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}={1}", new object[2]
              {
                (object) propertyDescriptor.Name,
                obj
              }));
          }
        }
        return string.Join(";", list.ToArray());
      }
      set
      {
        string[] strArray1 = value.Split(new char[1]
        {
          ';'
        });
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties((object) this.provider);
        foreach (string str in strArray1)
        {
          char[] chArray = new char[1]
          {
            '='
          };
          string[] strArray2 = str.Split(chArray);
          if (strArray2.Length == 2)
          {
            PropertyDescriptor propertyDescriptor = properties[strArray2[0]];
            if (propertyDescriptor != null)
            {
              try
              {
                TypeConverter converter = TypeDescriptor.GetConverter(propertyDescriptor.PropertyType);
                if (converter != null)
                {
                  if (converter.CanConvertFrom(typeof (string)))
                  {
                    object obj = converter.ConvertFromInvariantString(strArray2[1]);
                    propertyDescriptor.SetValue((object) this.provider, obj);
                  }
                }
              }
              catch
              {
              }
            }
          }
        }
      }
    }

    [Category("Information")]
    public byte Id
    {
      get
      {
        return this.provider.GetId();
      }
    }

    [Category("Information")]
    public string Name
    {
      get
      {
        return this.provider.GetName();
      }
    }

    [Category("Information")]
    public string Title
    {
      get
      {
        return this.provider.GetDescription();
      }
    }

    [Category("Information")]
    public string URL
    {
      get
      {
        return this.provider.GetURL();
      }
    }

    [Category("Status")]
    public bool IsConnected
    {
      get
      {
        return this.provider.CallIsConnected();
      }
    }

    [Category("Status")]
    public ProviderStatus Status
    {
      get
      {
        return !this.IsConnected ? ProviderStatus.Disconnected : ProviderStatus.Connected;
      }
    }

    [Category("Bar Factory")]
    public IBarFactory BarFactory
    {
      get
      {
        return this.barFactory;
      }
      set
      {
        if (this.barFactory != null)
        {
          this.barFactory.NewBarOpen -= new BarEventHandler(this.barFactory_NewBarOpen);
          this.barFactory.NewBar -= new BarEventHandler(this.barFactory_NewBar);
          this.barFactory.NewBarSlice -= new BarSliceEventHandler(this.barFactory_NewBarSlice);
        }
        this.barFactory = value;
        if (this.barFactory == null)
          return;
        this.barFactory.NewBarOpen += new BarEventHandler(this.barFactory_NewBarOpen);
        this.barFactory.NewBar += new BarEventHandler(this.barFactory_NewBar);
        this.barFactory.NewBarSlice += new BarSliceEventHandler(this.barFactory_NewBarSlice);
      }
    }

    [Browsable(false)]
    public IMarketDataFilter MarketDataFilter { get; set; }

    [Browsable(false)]
    public int[] BarSizes
    {
      get
      {
        return new int[0];
      }
    }

    [Browsable(false)]
    public int MaxConcurrentRequests
    {
      get
      {
        return 1;
      }
    }

    [Browsable(false)]
    public HistoricalDataRange DataRange
    {
      get
      {
        return HistoricalDataRange.DateTimeInterval;
      }
    }

    [Browsable(false)]
    public HistoricalDataType DataType
    {
      get
      {
        return HistoricalDataType.Trade | HistoricalDataType.Quote | HistoricalDataType.Bar | HistoricalDataType.Daily;
      }
    }

    public event EventHandler Connected;

    public event EventHandler Disconnected;

    public event ProviderErrorEventHandler Error;

    public event EventHandler StatusChanged;

    public event MarketDataRequestRejectEventHandler MarketDataRequestReject;

    public event MarketDataSnapshotEventHandler MarketDataSnapshot;

    public event BarEventHandler NewBar;

    public event BarEventHandler NewBarOpen;

    public event BarSliceEventHandler NewBarSlice;

    public event CorporateActionEventHandler NewCorporateAction;

    public event FundamentalEventHandler NewFundamental;

    public event BarEventHandler NewMarketBar;

    public event MarketDataEventHandler NewMarketData;

    public event MarketDepthEventHandler NewMarketDepth;

    public event QuoteEventHandler NewQuote;

    public event TradeEventHandler NewTrade;

    public event ExecutionReportEventHandler ExecutionReport;

    public event OrderCancelRejectEventHandler OrderCancelReject;

    public event HistoricalDataEventHandler HistoricalDataRequestCancelled;

    public event HistoricalDataEventHandler HistoricalDataRequestCompleted;

    public event HistoricalDataErrorEventHandler HistoricalDataRequestError;

    public event HistoricalBarEventHandler NewHistoricalBar;

    public event HistoricalMarketDepthEventHandler NewHistoricalMarketDepth;

    public event HistoricalQuoteEventHandler NewHistoricalQuote;

    public event HistoricalTradeEventHandler NewHistoricalTrade;

    internal FQProvider(UserProvider provider)
    {
      this.provider = provider;
      this.BarFactory = (IBarFactory) new FreeQuant.Providers.BarFactory(false);
      this.orderRecords = new Dictionary<Order, OrderRecord>();
      this.historicalDataRequests = new Dictionary<string, HistoricalDataRequest>();
    }

    public void Connect(int timeout)
    {
      this.provider.CallConnect();
      FreeQuant.Providers.ProviderManager.WaitConnected((IProvider) this, timeout);
    }

    public void Connect()
    {
      this.provider.CallConnect();
    }

    public void Disconnect()
    {
      this.provider.CallDisconnect();
    }

    public void Shutdown()
    {
      this.provider.CallShutdown();
    }

    public void EmitConnected()
    {
      if (this.Connected == null)
        return;
      this.Connected((object) this, EventArgs.Empty);
    }

    public void EmitDisconnected()
    {
      if (this.Disconnected == null)
        return;
      this.Disconnected((object) this, EventArgs.Empty);
    }

    public void EmitStatusChanged()
    {
      if (this.StatusChanged == null)
        return;
      this.StatusChanged((object) this, EventArgs.Empty);
    }

    public void EmitError(int id, int code, string message)
    {
      if (this.Error == null)
        return;
      this.Error(new ProviderErrorEventArgs((IProvider) this, id, code, message));
    }

    public void SendMarketDataRequest(FIXMarketDataRequest request)
    {
      SubscriptionDataType subscriptionDataType = (SubscriptionDataType) 0;
      for (int i = 0; i < request.NoMDEntryTypes; ++i)
      {
        switch (request.GetMDEntryTypesGroup(i).MDEntryType)
        {
          case '0':
          case '1':
            if (request.MarketDepth == 1)
            {
              subscriptionDataType |= SubscriptionDataType.Quotes;
              break;
            }
            else
            {
              subscriptionDataType |= SubscriptionDataType.OrderBook;
              break;
            }
          case '2':
            subscriptionDataType |= SubscriptionDataType.Trades;
            break;
        }
      }
      for (int i = 0; i < request.NoRelatedSym; ++i)
      {
        FreeQuant.Instruments.Instrument instrument1 = FreeQuant.Instruments.InstrumentManager.Instruments[request.GetRelatedSymGroup(i).Symbol];
        Instrument instrument2 = Map.FQ_OQ_Instrument[(object) instrument1] as Instrument;
        switch (request.SubscriptionRequestType)
        {
          case '1':
            this.provider.CallSubscribe(instrument2, subscriptionDataType);
            break;
          case '2':
            this.provider.CallUnsubscribe(instrument2, subscriptionDataType);
            break;
          default:
            throw new Exception("Unknown subscription request type " + (object) request.SubscriptionRequestType);
        }
      }
    }

    public void EmitTrade(Instrument instrument, DateTime time, byte providerId, double price, int size)
    {
      FreeQuant.Data.Trade trade = new FreeQuant.Data.Trade(time, price, size);
      trade.ProviderId = providerId;
      if (this.MarketDataFilter != null)
        trade = this.MarketDataFilter.FilterTrade(trade, instrument.Symbol);
      if (trade == null)
        return;
      if (this.NewTrade != null)
        this.NewTrade((object) this, new TradeEventArgs(trade, (IFIXInstrument) instrument.instrument, (IMarketDataProvider) this));
      if (this.barFactory == null)
        return;
      this.barFactory.OnNewTrade((IFIXInstrument) instrument.instrument, trade);
    }

    public void EmitQuote(Instrument instrument, DateTime time, byte providerId, double bid, int bidSize, double ask, int askSize)
    {
      FreeQuant.Data.Quote quote = new FreeQuant.Data.Quote(time, bid, bidSize, ask, askSize);
      quote.ProviderId = providerId;
      if (this.MarketDataFilter != null)
        quote = this.MarketDataFilter.FilterQuote(quote, instrument.Symbol);
      if (quote == null)
        return;
      if (this.NewQuote != null)
        this.NewQuote((object) this, new QuoteEventArgs(quote, (IFIXInstrument) instrument.instrument, (IMarketDataProvider) this));
      if (this.barFactory == null)
        return;
      this.barFactory.OnNewQuote((IFIXInstrument) instrument.instrument, quote);
    }

    public void EmitMarketDepth(Instrument instrument, DateTime time, BidAsk side, OrderBookAction action, double price, int size, int position)
    {
      MarketDepth marketDepth = new MarketDepth(time, string.Empty, position, EnumConverter.Convert(action), EnumConverter.Convert(side), price, size);
      if (this.NewMarketDepth == null)
        return;
      this.NewMarketDepth((object) this, new MarketDepthEventArgs(marketDepth, (IFIXInstrument) instrument.instrument, (IMarketDataProvider) this));
    }

    public void EmitBarOpen(Instrument instrument, BarType barType, long barSize, DateTime beginDateTime, DateTime endDateTime, double open, double high, double low, double close, long volume)
    {
      FreeQuant.Data.Bar bar = new FreeQuant.Data.Bar(EnumConverter.Convert(barType), barSize, beginDateTime, endDateTime, open, high, low, close, volume, 0L);
      if (this.MarketDataFilter != null)
        bar = this.MarketDataFilter.FilterBarOpen(bar, instrument.Symbol);
      if (bar == null)
        return;
      this.EmitBarOpen((IFIXInstrument) instrument.instrument, bar);
    }

    public void EmitBar(Instrument instrument, BarType barType, long barSize, DateTime beginDateTime, DateTime endDateTime, double open, double high, double low, double close, long volume)
    {
      FreeQuant.Data.Bar bar = new FreeQuant.Data.Bar(EnumConverter.Convert(barType), barSize, beginDateTime, endDateTime, open, high, low, close, volume, 0L);
      if (this.MarketDataFilter != null)
        bar = this.MarketDataFilter.FilterBar(bar, instrument.Symbol);
      if (bar == null)
        return;
      this.EmitBar((IFIXInstrument) instrument.instrument, bar);
    }

    public void EmitBarSlice(long barSize)
    {
      if (this.NewBarSlice == null)
        return;
      this.NewBarSlice((object) this, new BarSliceEventArgs(barSize, (IMarketDataProvider) this));
    }

    public void EmitMarketData()
    {
      if (this.NewMarketData == null)
        return;
      this.NewMarketData((object) this, new MarketDataEventArgs((IMarketData) null, (IFIXInstrument) null, (IMarketDataProvider) this));
    }

    public void EmitMarketDataSnapshot()
    {
      if (this.MarketDataSnapshot == null)
        return;
      this.MarketDataSnapshot((object) this, new MarketDataSnapshotEventArgs((FIXMarketDataSnapshot) null));
    }

    public void EmitMarketDataRequestReject()
    {
      if (this.MarketDataRequestReject == null)
        return;
      this.MarketDataRequestReject((object) this, new MarketDataRequestRejectEventArgs((MarketDataRequestReject) null));
    }

    public void EmitMarketBar()
    {
      if (this.NewMarketBar == null)
        return;
      this.NewMarketBar((object) this, new BarEventArgs((FreeQuant.Data.Bar) null, (IFIXInstrument) null, (IMarketDataProvider) this));
    }

    public void EmitFundamental()
    {
      if (this.NewFundamental == null)
        return;
      this.NewFundamental((object) this, new FundamentalEventArgs((Fundamental) null, (IFIXInstrument) null, (IMarketDataProvider) this));
    }

    public void EmitCorporateAction()
    {
      if (this.NewCorporateAction == null)
        return;
      this.NewCorporateAction((object) this, new CorporateActionEventArgs((CorporateAction) null, (IFIXInstrument) null, (IMarketDataProvider) this));
    }

    private void EmitBarOpen(IFIXInstrument instrument, FreeQuant.Data.Bar bar)
    {
      if (this.NewBarOpen == null)
        return;
      this.NewBarOpen((object) this, new BarEventArgs(bar, instrument, (IMarketDataProvider) this));
    }

    private void EmitBar(IFIXInstrument instrument, FreeQuant.Data.Bar bar)
    {
      if (this.NewBar == null)
        return;
      this.NewBar((object) this, new BarEventArgs(bar, instrument, (IMarketDataProvider) this));
    }

    public void SendNewOrderSingle(NewOrderSingle order)
    {
      Order order1 = Map.FQ_OQ_Order[(object) order] as Order;
      this.orderRecords.Add(order1, new OrderRecord(order as SingleOrder));
      this.provider.CallSend(order1);
    }

    public void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
    {
			IOrder iorder = ((InstrumentOrderListTable) OrderManager.Orders).All[request.OrigClOrdID];
      this.provider.CallReplace(Map.FQ_OQ_Order[(object) iorder] as Order);
    }

    public void SendOrderCancelRequest(OrderCancelRequest request)
    {
			IOrder iorder = ((InstrumentOrderListTable) OrderManager.Orders).All[request.OrigClOrdID];
      this.provider.CallCancel(Map.FQ_OQ_Order[(object) iorder] as Order);
    }

    public void SendOrderStatusRequest(OrderStatusRequest request)
    {
      throw new Exception("The method or operation is not implemented.");
    }

    public FreeQuant.Providers.BrokerInfo GetBrokerInfo()
    {
      return this.provider.CallGetBrokerInfo().brokerInfo;
    }

    public void RegisterOrder(NewOrderSingle order)
    {
    }

    public void EmitExecutionReport(Order order, double price, int quantity)
    {
      this.EmitExecutionReport(this.orderRecords[order], OrdStatus.Undefined, price, quantity, "");
    }

    public void EmitExecutionReport(Order order, double price, int quantity, CommType commType, double commission)
    {
      this.EmitExecutionReport(this.orderRecords[order], OrdStatus.Undefined, price, quantity, "", commType, commission);
    }

    public void EmitExecutionReport(Order order, OrdStatus status, string text)
    {
      this.EmitExecutionReport(this.orderRecords[order], status, 0.0, 0, text);
    }

    public void EmitExecutionReport(Order order, OrdStatus status)
    {
      this.EmitExecutionReport(order, status, "");
    }

    public void EmitCancelReject(Order order, OrdStatus status, string message)
    {
      this.EmitOrderCancelReject(this.orderRecords[order], status, CxlRejResponseTo.CancelRequest, message);
    }

    public void EmitCancelReplaceReject(Order order, OrdStatus status, string message)
    {
      this.EmitOrderCancelReject(this.orderRecords[order], status, CxlRejResponseTo.CancelReplaceRequest, message);
    }

    private void EmitExecutionReport(OrderRecord record, OrdStatus ordStatus, double lastPx, int lastQty, string text)
    {
      this.EmitExecutionReport(record, ordStatus, lastPx, lastQty, text, CommType.Absolute, 0.0);
    }

    private void EmitExecutionReport(OrderRecord record, OrdStatus ordStatus, double lastPx, int lastQty, string text, CommType commType, double commission)
    {
      FreeQuant.FIX.ExecutionReport report = new FreeQuant.FIX.ExecutionReport();
      report.TransactTime = Clock.Now;
      report.ClOrdID = ((FIXNewOrderSingle) record.Order).ClOrdID;
      report.OrigClOrdID = ((FIXNewOrderSingle) record.Order).ClOrdID;
      report.OrderID = record.Order.OrderID;
      report.Symbol = ((FIXNewOrderSingle) record.Order).Symbol;
      report.SecurityType = ((FIXNewOrderSingle) record.Order).SecurityType;
      report.SecurityExchange = ((FIXNewOrderSingle) record.Order).SecurityExchange;
      report.Currency = ((FIXNewOrderSingle) record.Order).Currency;
      report.CommType = commType;
      report.Commission = commission;
      report.Side = ((NewOrderSingle) record.Order).Side;
      if (ordStatus == OrdStatus.Replaced)
      {
				report.OrdType = record.Order.ReplaceOrder.ContainsField(40) ? record.Order.ReplaceOrder.OrdType : ((NewOrderSingle) record.Order).OrdType;
				report.TimeInForce = record.Order.ReplaceOrder.ContainsField(59) ? record.Order.ReplaceOrder.TimeInForce : ((NewOrderSingle) record.Order).TimeInForce;
				report.OrderQty = record.Order.ReplaceOrder.ContainsField(38) ? record.Order.ReplaceOrder.OrderQty : ((FIXNewOrderSingle) record.Order).OrderQty;
				report.Price = record.Order.ReplaceOrder.ContainsField(44) ? record.Order.ReplaceOrder.Price : ((FIXNewOrderSingle) record.Order).Price;
				report.StopPx = record.Order.ReplaceOrder.ContainsField(99) ? record.Order.ReplaceOrder.StopPx : ((FIXNewOrderSingle) record.Order).StopPx;
        record.LeavesQty = (int) report.OrderQty - record.CumQty;
      }
      else
      {
        report.OrdType = ((NewOrderSingle) record.Order).OrdType;
        report.TimeInForce = ((NewOrderSingle) record.Order).TimeInForce;
        report.OrderQty = ((FIXNewOrderSingle) record.Order).OrderQty;
        report.Price = ((FIXNewOrderSingle) record.Order).Price;
        report.StopPx = ((FIXNewOrderSingle) record.Order).StopPx;
      }
      report.LastPx = lastPx;
      report.LastQty = (double) lastQty;
      if (ordStatus == OrdStatus.Undefined)
      {
        record.AddFill(lastPx, lastQty);
        ordStatus = record.LeavesQty <= 0 ? OrdStatus.Filled : OrdStatus.PartiallyFilled;
      }
      report.AvgPx = record.AvgPx;
      report.CumQty = (double) record.CumQty;
      report.LeavesQty = (double) record.LeavesQty;
      report.ExecType = this.GetExecType(ordStatus);
      report.OrdStatus = ordStatus;
      report.Text = text;
      this.EmitExecutionReport(report);
    }

    private void EmitOrderCancelReject(OrderRecord record, OrdStatus ordStatus, CxlRejResponseTo responseTo, string text)
    {
      OrderCancelReject reject = new OrderCancelReject();
      reject.TransactTime = Clock.Now;
      reject.ClOrdID = ((FIXNewOrderSingle) record.Order).ClOrdID;
      reject.OrigClOrdID = ((FIXNewOrderSingle) record.Order).ClOrdID;
      reject.OrdStatus = ordStatus;
      reject.CxlRejResponseTo = responseTo;
      reject.CxlRejReason = CxlRejReason.BrokerOption;
      reject.Text = text;
      this.EmitOrderCancelReject(reject);
    }

    private void EmitExecutionReport(FreeQuant.FIX.ExecutionReport report)
    {
      if (this.ExecutionReport == null)
        return;
      this.ExecutionReport((object) this, new ExecutionReportEventArgs(report));
    }

    private void EmitOrderCancelReject(OrderCancelReject reject)
    {
      if (this.OrderCancelReject == null)
        return;
      this.OrderCancelReject((object) this, new OrderCancelRejectEventArgs(reject));
    }

    private ExecType GetExecType(OrdStatus status)
    {
      switch (status)
      {
        case OrdStatus.New:
          return ExecType.New;
        case OrdStatus.PartiallyFilled:
          return ExecType.PartialFill;
        case OrdStatus.Filled:
          return ExecType.Fill;
        case OrdStatus.Cancelled:
          return ExecType.Cancelled;
        case OrdStatus.Replaced:
          return ExecType.Replace;
        case OrdStatus.PendingCancel:
          return ExecType.PendingCancel;
        case OrdStatus.Rejected:
          return ExecType.Rejected;
        case OrdStatus.PendingReplace:
          return ExecType.PendingReplace;
        default:
          throw new ArgumentException(string.Format("Cannot find exec type for ord status - {0}", (object) status));
      }
    }

    private void barFactory_NewBarOpen(object sender, BarEventArgs args)
    {
      this.EmitBarOpen(args.Instrument, args.Bar);
    }

    private void barFactory_NewBar(object sender, BarEventArgs args)
    {
      this.EmitBar(args.Instrument, args.Bar);
    }

    private void barFactory_NewBarSlice(object sender, BarSliceEventArgs args)
    {
      this.EmitBarSlice(args.BarSize);
    }

    public void SendHistoricalDataRequest(FreeQuant.Providers.HistoricalDataRequest request)
    {
      HistoricalDataRequest request1 = new HistoricalDataRequest(request);
      this.historicalDataRequests.Add(request.RequestId, request1);
      this.provider.CallRequestHistoricalData(request1);
    }

    public void CancelHistoricalDataRequest(string requestId)
    {
      HistoricalDataRequest request;
      if (!this.historicalDataRequests.TryGetValue(requestId, out request))
        return;
      this.provider.CallCancelHistoricalData(request);
    }

    public void EmitHistoricalTrade(HistoricalDataRequest request, DateTime datetime, double price, int size)
    {
      if (this.NewHistoricalTrade == null)
        return;
      this.NewHistoricalTrade((object) this, new HistoricalTradeEventArgs(new FreeQuant.Data.Trade(datetime, price, size), request.request.RequestId, request.request.Instrument, (IHistoricalDataProvider) this, 0));
    }

    public void EmitHistoricalQuote(HistoricalDataRequest request, DateTime datetime, double bid, int bidSize, double ask, int askSize)
    {
      if (this.NewHistoricalQuote == null)
        return;
      this.NewHistoricalQuote((object) this, new HistoricalQuoteEventArgs(new FreeQuant.Data.Quote(datetime, bid, bidSize, ask, askSize), request.request.RequestId, request.request.Instrument, (IHistoricalDataProvider) this, 0));
    }

    public void EmitHistoricalBar(HistoricalDataRequest request, DateTime datetime, double open, double high, double low, double close, long volume)
    {
      if (this.NewHistoricalBar == null)
        return;
      this.NewHistoricalBar((object) this, new HistoricalBarEventArgs(request.request.DataType != HistoricalDataType.Daily ? new FreeQuant.Data.Bar(datetime, open, high, low, close, volume, request.request.BarSize) : (FreeQuant.Data.Bar) new Daily(datetime, open, high, low, close, volume, 0L), request.request.RequestId, request.request.Instrument, (IHistoricalDataProvider) this, 0));
    }

    private void EmitNewHistoricalMarketDepth()
    {
      if (this.NewHistoricalMarketDepth == null)
        return;
      this.NewHistoricalMarketDepth((object) this, new HistoricalMarketDepthEventArgs((MarketDepth) null, (string) null, (IFIXInstrument) null, (IHistoricalDataProvider) this, 0));
    }

    public void EmitHistoricalDataCompleted(HistoricalDataRequest request)
    {
      if (this.HistoricalDataRequestCompleted == null)
        return;
      this.HistoricalDataRequestCompleted((object) this, new HistoricalDataEventArgs(request.request.RequestId, request.request.Instrument, (IHistoricalDataProvider) this, 0));
    }

    public void EmitHistoricalDataCancelled(HistoricalDataRequest request)
    {
      if (this.HistoricalDataRequestCancelled == null)
        return;
      this.HistoricalDataRequestCancelled((object) this, new HistoricalDataEventArgs(request.request.RequestId, request.request.Instrument, (IHistoricalDataProvider) this, 0));
    }

    public void EmitHistoricalDataError(HistoricalDataRequest request, string message)
    {
      if (this.HistoricalDataRequestError == null)
        return;
      this.HistoricalDataRequestError((object) this, new HistoricalDataErrorEventArgs(request.request.RequestId, request.request.Instrument, (IHistoricalDataProvider) this, 0, message));
    }
  }
}
