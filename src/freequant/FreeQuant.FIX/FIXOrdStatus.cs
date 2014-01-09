using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrdStatus : FIXCharField
  {
    public const char New = '0';
    public const char PartiallyFilled = '1';
    public const char Filled = '2';
    public const char DoneForDay = '3';
    public const char Cancelled = '4';
    public const char Replaced = '5';
    public const char PendingCancel = '6';
    public const char Stopped = '7';
    public const char Rejected = '8';
    public const char Suspended = '9';
    public const char PendingNew = 'A';
    public const char Calculated = 'B';
    public const char Expired = 'C';
    public const char AcceptedForBidding = 'D';
    public const char PendingReplace = 'E';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrdStatus(char val):base(39, val)
    {
 
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39660);
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39670);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39704);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39720);
        case '4':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39744);
        case '5':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39766);
        case '6':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39786);
        case '7':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39816);
        case '8':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39834);
        case '9':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39854);
        case 'A':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39876);
        case 'B':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39900);
        case 'C':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39924);
        case 'D':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39942);
        case 'E':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39982);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(40014);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OrdStatus FromFIX(char ordStatus)
    {
      switch (ordStatus)
      {
        case char.MinValue:
          return OrdStatus.Undefined;
        case '0':
          return OrdStatus.New;
        case '1':
          return OrdStatus.PartiallyFilled;
        case '2':
          return OrdStatus.Filled;
        case '3':
          return OrdStatus.DoneForDay;
        case '4':
          return OrdStatus.Cancelled;
        case '5':
          return OrdStatus.Replaced;
        case '6':
          return OrdStatus.PendingCancel;
        case '7':
          return OrdStatus.Stopped;
        case '8':
          return OrdStatus.Rejected;
        case '9':
          return OrdStatus.Suspended;
        case 'A':
          return OrdStatus.PendingNew;
        case 'B':
          return OrdStatus.Calculated;
        case 'C':
          return OrdStatus.Expired;
        case 'D':
          return OrdStatus.AcceptedForBidding;
        case 'E':
          return OrdStatus.PendingReplace;
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(40032) + (object) ordStatus);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(OrdStatus ordStatus)
    {
      switch (ordStatus)
      {
        case OrdStatus.Undefined:
          return char.MinValue;
        case OrdStatus.New:
          return '0';
        case OrdStatus.PartiallyFilled:
          return '1';
        case OrdStatus.Filled:
          return '2';
        case OrdStatus.DoneForDay:
          return '3';
        case OrdStatus.Cancelled:
          return '4';
        case OrdStatus.Replaced:
          return '5';
        case OrdStatus.PendingCancel:
          return '6';
        case OrdStatus.Stopped:
          return '7';
        case OrdStatus.Rejected:
          return '8';
        case OrdStatus.Suspended:
          return '9';
        case OrdStatus.PendingNew:
          return 'A';
        case OrdStatus.Calculated:
          return 'B';
        case OrdStatus.Expired:
          return 'C';
        case OrdStatus.AcceptedForBidding:
          return 'D';
        case OrdStatus.PendingReplace:
          return 'E';
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(40070) + ((object) ordStatus).ToString());
      }
    }
  }
}
