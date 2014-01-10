using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Providers;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class Instrument : FIXInstrument
  {
    private const string ErF6qIRY8C = "F2";
    private Currency mEf6f8TGiq;
    private Exchange TNc6pL8cK3;
    private LegList uIJ6vbhTOX;
    private UnderlyingList JAT65L3WwQ;
    private IPricer pricer;
    private Quote quote;
    private Trade trade;
    private Bar bar;
    private MarketDepth marketDepth;
    private Fundamental fundamental;
    private CorporateAction mLj6n4gDEd;
    private OrderBook Dvj6i1WTmP;
    private double cAF6h0NHaN;

    [Description("Indicates whether an Option is for a put or call.")]
    [Category("Derivative")]
    public PutOrCall PutOrCall
    {
       get
      {
        return FIXPutOrCall.FromFIX(base.PutOrCall);
      }
        set
      {
        base.PutOrCall = FIXPutOrCall.ToFIX(value);
      }
    }

    [Browsable(false)]
    public Exchange Exchange
    {
       get
      {
        return this.TNc6pL8cK3;
      }
       set
      {
        this.TNc6pL8cK3 = value;
      }
    }

    [Description("List of instrument legs")]
    [Editor(typeof (em03FhdRrsMhLEot1L), typeof (UITypeEditor))]
    [Category("Attributes")]
    public LegList Legs
    {
       get
      {
        return this.uIJ6vbhTOX;
      }
    }

    [Description("List of instrument underlyings")]
    [Category("Attributes")]
    [Editor(typeof (eHiaMMJnVTTEAxAjWe), typeof (UITypeEditor))]
    public UnderlyingList Underlyings
    {
       get
      {
        return this.JAT65L3WwQ;
      }
    }

    [Browsable(false)]
    public IPricer Pricer
    {
       get
      {
				return this.pricer; 
      }
       set
      {
        this.pricer = value;
      }
    }

    [Category("Trade")]
    [Description("Identifies the form of delivery")]
    [FIXField("668", EFieldOption.Optional)]
    public int DeliveryForm
    {
       get
      {
        return this.GetIntValue(668);
      }
       set
      {
        this.SetIntValue(668, value);
      }
    }

    [Category("Trade")]
    [FIXField("869", EFieldOption.Optional)]
    [Description("Percent at risk due to lowest possible call.")]
    public double PctAtRisk
    {
       get
      {
        return this.GetDoubleValue(869);
      }
       set
      {
        this.SetDoubleValue(869, value);
      }
    }

    [Category("Appearance")]
    [FIXField("15", EFieldOption.Optional)]
    [Description("Identifies currency used for price. Absence of this field is interpreted as the default for the security.  It is recommended that systems provide the currency value whenever possible.")]
    public string Currency
    {
       get
      {
        return this.GetStringValue(15);
      }
       set
      {
        this.SetStringValue(15, value);
        this.mEf6f8TGiq = CurrencyManager.Currencies[value];
        if (this.mEf6f8TGiq != null)
          return;
        this.mEf6f8TGiq = CurrencyManager.DefaultCurrency;
      }
    }

    [Description("Identifier for Trading Session. Can be used to represent a specific market trading session (e.g. PRE-OPEN, CROSS_2, AFTER-HOURS, TOSTNET1, TOSTNET2, etc).")]
    [FIXField("336", EFieldOption.Optional)]
    [Category("Trade")]
    public string TradingSessionID
    {
       get
      {
        return this.GetStringValue(336);
      }
       set
      {
        this.SetStringValue(336, value);
      }
    }

    [Description("Optional market assigned sub identifier for a trading session. Usage is determined by market or counterparties. Used by US based futures markets to identify exchange specific execution time bracket codes as required by US market regulations.")]
    [Category("Trade")]
    [FIXField("625", EFieldOption.Optional)]
    public string TradingSessionSubID
    {
       get
      {
        return this.GetStringValue(625);
      }
       set
      {
        this.SetStringValue(625, value);
      }
    }

    [FIXField("827", EFieldOption.Optional)]
    [Category("Trade")]
    [Description("Part of trading cycle when an instrument expires. Field is applicable for derivatives.")]
    public int ExpirationCycle
    {
       get
      {
        return this.GetIntValue(827);
      }
       set
      {
        this.SetIntValue(827, value);
      }
    }

    [Category("Trade")]
    [Description("The trading lot size of a security")]
    [FIXField("561", EFieldOption.Optional)]
    public double RoundLot
    {
       get
      {
        return this.GetDoubleValue(561);
      }
       set
      {
        this.SetDoubleValue(561, value);
      }
    }

    [FIXField("562", EFieldOption.Optional)]
    [Description("The minimum trading volume for a security")]
    [Category("Trade")]
    public double MinTradeVol
    {
       get
      {
        return this.GetDoubleValue(562);
      }
       set
      {
        this.SetDoubleValue(562, value);
      }
    }

    [Category("Industry")]
    [FIXField("10100", EFieldOption.Optional)]
    [Description("Industry code")]
    public string IndustryCode
    {
       get
      {
        return this.GetStringValue(10100);
      }
       set
      {
        this.SetStringValue(10100, value);
      }
    }

    [FIXField("10101", EFieldOption.Optional)]
    [Description("Industry sector")]
    [Category("Industry")]
    public string IndustrySector
    {
       get
      {
        return this.GetStringValue(10101);
      }
       set
      {
        this.SetStringValue(10101, value);
      }
    }

    [Description("Industry group")]
    [FIXField("10102", EFieldOption.Optional)]
    [Category("Industry")]
    public string IndustryGroup
    {
       get
      {
        return this.GetStringValue(10102);
      }
       set
      {
        this.SetStringValue(10102, value);
      }
    }

    [Category("Industry")]
    [Description("Industry sub group")]
    [FIXField("10103", EFieldOption.Optional)]
    public string IndustrySubGroup
    {
       get
      {
        return this.GetStringValue(10103);
      }
       set
      {
        this.SetStringValue(10103, value);
      }
    }

    [Description("Price display")]
    [Category("Price format")]
    [FIXField("10103", EFieldOption.Optional)]
    [DefaultValue("F2")]
    public string PriceDisplay
    {
       get
      {
        return this.GetStringValue(11105);
      }
       set
      {
        this.SetStringValue(11105, value);
      }
    }

    [Category("Margin")]
    [FIXField("10600", EFieldOption.Optional)]
    [Description("Initial margin")]
    public double Margin
    {
       get
      {
        return this.GetDoubleValue(10600);
      }
       set
      {
        this.SetDoubleValue(10600, value);
      }
    }

    [Browsable(false)]
    public Quote Quote
    {
       get
      {
        return this.quote;
      }
    }

    [Browsable(false)]
    public Trade Trade
    {
       get
      {
        return this.trade;
      }
    }

    [Browsable(false)]
    public Bar Bar
    {
       get
      {
        return this.bar;
      }
    }

    [Browsable(false)]
    public MarketDepth MarketDepth
    {
       get
      {
        return this.marketDepth;
      }
    }

    [Browsable(false)]
    public Fundamental Fundamental
    {
       get
      {
        return this.fundamental;
      }
    }

    [Browsable(false)]
    public CorporateAction CorporateAction
    {
       get
      {
        return this.mLj6n4gDEd;
      }
    }

    [Browsable(false)]
    public OrderBook OrderBook
    {
       get
      {
        return this.Dvj6i1WTmP;
      }
    }

    [Browsable(false)]
    public double Change
    {
       get
      {
        return this.cAF6h0NHaN;
      }
    }

    [Browsable(false)]
    public QuoteArray Quotes
    {
       get
      {
        return DataManager.Quotes[this];
      }
    }

    [Browsable(false)]
    public TradeArray Trades
    {
       get
      {
        return DataManager.Trades[this];
      }
    }

    [Browsable(false)]
    public BarSeries Bars
    {
       get
      {
        return DataManager.Bars[this];
      }
    }

    public event QuoteEventHandler NewQuote;

    public event TradeEventHandler NewTrade;

    public event BarEventHandler NewBar;

    public event BarEventHandler NewBarOpen;

    public event MarketDepthEventHandler NewMarketDepth;

    public event FundamentalEventHandler NewFundamental;

    public event CorporateActionEventHandler NewCorporateAction;

		protected Instrument() : base()
    {
      this.uIJ6vbhTOX = new LegList();
      this.JAT65L3WwQ = new UnderlyingList();
      this.pricer = (IPricer) new Pricer();
      this.quote = new Quote();
      this.trade = new Trade();
      this.bar = new Bar();
      this.marketDepth = new MarketDepth();
      this.fundamental = new Fundamental();
      this.mLj6n4gDEd = new CorporateAction();
      this.Dvj6i1WTmP = new OrderBook();
      this.PriceDisplay = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3196);
    }

	public Instrument(string symbol) : this(symbol, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3204))
    {
    }

    public Instrument(string symbol, string securityType)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.uIJ6vbhTOX = new LegList();
      this.JAT65L3WwQ = new UnderlyingList();
      this.pricer = (IPricer) new Pricer();
      this.quote = new Quote();
      this.trade = new Trade();
      this.bar = new Bar();
      this.marketDepth = new MarketDepth();
      this.fundamental = new Fundamental();
      this.mLj6n4gDEd = new CorporateAction();
      this.Dvj6i1WTmP = new OrderBook();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Symbol = symbol;
      this.SecurityType = securityType;
      this.PriceDisplay = !(securityType == gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3212)) ? gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3230) : gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3222);
      InstrumentManager.VljEVFlVHf(this);
    }

    public Currency GetCurrency()
    {
      if (this.mEf6f8TGiq != null)
        return this.mEf6f8TGiq;
      this.mEf6f8TGiq = CurrencyManager.Currencies[this.Currency];
      if (this.mEf6f8TGiq == null)
        this.mEf6f8TGiq = CurrencyManager.DefaultCurrency;
      return this.mEf6f8TGiq;
    }

    public string GetSymbol(string source)
    {
      if (this.SecurityIDSource == source)
        return this.SecurityID;
      foreach (FIXSecurityAltIDGroup securityAltIdGroup in (FIXGroupList) this.fSecurityAltIDGroup)
      {
        if (securityAltIdGroup.SecurityAltIDSource == source && securityAltIdGroup.SecurityAltID != "")
          return securityAltIdGroup.SecurityAltID;
      }
      return this.Symbol;
    }

    
    public void AddSymbol(string symbol, string source)
    {
      this.AddGroup(new FIXSecurityAltIDGroup()
      {
        SecurityAltID = symbol,
        SecurityAltIDSource = source
      });
    }

    
    public void AddSymbol(string symbol, string securityExchange, string source)
    {
      this.AddGroup(new FIXSecurityAltIDGroup()
      {
        SecurityAltExchange = securityExchange,
        SecurityAltID = symbol,
        SecurityAltIDSource = source
      });
    }

    public string GetSecurityExchange(string source)
    {
      foreach (FIXSecurityAltIDGroup securityAltIdGroup in (FIXGroupList) this.fSecurityAltIDGroup)
      {
        if (securityAltIdGroup.SecurityAltIDSource == source && securityAltIdGroup.SecurityAltExchange != "")
          return securityAltIdGroup.SecurityAltExchange;
      }
      return this.SecurityExchange;
    }

    public void Save()
    {
      InstrumentManager.DdbEFF4dAg(this);
    }

    public virtual double Price()
    {
 		this.pricer.Price(this);
    }

    public virtual double Price(DateTime datetime)
    {
		this.pricer.Price(this, datetime);
    }

    public virtual double Volatility()
    {
   		this.pricer.Volatility(this);
    }

    public double Delta()
    {
      	this.pricer.Delta(this);
    }

    public double Delta(DateTime datetime)
    {
     	this.pricer.Delta(this, datetime);
    }

    public double Gamma()
    {
      	this.pricer.Gamma(this);
    }

    public double Gamma(DateTime datetime)
    {
		this.pricer.Gamma(this, datetime);
    }

    public double Theta()
    {
		this.pricer.Theta(this);
    }

    public double Theta(DateTime datetime)
    {
		this.pricer.Theta(this, datetime);
    }

    public double Rho()
    {
      	this.pricer.Rho(this);
    }

    public double Rho(DateTime datetime)
    {
     	this.pricer.Rho(this, datetime);
    }

    public double Vega()
    {
      	this.pricer.Vega(this);
    }

    public double Vega(DateTime datetime)
    {
     	this.pricer.Vega(this, datetime);
    }

    public void Reset()
    {
			this.bar = new Bar(); 
			this.quote = new Quote(); 
			this.trade = new Trade(); 
			this.marketDepth = new MarketDepth(); 
			this.fundamental = new Fundamental(); 
			this.mLj6n4gDEd = new CorporateAction(); 
			this.cAF6h0NHaN = 0.0; 
    }

    internal void JLw6D59Mxc([In] QuoteEventArgs obj0)
    {
      this.quote = obj0.Quote;
      if (this.TdT6S1usZL == null)
        return;
      this.TdT6S1usZL((object) this, obj0);
    }

    internal void akq60u3HYf([In] TradeEventArgs obj0)
    {
      if (this.trade.Price != 0.0 && this.trade.Price != obj0.Trade.Price)
        this.cAF6h0NHaN = obj0.Trade.Price - this.trade.Price;
      this.trade = obj0.Trade;
      if (this.Uyq6ZtLUjA == null)
        return;
      this.Uyq6ZtLUjA((object) this, obj0);
    }

    
    internal void trS6Hr1Wkt([In] BarEventArgs obj0)
    {
      this.bar = obj0.Bar;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Concat(new object[4]
        {
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3938),
          (object) this.Symbol,
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3988),
          (object) this.bar
        }));
      if (this.LGt6AP0Acf == null)
        return;
      this.LGt6AP0Acf((object) this, obj0);
    }

    
    internal void ami6cstOZQ([In] BarEventArgs obj0)
    {
      this.bar = obj0.Bar;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Concat(new object[4]
        {
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3994),
          (object) this.Symbol,
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(4052),
          (object) this.bar
        }));
      if (this.iPM6grNm2V == null)
        return;
      this.iPM6grNm2V((object) this, obj0);
    }

    
    internal void aSE6VetHfX([In] MarketDepthEventArgs obj0)
    {
      this.marketDepth = obj0.MarketDepth;
      if (this.apm61EO0je != null)
        this.apm61EO0je((object) this, obj0);
      this.Dvj6i1WTmP.Add(obj0.MarketDepth);
    }

    
    internal void a1w6FaBIwx([In] FundamentalEventArgs obj0)
    {
      this.fundamental = obj0.Fundamental;
      if (this.fYq6oMJm1K == null)
        return;
      this.fYq6oMJm1K((object) this, obj0);
    }

    
    internal void KPy6yCSTBZ([In] CorporateActionEventArgs obj0)
    {
      this.mLj6n4gDEd = obj0.CorporateAction;
      if (this.Nhy6xRMm7T == null)
        return;
      this.Nhy6xRMm7T((object) this, obj0);
    }

    
    public void Add(string series, Trade trade)
    {
      DataManager.Add(this, series, trade);
    }

    
    public void Add(Trade trade)
    {
      DataManager.Add(this, trade);
    }

    
    public void Add(string series, Quote quote)
    {
      DataManager.Add(this, series, quote);
    }

    
    public void Add(Quote quote)
    {
      DataManager.Add(this, quote);
    }

    
    public void Add(string series, Bar bar)
    {
      DataManager.Add(this, series, bar);
    }

    
    public void Add(Bar bar)
    {
      DataManager.Add(this, bar);
    }

    
    public void Add(Daily daily)
    {
      DataManager.Add(this, daily);
    }

    
    public void Add(string series, MarketDepth marketDepth)
    {
      DataManager.Add(this, series, marketDepth);
    }

    
    public void Add(MarketDepth marketDepth)
    {
      DataManager.Add(this, marketDepth);
    }

    
    public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetTradeArray(this, series, datetime1, datetime2);
    }

    
    public TradeArray GetTradeArray(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetTradeArray(this, datetime1, datetime2);
    }

    
    public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetQuoteArray(this, series, datetime1, datetime2);
    }

    
    public QuoteArray GetQuoteArray(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetQuoteArray(this, datetime1, datetime2);
    }

    
    public MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetMarketDepthArray(this, series, datetime1, datetime2);
    }

    
    public MarketDepthArray GetMarketDepthArray(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetMarketDepthArray(this, datetime1, datetime2);
    }

    
    public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetBarSeries(this, series, datetime1, datetime2);
    }

    
    public BarSeries GetBarSeries(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetBarSeries(this, datetime1, datetime2);
    }

    
    public BarSeries GetBarSeries(DateTime datetime1, DateTime datetime2, BarType barType, long barSize)
    {
      return DataManager.GetBarSeries(this, datetime1, datetime2, barType, barSize);
    }

    
    public DailySeries GetDailySeries(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetDailySeries(this, datetime1, datetime2);
    }

    
    public DailySeries GetDailySeries()
    {
      return DataManager.GetDailySeries(this);
    }

    
    public IDataSeries GetDataSeries(string series)
    {
      return DataManager.GetDataSeries(this, series);
    }

    
    public IDataSeries GetDataSeries(DataManager.EDataSeries series)
    {
      return DataManager.GetDataSeries(this, series);
    }

    
    public IDataSeries AddDataSeries(string series)
    {
      return DataManager.AddDataSeries(this, series);
    }

    
    public DataSeriesList GetDataSeries()
    {
      return DataManager.GetDataSeries(this);
    }

    
    public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
    {
      DataManager.RequestMarketData(provider, this, mdType, seriesSuffix);
    }

    
    public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType)
    {
      this.RequestMarketData(provider, mdType, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(4058));
    }

    
    public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
    {
      DataManager.CancelMarketData(provider, this, mdType, seriesSuffix);
    }

    
    public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType)
    {
      this.CancelMarketData(provider, mdType, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(4066));
    }

    
    public bool IsSubscribed(IMarketDataProvider provider, MarketDataType mdType)
    {
      return DataManager.IsSubscribed(provider, this, mdType);
    }

    
    public override string ToString()
    {
      return this.Symbol;
    }
  }
}
