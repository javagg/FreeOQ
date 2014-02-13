using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class EditorXmlDocument : XmlDocumentBase
	{
		private const int SCHEMA_VERSION = 1;

		public EditorSettingsXmlNode Settings
		{
			get
			{
				return (EditorSettingsXmlNode)this.GetChildNode<EditorSettingsXmlNode>();
			}
		}

		public EditorXmlDocument() : base("editor", 1)
		{
		}
	}
}
