using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRoutingIDsGroup : FIXGroup
  {
    [FIXField("216", EFieldOption.Optional)]
    public int RoutingType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(216).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(216, value);
      }
    }

    [FIXField("217", EFieldOption.Optional)]
    public string RoutingID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(217).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(217, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRoutingIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
