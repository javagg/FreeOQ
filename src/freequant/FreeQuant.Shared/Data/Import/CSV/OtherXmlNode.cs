// Type: SmartQuant.Shared.Data.Import.CSV.OtherXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Runtime.CompilerServices;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class OtherXmlNode : CommonXmlNode
  {
    public const string NAME = "other";
    private const string RdsVRpuxTL = "createInstrument";
    private const string cA3VHBBhy8 = "clearSeries";
    private const string PgdVkCElEH = "securityType";

    public OtherOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        OtherOptions otherOptions = new OtherOptions();
        otherOptions.CreateInstrument = bool.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14718)));
        otherOptions.ClearSeries = bool.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14754)));
        string str = this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14780));
        if (str != null)
          otherOptions.SecurityType = str;
        return otherOptions;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14808), value.CreateInstrument.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14844), value.ClearSeries.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14870), ((object) value.SecurityType).ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OtherXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator OtherXmlNode(XmlNode xmlNode)
    {
      return new OtherXmlNode(xmlNode);
    }
  }
}
