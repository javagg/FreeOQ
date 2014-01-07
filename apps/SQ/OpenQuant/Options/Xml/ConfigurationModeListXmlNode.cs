// Type: OpenQuant.Options.Xml.ConfigurationModeListXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Config;
using SmartQuant.Xml;
using System.Collections;

namespace OpenQuant.Options.Xml
{
  internal class ConfigurationModeListXmlNode : XmlNodeBase, IEnumerable
  {
    public override string NodeName
    {
      get
      {
        return "modes";
      }
    }

    public void Add(ConfigurationMode mode, ConfigurationInfo info)
    {
      ConfigurationModeXmlNode configurationModeXmlNode = this.AppendChildNode<ConfigurationModeXmlNode>();
      configurationModeXmlNode.Mode = mode;
      configurationModeXmlNode.Portfolio.PortfolioName = info.get_Portfolio().Name;
      configurationModeXmlNode.MarketDataProvider.ProviderId = info.get_MarketDataProvider() == null ? (byte) 0 : info.get_MarketDataProvider().Id;
      configurationModeXmlNode.ExecutionProvider.ProviderId = info.get_ExecutionProvider() == null ? (byte) 0 : info.get_ExecutionProvider().Id;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<ConfigurationModeXmlNode>().GetEnumerator();
    }
  }
}
