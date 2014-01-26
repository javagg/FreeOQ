using System;
using System.Collections;

namespace FreeQuant.FIX
{
  public class FIXOrderCancelRequest : FIXMessage
  {
    private ArrayList hfmtC4siS9;
    private ArrayList qrwt2VawNg;
    private ArrayList WDrtcPF3A7;
    private ArrayList qiMtzZLgcI;
    private ArrayList WYpQSbmcnC;
    private ArrayList JJnQU746Iq;

    [FIXField("144", EFieldOption.Optional)]
    public string OnBehalfOfLocationID
    {
       get
      {
        return this.GetStringField(144).Value;
      }
       set
      {
        this.AddStringField(144, value);
      }
    }

    [FIXField("9", EFieldOption.Required)]
    public int BodyLength
    {
       get
      {
        return this.GetIntField(9).Value;
      }
       set
      {
        this.AddIntField(9, value);
      }
    }

    [FIXField("35", EFieldOption.Required)]
    public string MsgType
    {
       get
      {
        return this.GetStringField(35).Value;
      }
       set
      {
        this.AddStringField(35, value);
      }
    }

    [FIXField("49", EFieldOption.Required)]
    public string SenderCompID
    {
       get
      {
        return this.GetStringField(49).Value;
      }
       set
      {
        this.AddStringField(49, value);
      }
    }

    [FIXField("56", EFieldOption.Required)]
    public string TargetCompID
    {
       get
      {
        return this.GetStringField(56).Value;
      }
       set
      {
        this.AddStringField(56, value);
      }
    }

    [FIXField("115", EFieldOption.Optional)]
    public string OnBehalfOfCompID
    {
       get
      {
        return this.GetStringField(115).Value;
      }
       set
      {
        this.AddStringField(115, value);
      }
    }

    [FIXField("128", EFieldOption.Optional)]
    public string DeliverToCompID
    {
       get
      {
        return this.GetStringField(128).Value;
      }
       set
      {
        this.AddStringField(128, value);
      }
    }

    [FIXField("90", EFieldOption.Optional)]
    public int SecureDataLen
    {
       get
      {
        return this.GetIntField(90).Value;
      }
       set
      {
        this.AddIntField(90, value);
      }
    }

    [FIXField("91", EFieldOption.Optional)]
    public string SecureData
    {
       get
      {
        return this.GetStringField(91).Value;
      }
       set
      {
        this.AddStringField(91, value);
      }
    }

    [FIXField("34", EFieldOption.Required)]
    public int MsgSeqNum
    {
       get
      {
        return this.GetIntField(34).Value;
      }
       set
      {
        this.AddIntField(34, value);
      }
    }

    [FIXField("50", EFieldOption.Optional)]
    public string SenderSubID
    {
       get
      {
        return this.GetStringField(50).Value;
      }
       set
      {
        this.AddStringField(50, value);
      }
    }

    [FIXField("142", EFieldOption.Optional)]
    public string SenderLocationID
    {
       get
      {
        return this.GetStringField(142).Value;
      }
       set
      {
        this.AddStringField(142, value);
      }
    }

    [FIXField("57", EFieldOption.Optional)]
    public string TargetSubID
    {
       get
      {
        return this.GetStringField(57).Value;
      }
       set
      {
        this.AddStringField(57, value);
      }
    }

    [FIXField("8", EFieldOption.Required)]
    public string BeginString
    {
       get
      {
        return this.GetStringField(8).Value;
      }
       set
      {
        this.AddStringField(8, value);
      }
    }

    [FIXField("116", EFieldOption.Optional)]
    public string OnBehalfOfSubID
    {
       get
      {
        return this.GetStringField(116).Value;
      }
       set
      {
        this.AddStringField(116, value);
      }
    }

    [FIXField("129", EFieldOption.Optional)]
    public string DeliverToSubID
    {
       get
      {
        return this.GetStringField(129).Value;
      }
       set
      {
        this.AddStringField(129, value);
      }
    }

    [FIXField("145", EFieldOption.Optional)]
    public string DeliverToLocationID
    {
       get
      {
        return this.GetStringField(145).Value;
      }
       set
      {
        this.AddStringField(145, value);
      }
    }

