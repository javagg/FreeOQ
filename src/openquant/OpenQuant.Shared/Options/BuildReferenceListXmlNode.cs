using OpenQuant.Shared.Compiler;
using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class BuildReferenceListXmlNode : ListXmlNode<BuildReferenceXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "references";
			}
		}

		public BuildReferenceListXmlNode() : base()
		{
		}

		public void Add(BuildReference reference)
		{
			BuildReferenceXmlNode referenceXmlNode = this.AppendChildNode<BuildReferenceXmlNode>();
			referenceXmlNode.ReferenceType = reference.Type;
			referenceXmlNode.ReferenceName = reference.Name;
			referenceXmlNode.ReferenceVersion = reference.Version;
			referenceXmlNode.HintPath = reference.HintPath;
		}
	}
}
