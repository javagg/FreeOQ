// Type: SmartQuant.Shared.Data.Import.CSV.SymbolXmlNode
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
  public class SymbolXmlNode : CommonXmlNode
  {
    public const string NAME = "symbol";
    private const string pgDHAefdms = "option";
    private const string ECIHB5FuCE = "cutFileExtension";
    private const string wweHcXIEAG = "name";

    public SymbolOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new SymbolOptions()
        {
          Option = (SymbolOption) Enum.Parse(typeof (SymbolOption), this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19344))),
          CutFileExt = bool.Parse(this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19360))),
          Name = this.ReadAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19396))
        };
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19408), ((object) value.Option).ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19424), value.CutFileExt.ToString());
        this.AppendAttribute(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19460), value.Name);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymbolXmlNode(XmlNode xmlNode)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(xmlNode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator SymbolXmlNode(XmlNode xmlNode)
    {
      return new SymbolXmlNode(xmlNode);
    }
  }
}
