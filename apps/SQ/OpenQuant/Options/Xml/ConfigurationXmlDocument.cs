// Type: OpenQuant.Options.Xml.ConfigurationXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal class ConfigurationXmlDocument : XmlDocumentBase
  {
    public ActiveModeXmlNode ActiveMode
    {
      get
      {
        return this.GetChildNode<ActiveModeXmlNode>();
      }
    }

    public ConfigurationModeListXmlNode Modes
    {
      get
      {
        return this.GetChildNode<ConfigurationModeListXmlNode>();
      }
    }

    public ConfigurationXmlDocument()
      : base("configuration", (string) null)
    {
    }
  }
}
