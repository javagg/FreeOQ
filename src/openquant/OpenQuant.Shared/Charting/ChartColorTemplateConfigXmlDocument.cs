using FreeQuant.Xml;

namespace OpenQuant.Shared.Charting
{
	class ChartColorTemplateConfigXmlDocument : XmlDocumentBase
	{
		private const string ATTR_DEFAULT_TEMPLATE = "default_template";

		public string DefaultTemplate {
			get {
				return this.GetStringAttribute ("default_template");
			}
			set {
				this.SetAttribute ("default_template", value);
			}
		}

		public ChartColorTemplateConfigXmlDocument () : base ("chart_color_template_config", "chart color template config file")
		{
		}
	}
}
