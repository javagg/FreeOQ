using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMsgTypesGroup : FIXGroup
  {
    [FIXField("372", EFieldOption.Optional)]
    public string RefMsgType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(372).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(372, value);
      }
    }

    [FIXField("385", EFieldOption.Optional)]
    public char MsgDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(385).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(385, value);
      }
    }


  }
}
