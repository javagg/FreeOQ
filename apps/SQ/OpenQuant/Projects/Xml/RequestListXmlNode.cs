// Type: OpenQuant.Projects.Xml.RequestListXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Trading;
using SmartQuant.Providers;
using SmartQuant.Xml;
using System;
using System.Collections;

namespace OpenQuant.Projects.Xml
{
  internal class RequestListXmlNode : XmlNodeBase, IEnumerable
  {
    private const string ATTR_BARFACTORY_INPUT = "barfactory_input";

    public override string NodeName
    {
      get
      {
        return "requests";
      }
    }

    public BarFactoryInput BarFactoryInput
    {
      get
      {
        if (this.GetStringAttribute("barfactory_input") == null)
          return BarFactoryInput.Trade;
        else
          return (BarFactoryInput) this.GetEnumAttribute("barfactory_input", typeof (BarFactoryInput));
      }
      set
      {
        this.SetAttribute("barfactory_input", (Enum) value);
      }
    }

    public void Add(MarketDataRequest request)
    {
      this.AppendChildNode<RequestXmlNode>().Request = request;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<RequestXmlNode>().GetEnumerator();
    }
  }
}
