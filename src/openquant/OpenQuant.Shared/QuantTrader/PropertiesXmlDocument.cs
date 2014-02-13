using FreeQuant.Xml;

namespace OpenQuant.Shared.QuantTrader
{
  internal class PropertiesXmlDocument : XmlDocumentBase
  {
    public PropertyListXmlNode Properties
    {
      get
      {
        return (PropertyListXmlNode) this.GetChildNode<PropertyListXmlNode>();
      }
    }

    public PropertiesXmlDocument() :  base("document")
    {
    
    }
  }
}
