// Type: OpenQuant.Projects.Xml.TesterSettingsXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Testing;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Projects.Xml
{
  internal class TesterSettingsXmlNode : XmlNodeBase
  {
    private const string ATTR_REPORT_ENABLED = "report_enabled";
    private const string ATTR_TESTING_PERIOD = "testing_period";

    public override string NodeName
    {
      get
      {
        return "reporting";
      }
    }

    public bool ReportEnabled
    {
      get
      {
        return this.GetBooleanAttribute("report_enabled");
      }
      set
      {
        this.SetAttribute("report_enabled", value);
      }
    }

    public TimeIntervalSize TestingPeriod
    {
      get
      {
        return (TimeIntervalSize) this.GetEnumAttribute("testing_period", typeof (TimeIntervalSize));
      }
      set
      {
        this.SetAttribute("testing_period", (Enum) value);
      }
    }
  }
}
