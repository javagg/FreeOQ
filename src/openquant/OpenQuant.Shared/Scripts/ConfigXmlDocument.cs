using FreeQuant.Xml;

namespace OpenQuant.Shared.Scripts
{
	class ConfigXmlDocument : XmlDocumentBase
	{
		public StartupScriptListXmlNode StartupScripts
		{
			get
			{
				return  this.GetChildNode<StartupScriptListXmlNode>();
			}
		}

		public ConfigXmlDocument() : base("config")
		{
		}
	}
}
