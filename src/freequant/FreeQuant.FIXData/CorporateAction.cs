using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.IO;

namespace FreeQuant.FIXData
{
	public class CorporateAction : FIXGroup, IDataObject, ISeriesObject
	{
		private const byte y6V3qyUUX = 1;

		public int CorporateActionType
		{
			get
			{
				return this.GetIntValue(10200);
			}
			set
			{
				this.SetIntValue(10200, value);
			}
		}

		public DateTime DeclaredDate
		{
			get
			{
				return this.GetDateTimeValue(10201);
			}
			set
			{
				this.SetDateTimeValue(10201, value);
			}
		}

		public DateTime ExDate
		{
			get
			{
				return this.GetDateTimeValue(230);
			}
			set
			{
				this.SetDateTimeValue(230, value);
			}
		}

		public DateTime RecordDate
		{
			get
			{
				return this.GetDateTimeValue(10202);
			}
			set
			{
				this.SetDateTimeValue(10202, value);
			}
		}

		public DateTime PayDate
		{
			get
			{
				return this.GetDateTimeValue(10203);
			}
			set
			{
				this.SetDateTimeValue(10203, value);
			}
		}

		public int DividendType
		{
			get
			{
				return this.GetIntValue(10204);
			}
			set
			{
				this.SetIntValue(10204, value);
			}
		}

		public int SplitType
		{
			get
			{
				return this.GetIntValue(10205);
			}
			set
			{
				this.SetIntValue(10205, value);
			}
		}

		public int RightsIssueType
		{
			get
			{
				return this.GetIntValue(10206);
			}
			set
			{
				this.SetIntValue(10206, value);
			}
		}

		public double NetAmount
		{
			get
			{
				return this.GetDoubleValue(10207);
			}
			set
			{
				this.SetDoubleValue(10207, value);
			}
		}

		public double GrossAmount
		{
			get
			{
				return this.GetDoubleValue(10208);
			}
			set
			{
				this.SetDoubleValue(10208, value);
			}
		}

		public double Percent
		{
			get
			{
				return this.GetDoubleValue(10210);
			}
			set
			{
				this.SetDoubleValue(10210, value);
			}
		}

		public double Ratio
		{
			get
			{
				return this.GetDoubleValue(10209);
			}
			set
			{
				this.SetDoubleValue(10209, value);
			}
		}

		public double AdjustmentFactor
		{
			get
			{
				return this.GetDoubleValue(10211);
			}
			set
			{
				this.SetDoubleValue(10211, value);
			}
		}

		[FIXField("15", EFieldOption.Optional)]
		public string Currency
		{
			get
			{
				return this.GetStringValue(15);
			}
			set
			{
				this.SetStringValue(15, value);
			}
		}

		public byte ProviderId { get; set; }

		public DateTime DateTime { get; set; }

		public ISeriesObject NewInstance()
		{
			return new CorporateAction();
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
			return  this;
		}
	}
}
