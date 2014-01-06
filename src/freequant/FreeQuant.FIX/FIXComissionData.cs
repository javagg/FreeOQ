// Type: SmartQuant.FIX.FIXComissionData
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXComissionData : FIXGroup
  {
    [FIXField("12", EFieldOption.Optional)]
    public double Commission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(12);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(12, value);
      }
    }

    [FIXField("13", EFieldOption.Optional)]
    public char CommType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(13);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(13, value);
      }
    }

    [FIXField("479", EFieldOption.Optional)]
    public string CommCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(479);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(479, value);
      }
    }

    [FIXField("497", EFieldOption.Optional)]
    public char FundRenewWaiv
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(497);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(497, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXComissionData()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
