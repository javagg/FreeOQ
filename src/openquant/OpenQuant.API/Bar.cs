using System;

namespace OpenQuant.API
{
	public class Bar
	{
		internal FreeQuant.Data.Bar bar;

		public DateTime DateTime
		{
			get
			{
				return this.bar.DateTime;
			}
		}

		public DateTime BeginTime
		{
			get
			{
				return this.bar.BeginTime;
			}
		}

		public virtual DateTime EndTime
		{
			get
			{
				return this.bar.EndTime;
			}
		}

		public TimeSpan Duration
		{
			get
			{
				return this.bar.Duration;
			}
		}

		public double Open
		{
			get
			{
				return this.bar.Open;
			}
		}

		public double High
		{
			get
			{
				return this.bar.High;
			}
		}

		public double Low
		{
			get
			{
				return this.bar.Low;
			}
		}

		public double Close
		{
			get
			{
				return this.bar.Close;
			}
		}

		public long Volume
		{
			get
			{
				return this.bar.Volume;
			}
		}

		public long OpenInt
		{
			get
			{
				return this.bar.OpenInt;
			}
		}

		public long Size
		{
			get
			{
				return this.bar.Size;
			}
		}

		public bool IsComplete
		{
			get
			{
				return this.bar.IsComplete;
			}
		}

		public BarType Type
		{
			get
			{
				return EnumConverter.Convert(this.bar.BarType);
			}
		}

		public double Median
		{
			get
			{
				return this.bar.Median;
			}
		}

		public double Typical
		{
			get
			{
				return this.bar.Typical;
			}
		}

		public double Weighted
		{
			get
			{
				return this.bar.Weighted;
			}
		}

		public double Average
		{
			get
			{
				return this.bar.Average;
			}
		}

		public double this[BarData barData]
		{
			get
			{
				switch (barData)
				{
					case BarData.Close:
						return this.bar.Close;
					case BarData.Open:
						return this.bar.Open;
					case BarData.High:
						return this.bar.High;
					case BarData.Low:
						return this.bar.Low;
					case BarData.Median:
						return this.bar.Median;
					case BarData.Typical:
						return this.bar.Typical;
					case BarData.Weighted:
						return this.bar.Weighted;
					case BarData.Average:
						return this.bar.Average;
					case BarData.Volume:
						return (double)this.bar.Volume;
					case BarData.OpenInt:
						return (double)this.bar.OpenInt;
					default:
						return double.NaN;
				}
			}
		}

		public Bar(DateTime dateTime, double open, double high, double low, double close, long volume, long size)
		{
			this.bar = new FreeQuant.Data.Bar(dateTime, open, high, low, close, volume, size);
		}

		internal Bar(FreeQuant.Data.Bar bar)
		{
			this.bar = bar;
		}

		public override string ToString()
		{
			return this.bar.ToString();
		}
	}
}
