using OpenQuant.API.Logs;
using System;
using System.Collections.Generic;

namespace OpenQuant.Shared.Logs
{
	public class StrategyLogManager : IStrategyLogManager
	{
		private SortedList<string, SortedList<string, StrategyLogList>> table;
		private List<StrategyLogList> array;
		private object syncRoot;

		internal StrategyLogList[] LogLists
		{
			get
			{
				return this.array.ToArray();
			}
		}

		internal object SyncRoot
		{
			get
			{
				return this.syncRoot;
			}
		}

		internal event EventHandler Cleared;
		internal event EventHandler<StrategyLogEventArgs> LogAdded;
		internal event EventHandler<StrategyLogItemEventArgs> LogItemAdded;

		public StrategyLogManager()
		{
			this.table = new SortedList<string, SortedList<string, StrategyLogList>>();
			this.array = new List<StrategyLogList>();
			this.syncRoot = new object();
		}

		internal void OnLogAdded(StrategyLogList list, StrategyLog log)
		{
			if (this.LogAdded == null)
				return;
			this.LogAdded((object)list, new StrategyLogEventArgs(log));
		}

		internal void OnLogItemAdded(StrategyLog log, StrategyLogItem item)
		{
			if (this.LogItemAdded == null)
				return;
			this.LogItemAdded((object)log, new StrategyLogItemEventArgs(item));
		}

		public void Clear()
		{
			lock (this.syncRoot)
			{
				this.table.Clear();
				this.array.Clear();
				if (this.Cleared == null)
					return;
				this.Cleared((object)this, EventArgs.Empty);
			}
		}

		public IStrategyLogList GetLogList(string strategyName, string symbol)
		{
			lock (this.syncRoot)
			{
				SortedList<string, StrategyLogList> local_0;
				if (!this.table.TryGetValue(strategyName, out local_0))
				{
					local_0 = new SortedList<string, StrategyLogList>();
					this.table.Add(strategyName, local_0);
				}
				StrategyLogList local_1;
				if (!local_0.TryGetValue(symbol, out local_1))
				{
					local_1 = new StrategyLogList(this, strategyName, symbol);
					local_0.Add(symbol, local_1);
					this.array.Add(local_1);
				}
				return (IStrategyLogList)local_1;
			}
		}
	}
}
