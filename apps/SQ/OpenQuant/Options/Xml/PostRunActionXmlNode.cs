// Type: OpenQuant.Options.Xml.PostRunActionXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Options.Xml
{
  internal class PostRunActionXmlNode : XmlNodeBase
  {
    public override string NodeName
    {
      get
      {
        return "post_run_action";
      }
    }

    public PostRunAction Value
    {
      get
      {
        return (PostRunAction) this.GetEnumValue(typeof (PostRunAction));
      }
      set
      {
        this.SetValue((Enum) value);
      }
    }
  }
}
