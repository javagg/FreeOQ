// Type: OpenQuant.Projects.UI.Tester.StatisticListView
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using SmartQuant.ExcelLib;
using SmartQuant.Testing;
using SmartQuant.Testing.TesterItems;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class StatisticListView : StatisticViewer
  {
    protected LiveTester tester;
    protected ListView listView;
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

    public StatisticListView(LiveTester tester, string name)
    {
      this.tester = tester;
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
      this.listView.Columns.Add("Statistics", 198, HorizontalAlignment.Left);
      this.listView.Columns.Add("Value", 109, HorizontalAlignment.Right);
      this.listView.EndUpdate();
      this.tester.StatisticChanged += new TesterEventHandler(this.Tester_StatisticChanged);
      this.tester.Reseted += new TesterEventHandler(this.tester_Reseted);
    }

    public override void UpdateContent()
    {
      this.forceUpdate = true;
      this.Tester_StatisticChanged(this.tester);
      this.forceUpdate = false;
    }

    public void AddComponentItem(TesterItem component)
    {
      this.AddComponentItem(component, "{0:F4}");
    }

    public void AddComponentItem(TesterItem component, string format)
    {
      this.components.Add((object) component);
      this.formatArray.Add((object) component, (object) format);
      SeriesTesterItem seriesTesterItem = (SeriesTesterItem) null;
      if (component is SeriesTesterItem)
      {
        seriesTesterItem = component as SeriesTesterItem;
        seriesTesterItem.ComponentEnabledChanged += new EventHandler(this.StatisticListView_ComponentEnabledChanged);
      }
      if (seriesTesterItem != null && !seriesTesterItem.Enabled)
        return;
      TesterComponentItem testerComponentItem = new TesterComponentItem(component);
      testerComponentItem.UseItemStyleForSubItems = true;
      this.listView.Items.Add((ListViewItem) testerComponentItem);
    }

    public void UpdateItems()
    {
      foreach (TesterComponentItem testerComponentItem in this.listView.Items)
        testerComponentItem.UpdateText(this.formatArray[(object) testerComponentItem.Component].ToString());
    }

    private void Tester_StatisticChanged(LiveTester sender)
    {
      if (!Global.Flags.UpdateUI && !this.forceUpdate || !this.updateEnabled)
        return;
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new TesterEventHandler(this.Tester_StatisticChanged), new object[1]
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

    private void Item_DoubleClick(object sender, EventArgs e)
    {
    }

    public override void Disconnect()
    {
      this.tester.StatisticChanged -= new TesterEventHandler(this.Tester_StatisticChanged);
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
        for (int index = 0; index < this.listView.Items.Count; ++index)
          this.listView.Items[index].SubItems[1].Text = "";
      }
    }

    private void StatisticListView_ComponentEnabledChanged(object sender, EventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new EventHandler(this.StatisticListView_ComponentEnabledChanged), sender, (object) e);
      }
      else
      {
        SeriesTesterItem seriesTesterItem = sender as SeriesTesterItem;
        if (seriesTesterItem.Enabled)
        {
          this.listView.Items.Add((ListViewItem) new TesterComponentItem((TesterItem) seriesTesterItem));
        }
        else
        {
          foreach (ListViewItem listViewItem in this.listView.Items)
          {
            if (listViewItem.Text == seriesTesterItem.Name)
              this.listView.Items.Remove(listViewItem);
          }
        }
      }
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
