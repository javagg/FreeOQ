using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
	[Serializable]
	public class Daily : Bar
	{
		public DateTime Date
		{
			get
			{
				return this.DateTime;
			}
			set
			{
				this.DateTime = value.Date;
			}
		}

		public Daily(DateTime date, double open, double high, double low, double close, long volume, long openInt) : base(BarType.Time, 86400, date.Date, date.Date.AddSeconds(86399.0), open, high, low, close, volume, openInt)
		{
		}

		public Daily(DateTime date, double open, double high, double low, double close, long volume) : this(date, open, high, low, close, volume, 0)
		{
		}

		public Daily(Daily daily) : base(daily)
		{
		}

		public Daily() : base()
		{
			this.endTime = DateTime.MinValue;
		}

		public override ISeriesObject NewInstance()
		{
			return new Daily();
		}

		public override void WriteTo(BinaryWriter writer)
		{
			base.WriteTo(writer);
			writer.Write((byte)1);
		}

		public override void ReadFrom(BinaryReader reader)
		{
			base.ReadFrom(reader);
			//      int num = (int) reader.ReadByte();
		}

		public override object Clone()
		{
			return new Daily(this);
		}
	}
}
