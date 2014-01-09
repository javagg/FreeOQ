using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrdersGroup : FIXGroup
  {
    private ArrayList hDUUiNXQor;
    private ArrayList zOaUl4gw1I;
    private ArrayList hxBUBt8PY1;
    private ArrayList qgwUOpCCGl;
    private ArrayList upwUxtBFiq;
    private ArrayList rebU5r5Gnt;

    [FIXField("11", EFieldOption.Required)]
    public string ClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(11).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(11, value);
      }
    }

    [FIXField("526", EFieldOption.Optional)]
    public string SecondaryClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(526).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(526, value);
      }
    }

    [FIXField("67", EFieldOption.Required)]
    public int ListSeqNo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(67).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(67, value);
      }
    }

    [FIXField("583", EFieldOption.Optional)]
    public string ClOrdLinkID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(583).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(583, value);
      }
    }

    [FIXField("160", EFieldOption.Optional)]
    public char SettlInstMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(160).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(160, value);
      }
    }

    [FIXField("453", EFieldOption.Optional)]
    public int NoPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(453).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(453, value);
      }
    }

    [FIXField("229", EFieldOption.Optional)]
    public DateTime TradeOriginationDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(229).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(229, value);
      }
    }

    [FIXField("75", EFieldOption.Optional)]
    public DateTime TradeDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(75).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(75, value);
      }
    }

    [FIXField("1", EFieldOption.Optional)]
    public string Account
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(1).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(1, value);
      }
    }

    [FIXField("660", EFieldOption.Optional)]
    public int AcctIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(660).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(660, value);
      }
    }

    [FIXField("581", EFieldOption.Optional)]
    public int AccountType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(581).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(581, value);
      }
    }

    [FIXField("589", EFieldOption.Optional)]
    public char DayBookingInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(589).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(589, value);
      }
    }

    [FIXField("590", EFieldOption.Optional)]
    public char BookingUnit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(590).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(590, value);
      }
    }

    [FIXField("70", EFieldOption.Optional)]
    public string AllocID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(70).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(70, value);
      }
    }

    [FIXField("591", EFieldOption.Optional)]
    public char PreallocMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(591).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(591, value);
      }
    }

    [FIXField("78", EFieldOption.Optional)]
    public int NoAllocs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(78).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(78, value);
      }
    }

    [FIXField("63", EFieldOption.Optional)]
    public char SettlType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(63).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(63, value);
      }
    }

    [FIXField("64", EFieldOption.Optional)]
    public DateTime SettlDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(64).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(64, value);
      }
    }

    [FIXField("544", EFieldOption.Optional)]
    public char CashMargin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(544).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(544, value);
      }
    }

    [FIXField("635", EFieldOption.Optional)]
    public string ClearingFeeIndicator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(635).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(635, value);
      }
    }

    [FIXField("21", EFieldOption.Optional)]
    public char HandlInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(21).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(21, value);
      }
    }

    [FIXField("18", EFieldOption.Optional)]
    public string ExecInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(18).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(18, value);
      }
    }

    [FIXField("110", EFieldOption.Optional)]
    public double MinQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(110).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(110, value);
      }
    }

    [FIXField("111", EFieldOption.Optional)]
    public double MaxFloor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(111).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(111, value);
      }
    }

    [FIXField("100", EFieldOption.Optional)]
    public string ExDestination
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(100).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(100, value);
      }
    }

    [FIXField("386", EFieldOption.Optional)]
    public int NoTradingSessions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(386).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(386, value);
      }
    }

    [FIXField("81", EFieldOption.Optional)]
    public char ProcessCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(81).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(81, value);
      }
    }

    [FIXField("55", EFieldOption.Optional)]
    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(55).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(55, value);
      }
    }

    [FIXField("65", EFieldOption.Optional)]
    public string SymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(65).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(65, value);
      }
    }

    [FIXField("48", EFieldOption.Optional)]
    public string SecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(48).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(48, value);
      }
    }

    [FIXField("22", EFieldOption.Optional)]
    public string SecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(22).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
    public int NoSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(454).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(454, value);
      }
    }

    [FIXField("460", EFieldOption.Optional)]
    public int Product
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(460).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(460, value);
      }
    }

    [FIXField("461", EFieldOption.Optional)]
    public string CFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(461).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(461, value);
      }
    }

    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(167).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    public string SecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(762).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    public string MaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(200).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(200, value);
      }
    }

    [FIXField("541", EFieldOption.Optional)]
    public DateTime MaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(541).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(541, value);
      }
    }

    [FIXField("224", EFieldOption.Optional)]
    public DateTime CouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(224).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(224, value);
      }
    }

    [FIXField("225", EFieldOption.Optional)]
    public DateTime IssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(225).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(225, value);
      }
    }

    [FIXField("239", EFieldOption.Optional)]
    public int RepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(239).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(239, value);
      }
    }

    [FIXField("226", EFieldOption.Optional)]
    public int RepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(226).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(226, value);
      }
    }

    [FIXField("227", EFieldOption.Optional)]
    public double RepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(227).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(227, value);
      }
    }

    [FIXField("228", EFieldOption.Optional)]
    public double Factor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(228).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(228, value);
      }
    }

    [FIXField("255", EFieldOption.Optional)]
    public string CreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField((int) byte.MaxValue).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField((int) byte.MaxValue, value);
      }
    }

    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(543).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(543, value);
      }
    }

    [FIXField("470", EFieldOption.Optional)]
    public string CountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(470).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(470, value);
      }
    }

    [FIXField("471", EFieldOption.Optional)]
    public string StateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(471).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(471, value);
      }
    }

    [FIXField("472", EFieldOption.Optional)]
    public string LocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(472).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(472, value);
      }
    }

    [FIXField("240", EFieldOption.Optional)]
    public DateTime RedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(240).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(240, value);
      }
    }

    [FIXField("202", EFieldOption.Optional)]
    public double StrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(202).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(202, value);
      }
    }

    [FIXField("947", EFieldOption.Optional)]
    public double StrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(947).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(947, value);
      }
    }

    [FIXField("206", EFieldOption.Optional)]
    public char OptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(206).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(206, value);
      }
    }

    [FIXField("231", EFieldOption.Optional)]
    public double ContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(231).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(231, value);
      }
    }

    [FIXField("223", EFieldOption.Optional)]
    public double CouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(223).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(223, value);
      }
    }

    [FIXField("207", EFieldOption.Optional)]
    public string SecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(207).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    public string Issuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(106).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(106, value);
      }
    }

    [FIXField("348", EFieldOption.Optional)]
    public int EncodedIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(348).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(348, value);
      }
    }

    [FIXField("349", EFieldOption.Optional)]
    public string EncodedIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(349).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(349, value);
      }
    }

    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(107).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
    public int EncodedSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(350).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(350, value);
      }
    }

    [FIXField("351", EFieldOption.Optional)]
    public string EncodedSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(351).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(351, value);
      }
    }

    [FIXField("691", EFieldOption.Optional)]
    public string Pool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(691).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    public string ContractSettlMonth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(667).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
    public int CPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(875).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(875, value);
      }
    }

    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(876).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(876, value);
      }
    }

    [FIXField("864", EFieldOption.Optional)]
    public int NoEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(864).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(864, value);
      }
    }

    [FIXField("873", EFieldOption.Optional)]
    public DateTime DatedDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(873).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(873, value);
      }
    }

    [FIXField("874", EFieldOption.Optional)]
    public DateTime InterestAccrualDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(874).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(874, value);
      }
    }

    [FIXField("711", EFieldOption.Optional)]
    public int NoUnderlyings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(711).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(711, value);
      }
    }

    [FIXField("140", EFieldOption.Optional)]
    public double PrevClosePx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(140).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(140, value);
      }
    }

    [FIXField("54", EFieldOption.Required)]
    public char Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(54).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(54, value);
      }
    }

    [FIXField("401", EFieldOption.Optional)]
    public int SideValueInd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(401).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(401, value);
      }
    }

    [FIXField("114", EFieldOption.Optional)]
    public bool LocateReqd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(114).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(114, value);
      }
    }

    [FIXField("60", EFieldOption.Optional)]
    public DateTime TransactTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(60).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(60, value);
      }
    }

    [FIXField("232", EFieldOption.Optional)]
    public int NoStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(232).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(232, value);
      }
    }

    [FIXField("854", EFieldOption.Optional)]
    public int QtyType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(854).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(854, value);
      }
    }

    [FIXField("38", EFieldOption.Optional)]
    public double OrderQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(38).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(38, value);
      }
    }

    [FIXField("152", EFieldOption.Optional)]
    public double CashOrderQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(152).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(152, value);
      }
    }

    [FIXField("516", EFieldOption.Optional)]
    public double OrderPercent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(516).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(516, value);
      }
    }

    [FIXField("468", EFieldOption.Optional)]
    public char RoundingDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(468).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(468, value);
      }
    }

    [FIXField("469", EFieldOption.Optional)]
    public double RoundingModulus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(469).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(469, value);
      }
    }

    [FIXField("40", EFieldOption.Optional)]
    public char OrdType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(40).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(40, value);
      }
    }

    [FIXField("423", EFieldOption.Optional)]
    public int PriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(423).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(423, value);
      }
    }

    [FIXField("44", EFieldOption.Optional)]
    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(44).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(44, value);
      }
    }

    [FIXField("99", EFieldOption.Optional)]
    public double StopPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(99).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(99, value);
      }
    }

    [FIXField("218", EFieldOption.Optional)]
    public double Spread
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(218).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(218, value);
      }
    }

    [FIXField("220", EFieldOption.Optional)]
    public double BenchmarkCurveCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(220).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(220, value);
      }
    }

    [FIXField("221", EFieldOption.Optional)]
    public string BenchmarkCurveName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(221).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(221, value);
      }
    }

    [FIXField("222", EFieldOption.Optional)]
    public string BenchmarkCurvePoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(222).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(222, value);
      }
    }

    [FIXField("662", EFieldOption.Optional)]
    public double BenchmarkPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(662).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(662, value);
      }
    }

    [FIXField("663", EFieldOption.Optional)]
    public int BenchmarkPriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(663).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(663, value);
      }
    }

    [FIXField("699", EFieldOption.Optional)]
    public string BenchmarkSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(699).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(699, value);
      }
    }

    [FIXField("761", EFieldOption.Optional)]
    public string BenchmarkSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(761).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(761, value);
      }
    }

    [FIXField("235", EFieldOption.Optional)]
    public string YieldType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(235).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(235, value);
      }
    }

    [FIXField("236", EFieldOption.Optional)]
    public double Yield
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(236).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(236, value);
      }
    }

    [FIXField("701", EFieldOption.Optional)]
    public DateTime YieldCalcDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(701).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(701, value);
      }
    }

    [FIXField("696", EFieldOption.Optional)]
    public DateTime YieldRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(696).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(696, value);
      }
    }

    [FIXField("697", EFieldOption.Optional)]
    public double YieldRedemptionPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(697).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(697, value);
      }
    }

    [FIXField("698", EFieldOption.Optional)]
    public int YieldRedemptionPriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(698).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(698, value);
      }
    }

    [FIXField("15", EFieldOption.Optional)]
    public double Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(15).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(15, value);
      }
    }

    [FIXField("376", EFieldOption.Optional)]
    public string ComplianceID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(376).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(376, value);
      }
    }

    [FIXField("377", EFieldOption.Optional)]
    public bool SolicitedFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(377).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(377, value);
      }
    }

    [FIXField("23", EFieldOption.Optional)]
    public string IOIID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(23).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(23, value);
      }
    }

    [FIXField("117", EFieldOption.Optional)]
    public string QuoteID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(117).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(117, value);
      }
    }

    [FIXField("59", EFieldOption.Optional)]
    public char TimeInForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(59).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(59, value);
      }
    }

    [FIXField("168", EFieldOption.Optional)]
    public DateTime EffectiveTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(168).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(168, value);
      }
    }

    [FIXField("432", EFieldOption.Optional)]
    public DateTime ExpireDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(432).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(432, value);
      }
    }

    [FIXField("126", EFieldOption.Optional)]
    public DateTime ExpireTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(126).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(126, value);
      }
    }

    [FIXField("427", EFieldOption.Optional)]
    public int GTBookingInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(427).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(427, value);
      }
    }

    [FIXField("12", EFieldOption.Optional)]
    public double Commission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(12).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(12, value);
      }
    }

    [FIXField("13", EFieldOption.Optional)]
    public char CommType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(13).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(13, value);
      }
    }

    [FIXField("479", EFieldOption.Optional)]
    public double CommCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(479).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(479, value);
      }
    }

    [FIXField("497", EFieldOption.Optional)]
    public char FundRenewWaiv
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(497).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(497, value);
      }
    }

    [FIXField("528", EFieldOption.Optional)]
    public char OrderCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(528).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(528, value);
      }
    }

    [FIXField("529", EFieldOption.Optional)]
    public string OrderRestrictions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(529).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(529, value);
      }
    }

    [FIXField("582", EFieldOption.Optional)]
    public int CustOrderCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(582).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(582, value);
      }
    }

    [FIXField("121", EFieldOption.Optional)]
    public bool ForexReq
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(121).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(121, value);
      }
    }

    [FIXField("120", EFieldOption.Optional)]
    public double SettlCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(120).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(120, value);
      }
    }

    [FIXField("775", EFieldOption.Optional)]
    public int BookingType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(775).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(775, value);
      }
    }

    [FIXField("58", EFieldOption.Optional)]
    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(58).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(58, value);
      }
    }

    [FIXField("354", EFieldOption.Optional)]
    public int EncodedTextLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(354).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(354, value);
      }
    }

    [FIXField("355", EFieldOption.Optional)]
    public string EncodedText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(355).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(355, value);
      }
    }

    [FIXField("193", EFieldOption.Optional)]
    public DateTime SettlDate2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(193).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(193, value);
      }
    }

    [FIXField("192", EFieldOption.Optional)]
    public double OrderQty2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(192).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(192, value);
      }
    }

    [FIXField("640", EFieldOption.Optional)]
    public double Price2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(640).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(640, value);
      }
    }

    [FIXField("77", EFieldOption.Optional)]
    public char PositionEffect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(77).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(77, value);
      }
    }

    [FIXField("203", EFieldOption.Optional)]
    public int CoveredOrUncovered
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(203).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(203, value);
      }
    }

    [FIXField("210", EFieldOption.Optional)]
    public double MaxShow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(210).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(210, value);
      }
    }

    [FIXField("211", EFieldOption.Optional)]
    public double PegOffsetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(211).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(211, value);
      }
    }

    [FIXField("835", EFieldOption.Optional)]
    public int PegMoveType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(835).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(835, value);
      }
    }

    [FIXField("836", EFieldOption.Optional)]
    public int PegOffsetType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(836).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(836, value);
      }
    }

    [FIXField("837", EFieldOption.Optional)]
    public int PegLimitType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(837).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(837, value);
      }
    }

    [FIXField("838", EFieldOption.Optional)]
    public int PegRoundDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(838).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(838, value);
      }
    }

    [FIXField("840", EFieldOption.Optional)]
    public int PegScope
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(840).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(840, value);
      }
    }

    [FIXField("388", EFieldOption.Optional)]
    public char DiscretionInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(388).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(388, value);
      }
    }

    [FIXField("389", EFieldOption.Optional)]
    public double DiscretionOffsetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(389).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(389, value);
      }
    }

    [FIXField("841", EFieldOption.Optional)]
    public int DiscretionMoveType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(841).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(841, value);
      }
    }

    [FIXField("842", EFieldOption.Optional)]
    public int DiscretionOffsetType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(842).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(842, value);
      }
    }

    [FIXField("843", EFieldOption.Optional)]
    public int DiscretionLimitType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(843).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(843, value);
      }
    }

    [FIXField("844", EFieldOption.Optional)]
    public int DiscretionRoundDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(844).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(844, value);
      }
    }

    [FIXField("846", EFieldOption.Optional)]
    public int DiscretionScope
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(846).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(846, value);
      }
    }

    [FIXField("847", EFieldOption.Optional)]
    public int TargetStrategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(847).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(847, value);
      }
    }

    [FIXField("848", EFieldOption.Optional)]
    public string TargetStrategyParameters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(848).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(848, value);
      }
    }

    [FIXField("849", EFieldOption.Optional)]
    public double ParticipationRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(849).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(849, value);
      }
    }

    [FIXField("494", EFieldOption.Optional)]
    public string Designation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(494).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(494, value);
      }
    }

    public FIXOrdersGroup():base()
    {
      this.hDUUiNXQor = new ArrayList();
      this.zOaUl4gw1I = new ArrayList();
      this.hxBUBt8PY1 = new ArrayList();
      this.qgwUOpCCGl = new ArrayList();
      this.upwUxtBFiq = new ArrayList();
      this.rebU5r5Gnt = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrdersGroup(string ClOrdID, int ListSeqNo, char Side) : base()
    {
      this.hDUUiNXQor = new ArrayList();
      this.zOaUl4gw1I = new ArrayList();
      this.hxBUBt8PY1 = new ArrayList();
      this.qgwUOpCCGl = new ArrayList();
      this.upwUxtBFiq = new ArrayList();
      this.rebU5r5Gnt = new ArrayList();
      this.ClOrdID = ClOrdID;
      this.ListSeqNo = ListSeqNo;
      this.Side = Side;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.hDUUiNXQor[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.hDUUiNXQor.Add((object) group);
      ++this.NoPartyIDs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXAllocsGroup GetAllocsGroup(int i)
    {
      if (i < this.NoAllocs)
        return (FIXAllocsGroup) this.zOaUl4gw1I[i];
      else
        return (FIXAllocsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXAllocsGroup group)
    {
      this.zOaUl4gw1I.Add((object) group);
      ++this.NoAllocs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
    {
      if (i < this.NoTradingSessions)
        return (FIXTradingSessionsGroup) this.hxBUBt8PY1[i];
      else
        return (FIXTradingSessionsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXTradingSessionsGroup group)
    {
      this.hxBUBt8PY1.Add((object) group);
      ++this.NoTradingSessions;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.qgwUOpCCGl[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.qgwUOpCCGl.Add((object) group);
      ++this.NoSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.upwUxtBFiq[i];
      else
        return (FIXEventsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXEventsGroup group)
    {
      this.upwUxtBFiq.Add((object) group);
      ++this.NoEvents;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStipulationsGroup GetStipulationsGroup(int i)
    {
      if (i < this.NoStipulations)
        return (FIXStipulationsGroup) this.rebU5r5Gnt[i];
      else
        return (FIXStipulationsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXStipulationsGroup group)
    {
      this.rebU5r5Gnt.Add((object) group);
      ++this.NoStipulations;
    }
  }
}
