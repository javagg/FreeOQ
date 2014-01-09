using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderCancelReplaceRequest : FIXMessage
  {
    private ArrayList zNXxaM6Xu;
    private ArrayList qP155eNm9;
    private ArrayList THJgABKWo;
    private ArrayList dYTohKwg6;
    private ArrayList T6ARrjHiK;
    private ArrayList H1Q4SNW22;
    private ArrayList TosenlNhM;
    private ArrayList ilEGkYXNu;

    [FIXField("144", EFieldOption.Optional)]
    public string OnBehalfOfLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(144);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(144, value);
      }
    }

    [FIXField("9", EFieldOption.Required)]
    public int BodyLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(9);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(9, value);
      }
    }

    [FIXField("35", EFieldOption.Required)]
    public string MsgType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(35);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(35, value);
      }
    }

    [FIXField("49", EFieldOption.Required)]
    public string SenderCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(49);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(49, value);
      }
    }

    [FIXField("56", EFieldOption.Required)]
    public string TargetCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(56);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(56, value);
      }
    }

    [FIXField("115", EFieldOption.Optional)]
    public string OnBehalfOfCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(115);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(115, value);
      }
    }

    [FIXField("128", EFieldOption.Optional)]
    public string DeliverToCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(128);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(128, value);
      }
    }

    [FIXField("90", EFieldOption.Optional)]
    public int SecureDataLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(90);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(90, value);
      }
    }

    [FIXField("91", EFieldOption.Optional)]
    public string SecureData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(91);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(91, value);
      }
    }

    [FIXField("34", EFieldOption.Required)]
    public int MsgSeqNum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(34);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(34, value);
      }
    }

    [FIXField("50", EFieldOption.Optional)]
    public string SenderSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(50);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(50, value);
      }
    }

    [FIXField("142", EFieldOption.Optional)]
    public string SenderLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(142);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(142, value);
      }
    }

    [FIXField("57", EFieldOption.Optional)]
    public string TargetSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(57);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(57, value);
      }
    }

    [FIXField("8", EFieldOption.Required)]
    public string BeginString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(8);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(8, value);
      }
    }

    [FIXField("116", EFieldOption.Optional)]
    public string OnBehalfOfSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(116);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(116, value);
      }
    }

    [FIXField("129", EFieldOption.Optional)]
    public string DeliverToSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(129);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(129, value);
      }
    }

    [FIXField("145", EFieldOption.Optional)]
    public string DeliverToLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(145);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(145, value);
      }
    }

    [FIXField("43", EFieldOption.Optional)]
    public bool PossDupFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(43);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(43, value);
      }
    }

    [FIXField("97", EFieldOption.Optional)]
    public bool PossResend
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(97);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(97, value);
      }
    }

    [FIXField("52", EFieldOption.Optional)]
    public DateTime SendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(52);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(52, value);
      }
    }

    [FIXField("122", EFieldOption.Optional)]
    public DateTime OrigSendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(122);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(122, value);
      }
    }

    [FIXField("212", EFieldOption.Optional)]
    public int XmlDataLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(212);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(212, value);
      }
    }

    [FIXField("213", EFieldOption.Optional)]
    public string XmlData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(213);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(213, value);
      }
    }

    [FIXField("347", EFieldOption.Optional)]
    public string MessageEncoding
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(347);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(347, value);
      }
    }

    [FIXField("369", EFieldOption.Optional)]
    public int LastMsgSeqNumProcessed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(369);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(369, value);
      }
    }

    [FIXField("627", EFieldOption.Optional)]
    public int NoHops
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(627);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(627, value);
      }
    }

    [FIXField("143", EFieldOption.Optional)]
    public string TargetLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(143);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(143, value);
      }
    }

    [FIXField("37", EFieldOption.Optional)]
    public string OrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(37);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(37, value);
      }
    }

    [FIXField("453", EFieldOption.Optional)]
    public int NoPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(453);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(453, value);
      }
    }

    [FIXField("229", EFieldOption.Optional)]
    public DateTime TradeOriginationDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(229);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(229, value);
      }
    }

    [FIXField("75", EFieldOption.Optional)]
    public DateTime TradeDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(75);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(75, value);
      }
    }

    [FIXField("41", EFieldOption.Required)]
    public string OrigClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(41);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(41, value);
      }
    }

    [FIXField("11", EFieldOption.Required)]
    public string ClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(11);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(11, value);
      }
    }

    [FIXField("526", EFieldOption.Optional)]
    public string SecondaryClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(526);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(526, value);
      }
    }

    [FIXField("583", EFieldOption.Optional)]
    public string ClOrdLinkID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(583);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(583, value);
      }
    }

    [FIXField("66", EFieldOption.Optional)]
    public string ListID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(66);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(66, value);
      }
    }

    [FIXField("586", EFieldOption.Optional)]
    public DateTime OrigOrdModTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(586);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(586, value);
      }
    }

    [FIXField("1", EFieldOption.Optional)]
    public string Account
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(1);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(1, value);
      }
    }

    [FIXField("660", EFieldOption.Optional)]
    public int AcctIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(660);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(660, value);
      }
    }

    [FIXField("581", EFieldOption.Optional)]
    public int AccountType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(581);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(581, value);
      }
    }

    [FIXField("589", EFieldOption.Optional)]
    public char DayBookingInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(589);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(589, value);
      }
    }

    [FIXField("590", EFieldOption.Optional)]
    public char BookingUnit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(590);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(590, value);
      }
    }

    [FIXField("591", EFieldOption.Optional)]
    public char PreallocMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(591);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(591, value);
      }
    }

    [FIXField("70", EFieldOption.Optional)]
    public string AllocID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(70);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(70, value);
      }
    }

    [FIXField("78", EFieldOption.Optional)]
    public int NoAllocs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(78);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(78, value);
      }
    }

    [FIXField("63", EFieldOption.Optional)]
    public char SettlType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(63);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(63, value);
      }
    }

    [FIXField("64", EFieldOption.Optional)]
    public DateTime SettlDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(64);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(64, value);
      }
    }

    [FIXField("544", EFieldOption.Optional)]
    public char CashMargin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(544);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(544, value);
      }
    }

    [FIXField("635", EFieldOption.Optional)]
    public string ClearingFeeIndicator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(635);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(635, value);
      }
    }

    [FIXField("21", EFieldOption.Optional)]
    public char HandlInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(21);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(21, value);
      }
    }

    [FIXField("18", EFieldOption.Optional)]
    public string ExecInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(18);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(18, value);
      }
    }

    [FIXField("110", EFieldOption.Optional)]
    public double MinQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(110);
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
        return this.GetDoubleValue(111);
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
        return this.GetStringValue(100);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(100, value);
      }
    }

    [FIXField("386", EFieldOption.Optional)]
    public int NoTradingSessions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(386);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(386, value);
      }
    }

    [FIXField("55", EFieldOption.Optional)]
    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(55);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(55, value);
      }
    }

    [FIXField("65", EFieldOption.Optional)]
    public string SymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(65);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(65, value);
      }
    }

    [FIXField("48", EFieldOption.Optional)]
    public string SecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(48);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(48, value);
      }
    }

    [FIXField("22", EFieldOption.Optional)]
    public string SecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(22);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
    public int NoSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(454);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(454, value);
      }
    }

    [FIXField("460", EFieldOption.Optional)]
    public int Product
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(460);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(460, value);
      }
    }

    [FIXField("461", EFieldOption.Optional)]
    public string CFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(461);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(461, value);
      }
    }

    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(167);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    public string SecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(762);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    public string MaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(200);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(200, value);
      }
    }

    [FIXField("541", EFieldOption.Optional)]
    public DateTime MaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(541);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(541, value);
      }
    }

    [FIXField("224", EFieldOption.Optional)]
    public DateTime CouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(224);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(224, value);
      }
    }

    [FIXField("225", EFieldOption.Optional)]
    public DateTime IssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(225);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(225, value);
      }
    }

    [FIXField("239", EFieldOption.Optional)]
    public int RepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(239);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(239, value);
      }
    }

    [FIXField("226", EFieldOption.Optional)]
    public int RepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(226);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(226, value);
      }
    }

    [FIXField("227", EFieldOption.Optional)]
    public double RepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(227);
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
        return this.GetDoubleValue(228);
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
        return this.GetStringValue((int) byte.MaxValue);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue((int) byte.MaxValue, value);
      }
    }

    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(543);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(543, value);
      }
    }

    [FIXField("470", EFieldOption.Optional)]
    public string CountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(470);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(470, value);
      }
    }

    [FIXField("471", EFieldOption.Optional)]
    public string StateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(471);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(471, value);
      }
    }

    [FIXField("472", EFieldOption.Optional)]
    public string LocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(472);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(472, value);
      }
    }

    [FIXField("240", EFieldOption.Optional)]
    public DateTime RedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(240);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(240, value);
      }
    }

    [FIXField("202", EFieldOption.Optional)]
    public double StrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(202);
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
        return this.GetDoubleValue(947);
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
        return this.GetCharValue(206);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(206, value);
      }
    }

    [FIXField("231", EFieldOption.Optional)]
    public double ContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(231);
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
        return this.GetDoubleValue(223);
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
        return this.GetStringValue(207);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    public string Issuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(106);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(106, value);
      }
    }

    [FIXField("348", EFieldOption.Optional)]
    public int EncodedIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(348);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(348, value);
      }
    }

    [FIXField("349", EFieldOption.Optional)]
    public string EncodedIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(349);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(349, value);
      }
    }

    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(107);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
    public int EncodedSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(350);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(350, value);
      }
    }

    [FIXField("351", EFieldOption.Optional)]
    public string EncodedSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(351);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(351, value);
      }
    }

    [FIXField("691", EFieldOption.Optional)]
    public string Pool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(691);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    public string ContractSettlMonth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(667);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
    public int CPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(875);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(875, value);
      }
    }

    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(876);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(876, value);
      }
    }

    [FIXField("864", EFieldOption.Optional)]
    public int NoEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(864);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(864, value);
      }
    }

    [FIXField("873", EFieldOption.Optional)]
    public DateTime DatedDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(873);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(873, value);
      }
    }

    [FIXField("874", EFieldOption.Optional)]
    public DateTime InterestAccrualDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(874);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(874, value);
      }
    }

    [FIXField("913", EFieldOption.Optional)]
    public string AgreementDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(913);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(913, value);
      }
    }

    [FIXField("914", EFieldOption.Optional)]
    public string AgreementID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(914);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(914, value);
      }
    }

    [FIXField("915", EFieldOption.Optional)]
    public DateTime AgreementDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(915);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(915, value);
      }
    }

    [FIXField("918", EFieldOption.Optional)]
    public double AgreementCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(918);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(918, value);
      }
    }

    [FIXField("788", EFieldOption.Optional)]
    public int TerminationType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(788);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(788, value);
      }
    }

    [FIXField("916", EFieldOption.Optional)]
    public DateTime StartDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(916);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(916, value);
      }
    }

    [FIXField("917", EFieldOption.Optional)]
    public DateTime EndDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(917);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(917, value);
      }
    }

    [FIXField("919", EFieldOption.Optional)]
    public int DeliveryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(919);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(919, value);
      }
    }

    [FIXField("898", EFieldOption.Optional)]
    public double MarginRatio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(898);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(898, value);
      }
    }

    [FIXField("711", EFieldOption.Optional)]
    public int NoUnderlyings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(711);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(711, value);
      }
    }

    [FIXField("54", EFieldOption.Required)]
    public char Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(54);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(54, value);
      }
    }

    [FIXField("60", EFieldOption.Required)]
    public DateTime TransactTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(60);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(60, value);
      }
    }

    [FIXField("854", EFieldOption.Optional)]
    public int QtyType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(854);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(854, value);
      }
    }

    [FIXField("38", EFieldOption.Optional)]
    public double OrderQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(38);
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
        return this.GetDoubleValue(152);
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
        return this.GetDoubleValue(516);
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
        return this.GetCharValue(468);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(468, value);
      }
    }

    [FIXField("469", EFieldOption.Optional)]
    public double RoundingModulus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(469);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(469, value);
      }
    }

    [FIXField("40", EFieldOption.Required)]
    public char OrdType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(40);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(40, value);
      }
    }

    [FIXField("423", EFieldOption.Optional)]
    public int PriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(423);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(423, value);
      }
    }

    [FIXField("44", EFieldOption.Optional)]
    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(44);
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
        return this.GetDoubleValue(99);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(99, value);
      }
    }

    public double TrailingAmt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10701);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10701, value);
      }
    }

    [FIXField("218", EFieldOption.Optional)]
    public double Spread
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(218);
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
        return this.GetDoubleValue(220);
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
        return this.GetStringValue(221);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(221, value);
      }
    }

    [FIXField("222", EFieldOption.Optional)]
    public string BenchmarkCurvePoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(222);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(222, value);
      }
    }

    [FIXField("662", EFieldOption.Optional)]
    public double BenchmarkPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(662);
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
        return this.GetIntValue(663);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(663, value);
      }
    }

    [FIXField("699", EFieldOption.Optional)]
    public string BenchmarkSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(699);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(699, value);
      }
    }

    [FIXField("761", EFieldOption.Optional)]
    public string BenchmarkSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(761);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(761, value);
      }
    }

    [FIXField("235", EFieldOption.Optional)]
    public string YieldType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(235);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(235, value);
      }
    }

    [FIXField("236", EFieldOption.Optional)]
    public double Yield
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(236);
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
        return this.GetDateTimeValue(701);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(701, value);
      }
    }

    [FIXField("696", EFieldOption.Optional)]
    public DateTime YieldRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(696);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(696, value);
      }
    }

    [FIXField("697", EFieldOption.Optional)]
    public double YieldRedemptionPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(697);
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
        return this.GetIntValue(698);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(698, value);
      }
    }

    [FIXField("211", EFieldOption.Optional)]
    public double PegOffsetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(211);
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
        return this.GetIntValue(835);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(835, value);
      }
    }

    [FIXField("836", EFieldOption.Optional)]
    public int PegOffsetType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(836);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(836, value);
      }
    }

    [FIXField("837", EFieldOption.Optional)]
    public int PegLimitType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(837);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(837, value);
      }
    }

    [FIXField("838", EFieldOption.Optional)]
    public int PegRoundDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(838);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(838, value);
      }
    }

    [FIXField("840", EFieldOption.Optional)]
    public int PegScope
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(840);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(840, value);
      }
    }

    [FIXField("388", EFieldOption.Optional)]
    public char DiscretionInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(388);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(388, value);
      }
    }

    [FIXField("389", EFieldOption.Optional)]
    public double DiscretionOffsetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(389);
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
        return this.GetIntValue(841);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(841, value);
      }
    }

    [FIXField("842", EFieldOption.Optional)]
    public int DiscretionOffsetType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(842);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(842, value);
      }
    }

    [FIXField("843", EFieldOption.Optional)]
    public int DiscretionLimitType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(843);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(843, value);
      }
    }

    [FIXField("844", EFieldOption.Optional)]
    public int DiscretionRoundDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(844);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(844, value);
      }
    }

    [FIXField("846", EFieldOption.Optional)]
    public int DiscretionScope
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(846);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(846, value);
      }
    }

    [FIXField("847", EFieldOption.Optional)]
    public int TargetStrategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(847);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(847, value);
      }
    }

    [FIXField("848", EFieldOption.Optional)]
    public string TargetStrategyParameters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(848);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(848, value);
      }
    }

    [FIXField("849", EFieldOption.Optional)]
    public double ParticipationRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(849);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(849, value);
      }
    }

    [FIXField("376", EFieldOption.Optional)]
    public string ComplianceID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(376);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(376, value);
      }
    }

    [FIXField("377", EFieldOption.Optional)]
    public bool SolicitedFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(377);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(377, value);
      }
    }

    [FIXField("15", EFieldOption.Optional)]
    public string Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(15);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(15, value);
      }
    }

    [FIXField("59", EFieldOption.Optional)]
    public char TimeInForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(59);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(59, value);
      }
    }

    [FIXField("168", EFieldOption.Optional)]
    public DateTime EffectiveTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(168);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(168, value);
      }
    }

    [FIXField("432", EFieldOption.Optional)]
    public DateTime ExpireDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(432);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(432, value);
      }
    }

    [FIXField("126", EFieldOption.Optional)]
    public DateTime ExpireTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(126);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(126, value);
      }
    }

    [FIXField("427", EFieldOption.Optional)]
    public int GTBookingInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(427);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(427, value);
      }
    }

    [FIXField("12", EFieldOption.Optional)]
    public double Commission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(12);
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
        return this.GetCharValue(13);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(13, value);
      }
    }

    [FIXField("479", EFieldOption.Optional)]
    public double CommCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(479);
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
        return this.GetCharValue(497);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(497, value);
      }
    }

    [FIXField("528", EFieldOption.Optional)]
    public char OrderCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(528);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(528, value);
      }
    }

    [FIXField("529", EFieldOption.Optional)]
    public string OrderRestrictions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(529);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(529, value);
      }
    }

    [FIXField("582", EFieldOption.Optional)]
    public int CustOrderCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(582);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(582, value);
      }
    }

    [FIXField("121", EFieldOption.Optional)]
    public bool ForexReq
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(121);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(121, value);
      }
    }

    [FIXField("120", EFieldOption.Optional)]
    public double SettlCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(120);
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
        return this.GetIntValue(775);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(775, value);
      }
    }

    [FIXField("58", EFieldOption.Optional)]
    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(58);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(58, value);
      }
    }

    [FIXField("354", EFieldOption.Optional)]
    public int EncodedTextLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(354);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(354, value);
      }
    }

    [FIXField("355", EFieldOption.Optional)]
    public string EncodedText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(355);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(355, value);
      }
    }

    [FIXField("193", EFieldOption.Optional)]
    public DateTime SettlDate2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(193);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(193, value);
      }
    }

    [FIXField("192", EFieldOption.Optional)]
    public double OrderQty2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(192);
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
        return this.GetDoubleValue(640);
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
        return this.GetCharValue(77);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(77, value);
      }
    }

    [FIXField("203", EFieldOption.Optional)]
    public int CoveredOrUncovered
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(203);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(203, value);
      }
    }

    [FIXField("210", EFieldOption.Optional)]
    public double MaxShow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(210);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(210, value);
      }
    }

    [FIXField("114", EFieldOption.Optional)]
    public bool LocateReqd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolValue(114);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetBoolValue(114, value);
      }
    }

    [FIXField("480", EFieldOption.Optional)]
    public char CancellationRights
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(480);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(480, value);
      }
    }

    [FIXField("481", EFieldOption.Optional)]
    public char MoneyLaunderingStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(481);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(481, value);
      }
    }

    [FIXField("513", EFieldOption.Optional)]
    public string RegistID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(513);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(513, value);
      }
    }

    [FIXField("494", EFieldOption.Optional)]
    public string Designation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(494);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(494, value);
      }
    }

    [FIXField("47", EFieldOption.Optional)]
    public char Rule80A
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(47);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(47, value);
      }
    }

    [FIXField("204", EFieldOption.Optional)]
    public int CustomerOrFirm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(204);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(204, value);
      }
    }

    [FIXField("10", EFieldOption.Required)]
    public string CheckSum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(10);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(10, value);
      }
    }

    [FIXField("89", EFieldOption.Optional)]
    public string Signature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(89);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(89, value);
      }
    }

    [FIXField("93", EFieldOption.Optional)]
    public int SignatureLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(93);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(93, value);
      }
    }

    public FIXOrderCancelReplaceRequest():base()
    {
      this.zNXxaM6Xu = new ArrayList();
      this.qP155eNm9 = new ArrayList();
      this.THJgABKWo = new ArrayList();
      this.dYTohKwg6 = new ArrayList();
      this.T6ARrjHiK = new ArrayList();
      this.H1Q4SNW22 = new ArrayList();
      this.TosenlNhM = new ArrayList();
      this.ilEGkYXNu = new ArrayList();
    }


    public FIXOrderCancelReplaceRequest(string OrigClOrdID, string ClOrdID, char Side, DateTime TransactTime, char OrdType)
    :base(){

      this.zNXxaM6Xu = new ArrayList();
      this.qP155eNm9 = new ArrayList();
      this.THJgABKWo = new ArrayList();
      this.dYTohKwg6 = new ArrayList();
      this.T6ARrjHiK = new ArrayList();
      this.H1Q4SNW22 = new ArrayList();
      this.TosenlNhM = new ArrayList();
      this.ilEGkYXNu = new ArrayList();

      this.OrigClOrdID = OrigClOrdID;
      this.ClOrdID = ClOrdID;
      this.Side = Side;
      this.TransactTime = TransactTime;
      this.OrdType = OrdType;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.zNXxaM6Xu[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.zNXxaM6Xu.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.qP155eNm9[i];
      else
        return (FIXHopsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopsGroup group)
    {
      this.qP155eNm9.Add((object) group);
      ++this.NoHops;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.THJgABKWo[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.THJgABKWo.Add((object) group);
      ++this.NoPartyIDs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXAllocsGroup GetAllocsGroup(int i)
    {
      if (i < this.NoAllocs)
        return (FIXAllocsGroup) this.dYTohKwg6[i];
      else
        return (FIXAllocsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXAllocsGroup group)
    {
      this.dYTohKwg6.Add((object) group);
      ++this.NoAllocs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
    {
      if (i < this.NoTradingSessions)
        return (FIXTradingSessionsGroup) this.T6ARrjHiK[i];
      else
        return (FIXTradingSessionsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXTradingSessionsGroup group)
    {
      this.T6ARrjHiK.Add((object) group);
      ++this.NoTradingSessions;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.H1Q4SNW22[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.H1Q4SNW22.Add((object) group);
      ++this.NoSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.TosenlNhM[i];
      else
        return (FIXEventsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXEventsGroup group)
    {
      this.TosenlNhM.Add((object) group);
      ++this.NoEvents;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
    {
      if (i < this.NoUnderlyings)
        return (FIXUnderlyingsGroup) this.ilEGkYXNu[i];
      else
        return (FIXUnderlyingsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingsGroup group)
    {
      this.ilEGkYXNu.Add((object) group);
      ++this.NoUnderlyings;
    }
  }
}
