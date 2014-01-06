// Type: OpenQuant.Finam.Transaq
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using OpenQuant.API;
using OpenQuant.API.Plugins;
using OpenQuant.Finam.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Threading;
using System.Xml;

namespace OpenQuant.Finam
{
  public class Transaq : UserProvider
  {
    private const string CATEGORY_ACCOUNT = "Account";
    private const string CATEGORY_LOGGING = "Logging";
    private const string CATEGORY_CONNECTION = "Connection";
    private const string CATEGORY_SESSION = "Session";
    private const string CATEGORY_PROXY = "Proxy";
    private const DllSelector DEFAULT_DLLSELECTOR = DllSelector.txmlconnector_dll;
    private const SecuritySelector DEFAULT_SECURITYSELECTOR = SecuritySelector.seccode;
    private const string DEFAULT_HOST = "127.0.0.1";
    private const int DEFAULT_PORT = 0;
    private const string DEFAULT_USERNAME = "";
    private const string DEFAULT_PASSWORD = "";
    private const string DEFAULT_LOGLEVELCONN = "0";
    private const string DEFAULT_LOGLEVELINIT = "2";
    private const int DEFAULT_RQDELAY = 100;
    private const bool DEFAULT_MICEX_REGISTERS = false;
    private const int DEFAULT_SESSION_TIMEOUT = 120;
    private const int DEFAULT_REQUEST_TIMEOUT = 20;
    private const string DEFAULT_PROXYUSING = "";
    private const string DEFAULT_PROXYTYPE = "";
    private const string DEFAULT_PROXYHOST = "";
    private const int DEFAULT_PROXYPORT = 0;
    private const string DEFAULT_PROXYUSERNAME = "";
    private const string DEFAULT_PROXYPASSWORD = "";
    private DllSelector selectedDll;
    private SecuritySelector selectedSecurity;
    private string host;
    private int port;
    private string username;
    public string proxyUsing;
    public string proxyType;
    private string proxyHost;
    private int proxyPort;
    private string proxyUsername;
    private string proxyPassword;
    private string logLevelConn;
    private string logLevelInit;
    private int rqdelay;
    private bool micexRegisters;
    private int sessionTimeout;
    private int requestTimeout;
    private bool isInitialize;
    private ITransaqConnector connector;
    private TransaqPositions positions;
    private Dictionary<int, TransaqMarket> marketById;
    private Dictionary<string, TransaqBoard> boardById;
    private Dictionary<long, TransaqCandleKind> candleKindByPeriod;
    private Dictionary<string, Instrument> instrumentBySymbol;
    private Dictionary<int, TransaqSecurity> securityBySecId;
    private Dictionary<string, TransaqSecurity> securityBySCB;
    private Dictionary<int, DateTime> tickEndTimeBySecId;
    private Dictionary<string, DateTime> tickEndTimeBySCB;
    private Dictionary<int, HistoricalDataRequest> hdrBySecId;
    private Dictionary<string, HistoricalDataRequest> hdrBySCB;
    private Dictionary<int, OpenBook> openBookBySecId;
    private Dictionary<string, OpenBook> openBookBySCB;
    private Dictionary<int, BidOfferPair> bidOfferPairBySecId;
    private Dictionary<string, BidOfferPair> bidOfferPairBySCB;
    private ReaderWriterLockSlim rwClientById;
    private ReaderWriterLockSlim rwClientLimits;
    private Dictionary<string, TransaqClient> clientById;
    private Dictionary<string, TransaqClientLimit> clientLimits;
    private Dictionary<string, BrokerAccount> brokerAccountByClientId;
    private ReaderWriterLockSlim rwOrderByOrdId;
    private ReaderWriterLockSlim rwOrderByOrdNo;
    private ReaderWriterLockSlim rwTransaqOrderByTrId;
    private ReaderWriterLockSlim rwTransaqStopOrderByTrId;
    private Dictionary<string, Order> orderByOrdId;
    private Dictionary<long, Order> orderByOrdNo;
    private Dictionary<long, TransaqOrder> transaqOrderByTrId;
    private Dictionary<long, TransaqStopOrder> transaqStopOrderByTrId;
    private Dictionary<long, object> clientTradeNo;
    private Dictionary<long, double> balanceByOrderNoForCancel;

    [Editor(typeof (AccountSelectorEditor), typeof (UITypeEditor))]
    [Category("Account")]
    public string DefaultAccount { get; set; }

    [Description("Click ellipse(...) to view available instruments")]
    [Category("Session")]
    [Editor(typeof (SessionDataTypeEditor), typeof (UITypeEditor))]
    public object SessionData
    {
      get
      {
        return (object) null;
      }
    }

    [Editor(typeof (FileBrowserTypeEditor), typeof (UITypeEditor))]
    [Category("Logging")]
    public string LogFilesDir { get; set; }

    [Description("LogLevelInit must be 1, 2 or 3")]
    [DefaultValue("2")]
    [Category("Logging")]
    public string LogLevelInit
    {
      get
      {
        return this.logLevelInit;
      }
      set
      {
        if (!(value == "1") && !(value == "2") && !(value == "3"))
          return;
        this.logLevelInit = value;
      }
    }

    [DefaultValue("0")]
    [Description("LogLevelConn must be 0, 1 or 2")]
    [Category("Logging")]
    public string LogLevelConn
    {
      get
      {
        return this.logLevelConn;
      }
      set
      {
        if (!(value == "0") && !(value == "1") && !(value == "2"))
          return;
        this.logLevelConn = value;
      }
    }

    [Description("Output error in \"Provider Errors\" if order is unknown")]
    [DefaultValue(true)]
    [Category("Logging")]
    public bool OutputUnknownOrderError { get; set; }

    [Category("Connection")]
    [DefaultValue(DllSelector.txmlconnector_dll)]
    public DllSelector SelectedDll
    {
      get
      {
        return this.selectedDll;
      }
      set
      {
        this.selectedDll = value;
      }
    }

    [Category("Connection")]
    [DefaultValue(SecuritySelector.seccode)]
    public SecuritySelector SelectedSecurity
    {
      get
      {
        return this.selectedSecurity;
      }
      set
      {
        this.selectedSecurity = value;
      }
    }

    [DefaultValue("127.0.0.1")]
    [Category("Connection")]
    public string Host
    {
      get
      {
        return this.host;
      }
      set
      {
        this.host = value;
      }
    }

    [Category("Connection")]
    [DefaultValue(0)]
    public int Port
    {
      get
      {
        return this.port;
      }
      set
      {
        this.port = value;
      }
    }

    [Category("Connection")]
    [DefaultValue("")]
    public string Username
    {
      get
      {
        return this.username;
      }
      set
      {
        this.username = value;
      }
    }

    [Editor(typeof (PasswordChangingTypeEditor), typeof (UITypeEditor))]
    [Description("Click (...) to change password")]
    [PasswordPropertyText(true)]
    [DefaultValue("")]
    [Category("Connection")]
    public string Password { get; set; }

    [Description("Should be equal or greater than 100")]
    [Category("Connection")]
    [DefaultValue(100)]
    public int RQDelay
    {
      get
      {
        return this.rqdelay;
      }
      set
      {
        this.rqdelay = value;
      }
    }

    [DefaultValue(false)]
    [Category("Connection")]
    public bool MicexRegisters
    {
      get
      {
        return this.micexRegisters;
      }
      set
      {
        this.micexRegisters = value;
      }
    }

    [DefaultValue(120)]
    [Category("Connection")]
    [Description("Must be greater than RequestTimeout")]
    public int SessionTimeout
    {
      get
      {
        return this.sessionTimeout;
      }
      set
      {
        if (value <= this.requestTimeout)
          return;
        this.sessionTimeout = value;
      }
    }

    [Category("Connection")]
    [DefaultValue(20)]
    [Description("Must be less than SessionTimeout")]
    public int RequestTimeout
    {
      get
      {
        return this.requestTimeout;
      }
      set
      {
        if (value >= this.sessionTimeout)
          return;
        this.requestTimeout = value;
      }
    }

    [Category("Proxy")]
    [Description("Use proxy - True or False")]
    [Editor(typeof (ProxyUsingSelectorEditor), typeof (UITypeEditor))]
    public string ProxyUsing { get; set; }

    [Category("Proxy")]
    [Editor(typeof (ProxyTypeSelectorEditor), typeof (UITypeEditor))]
    public string ProxyType { get; set; }

    [Category("Proxy")]
    [DefaultValue("")]
    public string ProxyHost
    {
      get
      {
        return this.proxyHost;
      }
      set
      {
        this.proxyHost = value;
      }
    }

    [DefaultValue(0)]
    [Category("Proxy")]
    public int ProxyPort
    {
      get
      {
        return this.proxyPort;
      }
      set
      {
        this.proxyPort = value;
      }
    }

    [Category("Proxy")]
    [DefaultValue("")]
    public string ProxyUsername
    {
      get
      {
        return this.proxyUsername;
      }
      set
      {
        this.proxyUsername = value;
      }
    }

    [PasswordPropertyText(true)]
    [Category("Proxy")]
    [DefaultValue("")]
    public string ProxyPassword
    {
      get
      {
        return this.proxyPassword;
      }
      set
      {
        this.proxyPassword = value;
      }
    }

    public Transaq()
    {
      this.name = "Finam Transaq";
      this.description = "Finam Transaq Provider";
      this.id = (byte) 117;
      this.url = "http://www.finam.ru/";
      this.selectedDll = DllSelector.txmlconnector_dll;
      this.selectedSecurity = SecuritySelector.seccode;
      this.host = "127.0.0.1";
      this.port = 0;
      this.username = "";
      this.logLevelConn = "0";
      this.logLevelInit = "2";
      this.rqdelay = 100;
      this.micexRegisters = false;
      this.sessionTimeout = 120;
      this.requestTimeout = 20;
      this.proxyUsing = "";
      this.proxyType = "";
      this.proxyHost = "";
      this.proxyPort = 0;
      this.proxyUsername = "";
      this.proxyPassword = "";
      this.isInitialize = false;
      this.positions = new TransaqPositions();
      this.marketById = new Dictionary<int, TransaqMarket>();
      this.boardById = new Dictionary<string, TransaqBoard>();
      this.candleKindByPeriod = new Dictionary<long, TransaqCandleKind>();
      this.instrumentBySymbol = new Dictionary<string, Instrument>();
      this.securityBySecId = new Dictionary<int, TransaqSecurity>();
      this.securityBySCB = new Dictionary<string, TransaqSecurity>();
      this.tickEndTimeBySecId = new Dictionary<int, DateTime>();
      this.tickEndTimeBySCB = new Dictionary<string, DateTime>();
      this.hdrBySecId = new Dictionary<int, HistoricalDataRequest>();
      this.hdrBySCB = new Dictionary<string, HistoricalDataRequest>();
      this.openBookBySecId = new Dictionary<int, OpenBook>();
      this.openBookBySCB = new Dictionary<string, OpenBook>();
      this.bidOfferPairBySecId = new Dictionary<int, BidOfferPair>();
      this.bidOfferPairBySCB = new Dictionary<string, BidOfferPair>();
      this.rwClientById = new ReaderWriterLockSlim();
      this.rwClientLimits = new ReaderWriterLockSlim();
      this.clientById = new Dictionary<string, TransaqClient>();
      this.clientLimits = new Dictionary<string, TransaqClientLimit>();
      this.brokerAccountByClientId = new Dictionary<string, BrokerAccount>();
      this.rwOrderByOrdId = new ReaderWriterLockSlim();
      this.rwOrderByOrdNo = new ReaderWriterLockSlim();
      this.rwTransaqOrderByTrId = new ReaderWriterLockSlim();
      this.rwTransaqStopOrderByTrId = new ReaderWriterLockSlim();
      this.orderByOrdId = new Dictionary<string, Order>();
      this.orderByOrdNo = new Dictionary<long, Order>();
      this.transaqOrderByTrId = new Dictionary<long, TransaqOrder>();
      this.transaqStopOrderByTrId = new Dictionary<long, TransaqStopOrder>();
      this.clientTradeNo = new Dictionary<long, object>();
      this.balanceByOrderNoForCancel = new Dictionary<long, double>();
      ProxyUsingSelectorEditor.t = this;
    }

