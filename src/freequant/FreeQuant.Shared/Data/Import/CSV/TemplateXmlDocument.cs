// Type: SmartQuant.Shared.Data.Import.CSV.TemplateXmlDocument
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class TemplateXmlDocument : XmlDocument
  {
    private const string DNgVVwonHQ = "templates";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TemplateXmlDocument()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.LoadXml(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14638));
      this.InsertBefore((XmlNode) this.CreateXmlDeclaration(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14688), Encoding.Unicode.HeaderName, (string) null), (XmlNode) this.DocumentElement);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteTemplates(TemplateCollection templates)
    {
      foreach (Template template in templates)
      {
        TemplateXmlNode templateXmlNode = (TemplateXmlNode) ((XmlNode) this.CreateElement(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14698)));
        this.DocumentElement.AppendChild((XmlNode) ((CommonXmlNode) templateXmlNode));
        templateXmlNode.Template = template;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TemplateCollection ReadTemplates()
    {
      TemplateCollection templateCollection = new TemplateCollection();
      foreach (XmlNode xmlNode in (XmlNode) this.DocumentElement)
      {
        TemplateXmlNode templateXmlNode = (TemplateXmlNode) xmlNode;
        templateCollection.Add(templateXmlNode.Template);
      }
      return templateCollection;
    }
  }
}
