using System;
using System.Collections;

namespace FreeQuant.Data
{
	public class DataArray : IEnumerable
	{
		protected int stopRecurant;
		protected double divisor;
		protected ArrayList list;

		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		public IDataObject this[int index]
		{
			get
			{
				return this.list[index] as IDataObject;
			}
		}

		public DateTime FirstDateTime
		{
			get
			{
				if (this.Count != 0)
					return this[0].DateTime;
				else
					return new DateTime();
			}
		}

		public DateTime LastDateTime
		{
			get
			{
				if (this.Count != 0)
					return this[this.Count - 1].DateTime;
				else
					return new DateTime(0);
			}
		}

		public event EventHandler Cleared;

		public DataArray()
		{
			this.stopRecurant = 25;
			this.divisor = 10.0;
			this.list = new ArrayList();
		}

		public void Add(IDataObject obj)
		{
			this.list.Add(obj);
		}

		public void Insert(int index, IDataObject obj)
		{
			this.list.Insert(index, obj);
		}

		public void Remove(IDataObject obj)
		{
			this.list.Remove(obj);
		}

		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		public void Clear()
		{
			this.list.Clear();
		}

		public bool Contains(IDataObject obj)
		{
			return this.list.Contains(obj);
		}

		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		public int GetIndex(DateTime datetime)
		{
			if (this.Count == 0) return -1;

			DateTime dateTime1 = this[0].DateTime;
			DateTime dateTime2 = this[this.Count - 1].DateTime;
			if (dateTime1 > datetime || dateTime2 < datetime)
				return -1;
			else
				return this.GetIndex(datetime, 0, this.Count - 1);
		}

		public int GetIndex(DateTime datetime, int index1, int index2)
		{
			long ticks1 = this[index1].DateTime.Ticks;
			long ticks2 = this[index2].DateTime.Ticks;
			long ticks3 = datetime.Ticks;
			int index3 = ticks2 == ticks1 ? (index1 + index2) / 2 : (int)((long)index1 + (long)(index2 - index1) * ((ticks3 - ticks1) / (ticks2 - ticks1)));
			if (this[index3].DateTime == datetime)
				return index3;
			if (index2 - index3 < this.stopRecurant || index3 - index1 < this.stopRecurant)
			{
				for (int index4 = index2; index4 >= index1; --index4)
				{
					if (this[index4].DateTime < datetime)
						return index4;
				}
				return -1;
			}
			else
			{
				int num = (int)((double)(index2 - index1) / this.divisor);
				int index4 = Math.Max(index1, index3 - num);
				if (this[index4].DateTime > datetime)
					return this.GetIndex(datetime, index1, index4);
				int index5 = Math.Min(index2, index3 + num);
				if (this[index5].DateTime < datetime)
					return this.GetIndex(datetime, index5, index2);
				else
					return this.GetIndex(datetime, index4, index5);
			}
		}
	}
}
