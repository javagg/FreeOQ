// Type: OpenQuant.Projects.Xml.InstrumentXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class InstrumentXmlNode : XmlNodeBase
  {
    private const string ATTR_SYMBOL = "symbol";

    public override string NodeName
    {
      get
      {
        return "instrument";
      }
    }

    public string Symbol
    {
      get
      {
        return this.GetStringAttribute("symbol");
      }
      set
      {
        this.SetAttribute("symbol", value);
      }
    }
  }
}
