using System;
using System.IO;

namespace FreeQuant.Data
{
	public abstract class SeriesObject : ISeriesObject
	{
		protected DateTime datetime;

		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
		}

		protected SeriesObject(DateTime datetime)
		{
			this.datetime = datetime;
		}

		public virtual void ReadFrom(BinaryReader reader)
		{
			this.datetime = new DateTime(reader.ReadInt64());
		}

		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(this.datetime.Ticks);
		}

		public abstract ISeriesObject NewInstance();
		public abstract object Clone();
	}
}
