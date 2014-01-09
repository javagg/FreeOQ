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

    public FIXLegSecurityAltIDGroup() : base()
    {
    }
  }
}
