// Type: OpenQuant.ToolbarManager
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Instruments;
using System.Collections.Generic;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant
{
  internal class ToolbarManager
  {
    private const string KEY_SETTINGS = "014B44C5-5D67-4509-911E-990AAFD963F5";
    private const string KEY_SETTINGS_RESET = "9A87EB32-8D89-437d-B78A-325E0527D8EF";
    private ToolStrip tstFile;
    private ToolStrip tstEdit;
    private ToolStrip tstView;
    private ToolStrip tstProject;
    private ToolStrip tstProjectView;
    private ChartToolStrip tstChart;
    private ToolStrip tstMode;
    private InstrumentListToolStrip tstInstrumentList;
    private List<Chart> charts;
    private List<InstrumentListSource> instrumentListSources;

    public ToolStrip File
    {
      get
      {
        return this.tstFile;
      }
    }

    public ToolStrip Edit
    {
      get
      {
        return this.tstEdit;
      }
    }

    public ToolStrip View
    {
      get
      {
        return this.tstView;
      }
    }

    public ToolStrip Project
    {
      get
      {
        return this.tstProject;
      }
    }

    public ToolStrip ProjectView
    {
      get
      {
        return this.tstProjectView;
      }
    }

    public ChartToolStrip Chart
    {
      get
      {
        return this.tstChart;
      }
    }

    public InstrumentListToolStrip InstrumentList
    {
      get
      {
        return this.tstInstrumentList;
      }
    }

    public ToolStrip Mode
    {
      get
      {
        return this.tstMode;
      }
    }

    public ToolbarManager()
    {
      this.charts = new List<Chart>();
      this.instrumentListSources = new List<InstrumentListSource>();
      // ISSUE: method pointer
      ((SandDockManager) Global.get_DockManager()).add_DockControlAdded(new DockControlEventHandler((object) this, __methodptr(DockManager_DockControlAdded)));
      // ISSUE: method pointer
      ((SandDockManager) Global.get_DockManager()).add_DockControlRemoved(new DockControlEventHandler((object) this, __methodptr(DockManager_DockControlRemoved)));
      // ISSUE: method pointer
      ((SandDockManager) Global.get_DockManager()).add_DockControlActivated(new DockControlEventHandler((object) this, __methodptr(DockManager_DockControlActivated)));
    }

    public void Init(ToolStrip tstFile, ToolStrip tstEdit, ToolStrip tstView, ToolStrip tstProject, ToolStrip tstProjectView, ChartToolStrip tstChart, ToolStrip tstMode, InstrumentListToolStrip tstInstrumentList)
    {
      this.tstFile = tstFile;
      this.tstEdit = tstEdit;
      this.tstView = tstView;
      this.tstProject = tstProject;
      this.tstProjectView = tstProjectView;
      this.tstChart = tstChart;
      this.tstMode = tstMode;
      this.tstInstrumentList = tstInstrumentList;
      ToolStripManager.SaveSettings(Global.MainForm, "9A87EB32-8D89-437d-B78A-325E0527D8EF");
    }

    public void Done()
    {
      ToolStripManager.SaveSettings(Global.MainForm, "014B44C5-5D67-4509-911E-990AAFD963F5");
    }

    public void Reset()
    {
      int num = (int) MessageBox.Show((IWin32Window) Global.MainForm, "This functionality is temporary unavailable.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void DockManager_DockControlAdded(object sender, DockControlEventArgs e)
    {
      DockControl dockControl = e.get_DockControl();
      if (dockControl is IChartControl)
        this.charts.Add(((IChartControl) dockControl).get_ChartControl());
      if (!(dockControl is IInstrumentListSource))
        return;
      this.instrumentListSources.Add(((IInstrumentListSource) dockControl).get_InstrumentListSource());
    }

    private void DockManager_DockControlRemoved(object sender, DockControlEventArgs e)
    {
      DockControl dockControl = e.get_DockControl();
      if (dockControl is IChartControl)
        this.charts.Remove(((IChartControl) dockControl).get_ChartControl());
      if (!(dockControl is IInstrumentListSource))
        return;
      this.instrumentListSources.Remove(((IInstrumentListSource) dockControl).get_InstrumentListSource());
    }

    private void DockManager_DockControlActivated(object sender, DockControlEventArgs e)
    {
      DockControl dockControl = e.get_DockControl();
      if (dockControl is IChartControl)
      {
        Chart chartControl = ((IChartControl) dockControl).get_ChartControl();
        this.charts.Remove(chartControl);
        this.charts.Add(chartControl);
      }
      if (dockControl is IInstrumentListSource)
      {
        InstrumentListSource instrumentListSource = ((IInstrumentListSource) dockControl).get_InstrumentListSource();
        this.instrumentListSources.Remove(instrumentListSource);
        this.instrumentListSources.Add(instrumentListSource);
      }
      if (this.tstChart != null)
      {
        Chart chart = (Chart) null;
        if (this.charts.Count > 0)
          chart = this.charts[this.charts.Count - 1];
        this.tstChart.set_Chart(chart);
      }
      if (this.tstInstrumentList == null)
        return;
      InstrumentListSource instrumentListSource1 = (InstrumentListSource) null;
      if (this.instrumentListSources.Count > 0)
        instrumentListSource1 = this.instrumentListSources[this.instrumentListSources.Count - 1];
      if (this.tstInstrumentList.get_InstrumentListSource() == instrumentListSource1)
        return;
      this.tstInstrumentList.set_InstrumentListSource(instrumentListSource1);
    }
  }
}
