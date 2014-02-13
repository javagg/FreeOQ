using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Charting
{
	class IndicatorTemplateXmlNode : XmlNodeBase
	{
		private const string ATTR_TYPE = "type";

		public IndicatorTemplateListXmlNode IndicatorTemplates
		{
			get
			{
				return (IndicatorTemplateListXmlNode)this.GetChildNode<IndicatorTemplateListXmlNode>();
			}
		}

		public SettingListXmlNode Settings
		{
			get
			{
				return (SettingListXmlNode)this.GetChildNode<SettingListXmlNode>();
			}
		}

		public override string NodeName
		{
			get
			{
				return "Indicator";
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

		public IndicatorTemplateXmlNode() : base()
		{
		}
	}
}
