// Type: OpenQuant.Projects.UI.MarketScanerWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.API;
using OpenQuant.Config;
using OpenQuant.ObjectMap;
using OpenQuant.Projects;
using OpenQuant.Projects.UI.Items;
using OpenQuant.Properties;
using SmartQuant.Docking.WinForms;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  public class MarketScanerWindow : DockControl, IUpdateUI
  {
    private IContainer components;
    private DataGridView dgvMonitor;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;

    public MarketScanerWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.dgvMonitor = new DataGridView();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.dgvMonitor.BeginInit();
      ((Control) this).SuspendLayout();
      this.dgvMonitor.AllowUserToAddRows = false;
      this.dgvMonitor.AllowUserToDeleteRows = false;
      this.dgvMonitor.AllowUserToResizeRows = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.dgvMonitor.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgvMonitor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMonitor.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvMonitor.DefaultCellStyle = gridViewCellStyle2;
      this.dgvMonitor.Dock = DockStyle.Fill;
      this.dgvMonitor.Location = new Point(0, 0);
      this.dgvMonitor.MultiSelect = false;
      this.dgvMonitor.Name = "dgvMonitor";
      this.dgvMonitor.ReadOnly = true;
      this.dgvMonitor.RowHeadersVisible = false;
      this.dgvMonitor.RowTemplate.Height = 18;
      this.dgvMonitor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvMonitor.ShowCellErrors = false;
      this.dgvMonitor.ShowRowErrors = false;
      this.dgvMonitor.Size = new Size(591, 288);
      this.dgvMonitor.TabIndex = 1;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column1.DefaultCellStyle = gridViewCellStyle3;
      this.Column1.Frozen = true;
      this.Column1.HeaderText = "Instrument";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 80;
      this.Column2.HeaderText = "DateTime";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 140;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.dgvMonitor);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "MarketScanerWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(591, 288);
      ((DockControl) this).set_TabImage((Image) Resources.market_scanner);
      ((Control) this).Text = "Market Scanner";
      this.dgvMonitor.EndInit();
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      if (Runner.IsRunning)
        Configuration.get_Active().get_MarketDataProvider().NewBarSlice += new BarSliceEventHandler(this.MarketDataProvider_NewBarSlice);
      this.UpdateGUI();
      this.Connect();
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      Configuration.get_Active().get_MarketDataProvider().NewBarSlice -= new BarSliceEventHandler(this.MarketDataProvider_NewBarSlice);
      this.Disconnect();
      ((DockControl) this).OnClosing(e);
    }

    private void Connect()
    {
      Runner.Started += new EventHandler(this.Runner_Started);
      Runner.Stopped += new EventHandler(this.Runner_Stopped);
    }

    private void Disconnect()
    {
      Runner.Started -= new EventHandler(this.Runner_Started);
      Runner.Stopped -= new EventHandler(this.Runner_Stopped);
    }

    private void Runner_Started(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.Runner_Started), sender, (object) e));
      }
      else
      {
        this.UpdateGUI();
        Configuration.get_Active().get_MarketDataProvider().NewBarSlice += new BarSliceEventHandler(this.MarketDataProvider_NewBarSlice);
      }
    }

    private void UpdateGUI()
    {
      while (this.dgvMonitor.Columns.Count > 2)
        this.dgvMonitor.Columns.RemoveAt(this.dgvMonitor.Columns.Count - 1);
      this.dgvMonitor.Rows.Clear();
      Dictionary<Instrument, List<MarketScannerCell>> table = new Dictionary<Instrument, List<MarketScannerCell>>();
      if (this.get_Key() is Solution)
      {
        ((Control) this).Text = "Market Scanner";
        foreach (StrategyProject project in Global.ProjectManager.ActiveSolution.Projects.Values)
        {
          if (((Dictionary<string, OrderedDictionary>) Map.PrintTable).ContainsKey(project.Name))
            this.BuildGrid(project, table);
        }
      }
      else
      {
        string name = (this.get_Key() as StrategyProject).Name;
        ((Control) this).Text = "Market Scanner (" + name + ")";
        if (((Dictionary<string, OrderedDictionary>) Map.PrintTable).ContainsKey(name))
          this.BuildGrid(this.get_Key() as StrategyProject, table);
      }
      using (Dictionary<Instrument, List<MarketScannerCell>>.Enumerator enumerator = table.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          KeyValuePair<Instrument, List<MarketScannerCell>> current = enumerator.Current;
          this.dgvMonitor.Rows.Add((DataGridViewRow) new InstrumentViewRow(current.Key, current.Value));
        }
      }
    }

    private void BuildGrid(StrategyProject project, Dictionary<Instrument, List<MarketScannerCell>> table)
    {
      OrderedDictionary orderedDictionary = ((Dictionary<string, OrderedDictionary>) Map.PrintTable)[project.Name];
      List<Instrument> list1 = !(this.get_Key() is Solution) ? project.StrategyRunner.get_Instruments() : Global.ProjectManager.ActiveSolution.SolutionRunner.get_Instruments();
      foreach (DictionaryEntry dictionaryEntry in orderedDictionary)
      {
        DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
        viewTextBoxColumn.HeaderText = dictionaryEntry.Key as string;
        this.dgvMonitor.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
        foreach (Instrument instrument in list1)
        {
          Instrument index = ((Hashtable) Map.SQ_OQ_Instrument)[(object) instrument] as Instrument;
          List<MarketScannerCell> list2 = (List<MarketScannerCell>) null;
          if (!table.TryGetValue(index, out list2))
          {
            list2 = new List<MarketScannerCell>();
            table.Add(index, list2);
          }
          if ((dictionaryEntry.Value as Dictionary<Instrument, object>).ContainsKey(index))
          {
            object obj = (dictionaryEntry.Value as Dictionary<Instrument, object>)[index];
            if (obj is ISeries)
              list2.Add((MarketScannerCell) new SeriesCell(obj as ISeries));
            else
              list2.Add((MarketScannerCell) new BarDataCell(index, (BarData) obj));
          }
          else
            list2.Add((MarketScannerCell) new EmptyCell());
        }
      }
    }

    private void Runner_Stopped(object sender, EventArgs e)
    {
      Configuration.get_Active().get_MarketDataProvider().NewBarSlice -= new BarSliceEventHandler(this.MarketDataProvider_NewBarSlice);
    }

    public void UpdateUI()
    {
      this.UpdateGUI();
    }

    private void MarketDataProvider_NewBarSlice(object sender, BarSliceEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      foreach (InstrumentViewRow instrumentViewRow in (IEnumerable) this.dgvMonitor.Rows)
        instrumentViewRow.Update();
      Thread.Sleep(0);
    }
  }
}
