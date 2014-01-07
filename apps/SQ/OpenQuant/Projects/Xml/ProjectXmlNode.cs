// Type: OpenQuant.Projects.Xml.ProjectXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class ProjectXmlNode : XmlNodeBase
  {
    private const string ATTR_ENABLED = "enabled";

    public override string NodeName
    {
      get
      {
        return "project";
      }
    }

    public PathXmlNode Path
    {
      get
      {
        return this.GetChildNode<PathXmlNode>();
      }
    }

    public bool Enabled
    {
      get
      {
        return this.GetBooleanAttribute("enabled");
      }
      set
      {
        this.SetAttribute("enabled", value);
      }
    }
  }
}
