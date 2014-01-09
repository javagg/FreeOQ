using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlInstGroup : FIXGroup
  {
    private ArrayList ODe9uy37A;
    private ArrayList SnQs3Hbiv;

    [FIXField("162", EFieldOption.Optional)]
    public string SettlInstID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(162).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(162, value);
      }
    }

    [FIXField("163", EFieldOption.Optional)]
    public char SettlInstTransType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(163).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(163, value);
      }
    }

    [FIXField("214", EFieldOption.Optional)]
    public string SettlInstRefID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(214).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(214, value);
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

    [FIXField("779", EFieldOption.Optional)]
    public DateTime LastUpdateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(779).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(779, value);
      }
    }

    [FIXField("172", EFieldOption.Optional)]
    public int SettlDeliveryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(172).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(172, value);
      }
    }

    [FIXField("169", EFieldOption.Optional)]
    public int StandInstDbType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(169).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(169, value);
      }
    }

    [FIXField("170", EFieldOption.Optional)]
    public string StandInstDbName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(170).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(170, value);
      }
    }

    [FIXField("171", EFieldOption.Optional)]
    public string StandInstDbID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(171).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(171, value);
      }
    }

    [FIXField("85", EFieldOption.Optional)]
    public int NoDlvyInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(85).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(85, value);
      }
    }

    [FIXField("492", EFieldOption.Optional)]
    public int PaymentMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(492).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(492, value);
      }
    }

    [FIXField("476", EFieldOption.Optional)]
    public string PaymentRef
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(476).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(476, value);
      }
    }

    [FIXField("488", EFieldOption.Optional)]
    public string CardHolderName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(488).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(488, value);
      }
    }

    [FIXField("489", EFieldOption.Optional)]
    public string CardNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(489).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(489, value);
      }
    }

    [FIXField("503", EFieldOption.Optional)]
    public DateTime CardStartDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(503).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(503, value);
      }
    }

    [FIXField("490", EFieldOption.Optional)]
    public DateTime CardExpDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(490).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(490, value);
      }
    }

    [FIXField("491", EFieldOption.Optional)]
    public string CardIssNum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(491).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(491, value);
      }
    }

    [FIXField("504", EFieldOption.Optional)]
    public DateTime PaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(504).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(504, value);
      }
    }

    [FIXField("505", EFieldOption.Optional)]
    public string PaymentRemitterID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(505).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(505, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlInstGroup():base()
    {
      this.ODe9uy37A = new ArrayList();
      this.SnQs3Hbiv = new ArrayList();

    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.ODe9uy37A[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.ODe9uy37A.Add((object) group);
      ++this.NoPartyIDs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDlvyInstGroup GetDlvyInstGroup(int i)
    {
      if (i < this.NoDlvyInst)
        return (FIXDlvyInstGroup) this.SnQs3Hbiv[i];
      else
        return (FIXDlvyInstGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXDlvyInstGroup group)
    {
      this.SnQs3Hbiv.Add((object) group);
      ++this.NoDlvyInst;
    }
  }
}
