using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUnderlyingSecurityAltIDGroup : FIXGroup
  {
    [FIXField("458", EFieldOption.Optional)]
    public string UnderlyingSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(458).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(458, value);
      }
    }

    [FIXField("459", EFieldOption.Optional)]
    public string UnderlyingSecurityAltIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(459).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(459, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingSecurityAltIDGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
