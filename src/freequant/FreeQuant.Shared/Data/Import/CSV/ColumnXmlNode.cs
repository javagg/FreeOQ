// Type: SmartQuant.Shared.Data.Import.CSV.ColumnXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Runtime.CompilerServices;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ColumnXmlNode : CommonXmlNode
  {
    public const string NAME = "column";
    private const string egxsQAQRAJ = "type";
    private const string JiYsv2lMwF = "format";

    public Column Column
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new Column()
        {
          ColumnType = (ColumnType) Enum.Parse(typeof (ColumnType), this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4426))),
          ColumnFormat = this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4438))
        };
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4454), ((object) value.ColumnType).ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4466), value.ColumnFormat);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ColumnXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator ColumnXmlNode(XmlNode xmlNode)
    {
      return new ColumnXmlNode(xmlNode);
    }
  }
}
