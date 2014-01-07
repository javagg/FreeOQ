// Type: SmartQuant.Shared.Data.Import.CSV.CSVXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class CSVXmlNode : CommonXmlNode
  {
    public const string NAME = "csv";
    private const string BAqJDmEk6S = "separator";
    private const string lQXJ1RP2Lo = "headerLineCount";
    private const string SCSJdDr4OM = "culture";

    public CSVOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new CSVOptions()
        {
          Separator = Separator.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33188))),
          HeaderLineCount = int.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33210))),
          CultureInfo = CultureInfo.CreateSpecificCulture(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33244)))
        };
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33262), value.Separator.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33284), value.HeaderLineCount.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33318), value.CultureInfo.Name);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CSVXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator CSVXmlNode(XmlNode xmlNode)
    {
      return new CSVXmlNode(xmlNode);
    }
  }
}
