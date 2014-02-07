using FreeQuant.Data;
using System;

namespace FreeQuant.Series
{
	[Serializable]
	public class DailySeries : BarSeries
	{
		public new Daily First
		{
			get
			{
				return this[0] as Daily;
			}
		}

		public new Daily Last
		{
			get
			{
				return this[this.Count - 1] as Daily;
			}
		}

		public new Daily this[int index]
		{
			get
			{
				return base[index] as Daily;
			}
		}

		public new Daily this[DateTime date]
		{
			get
			{
				return base[date] as Daily;
			}
		}

		public new Daily this[DateTime date, EIndexOption option]
		{
			get
			{
				return base[date, option] as Daily;
			}
		}

		public DailySeries(string name, string title) : base(name, title)
		{
			this.fArray = new MemorySeries<Daily>();
		}

		public DailySeries(string name) : this(name, string.Empty)
		{
		}

		public DailySeries() : this(string.Empty)
		{
		}

		public new DailySeries Clone()
		{
			return base.Clone() as DailySeries;
		}

		public new DailySeries Clone(int index1, int index2)
		{
			return base.Clone(index1, index2) as DailySeries;
		}

		public new DailySeries Clone(DateTime datetime1, DateTime datetime2)
		{
			return base.Clone(datetime1, datetime2) as DailySeries;
		}

		public new DailySeries Shift(int offset)
		{
			DailySeries dailySeries = new DailySeries(this.Name, this.Title);
			int num = 0;
			if (offset < 0)
				num += Math.Abs(offset);
			for (int index1 = num; index1 < this.Count; ++index1)
			{
				int index2 = index1 + offset;
				if (index2 < this.Count)
				{
					DateTime dateTime = this.GetDateTime(index2);
					dailySeries.Add(new Bar((Bar)this[index1])
					{
						DateTime = dateTime
					});
				}
				else
					break;
			}
			return dailySeries;
		}

		public new Daily Ago(int n)
		{
			int index = this.Count - 1 - n;
			if (index < 0)
				throw new ArgumentException("n out of range");
			return this[index];
		}
	}
}
