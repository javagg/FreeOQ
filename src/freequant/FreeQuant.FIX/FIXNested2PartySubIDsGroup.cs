using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNested2PartySubIDsGroup : FIXGroup
  {
    [FIXField("760", EFieldOption.Optional)]
    public string Nested2PartySubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(760).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(760, value);
      }
    }

    [FIXField("807", EFieldOption.Optional)]
    public int Nested2PartySubIDType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(807).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(807, value);
      }
    }


  }
}
