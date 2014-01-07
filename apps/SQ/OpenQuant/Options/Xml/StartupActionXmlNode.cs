// Type: OpenQuant.Options.Xml.StartupActionXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Startup;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Options.Xml
{
  internal class StartupActionXmlNode : XmlNodeBase
  {
    public override string NodeName
    {
      get
      {
        return "action";
      }
    }

    public StartupAction Value
    {
      get
      {
        return (StartupAction) Enum.Parse(typeof (StartupAction), this.GetStringValue());
      }
      set
      {
        this.SetValue((Enum) value);
      }
    }
  }
}
