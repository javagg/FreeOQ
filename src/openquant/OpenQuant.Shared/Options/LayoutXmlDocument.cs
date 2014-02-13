using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class LayoutXmlDocument : XmlDocumentBase
	{
		public LayoutRendererXmlNode Renderer
		{
			get
			{
				return this.GetChildNode<LayoutRendererXmlNode>();
			}
		}

		public LayoutColorSchemeXmlNode ColorScheme
		{
			get
			{
				return this.GetChildNode<LayoutColorSchemeXmlNode>();
			}
		}

		public IntegralCloseXmlNode IntegralClose
		{
			get
			{
				return  this.GetChildNode<IntegralCloseXmlNode>();
			}
		}

		public LayoutXmlDocument() : base("layout")
		{
		}
	}
}
