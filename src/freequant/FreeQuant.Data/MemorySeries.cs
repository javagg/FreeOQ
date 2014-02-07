using System;
using System.Collections;
using System.Collections.Generic;

namespace FreeQuant.Data
{
	public class MemorySeries<TValue> : IDataSeries
	{
		private SortedList<DateTime, TValue> list; 

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
				return this.list[datetime];
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
				return this.list.Values[index];
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
				return this.list.Keys[this.list.Count-1];
			}
		}

		public MemorySeries(string name, string description)
		{
			this.Name = name;
			this.Description = description;
			this.list = new SortedList<DateTime, TValue>();
		}

		public MemorySeries(string name) : this(name, string.Empty)
		{
		}

		public MemorySeries() : this("MemorySeries")
		{
		}

		public void Add(DateTime datetime, object value)
		{
			this.list[datetime] = (TValue)value;
		}

		public void Update(DateTime datetime, object value)
		{
			this.Add(datetime, value);
		}

		public void Update(int index, object value)
		{
			this.Update(this.list.Keys[index], value);
		}

		public bool Contains(DateTime datetime)
		{
			return this.list.ContainsKey(datetime);
		}

		public int IndexOf(DateTime datetime)
		{
			return this.list.IndexOfKey(datetime);
		}

		// TODO: read
		public int IndexOf(DateTime datetime, SearchOption option)
		{
			int index = 0;
			int begini = 0;
			int endi = this.list.Count - 1;
			bool flag = true;
			while (flag)
			{
				if (endi < begini)
					return -1;
				index = (begini + endi) / 2;
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
							endi = index - 1;
							continue;
						}
						else
						{
							begini = index + 1;
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
							endi = index - 1;
							continue;
						}
						else if (this.list.Keys[index] < datetime)
						{
							begini = index + 1;
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
							begini = index + 1;
							continue;
						}
						else
						{
							endi = index - 1;
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
