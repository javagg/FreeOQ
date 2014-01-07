// Type: OpenQuant.Projects.Xml.RecentSolutionXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class RecentSolutionXmlNode : XmlNodeBase
  {
    public override string NodeName
    {
      get
      {
        return "solution";
      }
    }

    public PathXmlNode Path
    {
      get
      {
        return this.GetChildNode<PathXmlNode>();
      }
    }

    public StringValueXmlNode Name
    {
      get
      {
        return this.GetStringValueNode("name");
      }
    }

    public StringValueXmlNode Description
    {
      get
      {
        return this.GetStringValueNode("description");
      }
    }

    public DateTimeValueXmlNode DateModified
    {
      get
      {
        return this.GetDateTimeValueNode("date");
      }
    }
  }
}
