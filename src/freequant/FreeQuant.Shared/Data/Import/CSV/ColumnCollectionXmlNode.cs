// Type: SmartQuant.Shared.Data.Import.CSV.ColumnCollectionXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ColumnCollectionXmlNode : CommonXmlNode
  {
    public const string NAME = "columns";

    public ColumnCollection Columns
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        ColumnCollection columnCollection = new ColumnCollection();
        foreach (XmlNode xmlNode in this.xmlNode)
          columnCollection.Add((ColumnXmlNode) xmlNode.Column);
        return columnCollection;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        foreach (Column column in (CollectionBase) value)
          (ColumnXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22966)).Column = column;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ColumnCollectionXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator ColumnCollectionXmlNode(XmlNode xmlNode)
    {
      return new ColumnCollectionXmlNode(xmlNode);
    }
  }
}