    protected override void Send(Order order)
    {
      try
      {
        if (!this.isConnected)
          this.EmitRejected(order, "Send order: provider is not connected");
        else if (order.Type == OrderType.Market && (order.Instrument.Type == InstrumentType.Option || order.Instrument.Type == InstrumentType.Futures))
        {
          this.EmitRejected(order, "Send order: market order for options and futures is unavailable");
        }
        else
        {
          TransaqSecurity transaqSecurity1 = (TransaqSecurity) null;
          string symbol = order.Instrument.GetSymbol(this.name);
          if (this.selectedSecurity == SecuritySelector.seccode)
          {
            foreach (int index in this.securityBySecId.Keys)
            {
              TransaqSecurity transaqSecurity2 = this.securityBySecId[index];
              if (transaqSecurity2.SecCode == symbol)
              {
                transaqSecurity1 = transaqSecurity2;
                break;
              }
            }
          }
          else if (this.selectedSecurity == SecuritySelector.seccode_board)
          {
            foreach (string index in this.securityBySCB.Keys)
            {
              TransaqSecurity transaqSecurity2 = this.securityBySCB[index];
              if (transaqSecurity2.SecCodeBoard == symbol)
              {
                transaqSecurity1 = transaqSecurity2;
                break;
              }
            }
          }
          if (transaqSecurity1 == null)
          {
            this.EmitRejected(order, string.Format("Send order: unknown instrument {0}", (object) symbol));
          }
          else
          {
            string str1 = order.Side == OrderSide.Buy ? "B" : "S";
            string str2 = string.Empty;
            string key;
            if (order.Account != null && !string.IsNullOrWhiteSpace(order.Account))
              key = order.Account;
            else if (this.DefaultAccount != null && !string.IsNullOrWhiteSpace(this.DefaultAccount))
            {
              key = this.DefaultAccount;
            }
            else
            {
              this.EmitRejected(order, "Send order: unknown account");
              return;
            }
            try
            {
              this.rwClientById.EnterReadLock();
              if (!this.clientById.ContainsKey(key))
                this.EmitRejected(order, string.Format("Send order: unknown account {0}", (object) key));
            }
            finally
            {
              this.rwClientById.ExitReadLock();
            }
            string cmd = string.Empty;
            switch (order.Type)
            {
              case OrderType.Market:
                if (!transaqSecurity1.ByMarket)
                {
                  this.EmitRejected(order, string.Format("Send order: bymarket isn't available for {0}", (object) symbol));
                  this.EmitError(string.Format("Send order: bymarket isn't available for {0}", (object) symbol));
                  return;
                }
                else
                {
                  string str3 = "<command id=\"neworder\">";
                  if (this.selectedSecurity == SecuritySelector.seccode)
                    str3 = string.Concat(new object[4]
                    {
                      (object) str3,
                      (object) "<secid>",
                      (object) transaqSecurity1.SecId,
                      (object) "</secid>"
                    });
                  else if (this.selectedSecurity == SecuritySelector.seccode_board)
                    str3 = str3 + "<security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security>";
                  string str4 = string.Concat(new object[4]
                  {
                    (object) (str3 + "<client>" + key + "</client>" + "<hidden>0</hidden>"),
                    (object) "<quantity>",
                    (object) order.Qty,
                    (object) "</quantity>"
                  }) + "<buysell>" + str1 + "</buysell>" + "<bymarket/>" + "<unfilled>PutInQueue</unfilled>";
                  if (transaqSecurity1.UseCredit)
                    str4 = str4 + "<usecredit/>";
                  cmd = str4 + "</command>";
                  break;
                }
              case OrderType.Limit:
                string str5 = "<command id=\"neworder\">";
                if (this.selectedSecurity == SecuritySelector.seccode)
                  str5 = string.Concat(new object[4]
                  {
                    (object) str5,
                    (object) "<secid>",
                    (object) transaqSecurity1.SecId,
                    (object) "</secid>"
                  });
                else if (this.selectedSecurity == SecuritySelector.seccode_board)
                  str5 = str5 + "<security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security>";
                string str6 = string.Concat(new object[4]
                {
                  (object) (str5 + "<client>" + key + "</client>" + "<price>" + order.Price.ToString().Replace(',', '.') + "</price>" + "<hidden>0</hidden>"),
                  (object) "<quantity>",
                  (object) order.Qty,
                  (object) "</quantity>"
                }) + "<buysell>" + str1 + "</buysell>" + "<unfilled>PutInQueue</unfilled>";
                if (transaqSecurity1.UseCredit)
                  str6 = str6 + "<usecredit/>";
                if (transaqSecurity1.NoSplit)
                  str6 = str6 + "<nosplit/>";
                cmd = str6 + "</command>";
                break;
              case OrderType.Stop:
                string str7 = "<command id=\"newstoporder\">";
                if (this.selectedSecurity == SecuritySelector.seccode)
                  str7 = string.Concat(new object[4]
                  {
                    (object) str7,
                    (object) "<secid>",
                    (object) transaqSecurity1.SecId,
                    (object) "</secid>"
                  });
                else if (this.selectedSecurity == SecuritySelector.seccode_board)
                  str7 = str7 + "<security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security>";
                string str8 = string.Concat(new object[4]
                {
                  (object) (str7 + "<client>" + key + "</client>" + "<buysell>" + str1 + "</buysell>" + "<stoploss>" + "<activationprice>" + order.StopPrice.ToString().Replace(',', '.') + "</activationprice>" + "<bymarket/>"),
                  (object) "<quantity>",
                  (object) order.Qty,
                  (object) "</quantity>"
                });
                if (transaqSecurity1.UseCredit)
                  str8 = str8 + "<usecredit/>";
                cmd = str8 + "</stoploss>" + "</command>";
                break;
              case OrderType.StopLimit:
                string str9 = !(str1 == "B") ? "LastDown" : "LastUp";
                string str10 = "<command id=\"newcondorder\">";
                if (this.selectedSecurity == SecuritySelector.seccode)
                  str10 = string.Concat(new object[4]
                  {
                    (object) str10,
                    (object) "<secid>",
                    (object) transaqSecurity1.SecId,
                    (object) "</secid>"
                  });
                else if (this.selectedSecurity == SecuritySelector.seccode_board)
                  str10 = str10 + "<security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security>";
                string str11 = string.Concat(new object[4]
                {
                  (object) (str10 + "<client>" + key + "</client>" + "<price>" + order.Price.ToString().Replace(',', '.') + "</price>" + "<hidden>0</hidden>"),
                  (object) "<quantity>",
                  (object) order.Qty,
                  (object) "</quantity>"
                }) + "<buysell>" + str1 + "</buysell>" + "<cond_type>" + str9 + "</cond_type>" + "<cond_value>" + order.StopPrice.ToString().Replace(',', '.') + "</cond_value>" + "<validafter>0</validafter>" + "<validbefore>0</validbefore>";
                if (transaqSecurity1.UseCredit)
                  str11 = str11 + "<usecredit/>";
                if (transaqSecurity1.NoSplit)
                  str11 = str11 + "<nosplit/>";
                cmd = str11 + "</command>";
                break;
            }
            TransaqResult transaqResult = this.SendCommandLine(cmd);
            if (transaqResult.Success)
            {
              order.OrderID = transaqResult.TransactionId;
              try
              {
                this.rwOrderByOrdId.EnterUpgradeableReadLock();
                if (!this.orderByOrdId.ContainsKey(order.OrderID))
                {
                  this.rwOrderByOrdId.EnterWriteLock();
                  this.orderByOrdId.Add(order.OrderID, order);
                }
                else
                {
                  this.rwOrderByOrdId.EnterWriteLock();
                  this.orderByOrdId[order.OrderID] = order;
                }
              }
              finally
              {
                if (this.rwOrderByOrdId.IsWriteLockHeld)
                  this.rwOrderByOrdId.ExitWriteLock();
                this.rwOrderByOrdId.ExitUpgradeableReadLock();
              }
            }
            else
              this.EmitRejected(order, string.Format("Send order: not success! Error={0}", (object) transaqResult.Message));
          }
        }
      }
      catch (Exception ex)
      {
        this.EmitRejected(order, string.Format("Send order: Exception={0} StackTrace={1}", (object) ex.Message, (object) ex.StackTrace));
      }
    }

    protected override void Cancel(Order order)
    {
      try
      {
        if (!this.isConnected)
          this.EmitCancelReject(order, order.Status, "provider is not connected");
        else if (string.IsNullOrWhiteSpace(order.OrderID))
        {
          this.EmitCancelReject(order, order.Status, "Cancel order: can't cancel order with empty TransactionId");
        }
        else
        {
          string str = string.Empty;
          TransaqResult transaqResult = this.SendCommandLine(order.Type != OrderType.Stop ? str + "<command id=\"cancelorder\">" + "<transactionid>" + order.OrderID + "</transactionid>" + "</command>" : str + "<command id=\"cancelstoporder\">" + "<transactionid>" + order.OrderID + "</transactionid>" + "</command>");
          if (transaqResult.Success)
            return;
          this.EmitCancelReject(order, order.Status, string.Format("Cancel order: not success! {0}", (object) transaqResult.Message));
        }
      }
      catch (Exception ex)
      {
        this.EmitCancelReject(order, order.Status, string.Format("Cancel order: Exception={0} StackTrace={1}", (object) ex.Message, (object) ex.StackTrace));
      }
    }

