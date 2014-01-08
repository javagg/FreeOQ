using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUnderlyingStipsGroup : FIXGroup
  {
    [FIXField("888", EFieldOption.Optional)]
    public string UnderlyingStipType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(888).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(888, value);
      }
    }

    [FIXField("889", EFieldOption.Optional)]
    public string UnderlyingStipValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(889).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(889, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
