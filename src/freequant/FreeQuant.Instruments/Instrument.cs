// Type: SmartQuant.Instruments.Instrument
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using ExV3wMPI8E8ZvKR845;
using nlmLboft3R6jnhSDBs;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using SmartQuant.Providers;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VFUvY5knK01pUIalDo;
using x4kjQFrrfpZvQx9QMP;

namespace FreeQuant.Instruments
{
  public class Instrument : FIXInstrument
  {
    private const string ErF6qIRY8C = "F2";
    private Currency mEf6f8TGiq;
    private Exchange TNc6pL8cK3;
    private LegList uIJ6vbhTOX;
    private UnderlyingList JAT65L3WwQ;
    private IPricer wZe6uJJRdy;
    private Quote r7n6IuAJ2g;
    private Trade Ful6LEXQOc;
    private Bar rph6b90s4W;
    private MarketDepth SIo6REcuQ6;
    private Fundamental JjI6aa64P4;
    private CorporateAction mLj6n4gDEd;
    private OrderBook Dvj6i1WTmP;
    private double cAF6h0NHaN;

    [Description("Indicates whether an Option is for a put or call.")]
    [Category("Derivative")]
    public PutOrCall PutOrCall
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPutOrCall.FromFIX(base.PutOrCall);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PutOrCall = FIXPutOrCall.ToFIX(value);
      }
    }

    [Browsable(false)]
    public Exchange Exchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TNc6pL8cK3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.TNc6pL8cK3 = value;
      }
    }

    [Description("List of instrument legs")]
    [Editor(typeof (em03FhdRrsMhLEot1L), typeof (UITypeEditor))]
    [Category("Attributes")]
    public LegList Legs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.uIJ6vbhTOX;
      }
    }

    [Description("List of instrument underlyings")]
    [Category("Attributes")]
    [Editor(typeof (eHiaMMJnVTTEAxAjWe), typeof (UITypeEditor))]
    public UnderlyingList Underlyings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JAT65L3WwQ;
      }
    }

    [Browsable(false)]
    public IPricer Pricer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wZe6uJJRdy;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wZe6uJJRdy = value;
      }
    }

    [Category("Trade")]
    [Description("Identifies the form of delivery")]
    [FIXField("668", EFieldOption.Optional)]
    public int DeliveryForm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(668);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(668, value);
      }
    }

    [Category("Trade")]
    [FIXField("869", EFieldOption.Optional)]
    [Description("Percent at risk due to lowest possible call.")]
    public double PctAtRisk
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(869);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(869, value);
      }
    }

    [Category("Appearance")]
    [FIXField("15", EFieldOption.Optional)]
    [Description("Identifies currency used for price. Absence of this field is interpreted as the default for the security.  It is recommended that systems provide the currency value whenever possible.")]
    public string Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(15);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(336);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(336, value);
      }
    }

    [Description("Optional market assigned sub identifier for a trading session. Usage is determined by market or counterparties. Used by US based futures markets to identify exchange specific execution time bracket codes as required by US market regulations.")]
    [Category("Trade")]
    [FIXField("625", EFieldOption.Optional)]
    public string TradingSessionSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(625);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(625, value);
      }
    }

    [FIXField("827", EFieldOption.Optional)]
    [Category("Trade")]
    [Description("Part of trading cycle when an instrument expires. Field is applicable for derivatives.")]
    public int ExpirationCycle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(827);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(827, value);
      }
    }

    [Category("Trade")]
    [Description("The trading lot size of a security")]
    [FIXField("561", EFieldOption.Optional)]
    public double RoundLot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(561);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(561, value);
      }
    }

    [FIXField("562", EFieldOption.Optional)]
    [Description("The minimum trading volume for a security")]
    [Category("Trade")]
    public double MinTradeVol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(562);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(562, value);
      }
    }

    [Category("Industry")]
    [FIXField("10100", EFieldOption.Optional)]
    [Description("Industry code")]
    public string IndustryCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(10100);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(10100, value);
      }
    }

    [FIXField("10101", EFieldOption.Optional)]
    [Description("Industry sector")]
    [Category("Industry")]
    public string IndustrySector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(10101);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(10101, value);
      }
    }

    [Description("Industry group")]
    [FIXField("10102", EFieldOption.Optional)]
    [Category("Industry")]
    public string IndustryGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(10102);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(10102, value);
      }
    }

    [Category("Industry")]
    [Description("Industry sub group")]
    [FIXField("10103", EFieldOption.Optional)]
    public string IndustrySubGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(10103);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(11105);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(11105, value);
      }
    }

    [Category("Margin")]
    [FIXField("10600", EFieldOption.Optional)]
    [Description("Initial margin")]
    public double Margin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10600);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10600, value);
      }
    }

    [Browsable(false)]
    public Quote Quote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.r7n6IuAJ2g;
      }
    }

    [Browsable(false)]
    public Trade Trade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Ful6LEXQOc;
      }
    }

    [Browsable(false)]
    public Bar Bar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rph6b90s4W;
      }
    }

    [Browsable(false)]
    public MarketDepth MarketDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.SIo6REcuQ6;
      }
    }

    [Browsable(false)]
    public Fundamental Fundamental
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JjI6aa64P4;
      }
    }

    [Browsable(false)]
    public CorporateAction CorporateAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mLj6n4gDEd;
      }
    }

    [Browsable(false)]
    public OrderBook OrderBook
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Dvj6i1WTmP;
      }
    }

    [Browsable(false)]
    public double Change
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cAF6h0NHaN;
      }
    }

    [Browsable(false)]
    public QuoteArray Quotes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return DataManager.Quotes[this];
      }
    }

    [Browsable(false)]
    public TradeArray Trades
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return DataManager.Trades[this];
      }
    }

    [Browsable(false)]
    public BarSeries Bars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Instrument()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.uIJ6vbhTOX = new LegList();
      this.JAT65L3WwQ = new UnderlyingList();
      this.wZe6uJJRdy = (IPricer) new Pricer();
      this.r7n6IuAJ2g = new Quote();
      this.Ful6LEXQOc = new Trade();
      this.rph6b90s4W = new Bar();
      this.SIo6REcuQ6 = new MarketDepth();
      this.JjI6aa64P4 = new Fundamental();
      this.mLj6n4gDEd = new CorporateAction();
      this.Dvj6i1WTmP = new OrderBook();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.PriceDisplay = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3196);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instrument(string symbol)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(symbol, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3204));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instrument(string symbol, string securityType)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.uIJ6vbhTOX = new LegList();
      this.JAT65L3WwQ = new UnderlyingList();
      this.wZe6uJJRdy = (IPricer) new Pricer();
      this.r7n6IuAJ2g = new Quote();
      this.Ful6LEXQOc = new Trade();
      this.rph6b90s4W = new Bar();
      this.SIo6REcuQ6 = new MarketDepth();
      this.JjI6aa64P4 = new Fundamental();
      this.mLj6n4gDEd = new CorporateAction();
      this.Dvj6i1WTmP = new OrderBook();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Symbol = symbol;
      this.SecurityType = securityType;
      this.PriceDisplay = !(securityType == gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3212)) ? gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3230) : gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3222);
      InstrumentManager.VljEVFlVHf(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Currency GetCurrency()
    {
      if (this.mEf6f8TGiq != null)
        return this.mEf6f8TGiq;
      this.mEf6f8TGiq = CurrencyManager.Currencies[this.Currency];
      if (this.mEf6f8TGiq == null)
        this.mEf6f8TGiq = CurrencyManager.DefaultCurrency;
      return this.mEf6f8TGiq;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSymbol(string symbol, string source)
    {
      this.AddGroup(new FIXSecurityAltIDGroup()
      {
        SecurityAltID = symbol,
        SecurityAltIDSource = source
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSymbol(string symbol, string securityExchange, string source)
    {
      this.AddGroup(new FIXSecurityAltIDGroup()
      {
        SecurityAltExchange = securityExchange,
        SecurityAltID = symbol,
        SecurityAltIDSource = source
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetSecurityExchange(string source)
    {
      foreach (FIXSecurityAltIDGroup securityAltIdGroup in (FIXGroupList) this.fSecurityAltIDGroup)
      {
        if (securityAltIdGroup.SecurityAltIDSource == source && securityAltIdGroup.SecurityAltExchange != "")
          return securityAltIdGroup.SecurityAltExchange;
      }
      return this.SecurityExchange;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save()
    {
      InstrumentManager.DdbEFF4dAg(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Price()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3238));
      else
        return this.wZe6uJJRdy.Price(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Price(DateTime datetime)
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3292));
      else
        return this.wZe6uJJRdy.Price(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Volatility()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3346));
      else
        return this.wZe6uJJRdy.Volatility(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Delta()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3398));
      else
        return this.wZe6uJJRdy.Delta(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Delta(DateTime datetime)
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3452));
      else
        return this.wZe6uJJRdy.Delta(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Gamma()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3506));
      else
        return this.wZe6uJJRdy.Gamma(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Gamma(DateTime datetime)
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3560));
      else
        return this.wZe6uJJRdy.Gamma(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Theta()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3614));
      else
        return this.wZe6uJJRdy.Theta(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Theta(DateTime datetime)
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3668));
      else
        return this.wZe6uJJRdy.Theta(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Rho()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3722));
      else
        return this.wZe6uJJRdy.Rho(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Rho(DateTime datetime)
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3776));
      else
        return this.wZe6uJJRdy.Rho(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Vega()
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3830));
      else
        return this.wZe6uJJRdy.Vega(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Vega(DateTime datetime)
    {
      if (this.wZe6uJJRdy == null)
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3884));
      else
        return this.wZe6uJJRdy.Vega(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset()
    {
      this.rph6b90s4W = new Bar();
      this.r7n6IuAJ2g = new Quote();
      this.Ful6LEXQOc = new Trade();
      this.SIo6REcuQ6 = new MarketDepth();
      this.JjI6aa64P4 = new Fundamental();
      this.mLj6n4gDEd = new CorporateAction();
      this.cAF6h0NHaN = 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void JLw6D59Mxc([In] QuoteEventArgs obj0)
    {
      this.r7n6IuAJ2g = obj0.Quote;
      if (this.TdT6S1usZL == null)
        return;
      this.TdT6S1usZL((object) this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void akq60u3HYf([In] TradeEventArgs obj0)
    {
      if (this.Ful6LEXQOc.Price != 0.0 && this.Ful6LEXQOc.Price != obj0.Trade.Price)
        this.cAF6h0NHaN = obj0.Trade.Price - this.Ful6LEXQOc.Price;
      this.Ful6LEXQOc = obj0.Trade;
      if (this.Uyq6ZtLUjA == null)
        return;
      this.Uyq6ZtLUjA((object) this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void trS6Hr1Wkt([In] BarEventArgs obj0)
    {
      this.rph6b90s4W = obj0.Bar;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Concat(new object[4]
        {
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3938),
          (object) this.Symbol,
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3988),
          (object) this.rph6b90s4W
        }));
      if (this.LGt6AP0Acf == null)
        return;
      this.LGt6AP0Acf((object) this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ami6cstOZQ([In] BarEventArgs obj0)
    {
      this.rph6b90s4W = obj0.Bar;
      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
        Trace.WriteLine(string.Concat(new object[4]
        {
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3994),
          (object) this.Symbol,
          (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(4052),
          (object) this.rph6b90s4W
        }));
      if (this.iPM6grNm2V == null)
        return;
      this.iPM6grNm2V((object) this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void aSE6VetHfX([In] MarketDepthEventArgs obj0)
    {
      this.SIo6REcuQ6 = obj0.MarketDepth;
      if (this.apm61EO0je != null)
        this.apm61EO0je((object) this, obj0);
      this.Dvj6i1WTmP.Add(obj0.MarketDepth);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void a1w6FaBIwx([In] FundamentalEventArgs obj0)
    {
      this.JjI6aa64P4 = obj0.Fundamental;
      if (this.fYq6oMJm1K == null)
        return;
      this.fYq6oMJm1K((object) this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void KPy6yCSTBZ([In] CorporateActionEventArgs obj0)
    {
      this.mLj6n4gDEd = obj0.CorporateAction;
      if (this.Nhy6xRMm7T == null)
        return;
      this.Nhy6xRMm7T((object) this, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string series, Trade trade)
    {
      DataManager.Add(this, series, trade);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Trade trade)
    {
      DataManager.Add(this, trade);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string series, Quote quote)
    {
      DataManager.Add(this, series, quote);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Quote quote)
    {
      DataManager.Add(this, quote);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string series, Bar bar)
    {
      DataManager.Add(this, series, bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Bar bar)
    {
      DataManager.Add(this, bar);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Daily daily)
    {
      DataManager.Add(this, daily);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string series, MarketDepth marketDepth)
    {
      DataManager.Add(this, series, marketDepth);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(MarketDepth marketDepth)
    {
      DataManager.Add(this, marketDepth);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetTradeArray(this, series, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeArray GetTradeArray(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetTradeArray(this, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetQuoteArray(this, series, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteArray GetQuoteArray(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetQuoteArray(this, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetMarketDepthArray(this, series, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepthArray GetMarketDepthArray(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetMarketDepthArray(this, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetBarSeries(this, series, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSeries GetBarSeries(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetBarSeries(this, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSeries GetBarSeries(DateTime datetime1, DateTime datetime2, BarType barType, long barSize)
    {
      return DataManager.GetBarSeries(this, datetime1, datetime2, barType, barSize);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries GetDailySeries(DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetDailySeries(this, datetime1, datetime2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries GetDailySeries()
    {
      return DataManager.GetDailySeries(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataSeries GetDataSeries(string series)
    {
      return DataManager.GetDataSeries(this, series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataSeries GetDataSeries(DataManager.EDataSeries series)
    {
      return DataManager.GetDataSeries(this, series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataSeries AddDataSeries(string series)
    {
      return DataManager.AddDataSeries(this, series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataSeriesList GetDataSeries()
    {
      return DataManager.GetDataSeries(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
    {
      DataManager.RequestMarketData(provider, this, mdType, seriesSuffix);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestMarketData(IMarketDataProvider provider, MarketDataType mdType)
    {
      this.RequestMarketData(provider, mdType, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(4058));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType, string seriesSuffix)
    {
      DataManager.CancelMarketData(provider, this, mdType, seriesSuffix);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CancelMarketData(IMarketDataProvider provider, MarketDataType mdType)
    {
      this.CancelMarketData(provider, mdType, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(4066));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSubscribed(IMarketDataProvider provider, MarketDataType mdType)
    {
      return DataManager.IsSubscribed(provider, this, mdType);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.Symbol;
    }
  }
}
