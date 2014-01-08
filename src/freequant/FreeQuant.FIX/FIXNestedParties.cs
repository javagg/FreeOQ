using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNestedParties : FIXMessage
  {
    private ArrayList obePoHEok;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedParties()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.obePoHEok = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
    {
      if (i < this.NoNestedPartyIDs)
        return (FIXNestedPartyIDsGroup) this.obePoHEok[i];
      else
        return (FIXNestedPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNestedPartyIDsGroup group)
    {
      this.obePoHEok.Add((object) group);
      ++this.NoNestedPartyIDs;
    }
  }
}
