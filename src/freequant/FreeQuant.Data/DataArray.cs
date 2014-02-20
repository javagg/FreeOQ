using System;
using System.Collections;

namespace FreeQuant.Data
{
	public class DataArray : IEnumerable
	{
		protected int fStopRecurant;
		protected double fDivisor;
		protected ArrayList fList;

		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		public IDataObject this[int index]
		{
			get
			{
				return this.fList[index] as IDataObject;
			}
		}

		public DateTime FirstDateTime
		{
			get
			{
                return this.Count != 0 ? this[0].DateTime : new DateTime(0);
			}
		}

		public DateTime LastDateTime
		{
			get
			{
                return this.Count != 0 ? this[this.Count - 1].DateTime : new DateTime(0);
			}
		}

		public event EventHandler Cleared;

		public DataArray()
		{
			this.fStopRecurant = 25;
			this.fDivisor = 10.0;
			this.fList = new ArrayList();
		}

		public void Add(IDataObject obj)
		{
			this.fList.Add(obj);
		}

		public void Insert(int index, IDataObject obj)
		{
			this.fList.Insert(index, obj);
		}

		public void Remove(IDataObject obj)
		{
			this.fList.Remove(obj);
		}

		public void RemoveAt(int index)
		{
			this.fList.RemoveAt(index);
		}

		public void Clear()
		{
			this.fList.Clear();
            this.EmitCleared();
		}

		public bool Contains(IDataObject obj)
		{
			return this.fList.Contains(obj);
		}

		public IEnumerator GetEnumerator()
		{
			return this.fList.GetEnumerator();
		}

		public int GetIndex(DateTime datetime)
		{
			if (this.Count == 0)
                return -1;

			DateTime dt1 = this[0].DateTime;
			DateTime dt2 = this[this.Count-1].DateTime;
			if (datetime < dt1 || dt2 < datetime)
                return -1;

			return this.GetIndex(datetime, 0, this.Count - 1);
		}

		public int GetIndex(DateTime datetime, int index1, int index2)
		{
			long beginTick = this[index1].DateTime.Ticks;
			long endTick = this[index2].DateTime.Ticks;
			long ticks3 = datetime.Ticks;
			int index3 = endTick == beginTick ? (index1 + index2) / 2 : (int)((long)index1 + (long)(index2 - index1) * ((ticks3 - beginTick) / (endTick - beginTick)));
			if (this[index3].DateTime == datetime)
				return index3;
			if (index2 - index3 < this.fStopRecurant || index3 - index1 < this.fStopRecurant)
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
				int num = (int)((double)(index2 - index1) / this.fDivisor);
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

        private void EmitCleared()
        {
            if (this.Cleared != null)
                this.Cleared( this, EventArgs.Empty);
        }
	}
}
