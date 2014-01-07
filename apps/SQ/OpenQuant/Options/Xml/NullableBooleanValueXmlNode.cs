// Type: OpenQuant.Options.Xml.NullableBooleanValueXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal class NullableBooleanValueXmlNode : BooleanValueXmlNode
  {
    public bool? Value
    {
      get
      {
        if (!string.IsNullOrEmpty(this.GetStringValue()))
          return new bool?(base.Value);
        else
          return new bool?();
      }
      set
      {
        if (!value.HasValue)
          return;
        base.Value = value.Value;
      }
    }
  }
}
