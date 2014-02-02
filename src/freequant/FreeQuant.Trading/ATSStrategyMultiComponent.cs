using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class ATSStrategyMultiComponent : StrategyBaseMultiComponent
	{
		[Browsable(false)]
		public ATSStrategy Strategy
		{
			get
			{
				return this.StrategyBase as ATSStrategy;
			}
		}
	}
}
