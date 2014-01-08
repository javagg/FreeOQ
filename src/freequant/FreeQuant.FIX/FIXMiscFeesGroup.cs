using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMiscFeesGroup : FIXGroup
  {
    [FIXField("137", EFieldOption.Optional)]
    public double MiscFeeAmt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(137).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(137, value);
      }
    }

    [FIXField("138", EFieldOption.Optional)]
    public double MiscFeeCurr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(138).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(138, value);
      }
    }

    [FIXField("139", EFieldOption.Optional)]
    public char MiscFeeType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(139).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(139, value);
      }
    }

    [FIXField("891", EFieldOption.Optional)]
    public int MiscFeeBasis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(891).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(891, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMiscFeesGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
