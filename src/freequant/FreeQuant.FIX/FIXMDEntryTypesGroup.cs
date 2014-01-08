using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMDEntryTypesGroup : FIXGroup
  {
    [FIXField("269", EFieldOption.Required)]
    public char MDEntryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(269).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(269, value);
      }
    }

    public FIXMDEntryTypesGroup(char MDEntryType)
    {
      this.MDEntryType = MDEntryType;
    }
  }
}
