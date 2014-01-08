using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStipulationsGroup : FIXGroup
  {
    [FIXField("233", EFieldOption.Optional)]
    public string StipulationType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(233).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(233, value);
      }
    }

    [FIXField("234", EFieldOption.Optional)]
    public string StipulationValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(234).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(234, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStipulationsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
