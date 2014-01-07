// Type: SmartQuant.Shared.Data.Import.CSV.SeriesXmlNode
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
  public class SeriesXmlNode : CommonXmlNode
  {
    public const string NAME = "series";
    private const string UF4dka1iAw = "nameOption";
    private const string pFEdlXrQFw = "seriesSuffix";

    public SeriesOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new SeriesOptions()
        {
          Option = (SeriesNameOption) Enum.Parse(typeof (SeriesNameOption), this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(9828))),
          SeriesSuffix = this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(9852))
        };
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(9880), ((object) value.Option).ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(9904), value.SeriesSuffix);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SeriesXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator SeriesXmlNode(XmlNode xmlNode)
    {
      return new SeriesXmlNode(xmlNode);
    }
  }
}
