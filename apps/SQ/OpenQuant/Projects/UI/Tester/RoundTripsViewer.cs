// Type: OpenQuant.Projects.UI.Tester.RoundTripsViewer
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using SmartQuant;
using SmartQuant.ExcelLib;
using SmartQuant.Testing;
using SmartQuant.Testing.RoundTrips;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class RoundTripsViewer : StatisticViewer
  {
    private string numberFormat = "F2";
    private string dateTimeFormat = "yyyy/MM/dd";
    private DateTime lastDateTime = new DateTime(1, 1, 1);
    protected ListView listView;
    protected RoundTripList roundTripList;
    protected int openRoundTripsNumber;
    protected LiveTester tester;
    protected RoundTrip lastClosedRoundTrip;
    private bool forceUpdate;

    public RoundTripsViewer(LiveTester tester, RoundTripList roundTripList, string name)
    {
      this.roundTripList = roundTripList;
      this.tester = tester;
      this.Init();
      this.viewerName = name;
      this.tester_StatisticChanged(tester);
      ListViewSorter listViewSorter = new ListViewSorter(this.listView);
    }

    private void Init()
    {
      this.listView = new ListView();
      this.Dock = DockStyle.Fill;
      this.Controls.Add((Control) this.listView);
      this.lastClosedRoundTrip = (RoundTrip) null;
      this.listView.FullRowSelect = true;
      this.listView.GridLines = true;
      this.listView.MultiSelect = false;
      this.listView.View = View.Details;
      this.listView.Dock = DockStyle.Fill;
      this.listView.BorderStyle = BorderStyle.None;
      this.listView.BeginUpdate();
      this.listView.Columns.Add("Instrument", 100, HorizontalAlignment.Left);
      this.listView.Columns.Add("Position", 80, HorizontalAlignment.Left);
      this.listView.Columns.Add("Entry Date", 80, HorizontalAlignment.Left);
      this.listView.Columns.Add("Exit Date", 80, HorizontalAlignment.Left);
      this.listView.Columns.Add("Entry Price", 80, HorizontalAlignment.Right);
      this.listView.Columns.Add("Exit Price", 80, HorizontalAlignment.Right);
      this.listView.Columns.Add("Value", 80, HorizontalAlignment.Right);
      this.listView.Columns.Add("Duration", 80, HorizontalAlignment.Right);
      this.listView.EndUpdate();
      this.listView.DoubleClick += new EventHandler(this.listView_DoubleClick);
      this.tester.RoundTripStatisticChanged += new TesterEventHandler(this.tester_StatisticChanged);
      this.tester.RoundTripsFinished += new TesterEventHandler(this.tester_RoundTripsFinished);
      this.tester.Reseted += new TesterEventHandler(this.tester_Reseted);
    }

    public override void UpdateContent()
    {
      this.forceUpdate = true;
      this.tester_StatisticChanged(this.tester);
      this.forceUpdate = false;
    }

    public override void Disconnect()
    {
      this.tester.RoundTripStatisticChanged -= new TesterEventHandler(this.tester_StatisticChanged);
      this.tester.RoundTripsFinished -= new TesterEventHandler(this.tester_RoundTripsFinished);
      this.tester.Reseted -= new TesterEventHandler(this.tester_Reseted);
    }

    public override void Reset()
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new MethodInvoker(((StatisticViewer) this).Reset));
      }
      else
      {
        this.listView.Items.Clear();
        this.openRoundTripsNumber = 0;
      }
    }

    private void tester_StatisticChanged(LiveTester sender)
    {
      if (!Global.Flags.UpdateUI && !this.forceUpdate || !this.updateEnabled)
        return;
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new TesterEventHandler(this.tester_StatisticChanged), new object[1]
        {
          (object) sender
        });
      }
      else
      {
        this.listView.BeginUpdate();
        if (this.lastDateTime > Clock.Now)
        {
          this.listView.Items.Clear();
          this.openRoundTripsNumber = 0;
          this.lastDateTime = new DateTime(1, 1, 1);
          this.lastClosedRoundTrip = (RoundTrip) null;
        }
        else
          this.lastDateTime = Clock.Now;
        int index1 = this.openRoundTripsNumber - 1;
        for (int index2 = this.roundTripList.GetClosedRoundTripIndex(this.lastClosedRoundTrip) + 1; index2 < this.roundTripList.CountOfClosedRoundTrips(); ++index2)
        {
          ListViewItem listViewItem;
          if (index1 < 0)
          {
            listViewItem = new ListViewItem();
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
          }
          else
            listViewItem = this.listView.Items[index1];
          this.numberFormat = this.roundTripList[index2].Instrument.PriceDisplay;
          listViewItem.SubItems[0].Text = this.roundTripList[index2].Instrument.ToString();
          listViewItem.SubItems[1].Text = ((object) this.roundTripList[index2].TradePosition).ToString();
          listViewItem.SubItems[2].Text = this.roundTripList[index2].EntryDateTime.ToString(this.dateTimeFormat);
          listViewItem.SubItems[3].Text = this.roundTripList[index2].ExitDateTime.ToString(this.dateTimeFormat);
          listViewItem.SubItems[4].Text = this.roundTripList[index2].EntryPrice.ToString(this.numberFormat);
          listViewItem.SubItems[5].Text = this.roundTripList[index2].ExitPrice.ToString(this.numberFormat);
          listViewItem.SubItems[6].Text = this.roundTripList[index2].RoundTripResultWithoutCost.ToString(this.numberFormat);
          listViewItem.SubItems[7].Text = this.roundTripList[index2].DurationToString;
          if (index1 < 0)
            this.listView.Items.Insert(0, listViewItem);
          --index1;
        }
        if (this.roundTripList.CountOfClosedRoundTrips() > 0)
          this.lastClosedRoundTrip = this.roundTripList[this.roundTripList.CountOfClosedRoundTrips() - 1];
        OpenRoundTripList openRoundTrips = this.roundTripList.GetOpenRoundTrips();
        for (int index2 = 0; index2 < openRoundTrips.Count; ++index2)
        {
          ListViewItem listViewItem;
          if (index1 < 0)
          {
            listViewItem = new ListViewItem();
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add("");
          }
          else
            listViewItem = this.listView.Items[index1];
          this.numberFormat = this.roundTripList[index2].Instrument.PriceDisplay;
          listViewItem.SubItems[0].Text = openRoundTrips[index2].Instrument.ToString();
          listViewItem.SubItems[1].Text = ((object) openRoundTrips[index2].TradePosition).ToString();
          listViewItem.SubItems[2].Text = openRoundTrips[index2].EntryDateTime.ToString(this.dateTimeFormat);
          listViewItem.SubItems[3].Text = openRoundTrips[index2].ExitDateTime.ToString(this.dateTimeFormat) + " - OPEN";
          listViewItem.SubItems[4].Text = openRoundTrips[index2].EntryPrice.ToString(this.numberFormat);
          listViewItem.SubItems[5].Text = "";
          listViewItem.SubItems[6].Text = openRoundTrips[index2].RoundTripResultWithoutCost.ToString(this.numberFormat);
          listViewItem.SubItems[7].Text = openRoundTrips[index2].DurationToString;
          if (index1 < 0)
            this.listView.Items.Insert(0, listViewItem);
          --index1;
        }
        this.openRoundTripsNumber = openRoundTrips.Count;
        this.listView.EndUpdate();
      }
    }

    private void tester_RoundTripsFinished(LiveTester sender)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new TesterEventHandler(this.tester_RoundTripsFinished), new object[1]
        {
          (object) sender
        });
      }
      else
      {
        ListViewItem listViewItem = new ListViewItem();
        listViewItem.SubItems[0].BackColor = Color.Pink;
        listViewItem.SubItems[0].Text = "Critial error in detecting Round Trips";
        this.listView.Items.Insert(0, listViewItem);
      }
    }

    private void listView_DoubleClick(object sender, EventArgs e)
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
