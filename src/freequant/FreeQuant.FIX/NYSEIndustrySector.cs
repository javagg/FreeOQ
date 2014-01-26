namespace FreeQuant.FIX
{
	public class NYSEIndustrySector : FIXStringField
	{
		public const string Industrials = "100";
		public const string Transportation = "200";
		public const string Utilities = "300";
		public const string FinanceRealEstate = "400";

		public NYSEIndustrySector(string val) : base(10101, val)
		{
		}
	}
}
