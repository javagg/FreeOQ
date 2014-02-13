using FreeQuant.Xml;

namespace OpenQuant.Shared.QuantTrader
{
	class MarketDataXmlDocument : XmlDocumentBase
	{
		public RequestListXmlNode Requests
		{
			get
			{
				return (RequestListXmlNode)this.GetChildNode<RequestListXmlNode>();
			}
		}

		public MarketDataXmlDocument() : base("market_data")
		{
		}
	}
}
