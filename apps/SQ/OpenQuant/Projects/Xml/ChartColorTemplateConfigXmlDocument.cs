// Type: OpenQuant.Projects.Xml.ChartColorTemplateConfigXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class ChartColorTemplateConfigXmlDocument : XmlDocumentBase
  {
    private const string ATTR_DEFAULT_TEMPLATE = "default_template";

    public string DefaultTemplate
    {
      get
      {
        return this.GetStringAttribute("default_template");
      }
      set
      {
        this.SetAttribute("default_template", value);
      }
    }

    public ChartColorTemplateConfigXmlDocument()
      : base("chart_color_template_config", "chart color template config file")
    {
    }
  }
}
