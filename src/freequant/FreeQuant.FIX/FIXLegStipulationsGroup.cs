using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLegStipulationsGroup : FIXGroup
  {
    [FIXField("688", EFieldOption.Optional)]
    public string LegStipulationType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(688).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(688, value);
      }
    }

    [FIXField("689", EFieldOption.Optional)]
    public string LegStipulationValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(689).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(689, value);
      }
    }

 
  }
}
