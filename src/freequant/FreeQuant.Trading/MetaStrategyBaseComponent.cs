using FreeQuant.Instruments;
using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class MetaStrategyBaseComponent : MultiInstrumentComponent, IMetaStrategyComponent
	{
		private MetaStrategyBase metaStrategyBase;

		[Browsable(false)]
		public MetaStrategyBase MetaStrategyBase
		{
			get
			{
				return this.metaStrategyBase;
			}
			internal set
			{
				if (this.metaStrategyBase != null)
					this.Disconnect();
				this.metaStrategyBase = value;
				if (this.metaStrategyBase != null)
				{
					this.Connect();
				}
			}
		}

		[Browsable(false)]
		public Portfolio Portfolio
		{
			get
			{
				return this.metaStrategyBase.Portfolio;
			}
		}

		public MetaStrategyBaseComponent() : base()
		{
		}

		public virtual void OnPortfolioValueChanged(Portfolio portfolio)
		{
		}
	}
}
