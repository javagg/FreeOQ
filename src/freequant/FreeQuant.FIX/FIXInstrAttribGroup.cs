using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXInstrAttribGroup : FIXGroup
  {
    [FIXField("871", EFieldOption.Optional)]
    public int InstrAttribType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(871).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(871, value);
      }
    }

    [FIXField("872", EFieldOption.Optional)]
    public string InstrAttribValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(872).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(872, value);
      }
    }


  }
}
