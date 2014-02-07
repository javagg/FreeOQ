using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class MetaStrategyComponent : MetaStrategyBaseComponent
	{
		[Browsable(false)]
		public MetaStrategy MetaStrategy
		{
			get
			{
				return this.MetaStrategyBase as MetaStrategy;
			}
		}

		public MetaStrategyComponent() : base()
		{

		}
	}
}
