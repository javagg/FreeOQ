using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class ProvidersSettingsXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "settings";
			}
		}

		public Int32ValueXmlNode ConnectionTimeout
		{
			get
			{
				return this.GetInt32ValueNode("connection_timeout");
			}
		}

		public ProvidersSettingsXmlNode() : base()
		{
     
		}
	}
}
