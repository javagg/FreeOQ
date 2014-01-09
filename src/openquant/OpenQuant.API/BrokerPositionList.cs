using System;
using System.Collections;

namespace OpenQuant.API
{
	public class BrokerPositionList : ICollection, IEnumerable
	{
		private FreeQuant.Providers.BrokerPosition[] positions;

		public int Count
		{
			get
			{
				return this.positions.Length;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.positions.IsSynchronized;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.positions.SyncRoot;
			}
		}

		public BrokerPosition this [int index]
		{
			get
			{
				if (index >= 0 && index < this.positions.Length)
					return new BrokerPosition(this.positions[index]);
				else
					return (BrokerPosition)null;
			}
		}

		internal BrokerPositionList(FreeQuant.Providers.BrokerPosition[] positions)
		{
			this.positions = positions;
		}

		public void CopyTo(Array array, int index)
		{
			ArrayList arrayList = new ArrayList();
			foreach (BrokerPosition brokerPosition in this)
				arrayList.Add((object)brokerPosition);
			arrayList.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			foreach (FreeQuant.Providers.BrokerPosition brokerPosition in this.positions)
				yield return (object)new BrokerPosition(brokerPosition);
		}
	}
}
