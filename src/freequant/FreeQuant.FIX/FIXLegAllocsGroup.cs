// Type: SmartQuant.FIX.FIXLegAllocsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXLegAllocsGroup : FIXGroup
  {
    [FIXField("671", EFieldOption.Optional)]
    public string LegAllocAccount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(671).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(671, value);
      }
    }

    [FIXField("672", EFieldOption.Optional)]
    public string LegIndividualAllocID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(672).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(672, value);
      }
    }

    [FIXField("673", EFieldOption.Optional)]
    public double LegAllocQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(673).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(673, value);
      }
    }

    [FIXField("674", EFieldOption.Optional)]
    public string LegAllocAcctIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(674).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(674, value);
      }
    }

    [FIXField("675", EFieldOption.Optional)]
    public double LegSettlCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(675).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(675, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegAllocsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
