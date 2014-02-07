using System;

namespace FreeQuant.Trading
{
	public class StrategyEventArgs : EventArgs
	{
		public StrategyBase Strategy { get; private set; }

		public StrategyEventArgs(StrategyBase strategy) : base()
		{
			this.Strategy = strategy;
		}
	}
}
