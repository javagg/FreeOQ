// Type: OpenQuant.Projects.Xml.SimulationSettingsXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;
using System;

namespace OpenQuant.Projects.Xml
{
  internal class SimulationSettingsXmlNode : XmlNodeBase
  {
    private const string ATTR_START_DATE = "start_date";
    private const string ATTR_STOP_DATE = "stop_date";
    private const string ATTR_CASH = "cash";

    public override string NodeName
    {
      get
      {
        return "simulation";
      }
    }

    public DateTime StartDate
    {
      get
      {
        return this.GetDateTimeAttribute("start_date");
      }
      set
      {
        this.SetAttribute("start_date", value);
      }
    }

    public DateTime StopDate
    {
      get
      {
        return this.GetDateTimeAttribute("stop_date");
      }
      set
      {
        this.SetAttribute("stop_date", value);
      }
    }

    public double Cash
    {
      get
      {
        return this.GetDoubleAttribute("cash");
      }
      set
      {
        this.SetAttribute("cash", value);
      }
    }
  }
}
