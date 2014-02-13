using FreeQuant.Xml;

namespace OpenQuant.Shared.Charting
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

		public ChartColorTemplateXmlDocument():  base("template", "chart color template file")
    {
   
    }
  }
}
