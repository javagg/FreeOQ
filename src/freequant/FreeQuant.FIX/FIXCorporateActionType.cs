using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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

		public FIXCorporateActionType(int val) : base(10200, val)
		{
		}

		public static string ToString(int val)
		{
			switch (val)
			{
				case CashDividend:
					return "CashDividend";
				case StockDividend:
					return "StockDividend";
				case Split:
					return "Split";
				case RightsIssue:
					return "RightsIssue";
				case Merger:
					return "Merger";
				case Acquisition:
					return "Acquisition";
				case SpinOff:
					return "SpinOff";
				default:
					return "Not defined";
			}
		}
	}
}
