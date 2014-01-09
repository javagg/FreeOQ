using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPartySubIDsGroup : FIXGroup
  {
    [FIXField("523", EFieldOption.Optional)]
    public string PartySubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(523).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(523, value);
      }
    }

    [FIXField("803", EFieldOption.Optional)]
    public int PartySubIDType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(803).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(803, value);
      }
    }

  }
}
