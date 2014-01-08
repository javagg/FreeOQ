using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNested2PartyIDsGroup : FIXGroup
  {
    private ArrayList EoU7iJrCH8;

    [FIXField("757", EFieldOption.Optional)]
    public string Nested2PartyID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(757).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(757, value);
      }
    }

    [FIXField("758", EFieldOption.Optional)]
    public char Nested2PartyIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(758).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(758, value);
      }
    }

    [FIXField("759", EFieldOption.Optional)]
    public int Nested2PartyRole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(759).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(759, value);
      }
    }

    [FIXField("806", EFieldOption.Optional)]
    public int NoNested2PartySubIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(806).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(806, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested2PartyIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.EoU7iJrCH8 = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested2PartySubIDsGroup GetNested2PartySubIDsGroup(int i)
    {
      if (i < this.NoNested2PartySubIDs)
        return (FIXNested2PartySubIDsGroup) this.EoU7iJrCH8[i];
      else
        return (FIXNested2PartySubIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNested2PartySubIDsGroup group)
    {
      this.EoU7iJrCH8.Add((object) group);
      ++this.NoNested2PartySubIDs;
    }
  }
}
