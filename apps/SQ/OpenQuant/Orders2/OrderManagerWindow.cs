// Type: OpenQuant.Orders2.OrderManagerWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Properties;
using SmartQuant.Docking.WinForms;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Orders2
{
  internal class OrderManagerWindow : DockControl
  {
    private const string KEY_BLOTTER_EXPANDED = "blotter_expanded";
    private const string KEY_REPORTS_EXPANDED = "reports_expanded";
    private const bool DEFAULT_BLOTTER_EXPANDED = true;
    private const bool DEFAULT_REPORTS_EXPANDED = true;
    private Dictionary<string, List<Instrument>> instrumentLists;
    private Dictionary<string, SecurityTypeItem> securityTypeItems;
    private Dictionary<Instrument, InstrumentItem> instrumentItems;
    private IContainer components;
    private ExpandableTabControl tabBlotter;
    private TabPage tabPage1;
    private ExpandableTabControl tabReports;
    private TabPage tabPage2;
    private Splitter splitter1;
    private ListView ltvOrders;
    private GroupBox gbxInstrument;
    private ComboBox cbxInstruments;
    private ComboBox cbxSecurityTypes;
    private Label label3;
    private Label label2;
    private Label label1;

    public OrderManagerWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.gbxInstrument.AllowDrop = true;
      this.instrumentLists = new Dictionary<string, List<Instrument>>();
      this.securityTypeItems = new Dictionary<string, SecurityTypeItem>();
      this.instrumentItems = new Dictionary<Instrument, InstrumentItem>();
    }

    protected virtual void OnInit()
    {
      this.tabBlotter.Expanded = this.get_Settings().GetBooleanValue("blotter_expanded", true);
      this.tabReports.Expanded = this.get_Settings().GetBooleanValue("reports_expanded", true);
      foreach (Instrument instrument in (FIXGroupList) InstrumentManager.Instruments)
      {
        List<Instrument> list;
        if (!this.instrumentLists.TryGetValue(instrument.SecurityType, out list))
        {
          list = new List<Instrument>();
          this.instrumentLists.Add(instrument.SecurityType, list);
        }
        list.Add(instrument);
      }
      this.cbxSecurityTypes.BeginUpdate();
      this.cbxSecurityTypes.Items.Clear();
      foreach (string str in this.instrumentLists.Keys)
      {
        SecurityTypeItem securityTypeItem = new SecurityTypeItem(str);
        this.cbxSecurityTypes.Items.Add((object) securityTypeItem);
        this.securityTypeItems.Add(str, securityTypeItem);
      }
      if (this.cbxSecurityTypes.Items.Count > 0)
        this.cbxSecurityTypes.SelectedIndex = 0;
      this.cbxSecurityTypes.EndUpdate();
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      this.get_Settings().SetValue("blotter_expanded", this.tabBlotter.Expanded);
      this.get_Settings().SetValue("reports_expanded", this.tabReports.Expanded);
      ((DockControl) this).OnClosing(e);
    }

    private void cbxSecurityTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateInstrumentList();
    }

    private void cbxInstruments_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.SetSelectedInstrument((this.cbxInstruments.SelectedItem as InstrumentItem).Instrument);
    }

    private void gbxInstrument_DragOver(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (InstrumentList)))
        return;
      e.Effect = DragDropEffects.Move;
    }

    private void gbxInstrument_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (InstrumentList)))
        return;
      InstrumentList instrumentList = (InstrumentList) e.Data.GetData(typeof (InstrumentList));
      this.cbxSecurityTypes.SelectedItem = (object) this.securityTypeItems[instrumentList[0].SecurityType];
      if (instrumentList.Count != 1)
        return;
      this.cbxInstruments.SelectedItem = (object) this.instrumentItems[instrumentList[0]];
    }

    private void UpdateInstrumentList()
    {
      this.instrumentItems.Clear();
      this.cbxInstruments.BeginUpdate();
      this.cbxInstruments.Items.Clear();
      foreach (Instrument instrument in this.instrumentLists[(this.cbxSecurityTypes.SelectedItem as SecurityTypeItem).SecurityType])
      {
        InstrumentItem instrumentItem = new InstrumentItem(instrument);
        this.cbxInstruments.Items.Add((object) instrumentItem);
        this.instrumentItems.Add(instrument, instrumentItem);
      }
      this.cbxInstruments.EndUpdate();
      this.SetSelectedInstrument((Instrument) null);
    }

    private void SetSelectedInstrument(Instrument instrument)
    {
      if (instrument == null)
        Console.WriteLine("NULL");
      else
        Console.WriteLine(instrument.Symbol);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.tabBlotter = new ExpandableTabControl();
      this.tabPage1 = new TabPage();
      this.gbxInstrument = new GroupBox();
      this.cbxInstruments = new ComboBox();
      this.cbxSecurityTypes = new ComboBox();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.tabReports = new ExpandableTabControl();
      this.tabPage2 = new TabPage();
      this.splitter1 = new Splitter();
      this.ltvOrders = new ListView();
      this.tabBlotter.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.gbxInstrument.SuspendLayout();
      this.tabReports.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.tabBlotter.Alignment = TabAlignment.Bottom;
      this.tabBlotter.AllowDrop = true;
      this.tabBlotter.Controls.Add((Control) this.tabPage1);
      this.tabBlotter.Dock = DockStyle.Top;
      this.tabBlotter.Location = new Point(0, 0);
      this.tabBlotter.Name = "tabBlotter";
      this.tabBlotter.SelectedIndex = 0;
      this.tabBlotter.ShowToolTips = true;
      this.tabBlotter.Size = new Size(600, 177);
      this.tabBlotter.TabIndex = 0;
      this.tabPage1.AllowDrop = true;
      this.tabPage1.Controls.Add((Control) this.gbxInstrument);
      this.tabPage1.ImageIndex = 0;
      this.tabPage1.Location = new Point(4, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(592, 150);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Order Blotter";
      this.tabPage1.ToolTipText = "Collapse";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.gbxInstrument.Controls.Add((Control) this.cbxInstruments);
      this.gbxInstrument.Controls.Add((Control) this.cbxSecurityTypes);
      this.gbxInstrument.Controls.Add((Control) this.label3);
      this.gbxInstrument.Controls.Add((Control) this.label2);
      this.gbxInstrument.Controls.Add((Control) this.label1);
      this.gbxInstrument.Location = new Point(9, 10);
      this.gbxInstrument.Name = "gbxInstrument";
      this.gbxInstrument.Size = new Size(222, 124);
      this.gbxInstrument.TabIndex = 0;
      this.gbxInstrument.TabStop = false;
      this.gbxInstrument.Text = "Instrument";
      this.gbxInstrument.DragOver += new DragEventHandler(this.gbxInstrument_DragOver);
      this.gbxInstrument.DragDrop += new DragEventHandler(this.gbxInstrument_DragDrop);
      this.cbxInstruments.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxInstruments.FormattingEnabled = true;
      this.cbxInstruments.Location = new Point(107, 22);
      this.cbxInstruments.Name = "cbxInstruments";
      this.cbxInstruments.Size = new Size(99, 21);
      this.cbxInstruments.Sorted = true;
      this.cbxInstruments.TabIndex = 5;
      this.cbxInstruments.SelectedIndexChanged += new EventHandler(this.cbxInstruments_SelectedIndexChanged);
      this.cbxSecurityTypes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxSecurityTypes.FormattingEnabled = true;
      this.cbxSecurityTypes.Location = new Point(12, 22);
      this.cbxSecurityTypes.Name = "cbxSecurityTypes";
      this.cbxSecurityTypes.Size = new Size(86, 21);
      this.cbxSecurityTypes.Sorted = true;
      this.cbxSecurityTypes.TabIndex = 4;
      this.cbxSecurityTypes.SelectedIndexChanged += new EventHandler(this.cbxSecurityTypes_SelectedIndexChanged);
      this.label3.Location = new Point(153, 55);
      this.label3.Name = "label3";
      this.label3.Size = new Size(40, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Last";
      this.label3.TextAlign = ContentAlignment.MiddleCenter;
      this.label2.Location = new Point(82, 55);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ask";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.label1.Location = new Point(12, 55);
      this.label1.Name = "label1";
      this.label1.Size = new Size(40, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Bid";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.tabReports.Controls.Add((Control) this.tabPage2);
      this.tabReports.Dock = DockStyle.Bottom;
      this.tabReports.Location = new Point(0, 289);
      this.tabReports.Name = "tabReports";
      this.tabReports.SelectedIndex = 0;
      this.tabReports.ShowToolTips = true;
      this.tabReports.Size = new Size(600, 111);
      this.tabReports.TabIndex = 1;
      this.tabPage2.ImageIndex = 1;
      this.tabPage2.Location = new Point(4, 23);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(592, 84);
      this.tabPage2.TabIndex = 0;
      this.tabPage2.Text = "Reports";
      this.tabPage2.ToolTipText = "Collapse";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.splitter1.Dock = DockStyle.Bottom;
      this.splitter1.Location = new Point(0, 285);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(600, 4);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      this.ltvOrders.Dock = DockStyle.Fill;
      this.ltvOrders.FullRowSelect = true;
      this.ltvOrders.GridLines = true;
      this.ltvOrders.HideSelection = false;
      this.ltvOrders.Location = new Point(0, 177);
      this.ltvOrders.MultiSelect = false;
      this.ltvOrders.Name = "ltvOrders";
      this.ltvOrders.ShowGroups = false;
      this.ltvOrders.ShowItemToolTips = true;
      this.ltvOrders.Size = new Size(600, 108);
      this.ltvOrders.TabIndex = 3;
      this.ltvOrders.UseCompatibleStateImageBehavior = false;
      this.ltvOrders.View = View.Details;
      ((DockControl) this).set_AllowDockCenter(true);
      ((Control) this).AllowDrop = true;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.ltvOrders);
      ((Control) this).Controls.Add((Control) this.splitter1);
      ((Control) this).Controls.Add((Control) this.tabReports);
      ((Control) this).Controls.Add((Control) this.tabBlotter);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((DockControl) this).set_FloatingSize(new Size(600, 400));
      ((Control) this).Name = "OrderManagerWindow";
      ((Control) this).Size = new Size(600, 400);
      ((DockControl) this).set_TabImage((Image) Resources.order_manager);
      ((Control) this).Text = "Order Manager";
      this.tabBlotter.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.gbxInstrument.ResumeLayout(false);
      this.tabReports.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }
  }
}
