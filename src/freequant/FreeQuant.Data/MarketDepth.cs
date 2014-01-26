using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
	[Serializable]
	public class MarketDepth : ISeriesObject, IDataObject, IComparable, ICloneable
	{
		private const byte sP4fptbej = 3;
		private DateTime dateTime;
		private byte providerId;
		private string source;
		private int position;
		private MDOperation operation;
		private MDSide side;
		private double price;
		private int size;

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
				return this.dateTime; 
			}
			set
			{
				this.dateTime = value;
			}
		}

		[View]
		public string MarketMaker { get; set; }

		[View]
		public string Source
		{
			get
			{
				return this.source; 
			}
			set
			{
				this.source = value;
			}
		}

		[View]
		public int Position
		{
			get
			{
				return this.position; 
			}
			set
			{
				this.position = value;
			}
		}

		[View]
		public MDOperation Operation
		{
			get
			{
				return this.operation;
			}
			set
			{
				this.operation = value;
			}
		}

		[View]
		public MDSide Side
		{
			get
			{
				return this.side;
			}
			 set
			{
				this.side = value;
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

		
		public MarketDepth(DateTime datetime, byte providerId, string marketMaker, string source, int position, MDOperation operation, MDSide side, double price, int size)
		{
			this.dateTime = datetime;
			this.providerId = providerId;
			this.MarketMaker = marketMaker;
			this.source = source;
			this.position = position;
			this.operation = operation;
			this.side = side;
			this.price = price;
			this.size = size;
		}

		public MarketDepth()
		{
		}

		public MarketDepth(DateTime datetime, string marketMaker, int position, MDOperation operation, MDSide side, double price, int size) : this(datetime, 0, marketMaker, String.Empty, position, operation, side, price, size)
		{

		}

		public MarketDepth(MarketDepth marketDepth) : this(marketDepth.DateTime, marketDepth.ProviderId, marketDepth.MarketMaker, marketDepth.Source, marketDepth.Position, marketDepth.operation, marketDepth.side, marketDepth.Price, marketDepth.Size)
		{
		}

		public int CompareTo(object obj)
		{
			if (obj is MarketDepth)
				return this.price.CompareTo((obj as MarketDepth).price);
			else
				throw new ArgumentException("type is not MarketDepth: " + obj.GetType());
		}

		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write((byte)3);
			writer.Write(this.dateTime.Ticks);
			writer.Write(this.MarketMaker);
			writer.Write(this.source);
			writer.Write((byte)this.side);
			writer.Write(this.price);
			writer.Write(this.size);
			writer.Write(this.providerId);
			writer.Write(this.position);
			writer.Write((byte)this.operation);
		}

		
		public virtual void ReadFrom(BinaryReader reader)
		{
			byte num = reader.ReadByte();
			switch (num)
			{
				case (byte) 1:
					this.dateTime = new DateTime(reader.ReadInt64());
					this.MarketMaker = reader.ReadString();
					this.Source = reader.ReadString();
					this.Side = (MDSide)reader.ReadByte();
					this.Price = Math.Round((double)reader.ReadSingle(), 4);
					this.Size = reader.ReadInt32();
					this.ProviderId = reader.ReadByte();
					this.Position = -1;
					this.Operation = MDOperation.Undefined;
					break;
				case (byte) 2:
					this.dateTime = new DateTime(reader.ReadInt64());
					this.MarketMaker = reader.ReadString();
					this.source = reader.ReadString();
					this.side = (MDSide)reader.ReadByte();
					this.price = Math.Round((double)reader.ReadSingle(), 4);
					this.size = reader.ReadInt32();
					this.providerId = reader.ReadByte();
					this.position = reader.ReadInt32();
					this.operation = (MDOperation)reader.ReadByte();
					break;
				case (byte) 3:
					this.dateTime = new DateTime(reader.ReadInt64());
					this.MarketMaker = reader.ReadString();
					this.source = reader.ReadString();
					this.side = (MDSide)reader.ReadByte();
					this.price = reader.ReadDouble();
					this.size = reader.ReadInt32();
					this.providerId = reader.ReadByte();
					this.position = reader.ReadInt32();
					this.operation = (MDOperation)reader.ReadByte();
					break;
				default:
					throw new Exception("" + (object)num);
			}
		}

		public virtual ISeriesObject NewInstance()
		{
			return new MarketDepth();
		}

		public virtual object Clone()
		{
			return new MarketDepth(this);
		}
	}
}
