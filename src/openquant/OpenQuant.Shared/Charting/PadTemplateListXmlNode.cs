using FreeQuant.Xml;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Charting
{
	class PadTemplateListXmlNode : XmlNodeBase, IEnumerable
	{
		public override string NodeName
		{
			get
			{
				return "Pads";
			}
		}

		public PadTemplateListXmlNode() : base()
		{
		}

		public PadTemplateXmlNode Add()
		{
			return this.AppendChildNode<PadTemplateXmlNode>();
		}

		public IEnumerator GetEnumerator()
		{
			return ((List<PadTemplateXmlNode>)this.GetChildNodes<PadTemplateXmlNode>()).GetEnumerator();
		}
	}
}
