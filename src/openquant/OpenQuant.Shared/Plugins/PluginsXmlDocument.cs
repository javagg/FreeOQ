using FreeQuant.Xml;

namespace OpenQuant.Shared.Plugins
{
	class PluginsXmlDocument : XmlDocumentBase
	{
		public PluginListXmlNode Plugins
		{
			get
			{
				return  this.GetChildNode<PluginListXmlNode>();
			}
		}

		public PluginsXmlDocument() : base("settings")
		{
     
		}
	}
}
