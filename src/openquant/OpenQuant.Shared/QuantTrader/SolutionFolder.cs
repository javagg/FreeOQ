namespace OpenQuant.Shared.QuantTrader
{
	public class SolutionFolder : PackageFolder
	{
		public string SolutionName
		{
			get
			{
				return this.Name;
			}
		}

		public AssemblyFile ScenarioAssembly
		{
			get
			{
				return this.GetEntry<AssemblyFile>("Scenario.dll");
			}
		}

		public ReferencesFolder References
		{
			get
			{
				return this.GetEntry<ReferencesFolder>("References");
			}
		}

		public MarketDataFile MarketData
		{
			get
			{
				return this.GetEntry<MarketDataFile>("marketdata.xml");
			}
		}

		public PropertiesFile Properties
		{
			get
			{
				return this.GetEntry<PropertiesFile>("properties.xml");
			}
		}

		public ProjectsFolder Projects
		{
			get
			{
				return this.GetEntry<ProjectsFolder>("Projects");
			}
		}
	}
}
