// Type: OpenQuant.Options.Xml.ConfigurationModeXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Config;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Options.Xml
{
  internal class ConfigurationModeXmlNode : XmlNodeBase
  {
    private const string ATTR_TYPE = "type";

    public override string NodeName
    {
      get
      {
        return "mode";
      }
    }

    public ConfigurationMode Mode
    {
      get
      {
        return (ConfigurationMode) this.GetEnumAttribute("type", typeof (ConfigurationMode));
      }
      set
      {
        this.SetAttribute("type", (Enum) (object) value);
      }
    }

    public PortfolioXmlNode Portfolio
    {
      get
      {
        return this.GetChildNode<PortfolioXmlNode>();
      }
    }

    public MarketDataProviderXmlNode MarketDataProvider
    {
      get
      {
        return this.GetChildNode<MarketDataProviderXmlNode>();
      }
    }

    public ExecutionProviderXmlNode ExecutionProvider
    {
      get
      {
        return this.GetChildNode<ExecutionProviderXmlNode>();
      }
    }
  }
}
