using System;
using System.Collections;

namespace FreeQuant.FIX
{
  public class FIXNewOrderSingle : FIXMessage
  {
    private ArrayList Gk8YDuogVw;
    private ArrayList mi3YPSTqEN;
    private ArrayList kb9YIAFtAE;
    private ArrayList D4iYHLFQdE;
    private ArrayList sxeYW3t0BM;
    private ArrayList jCaYTX9fmk;
    private ArrayList SgbYVisdm5;
    private ArrayList AxxYmvV7Zg;
    private ArrayList q6GYkjkFaA;

    [FIXField("144", EFieldOption.Optional)]
    public string OnBehalfOfLocationID
    {
       get
      {
        return this.GetStringValue(144);
      }
       set
      {
        this.SetStringValue(144, value);
      }
    }

    [FIXField("9", EFieldOption.Required)]
    public int BodyLength
    {
       get
      {
        return this.GetIntValue(9);
      }
       set
      {
        this.SetIntValue(9, value);
      }
    }

    [FIXField("35", EFieldOption.Required)]
    public string MsgType
    {
       get
      {
        return this.GetStringValue(35);
      }
       set
      {
        this.SetStringValue(35, value);
      }
    }

    [FIXField("49", EFieldOption.Required)]
    public string SenderCompID
    {
       get
      {
        return this.GetStringValue(49);
      }
       set
      {
        this.SetStringValue(49, value);
      }
    }

    [FIXField("56", EFieldOption.Required)]
    public string TargetCompID
    {
       get
      {
        return this.GetStringValue(56);
      }
       set
      {
        this.SetStringValue(56, value);
      }
    }

    [FIXField("115", EFieldOption.Optional)]
    public string OnBehalfOfCompID
    {
       get
      {
        return this.GetStringValue(115);
      }
       set
      {
        this.SetStringValue(115, value);
      }
    }

    [FIXField("128", EFieldOption.Optional)]
    public string DeliverToCompID
    {
       get
      {
        return this.GetStringValue(128);
      }
       set
      {
        this.SetStringValue(128, value);
      }
    }

    [FIXField("90", EFieldOption.Optional)]
    public int SecureDataLen
    {
       get
      {
        return this.GetIntValue(90);
      }
       set
      {
        this.SetIntValue(90, value);
      }
    }

    [FIXField("91", EFieldOption.Optional)]
    public string SecureData
    {
       get
      {
        return this.GetStringValue(91);
      }
       set
      {
        this.SetStringValue(91, value);
      }
    }

    [FIXField("34", EFieldOption.Required)]
    public int MsgSeqNum
    {
       get
      {
        return this.GetIntValue(34);
      }
       set
      {
        this.SetIntValue(34, value);
      }
    }

    [FIXField("50", EFieldOption.Optional)]
    public string SenderSubID
    {
       get
      {
        return this.GetStringValue(50);
      }
       set
      {
        this.SetStringValue(50, value);
      }
    }

    [FIXField("142", EFieldOption.Optional)]
    public string SenderLocationID
    {
       get
      {
        return this.GetStringValue(142);
      }
       set
      {
        this.SetStringValue(142, value);
      }
    }

    [FIXField("57", EFieldOption.Optional)]
    public string TargetSubID
    {
       get
      {
        return this.GetStringValue(57);
      }
       set
      {
        this.SetStringValue(57, value);
      }
    }

    [FIXField("8", EFieldOption.Required)]
    public string BeginString
    {
       get
      {
        return this.GetStringValue(8);
      }
       set
      {
        this.SetStringValue(8, value);
      }
    }

    [FIXField("116", EFieldOption.Optional)]
    public string OnBehalfOfSubID
    {
       get
      {
        return this.GetStringValue(116);
      }
       set
      {
        this.SetStringValue(116, value);
      }
    }

    [FIXField("129", EFieldOption.Optional)]
    public string DeliverToSubID
    {
       get
      {
        return this.GetStringValue(129);
      }
       set
      {
        this.SetStringValue(129, value);
      }
    }

    [FIXField("145", EFieldOption.Optional)]
    public string DeliverToLocationID
    {
       get
      {
        return this.GetStringValue(145);
      }
       set
      {
        this.SetStringValue(145, value);
      }
    }

    [FIXField("43", EFieldOption.Optional)]
    public bool PossDupFlag
    {
       get
      {
        return this.GetBoolValue(43);
      }
       set
      {
        this.SetBoolValue(43, value);
      }
    }

    [FIXField("97", EFieldOption.Optional)]
    public bool PossResend
    {
       get
      {
        return this.GetBoolValue(97);
      }
       set
      {
        this.SetBoolValue(97, value);
      }
    }

    [FIXField("52", EFieldOption.Optional)]
    public DateTime SendingTime
    {
       get
      {
        return this.GetDateTimeValue(52);
      }
       set
      {
        this.SetDateTimeValue(52, value);
      }
    }

    [FIXField("122", EFieldOption.Optional)]
    public DateTime OrigSendingTime
    {
       get
      {
        return this.GetDateTimeValue(122);
      }
       set
      {
        this.SetDateTimeValue(122, value);
      }
    }

