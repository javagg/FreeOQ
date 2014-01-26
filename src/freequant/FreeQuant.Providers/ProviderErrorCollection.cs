using System;
using System.Collections;

namespace FreeQuant.Providers
{
	public class ProviderErrorCollection : ICollection
	{
		private ArrayList errors;

		public bool IsSynchronized
		{
			get
			{
				return this.errors.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.errors.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.errors.SyncRoot;
			}
		}

		public ProviderError this [int index]
		{
			get
			{
				return this.errors[index] as ProviderError;
			}
		}

		internal ProviderErrorCollection()
		{
			this.errors = new ArrayList();
		}

		public void CopyTo(Array array, int index)
		{
			this.errors.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.errors.GetEnumerator();
		}

		internal void Add(ProviderError error)
		{
			this.errors.Add(error);
		}
	}
}
