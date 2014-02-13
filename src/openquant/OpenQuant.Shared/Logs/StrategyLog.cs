using OpenQuant.API.Logs;
using FreeQuant;
using System;
using System.Collections.Generic;

namespace OpenQuant.Shared.Logs
{
  class StrategyLog : IStrategyLog
  {
    private StrategyLogManager manager;
    private SortedList<DateTime, object> items;

    internal StrategyLogList List { get; private set; }

    internal string Name { get; private set; }

    internal IEnumerable<StrategyLogItem> Items
    {
      get
      {
        foreach (KeyValuePair<DateTime, object> keyValuePair in this.items)
          yield return new StrategyLogItem(this, keyValuePair.Key, keyValuePair.Value);
      }
    }

    internal int Count
    {
      get
      {
        return this.items.Count;
      }
    }

    internal StrategyLogItem Last
    {
      get
      {
        int index = this.items.Count - 1;
        return new StrategyLogItem(this, this.items.Keys[index], this.items.Values[index]);
      }
    }

    internal object this[DateTime datetime]
    {
      get
      {
        return this.items[datetime];
      }
    }

    public StrategyLog(StrategyLogManager manager, StrategyLogList list, string name)
    {
      this.manager = manager;
      this.List = list;
      this.Name = name;
      this.items = new SortedList<DateTime, object>();
    }

    internal bool Contains(DateTime datetime)
    {
      return this.items.ContainsKey(datetime);
    }

    public void Add(DateTime datetime, object value)
    {
      lock (this.manager.SyncRoot)
      {
        this.items[datetime] = value;
        this.manager.OnLogItemAdded(this, new StrategyLogItem(this, datetime, value));
      }
    }

    public void Add(object value)
    {
      this.Add(Clock.Now, value);
    }
  }
}
