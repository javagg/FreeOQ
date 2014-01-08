using System;

namespace FreeQuant.Business
{
	public class Calendar
	{
		private string name;
		private string description;
		private HolidayList holidays;

		public string Name
		{
			get
			{
				return this.name; 
			}
			set
			{
				this.name = value;
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

		public HolidayList Holidays
		{
			get
			{
				return this.holidays; 
			}
		}

		public Calendar()
		{
			this.Init();
		}

		public Calendar(string name, string description)
		{
			this.name = name;
			this.description = description;
			this.Init();
		}

		public Calendar(string name)
		{
			this.name = name;
			this.Init();
		}

		public void Init()
		{
			this.holidays = new HolidayList();
		}

		public void AddHoliday(Holiday holiday)
		{
			this.holidays.Add(holiday);
		}

		public void AddHoliday(DateTime date, string name, string description)
		{
			this.holidays.Add(new Holiday(date, name, description));
		}

		public void AddHoliday(DateTime date, string name)
		{
			this.holidays.Add(new Holiday(date, name));
		}

		public Holiday GetHoliday(DateTime date)
		{
			return this.holidays[date];
		}

		public static bool IsWeekend(DateTime date)
		{
			return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
		}

		public bool IsHoliday(DateTime date)
		{
			return !this.IsBusinessDay(date);
		}

		public bool IsBusinessDay(DateTime date)
		{
			return !Calendar.IsWeekend(date) && this.GetHoliday(date) == null;
		}

		public int GetNBusinessDays(DateTime date1, DateTime date2)
		{
			int num = 0;
			for (DateTime date = date1; date <= date2; date = date.AddDays(1.0))
			{
				if (this.IsBusinessDay(date))
					++num;
			}
			return num;
		}

		public static int GetNWeekends(DateTime date1, DateTime date2)
		{
			int num = 0;
			for (DateTime date = date1; date <= date2; date = date.AddDays(1.0))
			{
				if (Calendar.IsWeekend(date))
					++num;
			}
			return num;
		}

		public int GetNHolidays(DateTime date1, DateTime date2)
		{
			int num = 0;
			for (DateTime date = date1; date <= date2; date = date.AddDays(1.0))
			{
				if (this.IsHoliday(date))
					++num;
			}
			return num;
		}

		public DateTime GetNextBusinessDay(DateTime date)
		{
			do
			{
				date = date.AddDays(1.0);
			}
			while (!this.IsBusinessDay(date));
			return date;
		}

		public static DateTime GetNextWeekend(DateTime date)
		{
			do
			{
				date = date.AddDays(1.0);
			}
			while (!Calendar.IsWeekend(date));
			return date;
		}

		public static DateTime GetNextNonWeekend(DateTime date)
		{
			while (Calendar.IsWeekend(date))
				date = date.AddDays(1.0);
			return date;
		}

		public static DateTime GetPrevNonWeekend(DateTime date)
		{
			while (Calendar.IsWeekend(date))
				date = date.AddDays(-1.0);
			return date;
		}

		public DateTime GetNextHoliday(DateTime date)
		{
			do
			{
				date = date.AddDays(1.0);
			}
			while (!this.IsHoliday(date));
			return date;
		}

		public DateTime GetPrevBusinessDay(DateTime date)
		{
			do
			{
				date = date.AddDays(-1.0);
			}
			while (!this.IsBusinessDay(date));
			return date;
		}

		public static DateTime GetPrevWeekend(DateTime date)
		{
			do
			{
				date = date.AddDays(-1.0);
			}
			while (!Calendar.IsWeekend(date));
			return date;
		}

		public DateTime GetPrevHoliday(DateTime date)
		{
			do
			{
				date = date.AddDays(-1.0);
			}
			while (!this.IsHoliday(date));
			return date;
		}
	}
}
