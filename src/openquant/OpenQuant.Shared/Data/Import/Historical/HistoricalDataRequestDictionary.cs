using FreeQuant.Providers;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Import.Historical
{
	internal class HistoricalDataRequestDictionary
	{
		private Dictionary<string, HistoricalDataRequest> dictionary;

		public int Count
		{
			get
			{
				lock (this)
					return this.dictionary.Count;
			}
		}

		public IEnumerable<HistoricalDataRequest> Values
		{
			get
			{
				lock (this)
					return (IEnumerable<HistoricalDataRequest>)this.dictionary.Values;
			}
		}

		public HistoricalDataRequestDictionary()
		{
			this.dictionary = new Dictionary<string, HistoricalDataRequest>();
		}

		public void Add(string requestId, HistoricalDataRequest request)
		{
			lock (this)
				this.dictionary.Add(requestId, request);
		}

		public void Remove(string requestId)
		{
			lock (this)
				this.dictionary.Remove(requestId);
		}

		public void Clear()
		{
			lock (this)
				this.dictionary.Clear();
		}
	}
}
