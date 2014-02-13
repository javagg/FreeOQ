using FreeQuant.Xml;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class TemplateXmlDocument : XmlDocumentBase
	{
		public TemplateListXmlNode Templates
		{
			get
			{
				return (TemplateListXmlNode)this.GetChildNode<TemplateListXmlNode>();
			}
		}

		public TemplateXmlDocument() : base("document", "CSV Import saved templates")
		{
		}
	}
}
