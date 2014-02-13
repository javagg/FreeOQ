using FreeQuant.Xml;

namespace OpenQuant.Shared.QuantTrader
{
	class SymbolXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "symbol";
			}
		}

		public string Symbol
		{
			get
			{
				return this.GetStringValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public SymbolXmlNode() : base()
		{
		}
	}
}
