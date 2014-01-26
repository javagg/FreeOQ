using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using QuickFix;
using QuickFix.Transport;

namespace FreeQuant.FIXApplication
{
	public class QuickFIX43Provider : IMarketDataProvider, IInstrumentProvider, IExecutionProvider
	{
		private const string p7p4hiQOUV = "Information";
		private const string PfM4dMIa7H = "Status";
		private const string mIJ4y3LqCP = "Bar Factory";
		private const string VlE4J6auEU = "Initiator";
		protected const string CATEGORY_LOGGING = "Message Logging";
		protected const string CATEGORY_STORAGE = "Message Storage";
		protected QuickFIX43Application application;
		protected SessionSettings sessionSettings;
		protected IMessageFactory messageFactory;
		protected IMessageStoreFactory storeFactory;
		protected ILogFactory logFactory;
		protected bool loggingEnabled;
		protected bool isConnected;
		protected bool isInitiated;
		protected ProviderStatus status;
		protected int mdReqCount;
		protected Hashtable mdRequests;
		private IBarFactory barFactory;
		private IInitiator initiator; 
		private Hashtable OEp4ErKILr;
		private Hashtable Hmv4SHEnBE;

		[Description("FreeQuant unique identificator for this provider")]
		[Category("Information")]
		public virtual byte Id { get { return 3; } }

		[Description("Name of this provider")]
		[Category("Information")]
		public virtual string Name
		{
			get
			{
				return "QuickFIX43Provider";
			}
		}

		[Category("Information")]
		[Description("Description of this provider")]
		public virtual string Title
		{
			get
			{
				return "QuickFIX43Provider";
			}
		}

		[Category("Information")]
		[Description("URL of this provider")]
		public virtual string URL
		{
			get
			{
				return "Invalid URL";
			}
		}

		[Description("True if this provider is connected")]
		[Category("Status")]
		public bool IsConnected
		{
			get
			{
				return this.isConnected;
			}
		}

		[Category("Status")]
		[Description("Current connection status of this provider")]
		public ProviderStatus Status
		{
			get
			{
				return this.status;
			}
		}

		[Category("Initiator")]
		[DefaultValue(InitiatorMode.Single)]
		public InitiatorMode InitiatorMode { get; set; }

		[Category("Message Logging")]
		[Description("Enable or disable message logging")]
		[DefaultValue(false)]
		public bool LoggingEnabled
		{
			get
			{
				return this.loggingEnabled;
			}
			set
			{
				this.loggingEnabled = value;
			}
		}

