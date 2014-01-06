// Type: SmartQuant.FIX.FIXCorporateActionType
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXCorporateActionType : FIXIntField
  {
    public const int CashDividend = 1;
    public const int StockDividend = 2;
    public const int Split = 3;
    public const int RightsIssue = 4;
    public const int Merger = 5;
    public const int Acquisition = 6;
    public const int SpinOff = 7;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCorporateActionType(int val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(10200, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(int val)
    {
      switch (val)
      {
        case 1:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4350);
        case 2:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4378);
        case 3:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4408);
        case 4:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4422);
        case 5:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4448);
        case 6:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4464);
        case 7:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4490);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4508);
      }
    }
  }
}
