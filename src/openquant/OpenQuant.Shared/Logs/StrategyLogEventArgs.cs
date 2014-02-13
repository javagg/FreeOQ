using System;

namespace OpenQuant.Shared.Logs
{
	class StrategyLogEventArgs : EventArgs
	{
		public StrategyLog Log { get; private set; }

		public StrategyLogEventArgs(StrategyLog log)
		{
			this.Log = log;
		}
	}
}
