using FreeQuant.Xml;

namespace OpenQuant.Shared.QuantTrader
{
	class RequestListXmlNode : ListXmlNode<RequestXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "requests";
			}
		}

		public RequestListXmlNode() : base()
		{
		}

		public void Add(Request request)
		{
			RequestXmlNode requestXmlNode = this.AppendChildNode();
			requestXmlNode.DataType = request.DataType;
			if (!(request is BarRequest))
				return;
			BarRequest barRequest = (BarRequest)request;
			requestXmlNode.BarType.Value = barRequest.BarType;
			requestXmlNode.BarSize.Value = barRequest.BarSize;
		}
	}
}
