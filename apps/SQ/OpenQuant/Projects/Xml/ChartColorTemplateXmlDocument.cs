// Type: OpenQuant.Projects.Xml.ChartColorTemplateXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class ChartColorTemplateXmlDocument : XmlDocumentBase
  {
    private const string ATTR_NAME = "name";

    public string TemplateName
    {
      get
      {
        return this.GetStringAttribute("name");
      }
      set
      {
        this.SetAttribute("name", value);
      }
    }

    public PropertyListXmlNode Properties
    {
      get
      {
        return this.GetChildNode<PropertyListXmlNode>();
      }
    }

    public ChartColorTemplateXmlDocument()
      : base("template", "chart color template file")
    {
    }
  }
}
