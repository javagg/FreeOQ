using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlParties : FIXMessage
  {
    private ArrayList QptZQm8i1H;

    [FIXField("781", EFieldOption.Optional)]
    public int NoSettlPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(781).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(781, value);
      }
    }

    public FIXSettlParties():base()
    {
      this.QptZQm8i1H = new ArrayList();
    }

    public FIXSettlPartyIDsGroup GetSettlPartyIDsGroup(int i)
    {
      if (i < this.NoSettlPartyIDs)
        return (FIXSettlPartyIDsGroup) this.QptZQm8i1H[i];
      else
        return (FIXSettlPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSettlPartyIDsGroup group)
    {
      this.QptZQm8i1H.Add((object) group);
      ++this.NoSettlPartyIDs;
    }
  }
}
