using FreeQuant.Xml;

namespace OpenQuant.Shared.Charting
{
	internal class ChartTemplateXmlDocument : XmlDocumentBase
	{
		public PadTemplateListXmlNode PadTemplates {
			get {
				return (PadTemplateListXmlNode)this.GetChildNode<PadTemplateListXmlNode> ();
			}
		}

		public ChartTemplateXmlDocument () : base ("chart_template", "chart template settings")
		{
     
		}
	}
}
