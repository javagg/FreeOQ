// Type: OpenQuant.Projects.Xml.InstrumentListXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;
using System.Collections;

namespace OpenQuant.Projects.Xml
{
  internal class InstrumentListXmlNode : XmlNodeBase, IEnumerable
  {
    public override string NodeName
    {
      get
      {
        return "intruments";
      }
    }

    public void Add(string symbol)
    {
      this.AppendChildNode<InstrumentXmlNode>().Symbol = symbol;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<InstrumentXmlNode>().GetEnumerator();
    }
  }
}
