using OpenQuant.Shared.Data;
using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class DataXmlNode : XmlNodeBase
	{
		private const string ATTR_DATA_TYPE = "dataType";
		private const string ATTR_BAR_SIZE = "barSize";
		private const string ATTR_BAR_DATETIME = "barDateTime";

		public override string NodeName
		{
			get
			{
				return "data";
			}
		}

		public DataType DataType
		{
			get
			{
				return (DataType)this.GetEnumAttribute("dataType", typeof(DataType));
			}
			set
			{
				this.SetAttribute("dataType", (Enum)value);
			}
		}

		public long BarSize
		{
			get
			{
				return this.GetInt64Attribute("barSize");
			}
			set
			{
				this.SetAttribute("barSize", value);
			}
		}

		public BarDateTime BarDateTime
		{
			get
			{
				if (this.ContainsAttribute("barDateTime"))
					return (BarDateTime)this.GetEnumAttribute("barDateTime", typeof(BarDateTime));
				else
					return BarDateTime.BeginTime;
			}
			set
			{
				this.SetAttribute("barDateTime", (Enum)value);
			}
		}

		public DataXmlNode() : base()
		{
		}
	}
}
