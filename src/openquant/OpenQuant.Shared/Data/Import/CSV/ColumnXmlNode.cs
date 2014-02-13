using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class ColumnXmlNode : XmlNodeBase
	{
		private const string ATTR_TYPE = "type";
		private const string ATTR_FORMAT = "format";

		public override string NodeName
		{
			get
			{
				return "column";
			}
		}

		public ColumnType ColumnType
		{
			get
			{
				return (ColumnType)this.GetEnumAttribute("type", typeof(ColumnType));
			}
			set
			{
				this.SetAttribute("type", (Enum)value);
			}
		}

		public string Format
		{
			get
			{
				return this.GetStringAttribute("format");
			}
			set
			{
				this.SetAttribute("format", value);
			}
		}

		public ColumnXmlNode() : base()
		{
		}
	}
}
