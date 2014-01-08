using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXClearingInstructionsGroup : FIXGroup
  {
    [FIXField("577", EFieldOption.Optional)]
    public int ClearingInstruction
    {
      get
      {
        return this.GetIntField(577).Value;
      }
        set
      {
        this.AddIntField(577, value);
      }
    }
  }
}
