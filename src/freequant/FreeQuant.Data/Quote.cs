using System;
using System.IO;

namespace FreeQuant.Data
{
	[Serializable]
	public class Quote : IDataObject, ISeriesObject
	{
        private const byte VERSION = 2;
        protected DateTime datetime;
		protected byte providerId;
		protected double bid;
		protected double ask;
		protected int bidSize;
		protected int askSize;

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

		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
			set
			{
				this.datetime = value;
			}
		}

		[View]
		public int BidSize
		{
			get
			{
				return this.bidSize;
			}
			set
			{
				this.bidSize = value;
			}
		}

		[PriceView]
		public double Bid
		{
			get
			{
				return this.bid;
			}
			set
			{
				this.bid = value;
			}
		}

		[PriceView]
		public double Ask
		{
			get
			{
				return this.ask;
			}
			set
			{
				this.ask = value;
			}
		}

		[View]
		public int AskSize
		{
			get
			{
				return this.askSize;
			}
			set
			{
				this.askSize = value;
			}
		}

		public Quote() : this(DateTime.MinValue, 0.0, 0, 0.0, 0)
		{
		}

		public Quote(DateTime datetime, double bid, int bidSize, double ask, int askSize)
		{
			this.datetime = datetime;
			this.bid = bid;
			this.ask = ask;
			this.bidSize = bidSize;
			this.askSize = askSize;
			this.providerId = 0;
		}

		public Quote(Quote quote) : this(quote.datetime, quote.bid, quote.bidSize, quote.ask, quote.askSize)
		{
			this.providerId = quote.providerId;
		}

		public virtual void WriteTo(BinaryWriter writer)
		{
            writer.Write(VERSION);
			writer.Write(this.datetime.Ticks);
			writer.Write(this.bid);
			writer.Write(this.ask);
			writer.Write(this.bidSize);
			writer.Write(this.askSize);
			writer.Write(this.providerId);
		}

		public virtual void ReadFrom(BinaryReader reader)
		{
            byte version = reader.ReadByte(); 
			switch (version)
			{
				case 1:
					this.datetime = new DateTime(reader.ReadInt64());
					this.bid = Math.Round((double)reader.ReadSingle(), 4);
					this.bidSize = reader.ReadInt32();
					this.ask = Math.Round((double)reader.ReadSingle(), 4);
					this.askSize = reader.ReadInt32();
					this.providerId = reader.ReadByte();
					break;
				case 2:
					this.datetime = new DateTime(reader.ReadInt64());
					this.bid = reader.ReadDouble();
					this.ask = reader.ReadDouble();
					this.bidSize = reader.ReadInt32();
					this.askSize = reader.ReadInt32();
					this.providerId = reader.ReadByte();
					break;
				default:
                    throw new Exception("Invalid version: " + version);
			}
		}

		public virtual ISeriesObject NewInstance()
		{
			return new Quote();
		}

		public virtual object Clone()
		{
			return new Quote(this);
		}
	}
}
