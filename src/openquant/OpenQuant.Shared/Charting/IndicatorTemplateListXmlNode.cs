using FreeQuant.Xml;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Charting
{
	class IndicatorTemplateListXmlNode : XmlNodeBase, IEnumerable
	{
		public override string NodeName
		{
			get
			{
				return "Indicators";
			}
		}

		public IndicatorTemplateListXmlNode() : base()
		{
		}

		public IndicatorTemplateXmlNode Add()
		{
			return this.AppendChildNode<IndicatorTemplateXmlNode>();
		}

		public IEnumerator GetEnumerator()
		{
			return ((List<IndicatorTemplateXmlNode>)this.GetChildNodes<IndicatorTemplateXmlNode>()).GetEnumerator();
		}
	}
}
