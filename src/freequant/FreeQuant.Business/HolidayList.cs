using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Business
{
	public class HolidayList : IEnumerable
	{
		private SortedList holidays;

		public int Count
		{
			get
			{
				return this.holidays.Count;
			}
		}

		public Holiday this[int index]
		{
			get
			{
				return this.holidays.GetByIndex(index) as Holiday;
			}
		}

		public Holiday this[DateTime date]
		{
			get
			{
				return this.holidays[date] as Holiday;
			}
		}

		public HolidayList()
		{
			this.holidays = new SortedList();
		}

		public void Add(Holiday holiday)
		{
			if (this.holidays.Contains(holiday.Date))
				throw new ApplicationException("" + holiday.Date);
			this.holidays.Add(holiday.Date, holiday);
		}

		public void Remove(Holiday holiday)
		{
			this.holidays.Remove(holiday.Date);
		}

		public void RemoveAt(int index)
		{
			this.Remove(this[index]);
		}

		public void Clear()
		{
			this.holidays.Clear();
		}

		public bool Contains(DateTime date)
		{
			return this.holidays.Contains(date);
		}

		public bool Contains(Holiday holiday)
		{
			return this.holidays.ContainsValue(holiday);
		}

		public IEnumerator GetEnumerator()
		{
			return this.holidays.Values.GetEnumerator();
		}
	}
}
