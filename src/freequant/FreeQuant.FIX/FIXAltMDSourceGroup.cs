using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAltMDSourceGroup : FIXGroup
  {
    [FIXField("817", EFieldOption.Optional)]
    public string AltMDSourceID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(817).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(817, value);
      }
    }

  }
}
