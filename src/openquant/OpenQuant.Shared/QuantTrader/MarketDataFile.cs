using OpenQuant.Shared.Data;
using FreeQuant.Xml;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.QuantTrader
{
	public class MarketDataFile : XmlFile
	{
		public Request[] Requests
		{
			get
			{
				List<Request> list = new List<Request>();
				IEnumerator enumerator = this.GetDocument<MarketDataXmlDocument>().Requests.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						RequestXmlNode requestXmlNode = (RequestXmlNode)enumerator.Current;
						DataType dataType = requestXmlNode.DataType;
						if (dataType == DataType.Bar)
							list.Add((Request)new BarRequest(requestXmlNode.BarType.Value, requestXmlNode.BarSize.Value));
						else
							list.Add(new Request(dataType));
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
						disposable.Dispose();
				}
				return list.ToArray();
			}
			set
			{
				MarketDataXmlDocument marketDataXmlDocument = new MarketDataXmlDocument();
				foreach (Request request in value)
					marketDataXmlDocument.Requests.Add(request);
				this.SetDocument(marketDataXmlDocument);
			}
		}
	}
}
