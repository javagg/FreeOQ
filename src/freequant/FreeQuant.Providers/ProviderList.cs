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

		internal void AddProvider(IProvider provider)
		{
			if (this.providerNames.ContainsKey(provider.Name))
				throw new ArgumentException("Already Added: " + provider.Name);
			if (this.providerIds.Contains(provider.Id))
				throw new ArgumentException("Already Added: " + provider.Id);
			this.providerNames.Add(provider.Name, provider);
			this.providerIds.Add(provider.Id, provider);
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
