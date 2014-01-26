using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace FreeQuant.Shared.Data.Import.CSV
{
  public class CSVXmlNode : CommonXmlNode
  {
    public const string NAME = "csv";
    private const string BAqJDmEk6S = "separator";
    private const string lQXJ1RP2Lo = "headerLineCount";
    private const string SCSJdDr4OM = "culture";

    public CSVOptions Options
    {
       get
      {
        return new CSVOptions()
        {
          Separator = Separator.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33188))),
          HeaderLineCount = int.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33210))),
          CultureInfo = CultureInfo.CreateSpecificCulture(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33244)))
        };
      }
       set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33262), value.Separator.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33284), value.HeaderLineCount.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33318), value.CultureInfo.Name);
      }
    }

    
    private CSVXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    
    public static explicit operator CSVXmlNode(XmlNode xmlNode)
    {
      return new CSVXmlNode(xmlNode);
    }
  }
}
