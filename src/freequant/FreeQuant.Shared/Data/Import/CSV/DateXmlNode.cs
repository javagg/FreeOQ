// Type: SmartQuant.Shared.Data.Import.CSV.DateXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class DateXmlNode : CommonXmlNode
  {
    public const string NAME = "date";
    private const string GZWlRx7sRT = "dateType";
    private const string nAnlHJyto8 = "date";

    public DateOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new DateOptions()
        {
          DateType = (DateType) Enum.Parse(typeof (DateType), this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21398))),
          Date = DateTime.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21418)), (IFormatProvider) CultureInfo.InvariantCulture)
        };
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21430), ((object) value.DateType).ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21450), value.Date.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator DateXmlNode(XmlNode xmlNode)
    {
      return new DateXmlNode(xmlNode);
    }
  }
}
