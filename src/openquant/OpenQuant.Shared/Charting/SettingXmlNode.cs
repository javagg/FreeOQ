using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Charting
{
	class SettingXmlNode : XmlNodeBase
	{
		private const string ATTR_NAME = "name";
		private const string ATTR_TYPE = "type";

		public override string NodeName
		{
			get
			{
				return "item";
			}
		}

		public string Name
		{
			get
			{
				return this.GetStringAttribute("name");
			}
			set
			{
				this.SetAttribute("name", value);
			}
		}

		public Type Type
		{
			get
			{
				return this.GetTypeAttribute("type");
			}
			set
			{
				this.SetAttribute("type", value);
			}
		}

		public string Value
		{
			get
			{
				return this.GetStringValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public SettingXmlNode() : base()
		{
		}
	}
}
