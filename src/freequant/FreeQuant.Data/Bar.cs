using System;
using System.Drawing;
using System.IO;

namespace FreeQuant.Data
{
	[Serializable]
	public class Bar : IDataObject, ISeriesObject
	{
		protected DateTime beginTime;
		protected DateTime endTime;
		protected double high;
		protected double low;
		protected double open;
		protected double close;
		protected long volume;
		protected long openInt;
		protected long size;
		protected bool isComplete;
		protected Color color;
		protected BarType barType;

		public byte ProviderId { get; set; }
		public DateTime DateTime
		{
			get
			{
				return this.beginTime;
			}
			set
			{
				this.beginTime = value;
			}
		}

		public DateTime BeginTime
		{
			get
			{
				return this.beginTime;
			}
		}

		[View]
		public virtual DateTime EndTime
		{
			get
			{
				if (!(this.endTime == DateTime.MinValue))
					return this.endTime;
				if (this.barType == BarType.Time && this.size > 0L)
					return this.beginTime.AddSeconds((double)this.size);
				else
					throw new InvalidOperationException();// throw new InvalidOperationException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(192));
			}
     
			set
			{
				this.endTime = value;
			}
		}

		[View]
		public TimeSpan Duration
		{
			get
			{
				return this.EndTime - this.beginTime;
			}
		}

		[PriceView]
		public double Open
		{
			get
			{
				return this.open;
			}
			set
			{
				this.open = value;
			}
		}

		[PriceView]
		public double High
		{
			get
			{
				return this.high;
			}
			set
			{
				this.high = value;
			}
		}

		[PriceView]
		public double Low
		{
			get
			{
				return this.low;
			}
			set
			{
				this.low = value;
			}
		}

		[PriceView]
		public double Close
		{
			get
			{
				return this.close;
			}
			set
			{
				this.close = value;
			}
		}

		[View]
		public long Volume
		{
			get
			{
				return this.volume;
			}
			set
			{
				this.volume = value;
			}
		}

		public long OpenInt
		{
			get
			{
				return this.openInt;
			}
			set
			{
				this.openInt = value;
			}
		}

		[View]
		public long Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}

		public bool IsComplete
		{
			get
			{
				return this.isComplete;
			}
			set
			{
				this.isComplete = value;
			}
		}

		[View]
		public BarType BarType
		{
			get
			{
				return this.barType;
			}
			set
			{
				this.barType = value;
			}
		}

		public double Median
		{
			get
			{
				return (this.High + this.Low) / 2.0;
			}
		}

		public double Typical
		{
			get
			{
				return (this.High + this.Low + this.Close) / 3.0;
			}
		}

		public double Weighted
		{
			get
			{
				return (this.High + this.Low + 2.0 * this.Close) / 4.0;
			}
		}

		public double Average
		{
			get
			{
				return (this.High + this.Low + this.Open + this.Close) / 4.0;
			}
		}

		public Color Color
		{
			get
			{
				return this.color;
			}
			set
			{
				this.color = value;
			}
		}

		public double this[int barData]
		{
			get
			{
				switch (barData)
				{
					case 0:
						return this.Close;
					case 1:
						return this.Open;
					case 2:
						return this.High;
					case 3:
						return this.Low;
					case 4:
						return this.Median;
					case 5:
						return this.Typical;
					case 6:
						return this.Weighted;
					case 7:
						return (double)this.volume;
					case 8:
						return (double)this.openInt;
					case 9:
						return this.Average;
					default:
						return double.NaN;
				}
			}
		}

		public double this[BarData barData]
		{
			get
			{
				return this[(int)barData];
			}
		}

		public Bar(BarType barType, long size, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
		{
			this.barType = barType;
			this.size = size;
			this.beginTime = beginTime;
			this.endTime = endTime;
			this.open = open;
			this.high = high;
			this.low = low;
			this.close = close;
			this.volume = volume;
			this.openInt = openInt;
			this.ProviderId = 0;
			this.color = Color.Empty;
			this.isComplete = false;
		}

		public Bar(DateTime datetime, double open, double high, double low, double close, long volume, long size) : this(BarType.Time, size, datetime, datetime.AddSeconds(size), open, high, low, close, volume, 0)
		{
		}

		public Bar(Bar bar) : this(bar.barType, bar.size, bar.beginTime, bar.endTime, bar.open, bar.high, bar.low, bar.close, bar.volume, bar.openInt)
		{
			this.ProviderId = bar.ProviderId;
			this.color = bar.color;
			this.isComplete = bar.isComplete;
		}

		public Bar() : this(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0, 0)
		{
		}

		public double GetPrice(BarPrice option)
		{
			double num = 0.0;
			switch (option)
			{
				case BarPrice.High:
					num = this.High;
					break;
				case BarPrice.Low:
					num = this.Low;
					break;
				case BarPrice.Open:
					num = this.Open;
					break;
				case BarPrice.Close:
					num = this.Close;
					break;
				case BarPrice.Median:
					num = this.Median;
					break;
				case BarPrice.Typical:
					num = this.Typical;
					break;
				case BarPrice.Weighted:
					num = this.Weighted;
					break;
			}
			return num;
		}

		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write((byte)2);
			writer.Write(this.BeginTime.Ticks);
			writer.Write(this.EndTime.Ticks);
			writer.Write((byte)this.BarType);
			writer.Write(this.Size);
			writer.Write(this.High);
			writer.Write(this.Low);
			writer.Write(this.Open);
			writer.Write(this.Close);
			writer.Write(this.Volume);
			writer.Write(this.OpenInt);
			writer.Write(this.ProviderId);
		}

		public virtual void ReadFrom(BinaryReader reader)
		{
			byte num = reader.ReadByte();
			switch (num)
			{
				case (byte) 1:
					this.beginTime = new DateTime(reader.ReadInt64());
					this.EndTime = new DateTime(reader.ReadInt64());
					this.BarType = (BarType)reader.ReadByte();
					this.Size = reader.ReadInt64();
					this.High = Math.Round((double)reader.ReadSingle(), 4);
					this.Low = Math.Round((double)reader.ReadSingle(), 4);
					this.Open = Math.Round((double)reader.ReadSingle(), 4);
					this.Close = Math.Round((double)reader.ReadSingle(), 4);
					this.Volume = reader.ReadInt64();
					this.OpenInt = reader.ReadInt64();
					this.ProviderId = reader.ReadByte();
					break;
				case (byte) 2:
					this.beginTime = new DateTime(reader.ReadInt64());
					this.EndTime = new DateTime(reader.ReadInt64());
					this.barType = (BarType)reader.ReadByte();
					this.size = reader.ReadInt64();
					this.high = reader.ReadDouble();
					this.low = reader.ReadDouble();
					this.open = reader.ReadDouble();
					this.close = reader.ReadDouble();
					this.volume = reader.ReadInt64();
					this.openInt = reader.ReadInt64();
					this.ProviderId = reader.ReadByte();
					break;
				default:
					throw new Exception("Version doesn't Match. Version: " + num);
			}
		}

		public virtual ISeriesObject NewInstance()
		{
			return new Bar();
		}

		public virtual object Clone()
		{
			return new Bar(this);
		}
	}
}
