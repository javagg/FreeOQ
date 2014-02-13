using FreeQuant.Xml;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.QuantTrader
{
	public class InstrumentsFile : XmlFile
	{
		public string[] Symbols
		{
			get
			{
				List<string> list = new List<string>();
				IEnumerator enumerator = this.GetDocument<InstrumentsXmlDocument>().Symbols.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						SymbolXmlNode symbolXmlNode = (SymbolXmlNode)enumerator.Current;
						list.Add(symbolXmlNode.Symbol);
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
				InstrumentsXmlDocument instrumentsXmlDocument = new InstrumentsXmlDocument();
				foreach (string symbol in value)
					instrumentsXmlDocument.Symbols.Add(symbol);
				this.SetDocument(instrumentsXmlDocument);
			}
		}
	}
}
