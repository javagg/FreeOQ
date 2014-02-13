using FreeQuant.Xml;

namespace OpenQuant.Shared.Charting
{
	class PadTemplateXmlNode : XmlNodeBase
	{
		private const string ATTR_NUMBER = "number";

		public IndicatorTemplateListXmlNode IndicatorTemplates
		{
			get
			{
				return this.GetChildNode<IndicatorTemplateListXmlNode>();
			}
		}

		public override string NodeName
		{
			get
			{
				return "Pad";
			}
		}

		public int Number
		{
			get
			{
				return this.GetInt32Attribute("number");
			}
			set
			{
				this.SetAttribute("number", value);
			}
		}

		public PadTemplateXmlNode() : base()
		{
		}
	}
}
