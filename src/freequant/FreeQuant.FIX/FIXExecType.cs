using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXExecType : FIXCharField
  {
    public const char New = '0';
    public const char PartialFill = '1';
    public const char Fill = '2';
    public const char DoneForDay = '3';
    public const char Cancelled = '4';
    public const char Replace = '5';
    public const char PendingCancel = '6';
    public const char Stopped = '7';
    public const char Rejected = '8';
    public const char Suspended = '9';
    public const char PendingNew = 'A';
    public const char Calculated = 'B';
    public const char Expired = 'C';
    public const char Restarted = 'D';
    public const char PendingReplace = 'E';
    public const char Trade = 'F';
    public const char TradeCorrect = 'G';
    public const char TradeCancel = 'H';
    public const char OrderStatus = 'I';

    public FIXExecType(char val):base(150, val)
    {
    }

    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
					return "New";
        case '1':
					return "PartialFill";
        case '2':
					return "Fill";
        case '3':
					return "DoneForDay";
        case '4':
					return "Cancelled";
        case '5':
					return "Replace";
        case '6':
					return "PendingCancel";
        case '7':
					return "Stopped";
        case '8':
					return "Rejected";
        case '9':
					return "Suspended";
        case 'A':
					return "PendingNew";
        case 'B':
					return "Calculated";
        case 'C':
					return "Expired";
        case 'D':
					return "Restarted";
        case 'E':
					return "PendingReplace";
        case 'F':
					return "Trade";
        case 'G':
					return "TradeCorrect";
        case 'H':
					return "TradeCancel";
        case 'I':
					return "OrderStatus";
        default:
          return (string) null;
      }
    }

    public static ExecType FromFIX(char execType)
    {
      switch (execType)
      {
        case char.MinValue:
          return ExecType.Undefined;
        case '0':
          return ExecType.New;
        case '1':
          return ExecType.PartialFill;
        case '2':
          return ExecType.Fill;
        case '3':
          return ExecType.DoneForDay;
        case '4':
          return ExecType.Cancelled;
        case '5':
          return ExecType.Replace;
        case '6':
          return ExecType.PendingCancel;
        case '7':
          return ExecType.Stopped;
        case '8':
          return ExecType.Rejected;
        case '9':
          return ExecType.Suspended;
        case 'A':
          return ExecType.PendingNew;
        case 'B':
          return ExecType.Calculated;
        case 'C':
          return ExecType.Expired;
        case 'D':
          return ExecType.Restarted;
        case 'E':
          return ExecType.PendingReplace;
        case 'F':
          return ExecType.Trade;
        case 'G':
          return ExecType.TradeCorrect;
        case 'H':
          return ExecType.TradeCancel;
        case 'I':
          return ExecType.OrderStatus;
        default:
					throw new ArgumentException("unsupported"+ (object) execType);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(ExecType execType)
    {
      switch (execType)
      {
        case ExecType.New:
          return '0';
        case ExecType.PartialFill:
          return '1';
        case ExecType.Fill:
          return '2';
        case ExecType.DoneForDay:
          return '3';
        case ExecType.Cancelled:
          return '4';
        case ExecType.Replace:
          return '5';
        case ExecType.PendingCancel:
          return '6';
        case ExecType.Stopped:
          return '7';
        case ExecType.Rejected:
          return '8';
        case ExecType.Suspended:
          return '9';
        case ExecType.PendingNew:
          return 'A';
        case ExecType.Calculated:
          return 'B';
        case ExecType.Expired:
          return 'C';
        case ExecType.Restarted:
          return 'D';
        case ExecType.PendingReplace:
          return 'E';
        case ExecType.Trade:
          return 'F';
        case ExecType.TradeCorrect:
          return 'G';
        case ExecType.TradeCancel:
          return 'H';
        case ExecType.OrderStatus:
          return 'I';
        default:
					throw new ArgumentException("unknown: " + ((object) execType).ToString());
      }
    }
  }
}
