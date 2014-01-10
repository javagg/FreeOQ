using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
	public class FIXOrdType : FIXCharField
	{
		public const char Market = '1';
		public const char Limit = '2';
		public const char Stop = '3';
		public const char StopLimit = '4';
		public const char MarketOnClose = '5';
		public const char WithOrWithout = '6';
		public const char LimitOrBetter = '7';
		public const char LimitWithOrWithout = '8';
		public const char OnBasis = '9';
		public const char OnClose = 'A';
		public const char LimitOnClose = 'B';
		public const char ForexMarket = 'C';
		public const char PreviouslyQuoted = 'D';
		public const char PreviouslyIndicated = 'E';
		public const char ForexLimit = 'F';
		public const char ForexSwap = 'G';
		public const char ForexPreviouslyQuoted = 'H';
		public const char Funari = 'I';
		public const char MIT = 'J';
		public const char MarketWithLeftoverAsLimit = 'K';
		public const char PreviousFundValuationPoint = 'L';
		public const char NextFundValuationPoint = 'M';
		public const char Pegged = 'P';
		public const char TrailingStop = 'T';
		public const char TrailingStopLimit = 'S';

		public FIXOrdType(char val) : base(40, val)
		{
		}

		public static char Value(string Name)
		{
			if (Name == "Market")
				return '1';
			if (Name == "Limit")
				return '2';
			if (Name == "Stop")
				return '3';
			if (Name == "StopLimit")
				return '4';
			if (Name == "MarketOnClose")
				return '5';
			if (Name == "WithOrWithout")
				return '6';
			if (Name == "LimitOrBetter")
				return '7';
			if (Name == "LimitWithOrWithout")
				return '8';
			if (Name == "OnBasis")
				return '9';
			if (Name == "OnClose")
				return 'A';
			if (Name == "LimitOnClose")
				return 'B';
			if (Name == "ForexMarket")
				return 'C';
			if (Name == "PreviouslyQuoted")
				return 'D';
			if (Name == "PreviouslyIndicated")
				return 'E';
			if (Name == "ForexLimit")
				return 'F';
			if (Name == "ForexSwap")
				return 'G';
			if (Name == "ForexPreviouslyQuoted")
				return 'H';
			if (Name == "Funari")
				return 'I';
			if (Name == "MIT")
				return 'J';
			if (Name == "MarketWithLeftoverAsLimit")
				return 'K';
			if (Name == "PreviousFundValuationPoint")
				return 'L';
			if (Name == "NextFundValuationPoint")
				return 'M';
			if (Name == "TrailingStop")
				return 'T';

			if (Name == "TrailingStopLimit")
				return 'S';

			return  char.MinValue;
		}

		public static string ToString(char c)
		{
			switch (c)
			{
				case '1':
					return "Market";
				case '2':
					return "Limit";
				case '3':
					return "Stop";
				case '4':
					return "StopLimit";
				case '5':
					return "MarketOnClose";
				case '6':
					return "WithOrWithout";
				case '7':
					return "LimitOrBetter";
				case '8':
					return "LimitWithOrWithout";
				case '9':
					return "OnBasis";
				case 'A':
					return "OnClose";
				case 'B':
					return "LimitOnClose";
				case 'C':
					return "ForexMarket";
				case 'D':
					return "PreviouslyQuoted";
				case 'E':
					return "PreviouslyIndicated";
				case 'F':
					return "ForexLimit";
				case 'G':
					return "ForexSwap";
				case 'H':
					return "ForexPreviouslyQuoted";
				case 'I':
					return "Funari";
				case 'J':
					return "MIT";
				case 'K':
					return "MarketWithLeftoverAsLimit";
				case 'L':
					return "PreviousFundValuationPoint";
				case 'M':
					return "NextFundValuationPoint";
				case 'T':
					return "TrailingStop";
				case 'S':
					return "TrailingStopLimit";

				default:
					return "Unknown";
			}
		}

		public static OrdType FromFIX(char ordType)
		{
			switch (ordType)
			{
				case '1':
					return OrdType.Market;
				case '2':
					return OrdType.Limit;
				case '3':
					return OrdType.Stop;
				case '4':
					return OrdType.StopLimit;
				case '5':
					return OrdType.MarketOnClose;
				case '6':
					return OrdType.WithOrWithout;
				case '7':
					return OrdType.LimitOrBetter;
				case '8':
					return OrdType.LimitWithOrWithout;
				case '9':
					return OrdType.OnBasis;
				case 'A':
					return OrdType.OnClose;
				case 'B':
					return OrdType.LimitOnClose;
				case 'C':
					return OrdType.ForexMarket;
				case 'D':
					return OrdType.PreviouslyQuoted;
				case 'E':
					return OrdType.PreviouslyIndicated;
				case 'F':
					return OrdType.ForexLimit;
				case 'G':
					return OrdType.ForexSwap;
				case 'H':
					return OrdType.ForexPreviouslyQuoted;
				case 'I':
					return OrdType.Funari;
				case 'J':
					return OrdType.MIT;
				case 'K':
					return OrdType.MarketWithLeftoverAsLimit;
				case 'L':
					return OrdType.PreviousFundValuationPoint;
				case 'M':
					return OrdType.NextFundValuationPoint;
				case 'P':
					return OrdType.Pegged;
				case 'S':
					return OrdType.TrailingStopLimit;
				case 'T':
					return OrdType.TrailingStop;
				default:
					throw new ArgumentException("Error: " + (object)ordType);
			}
		}


		public static char ToFIX(OrdType ordType)
		{
			switch (ordType)
			{
				case OrdType.Market:
					return '1';
				case OrdType.Limit:
					return '2';
				case OrdType.Stop:
					return '3';
				case OrdType.StopLimit:
					return '4';
				case OrdType.MarketOnClose:
					return '5';
				case OrdType.WithOrWithout:
					return '6';
				case OrdType.LimitOrBetter:
					return '7';
				case OrdType.LimitWithOrWithout:
					return '8';
				case OrdType.OnBasis:
					return '9';
				case OrdType.OnClose:
					return 'A';
				case OrdType.LimitOnClose:
					return 'B';
				case OrdType.ForexMarket:
					return 'C';
				case OrdType.PreviouslyQuoted:
					return 'D';
				case OrdType.PreviouslyIndicated:
					return 'E';
				case OrdType.ForexLimit:
					return 'F';
				case OrdType.ForexSwap:
					return 'G';
				case OrdType.ForexPreviouslyQuoted:
					return 'H';
				case OrdType.Funari:
					return 'I';
				case OrdType.MIT:
					return 'J';
				case OrdType.MarketWithLeftoverAsLimit:
					return 'K';
				case OrdType.PreviousFundValuationPoint:
					return 'L';
				case OrdType.NextFundValuationPoint:
					return 'M';
				case OrdType.Pegged:
					return 'P';
				case OrdType.TrailingStop:
					return 'T';
				case OrdType.TrailingStopLimit:
					return 'S';
				default:
					throw new Exception("unknown: " + ((object)ordType).ToString());
			}
		}
	}
}