    [FIXField("212", EFieldOption.Optional)]
    public int XmlDataLen
    {
       get
      {
        return this.GetIntValue(212);
      }
       set
      {
        this.SetIntValue(212, value);
      }
    }

    [FIXField("213", EFieldOption.Optional)]
    public string XmlData
    {
       get
      {
        return this.GetStringValue(213);
      }
       set
      {
        this.SetStringValue(213, value);
      }
    }

    [FIXField("347", EFieldOption.Optional)]
    public string MessageEncoding
    {
       get
      {
        return this.GetStringValue(347);
      }
       set
      {
        this.SetStringValue(347, value);
      }
    }

    [FIXField("369", EFieldOption.Optional)]
    public int LastMsgSeqNumProcessed
    {
       get
      {
        return this.GetIntValue(369);
      }
       set
      {
        this.SetIntValue(369, value);
      }
    }

    [FIXField("627", EFieldOption.Optional)]
    public int NoHops
    {
       get
      {
        return this.GetIntValue(627);
      }
       set
      {
        this.SetIntValue(627, value);
      }
    }

    [FIXField("143", EFieldOption.Optional)]
    public string TargetLocationID
    {
       get
      {
        return this.GetStringValue(143);
      }
       set
      {
        this.SetStringValue(143, value);
      }
    }

    [FIXField("11", EFieldOption.Required)]
    public string ClOrdID
    {
       get
      {
        return this.GetStringValue(11);
      }
       set
      {
        this.SetStringValue(11, value);
      }
    }

    [FIXField("526", EFieldOption.Optional)]
    public string SecondaryClOrdID
    {
       get
      {
        return this.GetStringValue(526);
      }
       set
      {
        this.SetStringValue(526, value);
      }
    }

    [FIXField("583", EFieldOption.Optional)]
    public string ClOrdLinkID
    {
       get
      {
        return this.GetStringValue(583);
      }
       set
      {
        this.SetStringValue(583, value);
      }
    }

    [FIXField("453", EFieldOption.Optional)]
    public int NoPartyIDs
    {
       get
      {
        return this.GetIntValue(453);
      }
       set
      {
        this.SetIntValue(453, value);
      }
    }

    [FIXField("229", EFieldOption.Optional)]
    public DateTime TradeOriginationDate
    {
       get
      {
        return this.GetDateTimeValue(229);
      }
       set
      {
        this.SetDateTimeValue(229, value);
      }
    }

    [FIXField("75", EFieldOption.Optional)]
    public DateTime TradeDate
    {
       get
      {
        return this.GetDateTimeValue(75);
      }
       set
      {
        this.SetDateTimeValue(75, value);
      }
    }

    [FIXField("1", EFieldOption.Optional)]
    public string Account
    {
       get
      {
        return this.GetStringValue(1);
      }
       set
      {
        this.SetStringValue(1, value);
      }
    }

    [FIXField("660", EFieldOption.Optional)]
    public int AcctIDSource
    {
       get
      {
        return this.GetIntValue(660);
      }
       set
      {
        this.SetIntValue(660, value);
      }
    }

    [FIXField("581", EFieldOption.Optional)]
    public int AccountType
    {
       get
      {
        return this.GetIntValue(581);
      }
       set
      {
        this.SetIntValue(581, value);
      }
    }

    [FIXField("589", EFieldOption.Optional)]
    public char DayBookingInst
    {
       get
      {
        return this.GetCharValue(589);
      }
       set
      {
        this.SetCharValue(589, value);
      }
    }

    [FIXField("590", EFieldOption.Optional)]
    public char BookingUnit
    {
       get
      {
        return this.GetCharValue(590);
      }
       set
      {
        this.SetCharValue(590, value);
      }
    }

    [FIXField("591", EFieldOption.Optional)]
    public char PreallocMethod
    {
       get
      {
        return this.GetCharValue(591);
      }
       set
      {
        this.SetCharValue(591, value);
      }
    }

    [FIXField("70", EFieldOption.Optional)]
    public string AllocID
    {
       get
      {
        return this.GetStringValue(70);
      }
       set
      {
        this.SetStringValue(70, value);
      }
    }

    [FIXField("78", EFieldOption.Optional)]
    public int NoAllocs
    {
       get
      {
        return this.GetIntValue(78);
      }
       set
      {
        this.SetIntValue(78, value);
      }
    }

    [FIXField("63", EFieldOption.Optional)]
    public char SettlType
    {
       get
      {
        return this.GetCharValue(63);
      }
       set
      {
        this.SetCharValue(63, value);
      }
    }

    [FIXField("64", EFieldOption.Optional)]
    public DateTime SettlDate
    {
       get
      {
        return this.GetDateTimeValue(64);
      }
       set
      {
        this.SetDateTimeValue(64, value);
      }
    }

    [FIXField("544", EFieldOption.Optional)]
    public char CashMargin
    {
       get
      {
        return this.GetCharValue(544);
      }
       set
      {
        this.SetCharValue(544, value);
      }
    }

    [FIXField("635", EFieldOption.Optional)]
    public string ClearingFeeIndicator
    {
       get
      {
        return this.GetStringValue(635);
      }
       set
      {
        this.SetStringValue(635, value);
      }
    }

