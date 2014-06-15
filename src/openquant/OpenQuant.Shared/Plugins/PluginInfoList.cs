using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Plugins
{
	public class PluginInfoList : ICollection
	{
		private SortedList<string, PluginInfo> plugins;

		public int Count
		{
			get
			{
				return this.plugins.Count;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public PluginInfoList()
		{
			this.plugins = new SortedList<string, PluginInfo>();
		}

		public void CopyTo(Array array, int index)
		{
			new List<PluginInfo>(this.plugins.Values).ToArray().CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.plugins.Values.GetEnumerator();
		}

		public bool Contains(PluginInfo plugin)
		{
			return this.plugins.ContainsKey(this.GetPluginKey(plugin));
		}

		public void Add(PluginInfo plugin)
		{
			this.plugins.Add(this.GetPluginKey(plugin), plugin);
		}

		public void Remove(PluginInfo plugin)
		{
			this.plugins.Remove(this.GetPluginKey(plugin));
		}

		public bool TryGet(ref PluginInfo plugin)
		{
			PluginInfo pluginInfo;
			if (!this.plugins.TryGetValue(this.GetPluginKey(plugin), out pluginInfo))
				return false;
			plugin = pluginInfo;
			return true;
		}

		public void Clear()
		{
			this.plugins.Clear();
		}

		private string GetPluginKey(PluginInfo plugin)
		{
			return string.Format("{0}, {1}", plugin.TypeName, plugin.AssemblyName);
		}
	}
}
