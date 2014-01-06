using OpenQuant.API;
using FreeQuant.FIX;
using System;

namespace OpenQuant.API.Plugins
{
  public class UserProvider
  {
    protected byte id = byte.MaxValue;
    protected string name = "User provider";
    protected string description = "User provider";
    protected string url = "http://www.smartquant.com";
    private SQProvider provider;
    protected bool isConnected;

    protected virtual bool IsConnected
    {
      get
      {
        return this.isConnected;
      }
    }

    protected UserProvider()
    {
      this.isConnected = false;
      this.provider = new SQProvider(this);
    }

    internal byte GetId()
    {
      return this.id;
    }

    internal string GetName()
    {
      return this.name;
    }

    internal string GetDescription()
    {
      return this.description;
    }

    internal string GetURL()
    {
      return this.url;
    }

    protected virtual void Connect()
    {
    }

    protected virtual void Disconnect()
    {
    }

    protected virtual void Shutdown()
    {
      if (!this.isConnected)
        return;
      this.Disconnect();
    }

    [Obsolete("Use Subscribe(Instrument,SubscriptionDataType) method", false)]
    protected virtual void Subscribe(Instrument instrument)
    {
    }

    protected virtual void Subscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
    {
      this.Subscribe(instrument);
    }

    [Obsolete("Use Unsubscribe(Instrument,SubscriptionDataType) method", false)]
    protected virtual void Unsubscribe(Instrument instrument)
    {
    }

    protected virtual void Unsubscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
    {
      this.Unsubscribe(instrument);
    }

    protected virtual void RequestHistoricalData(HistoricalDataRequest request)
    {
    }

    protected virtual void CancelHistoricalData(HistoricalDataRequest request)
    {
    }

    protected void EmitConnected()
    {
      this.provider.EmitConnected();
    }

    protected void EmitDisconnected()
    {
      this.provider.EmitDisconnected();
    }

    protected void EmitNewTrade(Instrument instrument, DateTime time, double price, int size)
    {
      this.EmitNewTrade(instrument, time, this.id, price, size);
    }

    protected void EmitNewTrade(Instrument instrument, DateTime time, byte providerId, double price, int size)
    {
      this.provider.EmitTrade(instrument, time, providerId, price, size);
    }

    protected void EmitNewQuote(Instrument instrument, DateTime time, double bid, int bidSize, double ask, int askSize)
    {
      this.EmitNewQuote(instrument, time, this.id, bid, bidSize, ask, askSize);
    }

    protected void EmitNewQuote(Instrument instrument, DateTime time, byte providerId, double bid, int bidSize, double ask, int askSize)
    {
      this.provider.EmitQuote(instrument, time, providerId, bid, bidSize, ask, askSize);
    }

    protected void EmitNewOrderBookUpdate(Instrument instrument, DateTime time, BidAsk side, OrderBookAction action, double price, int size, int position)
    {
      this.provider.EmitMarketDepth(instrument, time, side, action, price, size, position);
    }

    protected void EmitNewBarOpen(Instrument instrument, BarType barType, long barSize, DateTime beginDateTime, DateTime endDateTime, double open, double high, double low, double close, long volume)
    {
      this.provider.EmitBarOpen(instrument, barType, barSize, beginDateTime, endDateTime, open, high, low, close, volume);
    }

    protected void EmitNewBar(Instrument instrument, BarType barType, long barSize, DateTime beginDateTime, DateTime endDateTime, double open, double high, double low, double close, long volume)
    {
      this.provider.EmitBar(instrument, barType, barSize, beginDateTime, endDateTime, open, high, low, close, volume);
    }

    protected void EmitNewBarSlice(long barSize)
    {
      this.provider.EmitBarSlice(barSize);
    }

    protected void EmitError(int id, int code, string message)
    {
      this.provider.EmitError(id, code, message);
    }

    protected void EmitError(string message)
    {
      this.EmitError(-1, -1, message);
    }

    protected void EmitAccepted(Order order)
    {
      this.provider.EmitExecutionReport(order, OrdStatus.New);
    }

    protected void EmitRejected(Order order, string message)
    {
      this.provider.EmitExecutionReport(order, OrdStatus.Rejected, message);
    }

