using QuickFix;
using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.FIXApplication;
using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;

namespace FreeQuant.QUIK
{
  public class QUIKFIX : QuickFIX42Provider
  {
    private const string oFOKbLCYC = "Session";
    private const string IkE43uFV1 = "Execution";
    private const string UoEwLot3R = "Market Data";
    private const bool oNNAmR5vG = false;
    private const string wTEanBEfK = "00:00:00";
    private const string u1O8Emhwb = "00:00:00";
    private const bool e1ZOhbO79 = false;
    private const bool zX4hREXAo = false;
    private const bool THPg0SqgD = false;
    private const bool aZtbvIrus = false;
    private const bool zOan0bdWY = true;
    private const string EJZBxKCsa = "00:02:00";
    private const string MEKCF78d0 = "00:00:30";
    private const string jjJdaATyg = "00:00:20";
    private const string hKurNrUxM = "localhost";
    private const uint TGl37GANS = 0U;
    private const int wtuJIgopy = 0;
    private const string dciNQdItQ = "ConnectionType";
    private const string yf7LsHH3W = "StartTime";
    private const string fvbZZ3uCR = "EndTime";
    private const string NQ8cEocFO = "SendRedundantResendRequests";
    private const string jDTQkEdlm = "ResetOnLogout";
    private const string WDixZYtPs = "ResetOnDisconnect";
    private const string QsktxXkGo = "RefreshOnLogon";
    private const string drq7wmiXB = "DataDictionary";
    private const string NkfHQkUOe = "CheckLatency";
    private const string vVdsG7v9J = "MaxLatency";
    private const string jrEIswrvc = "ReconnectInterval";
    private const string jeR13YWS8 = "HeartBtInt";
    private const string al4m984UY = "SocketConnectPort";
    private const string qN4TkhQ8Q = "SocketConnectHost";
    private const string nO8VINWHP = "PersistMessages";
    private const string c6VfHhZA2 = "FileStorePath";
    private const string opfDMM56S = "FileLogPath";