    protected override void Replace(Order order, double newQty, double newPrice, double newStopPrice)
    {
      this.EmitReplaceReject(order, order.Status, "Order replace is unavailable");
      this.EmitError("Order replace is unavailable");
    }

    protected override BrokerInfo GetBrokerInfo()
    {
      BrokerInfo brokerInfo = new BrokerInfo();
      if (!this.isConnected)
        return brokerInfo;
      try
      {
        this.rwClientById.EnterReadLock();
        foreach (string index in this.clientById.Keys)
          this.SendCommandLine("<command id=\"get_client_limits\" client=\"" + this.clientById[index].Id + "\"/>");
        foreach (string index in this.clientById.Keys)
        {
          TransaqClient transaqClient = this.clientById[index];
          BrokerAccount brokerAccount = brokerInfo.AddAccount(transaqClient.Id);
          brokerAccount.AddField("Client: Client Id", transaqClient.Id);
          brokerAccount.AddField("Client: Type", transaqClient.Type);
          brokerAccount.AddField("Client: Currency", transaqClient.Currency);
          brokerAccount.AddField("Client: Ml_intraday", transaqClient.Ml_intraday);
          brokerAccount.AddField("Client: Ml_overnight", transaqClient.Ml_overnight);
          brokerAccount.AddField("Client: Ml_restrict", transaqClient.Ml_restrict);
          brokerAccount.AddField("Client: Ml_call", transaqClient.Ml_call);
          brokerAccount.AddField("Client: Ml_close", transaqClient.Ml_close);
          Dictionary<string, TransaqMoneyPosition> dictionary1 = (Dictionary<string, TransaqMoneyPosition>) null;
          lock (this.positions.lockerMoneyPosition)
          {
            if (this.positions.MoneyPosition.TryGetValue(transaqClient.Id, out dictionary1))
            {
              foreach (string item_1 in dictionary1.Keys)
              {
                TransaqMoneyPosition local_9 = dictionary1[item_1];
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: Asset", (object) local_9.Register), local_9.Asset);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: ShortName", (object) local_9.Register), local_9.ShortName);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: SaldoIn", (object) local_9.Register), local_9.SaldoIn);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: Saldo", (object) local_9.Register), local_9.Saldo);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: Bought", (object) local_9.Register), local_9.Bought);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: Sold", (object) local_9.Register), local_9.Sold);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: OrdBuy", (object) local_9.Register), local_9.OrdBuy);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: OrdBuyCond", (object) local_9.Register), local_9.OrdBuyCond);
                brokerAccount.AddField(string.Format("MoneyPos Register={0}: Comission", (object) local_9.Register), local_9.Comission);
              }
            }
          }
          TransaqFortsMoney transaqFortsMoney = (TransaqFortsMoney) null;
          lock (this.positions.lockerFortsMoney)
          {
            if (this.positions.FortsMoney.TryGetValue(transaqClient.Id, out transaqFortsMoney))
            {
              brokerAccount.AddField("FortsMoney: Current", transaqFortsMoney.Current);
              brokerAccount.AddField("FortsMoney: Blocked", transaqFortsMoney.Blocked);
              brokerAccount.AddField("FortsMoney: Free", transaqFortsMoney.Free);
              brokerAccount.AddField("FortsMoney: VarMargin", transaqFortsMoney.VarMargin);
            }
          }
          TransaqFortsCollaterals fortsCollaterals = (TransaqFortsCollaterals) null;
          lock (this.positions.lockerFortsCollaterals)
          {
            if (this.positions.FortsCollaterals.TryGetValue(transaqClient.Id, out fortsCollaterals))
            {
              brokerAccount.AddField("FortsCollaterals: Client", fortsCollaterals.Client);
              brokerAccount.AddField("FortsCollaterals: Current", fortsCollaterals.Current);
              brokerAccount.AddField("FortsCollaterals: Blocked", fortsCollaterals.Blocked);
              brokerAccount.AddField("FortsCollaterals: Free", fortsCollaterals.Free);
            }
          }
          TransaqSpotLimit transaqSpotLimit = (TransaqSpotLimit) null;
          lock (this.positions.lockerSpotLimit)
          {
            if (this.positions.SpotLimit.TryGetValue(transaqClient.Id, out transaqSpotLimit))
            {
              brokerAccount.AddField("SpotLimit: Client", transaqSpotLimit.Client);
              brokerAccount.AddField("SpotLimit: BuyLimit", transaqSpotLimit.BuyLimit);
              brokerAccount.AddField("SpotLimit: BuyLimitUsed", transaqSpotLimit.BuyLimitUsed);
            }
          }
          TransaqClientLimit transaqClientLimit = (TransaqClientLimit) null;
          try
          {
            this.rwClientLimits.EnterReadLock();
            if (this.clientLimits.TryGetValue(transaqClient.Id, out transaqClientLimit))
            {
              brokerAccount.AddField("ClientLimit: Client", transaqClientLimit.Client);
              brokerAccount.AddField("ClientLimit: CbplLimit", transaqClientLimit.CbplLimit);
              brokerAccount.AddField("ClientLimit: CbplUsed", transaqClientLimit.CbplUsed);
              brokerAccount.AddField("ClientLimit: CbplPlanned", transaqClientLimit.CbplPlanned);
              brokerAccount.AddField("ClientLimit: Fob_VarMargin", transaqClientLimit.Fob_VarMargin);
              brokerAccount.AddField("ClientLimit: Coverage", transaqClientLimit.Coverage);
              brokerAccount.AddField("ClientLimit: Liquidity_C", transaqClientLimit.Liquidity_C);
              brokerAccount.AddField("ClientLimit: Profit", transaqClientLimit.Profit);
              brokerAccount.AddField("ClientLimit: Money_Current", transaqClientLimit.Money_Current);
              brokerAccount.AddField("ClientLimit: Money_Blocked", transaqClientLimit.Money_Blocked);
              brokerAccount.AddField("ClientLimit: Money_Free", transaqClientLimit.Money_Free);
              brokerAccount.AddField("ClientLimit: Options_Premium", transaqClientLimit.Options_Premium);
              brokerAccount.AddField("ClientLimit: Exchange_Fee", transaqClientLimit.Exchange_Fee);
              brokerAccount.AddField("ClientLimit: Forts_VarMargin", transaqClientLimit.Forts_VarMargin);
              brokerAccount.AddField("ClientLimit: PclMargin", transaqClientLimit.PclMargin);
              brokerAccount.AddField("ClientLimit: Options_VM", transaqClientLimit.Options_VM);
              brokerAccount.AddField("ClientLimit: Spot_Buy_Limit", transaqClientLimit.Spot_Buy_Limit);
              brokerAccount.AddField("ClientLimit: Used_Spot_Buy_Limit", transaqClientLimit.Used_Spot_Buy_Limit);
              brokerAccount.AddField("ClientLimit: Collat_Current", transaqClientLimit.Collat_Current);
              brokerAccount.AddField("ClientLimit: Collat_Blocked", transaqClientLimit.Collat_Blocked);
              brokerAccount.AddField("ClientLimit: Collat_Free", transaqClientLimit.Collat_Free);
            }
          }
          finally
          {
            this.rwClientLimits.ExitReadLock();
          }
          if (!this.brokerAccountByClientId.ContainsKey(transaqClient.Id))
            this.brokerAccountByClientId.Add(transaqClient.Id, brokerAccount);
          Dictionary<string, TransaqSecPosition> dictionary2 = (Dictionary<string, TransaqSecPosition>) null;
          lock (this.positions.lockerSecPosition)
          {
            if (this.positions.SecPosition.TryGetValue(transaqClient.Id, out dictionary2))
            {
              foreach (string item_2 in dictionary2.Keys)
              {
                TransaqSecPosition local_16 = dictionary2[item_2];
                BrokerPosition local_17 = brokerAccount.AddPosition();
                local_17.Symbol = local_16.SecCode;
                if (local_16.Saldo > 0.0)
                  local_17.LongQty = local_16.Saldo;
                else
                  local_17.ShortQty = -local_16.Saldo;
                local_17.Qty = local_16.Saldo;
                local_17.AddCustomField("SecId", local_16.SecId.ToString());
                local_17.AddCustomField("Market", local_16.Market.ToString());
                local_17.AddCustomField("SecCode", local_16.SecCode);
                local_17.AddCustomField("Register", local_16.Register);
                local_17.AddCustomField("Client", local_16.Client);
                local_17.AddCustomField("ShortName", local_16.ShortName);
                local_17.AddCustomField("SaldoIn", local_16.SaldoIn);
                local_17.AddCustomField("SaldoMin", local_16.SaldoMin);
                local_17.AddCustomField("Bought", local_16.Bought.ToString());
                local_17.AddCustomField("Sold", local_16.Sold.ToString());
                local_17.AddCustomField("Saldo", local_16.Saldo.ToString());
                local_17.AddCustomField("OrderBuy", local_16.OrderBuy);
                local_17.AddCustomField("OrderSell", local_16.OrderSell);
              }
            }
          }
          Dictionary<string, TransaqFortsPosition> dictionary3 = (Dictionary<string, TransaqFortsPosition>) null;
          lock (this.positions.lockerFortsPosition)
          {
            if (this.positions.FortsPosition.TryGetValue(transaqClient.Id, out dictionary3))
            {
              foreach (string item_4 in dictionary3.Keys)
              {
                TransaqFortsPosition local_20 = dictionary3[item_4];
                BrokerPosition local_21 = brokerAccount.AddPosition();
                local_21.Symbol = local_20.SecCode;
                if (local_20.TotalNet > 0.0)
                  local_21.LongQty = local_20.TotalNet;
                else
                  local_21.ShortQty = -local_20.TotalNet;
                local_21.Qty = local_20.TotalNet;
                local_21.AddCustomField("SecId", local_20.SecId.ToString());
                local_21.AddCustomField("SecCode", local_20.SecCode);
                local_21.AddCustomField("Client", local_20.Client);
                local_21.AddCustomField("StartNet", local_20.StartNet);
                local_21.AddCustomField("OpenBuys", local_20.OpenBuys);
                local_21.AddCustomField("OpenSells", local_20.OpenSells);
                local_21.AddCustomField("TotalNet", local_20.TotalNet.ToString());
                local_21.AddCustomField("TodayBuy", local_20.TodayBuy);
                local_21.AddCustomField("TodaySell", local_20.TodaySell);
                local_21.AddCustomField("OptMargin", local_20.OptMargin);
                local_21.AddCustomField("VarMargin", local_20.VarMargin);
                local_21.AddCustomField("ExpirationPos", local_20.ExpirationPos);
                local_21.AddCustomField("UsedSellSpotLimit", local_20.UsedSellSpotLimit);
                local_21.AddCustomField("SellSpotLimit", local_20.SellSpotLimit);
                local_21.AddCustomField("Netto", local_20.Netto);
                local_21.AddCustomField("Kgo", local_20.Kgo);
              }
            }
          }
        }
      }
      finally
      {
        this.rwClientById.ExitReadLock();
      }
      return brokerInfo;
    }

    protected override void Connect()
    {
      if (this.isConnected)
        return;
      if (!Directory.Exists(this.LogFilesDir))
      {
        this.EmitError(string.Format("LogFilesDir does not exist: {0}", (object) this.LogFilesDir));
      }
      else
      {
        string str1 = this.LogFilesDir.EndsWith("\\") ? this.LogFilesDir : this.LogFilesDir + "\\";
        if (!this.isInitialize)
        {
          short LogLevel = short.Parse(this.LogLevelInit);
          string str2 = string.Empty;
          if (this.selectedDll == DllSelector.txmlconnector_dll)
          {
            try
            {
              this.connector = (ITransaqConnector) new TXmlConnector();
            }
            catch (Exception ex)
            {
              this.EmitError(ex.Message);
              return;
            }
            this.connector.NewData += new EventHandler<NewDataEventArgs>(this.ReceiveMessage);
            this.connector.ConnectorInitialize(str1 + (object) char.MinValue, LogLevel);
            PasswordChangingTypeEditor.selectedDll = DllSelector.txmlconnector_dll;
          }
          else if (this.selectedDll == DllSelector.txcn_dll)
          {
            try
            {
              this.connector = (ITransaqConnector) new TXcnConnector();
            }
            catch (Exception ex)
            {
              this.EmitError(ex.Message);
              return;
            }
            this.connector.NewData += new EventHandler<NewDataEventArgs>(this.ReceiveMessage);
            this.connector.ConnectorInitialize(str1 + (object) char.MinValue, LogLevel);
            PasswordChangingTypeEditor.selectedDll = DllSelector.txcn_dll;
          }
          this.isInitialize = true;
        }
        string str3 = string.Concat(new object[4]
        {
          (object) string.Concat(new object[4]
          {
            (object) string.Concat(new object[4]
            {
              (object) string.Concat(new object[4]
              {
                (object) (string.Concat(new object[4]
                {
                  (object) ("<command id=\"connect\">" + "<login>" + this.Username + "</login>" + "<password>" + this.Password + "</password>" + "<host>" + this.Host + "</host>"),
                  (object) "<port>",
                  (object) this.Port,
                  (object) "</port>"
                }) + "<logsdir>" + str1 + "</logsdir>" + "<loglevel>" + this.LogLevelConn + "</loglevel>"),
                (object) "<micex_registers>",
                (object) (bool) (this.MicexRegisters ? 1 : 0),
                (object) "</micex_registers>"
              }),
              (object) "<rqdelay>",
              (object) this.RQDelay,
              (object) "</rqdelay>"
            }),
            (object) "<session_timeout>",
            (object) this.SessionTimeout,
            (object) "</session_timeout>"
          }),
          (object) "<request_timeout>",
          (object) this.RequestTimeout,
          (object) "</request_timeout>"
        });
        this.proxyType = this.ProxyType;
        this.proxyUsing = this.ProxyUsing;
        if (this.proxyUsing == "True" && this.ProxyType != "" && this.ProxyHost != "")
        {
          string str2 = string.Concat(new object[4]
          {
            (object) (str3 + "<proxy type=\"" + this.proxyType + "\"" + " addr=\"" + this.ProxyHost + "\""),
            (object) " port=\"",
            (object) this.ProxyPort,
            (object) "\""
          });
          if (this.ProxyUsername != "")
            str2 = str2 + " login=\"" + this.ProxyUsername + "\"";
          if (this.ProxyPassword != "")
            str2 = str2 + " password=\"" + this.ProxyPassword + "\"";
          str3 = str2 + "/>";
        }
        this.SendCommandLine(str3 + "</command>");
      }
    }

    protected override void Disconnect()
    {
      if (!this.isConnected)
        return;
      this.SendCommandLine("<command id=\"disconnect\"/>");
    }

    protected override void Shutdown()
    {
      this.Disconnect();
    }

    protected override void RequestHistoricalData(HistoricalDataRequest request)
    {
      if (!this.isConnected)
        this.EmitHistoricalDataError(request, "Provider is not connected");
      else if (request.DataType == DataType.Quote)
      {
        this.EmitHistoricalDataError(request, "Only Trade, Bar and Daily");
      }
      else
      {
        TransaqSecurity transaqSecurity1 = (TransaqSecurity) null;
        string symbol = request.Instrument.GetSymbol(this.name);
        if (this.selectedSecurity == SecuritySelector.seccode)
        {
          foreach (int index in this.securityBySecId.Keys)
          {
            TransaqSecurity transaqSecurity2 = this.securityBySecId[index];
            if (transaqSecurity2.SecCode == symbol)
            {
              transaqSecurity1 = transaqSecurity2;
              break;
            }
          }
        }
        else if (this.selectedSecurity == SecuritySelector.seccode_board)
        {
          foreach (string index in this.securityBySCB.Keys)
          {
            TransaqSecurity transaqSecurity2 = this.securityBySCB[index];
            if (transaqSecurity2.SecCodeBoard == symbol)
            {
              transaqSecurity1 = transaqSecurity2;
              break;
            }
          }
        }
        if (transaqSecurity1 == null)
        {
          this.EmitHistoricalDataError(request, string.Format("Unknown instrument {0} for get historical {1}", (object) symbol, (object) request.DataType));
        }
        else
        {
          long num1 = -1L;
          long key = 86400L;
          long num2 = -1L;
          if (request.DataType == DataType.Daily)
          {
            if (this.candleKindByPeriod.ContainsKey(key))
            {
              num1 = (long) this.candleKindByPeriod[key].Id;
              num2 = (long) Math.Ceiling((Clock.Now - request.BeginDate).TotalSeconds / (double) key);
            }
            else
            {
              this.EmitHistoricalDataError(request, string.Format("BarSize {0} second is unavailable", (object) key));
              return;
            }
          }
          else if (request.DataType == DataType.Bar)
          {
            if (this.candleKindByPeriod.ContainsKey(request.BarSize))
            {
              num1 = (long) this.candleKindByPeriod[request.BarSize].Id;
              num2 = (long) Math.Ceiling((Clock.Now - request.BeginDate).TotalSeconds / (double) request.BarSize);
            }
            else
            {
              this.EmitHistoricalDataError(request, string.Format("BarSize {0} second is unavailable", (object) num1));
              return;
            }
          }
          if (this.selectedSecurity == SecuritySelector.seccode)
          {
            string str = string.Empty;
            string cmd;
            if (request.DataType == DataType.Trade)
            {
              cmd = string.Concat(new object[4]
              {
                (object) (str + "<command id=\"subscribe_ticks\">"),
                (object) "<security secid=\"",
                (object) transaqSecurity1.SecId,
                (object) "\" tradeno=\"1\"/>"
              }) + "</command>";
              this.tickEndTimeBySecId.Add(transaqSecurity1.SecId, Clock.Now);
            }
            else
              cmd = str + (object) "<command id=\"gethistorydata\" secid=\"" + (string) (object) transaqSecurity1.SecId + "\" period=\"" + (string) (object) num1 + "\" count=\"" + (string) (object) num2 + "\" reset=\"true\"/>";
            if (this.SendCommandLine(cmd).Success)
              this.hdrBySecId.Add(transaqSecurity1.SecId, request);
            else
              this.EmitHistoricalDataError(request, "Error in request");
          }
          else
          {
            if (this.selectedSecurity != SecuritySelector.seccode_board)
              return;
            string str = string.Empty;
            string cmd;
            if (request.DataType == DataType.Trade)
            {
              cmd = str + "<command id=\"subscribe_ticks\">" + "<security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security>" + "<tradeno>1</tradeno>" + "</command>";
              this.tickEndTimeBySCB.Add(transaqSecurity1.SecCodeBoard, Clock.Now);
            }
            else
              cmd = string.Concat(new object[4]
              {
                (object) string.Concat(new object[4]
                {
                  (object) (str + "<command id=\"gethistorydata\">" + "<security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security>"),
                  (object) "<period>",
                  (object) num1,
                  (object) "</period>"
                }),
                (object) "<count>",
                (object) num2,
                (object) "</count>"
              }) + "<reset>true</reset>" + "</command>";
            if (this.SendCommandLine(cmd).Success)
              this.hdrBySCB.Add(transaqSecurity1.SecCodeBoard, request);
            else
              this.EmitHistoricalDataError(request, "Error in request");
          }
        }
      }
    }

    private TransaqResult SendCommandLine(string cmd)
    {
      cmd = cmd + (object) char.MinValue;
      TransaqResult transaqResult = new TransaqResult();
      try
      {
        transaqResult = new TransaqResult(this.GetResultString(this.connector.SendCommand(cmd)));
      }
      catch (Exception ex)
      {
        this.EmitError(ex.Message);
      }
      if (!transaqResult.Success)
      {
        if (!string.IsNullOrWhiteSpace(transaqResult.Message))
          this.EmitError(transaqResult.Message);
        if (!string.IsNullOrWhiteSpace(transaqResult.Error))
          this.EmitError(transaqResult.Error);
      }
      return transaqResult;
    }

    private string GetResultString(string xmlString)
    {
      string str = string.Empty;
      XmlReader xmlReader = XmlReader.Create((TextReader) new StringReader(xmlString));
      while (xmlReader.Read())
      {
        if (xmlReader.NodeType == XmlNodeType.Element)
        {
          if (xmlReader.Name == "result")
          {
            if (xmlReader.MoveToAttribute("success"))
              str = str + xmlReader.Name + ";" + xmlReader.Value + ";";
            if (xmlReader.MoveToAttribute("transactionid"))
              str = str + xmlReader.Name + ";" + xmlReader.Value + ";";
          }
          else
            str = str + xmlReader.Name + ";";
        }
        else if (xmlReader.NodeType == XmlNodeType.Text)
          str = str + xmlReader.Value + ";";
        else if (xmlReader.NodeType == XmlNodeType.EndElement && xmlReader.Name == "result")
          return str;
      }
      return str;
    }

    private void ReceiveMessage(object sender, NewDataEventArgs e)
    {
      XmlReader reader = XmlReader.Create((TextReader) new StringReader(e.Data));
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          switch (reader.Name)
          {
            case "markets":
              this.ProcessMarkets2(reader);
              continue;
            case "boards":
              this.ProcessBoards2(reader);
              continue;
            case "candlekinds":
              this.ProcessCandleKinds2(reader);
              continue;
            case "securities":
              this.ProcessSecurities2(reader);
              continue;
            case "client":
              this.ProcessClient2(reader);
              continue;
            case "positions":
              this.ProcessPositions2(reader);
              continue;
            case "clientlimits":
              this.ProcessClientLimits2(reader);
              continue;
            case "server_status":
              this.ProcessServerStatus2(reader);
              continue;
            case "quotations":
              this.ProcessQuotations2(reader);
              continue;
            case "alltrades":
              this.ProcessAllTrades2(reader);
              continue;
            case "quotes":
              this.ProcessQuotes2(reader);
              continue;
            case "candles":
              this.ProcessCandles2(reader);
              continue;
            case "ticks":
              this.ProcessTicks2(reader);
              continue;
            case "orders":
              this.ProcessOrders2(reader);
              continue;
            case "trades":
              this.ProcessClientTrades2(reader);
              continue;
            default:
              continue;
          }
        }
      }
    }

    private XmlReader ProcessMarkets2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "market" && reader.MoveToAttribute("id"))
            data = data + "id;" + reader.Value + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + "market;" + reader.Value;
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "market")
          {
            this.AddMarket(data);
            data = string.Empty;
          }
          else if (reader.Name == "markets")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessBoards2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "board")
          {
            if (reader.MoveToAttribute("id"))
              data = data + "id;" + reader.Value + ";";
          }
          else
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "board")
          {
            this.AddBoard(data);
            data = string.Empty;
          }
          else if (reader.Name == "boards")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessCandleKinds2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "id")
            data = data + "id;";
          else if (reader.Name == "period")
            data = data + "period;";
          else if (reader.Name == "name")
            data = data + "name;";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "kind")
          {
            this.AddCandleKind(data);
            data = string.Empty;
          }
          else if (reader.Name == "candlekinds")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessSecurities2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "security")
          {
            if (reader.MoveToAttribute("secid"))
              data = data + "secid;" + reader.Value + ";";
            if (reader.MoveToAttribute("active"))
              data = data + "active;" + reader.Value + ";";
          }
          else if (reader.Name == "opmask")
          {
            if (reader.MoveToAttribute("usecredit"))
              data = data + "usecredit;" + reader.Value + ";";
            if (reader.MoveToAttribute("bymarket"))
              data = data + "bymarket;" + reader.Value + ";";
            if (reader.MoveToAttribute("nosplit"))
              data = data + "nosplit;" + reader.Value + ";";
            if (reader.MoveToAttribute("immorcancel"))
              data = data + "immorcancel;" + reader.Value + ";";
            if (reader.MoveToAttribute("cancelbalance"))
              data = data + "cancelbalance;" + reader.Value + ";";
          }
          else
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "security")
          {
            this.AddSecurity(data);
            data = string.Empty;
          }
          else if (reader.Name == "securities")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessClient2(XmlReader reader)
    {
      string data = string.Empty;
      if (reader.Name == "client")
      {
        if (reader.MoveToAttribute("id"))
          data = data + "id;" + reader.Value + ";";
        if (reader.MoveToAttribute("remove"))
          data = data + "remove;" + reader.Value + ";";
      }
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
          data = data + reader.Name + ";";
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "client")
        {
          this.UpdateClient(data);
          string str = string.Empty;
          return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessPositions2(XmlReader reader)
    {
      bool flag = false;
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "markets")
            flag = true;
          else if (reader.Name == "market")
            flag = false;
          if (!flag)
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
        {
          if (!flag)
            data = data + reader.Value + ";";
        }
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "markets")
            flag = false;
          else if (reader.Name == "money_position")
          {
            this.positions.AddMoneyPositionInfo(data);
            data = string.Empty;
          }
          else if (reader.Name == "sec_position")
          {
            this.positions.AddSecPositionInfo(data);
            data = string.Empty;
          }
          else if (reader.Name == "forts_position")
          {
            this.positions.AddFortsPositionInfo(data);
            data = string.Empty;
          }
          else if (reader.Name == "forts_money")
          {
            this.positions.AddFortsMoneyInfo(data);
            data = string.Empty;
          }
          else if (reader.Name == "forts_collaterals")
          {
            this.positions.AddFortsCollateralsInfo(data);
            data = string.Empty;
          }
          else if (reader.Name == "spot_limit")
          {
            this.positions.AddSpotLimitInfo(data);
            data = string.Empty;
          }
          else if (reader.Name == "positions")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessClientLimits2(XmlReader reader)
    {
      string data = string.Empty;
      if (reader.MoveToAttribute("client"))
        data = data + "client;" + reader.Value + ";";
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
          data = data + reader.Name + ";";
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "clientlimits")
        {
          TransaqClientLimit transaqClientLimit = new TransaqClientLimit(data);
          try
          {
            this.rwClientLimits.EnterUpgradeableReadLock();
            if (!this.clientLimits.ContainsKey(transaqClientLimit.Client))
            {
              this.rwClientLimits.EnterWriteLock();
              this.clientLimits.Add(transaqClientLimit.Client, transaqClientLimit);
            }
            else
            {
              this.rwClientLimits.EnterWriteLock();
              this.clientLimits[transaqClientLimit.Client] = transaqClientLimit;
            }
          }
          finally
          {
            if (this.rwClientLimits.IsWriteLockHeld)
              this.rwClientLimits.ExitWriteLock();
            this.rwClientLimits.ExitUpgradeableReadLock();
          }
          return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessServerStatus2(XmlReader reader)
    {
      string data = string.Empty;
      if (reader.MoveToAttribute("id"))
        data = data + "id;" + reader.Value + ";";
      if (reader.MoveToAttribute("connected"))
        data = data + "connected;" + reader.Value + ";";
      string str;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "server_status")
        {
          this.UpdateServerStatus(data);
          str = string.Empty;
          return reader;
        }
      }
      this.UpdateServerStatus(data);
      str = string.Empty;
      return reader;
    }

    private XmlReader ProcessQuotations2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "quotation" && reader.MoveToAttribute("secid"))
            data = data + reader.Name + ";" + reader.Value + ";";
          else
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "quotation")
          {
            this.AddQuotation(data);
            data = string.Empty;
          }
          else if (reader.Name == "quotations")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessAllTrades2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "trade" && reader.MoveToAttribute("secid"))
            data = data + reader.Name + ";" + reader.Value + ";";
          else
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "trade")
          {
            this.AddAllTrade(data);
            data = string.Empty;
          }
          else if (reader.Name == "alltrades")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessQuotes2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "quote" && reader.MoveToAttribute("secid"))
            data = data + reader.Name + ";" + reader.Value + ";";
          else
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "quote")
          {
            this.AddQuote(data);
            data = string.Empty;
          }
          else if (reader.Name == "quotes")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessCandles2(XmlReader reader)
    {
      string data = string.Empty;
      if (reader.MoveToAttribute("secid"))
        data = data + reader.Name + ";" + reader.Value + ";";
      if (reader.MoveToAttribute("board"))
        data = data + reader.Name + ";" + reader.Value + ";";
      if (reader.MoveToAttribute("seccode"))
        data = data + reader.Name + ";" + reader.Value + ";";
      if (reader.MoveToAttribute("period"))
        data = data + reader.Name + ";" + reader.Value + ";";
      if (reader.MoveToAttribute("status"))
        data = data + reader.Name + ";" + reader.Value + ";";
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "candle")
          {
            data = data + "|";
            if (reader.MoveToAttribute("date"))
              data = data + reader.Name + ";" + reader.Value + ";";
            if (reader.MoveToAttribute("open"))
              data = data + reader.Name + ";" + reader.Value + ";";
            if (reader.MoveToAttribute("close"))
              data = data + reader.Name + ";" + reader.Value + ";";
            if (reader.MoveToAttribute("high"))
              data = data + reader.Name + ";" + reader.Value + ";";
            if (reader.MoveToAttribute("low"))
              data = data + reader.Name + ";" + reader.Value + ";";
            if (reader.MoveToAttribute("volume"))
              data = data + reader.Name + ";" + reader.Value + ";";
          }
        }
        else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "candles")
        {
          this.AddCandle(data);
          string str = string.Empty;
          return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessTicks2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name != "tick")
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "tick")
          {
            this.AddTick(data);
            data = string.Empty;
          }
          else if (reader.Name == "ticks")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessOrders2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name == "order")
          {
            if (reader.MoveToAttribute("transactionid"))
              data = data + reader.Name + ";" + reader.Value + ";";
          }
          else if (reader.Name == "stoporder")
          {
            data = data + "|stoporder;";
            if (reader.MoveToAttribute("transactionid"))
              data = data + reader.Name + ";" + reader.Value + ";";
          }
          else if (reader.Name == "stoploss")
          {
            data = data + "|stoploss;";
            if (reader.MoveToAttribute("usecredit"))
              data = data + reader.Name + ";" + reader.Value + ";";
          }
          else
            data = !(reader.Name == "takeprofit") ? data + reader.Name + ";" : data + "|takeprofit;";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "order")
          {
            this.UpdateOrder(data);
            data = string.Empty;
          }
          else if (reader.Name == "stoporder")
          {
            this.UpdateStopOrder(data);
            data = string.Empty;
          }
          else if (reader.Name == "orders")
            return reader;
        }
      }
      return reader;
    }

    private XmlReader ProcessClientTrades2(XmlReader reader)
    {
      string data = string.Empty;
      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element)
        {
          if (reader.Name != "trade")
            data = data + reader.Name + ";";
        }
        else if (reader.NodeType == XmlNodeType.Text)
          data = data + reader.Value + ";";
        else if (reader.NodeType == XmlNodeType.EndElement)
        {
          if (reader.Name == "trade")
          {
            this.AddClientTrade(data);
            data = string.Empty;
          }
          else if (reader.Name == "trades")
            return reader;
        }
      }
      return reader;
    }

    private void AddMarket(string data)
    {
      TransaqMarket transaqMarket = new TransaqMarket(data);
      if (this.marketById.ContainsKey(transaqMarket.Id))
        return;
      this.marketById.Add(transaqMarket.Id, transaqMarket);
      SessionDataTypeEditor.markets.Add(transaqMarket.Id, transaqMarket.Name);
    }

    private void AddBoard(string data)
    {
      TransaqBoard transaqBoard = new TransaqBoard(data);
      if (this.boardById.ContainsKey(transaqBoard.Id))
        return;
      this.boardById.Add(transaqBoard.Id, transaqBoard);
    }

    private void AddCandleKind(string data)
    {
      TransaqCandleKind transaqCandleKind = new TransaqCandleKind(data);
      if (this.candleKindByPeriod.ContainsKey(transaqCandleKind.Period))
        return;
      this.candleKindByPeriod.Add(transaqCandleKind.Period, transaqCandleKind);
    }

    private void AddSecurity(string data)
    {
      TransaqSecurity transaqSecurity = new TransaqSecurity(data);
      if (!this.securityBySecId.ContainsKey(transaqSecurity.SecId))
        this.securityBySecId.Add(transaqSecurity.SecId, transaqSecurity);
      if (!this.securityBySCB.ContainsKey(transaqSecurity.SecCodeBoard))
        this.securityBySCB.Add(transaqSecurity.SecCodeBoard, transaqSecurity);
      if (SessionDataTypeEditor.instruments.ContainsKey(transaqSecurity.SecCodeBoard))
        return;
      SessionDataTypeEditor.instruments.Add(transaqSecurity.SecCodeBoard, transaqSecurity);
    }

    private void UpdateClient(string data)
    {
      TransaqClient transaqClient = new TransaqClient(data);
      try
      {
        this.rwClientById.EnterUpgradeableReadLock();
        if (transaqClient.Remove == "false" && !this.clientById.ContainsKey(transaqClient.Id))
        {
          this.rwClientById.EnterWriteLock();
          this.clientById.Add(transaqClient.Id, transaqClient);
          AccountSelectorEditor.clients.Add(transaqClient.Id);
        }
        if (!(transaqClient.Remove == "true") || !this.clientById.ContainsKey(transaqClient.Id))
          return;
        this.rwClientById.EnterWriteLock();
        this.clientById.Remove(transaqClient.Id);
        AccountSelectorEditor.clients.Remove(transaqClient.Id);
      }
      finally
      {
        if (this.rwClientById.IsWriteLockHeld)
          this.rwClientById.ExitWriteLock();
        this.rwClientById.ExitUpgradeableReadLock();
      }
    }

    private void UpdateServerStatus(string data)
    {
      TransaqServerStatus transaqServerStatus = new TransaqServerStatus(data);
      if (transaqServerStatus.Connected == "true")
      {
        try
        {
          string.Format("{0}LogFile{1}.txt", this.LogFilesDir.EndsWith("\\") ? (object) this.LogFilesDir : (object) (this.LogFilesDir + "\\"), (object) Clock.Now.ToString("yyMMdd"));
        }
        catch (Exception ex)
        {
          this.EmitError(ex.Message);
        }
        this.isConnected = true;
        this.EmitConnected();
      }
      else if (transaqServerStatus.Connected == "false")
      {
        this.candleKindByPeriod.Clear();
        this.tickEndTimeBySecId.Clear();
        this.tickEndTimeBySCB.Clear();
        this.hdrBySecId.Clear();
        this.hdrBySCB.Clear();
        this.openBookBySecId.Clear();
        this.openBookBySCB.Clear();
        this.bidOfferPairBySecId.Clear();
        this.securityBySecId.Clear();
        this.securityBySCB.Clear();
        this.instrumentBySymbol.Clear();
        try
        {
          this.rwClientById.EnterWriteLock();
          this.clientById.Clear();
        }
        finally
        {
          this.rwClientById.ExitWriteLock();
        }
        this.brokerAccountByClientId.Clear();
        this.marketById.Clear();
        this.boardById.Clear();
        AccountSelectorEditor.clients.Clear();
        SessionDataTypeEditor.instruments.Clear();
        if (this.isInitialize)
        {
          this.connector.ConnectorUnInitialize();
          this.isInitialize = false;
          this.connector.NewData -= new EventHandler<NewDataEventArgs>(this.ReceiveMessage);
        }
        this.isConnected = false;
        this.EmitDisconnected();
      }
      else
      {
        if (!(transaqServerStatus.Connected == "error"))
          return;
        this.candleKindByPeriod.Clear();
        this.tickEndTimeBySecId.Clear();
        this.tickEndTimeBySCB.Clear();
        this.hdrBySecId.Clear();
        this.hdrBySCB.Clear();
        this.openBookBySecId.Clear();
        this.openBookBySCB.Clear();
        this.bidOfferPairBySecId.Clear();
        this.securityBySecId.Clear();
        this.securityBySCB.Clear();
        this.instrumentBySymbol.Clear();
        try
        {
          this.rwClientById.EnterWriteLock();
          this.clientById.Clear();
        }
        finally
        {
          this.rwClientById.ExitWriteLock();
        }
        this.brokerAccountByClientId.Clear();
        this.marketById.Clear();
        this.boardById.Clear();
        AccountSelectorEditor.clients.Clear();
        SessionDataTypeEditor.instruments.Clear();
        if (this.isInitialize)
        {
          this.connector.ConnectorUnInitialize();
          this.isInitialize = false;
          this.connector.NewData -= new EventHandler<NewDataEventArgs>(this.ReceiveMessage);
        }
        this.isConnected = false;
        this.EmitError(transaqServerStatus.ErrorMessage);
        this.EmitDisconnected();
      }
    }

    private void AddQuotation(string data)
    {
      TransaqQuote transaqQuote = new TransaqQuote(data);
      BidOfferPair bidOfferPair = (BidOfferPair) null;
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        if (!this.bidOfferPairBySecId.ContainsKey(transaqQuote.SecId))
          this.bidOfferPairBySecId.Add(transaqQuote.SecId, new BidOfferPair());
        bidOfferPair = this.bidOfferPairBySecId[transaqQuote.SecId];
      }
      else if (this.selectedSecurity == SecuritySelector.seccode_board)
      {
        if (!this.bidOfferPairBySCB.ContainsKey(transaqQuote.SecCodeBoard))
          this.bidOfferPairBySCB.Add(transaqQuote.SecCodeBoard, new BidOfferPair());
        bidOfferPair = this.bidOfferPairBySCB[transaqQuote.SecCodeBoard];
      }
      bool flag = false;
      if (bidOfferPair.Bid != transaqQuote.Bid && transaqQuote.Bid != 0.0)
      {
        bidOfferPair.Bid = transaqQuote.Bid;
        if (transaqQuote.BidSize != 0.0)
          bidOfferPair.BidSize = transaqQuote.BidSize;
        flag = true;
      }
      if (bidOfferPair.Offer != transaqQuote.Offer && transaqQuote.Offer != 0.0)
      {
        bidOfferPair.Offer = transaqQuote.Offer;
        if (transaqQuote.OfferSize != 0.0)
          bidOfferPair.OfferSize = transaqQuote.OfferSize;
        flag = true;
      }
      if ((bidOfferPair.Bid == transaqQuote.Bid || transaqQuote.Bid == 0.0) && (bidOfferPair.BidSize != transaqQuote.BidSize && transaqQuote.BidSize != 0.0))
      {
        bidOfferPair.BidSize = transaqQuote.BidSize;
        flag = true;
      }
      if ((bidOfferPair.Offer == transaqQuote.Offer || transaqQuote.Offer == 0.0) && (bidOfferPair.OfferSize != transaqQuote.OfferSize && transaqQuote.OfferSize != 0.0))
      {
        bidOfferPair.OfferSize = transaqQuote.OfferSize;
        flag = true;
      }
      if (!flag)
        return;
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        this.EmitNewQuote(this.instrumentBySymbol[transaqQuote.SecCode], Clock.Now, bidOfferPair.Bid, (int) bidOfferPair.BidSize, bidOfferPair.Offer, (int) bidOfferPair.OfferSize);
        this.bidOfferPairBySecId[transaqQuote.SecId] = bidOfferPair;
      }
      else
      {
        if (this.selectedSecurity != SecuritySelector.seccode_board)
          return;
        this.EmitNewQuote(this.instrumentBySymbol[transaqQuote.SecCodeBoard], Clock.Now, bidOfferPair.Bid, (int) bidOfferPair.BidSize, bidOfferPair.Offer, (int) bidOfferPair.OfferSize);
        this.bidOfferPairBySCB[transaqQuote.SecCodeBoard] = bidOfferPair;
      }
    }

    private void AddAllTrade(string data)
    {
      TransaqTrade transaqTrade = new TransaqTrade(data);
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        this.EmitNewTrade(this.instrumentBySymbol[transaqTrade.SecCode], Clock.Now, transaqTrade.Price, transaqTrade.Quantity);
      }
      else
      {
        if (this.selectedSecurity != SecuritySelector.seccode_board)
          return;
        this.EmitNewTrade(this.instrumentBySymbol[transaqTrade.SecCodeBoard], Clock.Now, transaqTrade.Price, transaqTrade.Quantity);
      }
    }

    private void AddQuote(string data)
    {
      TransaqOpenBook tob = new TransaqOpenBook(data);
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        OpenBookReturn openBookReturn = this.openBookBySecId[tob.SecId].UpdateOpenBook(tob);
        if (!this.instrumentBySymbol.ContainsKey(tob.SecCode))
          return;
        this.EmitNewOrderBookUpdate(this.instrumentBySymbol[tob.SecCode], Clock.Now, openBookReturn.Side, openBookReturn.Action, openBookReturn.Price, openBookReturn.Size, openBookReturn.Position);
      }
      else
      {
        if (this.selectedSecurity != SecuritySelector.seccode_board)
          return;
        OpenBookReturn openBookReturn = this.openBookBySCB[tob.SecCodeBoard].UpdateOpenBook(tob);
        if (!this.instrumentBySymbol.ContainsKey(tob.SecCodeBoard))
          return;
        this.EmitNewOrderBookUpdate(this.instrumentBySymbol[tob.SecCodeBoard], Clock.Now, openBookReturn.Side, openBookReturn.Action, openBookReturn.Price, openBookReturn.Size, openBookReturn.Position);
      }
    }

    private void AddCandle(string data)
    {
      TransaqCandles transaqCandles = new TransaqCandles(data);
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        if (!this.hdrBySecId.ContainsKey(transaqCandles.SecId))
          return;
        switch (transaqCandles.Status)
        {
          case 0:
          case 1:
            foreach (TransaqCandle transaqCandle in transaqCandles.TransaqCandleList)
            {
              if (this.hdrBySecId[transaqCandles.SecId].BeginDate <= transaqCandle.Date && transaqCandle.Date < this.hdrBySecId[transaqCandles.SecId].EndDate)
                this.EmitNewHistoricalBar(this.hdrBySecId[transaqCandles.SecId], transaqCandle.Date, transaqCandle.Open, transaqCandle.High, transaqCandle.Low, transaqCandle.Close, (long) transaqCandle.Volume);
            }
            this.EmitHistoricalDataCompleted(this.hdrBySecId[transaqCandles.SecId]);
            this.hdrBySecId.Remove(transaqCandles.SecId);
            break;
          case 2:
            using (List<TransaqCandle>.Enumerator enumerator = transaqCandles.TransaqCandleList.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                TransaqCandle current = enumerator.Current;
                if (this.hdrBySecId[transaqCandles.SecId].BeginDate <= current.Date && current.Date < this.hdrBySecId[transaqCandles.SecId].EndDate)
                  this.EmitNewHistoricalBar(this.hdrBySecId[transaqCandles.SecId], current.Date, current.Open, current.High, current.Low, current.Close, (long) current.Volume);
              }
              break;
            }
          case 3:
            this.EmitHistoricalDataError(this.hdrBySecId[transaqCandles.SecId], "Historical data is unavailable. Candle.");
            break;
        }
      }
      else
      {
        if (this.selectedSecurity != SecuritySelector.seccode_board || !this.hdrBySCB.ContainsKey(transaqCandles.SecCodeBoard))
          return;
        switch (transaqCandles.Status)
        {
          case 0:
          case 1:
            foreach (TransaqCandle transaqCandle in transaqCandles.TransaqCandleList)
            {
              if (this.hdrBySCB[transaqCandles.SecCodeBoard].BeginDate <= transaqCandle.Date && transaqCandle.Date < this.hdrBySCB[transaqCandles.SecCodeBoard].EndDate)
                this.EmitNewHistoricalBar(this.hdrBySCB[transaqCandles.SecCodeBoard], transaqCandle.Date, transaqCandle.Open, transaqCandle.High, transaqCandle.Low, transaqCandle.Close, (long) transaqCandle.Volume);
            }
            this.EmitHistoricalDataCompleted(this.hdrBySCB[transaqCandles.SecCodeBoard]);
            this.hdrBySCB.Remove(transaqCandles.SecCodeBoard);
            break;
          case 2:
            using (List<TransaqCandle>.Enumerator enumerator = transaqCandles.TransaqCandleList.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                TransaqCandle current = enumerator.Current;
                if (this.hdrBySCB[transaqCandles.SecCodeBoard].BeginDate <= current.Date && current.Date < this.hdrBySCB[transaqCandles.SecCodeBoard].EndDate)
                  this.EmitNewHistoricalBar(this.hdrBySCB[transaqCandles.SecCodeBoard], current.Date, current.Open, current.High, current.Low, current.Close, (long) current.Volume);
              }
              break;
            }
          case 3:
            this.EmitHistoricalDataError(this.hdrBySCB[transaqCandles.SecCodeBoard], "Historical data is unavailable. Candle.");
            break;
        }
      }
    }

    private void AddTick(string data)
    {
      TransaqTick transaqTick = new TransaqTick(data);
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        if (!this.hdrBySecId.ContainsKey(transaqTick.SecId))
          return;
        if (transaqTick.TradeTime >= this.tickEndTimeBySecId[transaqTick.SecId] || transaqTick.TradeTime > this.hdrBySecId[transaqTick.SecId].EndDate)
        {
          if (this.SendCommandLine("<command id=\"subscribe_ticks\" filter=\"true\" />\0").Success)
          {
            this.EmitHistoricalDataCompleted(this.hdrBySecId[transaqTick.SecId]);
            this.hdrBySecId.Remove(transaqTick.SecId);
            this.tickEndTimeBySecId.Remove(transaqTick.SecId);
          }
          else
            this.EmitHistoricalDataError(this.hdrBySecId[transaqTick.SecId], "Historical data is unavailable. Tick.");
        }
        if (!(this.hdrBySecId[transaqTick.SecId].BeginDate <= transaqTick.TradeTime) || !(transaqTick.TradeTime <= this.hdrBySecId[transaqTick.SecId].EndDate))
          return;
        this.EmitNewHistoricalTrade(this.hdrBySecId[transaqTick.SecId], transaqTick.TradeTime, transaqTick.Price, transaqTick.Quantity);
      }
      else
      {
        if (this.selectedSecurity != SecuritySelector.seccode_board || !this.hdrBySCB.ContainsKey(transaqTick.SecCodeBoard))
          return;
        if (transaqTick.TradeTime >= this.tickEndTimeBySCB[transaqTick.SecCodeBoard] || transaqTick.TradeTime > this.hdrBySCB[transaqTick.SecCodeBoard].EndDate)
        {
          if (this.SendCommandLine("<command id=\"subscribe_ticks\" filter=\"true\" />\0").Success)
          {
            this.EmitHistoricalDataCompleted(this.hdrBySCB[transaqTick.SecCodeBoard]);
            this.hdrBySCB.Remove(transaqTick.SecCodeBoard);
            this.tickEndTimeBySCB.Remove(transaqTick.SecCodeBoard);
          }
          else
            this.EmitHistoricalDataError(this.hdrBySCB[transaqTick.SecCodeBoard], "Historical data is unavailable. Tick.");
        }
        if (!(this.hdrBySCB[transaqTick.SecCodeBoard].BeginDate <= transaqTick.TradeTime) || !(transaqTick.TradeTime <= this.hdrBySCB[transaqTick.SecCodeBoard].EndDate))
          return;
        this.EmitNewHistoricalTrade(this.hdrBySCB[transaqTick.SecCodeBoard], transaqTick.TradeTime, transaqTick.Price, transaqTick.Quantity);
      }
    }

    private void UpdateOrder(string data)
    {
      if (!this.isConnected)
        return;
      TransaqOrder to = new TransaqOrder(data);
      TransaqOrder transaqOrder = (TransaqOrder) null;
      Order order = (Order) null;
      try
      {
        this.rwTransaqOrderByTrId.EnterUpgradeableReadLock();
        if (!this.transaqOrderByTrId.TryGetValue(to.TransactionId, out transaqOrder))
        {
          this.rwTransaqOrderByTrId.EnterWriteLock();
          this.transaqOrderByTrId.Add(to.TransactionId, to);
        }
        else
        {
          transaqOrder.Update(to);
          to = transaqOrder;
          this.rwTransaqOrderByTrId.EnterWriteLock();
          this.transaqOrderByTrId[to.TransactionId] = to;
        }
      }
      finally
      {
        if (this.rwTransaqOrderByTrId.IsWriteLockHeld)
          this.rwTransaqOrderByTrId.ExitWriteLock();
        this.rwTransaqOrderByTrId.ExitUpgradeableReadLock();
      }
      try
      {
        this.rwOrderByOrdId.EnterReadLock();
        this.orderByOrdId.TryGetValue(to.TransactionId.ToString(), out order);
      }
      finally
      {
        this.rwOrderByOrdId.ExitReadLock();
      }
      if (order == null)
      {
        try
        {
          this.rwOrderByOrdNo.EnterReadLock();
          this.orderByOrdNo.TryGetValue(to.OrderNo, out order);
        }
        finally
        {
          this.rwOrderByOrdNo.ExitReadLock();
        }
        if (order != null)
        {
          order.OrderID = to.TransactionId.ToString();
          try
          {
            this.rwOrderByOrdId.EnterWriteLock();
            this.orderByOrdId.Add(order.OrderID, order);
          }
          finally
          {
            this.rwOrderByOrdId.ExitWriteLock();
          }
        }
        else
        {
          if (!this.OutputUnknownOrderError)
            return;
          this.EmitError(string.Format("Unknown order. TransactionID={0} OrderNo={1}", (object) to.TransactionId, (object) to.OrderNo));
          return;
        }
      }
      if (to.OrderNo != 0L)
      {
        try
        {
          this.rwOrderByOrdNo.EnterUpgradeableReadLock();
          if (!this.orderByOrdNo.ContainsKey(to.OrderNo))
          {
            this.rwOrderByOrdNo.EnterWriteLock();
            this.orderByOrdNo.Add(to.OrderNo, order);
          }
        }
        finally
        {
          if (this.rwOrderByOrdNo.IsWriteLockHeld)
            this.rwOrderByOrdNo.ExitWriteLock();
          this.rwOrderByOrdNo.ExitUpgradeableReadLock();
        }
      }
      if (string.IsNullOrWhiteSpace(to.Status))
        return;
      switch (to.Status)
      {
        case "active":
        case "wait":
        case "watching":
          if (order.Status == OrderStatus.PendingNew && to.OrderNo != 0L)
          {
            this.EmitAccepted(order);
            break;
          }
          else
            break;
        case "cancelled":
          if (to.WithdrawTime == "0")
          {
            this.EmitPendingCancel(order);
            break;
          }
          else if ((double) to.Quantity == to.Balance || order.LeavesQty == to.Balance)
          {
            this.EmitCancelled(order);
            break;
          }
          else if (!this.balanceByOrderNoForCancel.ContainsKey(to.OrderNo))
          {
            this.balanceByOrderNoForCancel.Add(to.OrderNo, to.Balance);
            break;
          }
          else
          {
            this.balanceByOrderNoForCancel[to.OrderNo] = to.Balance;
            break;
          }
        case "disabled":
        case "removed":
          if ((double) to.Quantity == to.Balance || order.LeavesQty == to.Balance)
          {
            this.EmitRejected(order, to.Result);
            break;
          }
          else if (!this.balanceByOrderNoForCancel.ContainsKey(to.OrderNo))
          {
            this.balanceByOrderNoForCancel.Add(to.OrderNo, to.Balance);
            break;
          }
          else
          {
            this.balanceByOrderNoForCancel[to.OrderNo] = to.Balance;
            break;
          }
        case "denied":
        case "failed":
        case "refused":
        case "rejected":
          this.EmitRejected(order, to.Result);
          break;
      }
      if (!order.IsDone)
        return;
      this.RemoveOrder(to.TransactionId, to.OrderNo, true, true, true, false);
    }

    private void UpdateStopOrder(string data)
    {
      TransaqStopOrder tso = new TransaqStopOrder(data);
      TransaqStopOrder transaqStopOrder = (TransaqStopOrder) null;
      Order order = (Order) null;
      try
      {
        this.rwTransaqStopOrderByTrId.EnterUpgradeableReadLock();
        if (!this.transaqStopOrderByTrId.TryGetValue(tso.TransactionId, out transaqStopOrder))
        {
          this.rwTransaqStopOrderByTrId.EnterWriteLock();
          this.transaqStopOrderByTrId.Add(tso.TransactionId, tso);
        }
        else
        {
          transaqStopOrder.Update(tso);
          tso = transaqStopOrder;
          this.rwTransaqStopOrderByTrId.EnterWriteLock();
          this.transaqStopOrderByTrId[tso.TransactionId] = tso;
        }
      }
      finally
      {
        if (this.rwTransaqStopOrderByTrId.IsWriteLockHeld)
          this.rwTransaqStopOrderByTrId.ExitWriteLock();
        this.rwTransaqStopOrderByTrId.ExitUpgradeableReadLock();
      }
      try
      {
        this.rwOrderByOrdId.EnterReadLock();
        this.orderByOrdId.TryGetValue(tso.TransactionId.ToString(), out order);
      }
      finally
      {
        this.rwOrderByOrdId.ExitReadLock();
      }
      if (order == null)
      {
        if (!this.OutputUnknownOrderError || !this.isConnected)
          return;
        this.EmitError(string.Format("Unknown stoporder. TransactionID={0}", (object) tso.TransactionId));
      }
      else
      {
        if (string.IsNullOrWhiteSpace(tso.Status))
          return;
        switch (tso.Status)
        {
          case "watching":
            if (order.Status == OrderStatus.PendingNew)
            {
              this.EmitAccepted(order);
              break;
            }
            else
              break;
          case "cancelled":
            if (tso.WithdrawTime == "0")
            {
              if (order.Status != OrderStatus.PendingCancel && order.Status != OrderStatus.Cancelled)
              {
                this.EmitPendingCancel(order);
                break;
              }
              else
                break;
            }
            else if (order.Status != OrderStatus.Cancelled)
            {
              this.EmitCancelled(order);
              break;
            }
            else
              break;
          case "disabled":
            if (order.Status != OrderStatus.Cancelled)
            {
              this.EmitCancelled(order);
              break;
            }
            else
              break;
          case "denied":
          case "expired":
          case "failed":
          case "rejected":
            if (order.Status != OrderStatus.Rejected)
            {
              this.EmitRejected(order, tso.Result);
              break;
            }
            else
              break;
          case "sl_executed":
          case "tp_executed":
            if (tso.ActiveOrderNo != 0L)
            {
              try
              {
                this.rwOrderByOrdNo.EnterUpgradeableReadLock();
                if (!this.orderByOrdNo.ContainsKey(tso.ActiveOrderNo))
                {
                  this.rwOrderByOrdNo.EnterWriteLock();
                  this.orderByOrdNo.Add(tso.ActiveOrderNo, order);
                }
              }
              finally
              {
                if (this.rwOrderByOrdNo.IsWriteLockHeld)
                  this.rwOrderByOrdNo.ExitWriteLock();
                this.rwOrderByOrdNo.ExitUpgradeableReadLock();
              }
              this.RemoveOrder(tso.TransactionId, tso.ActiveOrderNo, true, false, false, true);
              break;
            }
            else
              break;
        }
        if (!order.IsDone)
          return;
        this.RemoveOrder(tso.TransactionId, tso.ActiveOrderNo, true, false, false, true);
      }
    }

    private void AddClientTrade(string data)
    {
      TransaqClientTrade transaqClientTrade = new TransaqClientTrade(data);
      Order order = (Order) null;
      try
      {
        this.rwOrderByOrdNo.EnterReadLock();
        this.orderByOrdNo.TryGetValue(transaqClientTrade.OrderNo, out order);
      }
      finally
      {
        this.rwOrderByOrdNo.ExitReadLock();
      }
      if (this.clientTradeNo.ContainsKey(transaqClientTrade.TradeNo))
        return;
      if (order != null)
      {
        if (order.Status == OrderStatus.PendingNew && transaqClientTrade.OrderNo != 0L)
          this.EmitAccepted(order);
        this.EmitFilled(order, transaqClientTrade.Price, transaqClientTrade.Quantity, CommissionType.Absolute, transaqClientTrade.Commission);
        if (this.balanceByOrderNoForCancel.ContainsKey(transaqClientTrade.OrderNo) && order.LeavesQty == this.balanceByOrderNoForCancel[transaqClientTrade.OrderNo])
        {
          this.EmitCancelled(order);
          this.balanceByOrderNoForCancel.Remove(transaqClientTrade.OrderNo);
        }
        long result = 0L;
        if (order.IsDone && long.TryParse(order.OrderID, out result))
          this.RemoveOrder(result, transaqClientTrade.OrderNo, true, true, true, true);
      }
      this.clientTradeNo.Add(transaqClientTrade.TradeNo, (object) null);
    }

    private void RemoveOrder(long trId, long orderNo, bool ordByOrdId, bool ordByOrdNo, bool trOrdByTrId, bool trStopOrdByTrId)
    {
      if (ordByOrdId)
      {
        try
        {
          this.rwOrderByOrdId.EnterWriteLock();
          this.orderByOrdId.Remove(trId.ToString());
        }
        finally
        {
          this.rwOrderByOrdId.ExitWriteLock();
        }
      }
      if (ordByOrdNo)
      {
        try
        {
          this.rwOrderByOrdNo.EnterWriteLock();
          this.orderByOrdNo.Remove(orderNo);
        }
        finally
        {
          this.rwOrderByOrdNo.ExitWriteLock();
        }
      }
      if (trOrdByTrId)
      {
        try
        {
          this.rwTransaqOrderByTrId.EnterWriteLock();
          this.transaqOrderByTrId.Remove(trId);
        }
        finally
        {
          this.rwTransaqOrderByTrId.ExitWriteLock();
        }
      }
      if (!trStopOrdByTrId)
        return;
      try
      {
        this.rwTransaqStopOrderByTrId.EnterWriteLock();
        this.transaqStopOrderByTrId.Remove(trId);
      }
      finally
      {
        this.rwTransaqStopOrderByTrId.ExitWriteLock();
      }
    }

    protected override void Subscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
    {
      if (!this.isConnected)
        return;
      TransaqSecurity transaqSecurity1 = (TransaqSecurity) null;
      string symbol = instrument.GetSymbol(this.name);
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        foreach (int index in this.securityBySecId.Keys)
        {
          TransaqSecurity transaqSecurity2 = this.securityBySecId[index];
          if (transaqSecurity2.SecCode == symbol)
          {
            transaqSecurity1 = transaqSecurity2;
            break;
          }
        }
      }
      else if (this.selectedSecurity == SecuritySelector.seccode_board)
      {
        foreach (string index in this.securityBySCB.Keys)
        {
          TransaqSecurity transaqSecurity2 = this.securityBySCB[index];
          if (transaqSecurity2.SecCodeBoard == symbol)
          {
            transaqSecurity1 = transaqSecurity2;
            break;
          }
        }
      }
      if (transaqSecurity1 == null)
      {
        this.EmitError(string.Format("Unknown instrument {0} for subscribe {1}", (object) symbol, (object) subscriptionDataType));
      }
      else
      {
        if (!this.instrumentBySymbol.ContainsKey(symbol))
          this.instrumentBySymbol.Add(symbol, instrument);
        if (this.selectedSecurity == SecuritySelector.seccode)
        {
          string str = "<command id=\"subscribe\">";
          if (subscriptionDataType == SubscriptionDataType.Trades)
            str = string.Concat(new object[4]
            {
              (object) str,
              (object) "<alltrades><secid>",
              (object) transaqSecurity1.SecId,
              (object) "</secid></alltrades>"
            });
          else if (subscriptionDataType == SubscriptionDataType.Quotes)
            str = string.Concat(new object[4]
            {
              (object) string.Concat(new object[4]
              {
                (object) str,
                (object) "<quotations><secid>",
                (object) transaqSecurity1.SecId,
                (object) "</secid></quotations>"
              }),
              (object) "<quotes><secid>",
              (object) transaqSecurity1.SecId,
              (object) "</secid></quotes>"
            });
          else if (subscriptionDataType == SubscriptionDataType.OrderBook)
            return;
          if (!this.SendCommandLine(str + "</command>").Success || this.openBookBySecId.ContainsKey(transaqSecurity1.SecId))
            return;
          this.openBookBySecId.Add(transaqSecurity1.SecId, new OpenBook());
        }
        else
        {
          if (this.selectedSecurity != SecuritySelector.seccode_board)
            return;
          string str = "<command id=\"subscribe\">";
          if (subscriptionDataType == SubscriptionDataType.Trades)
            str = str + "<alltrades><security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security></alltrades>";
          else if (subscriptionDataType == SubscriptionDataType.Quotes)
            str = str + "<quotations><security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security></quotations>" + "<quotes><security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security></quotes>";
          else if (subscriptionDataType == SubscriptionDataType.OrderBook)
            return;
          if (!this.SendCommandLine(str + "</command>").Success || this.openBookBySCB.ContainsKey(transaqSecurity1.SecCodeBoard))
            return;
          this.openBookBySCB.Add(transaqSecurity1.SecCodeBoard, new OpenBook());
        }
      }
    }

    protected override void Unsubscribe(Instrument instrument, SubscriptionDataType subscriptionDataType)
    {
      if (!this.isConnected)
        return;
      TransaqSecurity transaqSecurity1 = (TransaqSecurity) null;
      string symbol = instrument.GetSymbol(this.name);
      if (this.selectedSecurity == SecuritySelector.seccode)
      {
        foreach (int index in this.securityBySecId.Keys)
        {
          TransaqSecurity transaqSecurity2 = this.securityBySecId[index];
          if (transaqSecurity2.SecCode == symbol)
          {
            transaqSecurity1 = transaqSecurity2;
            break;
          }
        }
      }
      else if (this.selectedSecurity == SecuritySelector.seccode_board)
      {
        foreach (string index in this.securityBySCB.Keys)
        {
          TransaqSecurity transaqSecurity2 = this.securityBySCB[index];
          if (transaqSecurity2.SecCodeBoard == symbol)
          {
            transaqSecurity1 = transaqSecurity2;
            break;
          }
        }
      }
      if (transaqSecurity1 == null)
        this.EmitError(string.Format("Unknown instrument {0} for unsubscribe {1}", (object) symbol, (object) subscriptionDataType));
      else if (this.selectedSecurity == SecuritySelector.seccode)
      {
        string str = "<command id=\"unsubscribe\">";
        if (subscriptionDataType == SubscriptionDataType.Trades)
          str = string.Concat(new object[4]
          {
            (object) str,
            (object) "<alltrades><secid>",
            (object) transaqSecurity1.SecId,
            (object) "</secid></alltrades>"
          });
        else if (subscriptionDataType == SubscriptionDataType.Quotes)
          str = string.Concat(new object[4]
          {
            (object) string.Concat(new object[4]
            {
              (object) str,
              (object) "<quotations><secid>",
              (object) transaqSecurity1.SecId,
              (object) "</secid></quotations>"
            }),
            (object) "<quotes><secid>",
            (object) transaqSecurity1.SecId,
            (object) "</secid></quotes>"
          });
        else if (subscriptionDataType == SubscriptionDataType.OrderBook)
          return;
        if (!this.SendCommandLine(str + "</command>").Success || !this.openBookBySecId.ContainsKey(transaqSecurity1.SecId))
          return;
        this.openBookBySecId.Remove(transaqSecurity1.SecId);
      }
      else
      {
        if (this.selectedSecurity != SecuritySelector.seccode_board)
          return;
        string str = "<command id=\"unsubscribe\">";
        if (subscriptionDataType == SubscriptionDataType.Trades)
          str = str + "<alltrades><security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security></alltrades>";
        else if (subscriptionDataType == SubscriptionDataType.Quotes)
          str = str + "<quotations><security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security></quotations>" + "<quotes><security><board>" + transaqSecurity1.Board + "</board><seccode>" + transaqSecurity1.SecCode + "</seccode></security></quotes>";
        else if (subscriptionDataType == SubscriptionDataType.OrderBook)
          return;
        if (!this.SendCommandLine(str + "</command>").Success || !this.openBookBySCB.ContainsKey(transaqSecurity1.SecCodeBoard))
          return;
        this.openBookBySCB.Remove(transaqSecurity1.SecCodeBoard);
      }
    }
  }
}
