// Type: OpenQuant.Options.Xml.CheckForUpdatesXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal class CheckForUpdatesXmlNode : XmlNodeBase
  {
    public override string NodeName
    {
      get
      {
        return "check_for_updates";
      }
    }

    public bool Value
    {
      get
      {
        bool result;
        if (bool.TryParse(this.GetStringValue(), out result))
          return result;
        else
          return true;
      }
      set
      {
        this.SetValue(value);
      }
    }
  }
}