    [FIXField("21", EFieldOption.Optional)]
    public char HandlInst
    {
       get
      {
        return this.GetCharValue(21);
      }
       set
      {
        this.SetCharValue(21, value);
      }
    }

    [FIXField("18", EFieldOption.Optional)]
    public string ExecInst
    {
       get
      {
        return this.GetStringValue(18);
      }
       set
      {
        this.SetStringValue(18, value);
      }
    }

    [FIXField("110", EFieldOption.Optional)]
    public double MinQty
    {
       get
      {
        return this.GetDoubleValue(110);
      }
       set
      {
        this.SetDoubleValue(110, value);
      }
    }

    [FIXField("111", EFieldOption.Optional)]
    public double MaxFloor
    {
       get
      {
        return this.GetDoubleValue(111);
      }
       set
      {
        this.SetDoubleValue(111, value);
      }
    }

    [FIXField("100", EFieldOption.Optional)]
    public string ExDestination
    {
       get
      {
        return this.GetStringValue(100);
      }
       set
      {
        this.SetStringValue(100, value);
      }
    }

    [FIXField("386", EFieldOption.Optional)]
    public int NoTradingSessions
    {
       get
      {
        return this.GetIntValue(386);
      }
       set
      {
        this.SetIntValue(386, value);
      }
    }

