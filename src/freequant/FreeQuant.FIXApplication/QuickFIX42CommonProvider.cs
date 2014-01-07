// Type: SmartQuant.FIXApplication.QuickFIX42CommonProvider
// Assembly: SmartQuant.FIXApplication, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 44426555-807E-4D6E-87F0-79C6A497EF45
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIXApplication.dll

using aX1YwCE8tvUgZCyfib;
using QuickFix;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;
using zWmpDbtlldCIky2Q1f;

namespace SmartQuant.FIXApplication
{
  public abstract class QuickFIX42CommonProvider : QuickFIX42Provider
  {
    protected const string CATEGORY_SESSION_DEFAULTS = "Session Settings (Defaults)";
    protected const string CATEGORY_SESSION_PRICE = "Session Settings (Price)";
    protected const string CATEGORY_SESSION_ORDER = "Session Settings (Order)";
    private const int qiVKtq7I3I = 20;
    private const string oKgKCQ13Gs = "0";
    private const string DrmKmks3EW = "0";
    private const int muoKhxV9OU = 30;
    private const string Di8Kd4afU6 = "FIX.4.2";
    private const string e38KyPwIRl = "FIX42.xml";
    private const string xnWKJfHVnA = "";
    private const string pxXKP7pPqK = "";
    private const bool ic0KNpknHt = false;
    private const int iHvKE2iWkC = 120;
    private const bool O8KKSNbHuM = false;
    private const bool vmUKQci7gn = false;
    private const bool PudKogy0Zj = false;
    private const bool KFnKvdXwSF = false;
    private const bool mu4KWumvWP = false;
    private const bool B5UK2cgRRg = true;
    private const string cbAKRXttyF = "";
    private const string v9QK7j2EVd = "";
    private const string y9lKYxSt24 = "localhost";
    private const int UEtKuAbI2X = 0;
    private const string WrZKL8sn6E = "";
    private const bool IVDK1nM5Zf = true;
    private const string eK5KeyjRoK = "";
    private const string xP1K6X4hSu = "";
    private const string rhwKigRFDB = "localhost";
    private const int gAeKprx6MB = 0;
    private const string RanK8BXHEM = "";
    protected const string KEY_HEART_BT_INT = "HeartBtInt";
    protected const string KEY_CONNECTION_TYPE = "ConnectionType";
    protected const string KEY_START_TIME = "StartTime";
    protected const string KEY_END_TIME = "EndTime";
    protected const string KEY_RECONNECT_INTERVAL = "ReconnectInterval";
    protected const string KEY_BEGIN_STRING = "BeginString";
    protected const string KEY_DATA_DICTIONARY = "DataDictionary";
    protected const string KEY_FILE_STORE_PATH = "FileStorePath";
    protected const string KEY_FILE_LOG_PATH = "FileLogPath";
    protected const string KEY_CHECK_LATENCY = "CheckLatency";
    protected const string KEY_MAX_LATENCY = "MaxLatency";
    protected const string KEY_RESET_ON_LOGOUT = "ResetOnLogout";
    protected const string KEY_RESET_ON_DISCONNECT = "ResetOnDisconnect";
    protected const string KEY_REFRESH_ON_LOGON = "RefreshOnLogon";
    protected const string KEY_SOCKET_CONNECT_HOST = "SocketConnectHost";
    protected const string KEY_SOCKET_CONNECT_PORT = "SocketConnectPort";
    protected const string KEY_SOCKET_NODELAY = "SocketNodelay";
    protected const string KEY_SEND_REDUNDANT_RESEND_REQUESTS = "SendRedundantResendRequests";
    private const string utJKrdeJT7 = "initiator";

