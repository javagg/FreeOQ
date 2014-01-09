using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradingSessionStatus : FIXMessage
  {
    private ArrayList IMT7UTJxO5;
    private ArrayList ume7AfO5fM;
    private ArrayList p8O78ESLLR;

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

    [FIXField("335", EFieldOption.Optional)]
    public string TradSesReqID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(335).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(335, value);
      }
    }

    [FIXField("336", EFieldOption.Required)]
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

    [FIXField("338", EFieldOption.Optional)]
    public int TradSesMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(338).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(338, value);
      }
    }

    [FIXField("339", EFieldOption.Optional)]
    public int TradSesMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(339).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(339, value);
      }
    }

    [FIXField("340", EFieldOption.Required)]
    public int TradSesStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(340).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(340, value);
      }
    }

    [FIXField("567", EFieldOption.Optional)]
    public int TradSesStatusRejReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(567).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(567, value);
      }
    }

    [FIXField("341", EFieldOption.Optional)]
    public DateTime TradSesStartTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(341).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(341, value);
      }
    }

    [FIXField("342", EFieldOption.Optional)]
    public DateTime TradSesOpenTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(342).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(342, value);
      }
    }

    [FIXField("343", EFieldOption.Optional)]
    public DateTime TradSesPreCloseTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(343).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(343, value);
      }
    }

    [FIXField("344", EFieldOption.Optional)]
    public DateTime TradSesCloseTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(344).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(344, value);
      }
    }

    [FIXField("345", EFieldOption.Optional)]
    public DateTime TradSesEndTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(345).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(345, value);
      }
    }

    [FIXField("387", EFieldOption.Optional)]
    public double TotalVolumeTraded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(387).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(387, value);
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
    public FIXTradingSessionStatus() :base()
    { 

      this.IMT7UTJxO5 = new ArrayList();
      this.ume7AfO5fM = new ArrayList();
      this.p8O78ESLLR = new ArrayList();

    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradingSessionStatus(string TradingSessionID, int TradSesStatus):base()
    {
      this.IMT7UTJxO5 = new ArrayList();
      this.ume7AfO5fM = new ArrayList();
      this.p8O78ESLLR = new ArrayList();

      this.TradingSessionID = TradingSessionID;
      this.TradSesStatus = TradSesStatus;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.IMT7UTJxO5[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.IMT7UTJxO5.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.ume7AfO5fM[i];
      else
        return (FIXHopsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopsGroup group)
    {
      this.ume7AfO5fM.Add((object) group);
      ++this.NoHops;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnsolicitedIndicatorGroup GetUnsolicitedIndicatorGroup(int i)
    {
      return (FIXUnsolicitedIndicatorGroup) this.p8O78ESLLR[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnsolicitedIndicatorGroup group)
    {
      this.p8O78ESLLR.Add((object) group);
    }
  }
}
