// Type: SmartQuant.FIX.FIXCxlRejReason
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXCxlRejReason : FIXIntField
  {
    public const int TooLateToCancel = 0;
    public const int UnknownOrder = 1;
    public const int BrokerOption = 2;
    public const int AlreadyPending = 3;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCxlRejReason(int value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(102, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CxlRejReason FromFIX(int value)
    {
      switch (value)
      {
        case 0:
          return CxlRejReason.TooLateToCancel;
        case 1:
          return CxlRejReason.UnknownOrder;
        case 2:
          return CxlRejReason.BrokerOption;
        case 3:
          return CxlRejReason.AlreadyPending;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(2752), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ToFIX(CxlRejReason reason)
    {
      switch (reason)
      {
        case CxlRejReason.TooLateToCancel:
          return 0;
        case CxlRejReason.UnknownOrder:
          return 1;
        case CxlRejReason.BrokerOption:
          return 2;
        case CxlRejReason.AlreadyPending:
          return 3;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(2796), (object) reason));
      }
    }
  }
}
