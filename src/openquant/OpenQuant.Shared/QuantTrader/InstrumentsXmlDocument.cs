using FreeQuant.Xml;

namespace OpenQuant.Shared.QuantTrader
{
	class InstrumentsXmlDocument : XmlDocumentBase
	{
		public SymbolListXmlNode Symbols
		{
			get
			{
				return this.GetChildNode<SymbolListXmlNode>();
			}
		}

		public InstrumentsXmlDocument() : base("instruments")
		{
     
		}
	}
}
