using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXInstrument : FIXGroup, IFIXInstrument
  {
    protected FIXSecurityAltIDGroupList fSecurityAltIDGroup;
    private ArrayList CvJtSUh8gZ;

    [Description("Ticker symbol. Common, human understood representation of the security. SecurityID (48) value can be specified if no symbol exists (e.g. non-exchange traded Collective Investment Vehicles)")]
    [Category("Appearance")]
    [ReadOnly(true)]
    [FIXField("55", EFieldOption.Optional)]
    public string Symbol
    {
       get
      {
        return this.GetStringValue(55);
      }
       set
      {
        this.SetStringValue(55, value);
      }
    }

    [FIXField("65", EFieldOption.Optional)]
    [Category("Appearance")]
    [Description("Additional information about the security (e.g. preferred, warrants, etc.). Note also see SecurityType (167)")]
    public string SymbolSfx
    {
       get
      {
        return this.GetStringValue(65);
      }
       set
      {
        this.SetStringValue(65, value);
      }
    }

    [FIXField("48", EFieldOption.Optional)]
    [Category("Appearance")]
    [Description("Security identifier value of SecurityIDSource (22) type (e.g. CUSIP, SEDOL, ISIN, etc).  Requires SecurityIDSource.")]
    public string SecurityID
    {
       get
      {
        return this.GetStringValue(48);
      }
       set
      {
        this.SetStringValue(48, value);
      }
    }

    [FIXField("22", EFieldOption.Optional)]
    [Category("Appearance")]
    [Description("Identifies class or source of the SecurityID (48) value.  Required if SecurityID is specified.")]
    public string SecurityIDSource
    {
       get
      {
        return this.GetStringValue(22);
      }
       set
      {
        this.AddStringField(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
    [Browsable(false)]
    public int NoSecurityAltID
    {
       get
      {
        return this.GetIntValue(454);
      }
       set
      {
        this.SetIntValue(454, value);
      }
    }

//    [Editor(typeof (YeW5DMVLWLPd3kaNu3), typeof (UITypeEditor))]
    [Description("")]
    [Category("Appearance")]
    public FIXSecurityAltIDGroupList SecurityAltIDGroup
    {
       get
      {
        return this.fSecurityAltIDGroup;
      }
    }

    [Category("Appearance")]
    [Description("Indicates the type of product the security is associated with. See also the CFICode (461) and SecurityType (167) fields.")]
    [FIXField("460", EFieldOption.Optional)]
    public int Product
    {
       get
      {
        return this.GetIntValue(460);
      }
       set
      {
        this.SetIntValue(460, value);
      }
    }

    [FIXField("461", EFieldOption.Optional)]
    [Description("Indicates the type of security using  ISO 10962 standard, Classification of Financial Instruments (CFI code) values.  ISO 10962 is maintained by ANNA (Association of National Numbering Agencies) acting as Registration Authority. See also the Product (460) and SecurityType (167) fields. It is recommended that CFICode be used instead of SecurityType (167) for non-Fixed Income instruments.")]
    [Category("Appearance")]
    public string CFICode
    {
       get
      {
        return this.GetStringValue(461);
      }
       set
      {
        this.AddStringField(461, value);
      }
    }

    [Description("Indicates type of security.")]
    [Category("Appearance")]
    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
       get
      {
        return this.GetStringValue(167);
      }
       set
      {
        this.AddStringField(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    [Category("Appearance")]
    [Description("Sub-type qualification/identification of the SecurityType (e.g. for SecurityType=REPO).")]
    public string SecuritySubType
    {
       get
      {
        return this.GetStringValue(762);
      }
       set
      {
        this.AddStringField(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    [Description("Can be used with standardized derivatives vs. the MaturityDate (541) field. Month and Year of the maturity (used for standardized futures and options).")]
    [Category("Derivative")]
    public string MaturityMonthYear
    {
       get
      {
        return this.GetStringValue(200);
      }
       set
      {
        this.AddStringField(200, value);
      }
    }

    [FIXField("205", EFieldOption.Optional)]
    [Description("Day of month used in conjunction with MaturityMonthYear to specify the maturity date for SecurityType=FUT or SecurityType=OPT.")]
    [Category("Derivative")]
    public string MaturityDay
    {
       get
      {
        return this.GetStringValue(205);
      }
       set
      {
        this.SetStringValue(205, value);
      }
    }

    [Category("Derivative")]
    [FIXField("541", EFieldOption.Optional)]
    [Description("Date of maturity.")]
    public DateTime MaturityDate
    {
       get
      {
        return this.GetDateTimeValue(541);
      }
       set
      {
        this.SetDateTimeValue(541, value);
      }
    }

    [Description("Date interest is to be paid.  Used in identifying Corporate Bond issues.")]
    [FIXField("224", EFieldOption.Optional)]
    [Category("Fixed income")]
    public DateTime CouponPaymentDate
    {
       get
      {
        return this.GetDateTimeValue(224);
      }
       set
      {
        this.SetDateTimeValue(224, value);
      }
    }

    [Description("The date on which a bond or stock offering is issued. It may or may not be the same as the effective date (Dated Date) or the date on which interest begins to accrue (Interest Accrual Date)")]
    [FIXField("225", EFieldOption.Optional)]
    [Category("Issue")]
    public DateTime IssueDate
    {
       get
      {
        return this.GetDateTimeValue(225);
      }
       set
      {
        this.SetDateTimeValue(225, value);
      }
    }

    [FIXField("239", EFieldOption.Optional)]
    [Description("Identifies the collateral used in the transaction.")]
    [Category("Repo")]
    public int RepoCollateralSecurityType
    {
       get
      {
        return this.GetIntValue(239);
      }
       set
      {
        this.SetIntValue(239, value);
      }
    }

    [FIXField("226", EFieldOption.Optional)]
    [Category("Repo")]
    [Description("Number of business days before repurchase of a repo.")]
    public int RepurchaseTerm
    {
       get
      {
        return this.GetIntValue(226);
      }
       set
      {
        this.SetIntValue(226, value);
      }
    }

    [Description("Percent of par at which a Repo will be repaid. Represented as a percent, e.g. .9525 represents 95-1/4 percent of par.")]
    [Category("Repo")]
    [FIXField("227", EFieldOption.Optional)]
    public double RepurchaseRate
    {
       get
      {
        return this.GetDoubleValue(227);
      }
       set
      {
        this.SetDoubleValue(227, value);
      }
    }

    [Description("Contract Value Factor by which price must be adjusted to determine the true nominal value of one futures/options contract. (Qty * Price) * Factor = Nominal Value")]
    [Category("Derivative")]
    [FIXField("228", EFieldOption.Optional)]
    public double Factor
    {
       get
      {
        return this.GetDoubleValue(228);
      }
       set
      {
        this.SetDoubleValue(228, value);
      }
    }

    [Description("An evaluation of a company's ability to repay obligations or its likelihood of not defaulting. These evaluation are provided by Credit Rating Agencies, i.e. S&P, Moody's.")]
    [FIXField("255", EFieldOption.Optional)]
    [Category("Issue")]
    public string CreditRating
    {
       get
      {
        return this.GetStringValue((int) byte.MaxValue);
      }
       set
      {
        this.AddStringField((int) byte.MaxValue, value);
      }
    }

    [Category("Issue")]
    [Description("The location at which records of ownership are maintained for this instrument, and at which ownership changes must be recorded.")]
    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
       get
      {
        return this.GetStringValue(543);
      }
       set
      {
        this.AddStringField(543, value);
      }
    }

    [Category("Issue")]
    [FIXField("470", EFieldOption.Optional)]
    [Description("ISO Country code of instrument issue (e.g. the country portion typically used in ISIN).  Can be used in conjunction with non-ISIN SecurityID (48) (e.g. CUSIP for Municipal Bonds without ISIN) to provide uniqueness.")]
    public string CountryOfIssue
    {
       get
      {
        return this.GetStringValue(470);
      }
       set
      {
        this.AddStringField(470, value);
      }
    }

    [Description("A two-character state or province abbreviation.")]
    [FIXField("471", EFieldOption.Optional)]
    [Category("Issue")]
    public string StateOrProvinceOfIssue
    {
       get
      {
        return this.GetStringValue(471);
      }
       set
      {
        this.AddStringField(471, value);
      }
    }

    [Category("Issue")]
    [FIXField("472", EFieldOption.Optional)]
    [Description("Identifies the locale. For Municipal Security Issuers other than state or province.")]
    public string LocaleOfIssue
    {
       get
      {
        return this.GetStringValue(472);
      }
       set
      {
        this.AddStringField(472, value);
      }
    }

    [Category("Fixed income")]
    [Description("Return of investor's principal in a security. Bond redemption can occur before maturity date.")]
    [FIXField("240", EFieldOption.Optional)]
    public DateTime RedemptionDate
    {
       get
      {
        return this.GetDateTimeValue(240);
      }
       set
      {
        this.SetDateTimeValue(240, value);
      }
    }

    [FIXField("202", EFieldOption.Optional)]
    [Description("Strike Price for an Option.")]
    [Category("Derivative")]
    public double StrikePrice
    {
       get
      {
        return this.GetDoubleValue(202);
      }
       set
      {
        this.SetDoubleValue(202, value);
      }
    }

    [Description("Currency in which the StrikePrice is denominated.")]
    [FIXField("947", EFieldOption.Optional)]
    [Category("Derivative")]
    public string StrikeCurrency
    {
       get
      {
        return this.GetStringValue(947);
      }
       set
      {
        this.SetStringValue(947, value);
      }
    }

    [Description("Can be used for SecurityType (167) =OPT to identify a particular security.")]
    [Category("Derivative")]
    [FIXField("206", EFieldOption.Optional)]
    public char OptAttribute
    {
       get
      {
        return this.GetCharValue(206);
      }
       set
      {
        this.SetCharValue(206, value);
      }
    }

    [Category("Derivative")]
    [Description("Indicates whether an Option is for a put or call.")]
    [FIXField("201", EFieldOption.Optional)]
    public int PutOrCall
    {
       get
      {
        return this.GetIntValue(201);
      }
       set
      {
        this.SetIntValue(201, value);
      }
    }

    [Description("Specifies the ratio or multiply factor to convert from 'nominal' units (e.g. contracts) to total units (e.g. shares) (e.g. 1.0, 100, 1000, etc). Applicable For Fixed Income, Convertible Bonds, Derivatives, etc.")]
    [Category("Derivative")]
    [FIXField("231", EFieldOption.Optional)]
    public double ContractMultiplier
    {
       get
      {
        return this.GetDoubleValue(231);
      }
       set
      {
        this.SetDoubleValue(231, value);
      }
    }

    [FIXField("223", EFieldOption.Optional)]
    [Category("Fixed income")]
    [Description("The rate of interest that, when multiplied by the principal, par value, or face value of a bond, provides the currency amount of the periodic interest payment.  The coupon is always cited, along with maturity, in any quotation of a bond's price.")]
    public double CouponRate
    {
       get
      {
        return this.GetDoubleValue(223);
      }
       set
      {
        this.SetDoubleValue(223, value);
      }
    }

    [FIXField("207", EFieldOption.Optional)]
    [Description("Market used to help identify a security.")]
    [Category("Appearance")]
    public string SecurityExchange
    {
       get
      {
        return this.GetStringValue(207);
      }
       set
      {
        this.AddStringField(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    [Category("Issue")]
    [Description("Name of security issuer (e.g. International Business Machines, GNMA).")]
    public string Issuer
    {
       get
      {
        return this.GetStringValue(106);
      }
       set
      {
        this.AddStringField(106, value);
      }
    }

    [Browsable(false)]
    [FIXField("348", EFieldOption.Optional)]
    public int EncodedIssuerLen
    {
       get
      {
        return this.GetIntValue(348);
      }
       set
      {
        this.SetIntValue(348, value);
      }
    }

    [FIXField("349", EFieldOption.Optional)]
    [Browsable(false)]
    public string EncodedIssuer
    {
       get
      {
        return this.GetStringValue(349);
      }
       set
      {
        this.AddStringField(349, value);
      }
    }

    [Description("Security description.")]
    [Category("Appearance")]
    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
       get
      {
        return this.GetStringValue(107);
      }
       set
      {
        this.AddStringField(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
    [Browsable(false)]
    public int EncodedSecurityDescLen
    {
       get
      {
        return this.GetIntValue(350);
      }
       set
      {
        this.SetIntValue(350, value);
      }
    }

    [FIXField("351", EFieldOption.Optional)]
    [Browsable(false)]
    public string EncodedSecurityDesc
    {
       get
      {
        return this.GetStringValue(351);
      }
       set
      {
        this.AddStringField(351, value);
      }
    }

    [Category("Fixed income")]
    [FIXField("691", EFieldOption.Optional)]
    [Description("For Fixed Income, identifies MBS/ABS pool.")]
    public string Pool
    {
       get
      {
        return this.GetStringValue(691);
      }
       set
      {
        this.AddStringField(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    [Description("Specifies when the contract (i.e. MBS/TBA) will settle.")]
    [Category("Fixed income")]
    public string ContractSettlMonth
    {
       get
      {
        return this.GetStringValue(667);
      }
       set
      {
        this.AddStringField(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
    [Description("The program under which a commercial paper is issued")]
    [Category("Issue")]
    public int CPProgram
    {
       get
      {
        return this.GetIntValue(875);
      }
       set
      {
        this.SetIntValue(875, value);
      }
    }

    [Category("Issue")]
    [Description("The registration type of a commercial paper issuance")]
    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
       get
      {
        return this.GetStringValue(876);
      }
       set
      {
        this.AddStringField(876, value);
      }
    }

    [Browsable(false)]
    [FIXField("864", EFieldOption.Optional)]
    public int NoEvents
    {
       get
      {
        return this.GetIntValue(864);
      }
       set
      {
        this.SetIntValue(864, value);
      }
    }

    [Description("The effective date of a new securities issue determined by its underwriters. Often but not always the same as the Issue Date and the Interest Accrual Date")]
    [Category("Issue")]
    [FIXField("873", EFieldOption.Optional)]
    public DateTime DatedDate
    {
       get
      {
        return this.GetDateTimeValue(873);
      }
       set
      {
        this.SetDateTimeValue(873, value);
      }
    }

    [FIXField("874", EFieldOption.Optional)]
    [Category("Fixed income")]
    [Description("The start date used for calculating accrued interest on debt instruments which are being sold between interest payment dates. Often but not always the same as the Issue Date and the Dated Date")]
    public DateTime InterestAccrualDate
    {
       get
      {
        return this.GetDateTimeValue(874);
      }
       set
      {
        this.SetDateTimeValue(874, value);
      }
    }

    [Description("Tick size")]
    [Category("Trade")]
    public double TickSize
    {
       get
      {
        return this.GetDoubleValue(10400);
      }
       set
      {
        this.SetDoubleValue(10400, value);
      }
    }


    public FIXInstrument() : base()
    {
      this.fSecurityAltIDGroup = new FIXSecurityAltIDGroupList();
      this.CvJtSUh8gZ = new ArrayList();
    }

    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return this.fSecurityAltIDGroup[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(string source)
    {
      foreach (FIXSecurityAltIDGroup securityAltIdGroup in (FIXGroupList) this.fSecurityAltIDGroup)
      {
        if (securityAltIdGroup.SecurityAltIDSource == source)
          return securityAltIdGroup;
      }
      return (FIXSecurityAltIDGroup) null;
    }

    
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.fSecurityAltIDGroup.Add((FIXGroup) group);
      this.Groups.Add((FIXGroup) group);
      ++this.NoSecurityAltID;
    }

    
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.CvJtSUh8gZ[i];
      else
        return (FIXEventsGroup) null;
    }

    
    public void AddGroup(FIXEventsGroup group)
    {
      this.CvJtSUh8gZ.Add((object) group);
      ++this.NoEvents;
    }
  }
}
