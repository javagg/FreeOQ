using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXContAmtsGroup : FIXGroup
  {
    [FIXField("519", EFieldOption.Optional)]
    public int ContAmtType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(519).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(519, value);
      }
    }

    [FIXField("520", EFieldOption.Optional)]
    public double ContAmtValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(520).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(520, value);
      }
    }

    [FIXField("521", EFieldOption.Optional)]
    public double ContAmtCurr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(521).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(521, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXContAmtsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
