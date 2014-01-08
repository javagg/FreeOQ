using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAllocsGroup : FIXGroup
  {
    private ArrayList knUUgb6Axa;

    [FIXField("79", EFieldOption.Optional)]
    public string AllocAccount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(79).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(79, value);
      }
    }

    [FIXField("661", EFieldOption.Optional)]
    public int AllocAcctIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(661).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(661, value);
      }
    }

    [FIXField("736", EFieldOption.Optional)]
    public double AllocSettlCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(736).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(736, value);
      }
    }

    [FIXField("467", EFieldOption.Optional)]
    public string IndividualAllocID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(467).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(467, value);
      }
    }

    [FIXField("756", EFieldOption.Optional)]
    public int NoNested2PartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(756).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(756, value);
      }
    }

    [FIXField("80", EFieldOption.Optional)]
    public double AllocQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(80).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(80, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXAllocsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.knUUgb6Axa = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested2PartyIDsGroup GetNested2PartyIDsGroup(int i)
    {
      if (i < this.NoNested2PartyIDs)
        return (FIXNested2PartyIDsGroup) this.knUUgb6Axa[i];
      else
        return (FIXNested2PartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNested2PartyIDsGroup group)
    {
      this.knUUgb6Axa.Add((object) group);
      ++this.NoNested2PartyIDs;
    }
  }
}
