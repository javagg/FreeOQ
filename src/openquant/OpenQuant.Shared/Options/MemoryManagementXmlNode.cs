using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class MemoryManagementXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "settings";
			}
		}

		public BooleanValueXmlNode PortfolioPerformanceEnabled
		{
			get
			{
				return this.GetBooleanValueNode("portfolio_performance_enabled");
			}
		}

		public BooleanValueXmlNode PortfolioPerformancePnLCalculationEnabled
		{
			get
			{
				return this.GetChildNode<BooleanValueXmlNode>("portfolio_performance_pnl_calculation_enabled");
			}
		}

		public BooleanValueXmlNode PortfolioPerformanceDrawdownCalculationEnabled
		{
			get
			{
				return this.GetChildNode<BooleanValueXmlNode>("portfolio_performance_drawdown_calculation_enabled");
			}
		}

		public BooleanValueXmlNode RemoveOrders
		{
			get
			{
				return this.GetChildNode<BooleanValueXmlNode>("remove_orders");
			}
		}

		public BooleanValueXmlNode PortfolioPerformanceUpdateOnIntervalEnabled
		{
			get
			{
				return this.GetChildNode<BooleanValueXmlNode>("interval_update_enabled");
			}
		}

		public Int64ValueXmlNode PortfolioPerformanceUpdateInterval
		{
			get
			{
				return this.GetChildNode<Int64ValueXmlNode>("update_interval");
			}
		}

		public MemoryManagementXmlNode() : base()
		{
     
		}
	}
}