    public override byte Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (byte) 31;
      }
    }

    public override string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return nvcneRd3YWS84l4984.Ey6KSwFglw(162);
      }
    }

    public override string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Name;
      }
    }

    public override string URL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return nvcneRd3YWS84l4984.Ey6KSwFglw(182);
      }
    }

    [Description("Directory to store logs")]
    [Category("Message Logging")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    public string FileLogPath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [Category("Message Logging")]
    [Description("Directory to store backup logs")]
    public string FileLogBackupPath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Message Storage")]
    [Description("If set to N, no messages will be persisted. This will force QuickFIX to always send GapFills instead of resending messages")]
    [DefaultValue(false)]
    public bool PersistMessages { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [Description("Directory to store sequence number and message files")]
    [Category("Message Storage")]
    public string FileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session")]
    [DefaultValue(typeof (TimeSpan), "00:00:00")]
    [Description("Time of day that this FIX session becomes activated")]
    public TimeSpan StartTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(typeof (TimeSpan), "00:00:00")]
    [Category("Session")]
    [Description("Time of day that this FIX session becomes deactivated")]
    public TimeSpan EndTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("If set to true, QuickFIX will send all necessary resend requests, even if they appear redundant")]
    [DefaultValue(false)]
    [Category("Session")]
    public bool SendRedundantResendRequests { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Description("Determines if sequence numbers should be reset to 1 after a normal logout termination")]
    [Category("Session")]
    public bool ResetOnLogout { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session")]
    [Description("Determines if sequence numbers should be reset to 1 after an abnormal termination")]
    [DefaultValue(false)]
    public bool ResetOnDisconnect { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Description("Determines if session state should be restored from persistence layer when logging on")]
    [Category("Session")]
    public bool RefreshOnLogon { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("XML definition file for validating incoming FIX messages")]
    [Editor(typeof (FileNameEditor), typeof (UITypeEditor))]
    [Category("Session")]
    public string DataDictionary { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("If set to Y, messages must be received from the counterparty within a defined number of seconds (see MaxLatency)")]
    [DefaultValue(true)]
    [Category("Session")]
    public bool CheckLatency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session")]
    [DefaultValue(typeof (TimeSpan), "00:02:00")]
    [Description("If CheckLatency is set to Y, this defines the number of seconds latency allowed for a message to be processed")]
    public TimeSpan MaxLatency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(typeof (TimeSpan), "00:00:30")]
    [Description("Time between reconnection attempts")]
    [Category("Session")]
    public TimeSpan ReconnectInterval { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(typeof (TimeSpan), "00:00:20")]
    [Description("Heartbeat interval")]
    [Category("Session")]
    public TimeSpan HeartBtInt { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session")]
    [Description("Host to connect to")]
    [DefaultValue("localhost")]
    public string SocketConnectHost { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session")]
    [Description("Socket port for connecting to a session")]
    [DefaultValue(0L)]
    public uint SocketConnectPort { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Your ID as associated with this FIX session")]
    [Category("Session")]
    public string SenderCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session")]
    [Description("Counter parties ID as associated with this FIX session")]
    public string TargetCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Execution")]
    public string DefaultAccount { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Execution")]
    public string DefaultClientID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(0)]
    [Category("Market Data")]
    public int MarketDepth { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QUIKFIX()
    {
      he1DlExnKSyvVxIfFh.qrl8YBDzYVm38();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.FileLogPath = Framework.Installation.LogDir.FullName;
      this.FileLogBackupPath = Framework.Installation.LogDir.FullName;
      this.PersistMessages = false;
      this.FileStorePath = Framework.Installation.LogDir.FullName;
      this.StartTime = TimeSpan.Parse(nvcneRd3YWS84l4984.Ey6KSwFglw(0));
      this.EndTime = TimeSpan.Parse(nvcneRd3YWS84l4984.Ey6KSwFglw(20));
      this.SendRedundantResendRequests = false;
      this.ResetOnLogout = false;
      this.ResetOnDisconnect = false;
      this.RefreshOnLogon = false;
      this.DataDictionary = string.Format(nvcneRd3YWS84l4984.Ey6KSwFglw(40), (object) Framework.Installation.FIXDir.FullName);
      this.CheckLatency = true;
      this.MaxLatency = TimeSpan.Parse(nvcneRd3YWS84l4984.Ey6KSwFglw(80));
      this.ReconnectInterval = TimeSpan.Parse(nvcneRd3YWS84l4984.Ey6KSwFglw(100));
      this.HeartBtInt = TimeSpan.Parse(nvcneRd3YWS84l4984.Ey6KSwFglw(120));
      this.SocketConnectHost = nvcneRd3YWS84l4984.Ey6KSwFglw(140);
      this.SocketConnectPort = 0U;
      this.SenderCompID = string.Empty;
      this.TargetCompID = string.Empty;
      this.DefaultAccount = string.Empty;
      this.DefaultClientID = string.Empty;
      this.MarketDepth = 0;
      ProviderManager.Add((IProvider) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      Dictionary defaults = new Dictionary();
      defaults.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(222), nvcneRd3YWS84l4984.Ey6KSwFglw(254));
      defaults.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(276), this.StartTime.ToString());
      defaults.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(298), this.EndTime.ToString());
      defaults.setBool(nvcneRd3YWS84l4984.Ey6KSwFglw(316), this.SendRedundantResendRequests);
      defaults.setBool(nvcneRd3YWS84l4984.Ey6KSwFglw(374), this.ResetOnLogout);
      defaults.setBool(nvcneRd3YWS84l4984.Ey6KSwFglw(404), this.ResetOnDisconnect);
      defaults.setBool(nvcneRd3YWS84l4984.Ey6KSwFglw(442), this.RefreshOnLogon);
      defaults.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(474), this.DataDictionary);
      defaults.setBool(nvcneRd3YWS84l4984.Ey6KSwFglw(506), this.CheckLatency);
      defaults.setLong(nvcneRd3YWS84l4984.Ey6KSwFglw(534), (int) this.MaxLatency.TotalSeconds);
      defaults.setLong(nvcneRd3YWS84l4984.Ey6KSwFglw(558), (int) this.ReconnectInterval.TotalSeconds);
      defaults.setLong(nvcneRd3YWS84l4984.Ey6KSwFglw(596), (int) this.HeartBtInt.TotalSeconds);
      defaults.setBool(nvcneRd3YWS84l4984.Ey6KSwFglw(620), this.PersistMessages);
      if (this.PersistMessages)
        defaults.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(654), this.FileStorePath);
      if (this.LoggingEnabled)
        defaults.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(684), this.FileLogPath);
      Dictionary settings = new Dictionary();
      settings.setString(nvcneRd3YWS84l4984.Ey6KSwFglw(710), this.SocketConnectHost);
      settings.setLong(nvcneRd3YWS84l4984.Ey6KSwFglw(748), (int) this.SocketConnectPort);
      SessionID sessionID = new SessionID(nvcneRd3YWS84l4984.Ey6KSwFglw(786), this.SenderCompID, this.TargetCompID);
      this.sessionSettings = new SessionSettings();
      this.sessionSettings.set(defaults);
      this.sessionSettings.set(sessionID, settings);
      this.storeFactory = this.PersistMessages ? (MessageStoreFactory) new FileStoreFactory(this.sessionSettings) : (MessageStoreFactory) new MemoryStoreFactory();
      this.logFactory = this.LoggingEnabled ? (LogFactory) new FileLogFactory(this.sessionSettings) : (LogFactory) new NullLogFactory();
      this.messageFactory = (MessageFactory) new DefaultMessageFactory();
      this.application = (QuickFIX42Application) new mWYFJZ8xKCsaXEKF78(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SendMarketDataRequest(FIXMarketDataRequest request)
    {
      if (this.IsConnected)
        this.application.Send(request);
      else
        this.EmitError(nvcneRd3YWS84l4984.Ey6KSwFglw(804));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SendNewOrderSingle(NewOrderSingle order)
    {
      if (!order.ContainsField(1) && !string.IsNullOrWhiteSpace(this.DefaultAccount))
        order.Account = this.DefaultAccount.Trim();
      if (!order.ContainsField(109) && !string.IsNullOrWhiteSpace(this.DefaultClientID))
        order.SetStringValue(109, this.DefaultClientID.Trim());
      base.SendNewOrderSingle(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
    {
      if (!request.ContainsField(1) && !string.IsNullOrWhiteSpace(this.DefaultAccount))
        request.Account = this.DefaultAccount.Trim();
      if (!request.ContainsField(109) && !string.IsNullOrWhiteSpace(this.DefaultClientID))
        request.SetStringValue(109, this.DefaultClientID.Trim());
      base.SendOrderCancelReplaceRequest(request);
    }
  }
}
