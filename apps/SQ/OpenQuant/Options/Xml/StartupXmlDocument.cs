// Type: OpenQuant.Options.Xml.StartupXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal class StartupXmlDocument : XmlDocumentBase
  {
    public StartupActionXmlNode Action
    {
      get
      {
        return this.GetChildNode<StartupActionXmlNode>();
      }
    }

    public CheckForUpdatesXmlNode CheckForUpdates
    {
      get
      {
        return this.GetChildNode<CheckForUpdatesXmlNode>();
      }
    }

    public StartupXmlDocument()
      : base("startup")
    {
    }
  }
}
