using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPosAmtGroup : FIXGroup
  {
    [FIXField("707", EFieldOption.Optional)]
    public string PosAmtType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(707).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(707, value);
      }
    }

    [FIXField("708", EFieldOption.Optional)]
    public double PosAmt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(708).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(708, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPosAmtGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