		[Description("Bar factory of this market data provider")]
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
					this.barFactory.NewBar -= new BarEventHandler(this.UYL44X1DVX);
					this.barFactory.NewBarOpen -= new BarEventHandler(this.hFe4w8v4Nv);
					this.barFactory.NewBarSlice -= new BarSliceEventHandler(this.pd04aGWtRw);
				}
				this.barFactory = value;
				if (this.barFactory == null)
					return;
				this.barFactory.NewBar += new BarEventHandler(this.UYL44X1DVX);
				this.barFactory.NewBarOpen += new BarEventHandler(this.hFe4w8v4Nv);
				this.barFactory.NewBarSlice += new BarSliceEventHandler(this.pd04aGWtRw);
			}
		}

		[Browsable(false)]
		public IMarketDataFilter MarketDataFilter { get; set; }

		public event EventHandler Connected;
		public event EventHandler Disconnected;
		public event EventHandler StatusChanged;
		public event ProviderErrorEventHandler Error;
		public event SecurityDefinitionEventHandler SecurityDefinition;
		public event MarketDataRequestRejectEventHandler MarketDataRequestReject;
		public event MarketDataEventHandler NewMarketData;
		public event BarEventHandler NewBar;
		public event BarEventHandler NewBarOpen;
		public event BarSliceEventHandler NewBarSlice;
		public event BarEventHandler NewMarketBar;
		public event QuoteEventHandler NewQuote;
		public event TradeEventHandler NewTrade;
		public event MarketDepthEventHandler NewMarketDepth;
		public event FundamentalEventHandler NewFundamental;
		public event CorporateActionEventHandler NewCorporateAction;
		public event MarketDataSnapshotEventHandler MarketDataSnapshot;
		public event ExecutionReportEventHandler ExecutionReport;
		public event OrderCancelRejectEventHandler OrderCancelReject;

		protected QuickFIX43Provider()
		{
			this.mdRequests = new Hashtable();
			this.OEp4ErKILr = new Hashtable();
			this.Hmv4SHEnBE = new Hashtable();
			this.BarFactory = new BarFactory(false);
			this.InitiatorMode = InitiatorMode.Single;
		}

		protected virtual void Init()
		{
			this.application = new QuickFIX43Application();
			this.sessionSettings = new SessionSettings("session.settings");
			this.storeFactory = new FileStoreFactory(this.sessionSettings);
			this.logFactory = new FileLogFactory(this.sessionSettings);
			this.messageFactory = new DefaultMessageFactory();
		}

		public virtual void Connect()
		{
			if (this.isConnected)
				return;
			if (!this.isInitiated)
			{
				this.Init();
				switch (this.InitiatorMode)
				{
					case InitiatorMode.Single:
						this.initiator = !this.loggingEnabled ? new SocketInitiator(this.application, this.storeFactory, this.sessionSettings, this.messageFactory) : new SocketInitiator(this.application, this.storeFactory, this.sessionSettings, this.logFactory, this.messageFactory);
						break;
					case InitiatorMode.Threaded:
						this.initiator = !this.loggingEnabled ? new ThreadedSocketInitiator(this.application, this.storeFactory, this.sessionSettings, this.messageFactory) : new ThreadedSocketInitiator(this.application, this.storeFactory, this.sessionSettings, this.logFactory, this.messageFactory);
						break;
				}
				this.initiator.start();
				this.isInitiated = true;
				this.application.Logon += new FIXLogonEventHandler(this.H3T4F4ZJZW);
				this.application.Logout += new FIXLogoutEventHandler(this.L0C4OEBGEG);
				this.application.SecurityDefinition += new FIXSecurityDefinitionEventHandler(this.lB74tX1KNj);
				this.application.MarketDataSnapshot += new FIXMarketDataSnapshotEventHandler(this.ST74ZxO7ZP);
				this.application.ExecutionReport += new ExecutionReportEventHandler(this.LpP4CCeYG5);
				this.application.OrderCancelReject += new OrderCancelRejectEventHandler(this.aNk4mHq3DK);
			}
			this.application.Connect();
		}

		public virtual void Connect(int timeout)
		{
			this.Connect();
			ProviderManager.WaitConnected((IProvider)this, timeout);
		}

		public virtual void Disconnect()
		{
			if (!this.isConnected)
				return;
			this.application.Disconnect();
		}

		public virtual void Shutdown()
		{
			this.Disconnect();
		}

		public virtual void SendSecurityDefinitionRequest(FIXSecurityDefinitionRequest request)
		{
			if (this.IsConnected)
			{
				this.application.Send(request);
			}
			else
			{
				if (this.j4t4Wyi2Ea == null)
					return;
				this.j4t4Wyi2Ea(new ProviderErrorEventArgs((IProvider)this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(3698)));
			}
		}

		private void UYL44X1DVX([In] object obj0, [In] BarEventArgs obj1)
		{
			Bar bar = obj1.Bar;
			if (this.MarketDataFilter != null)
				bar = this.MarketDataFilter.FilterBar(bar, obj1.Instrument.Symbol);
			if (bar == null || this.fFo4YUW43X == null)
				return;
			this.fFo4YUW43X((object)this, new BarEventArgs(bar, obj1.Instrument, (IMarketDataProvider)this));
		}

		private void hFe4w8v4Nv([In] object obj0, [In] BarEventArgs obj1)
		{
			Bar bar = obj1.Bar;
			if (this.MarketDataFilter != null)
				bar = this.MarketDataFilter.FilterBarOpen(bar, obj1.Instrument.Symbol);
			if (bar == null || this.Uo04uKSknp == null)
				return;
			this.Uo04uKSknp((object)this, new BarEventArgs(bar, obj1.Instrument, (IMarketDataProvider)this));
		}

		private void pd04aGWtRw([In] object obj0, [In] BarSliceEventArgs obj1)
		{
			if (this.acs4LtXAvt == null)
				return;
			this.acs4LtXAvt((object)this, new BarSliceEventArgs(obj1.BarSize, (IMarketDataProvider)this));
		}

		public virtual void SendMarketDataRequest(FIXMarketDataRequest request)
		{
			if (this.IsConnected)
			{
				switch (request.SubscriptionRequestType)
				{
					case '1':
						string str1 = this.agD49enOqk(request.GetRelatedSymGroup(0));
						RequestRecord requestRecord1;
						if (str1 == null)
						{
							++this.mdReqCount;
							string str2 = string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3836), (object)Clock.Now, (object)this.mdReqCount);
							request.MDReqID = str2;
							requestRecord1 = new RequestRecord(request.GetRelatedSymGroup(0).Symbol, request);
							this.mdRequests.Add((object)str2, (object)requestRecord1);
							this.application.Send(request);
						}
						else
							requestRecord1 = this.mdRequests[(object)str1] as RequestRecord;
						++requestRecord1.RequestCount;
						break;
					case '2':
						string str3 = this.agD49enOqk(request.GetRelatedSymGroup(0));
						if (str3 == null)
							break;
						RequestRecord requestRecord2 = this.mdRequests[(object)str3] as RequestRecord;
						--requestRecord2.RequestCount;
						if (requestRecord2.RequestCount != 0)
							break;
						request.MDReqID = str3;
						this.application.Send(request);
						this.mdRequests.Remove((object)str3);
						break;
				}
			}
			else
			{
				if (this.j4t4Wyi2Ea == null)
					return;
				this.j4t4Wyi2Ea(new ProviderErrorEventArgs((IProvider)this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(3894)));
			}
		}

		private string agD49enOqk([In] FIXRelatedSymGroup obj0)
		{
			foreach (DictionaryEntry dictionaryEntry in this.mdRequests)
			{
				if (((RequestRecord)dictionaryEntry.Value).Symbol == obj0.Symbol)
					return (string)dictionaryEntry.Key;
			}
			return null;
		}

		public virtual void SendOrderStatusRequest(OrderStatusRequest request)
		{
		}

		public virtual void SendNewOrderSingle(NewOrderSingle order)
		{
			if (this.IsConnected)
			{
				this.application.Send((FIXNewOrderSingle)order);
			}
			else
			{
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = Clock.Now;
				report.ClOrdID = order.ClOrdID;
				report.ExecType = FreeQuant.FIX.ExecType.Rejected;
				report.OrdStatus = FreeQuant.FIX.OrdStatus.Rejected;
				report.Symbol = order.Symbol;
				report.SecurityType = order.SecurityType;
				report.SecurityExchange = order.SecurityExchange;
				report.Currency = order.Currency;
				report.Side = order.Side;
				report.OrdType = order.OrdType;
				report.TimeInForce = order.TimeInForce;
				report.OrderQty = order.OrderQty;
				report.Price = order.Price;
				report.StopPx = order.StopPx;
				report.LastPx = 0.0;
				report.LastQty = 0.0;
				report.AvgPx = 0.0;
				report.CumQty = 0.0;
				report.LeavesQty = order.OrderQty;
				report.Text = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4016);
				if (this.q8X4lYTN4C != null)
					this.q8X4lYTN4C((object)this, new ExecutionReportEventArgs(report));
				if (this.j4t4Wyi2Ea == null)
					return;
				this.j4t4Wyi2Ea(new ProviderErrorEventArgs((IProvider)this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(4070)));
			}
		}

		public virtual void SendOrderCancelRequest(OrderCancelRequest request)
		{
			if (this.IsConnected)
			{
				this.application.Send((FIXOrderCancelRequest)request);
			}
			else
			{
				OrderCancelReject reject = new OrderCancelReject();
				reject.TransactTime = Clock.Now;
				reject.OrigClOrdID = request.OrigClOrdID;
				reject.ClOrdID = reject.OrigClOrdID;
				reject.CxlRejResponseTo = FreeQuant.FIX.CxlRejResponseTo.CancelRequest;
				reject.CxlRejReason = FreeQuant.FIX.CxlRejReason.BrokerOption;
				reject.OrdStatus = FreeQuant.FIX.OrdStatus.Undefined;
				reject.Text = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4164);
				if (this.GZq4XSlmZH != null)
					this.GZq4XSlmZH((object)this, new OrderCancelRejectEventArgs(reject));
				if (this.j4t4Wyi2Ea == null)
					return;
				this.j4t4Wyi2Ea(new ProviderErrorEventArgs((IProvider)this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(4218)));
			}
		}

		public virtual void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
		{
			if (this.IsConnected)
			{
				this.application.Send((FIXOrderCancelReplaceRequest)request);
			}
			else
			{
				OrderCancelReject reject = new OrderCancelReject();
				reject.TransactTime = Clock.Now;
				reject.OrigClOrdID = request.OrigClOrdID;
				reject.ClOrdID = reject.OrigClOrdID;
				reject.CxlRejResponseTo = FreeQuant.FIX.CxlRejResponseTo.CancelReplaceRequest;
				reject.CxlRejReason = FreeQuant.FIX.CxlRejReason.BrokerOption;
				reject.OrdStatus = FreeQuant.FIX.OrdStatus.Undefined;
				reject.Text = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4342);
				if (this.GZq4XSlmZH != null)
					this.GZq4XSlmZH((object)this, new OrderCancelRejectEventArgs(reject));
				if (this.j4t4Wyi2Ea == null)
					return;
				this.j4t4Wyi2Ea(new ProviderErrorEventArgs((IProvider)this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(4396)));
			}
		}

		public virtual BrokerInfo GetBrokerInfo()
		{
			return new BrokerInfo();
		}

		public virtual void RegisterOrder(NewOrderSingle order)
		{
		}

		private void H3T4F4ZJZW([In] object obj0, [In] FIXSessionIDEventArgs obj1)
		{
			this.isConnected = true;
			this.status = ProviderStatus.LoggedIn;
			if (this.o6v4QitnW3 != null)
				this.o6v4QitnW3((object)this, EventArgs.Empty);
			if (this.BW04vSAahK == null)
				return;
			this.BW04vSAahK((object)this, EventArgs.Empty);
		}

		private void L0C4OEBGEG([In] object obj0, [In] FIXSessionIDEventArgs obj1)
		{
			if (!this.isConnected)
				return;
			this.mdRequests.Clear();
			this.isConnected = false;
			this.status = ProviderStatus.Disconnected;
			if (this.Xmn4o6calw != null)
				this.Xmn4o6calw((object)this, EventArgs.Empty);
			if (this.BW04vSAahK == null)
				return;
			this.BW04vSAahK((object)this, EventArgs.Empty);
		}

		private void ST74ZxO7ZP([In] object obj0, [In] FIXMarketDataSnapshotEventArgs obj1)
		{
			Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4536));
			FIXMarketDataSnapshot snapshotFullRefresh = obj1.MarketDataSnapshotFullRefresh;
			Instrument instrument = InstrumentManager.Instruments[(this.mdRequests[(object)snapshotFullRefresh.MDReqID] as RequestRecord).Symbol];
			Trade trade = this.OEp4ErKILr[(object)instrument] as Trade;
			Quote quote = this.Hmv4SHEnBE[(object)instrument] as Quote;
			if (trade == null)
			{
				trade = new Trade();
				this.OEp4ErKILr[(object)instrument] = (object)trade;
			}
			if (quote == null)
			{
				quote = new Quote();
				this.Hmv4SHEnBE[(object)instrument] = (object)quote;
			}
			bool flag1 = false;
			bool flag2 = false;
			for (int i = 0; i < snapshotFullRefresh.NoMDEntries; ++i)
			{
				FIXMDEntriesGroup mdEntriesGroup = snapshotFullRefresh.GetMDEntriesGroup(i);
				switch (mdEntriesGroup.MDEntryType)
				{
					case '0':
						if (quote.Bid != mdEntriesGroup.MDEntryPx || quote.BidSize != (int)mdEntriesGroup.MDEntrySize)
						{
							quote.DateTime = Clock.Now;
							quote.Bid = mdEntriesGroup.MDEntryPx;
							quote.BidSize = (int)mdEntriesGroup.MDEntrySize;
							flag2 = true;
							break;
						}
						else
							break;
					case '1':
						if (quote.Ask != mdEntriesGroup.MDEntryPx || quote.AskSize != (int)mdEntriesGroup.MDEntrySize)
						{
							quote.DateTime = Clock.Now;
							quote.Ask = mdEntriesGroup.MDEntryPx;
							quote.AskSize = (int)mdEntriesGroup.MDEntrySize;
							flag2 = true;
							break;
						}
						else
							break;
					case '2':
						if (trade.Price != mdEntriesGroup.MDEntryPx || trade.Size != (int)mdEntriesGroup.MDEntrySize)
						{
							trade.DateTime = Clock.Now;
							trade.Price = mdEntriesGroup.MDEntryPx;
							trade.Size = (int)mdEntriesGroup.MDEntrySize;
							flag1 = true;
							break;
						}
						else
							break;
				}
			}
			if (flag1 && this.odL46gHXsq != null)
				this.odL46gHXsq((object)this, new TradeEventArgs(new Trade(trade), (IFIXInstrument)instrument, (IMarketDataProvider)this));
			if (flag2 && this.uQX4e0V1fj != null)
				this.uQX4e0V1fj((object)this, new QuoteEventArgs(new Quote(quote), (IFIXInstrument)instrument, (IMarketDataProvider)this));
			if (this.oSc4rhuvbm == null)
				return;
			this.oSc4rhuvbm((object)this, new MarketDataSnapshotEventArgs(obj1.MarketDataSnapshotFullRefresh));
		}

		private void lB74tX1KNj([In] object obj0, [In] FIXSecurityDefinitionEventArgs obj1)
		{
			if (this.ppm42rEfws == null)
				return;
			this.ppm42rEfws((object)this, new SecurityDefinitionEventArgs(obj1.SecurityDefinition));
		}

		private void LpP4CCeYG5([In] object obj0, [In] ExecutionReportEventArgs obj1)
		{
			if (this.q8X4lYTN4C == null)
				return;
			this.q8X4lYTN4C((object)this, new ExecutionReportEventArgs(obj1.ExecutionReport));
		}

		private void aNk4mHq3DK([In] object obj0, [In] OrderCancelRejectEventArgs obj1)
		{
			if (this.GZq4XSlmZH == null)
				return;
			this.GZq4XSlmZH((object)this, new OrderCancelRejectEventArgs(obj1.OrderCancelReject));
		}

		public void EmitTrade(Trade trade, Instrument instrument)
		{
			if (this.MarketDataFilter != null)
			{
				trade = this.MarketDataFilter.FilterTrade(trade, instrument.Symbol);
				if (trade == null)
					return;
			}
			if (this.odL46gHXsq != null)
				this.odL46gHXsq((object)this, new TradeEventArgs(trade, (IFIXInstrument)instrument, (IMarketDataProvider)this));
			if (this.barFactory == null)
				return;
			this.barFactory.OnNewTrade((IFIXInstrument)instrument, trade);
		}

		public void EmitQuote(Quote quote, Instrument instrument)
		{
			if (this.MarketDataFilter != null)
			{
				quote = this.MarketDataFilter.FilterQuote(quote, instrument.Symbol);
				if (quote == null)
					return;
			}
			if (this.uQX4e0V1fj != null)
				this.uQX4e0V1fj((object)this, new QuoteEventArgs(quote, (IFIXInstrument)instrument, (IMarketDataProvider)this));
			if (this.barFactory == null)
				return;
			this.barFactory.OnNewQuote((IFIXInstrument)instrument, quote);
		}

		public void EmitMarketDepth(FreeQuant.Data.MarketDepth depth, Instrument instrument)
		{
			if (this.WiB4iTUE4w == null)
				return;
			this.WiB4iTUE4w((object)this, new MarketDepthEventArgs(depth, (IFIXInstrument)instrument, (IMarketDataProvider)this));
		}

		public void EmitError(int id, int code, string message)
		{
			if (this.j4t4Wyi2Ea == null)
				return;
			this.j4t4Wyi2Ea(new ProviderErrorEventArgs((IProvider)this, id, code, message));
		}

		public void EmitError(string message)
		{
			this.EmitError(-1, -1, message);
		}

		public void EmitOrderCancelReject(OrderCancelReject reject)
		{
			if (this.GZq4XSlmZH == null)
				return;
			this.GZq4XSlmZH((object)this, new OrderCancelRejectEventArgs(reject));
		}
	}
}
