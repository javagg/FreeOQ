namespace OpenQuant.Shared.QuantTrader
{
	public class Package : PackageFolder
	{
		public const string FILE_EXTENSION = ".qtp";

		public string PackageName
		{
			get
			{
				return this.Name;
			}
		}

		public SolutionsFolder Solutions
		{
			get
			{
				return this.GetEntry<SolutionsFolder>("Solutions");
			}
		}
	}
}
