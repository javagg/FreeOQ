using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUnsolicitedIndicatorGroup : FIXGroup
  {
    [FIXField("325", EFieldOption.Optional)]
    public bool UnsolicitedIndicator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(325).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(325, value);
      }
    }
  }
}
