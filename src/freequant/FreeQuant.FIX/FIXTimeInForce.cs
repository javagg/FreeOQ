using System;

namespace FreeQuant.FIX
{
	public class FIXTimeInForce : FIXCharField
	{
		public const char Day = '0';
		public const char GTC = '1';
		public const char OPG = '2';
		public const char IOC = '3';
		public const char FOK = '4';
		public const char GTX = '5';
		public const char GoodTillDate = '6';
		public const char AtTheClose = '7';
		public const char GoodForSeconds = 'X';

		public FIXTimeInForce(char val) : base(59, val)
		{
		}

		public static char Value(string Name)
		{
			if (Name == "Day")
				return '0';
			if (Name == "GTC")
				return '1';
			if (Name == "OPG")
				return '2';
			if (Name == "IOC")
				return '3';
			if (Name == "FOK")
				return '4';
			if (Name == "GTX")
				return '5';
			if (Name == "GoodTillDate")
				return '6';
			if (Name == "AtTheClose")
				return '7';
			return Name == "GoodForSeconds" ? 'X' : char.MinValue;
		}

		public static string ToString(char c)
		{
			switch (c)
			{
				case '0':
					return "Day";
				case '1':
					return "GTC";
				case '2':
					return "OPG";
				case '3':
					return "IOC";
				case '4':
					return "FOK";
				case '5':
					return "GTX";
				case '6':
					return "GoodTillDate";
				case '7':
					return "AtTheClose";
				case 'X':
					return "GoodForSeconds";
				default:
					return "Unknown";
			}
		}

		public static TimeInForce FromFIX(char timeInForce)
		{
			switch (timeInForce)
			{
				case char.MinValue:
					return TimeInForce.Undefined;
				case '0':
					return TimeInForce.Day;
				case '1':
					return TimeInForce.GTC;
				case '2':
					return TimeInForce.OPG;
				case '3':
					return TimeInForce.IOC;
				case '4':
					return TimeInForce.FOK;
				case '5':
					return TimeInForce.GTX;
				case '6':
					return TimeInForce.GoodTillDate;
				case '7':
					return TimeInForce.AtTheClose;
				case 'X':
					return TimeInForce.GoodForSeconds;
				default:
					throw new ArgumentException("" + (object)timeInForce);
			}
		}

		public static char ToFIX(TimeInForce timeInForce)
		{
			switch (timeInForce)
			{
				case TimeInForce.Undefined:
					return char.MinValue;
				case TimeInForce.Day:
					return '0';
				case TimeInForce.GTC:
					return '1';
				case TimeInForce.OPG:
					return '2';
				case TimeInForce.IOC:
					return '3';
				case TimeInForce.FOK:
					return '4';
				case TimeInForce.GTX:
					return '5';
				case TimeInForce.GoodTillDate:
					return '6';
				case TimeInForce.AtTheClose:
					return '7';
				case TimeInForce.GoodForSeconds:
					return 'X';
				default:
					throw new ArgumentException("" + ((object)timeInForce).ToString());
			}
		}
	}
}
