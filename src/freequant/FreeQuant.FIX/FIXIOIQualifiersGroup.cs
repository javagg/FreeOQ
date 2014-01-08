using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXIOIQualifiersGroup : FIXGroup
  {
    [FIXField("104", EFieldOption.Optional)]
    public char IOIQualifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(104).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(104, value);
      }
    }
  }
}
