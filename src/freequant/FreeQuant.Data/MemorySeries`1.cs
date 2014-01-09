using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
	public class MemorySeries<TValue> : IDataSeries, IEnumerable
	{
		private string name;
		private string description;
		private SortedList<DateTime, TValue> jy6GVFJfR;

		public string Name
		{
			get
			{
				return this.name; 
			}
		}

		public string Description
		{
			get
			{
				return this.description; 
			}
			set
			{
				this.description = value;
			}
		}

		public int Count
		{
			get
			{
				return this.jy6GVFJfR.Count;
			}
		}

		public object this [DateTime datetime]
		{
			get
			{
				return (object)this.jy6GVFJfR[datetime];
			}
			set
			{
				this.jy6GVFJfR[datetime] = (TValue)value;
			}
		}

		public object this [int index]
		{
			get
			{
				return (object)this.jy6GVFJfR.Values[index];
			}
		}

		public DateTime FirstDateTime
		{
			get
			{
				return this.jy6GVFJfR.Keys[0];
			}
		}

		public DateTime LastDateTime
		{
			get
			{
				return this.jy6GVFJfR.Keys[this.jy6GVFJfR.Count - 1];
			}
		}

		public MemorySeries(string name, string description) :base()
		{
			this.name = name;
			this.description = description;
			this.jy6GVFJfR = new SortedList<DateTime, TValue>();
		}

		public MemorySeries(string name) : this(name, "")
		{

		}

		public MemorySeries()
		{
		}

		public void Add(DateTime datetime, object obj)
		{
			this.jy6GVFJfR[datetime] = (TValue)obj;
		}

		public void Update(DateTime datetime, object obj)
		{
			this.Add(datetime, obj);
		}

		public void Update(int index, object obj)
		{
			this.Update(this.jy6GVFJfR.Keys[index], obj);
		}

		public bool Contains(DateTime datetime)
		{
			return this.jy6GVFJfR.ContainsKey(datetime);
		}

		public int IndexOf(DateTime datetime)
		{
			return this.jy6GVFJfR.IndexOfKey(datetime);
		}

		public int IndexOf(DateTime datetime, SearchOption option)
		{
			int index = 0;
			int num1 = 0;
			int num2 = this.jy6GVFJfR.Count - 1;
			bool flag = true;
			while (flag)
			{
				if (num2 < num1)
					return -1;
				index = (num1 + num2) / 2;
				switch (option)
				{
					case SearchOption.Prev:
						if (this.jy6GVFJfR.Keys[index] <= datetime && (index == this.jy6GVFJfR.Count - 1 || this.jy6GVFJfR.Keys[index + 1] > datetime))
						{
							flag = false;
							continue;
						}
						else if (this.jy6GVFJfR.Keys[index] > datetime)
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
						if (this.jy6GVFJfR.Keys[index] == datetime)
						{
							flag = false;
							continue;
						}
						else if (this.jy6GVFJfR.Keys[index] > datetime)
						{
							num2 = index - 1;
							continue;
						}
						else if (this.jy6GVFJfR.Keys[index] < datetime)
						{
							num1 = index + 1;
							continue;
						}
						else
							continue;
					case SearchOption.Next:
						if (this.jy6GVFJfR.Keys[index] >= datetime && (index == 0 || this.jy6GVFJfR.Keys[index - 1] < datetime))
						{
							flag = false;
							continue;
						}
						else if (this.jy6GVFJfR.Keys[index] < datetime)
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
			return this.jy6GVFJfR.Keys[index];
		}

		public void Remove(DateTime datetime)
		{
			this.jy6GVFJfR.Remove(datetime);
		}

		public void RemoveAt(int index)
		{
			this.jy6GVFJfR.RemoveAt(index);
		}

		public void Clear()
		{
			this.jy6GVFJfR.Clear();
		}

		public void Flush()
		{
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this.jy6GVFJfR.Values.GetEnumerator();
		}
	}
}
