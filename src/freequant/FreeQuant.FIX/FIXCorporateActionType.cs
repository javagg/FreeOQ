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
				case 1:
					return "CashDividend";
				case 2:
					return "StockDividend";
				case 3:
					return "Split";
				case 4:
					return "RightsIssue";
				case 5:
					return "Merger";
				case 6:
					return "Acquisition";
				case 7:
					return "SpinOff";
				default:
					return "Not defined";
			}
		}
	}
}
