using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCxlRejReason : FIXIntField
  {
    public const int TooLateToCancel = 0;
    public const int UnknownOrder = 1;
    public const int BrokerOption = 2;
    public const int AlreadyPending = 3;


    public FIXCxlRejReason(int value):base(102, value)
    {

    }

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
