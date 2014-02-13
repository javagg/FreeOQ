using FreeQuant.Xml;
using System;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.QuantTrader
{
	public class XmlFile : PackageFile
	{
		internal T GetDocument<T>() where T : XmlDocumentBase, new()
		{
			T instance = Activator.CreateInstance<T>();
			MemoryStream memoryStream = new MemoryStream(this.Data);
			instance.Load(memoryStream);
			return instance;
		}

		internal void SetDocument(XmlDocumentBase document)
		{
			MemoryStream memoryStream = new MemoryStream();
			((XmlDocument)document).Save(memoryStream);
			this.Data = memoryStream.ToArray();
		}
	}
}