    [FIXField("43", EFieldOption.Optional)]
    public bool PossDupFlag
    {
       get
      {
        return this.GetBoolField(43).Value;
      }
       set
      {
        this.AddBoolField(43, value);
      }
    }

    [FIXField("97", EFieldOption.Optional)]
    public bool PossResend
    {
       get
      {
        return this.GetBoolField(97).Value;
      }
       set
      {
        this.AddBoolField(97, value);
      }
    }

    [FIXField("52", EFieldOption.Optional)]
    public DateTime SendingTime
    {
       get
      {
        return this.GetDateTimeField(52).Value;
      }
       set
      {
        this.AddDateTimeField(52, value);
      }
    }

    [FIXField("122", EFieldOption.Optional)]
    public DateTime OrigSendingTime
    {
       get
      {
        return this.GetDateTimeField(122).Value;
      }
       set
      {
        this.AddDateTimeField(122, value);
      }
    }

    [FIXField("212", EFieldOption.Optional)]
    public int XmlDataLen
    {
       get
      {
        return this.GetIntField(212).Value;
      }
       set
      {
        this.AddIntField(212, value);
      }
    }

    [FIXField("213", EFieldOption.Optional)]
    public string XmlData
    {
       get
      {
        return this.GetStringField(213).Value;
      }
       set
      {
        this.AddStringField(213, value);
      }
    }

    [FIXField("347", EFieldOption.Optional)]
    public string MessageEncoding
    {
       get
      {
        return this.GetStringField(347).Value;
      }
       set
      {
        this.AddStringField(347, value);
      }
    }

    [FIXField("369", EFieldOption.Optional)]
    public int LastMsgSeqNumProcessed
    {
       get
      {
        return this.GetIntField(369).Value;
      }
       set
      {
        this.AddIntField(369, value);
      }
    }

    [FIXField("627", EFieldOption.Optional)]
    public int NoHops
    {
       get
      {
        return this.GetIntField(627).Value;
      }
       set
      {
        this.AddIntField(627, value);
      }
    }

    [FIXField("143", EFieldOption.Optional)]
    public string TargetLocationID
    {
       get
      {
        return this.GetStringField(143).Value;
      }
       set
      {
        this.AddStringField(143, value);
      }
    }

    [FIXField("41", EFieldOption.Required)]
    public string OrigClOrdID
    {
       get
      {
        return this.GetStringField(41).Value;
      }
       set
      {
        this.AddStringField(41, value);
      }
    }

    [FIXField("37", EFieldOption.Optional)]
    public string OrderID
    {
       get
      {
        return this.GetStringField(37).Value;
      }
       set
      {
        this.AddStringField(37, value);
      }
    }

    [FIXField("11", EFieldOption.Required)]
    public string ClOrdID
    {
       get
      {
        return this.GetStringField(11).Value;
      }
       set
      {
        this.AddStringField(11, value);
      }
    }

    [FIXField("526", EFieldOption.Optional)]
    public string SecondaryClOrdID
    {
       get
      {
        return this.GetStringField(526).Value;
      }
       set
      {
        this.AddStringField(526, value);
      }
    }

    [FIXField("583", EFieldOption.Optional)]
    public string ClOrdLinkID
    {
       get
      {
        return this.GetStringField(583).Value;
      }
       set
      {
        this.AddStringField(583, value);
      }
    }

    [FIXField("66", EFieldOption.Optional)]
    public string ListID
    {
       get
      {
        return this.GetStringField(66).Value;
      }
       set
      {
        this.AddStringField(66, value);
      }
    }

    [FIXField("586", EFieldOption.Optional)]
    public DateTime OrigOrdModTime
    {
       get
      {
        return this.GetDateTimeField(586).Value;
      }
       set
      {
        this.AddDateTimeField(586, value);
      }
    }

    [FIXField("1", EFieldOption.Optional)]
    public string Account
    {
       get
      {
        return this.GetStringField(1).Value;
      }
       set
      {
        this.AddStringField(1, value);
      }
    }

    [FIXField("660", EFieldOption.Optional)]
    public int AcctIDSource
    {
       get
      {
        return this.GetIntField(660).Value;
      }
       set
      {
        this.AddIntField(660, value);
      }
    }

