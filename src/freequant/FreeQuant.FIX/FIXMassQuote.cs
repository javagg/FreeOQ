using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMassQuote : FIXMessage
  {
    private ArrayList DX4Yf0or4i;
    private ArrayList SY3Y6yqPJd;
    private ArrayList DDDYqsWF4F;
    private ArrayList FcVYXWVOng;

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

    [FIXField("131", EFieldOption.Optional)]
    public string QuoteReqID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(131).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(131, value);
      }
    }

    [FIXField("117", EFieldOption.Required)]
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

    [FIXField("537", EFieldOption.Optional)]
    public int QuoteType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(537).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(537, value);
      }
    }

    [FIXField("301", EFieldOption.Optional)]
    public int QuoteResponseLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(301).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(301, value);
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

    [FIXField("293", EFieldOption.Optional)]
    public double DefBidSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(293).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(293, value);
      }
    }

    [FIXField("294", EFieldOption.Optional)]
    public double DefOfferSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(294).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(294, value);
      }
    }

    [FIXField("296", EFieldOption.Required)]
    public int NoQuoteSets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(296).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(296, value);
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
    public FIXMassQuote(): base()
    {
        this.DX4Yf0or4i = new ArrayList();
      this.SY3Y6yqPJd = new ArrayList();
      this.DDDYqsWF4F = new ArrayList();
      this.FcVYXWVOng = new ArrayList();
    }


    public FIXMassQuote(string QuoteID, int NoQuoteSets): base()
    {
      this.DX4Yf0or4i = new ArrayList();
      this.SY3Y6yqPJd = new ArrayList();
      this.DDDYqsWF4F = new ArrayList();
      this.FcVYXWVOng = new ArrayList();
      this.QuoteID = QuoteID;
      this.NoQuoteSets = NoQuoteSets;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.DX4Yf0or4i[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.DX4Yf0or4i.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.SY3Y6yqPJd[i];
      else
        return (FIXHopsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopsGroup group)
    {
      this.SY3Y6yqPJd.Add((object) group);
      ++this.NoHops;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.DDDYqsWF4F[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.DDDYqsWF4F.Add((object) group);
      ++this.NoPartyIDs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteSetsGroup GetQuoteSetsGroup(int i)
    {
      if (i < this.NoQuoteSets)
        return (FIXQuoteSetsGroup) this.FcVYXWVOng[i];
      else
        return (FIXQuoteSetsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXQuoteSetsGroup group)
    {
      this.FcVYXWVOng.Add((object) group);
      ++this.NoQuoteSets;
    }
  }
}
