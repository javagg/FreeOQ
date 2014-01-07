// Type: OpenQuant.Options.Xml.ActiveModeXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Config;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Options.Xml
{
  internal class ActiveModeXmlNode : XmlNodeBase
  {
    public override string NodeName
    {
      get
      {
        return "active";
      }
    }

    public ConfigurationMode Value
    {
      get
      {
        return (ConfigurationMode) this.GetEnumValue(typeof (ConfigurationMode));
      }
      set
      {
        this.SetValue((Enum) (object) value);
      }
    }
  }
}
