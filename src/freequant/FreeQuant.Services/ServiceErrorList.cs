using System;
using System.Collections;

namespace FreeQuant.Services
{
	public class ServiceErrorList : ICollection, IEnumerable
	{
		private ArrayList serviceErrors;

		public int Count
		{
			get
			{
				return this.serviceErrors.Count;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.serviceErrors.IsSynchronized;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.serviceErrors.SyncRoot;
			}
		}

		internal ServiceErrorList()
		{
			this.serviceErrors = new ArrayList();
		}

		public void CopyTo(Array array, int index)
		{
			this.serviceErrors.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.serviceErrors.GetEnumerator();
		}

		internal void Add(ServiceError error)
		{
			this.serviceErrors.Add(error);
		}
	}
}
