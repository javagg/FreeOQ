// Type: SmartQuant.Shared.Data.Import.CSV.CommonXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Runtime.CompilerServices;
using System.Xml;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class CommonXmlNode
  {
    protected XmlNode xmlNode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected CommonXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.xmlNode = xmlNode;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator XmlNode(CommonXmlNode commonXmlNode)
    {
      return commonXmlNode.xmlNode;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AppendAttribute(string name, string value)
    {
      XmlAttribute attribute = this.xmlNode.OwnerDocument.CreateAttribute(name);
      this.xmlNode.Attributes.Append(attribute);
      attribute.Value = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string ReadAttribute(string name)
    {
      XmlAttribute xmlAttribute = this.xmlNode.Attributes[name];
      if (xmlAttribute != null)
        return xmlAttribute.Value;
      else
        return (string) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected XmlNode FindNode(string name)
    {
      foreach (XmlNode xmlNode in this.xmlNode)
      {
        if (xmlNode.Name == name)
          return xmlNode;
      }
      return (XmlNode) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected XmlNode AddNode(string name)
    {
      XmlNode newChild = (XmlNode) this.xmlNode.OwnerDocument.CreateElement(name);
      this.xmlNode.AppendChild(newChild);
      return newChild;
    }
  }
}
