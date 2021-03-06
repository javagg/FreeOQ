using System;
using System.ComponentModel;
using System.Drawing.Design;
using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Providers;
using FreeQuant.Series;

namespace FreeQuant.Instruments
{
    public class Instrument : FIXInstrument
    {
        private const string PRICE_DISPLAY = "F2";
        private Currency currency;

        [Description("Indicates whether an Option is for a put or call.")]
        [Category("Derivative")]
        public new PutOrCall PutOrCall
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
        public Exchange Exchange { get; set; }

        [Description("List of instrument legs")]
//    [Editor(typeof (em03FhdRrsMhLEot1L), typeof (UITypeEditor))]
        [Category("Attributes")]
        public LegList Legs { get; private set; }

        [Description("List of instrument underlyings")]
        [Category("Attributes")]
        //    [Editor(typeof (eHiaMMJnVTTEAxAjWe), typeof (UITypeEditor))]
		public UnderlyingList Underlyings { get; private set; }

        [Browsable(false)]
        public IPricer Pricer { get; set; }

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
                this.currency = CurrencyManager.Currencies[value];
                if (this.currency != null)
                    return;
                this.currency = CurrencyManager.DefaultCurrency;
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
        [DefaultValue(PRICE_DISPLAY)]
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
        public Quote Quote { get; private set; }

        [Browsable(false)]
        public Trade Trade { get; private set; }

        [Browsable(false)]
        public Bar Bar { get; private set; }

        [Browsable(false)]
        public MarketDepth MarketDepth { get; private set; }

        [Browsable(false)]
        public Fundamental Fundamental { get; private set; }

        [Browsable(false)]
        public CorporateAction CorporateAction { get; private set; }

        [Browsable(false)]
        public OrderBook OrderBook { get; private set; }

        [Browsable(false)]
        public double Change { get; private set; }

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
            this.Legs = new LegList();
            this.Underlyings = new UnderlyingList();
            this.Pricer = new Pricer();
            this.Quote = new Quote();
            this.Trade = new Trade();
            this.Bar = new Bar();
            this.MarketDepth = new MarketDepth();
            this.Fundamental = new Fundamental();
            this.CorporateAction = new CorporateAction();
            this.OrderBook = new OrderBook();
            this.PriceDisplay = PRICE_DISPLAY;
        }

        public Instrument(string symbol) : this(symbol, "?")
        {
        }

        public Instrument(string symbol, string securityType) : this()
        {
            this.Symbol = symbol;
            this.SecurityType = securityType;
            InstrumentManager.Add(this);
        }

        public Currency GetCurrency()
        {
            if (this.currency != null)
                return this.currency;
            this.currency = CurrencyManager.Currencies[this.Currency];
            if (this.currency == null)
                this.currency = CurrencyManager.DefaultCurrency;
            return this.currency;
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
            InstrumentManager.Save(this);
        }

        public virtual double Price()
        {
            return this.Pricer.Price(this);
        }

        public virtual double Price(DateTime datetime)
        {
            return this.Pricer.Price(this, datetime);
        }

        public virtual double Volatility()
        {
            return this.Pricer.Volatility(this);
        }

        public double Delta()
        {
            return this.Pricer.Delta(this);
        }

        public double Delta(DateTime datetime)
        {
            return this.Pricer.Delta(this, datetime);
        }

        public double Gamma()
        {
            return this.Pricer.Gamma(this);
        }

        public double Gamma(DateTime datetime)
        {
            return this.Pricer.Gamma(this, datetime);
        }

        public double Theta()
        {
            return this.Pricer.Theta(this);
        }

        public double Theta(DateTime datetime)
        {
            return this.Pricer.Theta(this, datetime);
        }

        public double Rho()
        {
            return this.Pricer.Rho(this);
        }

        public double Rho(DateTime datetime)
        {
            return this.Pricer.Rho(this, datetime);
        }

        public double Vega()
        {
            return this.Pricer.Vega(this);
        }

        public double Vega(DateTime datetime)
        {
            return this.Pricer.Vega(this, datetime);
        }

        public void Reset()
        {
            this.Bar = new Bar(); 
            this.Quote = new Quote(); 
            this.Trade = new Trade(); 
            this.MarketDepth = new MarketDepth(); 
            this.Fundamental = new Fundamental(); 
            this.CorporateAction = new CorporateAction(); 
            this.Change = 0.0; 
        }

        internal void EmitNewQuote(QuoteEventArgs e)
        {
            this.Quote = e.Quote;
            if (this.NewQuote != null)
            {
                this.NewQuote(this, e);
            }
        }

        internal void EmitNewTrade(TradeEventArgs e)
        {
            if (this.Trade.Price != 0.0 && this.Trade.Price != e.Trade.Price)
                this.Change = e.Trade.Price - this.Trade.Price;
            this.Trade = e.Trade;
            if (this.NewTrade != null)
            {
                this.NewTrade(this, e);
            }
        }

        internal void EmitNewBarOpen(BarEventArgs e)
        {
            this.Bar = e.Bar;
            if (Trace.IsLevelEnabled(TraceLevel.Verbose))
            {
                Trace.WriteLine(string.Concat(new object[]
                {
                    "Symbol",
                    this.Symbol,
                    "Bar",
                    this.Bar
                }));
            }
            if (this.NewBarOpen != null)
            {
                this.NewBarOpen(this, e);
            }
        }

        internal void EmitNewBar(BarEventArgs e)
        {
            this.Bar = e.Bar;
            if (Trace.IsLevelEnabled(TraceLevel.Verbose))
            {
                Trace.WriteLine(string.Concat(new object[]
                {
                    "Symbol",
                    this.Symbol,
                    "Bar",
                    this.Bar
                }));
            }
            if (this.NewBar != null)
            {
                this.NewBar(this, e);
            }
        }

        internal void EmitNewMarketDepth(MarketDepthEventArgs e)
        {
            this.MarketDepth = e.MarketDepth;
            if (this.NewMarketDepth != null)
                this.NewMarketDepth(this, e);
            this.OrderBook.Add(e.MarketDepth);
        }

        internal void EmitNewFundamental(FundamentalEventArgs e)
        {
            this.Fundamental = e.Fundamental;
            if (this.NewFundamental != null)
                this.NewFundamental(this, e);
        }

        internal void EmitNewCorporateAction(CorporateActionEventArgs e)
        {
            this.CorporateAction = e.CorporateAction;
            if (this.NewCorporateAction != null)
                this.NewCorporateAction(this, e);
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

        // FIXME: seriesSuffix = ?
        public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType)
        {
            this.RequestMarketData(provider, mdType, "ALL");
        }

        public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
        {
            DataManager.CancelMarketData(provider, this, mdType, seriesSuffix);
        }

        // FIXME: seriesSuffix = ?
        public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType)
        {
            this.CancelMarketData(provider, mdType, "ALL");
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
