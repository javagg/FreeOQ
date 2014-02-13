using System;

namespace OpenQuant.Shared.Logs
{
	class StrategyLogItem
	{
		public StrategyLog Log { get; private set; }

		public DateTime DateTime { get; private set; }

		public object Value { get; private set; }

		public StrategyLogItem(StrategyLog log, DateTime datetime, object value)
		{
			this.Log = log;
			this.DateTime = datetime;
			this.Value = value;
		}
	}
}
