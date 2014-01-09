using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlPartySubIDsGroup : FIXGroup
  {
    [FIXField("785", EFieldOption.Optional)]
    public string SettlPartySubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(785).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(785, value);
      }
    }

    [FIXField("786", EFieldOption.Optional)]
    public int SettlPartySubIDType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(786).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(786, value);
      }
    }


  }
}
