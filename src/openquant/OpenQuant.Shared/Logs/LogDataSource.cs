using System.Collections.Generic;

namespace OpenQuant.Shared.Logs
{
	class LogDataSource<T> : ILogDataSource
	{
		private SortedList<T, object[]> data;
		private Dictionary<string, int> columnIndices;
		private object lockObject;
		private bool hasChanges;

		public int Count
		{
			get
			{
				lock (this.lockObject)
					return this.data.Count;
			}
		}

		public object this [int rowIndex, int columnIndex]
		{
			get
			{
				lock (this.lockObject)
					return this.data.Values[rowIndex][columnIndex];
			}
		}

		public LogDataSource()
		{
			this.data = new SortedList<T, object[]>();
			this.columnIndices = new Dictionary<string, int>();
			this.lockObject = new object();
			this.hasChanges = false;
		}

		public bool HasChanges(bool reset)
		{
			lock (this.lockObject)
			{
				bool local_0 = this.hasChanges;
				if (reset)
					this.hasChanges = false;
				return local_0;
			}
		}

		public void AddColumn(string columnName)
		{
			this.columnIndices.Add(columnName, this.columnIndices.Count);
		}

		public void Add(object key, string columnName, object value)
		{
			lock (this.lockObject)
			{
				int local_0;
				if (!this.columnIndices.TryGetValue(columnName, out local_0))
					return;
				T local_1 = (T)key;
				object[] local_2;
				if (!this.data.TryGetValue(local_1, out local_2))
				{
					local_2 = new object[this.columnIndices.Count];
					local_2[0] = (object)local_1;
					this.data.Add(local_1, local_2);
				}
				local_2[local_0] = value;
				this.hasChanges = true;
			}
		}
	}
}
