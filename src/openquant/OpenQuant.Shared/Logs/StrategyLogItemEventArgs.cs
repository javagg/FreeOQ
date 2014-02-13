using System;

namespace OpenQuant.Shared.Logs
{
	class StrategyLogItemEventArgs : EventArgs
	{
		public StrategyLogItem Item { get; private set; }

		public StrategyLogItemEventArgs(StrategyLogItem item)
		{
			this.Item = item;
		}
	}
}
