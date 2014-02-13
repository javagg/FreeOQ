using FreeQuant.Xml;

namespace OpenQuant.Shared.Updates
{
	class DataXmlDocument : XmlDocumentBase
	{
		public ReleaseListXmlNode Releases
		{
			get
			{
				return (ReleaseListXmlNode)this.GetChildNode<ReleaseListXmlNode>();
			}
		}

		public DataXmlDocument() : base("data")
		{
		}
	}
}
