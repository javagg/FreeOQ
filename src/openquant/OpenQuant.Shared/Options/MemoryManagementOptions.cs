using FreeQuant.Execution;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.Options
{
	[OptionsNode("Memory Management", typeof(MemoryManagementPanel))]
	public class MemoryManagementOptions : OptionsBase
	{
		private FileInfo configFile;

		public bool PortfolioPerformanceEnabled { get; set; }

		public bool PortfolioPerformancePnLCalculationEnabled { get; set; }

		public bool PortfolioPerformanceDrawdownCalculationEnabled { get; set; }

		public long PortfolioPerformanceUpdateInterval { get; set; }

		public bool PortfolioPerformanceUpdateOnIntervalEnabled { get; set; }

		public bool RemoveOrders
		{
			get
			{
				return OrderManager.RemoveDoneOrders;
			}
			set
			{
				OrderManager.RemoveDoneOrders = value;
			}
		}

		public MemoryManagementOptions(FileInfo configFile)
		{
			this.configFile = configFile;
		}

		protected override void OnLoad()
		{
			if (this.configFile.Exists)
			{
				MemoryManagementXmlDocument managementXmlDocument = new MemoryManagementXmlDocument();
				((XmlDocument)managementXmlDocument).Load(this.configFile.FullName);
				this.PortfolioPerformanceEnabled = managementXmlDocument.Settings.PortfolioPerformanceEnabled.Value;
				this.PortfolioPerformancePnLCalculationEnabled = managementXmlDocument.Settings.PortfolioPerformancePnLCalculationEnabled.Value;
				this.PortfolioPerformanceDrawdownCalculationEnabled = managementXmlDocument.Settings.PortfolioPerformanceDrawdownCalculationEnabled.Value;
				this.RemoveOrders = managementXmlDocument.Settings.RemoveOrders.Value;
				this.PortfolioPerformanceUpdateOnIntervalEnabled = managementXmlDocument.Settings.PortfolioPerformanceUpdateOnIntervalEnabled.Value;
				this.PortfolioPerformanceUpdateInterval = managementXmlDocument.Settings.PortfolioPerformanceUpdateInterval.Value;
			}
			else
			{
				this.PortfolioPerformanceEnabled = true;
				this.PortfolioPerformancePnLCalculationEnabled = true;
				this.PortfolioPerformanceDrawdownCalculationEnabled = true;
				this.RemoveOrders = false;
				this.PortfolioPerformanceUpdateOnIntervalEnabled = false;
				this.PortfolioPerformanceUpdateInterval = 1;
			}
		}

		protected override void OnSave()
		{
			MemoryManagementXmlDocument managementXmlDocument = new MemoryManagementXmlDocument();
			managementXmlDocument.Settings.PortfolioPerformanceEnabled.Value = this.PortfolioPerformanceEnabled;
			managementXmlDocument.Settings.PortfolioPerformancePnLCalculationEnabled.Value = this.PortfolioPerformancePnLCalculationEnabled;
			managementXmlDocument.Settings.PortfolioPerformanceDrawdownCalculationEnabled.Value = this.PortfolioPerformanceDrawdownCalculationEnabled;
			managementXmlDocument.Settings.RemoveOrders.Value = this.RemoveOrders;
			managementXmlDocument.Settings.PortfolioPerformanceUpdateOnIntervalEnabled.Value = this.PortfolioPerformanceUpdateOnIntervalEnabled;
			managementXmlDocument.Settings.PortfolioPerformanceUpdateInterval.Value = this.PortfolioPerformanceUpdateInterval;
			((XmlDocument)managementXmlDocument).Save(this.configFile.FullName);
		}
	}
}
