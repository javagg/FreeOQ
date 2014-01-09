using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderMassCancelReport : FIXMessage
  {
    private ArrayList Q9muiyDsoT;
    private ArrayList H2YuljlT7e;
    private ArrayList LbsuBPVg7s;
    private ArrayList ntbuOAPdfj;
    private ArrayList a1auxuiNfi;
    private ArrayList oc9u5ITyPp;
    private ArrayList zomugSSfxR;

    [FIXField("144", EFieldOption.Optional)]
    public string OnBehalfOfLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(144).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(144, value);
      }
    }

    [FIXField("9", EFieldOption.Required)]
    public int BodyLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(9).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(9, value);
      }
    }

    [FIXField("35", EFieldOption.Required)]
    public string MsgType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(35).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(35, value);
      }
    }

    [FIXField("49", EFieldOption.Required)]
    public string SenderCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(49).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(49, value);
      }
    }

    [FIXField("56", EFieldOption.Required)]
    public string TargetCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(56).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(56, value);
      }
    }

    [FIXField("115", EFieldOption.Optional)]
    public string OnBehalfOfCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(115).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(115, value);
      }
    }

    [FIXField("128", EFieldOption.Optional)]
    public string DeliverToCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(128).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(128, value);
      }
    }

    [FIXField("90", EFieldOption.Optional)]
    public int SecureDataLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(90).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(90, value);
      }
    }

    [FIXField("91", EFieldOption.Optional)]
    public string SecureData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(91).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(91, value);
      }
    }

    [FIXField("34", EFieldOption.Required)]
    public int MsgSeqNum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(34).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(34, value);
      }
    }

    [FIXField("50", EFieldOption.Optional)]
    public string SenderSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(50).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(50, value);
      }
    }

    [FIXField("142", EFieldOption.Optional)]
    public string SenderLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(142).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(142, value);
      }
    }

    [FIXField("57", EFieldOption.Optional)]
    public string TargetSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(57).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(57, value);
      }
    }

    [FIXField("8", EFieldOption.Required)]
    public string BeginString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(8).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(8, value);
      }
    }

    [FIXField("116", EFieldOption.Optional)]
    public string OnBehalfOfSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(116).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(116, value);
      }
    }

    [FIXField("129", EFieldOption.Optional)]
    public string DeliverToSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(129).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(129, value);
      }
    }

    [FIXField("145", EFieldOption.Optional)]
    public string DeliverToLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(145).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(145, value);
      }
    }

    [FIXField("43", EFieldOption.Optional)]
    public bool PossDupFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(43).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(43, value);
      }
    }

    [FIXField("97", EFieldOption.Optional)]
    public bool PossResend
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(97).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(97, value);
      }
    }

    [FIXField("52", EFieldOption.Optional)]
    public DateTime SendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(52).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(52, value);
      }
    }

    [FIXField("122", EFieldOption.Optional)]
    public DateTime OrigSendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(122).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(122, value);
      }
    }

    [FIXField("212", EFieldOption.Optional)]
    public int XmlDataLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(212).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(212, value);
      }
    }

    [FIXField("213", EFieldOption.Optional)]
    public string XmlData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(213).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(213, value);
      }
    }

    [FIXField("347", EFieldOption.Optional)]
    public string MessageEncoding
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(347).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(347, value);
      }
    }

    [FIXField("369", EFieldOption.Optional)]
    public int LastMsgSeqNumProcessed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(369).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(369, value);
      }
    }

    [FIXField("627", EFieldOption.Optional)]
    public int NoHops
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(627).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(627, value);
      }
    }

    [FIXField("143", EFieldOption.Optional)]
    public string TargetLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(143).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(143, value);
      }
    }

    [FIXField("11", EFieldOption.Optional)]
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

    [FIXField("37", EFieldOption.Required)]
    public string OrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(37).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(37, value);
      }
    }

    [FIXField("198", EFieldOption.Optional)]
    public string SecondaryOrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(198).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(198, value);
      }
    }

    [FIXField("530", EFieldOption.Required)]
    public char MassCancelRequestType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(530).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(530, value);
      }
    }

    [FIXField("531", EFieldOption.Required)]
    public char MassCancelResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(531).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(531, value);
      }
    }

    [FIXField("532", EFieldOption.Optional)]
    public char MassCancelRejectReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(532).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(532, value);
      }
    }

    [FIXField("533", EFieldOption.Optional)]
    public int TotalAffectedOrders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(533).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(533, value);
      }
    }

    [FIXField("534", EFieldOption.Optional)]
    public int NoAffectedOrders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(534).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(534, value);
      }
    }

    [FIXField("336", EFieldOption.Optional)]
    public string TradingSessionID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(336).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(336, value);
      }
    }

    [FIXField("625", EFieldOption.Optional)]
    public string TradingSessionSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(625).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(625, value);
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

    [FIXField("311", EFieldOption.Optional)]
    public string UnderlyingSymbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(311).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(311, value);
      }
    }

    [FIXField("312", EFieldOption.Optional)]
    public string UnderlyingSymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(312).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(312, value);
      }
    }

    [FIXField("309", EFieldOption.Optional)]
    public string UnderlyingSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(309).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(309, value);
      }
    }

    [FIXField("305", EFieldOption.Optional)]
    public string UnderlyingSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(305).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(305, value);
      }
    }

    [FIXField("457", EFieldOption.Optional)]
    public int NoUnderlyingSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(457).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(457, value);
      }
    }

    [FIXField("462", EFieldOption.Optional)]
    public int UnderlyingProduct
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(462).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(462, value);
      }
    }

    [FIXField("463", EFieldOption.Optional)]
    public string UnderlyingCFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(463).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(463, value);
      }
    }

    [FIXField("310", EFieldOption.Optional)]
    public string UnderlyingSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(310).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(310, value);
      }
    }

    [FIXField("763", EFieldOption.Optional)]
    public string UnderlyingSecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(763).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(763, value);
      }
    }

    [FIXField("313", EFieldOption.Optional)]
    public string UnderlyingMaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(313).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(313, value);
      }
    }

    [FIXField("542", EFieldOption.Optional)]
    public DateTime UnderlyingMaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(542).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(542, value);
      }
    }

    [FIXField("241", EFieldOption.Optional)]
    public DateTime UnderlyingCouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(241).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(241, value);
      }
    }

    [FIXField("242", EFieldOption.Optional)]
    public DateTime UnderlyingIssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(242).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(242, value);
      }
    }

    [FIXField("243", EFieldOption.Optional)]
    public int UnderlyingRepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(243).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(243, value);
      }
    }

    [FIXField("244", EFieldOption.Optional)]
    public int UnderlyingRepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(244).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(244, value);
      }
    }

    [FIXField("245", EFieldOption.Optional)]
    public double UnderlyingRepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(245).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(245, value);
      }
    }

    [FIXField("246", EFieldOption.Optional)]
    public double UnderlyingFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(246).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(246, value);
      }
    }

    [FIXField("256", EFieldOption.Optional)]
    public string UnderlyingCreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(256).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(256, value);
      }
    }

    [FIXField("595", EFieldOption.Optional)]
    public string UnderlyingInstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(595).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(595, value);
      }
    }

    [FIXField("592", EFieldOption.Optional)]
    public string UnderlyingCountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(592).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(592, value);
      }
    }

    [FIXField("593", EFieldOption.Optional)]
    public string UnderlyingStateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(593).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(593, value);
      }
    }

    [FIXField("594", EFieldOption.Optional)]
    public string UnderlyingLocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(594).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(594, value);
      }
    }

    [FIXField("247", EFieldOption.Optional)]
    public DateTime UnderlyingRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(247).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(247, value);
      }
    }

    [FIXField("316", EFieldOption.Optional)]
    public double UnderlyingStrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(316).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(316, value);
      }
    }

    [FIXField("941", EFieldOption.Optional)]
    public double UnderlyingStrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(941).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(941, value);
      }
    }

    [FIXField("317", EFieldOption.Optional)]
    public char UnderlyingOptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(317).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(317, value);
      }
    }

    [FIXField("436", EFieldOption.Optional)]
    public double UnderlyingContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(436).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(436, value);
      }
    }

    [FIXField("435", EFieldOption.Optional)]
    public double UnderlyingCouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(435).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(435, value);
      }
    }

    [FIXField("308", EFieldOption.Optional)]
    public string UnderlyingSecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(308).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(308, value);
      }
    }

    [FIXField("306", EFieldOption.Optional)]
    public string UnderlyingIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(306).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(306, value);
      }
    }

    [FIXField("362", EFieldOption.Optional)]
    public int EncodedUnderlyingIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(362).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(362, value);
      }
    }

    [FIXField("363", EFieldOption.Optional)]
    public string EncodedUnderlyingIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(363).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(363, value);
      }
    }

    [FIXField("307", EFieldOption.Optional)]
    public string UnderlyingSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(307).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(307, value);
      }
    }

    [FIXField("364", EFieldOption.Optional)]
    public int EncodedUnderlyingSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(364).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(364, value);
      }
    }

    [FIXField("365", EFieldOption.Optional)]
    public string EncodedUnderlyingSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(365).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(365, value);
      }
    }

    [FIXField("877", EFieldOption.Optional)]
    public string UnderlyingCPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(877).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(877, value);
      }
    }

    [FIXField("878", EFieldOption.Optional)]
    public string UnderlyingCPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(878).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(878, value);
      }
    }

    [FIXField("318", EFieldOption.Optional)]
    public double UnderlyingCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(318).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(318, value);
      }
    }

    [FIXField("879", EFieldOption.Optional)]
    public double UnderlyingQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(879).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(879, value);
      }
    }

    [FIXField("810", EFieldOption.Optional)]
    public double UnderlyingPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(810).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(810, value);
      }
    }

    [FIXField("882", EFieldOption.Optional)]
    public double UnderlyingDirtyPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(882).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(882, value);
      }
    }

    [FIXField("883", EFieldOption.Optional)]
    public double UnderlyingEndPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(883).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(883, value);
      }
    }

    [FIXField("884", EFieldOption.Optional)]
    public double UnderlyingStartValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(884).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(884, value);
      }
    }

    [FIXField("885", EFieldOption.Optional)]
    public double UnderlyingCurrentValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(885).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(885, value);
      }
    }

    [FIXField("886", EFieldOption.Optional)]
    public double UnderlyingEndValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(886).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(886, value);
      }
    }

    [FIXField("887", EFieldOption.Optional)]
    public int NoUnderlyingStips
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(887).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(887, value);
      }
    }

    [FIXField("54", EFieldOption.Optional)]
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

    [FIXField("10", EFieldOption.Required)]
    public string CheckSum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(10).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(10, value);
      }
    }

    [FIXField("89", EFieldOption.Optional)]
    public string Signature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(89).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(89, value);
      }
    }

    [FIXField("93", EFieldOption.Optional)]
    public int SignatureLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(93).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(93, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderMassCancelReport():base()
    {

      this.Q9muiyDsoT = new ArrayList();
      this.H2YuljlT7e = new ArrayList();
      this.LbsuBPVg7s = new ArrayList();
      this.ntbuOAPdfj = new ArrayList();
      this.a1auxuiNfi = new ArrayList();
      this.oc9u5ITyPp = new ArrayList();
      this.zomugSSfxR = new ArrayList();
    }

    public FIXOrderMassCancelReport(string OrderID, char MassCancelRequestType, char MassCancelResponse):base()
    {

      this.Q9muiyDsoT = new ArrayList();
      this.H2YuljlT7e = new ArrayList();
      this.LbsuBPVg7s = new ArrayList();
      this.ntbuOAPdfj = new ArrayList();
      this.a1auxuiNfi = new ArrayList();
      this.oc9u5ITyPp = new ArrayList();
      this.zomugSSfxR = new ArrayList();

      this.OrderID = OrderID;
      this.MassCancelRequestType = MassCancelRequestType;
      this.MassCancelResponse = MassCancelResponse;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.Q9muiyDsoT[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.Q9muiyDsoT.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.H2YuljlT7e[i];
      else
        return (FIXHopsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopsGroup group)
    {
      this.H2YuljlT7e.Add((object) group);
      ++this.NoHops;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXAffectedOrdersGroup GetAffectedOrdersGroup(int i)
    {
      if (i < this.NoAffectedOrders)
        return (FIXAffectedOrdersGroup) this.LbsuBPVg7s[i];
      else
        return (FIXAffectedOrdersGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXAffectedOrdersGroup group)
    {
      this.LbsuBPVg7s.Add((object) group);
      ++this.NoAffectedOrders;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.ntbuOAPdfj[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.ntbuOAPdfj.Add((object) group);
      ++this.NoSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.a1auxuiNfi[i];
      else
        return (FIXEventsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXEventsGroup group)
    {
      this.a1auxuiNfi.Add((object) group);
      ++this.NoEvents;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
    {
      if (i < this.NoUnderlyingSecurityAltID)
        return (FIXUnderlyingSecurityAltIDGroup) this.oc9u5ITyPp[i];
      else
        return (FIXUnderlyingSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
    {
      this.oc9u5ITyPp.Add((object) group);
      ++this.NoUnderlyingSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
    {
      if (i < this.NoUnderlyingStips)
        return (FIXUnderlyingStipsGroup) this.zomugSSfxR[i];
      else
        return (FIXUnderlyingStipsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingStipsGroup group)
    {
      this.zomugSSfxR.Add((object) group);
      ++this.NoUnderlyingStips;
    }
  }
}
