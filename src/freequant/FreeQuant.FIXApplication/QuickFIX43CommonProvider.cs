// Type: SmartQuant.FIXApplication.QuickFIX43CommonProvider
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

namespace FreeQuant.FIXApplication
{
  public abstract class QuickFIX43CommonProvider : QuickFIX43Provider
  {
    protected const string CATEGORY_SESSION_DEFAULTS = "Session Settings (Defaults)";
    protected const string CATEGORY_SESSION_PRICE = "Session Settings (Price)";
    protected const string CATEGORY_SESSION_ORDER = "Session Settings (Order)";
    private const int pf24GFgvWc = 20;
    private const string uxk4kGoT1P = "0";
    private const string mQb457W4HY = "0";
    private const int oqT4bVtFY4 = 30;
    private const string Dpa4jtg25I = "FIX.4.3";
    private const string Fq04BoKuky = "FIX43.xml";
    private const string hGa4fpBuxf = "";
    private const string E1k4TJGo8G = "";
    private const bool Qx44x7XiuM = false;
    private const int Kjy40P42jD = 120;
    private const bool U3Q4ci5eND = false;
    private const bool X5l4n46Kvo = false;
    private const bool fVo4AQ9S7T = true;
    private const string GqZ4qaVuaT = "";
    private const string U4h4sPk4QU = "";
    private const string J6h4DRoQ81 = "localhost";
    private const int rw94VyXn2q = 0;
    private const string CZO4HKpyh4 = "";
    private const bool dr34UOuPfX = true;
    private const string R0X43CdEwa = "";
    private const string aZg4zrSSYM = "";
    private const string MPfwMAI5oP = "localhost";
    private const int hJKwKfiymm = 0;
    private const string K0Uw4REfh4 = "";
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
    protected const string KEY_SOCKET_CONNECT_HOST = "SocketConnectHost";
    protected const string KEY_SOCKET_CONNECT_PORT = "SocketConnectPort";
    private const string xtJwwAvHUD = "initiator";

