// Type: SmartQuant.FIX.FIXMiscFeesGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
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
