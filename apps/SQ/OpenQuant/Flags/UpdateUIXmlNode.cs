// Type: OpenQuant.Flags.UpdateUIXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Flags
{
  internal class UpdateUIXmlNode : XmlNodeBase
  {
    public override string NodeName
    {
      get
      {
        return "update_ui";
      }
    }

    public bool Value
    {
      get
      {
        return this.GetBooleanValue();
      }
      set
      {
        this.SetValue(value);
      }
    }
  }
}