    [FIXField("581", EFieldOption.Optional)]
    public int AccountType
    {
       get
      {
        return this.GetIntField(581).Value;
      }
       set
      {
        this.AddIntField(581, value);
      }
    }

    [FIXField("453", EFieldOption.Optional)]
    public int NoPartyIDs
    {
       get
      {
        return this.GetIntField(453).Value;
      }
       set
      {
        this.AddIntField(453, value);
      }
    }

    [FIXField("55", EFieldOption.Optional)]
    public string Symbol
    {
       get
      {
        return this.GetStringField(55).Value;
      }
       set
      {
        this.AddStringField(55, value);
      }
    }

    [FIXField("65", EFieldOption.Optional)]
    public string SymbolSfx
    {
       get
      {
        return this.GetStringField(65).Value;
      }
       set
      {
        this.AddStringField(65, value);
      }
    }

    [FIXField("48", EFieldOption.Optional)]
    public string SecurityID
    {
       get
      {
        return this.GetStringField(48).Value;
      }
       set
      {
        this.AddStringField(48, value);
      }
    }

    [FIXField("22", EFieldOption.Optional)]
    public string SecurityIDSource
    {
       get
      {
        return this.GetStringField(22).Value;
      }
       set
      {
        this.AddStringField(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
    public int NoSecurityAltID
    {
       get
      {
        return this.GetIntField(454).Value;
      }
       set
      {
        this.AddIntField(454, value);
      }
    }

    [FIXField("460", EFieldOption.Optional)]
    public int Product
    {
       get
      {
        return this.GetIntField(460).Value;
      }
       set
      {
        this.AddIntField(460, value);
      }
    }

    [FIXField("461", EFieldOption.Optional)]
    public string CFICode
    {
       get
      {
        return this.GetStringField(461).Value;
      }
       set
      {
        this.AddStringField(461, value);
      }
    }

    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
       get
      {
        return this.GetStringField(167).Value;
      }
       set
      {
        this.AddStringField(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    public string SecuritySubType
    {
       get
      {
        return this.GetStringField(762).Value;
      }
       set
      {
        this.AddStringField(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    public string MaturityMonthYear
    {
       get
      {
        return this.GetStringField(200).Value;
      }
       set
      {
        this.AddStringField(200, value);
      }
    }

    [FIXField("541", EFieldOption.Optional)]
    public DateTime MaturityDate
    {
       get
      {
        return this.GetDateTimeField(541).Value;
      }
       set
      {
        this.AddDateTimeField(541, value);
      }
    }

    [FIXField("224", EFieldOption.Optional)]
    public DateTime CouponPaymentDate
    {
       get
      {
        return this.GetDateTimeField(224).Value;
      }
       set
      {
        this.AddDateTimeField(224, value);
      }
    }

    [FIXField("225", EFieldOption.Optional)]
    public DateTime IssueDate
    {
       get
      {
        return this.GetDateTimeField(225).Value;
      }
       set
      {
        this.AddDateTimeField(225, value);
      }
    }

    [FIXField("239", EFieldOption.Optional)]
    public int RepoCollateralSecurityType
    {
       get
      {
        return this.GetIntField(239).Value;
      }
       set
      {
        this.AddIntField(239, value);
      }
    }

    [FIXField("226", EFieldOption.Optional)]
    public int RepurchaseTerm
    {
       get
      {
        return this.GetIntField(226).Value;
      }
       set
      {
        this.AddIntField(226, value);
      }
    }

    [FIXField("227", EFieldOption.Optional)]
    public double RepurchaseRate
    {
       get
      {
        return this.GetDoubleField(227).Value;
      }
       set
      {
        this.AddDoubleField(227, value);
      }
    }

    [FIXField("228", EFieldOption.Optional)]
    public double Factor
    {
       get
      {
        return this.GetDoubleField(228).Value;
      }
       set
      {
        this.AddDoubleField(228, value);
      }
    }

    [FIXField("255", EFieldOption.Optional)]
    public string CreditRating
    {
       get
      {
        return this.GetStringField((int) byte.MaxValue).Value;
      }
       set
      {
        this.AddStringField((int) byte.MaxValue, value);
      }
    }

    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
       get
      {
        return this.GetStringField(543).Value;
      }
       set
      {
        this.AddStringField(543, value);
      }
    }

    [FIXField("470", EFieldOption.Optional)]
    public string CountryOfIssue
    {
       get
      {
        return this.GetStringField(470).Value;
      }
       set
      {
        this.AddStringField(470, value);
      }
    }

    [FIXField("471", EFieldOption.Optional)]
    public string StateOrProvinceOfIssue
    {
       get
      {
        return this.GetStringField(471).Value;
      }
       set
      {
        this.AddStringField(471, value);
      }
    }

    [FIXField("472", EFieldOption.Optional)]
    public string LocaleOfIssue
    {
       get
      {
        return this.GetStringField(472).Value;
      }
       set
      {
        this.AddStringField(472, value);
      }
    }

    [FIXField("240", EFieldOption.Optional)]
    public DateTime RedemptionDate
    {
       get
      {
        return this.GetDateTimeField(240).Value;
      }
       set
      {
        this.AddDateTimeField(240, value);
      }
    }

    [FIXField("202", EFieldOption.Optional)]
    public double StrikePrice
    {
       get
      {
        return this.GetDoubleField(202).Value;
      }
       set
      {
        this.AddDoubleField(202, value);
      }
    }

    [FIXField("947", EFieldOption.Optional)]
    public double StrikeCurrency
    {
       get
      {
        return this.GetDoubleField(947).Value;
      }
       set
      {
        this.AddDoubleField(947, value);
      }
    }

    [FIXField("206", EFieldOption.Optional)]
    public char OptAttribute
    {
       get
      {
        return this.GetCharField(206).Value;
      }
       set
      {
        this.AddCharField(206, value);
      }
    }

    [FIXField("231", EFieldOption.Optional)]
    public double ContractMultiplier
    {
       get
      {
        return this.GetDoubleField(231).Value;
      }
       set
      {
        this.AddDoubleField(231, value);
      }
    }

    [FIXField("223", EFieldOption.Optional)]
    public double CouponRate
    {
       get
      {
        return this.GetDoubleField(223).Value;
      }
       set
      {
        this.AddDoubleField(223, value);
      }
    }

    [FIXField("207", EFieldOption.Optional)]
    public string SecurityExchange
    {
       get
      {
        return this.GetStringField(207).Value;
      }
       set
      {
        this.AddStringField(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    public string Issuer
    {
       get
      {
        return this.GetStringField(106).Value;
      }
       set
      {
        this.AddStringField(106, value);
      }
    }

    [FIXField("348", EFieldOption.Optional)]
    public int EncodedIssuerLen
    {
       get
      {
        return this.GetIntField(348).Value;
      }
       set
      {
        this.AddIntField(348, value);
      }
    }

    [FIXField("349", EFieldOption.Optional)]
    public string EncodedIssuer
    {
       get
      {
        return this.GetStringField(349).Value;
      }
       set
      {
        this.AddStringField(349, value);
      }
    }

    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
       get
      {
        return this.GetStringField(107).Value;
      }
       set
      {
        this.AddStringField(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
    public int EncodedSecurityDescLen
    {
       get
      {
        return this.GetIntField(350).Value;
      }
       set
      {
        this.AddIntField(350, value);
      }
    }

    [FIXField("351", EFieldOption.Optional)]
    public string EncodedSecurityDesc
    {
       get
      {
        return this.GetStringField(351).Value;
      }
       set
      {
        this.AddStringField(351, value);
      }
    }

    [FIXField("691", EFieldOption.Optional)]
    public string Pool
    {
       get
      {
        return this.GetStringField(691).Value;
      }
       set
      {
        this.AddStringField(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    public string ContractSettlMonth
    {
       get
      {
        return this.GetStringField(667).Value;
      }
       set
      {
        this.AddStringField(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
    public int CPProgram
    {
       get
      {
        return this.GetIntField(875).Value;
      }
       set
      {
        this.AddIntField(875, value);
      }
    }

    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
       get
      {
        return this.GetStringField(876).Value;
      }
       set
      {
        this.AddStringField(876, value);
      }
    }

    [FIXField("864", EFieldOption.Optional)]
    public int NoEvents
    {
       get
      {
        return this.GetIntField(864).Value;
      }
       set
      {
        this.AddIntField(864, value);
      }
    }

    [FIXField("873", EFieldOption.Optional)]
    public DateTime DatedDate
    {
       get
      {
        return this.GetDateTimeField(873).Value;
      }
       set
      {
        this.AddDateTimeField(873, value);
      }
    }

    [FIXField("874", EFieldOption.Optional)]
    public DateTime InterestAccrualDate
    {
       get
      {
        return this.GetDateTimeField(874).Value;
      }
       set
      {
        this.AddDateTimeField(874, value);
      }
    }

    [FIXField("913", EFieldOption.Optional)]
    public string AgreementDesc
    {
       get
      {
        return this.GetStringField(913).Value;
      }
       set
      {
        this.AddStringField(913, value);
      }
    }

    [FIXField("914", EFieldOption.Optional)]
    public string AgreementID
    {
       get
      {
        return this.GetStringField(914).Value;
      }
       set
      {
        this.AddStringField(914, value);
      }
    }

    [FIXField("915", EFieldOption.Optional)]
    public DateTime AgreementDate
    {
       get
      {
        return this.GetDateTimeField(915).Value;
      }
       set
      {
        this.AddDateTimeField(915, value);
      }
    }

    [FIXField("918", EFieldOption.Optional)]
    public double AgreementCurrency
    {
       get
      {
        return this.GetDoubleField(918).Value;
      }
       set
      {
        this.AddDoubleField(918, value);
      }
    }

    [FIXField("788", EFieldOption.Optional)]
    public int TerminationType
    {
       get
      {
        return this.GetIntField(788).Value;
      }
       set
      {
        this.AddIntField(788, value);
      }
    }

    [FIXField("916", EFieldOption.Optional)]
    public DateTime StartDate
    {
       get
      {
        return this.GetDateTimeField(916).Value;
      }
       set
      {
        this.AddDateTimeField(916, value);
      }
    }

    [FIXField("917", EFieldOption.Optional)]
    public DateTime EndDate
    {
       get
      {
        return this.GetDateTimeField(917).Value;
      }
       set
      {
        this.AddDateTimeField(917, value);
      }
    }

    [FIXField("919", EFieldOption.Optional)]
    public int DeliveryType
    {
       get
      {
        return this.GetIntField(919).Value;
      }
       set
      {
        this.AddIntField(919, value);
      }
    }

    [FIXField("898", EFieldOption.Optional)]
    public double MarginRatio
    {
       get
      {
        return this.GetDoubleField(898).Value;
      }
       set
      {
        this.AddDoubleField(898, value);
      }
    }

    [FIXField("711", EFieldOption.Optional)]
    public int NoUnderlyings
    {
       get
      {
        return this.GetIntField(711).Value;
      }
       set
      {
        this.AddIntField(711, value);
      }
    }

    [FIXField("54", EFieldOption.Required)]
    public char Side
    {
       get
      {
        return this.GetCharField(54).Value;
      }
       set
      {
        this.AddCharField(54, value);
      }
    }

    [FIXField("60", EFieldOption.Required)]
    public DateTime TransactTime
    {
       get
      {
        return this.GetDateTimeField(60).Value;
      }
       set
      {
        this.AddDateTimeField(60, value);
      }
    }

    [FIXField("38", EFieldOption.Optional)]
    public double OrderQty
    {
       get
      {
        return this.GetDoubleField(38).Value;
      }
       set
      {
        this.AddDoubleField(38, value);
      }
    }

    [FIXField("152", EFieldOption.Optional)]
    public double CashOrderQty
    {
       get
      {
        return this.GetDoubleField(152).Value;
      }
       set
      {
        this.AddDoubleField(152, value);
      }
    }

    [FIXField("516", EFieldOption.Optional)]
    public double OrderPercent
    {
       get
      {
        return this.GetDoubleField(516).Value;
      }
       set
      {
        this.AddDoubleField(516, value);
      }
    }

    [FIXField("468", EFieldOption.Optional)]
    public char RoundingDirection
    {
       get
      {
        return this.GetCharField(468).Value;
      }
       set
      {
        this.AddCharField(468, value);
      }
    }

    [FIXField("469", EFieldOption.Optional)]
    public double RoundingModulus
    {
       get
      {
        return this.GetDoubleField(469).Value;
      }
       set
      {
        this.AddDoubleField(469, value);
      }
    }

    [FIXField("376", EFieldOption.Optional)]
    public string ComplianceID
    {
       get
      {
        return this.GetStringField(376).Value;
      }
       set
      {
        this.AddStringField(376, value);
      }
    }

    [FIXField("58", EFieldOption.Optional)]
    public string Text
    {
       get
      {
        return this.GetStringField(58).Value;
      }
       set
      {
        this.AddStringField(58, value);
      }
    }

    [FIXField("354", EFieldOption.Optional)]
    public int EncodedTextLen
    {
       get
      {
        return this.GetIntField(354).Value;
      }
       set
      {
        this.AddIntField(354, value);
      }
    }

    [FIXField("355", EFieldOption.Optional)]
    public string EncodedText
    {
       get
      {
        return this.GetStringField(355).Value;
      }
       set
      {
        this.AddStringField(355, value);
      }
    }

    [FIXField("10", EFieldOption.Required)]
    public string CheckSum
    {
       get
      {
        return this.GetStringField(10).Value;
      }
       set
      {
        this.AddStringField(10, value);
      }
    }

    [FIXField("89", EFieldOption.Optional)]
    public string Signature
    {
       get
      {
        return this.GetStringField(89).Value;
      }
       set
      {
        this.AddStringField(89, value);
      }
    }

    [FIXField("93", EFieldOption.Optional)]
    public int SignatureLength
    {
       get
      {
        return this.GetIntField(93).Value;
      }
       set
      {
        this.AddIntField(93, value);
      }
    }

    
    public FIXOrderCancelRequest():base()
    {
      this.hfmtC4siS9 = new ArrayList();
      this.qrwt2VawNg = new ArrayList();
      this.WDrtcPF3A7 = new ArrayList();
      this.qiMtzZLgcI = new ArrayList();
      this.WYpQSbmcnC = new ArrayList();
      this.JJnQU746Iq = new ArrayList();
    }

    public FIXOrderCancelRequest(string OrigClOrdID, string ClOrdID, char Side, DateTime TransactTime):base()
    {

      this.hfmtC4siS9 = new ArrayList();
      this.qrwt2VawNg = new ArrayList();
      this.WDrtcPF3A7 = new ArrayList();
      this.qiMtzZLgcI = new ArrayList();
      this.WYpQSbmcnC = new ArrayList();
      this.JJnQU746Iq = new ArrayList();

      this.OrigClOrdID = OrigClOrdID;
      this.ClOrdID = ClOrdID;
      this.Side = Side;
      this.TransactTime = TransactTime;
    }

    
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.hfmtC4siS9[i];
    }

    
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.hfmtC4siS9.Add((object) group);
    }

    
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.qrwt2VawNg[i];
      else
        return (FIXHopsGroup) null;
    }

    
    public void AddGroup(FIXHopsGroup group)
    {
      this.qrwt2VawNg.Add((object) group);
      ++this.NoHops;
    }

    
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.WDrtcPF3A7[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.WDrtcPF3A7.Add((object) group);
      ++this.NoPartyIDs;
    }

    
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.qiMtzZLgcI[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.qiMtzZLgcI.Add((object) group);
      ++this.NoSecurityAltID;
    }

    
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.WYpQSbmcnC[i];
      else
        return (FIXEventsGroup) null;
    }

    
    public void AddGroup(FIXEventsGroup group)
    {
      this.WYpQSbmcnC.Add((object) group);
      ++this.NoEvents;
    }

    
    public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
    {
      if (i < this.NoUnderlyings)
        return (FIXUnderlyingsGroup) this.JJnQU746Iq[i];
      else
        return (FIXUnderlyingsGroup) null;
    }

    
    public void AddGroup(FIXUnderlyingsGroup group)
    {
      this.JJnQU746Iq.Add((object) group);
      ++this.NoUnderlyings;
    }
  }
}
