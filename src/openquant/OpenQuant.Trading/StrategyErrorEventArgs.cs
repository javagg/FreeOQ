using System;

namespace OpenQuant.Trading
{
	public class StrategyErrorEventArgs : EventArgs
	{
		public StrategyError Error { get; private set; }

		public StrategyErrorEventArgs(StrategyError error)
		{
			this.Error = error;
		}
	}
}
