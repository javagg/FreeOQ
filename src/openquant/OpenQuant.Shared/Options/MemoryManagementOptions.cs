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
                MemoryManagementXmlDocument doc = new MemoryManagementXmlDocument();
				doc.Load(this.configFile.FullName);
				this.PortfolioPerformanceEnabled = doc.Settings.PortfolioPerformanceEnabled.Value;
				this.PortfolioPerformancePnLCalculationEnabled = doc.Settings.PortfolioPerformancePnLCalculationEnabled.Value;
				this.PortfolioPerformanceDrawdownCalculationEnabled = doc.Settings.PortfolioPerformanceDrawdownCalculationEnabled.Value;
				this.RemoveOrders = doc.Settings.RemoveOrders.Value;
				this.PortfolioPerformanceUpdateOnIntervalEnabled = doc.Settings.PortfolioPerformanceUpdateOnIntervalEnabled.Value;
				this.PortfolioPerformanceUpdateInterval = doc.Settings.PortfolioPerformanceUpdateInterval.Value;
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
            MemoryManagementXmlDocument doc = new MemoryManagementXmlDocument();
			doc.Settings.PortfolioPerformanceEnabled.Value = this.PortfolioPerformanceEnabled;
			doc.Settings.PortfolioPerformancePnLCalculationEnabled.Value = this.PortfolioPerformancePnLCalculationEnabled;
			doc.Settings.PortfolioPerformanceDrawdownCalculationEnabled.Value = this.PortfolioPerformanceDrawdownCalculationEnabled;
			doc.Settings.RemoveOrders.Value = this.RemoveOrders;
			doc.Settings.PortfolioPerformanceUpdateOnIntervalEnabled.Value = this.PortfolioPerformanceUpdateOnIntervalEnabled;
			doc.Settings.PortfolioPerformanceUpdateInterval.Value = this.PortfolioPerformanceUpdateInterval;
			doc.Save(this.configFile.FullName);
		}
	}
}
