using QuickFix;
using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FIXApplication
{
  public class QuickFIX42Provider : IMarketDataProvider, IInstrumentProvider, IProvider, IExecutionProvider
  {
    private const string OjNkxY5eI = "Information";
    private const string xvg5fWw34 = "Status";
    private const string TM0bdIJVq = "Bar Factory";
    private const string LmqjW2qhm = "Initiator";
    protected const string CATEGORY_LOGGING = "Message Logging";
    protected const string CATEGORY_STORAGE = "Message Storage";
    protected QuickFIX42Application application;
    protected SessionSettings sessionSettings;
    protected MessageFactory messageFactory;
    protected MessageStoreFactory storeFactory;
    protected LogFactory logFactory;
    protected bool loggingEnabled;
    protected bool isConnected;
    protected bool isInitiated;
    protected ProviderStatus status;
    protected int mdReqCount;
    protected Hashtable mdRequests;
    private IBarFactory lI2B1F18m;
    private Initiator iTjfR0QTM;
    private Hashtable nWHTWovCn;
    private Hashtable ojqxnwuNv;

    [Category("Information")]
    [Description("SmartQuant unique identificator for this provider")]
    public virtual byte Id
    {
     get
      {
        return (byte) 3;
      }
    }

    [Category("Information")]
    [Description("Name of this provider")]
    public virtual string Name
    {
     get
      {
        return BeAEwTZGlZaeOmY5cm.J00weU3cM6(1680);
      }
    }

    [Description("Description of this provider")]
    [Category("Information")]
    public virtual string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return BeAEwTZGlZaeOmY5cm.J00weU3cM6(1704);
      }
    }

    [Category("Information")]
    [Description("URL of this provider")]
    public virtual string URL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return BeAEwTZGlZaeOmY5cm.J00weU3cM6(1728);
      }
    }

    [Category("Status")]
    [Description("True if this provider is connected")]
    public bool IsConnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isConnected;
      }
    }

    [Description("Current connection status of this provider")]
    [Category("Status")]
    public ProviderStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.status;
      }
    }

    [DefaultValue(InitiatorMode.Single)]
    [Category("Initiator")]
    public InitiatorMode InitiatorMode { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Category("Message Logging")]
    [Description("Enable or disable message logging")]
    public bool LoggingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.loggingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.loggingEnabled = value;
      }
    }

    [Category("Bar Factory")]
    [Description("Bar factory of this market data provider")]
    public IBarFactory BarFactory
    {
     get
      {
        return this.lI2B1F18m;
      }
      set
      {
        if (this.lI2B1F18m != null)
        {
          this.lI2B1F18m.NewBar -= new BarEventHandler(this.CLc6DHRyV);
          this.lI2B1F18m.NewBarOpen -= new BarEventHandler(this.PiIiF8bRq);
          this.lI2B1F18m.NewBarSlice -= new BarSliceEventHandler(this.OZ2paKt9A);
        }
        this.lI2B1F18m = value;
        if (this.lI2B1F18m == null)
          return;
        this.lI2B1F18m.NewBar += new BarEventHandler(this.CLc6DHRyV);
        this.lI2B1F18m.NewBarOpen += new BarEventHandler(this.PiIiF8bRq);
        this.lI2B1F18m.NewBarSlice += new BarSliceEventHandler(this.OZ2paKt9A);
      }
    }

    [Browsable(false)]
    public IMarketDataFilter MarketDataFilter { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

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

    protected QuickFIX42Provider()
    {
      this.mdRequests = new Hashtable();
      this.nWHTWovCn = new Hashtable();
      this.ojqxnwuNv = new Hashtable();

      this.BarFactory = (IBarFactory) new BarFactory();
      this.InitiatorMode = InitiatorMode.Single;
    }

    protected virtual void Init()
    {
      this.application = new QuickFIX42Application();
      this.sessionSettings = new SessionSettings(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1776));
      this.storeFactory = (MessageStoreFactory) new FileStoreFactory(this.sessionSettings);
      this.logFactory = (LogFactory) new FileLogFactory(this.sessionSettings);
      this.messageFactory = (MessageFactory) new DefaultMessageFactory();
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
            this.iTjfR0QTM = !this.loggingEnabled ? (Initiator) new SocketInitiator((Application) this.application, this.storeFactory, this.sessionSettings, this.messageFactory) : (Initiator) new SocketInitiator((Application) this.application, this.storeFactory, this.sessionSettings, this.logFactory, this.messageFactory);
            break;
          case InitiatorMode.Threaded:
            this.iTjfR0QTM = !this.loggingEnabled ? (Initiator) new ThreadedSocketInitiator((Application) this.application, this.storeFactory, this.sessionSettings, this.messageFactory) : (Initiator) new ThreadedSocketInitiator((Application) this.application, this.storeFactory, this.sessionSettings, this.logFactory, this.messageFactory);
            break;
        }
        this.iTjfR0QTM.start();
        this.isInitiated = true;
        this.application.Logon += new FIXLogonEventHandler(this.CPQrwXYoJ);
        this.application.Logout += new FIXLogoutEventHandler(this.qKXl1YwC8);
        this.application.SecurityDefinition += new FIXSecurityDefinitionEventHandler(this.BbGIo0Hmp);
        this.application.MarketDataSnapshot += new FIXMarketDataSnapshotEventHandler(this.hvUXgZCyf);
        this.application.ExecutionReport += new ExecutionReportEventHandler(this.pQ0g8arCK);
        this.application.OrderCancelReject += new OrderCancelRejectEventHandler(this.Q4TGKECr3);
      }
      this.application.Connect();
    }

    public virtual void Connect(int timeout)
    {
      this.Connect();
      ProviderManager.WaitConnected((IProvider) this, timeout);
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
        if (this.e4HAgJhCB == null)
          return;
        this.e4HAgJhCB(new ProviderErrorEventArgs((IProvider) this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(1836)));
      }
    }

    private void CLc6DHRyV([In] object obj0, [In] BarEventArgs obj1)
    {
      Bar bar = obj1.Bar;
      if (this.MarketDataFilter != null)
        bar = this.MarketDataFilter.FilterBar(bar, obj1.Instrument.Symbol);
      if (bar == null || this.MXBVM8t2I == null)
        return;
      this.MXBVM8t2I((object) this, new BarEventArgs(bar, obj1.Instrument, (IMarketDataProvider) this));
    }

    private void PiIiF8bRq([In] object obj0, [In] BarEventArgs obj1)
    {
      Bar bar = obj1.Bar;
      if (this.MarketDataFilter != null)
        bar = this.MarketDataFilter.FilterBarOpen(bar, obj1.Instrument.Symbol);
      if (bar == null || this.NE3HYAjK2 == null)
        return;
      this.NE3HYAjK2((object) this, new BarEventArgs(bar, obj1.Instrument, (IMarketDataProvider) this));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OZ2paKt9A([In] object obj0, [In] BarSliceEventArgs obj1)
    {
      if (this.gU7UoXKRw == null)
        return;
      this.gU7UoXKRw((object) this, new BarSliceEventArgs(obj1.BarSize, (IMarketDataProvider) this));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SendMarketDataRequest(FIXMarketDataRequest request)
    {
      if (this.IsConnected)
      {
        switch (request.SubscriptionRequestType)
        {
          case '1':
            string str1 = this.Ni08n2nTx(request.GetRelatedSymGroup(0));
            RequestRecord requestRecord1;
            if (str1 == null)
            {
              ++this.mdReqCount;
              string str2 = string.Format(BeAEwTZGlZaeOmY5cm.J00weU3cM6(1974), (object) Clock.Now, (object) this.mdReqCount);
              request.MDReqID = str2;
              requestRecord1 = new RequestRecord(request.GetRelatedSymGroup(0).Symbol, request);
              this.mdRequests.Add((object) str2, (object) requestRecord1);
              this.application.Send(request);
            }
            else
              requestRecord1 = this.mdRequests[(object) str1] as RequestRecord;
            ++requestRecord1.RequestCount;
            break;
          case '2':
            string str3 = this.Ni08n2nTx(request.GetRelatedSymGroup(0));
            if (str3 == null)
              break;
            RequestRecord requestRecord2 = this.mdRequests[(object) str3] as RequestRecord;
            --requestRecord2.RequestCount;
            if (requestRecord2.RequestCount != 0)
              break;
            request.MDReqID = str3;
            this.application.Send(request);
            this.mdRequests.Remove((object) str3);
            break;
        }
      }
      else
      {
        if (this.e4HAgJhCB == null)
          return;
        this.e4HAgJhCB(new ProviderErrorEventArgs((IProvider) this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(2032)));
      }
    }

    private string Ni08n2nTx([In] FIXRelatedSymGroup obj0)
    {
      foreach (DictionaryEntry dictionaryEntry in this.mdRequests)
      {
        if (((RequestRecord) dictionaryEntry.Value).Symbol == obj0.Symbol)
          return (string) dictionaryEntry.Key;
      }
      return (string) null;
    }

    public virtual void SendOrderStatusRequest(OrderStatusRequest request)
    {
    }

    public virtual void SendNewOrderSingle(NewOrderSingle order)
    {
      if (this.IsConnected)
      {
        this.application.Send((FIXNewOrderSingle) order);
      }
      else
      {
        ExecutionReport report = new ExecutionReport();
        report.TransactTime = Clock.Now;
        report.ClOrdID = order.ClOrdID;
        report.ExecType = SmartQuant.FIX.ExecType.Rejected;
        report.OrdStatus = SmartQuant.FIX.OrdStatus.Rejected;
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
        report.Text = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2154);
        if (this.pPOK9Nf3hf != null)
          this.pPOK9Nf3hf((object) this, new ExecutionReportEventArgs(report));
        if (this.e4HAgJhCB == null)
          return;
        this.e4HAgJhCB(new ProviderErrorEventArgs((IProvider) this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(2208)));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SendOrderCancelRequest(OrderCancelRequest request)
    {
      if (this.IsConnected)
      {
        this.application.Send((FIXOrderCancelRequest) request);
      }
      else
      {
        OrderCancelReject reject = new OrderCancelReject();
        reject.TransactTime = Clock.Now;
        reject.OrigClOrdID = request.OrigClOrdID;
        reject.ClOrdID = reject.OrigClOrdID;
        reject.CxlRejResponseTo = SmartQuant.FIX.CxlRejResponseTo.CancelRequest;
        reject.CxlRejReason = SmartQuant.FIX.CxlRejReason.BrokerOption;
        reject.OrdStatus = SmartQuant.FIX.OrdStatus.Undefined;
        reject.Text = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2302);
        if (this.B02KF0Hm96 != null)
          this.B02KF0Hm96((object) this, new OrderCancelRejectEventArgs(reject));
        if (this.e4HAgJhCB == null)
          return;
        this.e4HAgJhCB(new ProviderErrorEventArgs((IProvider) this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(2356)));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
    {
      if (this.IsConnected)
      {
        this.application.Send((FIXOrderCancelReplaceRequest) request);
      }
      else
      {
        OrderCancelReject reject = new OrderCancelReject();
        reject.TransactTime = Clock.Now;
        reject.OrigClOrdID = request.OrigClOrdID;
        reject.ClOrdID = reject.OrigClOrdID;
        reject.CxlRejResponseTo = SmartQuant.FIX.CxlRejResponseTo.CancelReplaceRequest;
        reject.CxlRejReason = SmartQuant.FIX.CxlRejReason.BrokerOption;
        reject.OrdStatus = SmartQuant.FIX.OrdStatus.Undefined;
        reject.Text = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2480);
        if (this.B02KF0Hm96 != null)
          this.B02KF0Hm96((object) this, new OrderCancelRejectEventArgs(reject));
        if (this.e4HAgJhCB == null)
          return;
        this.e4HAgJhCB(new ProviderErrorEventArgs((IProvider) this, -1, -1, BeAEwTZGlZaeOmY5cm.J00weU3cM6(2534)));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BrokerInfo GetBrokerInfo()
    {
      return new BrokerInfo();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RegisterOrder(NewOrderSingle order)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CPQrwXYoJ([In] object obj0, [In] FIXSessionIDEventArgs obj1)
    {
      this.isConnected = true;
      this.status = ProviderStatus.LoggedIn;
      if (this.a2W0G3uh5 != null)
        this.a2W0G3uh5((object) this, EventArgs.Empty);
      if (this.SsDnoMUvf == null)
        return;
      this.SsDnoMUvf((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qKXl1YwC8([In] object obj0, [In] FIXSessionIDEventArgs obj1)
    {
      if (!this.isConnected)
        return;
      this.mdRequests.Clear();
      this.isConnected = false;
      this.status = ProviderStatus.Disconnected;
      if (this.UUEcVhfVS != null)
        this.UUEcVhfVS((object) this, EventArgs.Empty);
      if (this.SsDnoMUvf == null)
        return;
      this.SsDnoMUvf((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hvUXgZCyf([In] object obj0, [In] FIXMarketDataSnapshotEventArgs obj1)
    {
      Console.WriteLine(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2674));
      FIXMarketDataSnapshot snapshotFullRefresh = obj1.MarketDataSnapshotFullRefresh;
      Instrument instrument = InstrumentManager.Instruments[(this.mdRequests[(object) snapshotFullRefresh.MDReqID] as RequestRecord).Symbol];
      Trade trade = this.nWHTWovCn[(object) instrument] as Trade;
      Quote quote = this.ojqxnwuNv[(object) instrument] as Quote;
      if (trade == null)
      {
        trade = new Trade();
        this.nWHTWovCn[(object) instrument] = (object) trade;
      }
      if (quote == null)
      {
        quote = new Quote();
        this.ojqxnwuNv[(object) instrument] = (object) quote;
      }
      bool flag1 = false;
      bool flag2 = false;
      for (int i = 0; i < snapshotFullRefresh.NoMDEntries; ++i)
      {
        FIXMDEntriesGroup mdEntriesGroup = snapshotFullRefresh.GetMDEntriesGroup(i);
        switch (mdEntriesGroup.MDEntryType)
        {
          case '0':
            if (quote.Bid != mdEntriesGroup.MDEntryPx || quote.BidSize != (int) mdEntriesGroup.MDEntrySize)
            {
              quote.DateTime = Clock.Now;
              quote.Bid = mdEntriesGroup.MDEntryPx;
              quote.BidSize = (int) mdEntriesGroup.MDEntrySize;
              flag2 = true;
              break;
            }
            else
              break;
          case '1':
            if (quote.Ask != mdEntriesGroup.MDEntryPx || quote.AskSize != (int) mdEntriesGroup.MDEntrySize)
            {
              quote.DateTime = Clock.Now;
              quote.Ask = mdEntriesGroup.MDEntryPx;
              quote.AskSize = (int) mdEntriesGroup.MDEntrySize;
              flag2 = true;
              break;
            }
            else
              break;
          case '2':
            if (trade.Price != mdEntriesGroup.MDEntryPx || trade.Size != (int) mdEntriesGroup.MDEntrySize)
            {
              trade.DateTime = Clock.Now;
              trade.Price = mdEntriesGroup.MDEntryPx;
              trade.Size = (int) mdEntriesGroup.MDEntrySize;
              flag1 = true;
              break;
            }
            else
              break;
        }
      }
      if (flag1 && this.afmKM6OC6L != null)
        this.afmKM6OC6L((object) this, new TradeEventArgs(new Trade(trade), (IFIXInstrument) instrument, (IMarketDataProvider) this));
      if (flag2 && this.C1azfVlsV != null)
        this.C1azfVlsV((object) this, new QuoteEventArgs(new Quote(quote), (IFIXInstrument) instrument, (IMarketDataProvider) this));
      if (this.yT3KaHE6As == null)
        return;
      this.yT3KaHE6As((object) this, new MarketDataSnapshotEventArgs(obj1.MarketDataSnapshotFullRefresh));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BbGIo0Hmp([In] object obj0, [In] FIXSecurityDefinitionEventArgs obj1)
    {
      if (this.lEnqW7W3N == null)
        return;
      this.lEnqW7W3N((object) this, new SecurityDefinitionEventArgs(obj1.SecurityDefinition));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pQ0g8arCK([In] object obj0, [In] ExecutionReportEventArgs obj1)
    {
      if (this.pPOK9Nf3hf == null)
        return;
      this.pPOK9Nf3hf((object) this, new ExecutionReportEventArgs(obj1.ExecutionReport));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Q4TGKECr3([In] object obj0, [In] OrderCancelRejectEventArgs obj1)
    {
      if (this.B02KF0Hm96 == null)
        return;
      this.B02KF0Hm96((object) this, new OrderCancelRejectEventArgs(obj1.OrderCancelReject));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitTrade(Trade trade, Instrument instrument)
    {
      if (this.MarketDataFilter != null)
      {
        trade = this.MarketDataFilter.FilterTrade(trade, instrument.Symbol);
        if (trade == null)
          return;
      }
      if (this.afmKM6OC6L != null)
        this.afmKM6OC6L((object) this, new TradeEventArgs(trade, (IFIXInstrument) instrument, (IMarketDataProvider) this));
      if (this.lI2B1F18m == null)
        return;
      this.lI2B1F18m.OnNewTrade((IFIXInstrument) instrument, trade);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitQuote(Quote quote, Instrument instrument)
    {
      if (this.MarketDataFilter != null)
      {
        quote = this.MarketDataFilter.FilterQuote(quote, instrument.Symbol);
        if (quote == null)
          return;
      }
      if (this.C1azfVlsV != null)
        this.C1azfVlsV((object) this, new QuoteEventArgs(quote, (IFIXInstrument) instrument, (IMarketDataProvider) this));
      if (this.lI2B1F18m == null)
        return;
      this.lI2B1F18m.OnNewQuote((IFIXInstrument) instrument, quote);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitMarketDepth(SmartQuant.Data.MarketDepth depth, Instrument instrument)
    {
      if (this.UR6KKZlmv3 == null)
        return;
      this.UR6KKZlmv3((object) this, new MarketDepthEventArgs(depth, (IFIXInstrument) instrument, (IMarketDataProvider) this));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitError(int id, int code, string message)
    {
      if (this.e4HAgJhCB == null)
        return;
      this.e4HAgJhCB(new ProviderErrorEventArgs((IProvider) this, id, code, message));
    }

    public void EmitError(string message)
    {
      this.EmitError(-1, -1, message);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitOrderCancelReject(OrderCancelReject reject)
    {
      if (this.B02KF0Hm96 == null)
        return;
      this.B02KF0Hm96((object) this, new OrderCancelRejectEventArgs(reject));
    }
  }
}
