using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
	[Serializable]
	public class Trade : IDataObject, ISeriesObject
	{
		protected DateTime datetime;
		protected byte providerId;
		protected double price;
		protected int size;

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

		[PriceView]
		public double Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		[View]
		public int Size
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
		public Trade(){
		}
		public Trade(DateTime datetime, double price, int size)
		{
			this.datetime = datetime;
			this.price = price;
			this.size = size;
		}

		public Trade(Trade trade) : this(trade.datetime, trade.price, trade.size)
		{
			this.providerId = trade.providerId;
		}
		//    public override string ToString()
		//    {
		//      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(1080), (object) this.datetime, (object) this.price, (object) this.size);
		//    }
		public virtual ISeriesObject NewInstance()
		{
			return (ISeriesObject)new Trade();
		}

		public virtual object Clone()
		{
			return (object)new Trade(this);
		}

		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(this.datetime.Ticks);
			writer.Write(this.price);
			writer.Write(this.size);
			writer.Write(this.providerId);
		}

		public virtual void ReadFrom(BinaryReader reader)
		{
			this.datetime = new DateTime(reader.ReadInt64());
			this.price = reader.ReadDouble();
			this.size = reader.ReadInt32();
			this.providerId = reader.ReadByte();
		}
	}
}
