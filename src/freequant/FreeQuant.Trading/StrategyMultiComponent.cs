using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class StrategyMultiComponent : StrategyBaseMultiComponent
	{
		[Browsable(false)]
		public Strategy Strategy
		{
			get
			{
				return this.StrategyBase as Strategy;
			}
		}

		public StrategyMultiComponent() : base()
		{
		}
	}
}
