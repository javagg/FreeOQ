using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.IO;

namespace FreeQuant.FIXData
{
	public class News : FIXNews, IDataObject, ISeriesObject
	{
		private const byte PGEwNxMr8 = (byte)1;

		public byte ProviderId { get; set; }

		public DateTime DateTime
		{
			get
			{
				return this.OrigTime;
			}
			set
			{
				this.OrigTime = value;
			}
		}

		[View]
		public override string Headline
		{
			get
			{
				return base.Headline;
			}
			set
			{
				base.Headline = value;
			}
		}

		public News()
		{
			this.ProviderId = 0;
		}

		public ISeriesObject NewInstance()
		{
			return new News();
		}

		public void WriteTo(BinaryWriter writer)
		{
			writer.Write((byte)1);
			writer.Write(this.DateTime.Ticks);
			writer.Write(this.ProviderId);
			FIXGroupStreamer.WriteTo(writer, (FIXGroup)this);
		}

		public void ReadFrom(BinaryReader reader)
		{
			int num = (int)reader.ReadByte();
			this.DateTime = new DateTime(reader.ReadInt64());
			this.ProviderId = reader.ReadByte();
			FIXGroupStreamer.ReadFrom(reader, (FIXGroup)this);
		}

		public object Clone()
		{
			return this;
		}
	}
}
