using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.IO;

namespace FreeQuant.FIXData
{
	public class Fundamental : FIXGroup, IDataObject, ISeriesObject
	{
		private const byte sc1R9Co0v = 1;
		public double EarningsPerShare
		{
			get
			{
				return this.GetDoubleValue(10300);
			}
			set
			{
				this.SetDoubleValue(10300, value);
			}
		}

		public double CashPerShare
		{
			get
			{
				return this.GetDoubleValue(10302);
			}
			set
			{
				this.SetDoubleValue(10302, value);
			}
		}

		public double RevenuePerShare
		{
			get
			{
				return this.GetDoubleValue(10303);
			}
			set
			{
				this.SetDoubleValue(10303, value);
			}
		}

		public double DebtPerShare
		{
			get
			{
				return this.GetDoubleValue(10304);
			}
			set
			{
				this.SetDoubleValue(10304, value);
			}
		}

		public double CashFlowPerShare
		{
			get
			{
				return this.GetDoubleValue(10305);
			}
			set
			{
				this.SetDoubleValue(10305, value);
			}
		}

		public double InterestPaymentPerShare
		{
			get
			{
				return this.GetDoubleValue(10306);
			}
			set
			{
				this.SetDoubleValue(10306, value);
			}
		}

		public byte ProviderId { get; set; }
		public DateTime DateTime { get; set; }

		public ISeriesObject NewInstance()
		{
			return new Fundamental();
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
