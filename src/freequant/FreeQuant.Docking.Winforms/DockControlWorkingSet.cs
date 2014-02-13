using System;
using System.Collections;
using System.Collections.Generic;

namespace FreeQuant.Docking.WinForms
{
	class DockControlWorkingSet : IEnumerable<DockControl>, IEnumerable
	{
		private Dictionary<Type, Dictionary<DockControlKey, DockControl>> table;

		public DockControlWorkingSet()
		{
			this.table = new Dictionary<Type, Dictionary<DockControlKey, DockControl>>();
		}

		public void Add(Type type, object key, DockControl control)
		{
			Dictionary<DockControlKey, DockControl> dictionary;
			if (!this.table.TryGetValue(type, out dictionary))
			{
				dictionary = new Dictionary<DockControlKey, DockControl>();
				this.table.Add(type, dictionary);
			}
			dictionary.Add(new DockControlKey(key), control);
		}

		public void Remove(Type type, object key)
		{
			Dictionary<DockControlKey, DockControl> dictionary;
			if (!this.table.TryGetValue(type, out dictionary))
				return;
			dictionary.Remove(new DockControlKey(key));
			if (dictionary.Count != 0)
				return;
			this.table.Remove(type);
		}

		public bool TryGetControl(Type type, object key, out DockControl control)
		{
			Dictionary<DockControlKey, DockControl> dictionary;
			if (this.table.TryGetValue(type, out dictionary))
				return dictionary.TryGetValue(new DockControlKey(key), out control);
			control = null;
			return false;
		}

		public IEnumerator<DockControl> GetEnumerator()
		{
			foreach (Dictionary<DockControlKey, DockControl> dictionary in this.table.Values)
			{
				foreach (DockControl dockControl in dictionary.Values)
					yield return dockControl;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
