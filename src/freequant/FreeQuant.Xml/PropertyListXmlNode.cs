// Type: SmartQuant.Xml.PropertyListXmlNode
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using naygH2hw2me9oFIyF5;
using System;
using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

namespace SmartQuant.Xml
{
  public class PropertyListXmlNode : ListXmlNode<PropertyXmlNode>
  {
    public override string NodeName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return adDoDiJH1mdTdOllhW.JY4ws5fy8(108);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyListXmlNode()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyXmlNode Add(string name, Type type, string value)
    {
      PropertyXmlNode propertyXmlNode = this.AppendChildNode();
      propertyXmlNode.Name = name;
      propertyXmlNode.Type = type;
      propertyXmlNode.Value = value;
      return propertyXmlNode;
    }
  }
}
