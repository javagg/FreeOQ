using OpenQuant.API.Logs;
using System.Collections.Generic;

namespace OpenQuant.Shared.Logs
{
	class StrategyLogList : IStrategyLogList
	{
		private StrategyLogManager manager;
		private SortedList<string, StrategyLog> logs;
		private List<StrategyLog> array;

		internal string StrategyName { get; private set; }

		internal string Symbol { get; private set; }

		internal StrategyLog[] Logs
		{
			get
			{
				return this.array.ToArray();
			}
		}

		public IStrategyLog this [string name]
		{
			get
			{
				lock (this.manager.SyncRoot)
				{
					StrategyLog local_0;
					if (!this.logs.TryGetValue(name, out local_0))
					{
						local_0 = new StrategyLog(this.manager, this, name);
						this.logs.Add(name, local_0);
						this.array.Add(local_0);
						this.manager.OnLogAdded(this, local_0);
					}
					return (IStrategyLog)local_0;
				}
			}
		}

		public IStrategyLog this [string logName, string logCategory]
		{
			get
			{
				return this[string.Format("{0}.{1}", logCategory, logName)];
			}
		}

		public StrategyLogList(StrategyLogManager manager, string strategyName, string symbol)
		{
			this.manager = manager;
			this.StrategyName = strategyName;
			this.Symbol = symbol;
			this.logs = new SortedList<string, StrategyLog>();
			this.array = new List<StrategyLog>();
		}
	}
}
