namespace OpenQuant.Shared.QuantTrader
{
	public class ProjectFolder : PackageFolder
	{
		public string ProjectName
		{
			get
			{
				return this.Name;
			}
		}

		public AssemblyFile StrategyAssembly
		{
			get
			{
				return this.GetEntry<AssemblyFile>("Strategy.dll");
			}
		}

		public InstrumentsFile Instruments
		{
			get
			{
				return this.GetEntry<InstrumentsFile>("instruments.xml");
			}
		}

		public PropertiesFile Properties
		{
			get
			{
				return this.GetEntry<PropertiesFile>("properties.xml");
			}
		}
	}
}
