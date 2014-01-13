using OpenQuant.API;
using FreeQuant.FIX;
using System;

namespace OpenQuant.API.Plugins
{
	///<summary>
	///  A user defined provider
	///</summary>
	public class UserProvider
	{
		private FQProvider provider;
		///<summary>
		///  Provider identificator
		///</summary>
		protected byte id = byte.MaxValue;
		///<summary>
		///  Provider name 
		///</summary>
		protected string name = "User provider name";
		///<summary>
		///  Provider description
		///</summary>
		protected string description = "User provider description";
		///<summary>
		///  Provider URL
		///</summary>
		protected string url = "http://www.freequant.org";
		///<summary>
		///  Provider connected flag 
		///</summary>
		protected bool isConnected;

		protected virtual bool IsConnected
		{ 
			get { return this.isConnected; }
		}

		///<summary>
		///  Initializes a new instance of the UserProvider class
		///</summary>
		protected UserProvider()
		{
			this.isConnected = false;
			this.provider = new FQProvider(this);
		}

		///<summary>
		///  Initializes a new instance of the UserProvider class
		///</summary>
		/// 
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

		///<summary>
		///  Override to disconnect from provider
		///</summary>
		protected virtual void Disconnect() {}

		///<summary>
		///  Override to shutdown provider plugin 
		///</summary>
		protected virtual void Shutdown()
		{
			if (!this.isConnected)
				return;
			this.Disconnect();
		}

		///<summary>
		///  Override to subscribe to market data feed
		///</summary>		 
		[Obsolete("Use Subscribe(Instrument,SubscriptionDataType) method", false)]
		protected virtual void Subscribe(Instrument instrument) {}

		///<summary>
		///  Override to subscribe to market data feed
		///</summary>	
		protected virtual void Subscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
		{
			this.Subscribe(instrument);
		}

		///<summary>
		///  Override to unsubscribe from market data feed
		///</summary>	
		[Obsolete("Use Unsubscribe(Instrument,SubscriptionDataType) method", false)]
		protected virtual void Unsubscribe(Instrument instrument) {}

		///<summary>
		///  Override to unsubscribe from market data feed
		///</summary>	
		protected virtual void Unsubscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
		{
			this.Unsubscribe(instrument);
		}

		///<summary>
		///  Override to request a historical data 
		///</summary>	
		protected virtual void RequestHistoricalData(HistoricalDataRequest request)
		{
		}
		///<summary>
		///  Override to cancel a historical data request
		///</summary>
		protected virtual void CancelHistoricalData(HistoricalDataRequest request)	{}

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

		///<summary>
		///  Call to emit order accepted execution report 
		///</summary>
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

		///<summary>
		///  Call to emit order cancelled execution report
		///</summary>
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

		///<summary>
		///  Override to send an order
		///</summary>
		protected virtual void Send(Order order) {}

		///<summary>
		///  Override to cancel an order
		///</summary>
		protected virtual void Cancel(Order order) {}

		///<summary>
		///  Override to replace an order 
		///</summary>
		[Obsolete("Use Replace(Order,double,double,double) method.", false)]
		protected virtual void Replace(Order order)
		{
			throw new NotImplementedException("Not implemented because of Obsoletion");
		}

		///<summary>
		///  Override to replace an order
		///</summary>
		protected virtual void Replace(Order order, double newQty, double newPrice, double newStopPrice)
		{
		}

		protected virtual BrokerInfo GetBrokerInfo()
		{
			return new BrokerInfo();
		}
	}
}
