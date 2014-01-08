using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNested3PartySubIDsGroup : FIXGroup
  {
    [FIXField("953", EFieldOption.Optional)]
    public string Nested3PartySubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(953).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(953, value);
      }
    }

    [FIXField("954", EFieldOption.Optional)]
    public int Nested3PartySubIDType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(954).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(954, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested3PartySubIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
