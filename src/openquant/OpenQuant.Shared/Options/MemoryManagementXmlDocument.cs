using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class MemoryManagementXmlDocument : XmlDocumentBase
	{
		public MemoryManagementXmlNode Settings
		{
			get
			{
				return this.GetChildNode<MemoryManagementXmlNode>();
			}
		}

		public MemoryManagementXmlDocument() : base("memory_management")
		{
		}
	}
}
