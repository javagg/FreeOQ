using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class DateXmlNode : XmlNodeBase
	{
		private const string ATTR_DATE_TYPE = "dateType";
		private const string ATTR_DATE = "date";

		public override string NodeName
		{
			get
			{
				return "date";
			}
		}

		public DateType DateType
		{
			get
			{
				return (DateType)this.GetEnumAttribute("dateType", typeof(DateType));
			}
			set
			{
				this.SetAttribute("dateType", (Enum)value);
			}
		}

		public DateTime Date
		{
			get
			{
				return this.GetDateTimeAttribute("date");
			}
			set
			{
				this.SetAttribute("date", value);
			}
		}

		public DateXmlNode() : base()
		{
		}
	}
}
