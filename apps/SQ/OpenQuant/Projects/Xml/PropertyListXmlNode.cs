// Type: OpenQuant.Projects.Xml.PropertyListXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;
using System;
using System.Collections;

namespace OpenQuant.Projects.Xml
{
  internal class PropertyListXmlNode : XmlNodeBase, IEnumerable
  {
    public override string NodeName
    {
      get
      {
        return "properties";
      }
    }

    public void Add(string name, Type type, string value, string category, string description)
    {
      PropertyXmlNode propertyXmlNode = this.AppendChildNode<PropertyXmlNode>();
      propertyXmlNode.Name = name;
      propertyXmlNode.Type = type;
      propertyXmlNode.IsEnum = type.IsEnum;
      propertyXmlNode.Value = value;
      propertyXmlNode.Category = category;
      propertyXmlNode.Descrition = description;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<PropertyXmlNode>().GetEnumerator();
    }
  }
}
