// Type: SmartQuant.FIX.FIXPutOrCall
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXPutOrCall : FIXIntField
  {
    public const int Put = 0;
    public const int Call = 1;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPutOrCall(int val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(201, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(int i)
    {
      switch (i)
      {
        case 0:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3398);
        case 1:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3408);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3420);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PutOrCall FromFIX(int value)
    {
      switch (value)
      {
        case 0:
          return PutOrCall.Put;
        case 1:
          return PutOrCall.Call;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(3438), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ToFIX(PutOrCall value)
    {
      switch (value)
      {
        case PutOrCall.Put:
          return 0;
        case PutOrCall.Call:
          return 1;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(3504), (object) value));
      }
    }
  }
}
