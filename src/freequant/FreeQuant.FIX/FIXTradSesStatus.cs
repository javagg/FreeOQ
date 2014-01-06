// Type: SmartQuant.FIX.FIXTradSesStatus
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXTradSesStatus : FIXIntField
  {
    public const int Halted = 1;
    public const int Open = 2;
    public const int Closed = 3;
    public const int PreOpen = 4;
    public const int PreClose = 5;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradSesStatus(int value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(340, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(int value)
    {
      switch (value)
      {
        case 1:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3294);
        case 2:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3310);
        case 3:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3322);
        case 4:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3338);
        case 5:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3358);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3380);
      }
    }
  }
}