    [FIXField("81", EFieldOption.Optional)]
    public char ProcessCode
    {
       get
      {
        return this.GetCharValue(81);
      }
       set
      {
        this.SetCharValue(81, value);
      }
    }

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
    public string SecurityIDSource
    {
       get
      {
        return this.GetStringValue(22);
      }
       set
      {
        this.SetStringValue(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
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
    public string CFICode
    {
       get
      {
        return this.GetStringValue(461);
      }
       set
      {
        this.SetStringValue(461, value);
      }
    }

    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
       get
      {
        return this.GetStringValue(167);
      }
       set
      {
        this.SetStringValue(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    public string SecuritySubType
    {
       get
      {
        return this.GetStringValue(762);
      }
       set
      {
        this.SetStringValue(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    public string MaturityMonthYear
    {
       get
      {
        return this.GetStringValue(200);
      }
       set
      {
        this.SetStringValue(200, value);
      }
    }

    [FIXField("541", EFieldOption.Optional)]
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

    [FIXField("224", EFieldOption.Optional)]
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

    [FIXField("225", EFieldOption.Optional)]
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

    [FIXField("255", EFieldOption.Optional)]
    public string CreditRating
    {
       get
      {
        return this.GetStringValue((int) byte.MaxValue);
      }
       set
      {
        this.SetStringValue((int) byte.MaxValue, value);
      }
    }

    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
       get
      {
        return this.GetStringValue(543);
      }
       set
      {
        this.SetStringValue(543, value);
      }
    }

    [FIXField("470", EFieldOption.Optional)]
    public string CountryOfIssue
    {
       get
      {
        return this.GetStringValue(470);
      }
       set
      {
        this.SetStringValue(470, value);
      }
    }

    [FIXField("471", EFieldOption.Optional)]
    public string StateOrProvinceOfIssue
    {
       get
      {
        return this.GetStringValue(471);
      }
       set
      {
        this.SetStringValue(471, value);
      }
    }

    [FIXField("472", EFieldOption.Optional)]
    public string LocaleOfIssue
    {
       get
      {
        return this.GetStringValue(472);
      }
       set
      {
        this.SetStringValue(472, value);
      }
    }

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

    [FIXField("947", EFieldOption.Optional)]
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
    public string SecurityExchange
    {
       get
      {
        return this.GetStringValue(207);
      }
       set
      {
        this.SetStringValue(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    public string Issuer
    {
       get
      {
        return this.GetStringValue(106);
      }
       set
      {
        this.SetStringValue(106, value);
      }
    }

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
    public string EncodedIssuer
    {
       get
      {
        return this.GetStringValue(349);
      }
       set
      {
        this.SetStringValue(349, value);
      }
    }

    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
       get
      {
        return this.GetStringValue(107);
      }
       set
      {
        this.SetStringValue(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
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
    public string EncodedSecurityDesc
    {
       get
      {
        return this.GetStringValue(351);
      }
       set
      {
        this.SetStringValue(351, value);
      }
    }

    [FIXField("691", EFieldOption.Optional)]
    public string Pool
    {
       get
      {
        return this.GetStringValue(691);
      }
       set
      {
        this.SetStringValue(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    public string ContractSettlMonth
    {
       get
      {
        return this.GetStringValue(667);
      }
       set
      {
        this.SetStringValue(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
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

    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
       get
      {
        return this.GetStringValue(876);
      }
       set
      {
        this.SetStringValue(876, value);
      }
    }

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

    [FIXField("913", EFieldOption.Optional)]
    public string AgreementDesc
    {
       get
      {
        return this.GetStringValue(913);
      }
       set
      {
        this.SetStringValue(913, value);
      }
    }

    [FIXField("914", EFieldOption.Optional)]
    public string AgreementID
    {
       get
      {
        return this.GetStringValue(914);
      }
       set
      {
        this.SetStringValue(914, value);
      }
    }

    [FIXField("915", EFieldOption.Optional)]
    public DateTime AgreementDate
    {
       get
      {
        return this.GetDateTimeValue(915);
      }
       set
      {
        this.SetDateTimeValue(915, value);
      }
    }

    [FIXField("918", EFieldOption.Optional)]
    public string AgreementCurrency
    {
       get
      {
        return this.GetStringValue(918);
      }
       set
      {
        this.SetStringValue(918, value);
      }
    }

    [FIXField("788", EFieldOption.Optional)]
    public int TerminationType
    {
       get
      {
        return this.GetIntValue(788);
      }
       set
      {
        this.SetIntValue(788, value);
      }
    }

    [FIXField("916", EFieldOption.Optional)]
    public DateTime StartDate
    {
       get
      {
        return this.GetDateTimeValue(916);
      }
       set
      {
        this.SetDateTimeValue(916, value);
      }
    }

    [FIXField("917", EFieldOption.Optional)]
    public DateTime EndDate
    {
       get
      {
        return this.GetDateTimeValue(917);
      }
       set
      {
        this.SetDateTimeValue(917, value);
      }
    }

    [FIXField("919", EFieldOption.Optional)]
    public int DeliveryType
    {
       get
      {
        return this.GetIntValue(919);
      }
       set
      {
        this.SetIntValue(919, value);
      }
    }

    [FIXField("898", EFieldOption.Optional)]
    public double MarginRatio
    {
       get
      {
        return this.GetDoubleValue(898);
      }
       set
      {
        this.SetDoubleValue(898, value);
      }
    }

    [FIXField("711", EFieldOption.Optional)]
    public int NoUnderlyings
    {
       get
      {
        return this.GetIntValue(711);
      }
       set
      {
        this.SetIntValue(711, value);
      }
    }

    [FIXField("140", EFieldOption.Optional)]
    public double PrevClosePx
    {
       get
      {
        return this.GetDoubleValue(140);
      }
       set
      {
        this.SetDoubleValue(140, value);
      }
    }

    [FIXField("54", EFieldOption.Required)]
    public char Side
    {
       get
      {
        return this.GetCharValue(54);
      }
       set
      {
        this.SetCharValue(54, value);
      }
    }

    [FIXField("114", EFieldOption.Optional)]
    public bool LocateReqd
    {
       get
      {
        return this.GetBoolValue(114);
      }
       set
      {
        this.SetBoolValue(114, value);
      }
    }

    [FIXField("60", EFieldOption.Required)]
    public DateTime TransactTime
    {
       get
      {
        return this.GetDateTimeValue(60);
      }
       set
      {
        this.SetDateTimeValue(60, value);
      }
    }

    [FIXField("232", EFieldOption.Optional)]
    public int NoStipulations
    {
       get
      {
        return this.GetIntValue(232);
      }
       set
      {
        this.SetIntValue(232, value);
      }
    }

    [FIXField("854", EFieldOption.Optional)]
    public int QtyType
    {
       get
      {
        return this.GetIntValue(854);
      }
       set
      {
        this.SetIntValue(854, value);
      }
    }

    [FIXField("38", EFieldOption.Optional)]
    public double OrderQty
    {
       get
      {
        return this.GetDoubleValue(38);
      }
       set
      {
        this.SetDoubleValue(38, value);
      }
    }

    [FIXField("152", EFieldOption.Optional)]
    public double CashOrderQty
    {
       get
      {
        return this.GetDoubleValue(152);
      }
       set
      {
        this.SetDoubleValue(152, value);
      }
    }

    [FIXField("516", EFieldOption.Optional)]
    public double OrderPercent
    {
       get
      {
        return this.GetDoubleValue(516);
      }
       set
      {
        this.SetDoubleValue(516, value);
      }
    }

    [FIXField("468", EFieldOption.Optional)]
    public char RoundingDirection
    {
       get
      {
        return this.GetCharValue(468);
      }
       set
      {
        this.SetCharValue(468, value);
      }
    }

    [FIXField("469", EFieldOption.Optional)]
    public double RoundingModulus
    {
       get
      {
        return this.GetDoubleValue(469);
      }
       set
      {
        this.SetDoubleValue(469, value);
      }
    }

    [FIXField("40", EFieldOption.Required)]
    public char OrdType
    {
       get
      {
        return this.GetCharValue(40);
      }
       set
      {
        this.SetCharValue(40, value);
      }
    }

    [FIXField("423", EFieldOption.Optional)]
    public int PriceType
    {
       get
      {
        return this.GetIntValue(423);
      }
       set
      {
        this.SetIntValue(423, value);
      }
    }

    [FIXField("44", EFieldOption.Optional)]
    public double Price
    {
       get
      {
        return this.GetDoubleValue(44);
      }
       set
      {
        this.SetDoubleValue(44, value);
      }
    }

    [FIXField("99", EFieldOption.Optional)]
    public double StopPx
    {
       get
      {
        return this.GetDoubleValue(99);
      }
       set
      {
        this.SetDoubleValue(99, value);
      }
    }

    [FIXField("218", EFieldOption.Optional)]
    public double Spread
    {
       get
      {
        return this.GetDoubleValue(218);
      }
       set
      {
        this.SetDoubleValue(218, value);
      }
    }

    [FIXField("220", EFieldOption.Optional)]
    public string BenchmarkCurveCurrency
    {
       get
      {
        return this.GetStringValue(220);
      }
       set
      {
        this.SetStringValue(220, value);
      }
    }

    [FIXField("221", EFieldOption.Optional)]
    public string BenchmarkCurveName
    {
       get
      {
        return this.GetStringValue(221);
      }
       set
      {
        this.SetStringValue(221, value);
      }
    }

    [FIXField("222", EFieldOption.Optional)]
    public string BenchmarkCurvePoint
    {
       get
      {
        return this.GetStringValue(222);
      }
       set
      {
        this.SetStringValue(222, value);
      }
    }

    [FIXField("662", EFieldOption.Optional)]
    public double BenchmarkPrice
    {
       get
      {
        return this.GetDoubleValue(662);
      }
       set
      {
        this.SetDoubleValue(662, value);
      }
    }

    [FIXField("663", EFieldOption.Optional)]
    public int BenchmarkPriceType
    {
       get
      {
        return this.GetIntValue(663);
      }
       set
      {
        this.SetIntValue(663, value);
      }
    }

    [FIXField("699", EFieldOption.Optional)]
    public string BenchmarkSecurityID
    {
       get
      {
        return this.GetStringValue(699);
      }
       set
      {
        this.SetStringValue(699, value);
      }
    }

    [FIXField("761", EFieldOption.Optional)]
    public string BenchmarkSecurityIDSource
    {
       get
      {
        return this.GetStringValue(761);
      }
       set
      {
        this.SetStringValue(761, value);
      }
    }

    [FIXField("235", EFieldOption.Optional)]
    public string YieldType
    {
       get
      {
        return this.GetStringValue(235);
      }
       set
      {
        this.SetStringValue(235, value);
      }
    }

    [FIXField("236", EFieldOption.Optional)]
    public double Yield
    {
       get
      {
        return this.GetDoubleValue(236);
      }
       set
      {
        this.SetDoubleValue(236, value);
      }
    }

    [FIXField("701", EFieldOption.Optional)]
    public DateTime YieldCalcDate
    {
       get
      {
        return this.GetDateTimeValue(701);
      }
       set
      {
        this.SetDateTimeValue(701, value);
      }
    }

    [FIXField("696", EFieldOption.Optional)]
    public DateTime YieldRedemptionDate
    {
       get
      {
        return this.GetDateTimeValue(696);
      }
       set
      {
        this.SetDateTimeValue(696, value);
      }
    }

    [FIXField("697", EFieldOption.Optional)]
    public double YieldRedemptionPrice
    {
       get
      {
        return this.GetDoubleValue(697);
      }
       set
      {
        this.SetDoubleValue(697, value);
      }
    }

    [FIXField("698", EFieldOption.Optional)]
    public int YieldRedemptionPriceType
    {
       get
      {
        return this.GetIntValue(698);
      }
       set
      {
        this.SetIntValue(698, value);
      }
    }

    [FIXField("15", EFieldOption.Optional)]
    public string Currency
    {
       get
      {
        return this.GetStringValue(15);
      }
       set
      {
        this.SetStringValue(15, value);
      }
    }

    [FIXField("376", EFieldOption.Optional)]
    public string ComplianceID
    {
       get
      {
        return this.GetStringValue(376);
      }
       set
      {
        this.SetStringValue(376, value);
      }
    }

    [FIXField("377", EFieldOption.Optional)]
    public bool SolicitedFlag
    {
       get
      {
        return this.GetBoolValue(377);
      }
       set
      {
        this.SetBoolValue(377, value);
      }
    }

    [FIXField("23", EFieldOption.Optional)]
    public string IOIID
    {
       get
      {
        return this.GetStringValue(23);
      }
       set
      {
        this.SetStringValue(23, value);
      }
    }

    [FIXField("117", EFieldOption.Optional)]
    public string QuoteID
    {
       get
      {
        return this.GetStringValue(117);
      }
       set
      {
        this.SetStringValue(117, value);
      }
    }

    [FIXField("59", EFieldOption.Optional)]
    public char TimeInForce
    {
       get
      {
        return this.GetCharValue(59);
      }
       set
      {
        this.SetCharValue(59, value);
      }
    }

    [FIXField("168", EFieldOption.Optional)]
    public DateTime EffectiveTime
    {
       get
      {
        return this.GetDateTimeValue(168);
      }
       set
      {
        this.SetDateTimeValue(168, value);
      }
    }

    [FIXField("432", EFieldOption.Optional)]
    public DateTime ExpireDate
    {
       get
      {
        return this.GetDateTimeValue(432);
      }
       set
      {
        this.SetDateTimeValue(432, value);
      }
    }

    [FIXField("126", EFieldOption.Optional)]
    public DateTime ExpireTime
    {
       get
      {
        return this.GetDateTimeValue(126);
      }
       set
      {
        this.SetDateTimeValue(126, value);
      }
    }

    [FIXField("427", EFieldOption.Optional)]
    public int GTBookingInst
    {
       get
      {
        return this.GetIntValue(427);
      }
       set
      {
        this.SetIntValue(427, value);
      }
    }

    [FIXField("12", EFieldOption.Optional)]
    public double Commission
    {
       get
      {
        return this.GetDoubleValue(12);
      }
       set
      {
        this.SetDoubleValue(12, value);
      }
    }

    [FIXField("13", EFieldOption.Optional)]
    public char CommType
    {
       get
      {
        return this.GetCharValue(13);
      }
       set
      {
        this.SetCharValue(13, value);
      }
    }

    [FIXField("479", EFieldOption.Optional)]
    public string CommCurrency
    {
       get
      {
        return this.GetStringValue(479);
      }
       set
      {
        this.SetStringValue(479, value);
      }
    }

    [FIXField("497", EFieldOption.Optional)]
    public char FundRenewWaiv
    {
       get
      {
        return this.GetCharValue(497);
      }
       set
      {
        this.SetCharValue(497, value);
      }
    }

    [FIXField("47", EFieldOption.Optional)]
    public char Rule80A
    {
       get
      {
        return this.GetCharValue(47);
      }
       set
      {
        this.SetCharValue(47, value);
      }
    }

    [FIXField("528", EFieldOption.Optional)]
    public char OrderCapacity
    {
       get
      {
        return this.GetCharValue(528);
      }
       set
      {
        this.SetCharValue(528, value);
      }
    }

    [FIXField("204", EFieldOption.Optional)]
    public int CustomerOrFirm
    {
       get
      {
        return this.GetIntValue(204);
      }
       set
      {
        this.SetIntValue(204, value);
      }
    }

    [FIXField("529", EFieldOption.Optional)]
    public string OrderRestrictions
    {
       get
      {
        return this.GetStringValue(529);
      }
       set
      {
        this.SetStringValue(529, value);
      }
    }

    [FIXField("582", EFieldOption.Optional)]
    public int CustOrderCapacity
    {
       get
      {
        return this.GetIntValue(582);
      }
       set
      {
        this.SetIntValue(582, value);
      }
    }

    [FIXField("121", EFieldOption.Optional)]
    public bool ForexReq
    {
       get
      {
        return this.GetBoolValue(121);
      }
       set
      {
        this.SetBoolValue(121, value);
      }
    }

    [FIXField("120", EFieldOption.Optional)]
    public string SettlCurrency
    {
       get
      {
        return this.GetStringValue(120);
      }
       set
      {
        this.SetStringValue(120, value);
      }
    }

    [FIXField("775", EFieldOption.Optional)]
    public int BookingType
    {
       get
      {
        return this.GetIntValue(775);
      }
       set
      {
        this.SetIntValue(775, value);
      }
    }

    [FIXField("58", EFieldOption.Optional)]
    public string Text
    {
       get
      {
        return this.GetStringValue(58);
      }
       set
      {
        this.SetStringValue(58, value);
      }
    }

    [FIXField("354", EFieldOption.Optional)]
    public int EncodedTextLen
    {
       get
      {
        return this.GetIntValue(354);
      }
       set
      {
        this.SetIntValue(354, value);
      }
    }

    [FIXField("355", EFieldOption.Optional)]
    public string EncodedText
    {
       get
      {
        return this.GetStringValue(355);
      }
       set
      {
        this.SetStringValue(355, value);
      }
    }

    [FIXField("193", EFieldOption.Optional)]
    public DateTime SettlDate2
    {
       get
      {
        return this.GetDateTimeValue(193);
      }
       set
      {
        this.SetDateTimeValue(193, value);
      }
    }

    [FIXField("192", EFieldOption.Optional)]
    public double OrderQty2
    {
       get
      {
        return this.GetDoubleValue(192);
      }
       set
      {
        this.SetDoubleValue(192, value);
      }
    }

    [FIXField("640", EFieldOption.Optional)]
    public double Price2
    {
       get
      {
        return this.GetDoubleValue(640);
      }
       set
      {
        this.SetDoubleValue(640, value);
      }
    }

    [FIXField("77", EFieldOption.Optional)]
    public char PositionEffect
    {
       get
      {
        return this.GetCharValue(77);
      }
       set
      {
        this.SetCharValue(77, value);
      }
    }

    [FIXField("203", EFieldOption.Optional)]
    public int CoveredOrUncovered
    {
       get
      {
        return this.GetIntValue(203);
      }
       set
      {
        this.SetIntValue(203, value);
      }
    }

    [FIXField("210", EFieldOption.Optional)]
    public double MaxShow
    {
       get
      {
        return this.GetDoubleValue(210);
      }
       set
      {
        this.SetDoubleValue(210, value);
      }
    }

    [FIXField("211", EFieldOption.Optional)]
    public double PegOffsetValue
    {
       get
      {
        return this.GetDoubleValue(211);
      }
       set
      {
        this.SetDoubleValue(211, value);
      }
    }

    [FIXField("835", EFieldOption.Optional)]
    public int PegMoveType
    {
       get
      {
        return this.GetIntValue(835);
      }
       set
      {
        this.SetIntValue(835, value);
      }
    }

    [FIXField("836", EFieldOption.Optional)]
    public int PegOffsetType
    {
       get
      {
        return this.GetIntValue(836);
      }
       set
      {
        this.SetIntValue(836, value);
      }
    }

    [FIXField("837", EFieldOption.Optional)]
    public int PegLimitType
    {
       get
      {
        return this.GetIntValue(837);
      }
       set
      {
        this.SetIntValue(837, value);
      }
    }

    [FIXField("838", EFieldOption.Optional)]
    public int PegRoundDirection
    {
       get
      {
        return this.GetIntValue(838);
      }
       set
      {
        this.SetIntValue(838, value);
      }
    }

    [FIXField("840", EFieldOption.Optional)]
    public int PegScope
    {
       get
      {
        return this.GetIntValue(840);
      }
       set
      {
        this.SetIntValue(840, value);
      }
    }

    [FIXField("388", EFieldOption.Optional)]
    public char DiscretionInst
    {
       get
      {
        return this.GetCharValue(388);
      }
       set
      {
        this.SetCharValue(388, value);
      }
    }

    [FIXField("389", EFieldOption.Optional)]
    public double DiscretionOffsetValue
    {
       get
      {
        return this.GetDoubleValue(389);
      }
       set
      {
        this.SetDoubleValue(389, value);
      }
    }

    [FIXField("841", EFieldOption.Optional)]
    public int DiscretionMoveType
    {
       get
      {
        return this.GetIntValue(841);
      }
       set
      {
        this.SetIntValue(841, value);
      }
    }

    [FIXField("842", EFieldOption.Optional)]
    public int DiscretionOffsetType
    {
       get
      {
        return this.GetIntValue(842);
      }
       set
      {
        this.SetIntValue(842, value);
      }
    }

    [FIXField("843", EFieldOption.Optional)]
    public int DiscretionLimitType
    {
       get
      {
        return this.GetIntValue(843);
      }
       set
      {
        this.SetIntValue(843, value);
      }
    }

    [FIXField("844", EFieldOption.Optional)]
    public int DiscretionRoundDirection
    {
       get
      {
        return this.GetIntValue(844);
      }
       set
      {
        this.SetIntValue(844, value);
      }
    }

    [FIXField("846", EFieldOption.Optional)]
    public int DiscretionScope
    {
       get
      {
        return this.GetIntValue(846);
      }
       set
      {
        this.SetIntValue(846, value);
      }
    }

    [FIXField("847", EFieldOption.Optional)]
    public int TargetStrategy
    {
       get
      {
        return this.GetIntValue(847);
      }
       set
      {
        this.SetIntValue(847, value);
      }
    }

    [FIXField("848", EFieldOption.Optional)]
    public string TargetStrategyParameters
    {
       get
      {
        return this.GetStringValue(848);
      }
       set
      {
        this.SetStringValue(848, value);
      }
    }

    [FIXField("849", EFieldOption.Optional)]
    public double ParticipationRate
    {
       get
      {
        return this.GetDoubleValue(849);
      }
       set
      {
        this.SetDoubleValue(849, value);
      }
    }

    [FIXField("480", EFieldOption.Optional)]
    public char CancellationRights
    {
       get
      {
        return this.GetCharValue(480);
      }
       set
      {
        this.SetCharValue(480, value);
      }
    }

    [FIXField("481", EFieldOption.Optional)]
    public char MoneyLaunderingStatus
    {
       get
      {
        return this.GetCharValue(481);
      }
       set
      {
        this.SetCharValue(481, value);
      }
    }

    [FIXField("513", EFieldOption.Optional)]
    public string RegistID
    {
       get
      {
        return this.GetStringValue(513);
      }
       set
      {
        this.SetStringValue(513, value);
      }
    }

    [FIXField("494", EFieldOption.Optional)]
    public string Designation
    {
       get
      {
        return this.GetStringValue(494);
      }
       set
      {
        this.SetStringValue(494, value);
      }
    }

    [FIXField("440", EFieldOption.Optional)]
    public string ClearingAccount
    {
       get
      {
        return this.GetStringValue(440);
      }
       set
      {
        this.SetStringValue(440, value);
      }
    }

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

    public string OCAGroup
    {
       get
      {
        return this.GetStringValue(10500);
      }
       set
      {
        this.SetStringValue(10500, value);
      }
    }

    public bool Hidden
    {
       get
      {
        return this.GetBoolValue(10700);
      }
       set
      {
        this.SetBoolValue(10700, value);
      }
    }

    public double TrailingAmt
    {
       get
      {
        return this.GetDoubleValue(10701);
      }
       set
      {
        this.SetDoubleValue(10701, value);
      }
    }

    public double DisplaySize
    {
       get
      {
        return this.GetDoubleValue(10702);
      }
       set
      {
        this.SetDoubleValue(10702, value);
      }
    }

    public string FaMethod
    {
       get
      {
        return this.GetStringValue(10710);
      }
       set
      {
        this.SetStringValue(10710, value);
      }
    }

    public string FaGroup
    {
       get
      {
        return this.GetStringValue(10711);
      }
       set
      {
        this.SetStringValue(10711, value);
      }
    }

    public string FaProfile
    {
       get
      {
        return this.GetStringValue(10712);
      }
       set
      {
        this.SetStringValue(10712, value);
      }
    }

    public double FaPercentage
    {
       get
      {
        return this.GetDoubleValue(10713);
      }
       set
      {
        this.SetDoubleValue(10713, value);
      }
    }

    public string OrderRef
    {
       get
      {
        return this.GetStringValue(10714);
      }
       set
      {
        this.SetStringValue(10714, value);
      }
    }

    public int ExpireSeconds
    {
       get
      {
        return this.GetIntValue(7558);
      }
       set
      {
        this.SetIntValue(7558, value);
      }
    }

    public int Route
    {
       get
      {
        return this.GetIntValue(10900);
      }
       set
      {
        this.SetIntValue(10900, value);
      }
    }

    public int TradeVolumeDelay
    {
       get
      {
        return this.GetIntValue(11000);
      }
       set
      {
        this.SetIntValue(11000, value);
      }
    }

    [FIXField("10", EFieldOption.Required)]
    public string CheckSum
    {
       get
      {
        return this.GetStringValue(10);
      }
       set
      {
        this.SetStringValue(10, value);
      }
    }

    [FIXField("89", EFieldOption.Optional)]
    public string Signature
    {
       get
      {
        return this.GetStringValue(89);
      }
       set
      {
        this.SetStringValue(89, value);
      }
    }

    [FIXField("93", EFieldOption.Optional)]
    public int SignatureLength
    {
       get
      {
        return this.GetIntValue(93);
      }
       set
      {
        this.SetIntValue(93, value);
      }
    }

    
    public FIXNewOrderSingle():base()
    {
      this.Gk8YDuogVw = new ArrayList();
      this.mi3YPSTqEN = new ArrayList();
      this.kb9YIAFtAE = new ArrayList();
      this.D4iYHLFQdE = new ArrayList();
      this.sxeYW3t0BM = new ArrayList();
      this.jCaYTX9fmk = new ArrayList();
      this.SgbYVisdm5 = new ArrayList();
      this.AxxYmvV7Zg = new ArrayList();
      this.q6GYkjkFaA = new ArrayList();
    }

    
    public FIXNewOrderSingle(string ClOrdID, char Side, DateTime TransactTime, char OrdType):base()
    {
      this.Gk8YDuogVw = new ArrayList();
      this.mi3YPSTqEN = new ArrayList();
      this.kb9YIAFtAE = new ArrayList();
      this.D4iYHLFQdE = new ArrayList();
      this.sxeYW3t0BM = new ArrayList();
      this.jCaYTX9fmk = new ArrayList();
      this.SgbYVisdm5 = new ArrayList();
      this.AxxYmvV7Zg = new ArrayList();
      this.q6GYkjkFaA = new ArrayList();
      this.ClOrdID = ClOrdID;
      this.Side = Side;
      this.TransactTime = TransactTime;
      this.OrdType = OrdType;
    }

    
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.Gk8YDuogVw[i];
    }

    
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.Gk8YDuogVw.Add((object) group);
    }

    
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.mi3YPSTqEN[i];
      else
        return (FIXHopsGroup) null;
    }

    
    public void AddGroup(FIXHopsGroup group)
    {
      this.mi3YPSTqEN.Add((object) group);
      ++this.NoHops;
    }

    
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.kb9YIAFtAE[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.kb9YIAFtAE.Add((object) group);
      ++this.NoPartyIDs;
    }

    
    public FIXAllocsGroup GetAllocsGroup(int i)
    {
      if (i < this.NoAllocs)
        return (FIXAllocsGroup) this.D4iYHLFQdE[i];
      else
        return (FIXAllocsGroup) null;
    }

    
    public void AddGroup(FIXAllocsGroup group)
    {
      this.D4iYHLFQdE.Add((object) group);
      ++this.NoAllocs;
    }

    
    public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
    {
      if (i < this.NoTradingSessions)
        return (FIXTradingSessionsGroup) this.sxeYW3t0BM[i];
      else
        return (FIXTradingSessionsGroup) null;
    }

    
    public void AddGroup(FIXTradingSessionsGroup group)
    {
      this.sxeYW3t0BM.Add((object) group);
      ++this.NoTradingSessions;
    }

    
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.jCaYTX9fmk[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.jCaYTX9fmk.Add((object) group);
      ++this.NoSecurityAltID;
    }

    
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.SgbYVisdm5[i];
      else
        return (FIXEventsGroup) null;
    }

    
    public void AddGroup(FIXEventsGroup group)
    {
      this.SgbYVisdm5.Add((object) group);
      ++this.NoEvents;
    }

    
    public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
    {
      if (i < this.NoUnderlyings)
        return (FIXUnderlyingsGroup) this.AxxYmvV7Zg[i];
      else
        return (FIXUnderlyingsGroup) null;
    }

    
    public void AddGroup(FIXUnderlyingsGroup group)
    {
      this.AxxYmvV7Zg.Add((object) group);
      ++this.NoUnderlyings;
    }

    
    public FIXStipulationsGroup GetStipulationsGroup(int i)
    {
      if (i < this.NoStipulations)
        return (FIXStipulationsGroup) this.q6GYkjkFaA[i];
      else
        return (FIXStipulationsGroup) null;
    }

    
    public void AddGroup(FIXStipulationsGroup group)
    {
      this.q6GYkjkFaA.Add((object) group);
      ++this.NoStipulations;
    }
  }
}
