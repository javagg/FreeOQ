using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class StrategySingleComponent : StrategyBaseSingleComponent
	{
		[Browsable(false)]
		public Strategy Strategy
		{
			get
			{
				return this.StrategyBase as Strategy;
			}
		}
	}
}
