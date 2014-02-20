using System;
using System.Drawing;
using System.IO;

namespace FreeQuant.Data
{
	[Serializable]
	public class Bar : IDataObject, ISeriesObject
	{
        private const byte VERSION = 2;
        protected byte providerId;
		protected BarType barType;
		protected Color color;
		protected bool isComplete;
		protected long size;
		protected long openInt;
		protected long volume;
		protected DateTime beginTime;
		protected DateTime endTime;
		protected double high;
		protected double low;
		protected double open;
		protected double close;

		public double Average
		{
			get
			{
				return (this.High + this.Low + this.Open + this.Close) / 4;
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

		public DateTime BeginTime
		{
			get
			{
				return this.beginTime;
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

		[View]
		public TimeSpan Duration
		{
			get
			{
				return this.EndTime - this.beginTime;
			}
		}

		[View]
		public virtual DateTime EndTime
		{
			get
			{
                if (this.endTime != DateTime.MinValue)
				{
					return this.endTime;
				}
				if (this.barType == BarType.Time && this.size > 0)
				{
					return this.beginTime.AddSeconds(this.size);
				}
				throw new InvalidOperationException();
			}
			
			set
			{
				this.endTime = value;
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

		public double Median
		{
			get
			{
				return (this.High + this.Low) / 2;
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

		public byte ProviderId
		{
			get
			{
				return this.providerId;
			}
			
			set
			{
				this.providerId = value;
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

		public double Typical
		{
			get
			{
				return (this.High + this.Low + this.Close) / 3;
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

		public double Weighted
		{
			get
			{
				return (this.High + this.Low + 2 * this.Close) / 4;
			}
		}

		public double this [int barData]
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

		public double this [BarData barData]
		{
			get
			{
				return this[(int)barData];
			}
		}

		public Bar() : this(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0, 0)
		{
		}

		public Bar(Bar bar) : this(bar.barType, bar.size, bar.beginTime, bar.endTime, bar.open, bar.high, bar.low, bar.close, bar.volume, bar.openInt)
		{
			this.providerId = bar.providerId;
			this.color = bar.color;
			this.isComplete = bar.isComplete;
		}

		public Bar(DateTime datetime, double open, double high, double low, double close, long volume, long size) : this(BarType.Time, size, datetime, datetime.AddSeconds(size), open, high, low, close, volume, 0)
		{
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
			this.providerId = 0;
			this.color = Color.Empty;
			this.isComplete = false;
		}

		public virtual object Clone()
		{
			return new Bar(this);
		}

		public double GetPrice(BarPrice option)
		{
			double result = 0.0;
			switch (option)
			{
				case BarPrice.High:
					result = this.High;
					break;
				case BarPrice.Low:
					result = this.Low;
					break;
				case BarPrice.Open:
					result = this.Open;
					break;
				case BarPrice.Close:
					result = this.Close;
					break;
				case BarPrice.Median:
					result = this.Median;
					break;
				case BarPrice.Typical:
					result = this.Typical;
					break;
				case BarPrice.Weighted:
					result = this.Weighted;
					break;
			}
			return result;
		}

		public virtual ISeriesObject NewInstance()
		{
			return new Bar();
		}

		public virtual void ReadFrom(BinaryReader reader)
		{
            byte version = reader.ReadByte(); 
			switch (version)
			{
				case 1:
					this.beginTime = new DateTime(reader.ReadInt64());
					this.endTime = new DateTime(reader.ReadInt64());
					this.barType = (BarType)reader.ReadByte();
					this.size = reader.ReadInt64();
					this.high = Math.Round((double)reader.ReadSingle(), 4);
					this.low = Math.Round((double)reader.ReadSingle(), 4);
					this.open = Math.Round((double)reader.ReadSingle(), 4);
					this.close = Math.Round((double)reader.ReadSingle(), 4);
					this.volume = reader.ReadInt64();
					this.openInt = reader.ReadInt64();
					this.providerId = reader.ReadByte();
					return;
				case 2:
					this.beginTime = new DateTime(reader.ReadInt64());
					this.endTime = new DateTime(reader.ReadInt64());
					this.barType = (BarType)reader.ReadByte();
					this.size = reader.ReadInt64();
					this.high = reader.ReadDouble();
					this.low = reader.ReadDouble();
					this.open = reader.ReadDouble();
					this.close = reader.ReadDouble();
					this.volume = reader.ReadInt64();
					this.openInt = reader.ReadInt64();
					this.providerId = reader.ReadByte();
					return;
				default:
                    throw new Exception("Version unknown" + version);
			}
		}

		public override string ToString()
		{
            return string.Format("BeginTime:{0}\nEndTime:{1}\nBarType:{2}\n...", new object[]
			{
				this.beginTime,
				this.endTime,
				this.barType,
				this.open,
				this.high,
				this.low,
				this.close,
				this.volume,
				this.openInt,
				this.size
			});
		}

		public virtual void WriteTo(BinaryWriter writer)
		{
            writer.Write(VERSION);
			writer.Write(this.beginTime.Ticks);
			writer.Write(this.endTime.Ticks);
			writer.Write((byte)this.barType);
			writer.Write(this.size);
			writer.Write(this.high);
			writer.Write(this.low);
			writer.Write(this.open);
			writer.Write(this.close);
			writer.Write(this.volume);
			writer.Write(this.openInt);
			writer.Write(this.providerId);
		}
	}
}