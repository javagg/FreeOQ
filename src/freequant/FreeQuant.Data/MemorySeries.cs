using System;
using System.Collections;
using System.Collections.Generic;

namespace FreeQuant.Data
{
	public class MemorySeries<TValue> : IDataSeries, IEnumerable
	{
		private SortedList<DateTime, TValue> list =  new SortedList<DateTime, TValue>(); 

		public string Name { get; private set; }
		public string Description { get; set; }
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		public object this[DateTime datetime]
		{
			get
			{
				return (object)this.list[datetime];
			}
			set
			{
				this.list[datetime] = (TValue)value;
			}
		}

		public object this[int index]
		{
			get
			{
				return (object)this.list.Values[index];
			}
		}

		public DateTime FirstDateTime
		{
			get
			{
				return this.list.Keys[0];
			}
		}

		public DateTime LastDateTime
		{
			get
			{
				return this.list.Keys[this.list.Count - 1];
			}
		}

		public MemorySeries(string name = null, string description = null)
		{
			this.Name = name ?? String.Empty;
			this.Description = description ?? String.Empty;
		}

//		public MemorySeries(string name) : this(name, String.Empty)
//		{
//		}
//
//		public MemorySeries()
//		{
//		}

		public void Add(DateTime datetime, TValue value)
		{
			this.list[datetime] = value;
		}

		public void Add(DateTime datetime, object obj)
		{
			this.list[datetime] = (TValue)obj;
		}

		public void Update(DateTime datetime, object obj)
		{
			this.Add(datetime, obj);
		}

		public void Update(int index, object obj)
		{
			this.Update(this.list.Keys[index], obj);
		}

		public bool Contains(DateTime datetime)
		{
			return this.list.ContainsKey(datetime);
		}

		public int IndexOf(DateTime datetime)
		{
			return this.list.IndexOfKey(datetime);
		}

		public int IndexOf(DateTime datetime, SearchOption option)
		{
			int index = 0;
			int num1 = 0;
			int num2 = this.list.Count - 1;
			bool flag = true;
			while (flag)
			{
				if (num2 < num1)
					return -1;
				index = (num1 + num2) / 2;
				switch (option)
				{
					case SearchOption.Prev:
						if (this.list.Keys[index] <= datetime && (index == this.list.Count - 1 || this.list.Keys[index + 1] > datetime))
						{
							flag = false;
							continue;
						}
						else if (this.list.Keys[index] > datetime)
						{
							num2 = index - 1;
							continue;
						}
						else
						{
							num1 = index + 1;
							continue;
						}
					case SearchOption.Exact:
						if (this.list.Keys[index] == datetime)
						{
							flag = false;
							continue;
						}
						else if (this.list.Keys[index] > datetime)
						{
							num2 = index - 1;
							continue;
						}
						else if (this.list.Keys[index] < datetime)
						{
							num1 = index + 1;
							continue;
						}
						else
							continue;
					case SearchOption.Next:
						if (this.list.Keys[index] >= datetime && (index == 0 || this.list.Keys[index - 1] < datetime))
						{
							flag = false;
							continue;
						}
						else if (this.list.Keys[index] < datetime)
						{
							num1 = index + 1;
							continue;
						}
						else
						{
							num2 = index - 1;
							continue;
						}
					default:
						continue;
				}
			}
			return index;
		}

		public DateTime DateTimeAt(int index)
		{
			return this.list.Keys[index];
		}

		public void Remove(DateTime datetime)
		{
			this.list.Remove(datetime);
		}

		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		public void Clear()
		{
			this.list.Clear();
		}

		public void Flush()
		{
		}

		public IEnumerator GetEnumerator()
		{
			return this.list.Values.GetEnumerator();
		}
	}
}
