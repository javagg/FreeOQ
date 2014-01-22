using System;
using System.Collections;

namespace FreeQuant.Data
{
	public interface IDataSeries : IEnumerable
	{
		string Name { get; }
		string Description { get; set; }
		int Count { get; }
		object this[DateTime datetime] { get; set; }
		object this[int index] { get; }
		DateTime FirstDateTime { get; }
		DateTime LastDateTime { get; }
		void Add(DateTime datetime, object obj);
		void Update(DateTime datetime, object obj);
		void Update(int index, object obj);
		bool Contains(DateTime datetime);
		int IndexOf(DateTime datetime);
		int IndexOf(DateTime datetime, SearchOption option);
		DateTime DateTimeAt(int index);
		void Remove(DateTime datetime);
		void RemoveAt(int index);
		void Clear();
		void Flush();
	}
}
