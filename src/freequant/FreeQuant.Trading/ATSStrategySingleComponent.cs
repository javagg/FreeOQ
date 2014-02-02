using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class ATSStrategySingleComponent : StrategyBaseSingleComponent
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
