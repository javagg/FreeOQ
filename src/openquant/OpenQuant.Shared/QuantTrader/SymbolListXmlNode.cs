using FreeQuant.Xml;

namespace OpenQuant.Shared.QuantTrader
{
	class SymbolListXmlNode : ListXmlNode<SymbolXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "symbols";
			}
		}

		public SymbolListXmlNode() : base()
		{
		}

		public void Add(string symbol)
		{
			this.AppendChildNode().Symbol = symbol;
		}
	}
}
