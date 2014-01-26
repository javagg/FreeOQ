using System;
using System.Collections;

namespace FreeQuant.Providers
{
	public class ProviderList : ICollection
	{
		private SortedList providerNames;
		private SortedList providerIds;

		public bool IsSynchronized
		{
			get
			{
				return this.providerNames.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.providerNames.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.providerNames.SyncRoot;
			}
		}

		public IProvider this[string name]
		{
			get
			{
				return this.providerNames[name] as IProvider;
			}
		}

		public IProvider this[byte id]
		{
			get
			{
				return this.providerIds[id] as IProvider;
			}
		}

		public ProviderList()
		{
			this.providerNames = new SortedList();
			this.providerIds = new SortedList();
		}

		public static implicit operator IProvider[](ProviderList list)
		{
			return new ArrayList(list.providerNames.Values).ToArray(typeof(IProvider)) as IProvider[];
		}

		public void CopyTo(Array array, int index)
		{
			this.providerNames.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.providerNames.Values.GetEnumerator();
		}

		internal void HH8tS7bFw(IProvider obj0)
		{
//      if (this.providerNames.ContainsKey((object) obj0.Name))
//        throw new ArgumentException(GojrKtfk5NMi1fou68.a17L2Y7Wnd(0) + obj0.Name);
//      if (this.providerIds.Contains((object) obj0.Id))
//        throw new ArgumentException(GojrKtfk5NMi1fou68.a17L2Y7Wnd(142) + (object) obj0.Id);
			this.providerNames.Add(obj0.Name, obj0);
			this.providerIds.Add(obj0.Id, obj0);
		}

		public bool Contains(string name)
		{
			return this.providerNames.ContainsKey(name); 
		}

		public bool Contains(byte id)
		{
			return this.providerIds.ContainsKey(id); 
		}

		public bool Contains(IProvider provider)
		{
			return this.providerNames.ContainsValue(provider);
		}
	}
}
