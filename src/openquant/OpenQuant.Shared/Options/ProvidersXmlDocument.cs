using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class ProvidersXmlDocument : XmlDocumentBase
	{
		public ProvidersSettingsXmlNode Settings
		{
			get
			{
				return (ProvidersSettingsXmlNode)this.GetChildNode<ProvidersSettingsXmlNode>();
			}
		}

		public ProvidersXmlDocument() : base("config")
		{
		}
	}
}
