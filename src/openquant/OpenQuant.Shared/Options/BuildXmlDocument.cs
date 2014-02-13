using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class BuildXmlDocument : XmlDocumentBase
	{
		public BuildReferenceListXmlNode References
		{
			get
			{
				return (BuildReferenceListXmlNode)this.GetChildNode<BuildReferenceListXmlNode>();
			}
		}

		public BuildXmlDocument() : base("build")
		{
		}
	}
}
