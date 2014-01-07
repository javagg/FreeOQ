// Type: OpenQuant.Orders.OrderManagerWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.ObjectMap;
using OpenQuant.Properties;
using OpenQuant.Shared;
using OpenQuant.Shared.ToolWindows;
using SmartQuant.Docking.WinForms;
using SmartQuant.Execution;
using SmartQuant.FIX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Orders
{
  public class OrderManagerWindow : DockControl, IPropertyEditable, IUpdateUI
  {
    private IContainer components;
    private TabControl tabOrders;
    private TabPage tabPage1;
    private ListView ltvOrders;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private ListView ltvWorkingOrders;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private ColumnHeader columnHeader14;
    private ColumnHeader columnHeader15;
    private ColumnHeader columnHeader16;
    private ColumnHeader columnHeader17;
    private ColumnHeader columnHeader18;
    private TabPage tabPage4;
    private ListView ltvCancelledOrder;
    private ColumnHeader columnHeader28;
    private ColumnHeader columnHeader29;
    private ColumnHeader columnHeader30;
    private ColumnHeader columnHeader31;
    private ColumnHeader columnHeader32;
    private ColumnHeader columnHeader33;
    private ColumnHeader columnHeader34;
    private ColumnHeader columnHeader35;
    private TabPage tabPage5;
    private ListView ltvRejectedOrders;
    private ColumnHeader columnHeader37;
    private ColumnHeader columnHeader38;
    private ColumnHeader columnHeader39;
    private ColumnHeader columnHeader40;
    private ColumnHeader columnHeader41;
    private ColumnHeader columnHeader42;
    private ColumnHeader columnHeader43;
    private ColumnHeader columnHeader44;
    private ContextMenuStrip ctxOrder;
    private ToolStripMenuItem ctxOrder_Cancel;
    private ColumnHeader columnHeader27;
    private ColumnHeader columnHeader36;
    private ColumnHeader columnHeader45;
    private ColumnHeader columnHeader46;
    private ColumnHeader columnHeader47;
    private ColumnHeader columnHeader48;
    private ColumnHeader columnHeader49;
    private ColumnHeader columnHeader50;
    private ColumnHeader columnHeader51;
    private Splitter splitter1;
    private TabPage tabPage6;
    private ListView ltvReports;
    private ColumnHeader columnHeader52;
    private ColumnHeader columnHeader55;
    private ColumnHeader columnHeader59;
    private ColumnHeader columnHeader56;
    private ColumnHeader columnHeader57;
    private ColumnHeader columnHeader68;
    private ColumnHeader columnHeader58;
    private ColumnHeader columnHeader60;
    private TabControl tabReports;
    private ColumnHeader columnHeader61;
    private ColumnHeader columnHeader62;
    private ColumnHeader columnHeader64;
    private ColumnHeader columnHeader65;
    private ColumnHeader columnHeader53;
    private ListView ltvFilledOrders;
    private ColumnHeader columnHeader19;
    private ColumnHeader columnHeader20;
    private ColumnHeader columnHeader21;
    private ColumnHeader columnHeader22;
    private ColumnHeader columnHeader23;
    private ColumnHeader columnHeader24;
    private ColumnHeader columnHeader25;
    private ColumnHeader columnHeader26;
    private ColumnHeader columnHeader63;
    private ToolStripMenuItem ctxOrder_Modify;
    private ToolStripSeparator toolStripSeparator1;
    private Dictionary<SingleOrder, OrderViewItem> table;
    private Dictionary<SingleOrder, OrderViewItem> workingTable;
    private Dictionary<SingleOrder, OrderViewItem> filledTable;
    private Dictionary<SingleOrder, OrderViewItem> cancelledTable;
    private Dictionary<SingleOrder, OrderViewItem> rejectedTable;
    private SingleOrder reportedOrder;
    private bool asynchEventProcessing;

    public object PropertyObject
    {
      get
      {
        if (this.reportedOrder == null)
          return (object) null;
        else
          return (object) new ReadOnlyTypeDescriptor(((Hashtable) Map.SQ_OQ_Order)[(object) this.reportedOrder]);
      }
    }

    public OrderManagerWindow()
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
      this.components = (IContainer) new Container();
      this.tabOrders = new TabControl();
      this.tabPage1 = new TabPage();
      this.ltvOrders = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.columnHeader61 = new ColumnHeader();
      this.ctxOrder = new ContextMenuStrip(this.components);
      this.ctxOrder_Modify = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxOrder_Cancel = new ToolStripMenuItem();
      this.tabPage2 = new TabPage();
      this.ltvWorkingOrders = new ListView();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.columnHeader13 = new ColumnHeader();
      this.columnHeader14 = new ColumnHeader();
      this.columnHeader15 = new ColumnHeader();
      this.columnHeader16 = new ColumnHeader();
      this.columnHeader17 = new ColumnHeader();
      this.columnHeader18 = new ColumnHeader();
      this.columnHeader62 = new ColumnHeader();
      this.tabPage3 = new TabPage();
      this.ltvFilledOrders = new ListView();
      this.columnHeader19 = new ColumnHeader();
      this.columnHeader20 = new ColumnHeader();
      this.columnHeader21 = new ColumnHeader();
      this.columnHeader22 = new ColumnHeader();
      this.columnHeader23 = new ColumnHeader();
      this.columnHeader24 = new ColumnHeader();
      this.columnHeader25 = new ColumnHeader();
      this.columnHeader26 = new ColumnHeader();
      this.columnHeader63 = new ColumnHeader();
      this.tabPage4 = new TabPage();
      this.ltvCancelledOrder = new ListView();
      this.columnHeader28 = new ColumnHeader();
      this.columnHeader29 = new ColumnHeader();
      this.columnHeader30 = new ColumnHeader();
      this.columnHeader31 = new ColumnHeader();
      this.columnHeader32 = new ColumnHeader();
      this.columnHeader33 = new ColumnHeader();
      this.columnHeader34 = new ColumnHeader();
      this.columnHeader35 = new ColumnHeader();
      this.columnHeader64 = new ColumnHeader();
      this.tabPage5 = new TabPage();
      this.ltvRejectedOrders = new ListView();
      this.columnHeader37 = new ColumnHeader();
      this.columnHeader38 = new ColumnHeader();
      this.columnHeader39 = new ColumnHeader();
      this.columnHeader40 = new ColumnHeader();
      this.columnHeader41 = new ColumnHeader();
      this.columnHeader42 = new ColumnHeader();
      this.columnHeader43 = new ColumnHeader();
      this.columnHeader44 = new ColumnHeader();
      this.columnHeader65 = new ColumnHeader();
      this.columnHeader27 = new ColumnHeader();
      this.columnHeader36 = new ColumnHeader();
      this.columnHeader45 = new ColumnHeader();
      this.columnHeader46 = new ColumnHeader();
      this.columnHeader47 = new ColumnHeader();
      this.columnHeader48 = new ColumnHeader();
      this.columnHeader49 = new ColumnHeader();
      this.columnHeader50 = new ColumnHeader();
      this.columnHeader51 = new ColumnHeader();
      this.splitter1 = new Splitter();
      this.tabPage6 = new TabPage();
      this.ltvReports = new ListView();
      this.columnHeader52 = new ColumnHeader();
      this.columnHeader55 = new ColumnHeader();
      this.columnHeader59 = new ColumnHeader();
      this.columnHeader56 = new ColumnHeader();
      this.columnHeader57 = new ColumnHeader();
      this.columnHeader68 = new ColumnHeader();
      this.columnHeader58 = new ColumnHeader();
      this.columnHeader60 = new ColumnHeader();
      this.columnHeader53 = new ColumnHeader();
      this.tabReports = new TabControl();
      this.tabOrders.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.ctxOrder.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabPage6.SuspendLayout();
      this.tabReports.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.tabOrders.Controls.Add((Control) this.tabPage1);
      this.tabOrders.Controls.Add((Control) this.tabPage2);
      this.tabOrders.Controls.Add((Control) this.tabPage3);
      this.tabOrders.Controls.Add((Control) this.tabPage4);
      this.tabOrders.Controls.Add((Control) this.tabPage5);
      this.tabOrders.Dock = DockStyle.Fill;
      this.tabOrders.Location = new Point(0, 0);
      this.tabOrders.Name = "tabOrders";
      this.tabOrders.SelectedIndex = 0;
      this.tabOrders.Size = new Size(743, 392);
      this.tabOrders.TabIndex = 1;
      this.tabPage1.Controls.Add((Control) this.ltvOrders);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(735, 366);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "All";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.ltvOrders.Columns.AddRange(new ColumnHeader[10]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6,
        this.columnHeader7,
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader61
      });
      this.ltvOrders.ContextMenuStrip = this.ctxOrder;
      this.ltvOrders.Dock = DockStyle.Fill;
      this.ltvOrders.FullRowSelect = true;
      this.ltvOrders.GridLines = true;
      this.ltvOrders.HideSelection = false;
      this.ltvOrders.Location = new Point(3, 3);
      this.ltvOrders.MultiSelect = false;
      this.ltvOrders.Name = "ltvOrders";
      this.ltvOrders.ShowGroups = false;
      this.ltvOrders.ShowItemToolTips = true;
      this.ltvOrders.Size = new Size(729, 360);
      this.ltvOrders.TabIndex = 1;
      this.ltvOrders.UseCompatibleStateImageBehavior = false;
      this.ltvOrders.View = View.Details;
      this.ltvOrders.SelectedIndexChanged += new EventHandler(this.SelectedOrderChanged);
      this.columnHeader1.Text = "DateTime";
      this.columnHeader1.Width = 116;
      this.columnHeader2.Text = "Symbol";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Text = "Side";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Text = "Type";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader5.Text = "Qty";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader6.Text = "Avg. Price";
      this.columnHeader6.TextAlign = HorizontalAlignment.Right;
      this.columnHeader6.Width = 73;
      this.columnHeader7.Text = "Price";
      this.columnHeader7.TextAlign = HorizontalAlignment.Right;
      this.columnHeader8.Text = "Stop Price";
      this.columnHeader8.TextAlign = HorizontalAlignment.Right;
      this.columnHeader8.Width = 72;
      this.columnHeader9.Text = "Status";
      this.columnHeader9.TextAlign = HorizontalAlignment.Right;
      this.columnHeader61.Text = "Text";
      this.columnHeader61.Width = 120;
      this.ctxOrder.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ctxOrder_Modify,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxOrder_Cancel
      });
      this.ctxOrder.Name = "ctxOrder";
      this.ctxOrder.Size = new Size(153, 76);
      this.ctxOrder.Opening += new CancelEventHandler(this.ctxOrder_Opening);
      this.ctxOrder_Modify.Name = "ctxOrder_Modify";
      this.ctxOrder_Modify.Size = new Size(152, 22);
      this.ctxOrder_Modify.Text = "Modify...";
      this.ctxOrder_Modify.Click += new EventHandler(this.ctxOrder_Modify_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(149, 6);
      this.ctxOrder_Cancel.Name = "ctxOrder_Cancel";
      this.ctxOrder_Cancel.Size = new Size(152, 22);
      this.ctxOrder_Cancel.Text = "Cancel";
      this.ctxOrder_Cancel.Click += new EventHandler(this.ctxOrder_Cancel_Click);
      this.tabPage2.Controls.Add((Control) this.ltvWorkingOrders);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(735, 366);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Working";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.ltvWorkingOrders.Columns.AddRange(new ColumnHeader[10]
      {
        this.columnHeader10,
        this.columnHeader11,
        this.columnHeader12,
        this.columnHeader13,
        this.columnHeader14,
        this.columnHeader15,
        this.columnHeader16,
        this.columnHeader17,
        this.columnHeader18,
        this.columnHeader62
      });
      this.ltvWorkingOrders.ContextMenuStrip = this.ctxOrder;
      this.ltvWorkingOrders.Dock = DockStyle.Fill;
      this.ltvWorkingOrders.FullRowSelect = true;
      this.ltvWorkingOrders.GridLines = true;
      this.ltvWorkingOrders.HideSelection = false;
      this.ltvWorkingOrders.Location = new Point(3, 3);
      this.ltvWorkingOrders.MultiSelect = false;
      this.ltvWorkingOrders.Name = "ltvWorkingOrders";
      this.ltvWorkingOrders.ShowGroups = false;
      this.ltvWorkingOrders.ShowItemToolTips = true;
      this.ltvWorkingOrders.Size = new Size(729, 360);
      this.ltvWorkingOrders.TabIndex = 2;
      this.ltvWorkingOrders.UseCompatibleStateImageBehavior = false;
      this.ltvWorkingOrders.View = View.Details;
      this.ltvWorkingOrders.SelectedIndexChanged += new EventHandler(this.SelectedOrderChanged);
      this.columnHeader10.Text = "DateTime";
      this.columnHeader10.Width = 116;
      this.columnHeader11.Text = "Symbol";
      this.columnHeader11.TextAlign = HorizontalAlignment.Right;
      this.columnHeader12.Text = "Side";
      this.columnHeader12.TextAlign = HorizontalAlignment.Right;
      this.columnHeader13.Text = "Type";
      this.columnHeader13.TextAlign = HorizontalAlignment.Right;
      this.columnHeader14.Text = "Qty";
      this.columnHeader14.TextAlign = HorizontalAlignment.Right;
      this.columnHeader15.Text = "Avg. Price";
      this.columnHeader15.TextAlign = HorizontalAlignment.Right;
      this.columnHeader15.Width = 73;
      this.columnHeader16.Text = "Price";
      this.columnHeader16.TextAlign = HorizontalAlignment.Right;
      this.columnHeader17.Text = "Stop Price";
      this.columnHeader17.TextAlign = HorizontalAlignment.Right;
      this.columnHeader17.Width = 72;
      this.columnHeader18.Text = "Status";
      this.columnHeader18.TextAlign = HorizontalAlignment.Right;
      this.columnHeader62.Text = "Text";
      this.columnHeader62.Width = 120;
      this.tabPage3.Controls.Add((Control) this.ltvFilledOrders);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(735, 366);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Filled";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.ltvFilledOrders.Columns.AddRange(new ColumnHeader[9]
      {
        this.columnHeader19,
        this.columnHeader20,
        this.columnHeader21,
        this.columnHeader22,
        this.columnHeader23,
        this.columnHeader24,
        this.columnHeader25,
        this.columnHeader26,
        this.columnHeader63
      });
      this.ltvFilledOrders.Dock = DockStyle.Fill;
      this.ltvFilledOrders.FullRowSelect = true;
      this.ltvFilledOrders.GridLines = true;
      this.ltvFilledOrders.HideSelection = false;
      this.ltvFilledOrders.Location = new Point(3, 3);
      this.ltvFilledOrders.MultiSelect = false;
      this.ltvFilledOrders.Name = "ltvFilledOrders";
      this.ltvFilledOrders.ShowGroups = false;
      this.ltvFilledOrders.ShowItemToolTips = true;
      this.ltvFilledOrders.Size = new Size(729, 360);
      this.ltvFilledOrders.TabIndex = 2;
      this.ltvFilledOrders.UseCompatibleStateImageBehavior = false;
      this.ltvFilledOrders.View = View.Details;
      this.ltvFilledOrders.SelectedIndexChanged += new EventHandler(this.SelectedOrderChanged);
      this.columnHeader19.Text = "DateTime";
      this.columnHeader19.Width = 116;
      this.columnHeader20.Text = "Symbol";
      this.columnHeader20.TextAlign = HorizontalAlignment.Right;
      this.columnHeader21.Text = "Side";
      this.columnHeader21.TextAlign = HorizontalAlignment.Right;
      this.columnHeader22.Text = "Type";
      this.columnHeader22.TextAlign = HorizontalAlignment.Right;
      this.columnHeader23.Text = "Qty";
      this.columnHeader23.TextAlign = HorizontalAlignment.Right;
      this.columnHeader24.Text = "Avg. Price";
      this.columnHeader24.TextAlign = HorizontalAlignment.Right;
      this.columnHeader24.Width = 73;
      this.columnHeader25.Text = "Price";
      this.columnHeader25.TextAlign = HorizontalAlignment.Right;
      this.columnHeader26.Text = "Stop Price";
      this.columnHeader26.TextAlign = HorizontalAlignment.Right;
      this.columnHeader26.Width = 72;
      this.columnHeader63.Text = "Text";
      this.columnHeader63.Width = 120;
      this.tabPage4.Controls.Add((Control) this.ltvCancelledOrder);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(735, 366);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Cancelled";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.ltvCancelledOrder.Columns.AddRange(new ColumnHeader[9]
      {
        this.columnHeader28,
        this.columnHeader29,
        this.columnHeader30,
        this.columnHeader31,
        this.columnHeader32,
        this.columnHeader33,
        this.columnHeader34,
        this.columnHeader35,
        this.columnHeader64
      });
      this.ltvCancelledOrder.Dock = DockStyle.Fill;
      this.ltvCancelledOrder.FullRowSelect = true;
      this.ltvCancelledOrder.GridLines = true;
      this.ltvCancelledOrder.HideSelection = false;
      this.ltvCancelledOrder.Location = new Point(3, 3);
      this.ltvCancelledOrder.MultiSelect = false;
      this.ltvCancelledOrder.Name = "ltvCancelledOrder";
      this.ltvCancelledOrder.ShowGroups = false;
      this.ltvCancelledOrder.ShowItemToolTips = true;
      this.ltvCancelledOrder.Size = new Size(729, 360);
      this.ltvCancelledOrder.TabIndex = 2;
      this.ltvCancelledOrder.UseCompatibleStateImageBehavior = false;
      this.ltvCancelledOrder.View = View.Details;
      this.columnHeader28.Text = "DateTime";
      this.columnHeader28.Width = 116;
      this.columnHeader29.Text = "Symbol";
      this.columnHeader29.TextAlign = HorizontalAlignment.Right;
      this.columnHeader30.Text = "Side";
      this.columnHeader30.TextAlign = HorizontalAlignment.Right;
      this.columnHeader31.Text = "Type";
      this.columnHeader31.TextAlign = HorizontalAlignment.Right;
      this.columnHeader32.Text = "Qty";
      this.columnHeader32.TextAlign = HorizontalAlignment.Right;
      this.columnHeader33.Text = "Avg. Price";
      this.columnHeader33.TextAlign = HorizontalAlignment.Right;
      this.columnHeader33.Width = 73;
      this.columnHeader34.Text = "Price";
      this.columnHeader34.TextAlign = HorizontalAlignment.Right;
      this.columnHeader35.Text = "Stop Price";
      this.columnHeader35.TextAlign = HorizontalAlignment.Right;
      this.columnHeader35.Width = 72;
      this.columnHeader64.Text = "Text";
      this.columnHeader64.Width = 120;
      this.tabPage5.Controls.Add((Control) this.ltvRejectedOrders);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(735, 366);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Rejected";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.ltvRejectedOrders.Columns.AddRange(new ColumnHeader[9]
      {
        this.columnHeader37,
        this.columnHeader38,
        this.columnHeader39,
        this.columnHeader40,
        this.columnHeader41,
        this.columnHeader42,
        this.columnHeader43,
        this.columnHeader44,
        this.columnHeader65
      });
      this.ltvRejectedOrders.Dock = DockStyle.Fill;
      this.ltvRejectedOrders.FullRowSelect = true;
      this.ltvRejectedOrders.GridLines = true;
      this.ltvRejectedOrders.HideSelection = false;
      this.ltvRejectedOrders.Location = new Point(3, 3);
      this.ltvRejectedOrders.MultiSelect = false;
      this.ltvRejectedOrders.Name = "ltvRejectedOrders";
      this.ltvRejectedOrders.ShowGroups = false;
      this.ltvRejectedOrders.ShowItemToolTips = true;
      this.ltvRejectedOrders.Size = new Size(729, 360);
      this.ltvRejectedOrders.TabIndex = 2;
      this.ltvRejectedOrders.UseCompatibleStateImageBehavior = false;
      this.ltvRejectedOrders.View = View.Details;
      this.columnHeader37.Text = "DateTime";
      this.columnHeader37.Width = 116;
      this.columnHeader38.Text = "Symbol";
      this.columnHeader38.TextAlign = HorizontalAlignment.Right;
      this.columnHeader39.Text = "Side";
      this.columnHeader39.TextAlign = HorizontalAlignment.Right;
      this.columnHeader40.Text = "Type";
      this.columnHeader40.TextAlign = HorizontalAlignment.Right;
      this.columnHeader41.Text = "Qty";
      this.columnHeader41.TextAlign = HorizontalAlignment.Right;
      this.columnHeader42.Text = "Avg. Price";
      this.columnHeader42.TextAlign = HorizontalAlignment.Right;
      this.columnHeader42.Width = 73;
      this.columnHeader43.Text = "Price";
      this.columnHeader43.TextAlign = HorizontalAlignment.Right;
      this.columnHeader44.Text = "Stop Price";
      this.columnHeader44.TextAlign = HorizontalAlignment.Right;
      this.columnHeader44.Width = 72;
      this.columnHeader65.Text = "Text";
      this.columnHeader65.Width = 120;
      this.columnHeader27.Text = "DateTime";
      this.columnHeader27.Width = 116;
      this.columnHeader36.Text = "Symbol";
      this.columnHeader36.TextAlign = HorizontalAlignment.Right;
      this.columnHeader45.Text = "Side";
      this.columnHeader45.TextAlign = HorizontalAlignment.Right;
      this.columnHeader46.Text = "Type";
      this.columnHeader46.TextAlign = HorizontalAlignment.Right;
      this.columnHeader47.Text = "Qty";
      this.columnHeader47.TextAlign = HorizontalAlignment.Right;
      this.columnHeader48.Text = "Avg. Price";
      this.columnHeader48.TextAlign = HorizontalAlignment.Right;
      this.columnHeader48.Width = 73;
      this.columnHeader49.Text = "Price";
      this.columnHeader49.TextAlign = HorizontalAlignment.Right;
      this.columnHeader50.Text = "Stop Price";
      this.columnHeader50.TextAlign = HorizontalAlignment.Right;
      this.columnHeader50.Width = 72;
      this.columnHeader51.Text = "Status";
      this.columnHeader51.TextAlign = HorizontalAlignment.Right;
      this.splitter1.Dock = DockStyle.Bottom;
      this.splitter1.Location = new Point(0, 389);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(743, 3);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      this.tabPage6.Controls.Add((Control) this.ltvReports);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Size = new Size(735, 102);
      this.tabPage6.TabIndex = 0;
      this.tabPage6.Text = "Reports";
      this.tabPage6.UseVisualStyleBackColor = true;
      this.ltvReports.BorderStyle = BorderStyle.None;
      this.ltvReports.Columns.AddRange(new ColumnHeader[9]
      {
        this.columnHeader52,
        this.columnHeader55,
        this.columnHeader59,
        this.columnHeader56,
        this.columnHeader57,
        this.columnHeader68,
        this.columnHeader58,
        this.columnHeader60,
        this.columnHeader53
      });
      this.ltvReports.Dock = DockStyle.Fill;
      this.ltvReports.FullRowSelect = true;
      this.ltvReports.GridLines = true;
      this.ltvReports.HideSelection = false;
      this.ltvReports.Location = new Point(0, 0);
      this.ltvReports.MultiSelect = false;
      this.ltvReports.Name = "ltvReports";
      this.ltvReports.ShowGroups = false;
      this.ltvReports.ShowItemToolTips = true;
      this.ltvReports.Size = new Size(735, 102);
      this.ltvReports.TabIndex = 0;
      this.ltvReports.UseCompatibleStateImageBehavior = false;
      this.ltvReports.View = View.Details;
      this.ltvReports.SelectedIndexChanged += new EventHandler(this.SelectedReportChanged);
      this.columnHeader52.Text = "TransactTime";
      this.columnHeader52.Width = 97;
      this.columnHeader55.Text = "OrdStatus";
      this.columnHeader55.TextAlign = HorizontalAlignment.Right;
      this.columnHeader55.Width = 74;
      this.columnHeader59.Text = "OrderQty";
      this.columnHeader59.TextAlign = HorizontalAlignment.Right;
      this.columnHeader59.Width = 75;
      this.columnHeader56.Text = "CumQty";
      this.columnHeader56.TextAlign = HorizontalAlignment.Right;
      this.columnHeader56.Width = 67;
      this.columnHeader57.Text = "LeavesQty";
      this.columnHeader57.TextAlign = HorizontalAlignment.Right;
      this.columnHeader57.Width = 73;
      this.columnHeader68.Text = "LastQty";
      this.columnHeader68.TextAlign = HorizontalAlignment.Right;
      this.columnHeader68.Width = 71;
      this.columnHeader58.Text = "LastPx";
      this.columnHeader58.TextAlign = HorizontalAlignment.Right;
      this.columnHeader58.Width = 64;
      this.columnHeader60.Text = "AvgPx";
      this.columnHeader60.TextAlign = HorizontalAlignment.Right;
      this.columnHeader60.Width = 63;
      this.columnHeader53.Text = "Text";
      this.columnHeader53.Width = 100;
      this.tabReports.Controls.Add((Control) this.tabPage6);
      this.tabReports.Dock = DockStyle.Bottom;
      this.tabReports.Location = new Point(0, 392);
      this.tabReports.Name = "tabReports";
      this.tabReports.SelectedIndex = 0;
      this.tabReports.Size = new Size(743, 128);
      this.tabReports.TabIndex = 4;
      ((DockControl) this).set_AllowDockCenter(true);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.splitter1);
      ((Control) this).Controls.Add((Control) this.tabOrders);
      ((Control) this).Controls.Add((Control) this.tabReports);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "OrderManagerWindow";
      ((Control) this).Size = new Size(743, 520);
      ((DockControl) this).set_TabImage((Image) Resources.order_manager);
      ((Control) this).Text = "Order Manager";
      this.tabOrders.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.ctxOrder.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      this.tabPage6.ResumeLayout(false);
      this.tabReports.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      this.asynchEventProcessing = Configuration.get_ActiveMode() != 0;
      if (Global.Flags.UpdateUI || !Runner.IsRunning)
        this.UpdateView();
      OrderManager.NewOrder += new OrderEventHandler(this.OrderManager_NewOrder);
      OrderManager.OrderRemoved += new OrderEventHandler(this.OrderManager_OrderRemoved);
      OrderManager.OrderStatusChanged += new OrderEventHandler(this.OrderManager_OrderStatusChanged);
      OrderManager.OrderListUpdated += new EventHandler(this.OrderManager_OrderListUpdated);
      OrderManager.ExecutionReport += new ExecutionReportEventHandler(this.OrderManager_ExecutionReport);
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.asynchEventProcessing = Configuration.get_ActiveMode() != 0;
    }

    private void OrderManager_ExecutionReport(object sender, ExecutionReportEventArgs args)
    {
      SingleOrder order = args.ExecutionReport.ExecType == ExecType.PendingCancel || args.ExecutionReport.ExecType == ExecType.Cancelled || args.ExecutionReport.ExecType == ExecType.PendingReplace ? OrderManager.Orders.All[args.ExecutionReport.OrigClOrdID] as SingleOrder : OrderManager.Orders.All[args.ExecutionReport.ClOrdID] as SingleOrder;
      if (order == this.reportedOrder)
        ((Control) this).Invoke((Delegate) (() => this.ltvReports.Items.Insert(0, (ListViewItem) new ExecutionReportViewItem(args.ExecutionReport))));
      if (order.IsDone || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() =>
      {
        this.table[order].Update();
        this.workingTable[order].Update();
      }));
    }

    public void UpdateUI()
    {
      ((Control) this).Invoke((Delegate) (() => this.Reset()));
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      OrderManager.NewOrder -= new OrderEventHandler(this.OrderManager_NewOrder);
      OrderManager.OrderRemoved -= new OrderEventHandler(this.OrderManager_OrderRemoved);
      OrderManager.OrderStatusChanged -= new OrderEventHandler(this.OrderManager_OrderStatusChanged);
      OrderManager.OrderListUpdated -= new EventHandler(this.OrderManager_OrderListUpdated);
      OrderManager.ExecutionReport -= new ExecutionReportEventHandler(this.OrderManager_ExecutionReport);
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    private void UpdateView()
    {
      this.ltvOrders.BeginUpdate();
      this.ltvCancelledOrder.BeginUpdate();
      this.ltvFilledOrders.BeginUpdate();
      this.ltvRejectedOrders.BeginUpdate();
      this.ltvWorkingOrders.BeginUpdate();
      this.ltvOrders.Items.Clear();
      this.ltvCancelledOrder.Items.Clear();
      this.ltvFilledOrders.Items.Clear();
      this.ltvRejectedOrders.Items.Clear();
      this.ltvWorkingOrders.Items.Clear();
      for (int index1 = 0; index1 < OrderManager.Orders.All.Count; ++index1)
      {
        SingleOrder index2 = OrderManager.Orders.All[index1] as SingleOrder;
        OrderViewItem orderViewItem1 = new OrderViewItem(index2);
        this.table.Add(index2, orderViewItem1);
        this.ltvOrders.Items.Insert(0, (ListViewItem) orderViewItem1);
        switch (index2.OrdStatus)
        {
          case OrdStatus.Filled:
            OrderViewItem orderViewItem2 = new OrderViewItem(index2);
            this.ltvFilledOrders.Items.Insert(0, (ListViewItem) orderViewItem2);
            this.filledTable[index2] = orderViewItem2;
            break;
          case OrdStatus.Cancelled:
            OrderViewItem orderViewItem3 = new OrderViewItem(index2);
            this.ltvCancelledOrder.Items.Insert(0, (ListViewItem) orderViewItem3);
            this.cancelledTable[index2] = orderViewItem3;
            break;
          case OrdStatus.Rejected:
            OrderViewItem orderViewItem4 = new OrderViewItem(index2);
            this.ltvRejectedOrders.Items.Insert(0, (ListViewItem) orderViewItem4);
            this.rejectedTable[index2] = orderViewItem4;
            break;
          default:
            OrderViewItem orderViewItem5 = new OrderViewItem(index2);
            this.ltvWorkingOrders.Items.Insert(0, (ListViewItem) orderViewItem5);
            this.workingTable[index2] = orderViewItem5;
            break;
        }
      }
      this.ltvOrders.EndUpdate();
      this.ltvCancelledOrder.EndUpdate();
      this.ltvFilledOrders.EndUpdate();
      this.ltvRejectedOrders.EndUpdate();
      this.ltvWorkingOrders.EndUpdate();
    }

    private void Reset()
    {
      this.table.Clear();
      this.workingTable.Clear();
      this.filledTable.Clear();
      this.cancelledTable.Clear();
      this.rejectedTable.Clear();
      this.UpdateView();
      this.ltvReports.Items.Clear();
      this.reportedOrder = (SingleOrder) null;
    }

    private void OrderManager_OrderListUpdated(object sender, EventArgs e)
    {
      MethodInvoker methodInvoker = (MethodInvoker) (() => this.Reset());
      if (this.asynchEventProcessing)
        ((Control) this).BeginInvoke((Delegate) methodInvoker);
      else
        ((Control) this).Invoke((Delegate) methodInvoker);
    }

    private void OrderManager_NewOrder(OrderEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      MethodInvoker methodInvoker = (MethodInvoker) (() =>
      {
        try
        {
          SingleOrder local_0 = args.Order;
          OrderViewItem local_1 = new OrderViewItem(local_0);
          this.table.Add(args.Order, local_1);
          this.ltvOrders.Items.Insert(0, (ListViewItem) local_1);
          OrderViewItem local_2 = new OrderViewItem(local_0);
          this.workingTable.Add(local_0, local_2);
          this.ltvWorkingOrders.Items.Insert(0, (ListViewItem) local_2);
          Application.DoEvents();
        }
        catch (Exception exception_0)
        {
          Console.WriteLine(((object) exception_0).ToString());
        }
      });
      if (this.asynchEventProcessing)
        ((Control) this).BeginInvoke((Delegate) methodInvoker);
      else
        ((Control) this).Invoke((Delegate) methodInvoker);
    }

    private void OrderManager_OrderRemoved(OrderEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      MethodInvoker methodInvoker = (MethodInvoker) (() =>
      {
        try
        {
          SingleOrder local_0 = args.Order;
          OrderViewItem local_1;
          if (this.table.TryGetValue(local_0, out local_1))
          {
            this.table.Remove(local_0);
            local_1.Remove();
          }
          if (this.filledTable.TryGetValue(local_0, out local_1))
          {
            this.filledTable.Remove(local_0);
            local_1.Remove();
          }
          if (this.cancelledTable.TryGetValue(local_0, out local_1))
          {
            this.cancelledTable.Remove(local_0);
            local_1.Remove();
          }
          if (this.rejectedTable.TryGetValue(local_0, out local_1))
          {
            this.rejectedTable.Remove(local_0);
            local_1.Remove();
          }
          if (local_0 != this.reportedOrder)
            return;
          this.reportedOrder = (SingleOrder) null;
          this.ltvReports.Items.Clear();
          this.tabReports.TabPages[0].Text = "Reports";
        }
        catch (Exception exception_0)
        {
          Console.WriteLine(((object) exception_0).ToString());
        }
      });
      if (this.asynchEventProcessing)
        ((Control) this).BeginInvoke((Delegate) methodInvoker);
      else
        ((Control) this).Invoke((Delegate) methodInvoker);
    }

    private void OrderManager_OrderStatusChanged(OrderEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      MethodInvoker methodInvoker = (MethodInvoker) (() =>
      {
        try
        {
          SingleOrder local_0 = args.Order;
          this.table[local_0].Update();
          OrderViewItem local_2 = this.workingTable[local_0];
          switch (local_0.OrdStatus)
          {
            case OrdStatus.Filled:
              local_2.Remove();
              OrderViewItem local_3 = new OrderViewItem(local_0);
              this.ltvFilledOrders.Items.Insert(0, (ListViewItem) local_3);
              this.filledTable[local_0] = local_3;
              break;
            case OrdStatus.Cancelled:
              local_2.Remove();
              OrderViewItem local_4 = new OrderViewItem(local_0);
              this.ltvCancelledOrder.Items.Insert(0, (ListViewItem) local_4);
              this.cancelledTable[local_0] = local_4;
              break;
            case OrdStatus.Rejected:
              local_2.Remove();
              OrderViewItem local_5 = new OrderViewItem(local_0);
              this.ltvRejectedOrders.Items.Insert(0, (ListViewItem) local_5);
              this.rejectedTable[local_0] = local_5;
              break;
          }
          Application.DoEvents();
        }
        catch (Exception exception_0)
        {
          Console.WriteLine(((object) exception_0).ToString());
        }
      });
      if (this.asynchEventProcessing)
        ((Control) this).BeginInvoke((Delegate) methodInvoker);
      else
        ((Control) this).Invoke((Delegate) methodInvoker);
    }

    private void ctxOrder_Cancel_Click(object sender, EventArgs e)
    {
      ListView listView;
      switch (this.tabOrders.SelectedIndex)
      {
        case 0:
          listView = this.ltvOrders;
          break;
        case 1:
          listView = this.ltvWorkingOrders;
          break;
        default:
          throw new ArgumentException("The page with given index does not support ContextMenu");
      }
      (listView.SelectedItems[0] as OrderViewItem).Order.Cancel();
    }

    private void ctxOrder_Modify_Click(object sender, EventArgs e)
    {
      ListView listView;
      switch (this.tabOrders.SelectedIndex)
      {
        case 0:
          listView = this.ltvOrders;
          break;
        case 1:
          listView = this.ltvWorkingOrders;
          break;
        default:
          throw new ArgumentException("The page with given index does not support ContextMenu");
      }
      SingleOrder order = (listView.SelectedItems[0] as OrderViewItem).Order;
      ModifyOrderForm modifyOrderForm = new ModifyOrderForm();
      modifyOrderForm.Init(order);
      if (modifyOrderForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        order.ReplaceOrder.Price = modifyOrderForm.LimitPrice;
        order.ReplaceOrder.StopPx = modifyOrderForm.StopPrice;
        order.ReplaceOrder.OrderQty = (double) modifyOrderForm.Qty;
        order.Replace();
      }
      modifyOrderForm.Dispose();
    }

    private void ctxOrder_Opening(object sender, CancelEventArgs e)
    {
      ListView listView;
      switch (this.tabOrders.SelectedIndex)
      {
        case 0:
          listView = this.ltvOrders;
          break;
        case 1:
          listView = this.ltvWorkingOrders;
          break;
        default:
          throw new ArgumentException("The page with given index does not support ContextMenu");
      }
      if (listView.SelectedItems.Count == 1)
      {
        SingleOrder order = (listView.SelectedItems[0] as OrderViewItem).Order;
        this.ctxOrder_Modify.Enabled = !order.IsDone;
        this.ctxOrder_Cancel.Enabled = !order.IsDone;
      }
      else
      {
        this.ctxOrder_Modify.Enabled = false;
        this.ctxOrder_Cancel.Enabled = false;
      }
    }

    private void SelectedOrderChanged(object sender, EventArgs e)
    {
      if ((sender as ListView).SelectedItems.Count == 0)
        return;
      SingleOrder order = ((sender as ListView).SelectedItems[0] as OrderViewItem).Order;
      this.tabReports.TabPages[0].Text = "Reports - " + order.ClOrdID;
      this.ltvReports.BeginUpdate();
      this.ltvReports.Items.Clear();
      foreach (ExecutionReport report in (FIXGroupList) order.Reports)
        this.ltvReports.Items.Insert(0, (ListViewItem) new ExecutionReportViewItem(report));
      this.ltvReports.EndUpdate();
      this.reportedOrder = order;
      Global.get_ToolWindowManager().ShowProperties((IPropertyEditable) this, false);
    }

    private void SelectedReportChanged(object sender, EventArgs e)
    {
    }
  }
}
