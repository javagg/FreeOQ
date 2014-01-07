// Type: OpenQuant.Options.Xml.RecentSolutionsXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal class RecentSolutionsXmlNode : XmlNodeBase
  {
    private const string ATTR_MAX_COUNT = "max";
    private const string ATTR_SHOW_COUNT = "show";

    public override string NodeName
    {
      get
      {
        return "recent";
      }
    }

    public int MaxCount
    {
      get
      {
        return this.GetInt32Attribute("max");
      }
      set
      {
        this.SetAttribute("max", value);
      }
    }

    public int ShowCount
    {
      get
      {
        return this.GetInt32Attribute("show");
      }
      set
      {
        this.SetAttribute("show", value);
      }
    }
  }
}
