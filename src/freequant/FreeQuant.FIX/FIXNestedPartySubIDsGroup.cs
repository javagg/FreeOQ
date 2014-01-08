using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNestedPartySubIDsGroup : FIXGroup
  {
    [FIXField("545", EFieldOption.Optional)]
    public string NestedPartySubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(545).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(545, value);
      }
    }

    [FIXField("805", EFieldOption.Optional)]
    public int NestedPartySubIDType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(805).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(805, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartySubIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
