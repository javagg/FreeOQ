using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLegSecurityAltIDGroup : FIXGroup
  {
    [FIXField("605", EFieldOption.Optional)]
    public string LegSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(605).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(605, value);
      }
    }

    [FIXField("606", EFieldOption.Optional)]
    public string LegSecurityAltIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(606).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(606, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegSecurityAltIDGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
