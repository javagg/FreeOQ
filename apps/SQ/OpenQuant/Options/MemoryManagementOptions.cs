// Type: OpenQuant.Options.MemoryManagementOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Shared.Options;
using System;
using System.IO;

namespace OpenQuant.Options
{
  internal class MemoryManagementOptions : MemoryManagementOptions
  {
    public MemoryManagementOptions()
    {
      base.\u002Ector(new FileInfo(string.Format("{0}\\memorymanagement.xml", (object) Global.Setup.Folders.Ini.FullName)));
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    protected virtual void OnLoad()
    {
      base.OnLoad();
      this.SetOptions();
    }

    protected virtual void OnSave()
    {
      base.OnSave();
      this.SetOptions();
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.SetOptions();
    }

    private void SetOptions()
    {
      Configuration.get_Active().get_Portfolio().Performance.CalculateDrawdown = this.get_PortfolioPerformanceDrawdownCalculationEnabled();
      Configuration.get_Active().get_Portfolio().Performance.CalculatePnL = this.get_PortfolioPerformancePnLCalculationEnabled();
      Configuration.get_Active().get_Portfolio().Performance.Enabled = this.get_PortfolioPerformanceEnabled();
      Configuration.get_Active().get_Portfolio().Performance.UpdateInterval = new TimeSpan(this.get_PortfolioPerformanceUpdateInterval() * 10000000L);
      Configuration.get_Active().get_Portfolio().Performance.UpdateOnIntervalEnabled = this.get_PortfolioPerformanceUpdateOnIntervalEnabled();
    }
  }
}
