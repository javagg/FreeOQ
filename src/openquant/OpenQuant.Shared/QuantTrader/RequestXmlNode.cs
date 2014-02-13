using OpenQuant.Shared.Data;
using FreeQuant.Data;
using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.QuantTrader
{
	class RequestXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "request";
			}
		}

		public DataType DataType
		{
			get
			{
				return (DataType)this.GetEnumAttribute("type", typeof(DataType));
			}
			set
			{
				this.SetAttribute("type", (Enum)value);
			}
		}

		public EnumValueXmlNode<BarType> BarType
		{
			get
			{
				return this.GetEnumValueXmlNode<BarType>("bar_type");
			}
		}

		public Int64ValueXmlNode BarSize
		{
			get
			{
				return this.GetInt64ValueNode("bar_size");
			}
		}

		public RequestXmlNode() : base()
		{
		}
	}
}