    protected void EmitFilled(Order order, double price, int quantity)
    {
      this.provider.EmitExecutionReport(order, price, quantity);
    }

    protected void EmitFilled(Order order, double price, int quantity, CommissionType commissionType, double commission)
    {
      this.provider.EmitExecutionReport(order, price, quantity, EnumConverter.Convert(commissionType), commission);
    }

    protected void EmitPendingCancel(Order order)
    {
      this.provider.EmitExecutionReport(order, OrdStatus.PendingCancel);
    }

    protected void EmitCancelled(Order order)
    {
      this.provider.EmitExecutionReport(order, OrdStatus.Cancelled);
    }

    protected void EmitPendingReplace(Order order)
    {
      this.provider.EmitExecutionReport(order, OrdStatus.PendingReplace);
    }

    protected void EmitReplaced(Order order)
    {
      this.provider.EmitExecutionReport(order, OrdStatus.Replaced);
    }

    protected void EmitCancelReject(Order order, OrderStatus status, string message)
    {
      this.provider.EmitCancelReject(order, EnumConverter.Convert(status), message);
    }

    protected void EmitReplaceReject(Order order, OrderStatus status, string message)
    {
      this.provider.EmitCancelReplaceReject(order, EnumConverter.Convert(status), message);
    }

    protected void EmitNewHistoricalTrade(HistoricalDataRequest request, DateTime datetime, double price, int size)
    {
      this.provider.EmitHistoricalTrade(request, datetime, price, size);
    }

    protected void EmitNewHistoricalQuote(HistoricalDataRequest request, DateTime datetime, double bid, int bidSize, double ask, int askSize)
    {
      this.provider.EmitHistoricalQuote(request, datetime, bid, bidSize, ask, askSize);
    }

    protected void EmitNewHistoricalBar(HistoricalDataRequest request, DateTime datetime, double open, double high, double low, double close, long volume)
    {
      this.provider.EmitHistoricalBar(request, datetime, open, high, low, close, volume);
    }

    protected void EmitHistoricalDataCompleted(HistoricalDataRequest request)
    {
      this.provider.EmitHistoricalDataCompleted(request);
    }

    protected void EmitHistoricalDataCancelled(HistoricalDataRequest request)
    {
      this.provider.EmitHistoricalDataCancelled(request);
    }

    protected void EmitHistoricalDataError(HistoricalDataRequest request, string message)
    {
      this.provider.EmitHistoricalDataError(request, message);
    }

    internal bool CallIsConnected()
    {
      return this.IsConnected;
    }

    internal void CallConnect()
    {
      this.Connect();
    }

    internal void CallDisconnect()
    {
      this.Disconnect();
    }

    internal void CallShutdown()
    {
      this.Shutdown();
    }

    internal void CallSubscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
    {
      this.Subscribe(instrument, subscriptionDataType);
    }

    internal void CallUnsubscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
    {
      this.Unsubscribe(instrument, subscriptionDataType);
    }

    internal void CallSend(Order order)
    {
      this.Send(order);
    }

    internal void CallCancel(Order order)
    {
      this.Cancel(order);
    }

    internal void CallReplace(Order order)
    {
      this.Replace(order, order.ReplaceOrder.OrderQty, order.ReplaceOrder.Price, order.ReplaceOrder.StopPx);
    }

    internal BrokerInfo CallGetBrokerInfo()
    {
      return this.GetBrokerInfo();
    }

    internal void CallRequestHistoricalData(HistoricalDataRequest request)
    {
      this.RequestHistoricalData(request);
    }

    internal void CallCancelHistoricalData(HistoricalDataRequest request)
    {
      this.CancelHistoricalData(request);
    }

    protected virtual void Send(Order order)
    {
    }

    protected virtual void Cancel(Order order)
    {
    }

    [Obsolete("Use Replace(Order,double,double,double) method.", false)]
    protected virtual void Replace(Order order)
    {
    }

    protected virtual void Replace(Order order, double newQty, double newPrice, double newStopPrice)
    {
    }

    protected virtual BrokerInfo GetBrokerInfo()
    {
      return new BrokerInfo();
    }
  }
}
