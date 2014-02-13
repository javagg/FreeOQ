using FreeQuant.Xml;

namespace OpenQuant.Shared.Data.Import.CSV
{
  class TemplateXmlNode : XmlNodeBase
  {
    private const string ATTR_NAME = "name";

		public override string NodeName
    {
      get
      {
        return "template";
      }
    }

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

    public CSVXmlNode CSV
    {
      get
      {
        return this.GetChildNode<CSVXmlNode>();
      }
    }

    public DataXmlNode Data
    {
      get
      {
        return this.GetChildNode<DataXmlNode>();
      }
    }

    public DateXmlNode Date
    {
      get
      {
        return (DateXmlNode) this.GetChildNode<DateXmlNode>();
      }
    }

    public SymbolXmlNode Symbol
    {
      get
      {
        return (SymbolXmlNode) this.GetChildNode<SymbolXmlNode>();
      }
    }

    public OtherXmlNode Other
    {
      get
      {
        return (OtherXmlNode) this.GetChildNode<OtherXmlNode>();
      }
    }

    public ColumnListXmlNode Columns
    {
      get
      {
        return (ColumnListXmlNode) this.GetChildNode<ColumnListXmlNode>();
      }
    }

		public TemplateXmlNode() : base()

    {
    }
  }
}
