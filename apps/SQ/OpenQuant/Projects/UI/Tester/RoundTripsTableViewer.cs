// Type: OpenQuant.Projects.UI.Tester.RoundTripsTableViewer
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using SmartQuant.ExcelLib;
using SmartQuant.Testing;
using SmartQuant.Testing.RoundTrips;
using SmartQuant.Testing.TesterItems;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class RoundTripsTableViewer : StatisticViewer
  {
    protected LiveTester tester;
    protected ListView listView;
    protected RoundTripList roundTripList;
    protected bool forceUpdate;
    protected Hashtable formatArray;

    public ArrayList Components
    {
      get
      {
        return this.components;
      }
    }

    public LiveTester Tester
    {
      get
      {
        return this.tester;
      }
    }

    public RoundTripsTableViewer(LiveTester tester, RoundTripList roundTripList, string name)
    {
      this.tester = tester;
      this.roundTripList = roundTripList;
      this.Init();
      this.viewerName = name;
    }

    private void Init()
    {
      this.listView = new ListView();
      this.components = new ArrayList();
      this.formatArray = new Hashtable();
      this.Dock = DockStyle.Fill;
      this.Controls.Add((Control) this.listView);
      this.listView.FullRowSelect = true;
      this.listView.GridLines = true;
      this.listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.listView.MultiSelect = false;
      this.listView.View = View.Details;
      this.listView.Dock = DockStyle.Fill;
      this.listView.BorderStyle = BorderStyle.None;
      this.listView.DoubleClick += new EventHandler(this.Item_DoubleClick);
      Color white = Color.White;
      this.listView.BeginUpdate();
      this.listView.Columns.Add("RoundTrip Statistics", 200, HorizontalAlignment.Left);
      this.listView.Columns.Add("All", 100, HorizontalAlignment.Right);
      this.listView.Columns.Add("Long", 100, HorizontalAlignment.Right);
      this.listView.Columns.Add("Short", 100, HorizontalAlignment.Right);
      this.listView.EndUpdate();
      this.tester.RoundTripStatisticChanged += new TesterEventHandler(this.tester_RoundTripStatisticChanged);
      this.tester.Reseted += new TesterEventHandler(this.tester_Reseted);
    }

    private void tester_RoundTripStatisticChanged(LiveTester sender)
    {
      if (!Global.Flags.UpdateUI && !this.forceUpdate || !this.updateEnabled)
        return;
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new TesterEventHandler(this.tester_RoundTripStatisticChanged), new object[1]
        {
          (object) sender
        });
      }
      else
      {
        this.listView.BeginUpdate();
        this.UpdateItems();
        this.listView.EndUpdate();
      }
    }

    public override void UpdateContent()
    {
      if (!this.updateEnabled)
        return;
      this.forceUpdate = true;
      this.UpdateItems();
      this.forceUpdate = false;
    }

    public void AddComponentItem(SeriesTesterItem component1, SeriesTesterItem component2, SeriesTesterItem component3)
    {
      this.AddComponentItem(component1, component2, component3, "{0:F4}");
    }

    public void AddComponentItem(SeriesTesterItem component1, SeriesTesterItem component2, SeriesTesterItem component3, string format)
    {
      this.components.Add((object) component1);
      this.components.Add((object) component2);
      this.components.Add((object) component3);
      this.formatArray.Add((object) component1, (object) format);
      this.formatArray.Add((object) component2, (object) format);
      this.formatArray.Add((object) component3, (object) format);
      SeriesTesterItem seriesTesterItem = (SeriesTesterItem) null;
      component1.ComponentEnabledChanged += new EventHandler(this.StatisticListView_ComponentEnabledChanged);
      component2.ComponentEnabledChanged += new EventHandler(this.StatisticListView_ComponentEnabledChanged);
      component3.ComponentEnabledChanged += new EventHandler(this.StatisticListView_ComponentEnabledChanged);
      if (seriesTesterItem != null && !seriesTesterItem.Enabled)
        return;
      RoundTripRowItem roundTripRowItem = new RoundTripRowItem(component1, component2, component3, component1.Name);
      roundTripRowItem.UseItemStyleForSubItems = true;
      this.listView.Items.Add((ListViewItem) roundTripRowItem);
    }

    public void UpdateItems()
    {
      foreach (RoundTripRowItem roundTripRowItem in this.listView.Items)
        roundTripRowItem.UpdateText(this.formatArray[(object) roundTripRowItem.Component1].ToString());
    }

    private void Item_DoubleClick(object sender, EventArgs e)
    {
    }

    public override void Disconnect()
    {
      this.tester.RoundTripStatisticChanged -= new TesterEventHandler(this.tester_RoundTripStatisticChanged);
      this.tester.Reseted -= new TesterEventHandler(this.tester_Reseted);
      foreach (TesterItem testerItem in this.components)
      {
        if (testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).ComponentEnabledChanged -= new EventHandler(this.StatisticListView_ComponentEnabledChanged);
      }
    }

    public override void Reset()
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new MethodInvoker(((StatisticViewer) this).Reset));
      }
      else
      {
        for (int index1 = 0; index1 < this.listView.Items.Count; ++index1)
        {
          for (int index2 = 1; index2 < this.listView.Items[index1].SubItems.Count; ++index2)
            this.listView.Items[index1].SubItems[index2].Text = "";
        }
      }
    }

    private void StatisticListView_ComponentEnabledChanged(object sender, EventArgs e)
    {
    }

    private void tester_Reseted(LiveTester sender)
    {
      this.Reset();
    }

    public override void WriteToExcel(Worksheet sheet)
    {
      this.CopyDataToWorksheet(sheet, this.listView);
    }
  }
}