    [Category("Session Settings (Defaults)")]
    [Description("Heartbeat interval in seconds")]
    [DefaultValue(20)]
    public int HeartBtInt { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Time of day that this FIX session becomes activated")]
    [DefaultValue(typeof (TimeSpan), "0")]
    [Category("Session Settings (Defaults)")]
    public TimeSpan StartTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Time of day that this FIX session becomes deactivated")]
    [Category("Session Settings (Defaults)")]
    [DefaultValue(typeof (TimeSpan), "0")]
    public TimeSpan EndTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(30)]
    [Description("Time between reconnection attempts in seconds")]
    [Category("Session Settings (Defaults)")]
    public int ReconnectInterval { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue("FIX.4.2")]
    [Category("Session Settings (Defaults)")]
    [Description("Version of FIX this session should use")]
    public string BeginString { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("XML definition file for validating incoming FIX messages. If no DataDictionary is supplied, only basic message validation will be done")]
    [DefaultValue("FIX42.xml")]
    [Category("Session Settings (Defaults)")]
    [Editor(typeof (FileNameEditor), typeof (UITypeEditor))]
    public string DataDictionary { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue("")]
    [Category("Session Settings (Defaults)")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [Description("Directory to store sequence number and message files. Only used with FileStoreFactory.")]
    public string FileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Directory to store logs. Only used with FileLogFactory.")]
    [Category("Session Settings (Defaults)")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [DefaultValue("")]
    public string FileLogPath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("If set to TRUE, messages must be received from the counterparty within a defined number of seconds (see MaxLatency). It is useful to turn this off if a system uses localtime for it's timestamps instead of GMT")]
    [DefaultValue(false)]
    [Category("Session Settings (Defaults)")]
    public bool CheckLatency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("If CheckLatency is set to Y, this defines the number of seconds latency allowed for a message to be processed")]
    [DefaultValue(120)]
    [Category("Session Settings (Defaults)")]
    public int MaxLatency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("If set to true, QuickFIX will send all necessary resend requests, even if they appear redundant")]
    [DefaultValue(false)]
    [Category("Session Settings (Defaults)")]
    public bool SendRedundantResendRequests { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Determines if sequence numbers should be reset to 1 after a normal logout termination")]
    [Category("Session Settings (Defaults)")]
    [DefaultValue(false)]
    public bool ResetOnLogout { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Defaults)")]
    [Description("Determines if sequence numbers should be reset to 1 after an abnormal termination")]
    [DefaultValue(false)]
    public bool ResetOnDisconnect { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Category("Session Settings (Defaults)")]
    [Description("Determines if session state should be restored from persistence layer when logging on")]
    public bool RefreshOnLogon { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Determines if a socket should be created with TCP_NODELAY")]
    [Category("Session Settings (Defaults)")]
    [DefaultValue(false)]
    public bool TcpNoDelay { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(true)]
    [DisplayName("Enabled")]
    [Description("Enable or disable this session")]
    [Category("Session Settings (Price)")]
    public bool PriceSessionEnabled { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Price)")]
    [DefaultValue("")]
    [DisplayName("SenderCompID")]
    [Description("Your ID as associated with this FIX session")]
    public string PriceSenderCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("TargetCompID")]
    [Description("Counter parties ID as associated with this FIX session")]
    [Category("Session Settings (Price)")]
    [DefaultValue("")]
    public string PriceTargetCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Host to connect to")]
    [Category("Session Settings (Price)")]
    [DisplayName("SocketConnectHost")]
    [DefaultValue("localhost")]
    public string PriceSocketConnectHost { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Price)")]
    [DisplayName("SocketConnectPort")]
    [Description("Socket port for connecting to a session")]
    [DefaultValue(0)]
    public int PriceSocketConnectPort { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [Description("Directory to store sequence number and message files. Only used with FileStoreFactory.")]
    [Category("Session Settings (Price)")]
    [DefaultValue("")]
    [DisplayName("FileStorePath")]
    public string PriceFileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Order)")]
    [Description("Enable or disable this session")]
    [DefaultValue(true)]
    [DisplayName("Enabled")]
    public bool OrderSessionEnabled { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue("")]
    [DisplayName("SenderCompID")]
    [Category("Session Settings (Order)")]
    [Description("Your ID as associated with this FIX session")]
    public string OrderSenderCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("TargetCompID")]
    [Description("Counter parties ID as associated with this FIX session")]
    [DefaultValue("")]
    [Category("Session Settings (Order)")]
    public string OrderTargetCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("SocketConnectHost")]
    [DefaultValue("localhost")]
    [Category("Session Settings (Order)")]
    [Description("Host to connect to")]
    public string OrderSocketConnectHost { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("SocketConnectPort")]
    [DefaultValue(0)]
    [Category("Session Settings (Order)")]
    [Description("Socket port for connecting to a session")]
    public int OrderSocketConnectPort { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("FileStorePath")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [Description("Directory to store sequence number and message files. Only used with FileStoreFactory.")]
    [DefaultValue("")]
    [Category("Session Settings (Order)")]
    public string OrderFileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected QuickFIX42CommonProvider()
    {
      Ni0n2nNTxpPQwXYoJS.cvl3IaMzFxY5E();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.HeartBtInt = 20;
      this.StartTime = TimeSpan.Parse(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2724));
      this.EndTime = TimeSpan.Parse(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2730));
      this.ReconnectInterval = 30;
      this.BeginString = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2736);
      this.DataDictionary = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2754);
      this.FileStorePath = "";
      this.FileLogPath = "";
      this.CheckLatency = false;
      this.MaxLatency = 120;
      this.ResetOnLogout = false;
      this.ResetOnDisconnect = false;
      this.RefreshOnLogon = false;
      this.SendRedundantResendRequests = false;
      this.PriceSessionEnabled = true;
      this.PriceSenderCompID = "";
      this.PriceTargetCompID = "";
      this.PriceSocketConnectHost = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2776);
      this.PriceSocketConnectPort = 0;
      this.PriceFileStorePath = "";
      this.OrderSessionEnabled = true;
      this.OrderSenderCompID = "";
      this.OrderTargetCompID = "";
      this.OrderSocketConnectHost = BeAEwTZGlZaeOmY5cm.J00weU3cM6(2798);
      this.OrderSocketConnectPort = 0;
      this.OrderFileStorePath = "";
    }

    protected abstract QuickFIX42CommonApplication CreateApplicationInstance();

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDefaultsSessionSettingsCreated(Dictionary settings)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPriceSessionSettingsCreated(Dictionary settings)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnOrderSessionSettingsCreated(Dictionary settings)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.application = (QuickFIX42Application) this.CreateApplicationInstance();
      Dictionary dictionary = new Dictionary();
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2820), BeAEwTZGlZaeOmY5cm.J00weU3cM6(2852));
      dictionary.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2874), this.HeartBtInt);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2898), this.StartTime.ToString());
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2920), this.EndTime.ToString());
      dictionary.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2938), this.ReconnectInterval);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(2976), this.BeginString);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3002), this.DataDictionary);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3034), this.FileStorePath);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3064), this.FileLogPath);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3090), this.CheckLatency);
      dictionary.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3118), this.MaxLatency);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3142), this.SendRedundantResendRequests);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3200), this.ResetOnLogout);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3230), this.ResetOnDisconnect);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3268), this.RefreshOnLogon);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3300), this.TcpNoDelay);
      this.OnDefaultsSessionSettingsCreated(dictionary);
      Dictionary settings1 = (Dictionary) null;
      if (this.PriceSessionEnabled)
      {
        settings1 = new Dictionary();
        settings1.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3330), this.PriceSocketConnectHost);
        settings1.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3368), this.PriceSocketConnectPort);
        settings1.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3406), this.PriceFileStorePath);
        this.OnPriceSessionSettingsCreated(settings1);
      }
      Dictionary settings2 = (Dictionary) null;
      if (this.OrderSessionEnabled)
      {
        settings2 = new Dictionary();
        settings2.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3436), this.OrderSocketConnectHost);
        settings2.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3474), this.OrderSocketConnectPort);
        settings2.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(3512), this.OrderFileStorePath);
        this.OnOrderSessionSettingsCreated(settings2);
      }
      SessionID sessionID1 = this.PriceSessionEnabled ? new SessionID(this.BeginString, this.PriceSenderCompID, this.PriceTargetCompID) : (SessionID) null;
      SessionID sessionID2 = this.OrderSessionEnabled ? new SessionID(this.BeginString, this.OrderSenderCompID, this.OrderTargetCompID) : (SessionID) null;
      this.sessionSettings = new SessionSettings();
      this.sessionSettings.set(dictionary);
      if (this.PriceSessionEnabled)
        this.sessionSettings.set(sessionID1, settings1);
      if (this.OrderSessionEnabled)
        this.sessionSettings.set(sessionID2, settings2);
      this.storeFactory = (MessageStoreFactory) new FileStoreFactory(this.sessionSettings);
      this.logFactory = (LogFactory) new FileLogFactory(this.sessionSettings);
      this.messageFactory = (MessageFactory) new DefaultMessageFactory();
      (this.application as QuickFIX42CommonApplication).adf1ZbrcY(sessionID1, sessionID2);
    }
  }
}
