using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAllocationInstructionAck : FIXMessage
  {
    private ArrayList Sr4uF6IwcY;
    private ArrayList JsMuwo6Fsf;
    private ArrayList vVduCyTLjj;
    private ArrayList Autu2ScN8L;

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

    [FIXField("70", EFieldOption.Required)]
    public string AllocID
    {
       get
      {
        return this.GetStringField(70).Value;
      }
       set
      {
        this.AddStringField(70, value);
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

    [FIXField("793", EFieldOption.Optional)]
    public string SecondaryAllocID
    {
       get
      {
        return this.GetStringField(793).Value;
      }
       set
      {
        this.AddStringField(793, value);
      }
    }

    [FIXField("75", EFieldOption.Optional)]
    public DateTime TradeDate
    {
       get
      {
        return this.GetDateTimeField(75).Value;
      }
       set
      {
        this.AddDateTimeField(75, value);
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

    [FIXField("87", EFieldOption.Required)]
    public int AllocStatus
    {
       get
      {
        return this.GetIntField(87).Value;
      }
       set
      {
        this.AddIntField(87, value);
      }
    }

    [FIXField("88", EFieldOption.Optional)]
    public int AllocRejCode
    {
       get
      {
        return this.GetIntField(88).Value;
      }
       set
      {
        this.AddIntField(88, value);
      }
    }

    [FIXField("626", EFieldOption.Optional)]
    public int AllocType
    {
       get
      {
        return this.GetIntField(626).Value;
      }
       set
      {
        this.AddIntField(626, value);
      }
    }

    [FIXField("808", EFieldOption.Optional)]
    public int AllocIntermedReqType
    {
       get
      {
        return this.GetIntField(808).Value;
      }
       set
      {
        this.AddIntField(808, value);
      }
    }

    [FIXField("573", EFieldOption.Optional)]
    public char MatchStatus
    {
       get
      {
        return this.GetCharField(573).Value;
      }
       set
      {
        this.AddCharField(573, value);
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

    [FIXField("78", EFieldOption.Optional)]
    public int NoAllocs
    {
       get
      {
        return this.GetIntField(78).Value;
      }
       set
      {
        this.AddIntField(78, value);
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

    
    public FIXAllocationInstructionAck():base()
    {

      this.Sr4uF6IwcY = new ArrayList();
      this.JsMuwo6Fsf = new ArrayList();
      this.vVduCyTLjj = new ArrayList();
      this.Autu2ScN8L = new ArrayList();

    }

    
    public FIXAllocationInstructionAck(string AllocID, DateTime TransactTime, int AllocStatus)
        : base()
    {

      this.Sr4uF6IwcY = new ArrayList();
      this.JsMuwo6Fsf = new ArrayList();
      this.vVduCyTLjj = new ArrayList();
      this.Autu2ScN8L = new ArrayList();

      this.AllocID = AllocID;
      this.TransactTime = TransactTime;
      this.AllocStatus = AllocStatus;
    }

    
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.Sr4uF6IwcY[i];
    }

    
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.Sr4uF6IwcY.Add((object) group);
    }

    
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.JsMuwo6Fsf[i];
      else
        return (FIXHopsGroup) null;
    }

    
    public void AddGroup(FIXHopsGroup group)
    {
      this.JsMuwo6Fsf.Add((object) group);
      ++this.NoHops;
    }

    
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.vVduCyTLjj[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.vVduCyTLjj.Add((object) group);
      ++this.NoPartyIDs;
    }

    
    public FIXAllocsGroup GetAllocsGroup(int i)
    {
      if (i < this.NoAllocs)
        return (FIXAllocsGroup) this.Autu2ScN8L[i];
      else
        return (FIXAllocsGroup) null;
    }

    
    public void AddGroup(FIXAllocsGroup group)
    {
      this.Autu2ScN8L.Add((object) group);
      ++this.NoAllocs;
    }
  }
}
