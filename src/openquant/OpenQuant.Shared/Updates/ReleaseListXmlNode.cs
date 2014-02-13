using FreeQuant.Xml;

namespace OpenQuant.Shared.Updates
{
	class ReleaseListXmlNode : ListXmlNode<ReleaseXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "releases";
			}
		}

		public ReleaseListXmlNode() : base()
		{
		}
	}
}
