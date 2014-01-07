// Type: SmartQuant.Shared.Data.Import.CSV.DataXmlNode
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
  public class DataXmlNode : CommonXmlNode
  {
    public const string NAME = "data";
    private const string wjQJkCNwAH = "dataType";
    private const string Hr1Jll1w4B = "barSize";

    public DataOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new DataOptions()
        {
          DataType = (DataType) Enum.Parse(typeof (DataType), this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33354))),
          BarSize = int.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33374)))
        };
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33392), ((object) value.DataType).ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33412), value.BarSize.ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DataXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator DataXmlNode(XmlNode xmlNode)
    {
      return new DataXmlNode(xmlNode);
    }
  }
}
