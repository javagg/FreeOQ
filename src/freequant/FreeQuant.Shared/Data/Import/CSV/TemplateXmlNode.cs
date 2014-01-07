// Type: SmartQuant.Shared.Data.Import.CSV.TemplateXmlNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Runtime.CompilerServices;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class TemplateXmlNode : CommonXmlNode
  {
    public const string NAME = "template";
    private const string EtElVaB2Ei = "name";

    public Template Template
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        Template template = new Template();
        template.Name = this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21178));
        CSVXmlNode csvXmlNode = (CSVXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21190));
        template.CSVOptions = csvXmlNode.Options;
        DataXmlNode dataXmlNode = (DataXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21200));
        template.DataOptions = dataXmlNode.Options;
        DateXmlNode dateXmlNode = (DateXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21212));
        template.DateOptions = dateXmlNode.Options;
        SymbolXmlNode symbolXmlNode = (SymbolXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21224));
        template.SymbolOptions = symbolXmlNode.Options;
        SeriesXmlNode seriesXmlNode = (SeriesXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21240));
        template.SeriesOptions = seriesXmlNode.Options;
        OtherXmlNode otherXmlNode = (OtherXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21256));
        template.OtherOptions = otherXmlNode.Options;
        ColumnCollectionXmlNode collectionXmlNode = (ColumnCollectionXmlNode) this.FindNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21270));
        template.Columns = collectionXmlNode.Columns;
        return template;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21288), value.Name);
        (CSVXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21300)).Options = value.CSVOptions;
        (DataXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21310)).Options = value.DataOptions;
        (DateXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21322)).Options = value.DateOptions;
        (SymbolXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21334)).Options = value.SymbolOptions;
        (SeriesXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21350)).Options = value.SeriesOptions;
        (OtherXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21366)).Options = value.OtherOptions;
        (ColumnCollectionXmlNode) this.AddNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(21380)).Columns = value.Columns;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TemplateXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator TemplateXmlNode(XmlNode xmlNode)
    {
      return new TemplateXmlNode(xmlNode);
    }
  }
}
