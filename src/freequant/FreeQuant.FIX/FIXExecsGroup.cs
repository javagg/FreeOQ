using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXExecsGroup : FIXGroup
  {
    [FIXField("17", EFieldOption.Optional)]
    public string ExecID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(17).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(17, value);
      }
    }
  }
}
