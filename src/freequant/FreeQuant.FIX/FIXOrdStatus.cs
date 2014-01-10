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

		public FIXOrdStatus(char val) : base(39, val)
		{
 
		}

		public static string ToString(char c)
		{
			switch (c)
			{
				case '0':
					return "New";
				case '1':
					return "PartiallyFilled";
				case '2':
					return "Filled";
				case '3':
					return "DoneForDay";
				case '4':
					return "Cancelled";
				case '5':
					return "Replaced";
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
					return "AcceptedForBidding";
				case 'E':
					return "PendingReplace";
				default:
					return "Unknown";
			}
		}

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
					throw new ArgumentException("unknown: " + (object)ordStatus);
			}
		}

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
					throw new ArgumentException("unknown: " + ((object)ordStatus).ToString());
			}
		}
	}
}
