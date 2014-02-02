using System;

namespace OpenQuant.Trading
{
	public class StrategyError
	{
		public DateTime DateTime { get; private set; }
		public Exception Exception { get; private set; }

		public StrategyError(DateTime datetime, Exception exception)
		{
			this.DateTime = datetime;
			this.Exception = exception;
		}
	}
}
