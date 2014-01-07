// Type: OpenQuant.Projects.UI.Tester.StatisticsViewerContainer
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.ExcelLib;
using SmartQuant.Testing;
using System;
using System.Collections;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class StatisticsViewerContainer : StatisticViewer
  {
    protected ArrayList statisticsViewers;
    protected TabControl tabControl;

    public ArrayList StatisticsViewers
    {
      get
      {
        return this.statisticsViewers;
      }
    }

    public StatisticsViewerContainer(LiveTester tester, string name)
    {
      this.Init();
      this.viewerName = name;
    }

    private void Init()
    {
      this.Dock = DockStyle.Fill;
      this.statisticsViewers = new ArrayList();
      this.tabControl = new TabControl();
      this.tabControl.Dock = DockStyle.Fill;
      this.Controls.Add((Control) this.tabControl);
    }

    public override void UpdateContent()
    {
      foreach (StatisticViewer statisticViewer in this.statisticsViewers)
        statisticViewer.UpdateContent();
    }

    public void AddViewer(StatisticViewer viewer)
    {
      TabPage tabPage = new TabPage(viewer.ViewerName);
      this.statisticsViewers.Add((object) viewer);
      tabPage.Controls.Add((Control) viewer);
      this.tabControl.TabPages.Add(tabPage);
    }

    public void ClearViewers()
    {
      this.statisticsViewers.Clear();
      this.tabControl.TabPages.Clear();
    }

    public override void Disconnect()
    {
      foreach (StatisticViewer statisticViewer in this.statisticsViewers)
        statisticViewer.Disconnect();
    }

    public override void Reset()
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new MethodInvoker(((StatisticViewer) this).Reset));
      }
      else
      {
        foreach (StatisticViewer statisticViewer in this.statisticsViewers)
          statisticViewer.Reset();
      }
    }

    public void WriteToExcel(Workbook workbook)
    {
      foreach (StatisticViewer statisticViewer in this.statisticsViewers)
      {
        int num = statisticViewer.UpdateEnabled ? 1 : 0;
      }
    }

    public override void WriteToExcel(Worksheet sheet)
    {
    }
  }
}
