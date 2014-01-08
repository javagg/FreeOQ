using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRegistDtlsGroup : FIXGroup
  {
    private ArrayList W6VZvlQljA;

    [FIXField("509", EFieldOption.Optional)]
    public string RegistDtls
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(509).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(509, value);
      }
    }

    [FIXField("511", EFieldOption.Optional)]
    public string RegistEmail
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(511).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(511, value);
      }
    }

    [FIXField("474", EFieldOption.Optional)]
    public string MailingDtls
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(474).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(474, value);
      }
    }

    [FIXField("482", EFieldOption.Optional)]
    public string MailingInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(482).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(482, value);
      }
    }

    [FIXField("539", EFieldOption.Optional)]
    public int NoNestedPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(539).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(539, value);
      }
    }

    [FIXField("522", EFieldOption.Optional)]
    public int OwnerType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(522).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(522, value);
      }
    }

    [FIXField("486", EFieldOption.Optional)]
    public DateTime DateOfBirth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(486).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(486, value);
      }
    }

    [FIXField("475", EFieldOption.Optional)]
    public string InvestorCountryOfResidence
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(475).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(475, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRegistDtlsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.W6VZvlQljA = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
    {
      if (i < this.NoNestedPartyIDs)
        return (FIXNestedPartyIDsGroup) this.W6VZvlQljA[i];
      else
        return (FIXNestedPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNestedPartyIDsGroup group)
    {
      this.W6VZvlQljA.Add((object) group);
      ++this.NoNestedPartyIDs;
    }
  }
}