    [DefaultValue(20)]
    [Category("Session Settings (Defaults)")]
    [Description("Heartbeat interval in seconds")]
    public int HeartBtInt { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Time of day that this FIX session becomes activated")]
    [Category("Session Settings (Defaults)")]
    [DefaultValue(typeof (TimeSpan), "0")]
    public TimeSpan StartTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Defaults)")]
    [Description("Time of day that this FIX session becomes deactivated")]
    [DefaultValue(typeof (TimeSpan), "0")]
    public TimeSpan EndTime { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Defaults)")]
    [Description("Time between reconnection attempts in seconds")]
    [DefaultValue(30)]
    public int ReconnectInterval { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Defaults)")]
    [DefaultValue("FIX.4.3")]
    [Description("Version of FIX this session should use")]
    public string BeginString { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("XML definition file for validating incoming FIX messages. If no DataDictionary is supplied, only basic message validation will be done")]
    [DefaultValue("FIX43.xml")]
    [Category("Session Settings (Defaults)")]
    [Editor(typeof (FileNameEditor), typeof (UITypeEditor))]
    public string DataDictionary { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Defaults)")]
    [DefaultValue("")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [Description("Directory to store sequence number and message files. Only used with FileStoreFactory.")]
    public string FileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Directory to store logs. Only used with FileLogFactory.")]
    [DefaultValue("")]
    [Category("Session Settings (Defaults)")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    public string FileLogPath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Category("Session Settings (Defaults)")]
    [Description("If set to TRUE, messages must be received from the counterparty within a defined number of seconds (see MaxLatency). It is useful to turn this off if a system uses localtime for it's timestamps instead of GMT")]
    public bool CheckLatency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Defaults)")]
    [DefaultValue(120)]
    [Description("If CheckLatency is set to Y, this defines the number of seconds latency allowed for a message to be processed")]
    public int MaxLatency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Description("Determines if sequence numbers should be reset to 1 after a normal logout termination")]
    [Category("Session Settings (Defaults)")]
    public bool ResetOnLogout { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue(false)]
    [Category("Session Settings (Defaults)")]
    [Description("Determines if sequence numbers should be reset to 1 after an abnormal termination")]
    public bool ResetOnDisconnect { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Enable or disable this session")]
    [DefaultValue(true)]
    [Category("Session Settings (Price)")]
    [DisplayName("Enabled")]
    public bool PriceSessionEnabled { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue("")]
    [Category("Session Settings (Price)")]
    [DisplayName("SenderCompID")]
    [Description("Your ID as associated with this FIX session")]
    public string PriceSenderCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("TargetCompID")]
    [DefaultValue("")]
    [Description("Counter parties ID as associated with this FIX session")]
    [Category("Session Settings (Price)")]
    public string PriceTargetCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Host to connect to")]
    [DisplayName("SocketConnectHost")]
    [DefaultValue("localhost")]
    [Category("Session Settings (Price)")]
    public string PriceSocketConnectHost { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Socket port for connecting to a session")]
    [DisplayName("SocketConnectPort")]
    [Category("Session Settings (Price)")]
    [DefaultValue(0)]
    public int PriceSocketConnectPort { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Description("Directory to store sequence number and message files. Only used with FileStoreFactory.")]
    [DefaultValue("")]
    [DisplayName("FileStorePath")]
    [Category("Session Settings (Price)")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    public string PriceFileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("Enabled")]
    [Category("Session Settings (Order)")]
    [DefaultValue(true)]
    [Description("Enable or disable this session")]
    public bool OrderSessionEnabled { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Order)")]
    [DefaultValue("")]
    [DisplayName("SenderCompID")]
    [Description("Your ID as associated with this FIX session")]
    public string OrderSenderCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Order)")]
    [DefaultValue("")]
    [DisplayName("TargetCompID")]
    [Description("Counter parties ID as associated with this FIX session")]
    public string OrderTargetCompID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DefaultValue("localhost")]
    [Category("Session Settings (Order)")]
    [DisplayName("SocketConnectHost")]
    [Description("Host to connect to")]
    public string OrderSocketConnectHost { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [DisplayName("SocketConnectPort")]
    [DefaultValue(0)]
    [Description("Socket port for connecting to a session")]
    [Category("Session Settings (Order)")]
    public int OrderSocketConnectPort { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Category("Session Settings (Order)")]
    [DefaultValue("")]
    [Description("Directory to store sequence number and message files. Only used with FileStoreFactory.")]
    [Editor(typeof (FolderNameEditor), typeof (UITypeEditor))]
    [DisplayName("FileStorePath")]
    public string OrderFileStorePath { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected QuickFIX43CommonProvider()
    {
      Ni0n2nNTxpPQwXYoJS.cvl3IaMzFxY5E();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.HeartBtInt = 20;
      this.StartTime = TimeSpan.Parse(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4586));
      this.EndTime = TimeSpan.Parse(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4592));
      this.ReconnectInterval = 30;
      this.BeginString = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4598);
      this.DataDictionary = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4616);
      this.FileStorePath = "";
      this.FileLogPath = "";
      this.CheckLatency = false;
      this.MaxLatency = 120;
      this.ResetOnLogout = false;
      this.ResetOnDisconnect = false;
      this.PriceSessionEnabled = true;
      this.PriceSenderCompID = "";
      this.PriceTargetCompID = "";
      this.PriceSocketConnectHost = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4638);
      this.PriceSocketConnectPort = 0;
      this.PriceFileStorePath = "";
      this.OrderSessionEnabled = true;
      this.OrderSenderCompID = "";
      this.OrderTargetCompID = "";
      this.OrderSocketConnectHost = BeAEwTZGlZaeOmY5cm.J00weU3cM6(4660);
      this.OrderSocketConnectPort = 0;
      this.OrderFileStorePath = "";
    }

    protected abstract QuickFIX43CommonApplication CreateApplicationInstance();

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
      this.application = (QuickFIX43Application) this.CreateApplicationInstance();
      Dictionary dictionary = new Dictionary();
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4682), BeAEwTZGlZaeOmY5cm.J00weU3cM6(4714));
      dictionary.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4736), this.HeartBtInt);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4760), this.StartTime.ToString());
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4782), this.EndTime.ToString());
      dictionary.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4800), this.ReconnectInterval);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4838), this.BeginString);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4864), this.DataDictionary);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4896), this.FileStorePath);
      dictionary.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4926), this.FileLogPath);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4952), this.CheckLatency);
      dictionary.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(4980), this.MaxLatency);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5004), this.ResetOnLogout);
      dictionary.setBool(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5034), this.ResetOnDisconnect);
      this.OnDefaultsSessionSettingsCreated(dictionary);
      Dictionary settings1 = (Dictionary) null;
      if (this.PriceSessionEnabled)
      {
        settings1 = new Dictionary();
        settings1.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5072), this.PriceSocketConnectHost);
        settings1.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5110), this.PriceSocketConnectPort);
        settings1.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5148), this.PriceFileStorePath);
        this.OnPriceSessionSettingsCreated(settings1);
      }
      Dictionary settings2 = (Dictionary) null;
      if (this.OrderSessionEnabled)
      {
        settings2 = new Dictionary();
        settings2.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5178), this.OrderSocketConnectHost);
        settings2.setLong(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5216), this.OrderSocketConnectPort);
        settings2.setString(BeAEwTZGlZaeOmY5cm.J00weU3cM6(5254), this.OrderFileStorePath);
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
      (this.application as QuickFIX43CommonApplication).zWmEpDbll(sessionID1, sessionID2);
    }
  }
}
