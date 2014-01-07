// Type: OpenQuant.BrokerInfo.BrokerInfoWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Config;
using OpenQuant.Properties;
using SmartQuant.Docking.WinForms;
using SmartQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.BrokerInfo
{
  internal class BrokerInfoWindow : DockControl
  {
    private IContainer components;
    private ToolStrip toolStrip;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripLabel toolStripLabel1;
    private ToolStripComboBox cbxAccounts;
    private ToolStripStatusLabel toolStripStatusLabel2;
    private ToolStripStatusLabel toolStripStatusLabel3;
    private ToolStripButton tsbRefresh;
    private TabControl tabControl;
    private TabPage tabPage1;
    private ListView ltvAccountFields;
    private ImageList imgAccountFields;
    private TabPage tabPage2;
    private ListView ltvPositions;
    private TabControl tabControl1;
    private TabPage tabPage3;
    private ListView ltvPositionFields;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ImageList imgPositionFields;
    private Splitter splitter1;
    private ImageList imgPositions;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private TabPage tabPage4;
    private ListView ltvOrders;
    private ImageList imgOrders;
    private ImageList imgOrderFields;
    private TabControl tabControl2;
    private TabPage tabPage5;
    private ListView ltvOrderFields;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private Splitter splitter2;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private ColumnHeader columnHeader14;
    private ColumnHeader columnHeader15;
    private ColumnHeader columnHeader16;
    private ColumnHeader columnHeader17;
    private IExecutionProvider provider;

    public BrokerInfoWindow()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BrokerInfoWindow));
      this.toolStrip = new ToolStrip();
      this.toolStripLabel1 = new ToolStripLabel();
      this.cbxAccounts = new ToolStripComboBox();
      this.tsbRefresh = new ToolStripButton();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabel2 = new ToolStripStatusLabel();
      this.toolStripStatusLabel3 = new ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.tabControl = new TabControl();
      this.tabPage1 = new TabPage();
      this.ltvAccountFields = new ListView();
      this.imgAccountFields = new ImageList(this.components);
      this.tabPage2 = new TabPage();
      this.tabControl1 = new TabControl();
      this.tabPage3 = new TabPage();
      this.ltvPositionFields = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.imgPositionFields = new ImageList(this.components);
      this.splitter1 = new Splitter();
      this.ltvPositions = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.imgPositions = new ImageList(this.components);
      this.tabPage4 = new TabPage();
      this.tabControl2 = new TabControl();
      this.tabPage5 = new TabPage();
      this.ltvOrderFields = new ListView();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.imgOrderFields = new ImageList(this.components);
      this.splitter2 = new Splitter();
      this.ltvOrders = new ListView();
      this.columnHeader17 = new ColumnHeader();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.columnHeader13 = new ColumnHeader();
      this.columnHeader14 = new ColumnHeader();
      this.columnHeader15 = new ColumnHeader();
      this.columnHeader16 = new ColumnHeader();
      this.imgOrders = new ImageList(this.components);
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage5.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.toolStrip.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripLabel1,
        (ToolStripItem) this.cbxAccounts,
        (ToolStripItem) this.tsbRefresh
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(557, 25);
      this.toolStrip.TabIndex = 0;
      this.toolStrip.Text = "toolStrip1";
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new Size(50, 22);
      this.toolStripLabel1.Text = "Account:";
      this.cbxAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxAccounts.Name = "cbxAccounts";
      this.cbxAccounts.Size = new Size(121, 25);
      this.cbxAccounts.Sorted = true;
      this.cbxAccounts.SelectedIndexChanged += new EventHandler(this.cbxAccounts_SelectedIndexChanged);
      this.tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbRefresh.Image = (Image) Resources.refresh;
      this.tsbRefresh.ImageTransparentColor = Color.Magenta;
      this.tsbRefresh.Name = "tsbRefresh";
      this.tsbRefresh.Size = new Size(23, 22);
      this.tsbRefresh.Text = "toolStripButton1";
      this.tsbRefresh.ToolTipText = "Refresh account list";
      this.tsbRefresh.Click += new EventHandler(this.tsbRefresh_Click);
      this.statusStrip.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripStatusLabel2,
        (ToolStripItem) this.toolStripStatusLabel3,
        (ToolStripItem) this.toolStripStatusLabel1
      });
      this.statusStrip.Location = new Point(0, 378);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(557, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip1";
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new Size(76, 17);
      this.toolStripStatusLabel2.Text = "Buying Power:";
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new Size(466, 17);
      this.toolStripStatusLabel3.Spring = true;
      this.toolStripStatusLabel3.Text = "0";
      this.toolStripStatusLabel3.TextAlign = ContentAlignment.MiddleLeft;
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(0, 17);
      this.tabControl.Controls.Add((Control) this.tabPage1);
      this.tabControl.Controls.Add((Control) this.tabPage2);
      this.tabControl.Controls.Add((Control) this.tabPage4);
      this.tabControl.Dock = DockStyle.Fill;
      this.tabControl.Location = new Point(0, 25);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new Size(557, 353);
      this.tabControl.TabIndex = 2;
      this.tabPage1.Controls.Add((Control) this.ltvAccountFields);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(549, 327);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Fields";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.ltvAccountFields.Dock = DockStyle.Fill;
      this.ltvAccountFields.FullRowSelect = true;
      this.ltvAccountFields.GridLines = true;
      this.ltvAccountFields.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvAccountFields.Location = new Point(3, 3);
      this.ltvAccountFields.Name = "ltvAccountFields";
      this.ltvAccountFields.ShowGroups = false;
      this.ltvAccountFields.ShowItemToolTips = true;
      this.ltvAccountFields.Size = new Size(543, 321);
      this.ltvAccountFields.SmallImageList = this.imgAccountFields;
      this.ltvAccountFields.Sorting = SortOrder.Ascending;
      this.ltvAccountFields.TabIndex = 0;
      this.ltvAccountFields.UseCompatibleStateImageBehavior = false;
      this.ltvAccountFields.View = View.Details;
      this.imgAccountFields.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgAccountFields.ImageStream");
      this.imgAccountFields.TransparentColor = Color.Transparent;
      this.imgAccountFields.Images.SetKeyName(0, "field.png");
      this.tabPage2.Controls.Add((Control) this.tabControl1);
      this.tabPage2.Controls.Add((Control) this.splitter1);
      this.tabPage2.Controls.Add((Control) this.ltvPositions);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(549, 327);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Positions";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(3, 142);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(543, 182);
      this.tabControl1.TabIndex = 2;
      this.tabPage3.Controls.Add((Control) this.ltvPositionFields);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(535, 156);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Fields";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.ltvPositionFields.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader1,
        this.columnHeader2
      });
      this.ltvPositionFields.Dock = DockStyle.Fill;
      this.ltvPositionFields.FullRowSelect = true;
      this.ltvPositionFields.GridLines = true;
      this.ltvPositionFields.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvPositionFields.Location = new Point(3, 3);
      this.ltvPositionFields.MultiSelect = false;
      this.ltvPositionFields.Name = "ltvPositionFields";
      this.ltvPositionFields.ShowGroups = false;
      this.ltvPositionFields.ShowItemToolTips = true;
      this.ltvPositionFields.Size = new Size(529, 150);
      this.ltvPositionFields.SmallImageList = this.imgPositionFields;
      this.ltvPositionFields.Sorting = SortOrder.Ascending;
      this.ltvPositionFields.TabIndex = 0;
      this.ltvPositionFields.UseCompatibleStateImageBehavior = false;
      this.ltvPositionFields.View = View.Details;
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 131;
      this.columnHeader2.Text = "Value";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 143;
      this.imgPositionFields.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgPositionFields.ImageStream");
      this.imgPositionFields.TransparentColor = Color.Transparent;
      this.imgPositionFields.Images.SetKeyName(0, "field.png");
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new Point(3, 138);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(543, 4);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      this.ltvPositions.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6,
        this.columnHeader7
      });
      this.ltvPositions.Dock = DockStyle.Top;
      this.ltvPositions.FullRowSelect = true;
      this.ltvPositions.GridLines = true;
      this.ltvPositions.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvPositions.HideSelection = false;
      this.ltvPositions.Location = new Point(3, 3);
      this.ltvPositions.MultiSelect = false;
      this.ltvPositions.Name = "ltvPositions";
      this.ltvPositions.ShowGroups = false;
      this.ltvPositions.ShowItemToolTips = true;
      this.ltvPositions.Size = new Size(543, 135);
      this.ltvPositions.SmallImageList = this.imgPositions;
      this.ltvPositions.Sorting = SortOrder.Ascending;
      this.ltvPositions.TabIndex = 0;
      this.ltvPositions.UseCompatibleStateImageBehavior = false;
      this.ltvPositions.View = View.Details;
      this.ltvPositions.SelectedIndexChanged += new EventHandler(this.ltvPositions_SelectedIndexChanged);
      this.columnHeader3.Text = "Contract";
      this.columnHeader3.Width = 142;
      this.columnHeader4.Text = "Exchange";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 71;
      this.columnHeader5.Text = "Currency";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader5.Width = 76;
      this.columnHeader6.Text = "Long";
      this.columnHeader6.TextAlign = HorizontalAlignment.Right;
      this.columnHeader6.Width = 84;
      this.columnHeader7.Text = "Short";
      this.columnHeader7.TextAlign = HorizontalAlignment.Right;
      this.columnHeader7.Width = 91;
      this.imgPositions.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgPositions.ImageStream");
      this.imgPositions.TransparentColor = Color.Transparent;
      this.imgPositions.Images.SetKeyName(0, "position.png");
      this.tabPage4.Controls.Add((Control) this.tabControl2);
      this.tabPage4.Controls.Add((Control) this.splitter2);
      this.tabPage4.Controls.Add((Control) this.ltvOrders);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(549, 327);
      this.tabPage4.TabIndex = 2;
      this.tabPage4.Text = "Orders";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.tabControl2.Controls.Add((Control) this.tabPage5);
      this.tabControl2.Dock = DockStyle.Fill;
      this.tabControl2.Location = new Point(3, 143);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(543, 181);
      this.tabControl2.TabIndex = 2;
      this.tabPage5.Controls.Add((Control) this.ltvOrderFields);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(535, 155);
      this.tabPage5.TabIndex = 0;
      this.tabPage5.Text = "Fields";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.ltvOrderFields.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader8,
        this.columnHeader9
      });
      this.ltvOrderFields.Dock = DockStyle.Fill;
      this.ltvOrderFields.FullRowSelect = true;
      this.ltvOrderFields.GridLines = true;
      this.ltvOrderFields.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvOrderFields.LabelWrap = false;
      this.ltvOrderFields.Location = new Point(3, 3);
      this.ltvOrderFields.MultiSelect = false;
      this.ltvOrderFields.Name = "ltvOrderFields";
      this.ltvOrderFields.ShowGroups = false;
      this.ltvOrderFields.ShowItemToolTips = true;
      this.ltvOrderFields.Size = new Size(529, 149);
      this.ltvOrderFields.SmallImageList = this.imgOrderFields;
      this.ltvOrderFields.Sorting = SortOrder.Ascending;
      this.ltvOrderFields.TabIndex = 0;
      this.ltvOrderFields.UseCompatibleStateImageBehavior = false;
      this.ltvOrderFields.View = View.Details;
      this.columnHeader8.Text = "Name";
      this.columnHeader8.Width = 138;
      this.columnHeader9.Text = "Value";
      this.columnHeader9.TextAlign = HorizontalAlignment.Right;
      this.columnHeader9.Width = 133;
      this.imgOrderFields.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgOrderFields.ImageStream");
      this.imgOrderFields.TransparentColor = Color.Transparent;
      this.imgOrderFields.Images.SetKeyName(0, "field.png");
      this.splitter2.Dock = DockStyle.Top;
      this.splitter2.Location = new Point(3, 139);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new Size(543, 4);
      this.splitter2.TabIndex = 1;
      this.splitter2.TabStop = false;
      this.ltvOrders.Columns.AddRange(new ColumnHeader[8]
      {
        this.columnHeader17,
        this.columnHeader10,
        this.columnHeader11,
        this.columnHeader12,
        this.columnHeader13,
        this.columnHeader14,
        this.columnHeader15,
        this.columnHeader16
      });
      this.ltvOrders.Dock = DockStyle.Top;
      this.ltvOrders.FullRowSelect = true;
      this.ltvOrders.GridLines = true;
      this.ltvOrders.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvOrders.HideSelection = false;
      this.ltvOrders.LabelWrap = false;
      this.ltvOrders.Location = new Point(3, 3);
      this.ltvOrders.MultiSelect = false;
      this.ltvOrders.Name = "ltvOrders";
      this.ltvOrders.ShowGroups = false;
      this.ltvOrders.ShowItemToolTips = true;
      this.ltvOrders.Size = new Size(543, 136);
      this.ltvOrders.SmallImageList = this.imgOrders;
      this.ltvOrders.TabIndex = 0;
      this.ltvOrders.UseCompatibleStateImageBehavior = false;
      this.ltvOrders.View = View.Details;
      this.ltvOrders.SelectedIndexChanged += new EventHandler(this.ltvOrders_SelectedIndexChanged);
      this.columnHeader17.Text = "OrderID";
      this.columnHeader10.Text = "Symbol";
      this.columnHeader10.TextAlign = HorizontalAlignment.Right;
      this.columnHeader10.Width = 70;
      this.columnHeader11.Text = "Side";
      this.columnHeader11.TextAlign = HorizontalAlignment.Right;
      this.columnHeader11.Width = 66;
      this.columnHeader12.Text = "Type";
      this.columnHeader12.TextAlign = HorizontalAlignment.Right;
      this.columnHeader13.Text = "Qty";
      this.columnHeader13.TextAlign = HorizontalAlignment.Right;
      this.columnHeader14.Text = "Price";
      this.columnHeader14.TextAlign = HorizontalAlignment.Right;
      this.columnHeader14.Width = 67;
      this.columnHeader15.Text = "Stop Price";
      this.columnHeader15.TextAlign = HorizontalAlignment.Right;
      this.columnHeader15.Width = 75;
      this.columnHeader16.Text = "Status";
      this.columnHeader16.TextAlign = HorizontalAlignment.Right;
      this.columnHeader16.Width = 70;
      this.imgOrders.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgOrders.ImageStream");
      this.imgOrders.TransparentColor = Color.Transparent;
      this.imgOrders.Images.SetKeyName(0, "order.png");
      ((DockControl) this).set_AllowDockCenter(true);
      ((DockControl) this).set_AllowDockLeft(false);
      ((DockControl) this).set_AllowDockRight(false);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.tabControl);
      ((Control) this).Controls.Add((Control) this.statusStrip);
      ((Control) this).Controls.Add((Control) this.toolStrip);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "BrokerInfoWindow";
      ((Control) this).Size = new Size(557, 400);
      ((DockControl) this).set_TabImage((Image) Resources.broker_info);
      ((Control) this).Text = "Broker Info";
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.tabControl.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }

    protected virtual void OnInit()
    {
      this.Init();
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      ProviderManager.Connected += new ProviderEventHandler(this.ProviderManager_Connected);
      ProviderManager.Disconnected += new ProviderEventHandler(this.ProviderManager_Disconnected);
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      ProviderManager.Connected -= new ProviderEventHandler(this.ProviderManager_Connected);
      ProviderManager.Disconnected -= new ProviderEventHandler(this.ProviderManager_Disconnected);
      ((DockControl) this).OnClosing(e);
    }

    private void cbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateAccountInformation();
    }

    private void tsbRefresh_Click(object sender, EventArgs e)
    {
      this.Init();
    }

    private void ltvPositions_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdatePositionFields(this.ltvPositions.SelectedItems.Count == 1 ? (this.ltvPositions.SelectedItems[0] as BrokerPositionViewItem).Position : (BrokerPosition) null);
    }

    private void ltvOrders_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateOrderFields(this.ltvOrders.SelectedItems.Count == 1 ? ((BrokerOrderViewItem) this.ltvOrders.SelectedItems[0]).Order : (BrokerOrder) null);
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.Init();
    }

    private void ProviderManager_Connected(ProviderEventArgs args)
    {
      if (args.Provider != this.provider)
        return;
      ((Control) this).Invoke((Delegate) (() => this.UpdateProviderStatus()));
    }

    private void ProviderManager_Disconnected(ProviderEventArgs args)
    {
      if (args.Provider != this.provider)
        return;
      ((Control) this).Invoke((Delegate) (() => this.UpdateProviderStatus()));
    }

    private void UpdateProviderStatus()
    {
      if (this.provider.IsConnected)
      {
        this.statusStrip.Items[2].Image = (Image) Resources.provider_connected;
        this.statusStrip.Items[2].Text = "Connected.";
      }
      else
      {
        this.statusStrip.Items[2].Image = (Image) Resources.provider_disconnected;
        this.statusStrip.Items[2].Text = "Not connected.";
      }
    }

    private void Init()
    {
      this.provider = Configuration.get_Active().get_ExecutionProvider();
      this.cbxAccounts.BeginUpdate();
      this.cbxAccounts.Items.Clear();
      if (this.provider.IsConnected)
      {
        foreach (BrokerAccount account in this.provider.GetBrokerInfo().Accounts)
          this.cbxAccounts.Items.Add((object) new BrokerAccountItem(account));
      }
      this.cbxAccounts.EndUpdate();
      if (this.cbxAccounts.Items.Count > 0)
        this.cbxAccounts.SelectedIndex = 0;
      else
        this.UpdateAccountInformation();
      this.UpdateProviderStatus();
    }

    private void UpdateAccountInformation()
    {
      BrokerAccount account = this.cbxAccounts.SelectedItem == null ? (BrokerAccount) null : (this.cbxAccounts.SelectedItem as BrokerAccountItem).Account;
      this.UpdateAccountFields(account);
      this.UpdateAccountPositions(account);
      this.UpdateAccountOrders(account);
      this.statusStrip.Items[1].Text = account == null ? "0" : account.BuyingPower.ToString("n");
    }

    private void UpdateAccountFields(BrokerAccount account)
    {
      this.ltvAccountFields.BeginUpdate();
      this.ltvAccountFields.Clear();
      if (account != null)
      {
        BrokerAccountField[] fields = account.GetFields();
        SortedList<string, ColumnHeader> sortedList = new SortedList<string, ColumnHeader>();
        foreach (BrokerAccountField brokerAccountField in fields)
        {
          if (!sortedList.ContainsKey(brokerAccountField.Currency))
            sortedList.Add(brokerAccountField.Currency, new ColumnHeader()
            {
              Text = brokerAccountField.Currency,
              TextAlign = HorizontalAlignment.Right,
              Width = 100
            });
        }
        this.ltvAccountFields.Columns.Add("Name", 120, HorizontalAlignment.Left);
        this.ltvAccountFields.Columns.AddRange(new List<ColumnHeader>((IEnumerable<ColumnHeader>) sortedList.Values).ToArray());
        Dictionary<string, ListViewItem> dictionary = new Dictionary<string, ListViewItem>();
        foreach (BrokerAccountField brokerAccountField in fields)
        {
          ListViewItem listViewItem;
          if (!dictionary.TryGetValue(brokerAccountField.Name, out listViewItem))
          {
            listViewItem = new ListViewItem(new string[this.ltvAccountFields.Columns.Count], 0);
            dictionary.Add(brokerAccountField.Name, listViewItem);
            listViewItem.SubItems[0].Text = brokerAccountField.Name;
            this.ltvAccountFields.Items.Add(listViewItem);
          }
          listViewItem.SubItems[sortedList.IndexOfKey(brokerAccountField.Currency) + 1].Text = brokerAccountField.Value;
        }
      }
      this.ltvAccountFields.EndUpdate();
    }

    private void UpdateAccountPositions(BrokerAccount account)
    {
      this.ltvPositions.BeginUpdate();
      this.ltvPositions.Items.Clear();
      if (account != null)
      {
        foreach (BrokerPosition position in account.GetPositions())
          this.ltvPositions.Items.Add((ListViewItem) new BrokerPositionViewItem(position));
      }
      this.ltvPositions.EndUpdate();
      this.UpdatePositionFields((BrokerPosition) null);
    }

    private void UpdatePositionFields(BrokerPosition position)
    {
      this.ltvPositionFields.BeginUpdate();
      this.ltvPositionFields.Items.Clear();
      if (position != null)
      {
        foreach (BrokerPositionField brokerPositionField in position.GetCustomFields())
        {
          ListViewItem listViewItem = new ListViewItem(new string[2], 0);
          listViewItem.SubItems[0].Text = brokerPositionField.Name;
          listViewItem.SubItems[1].Text = brokerPositionField.Value;
          this.ltvPositionFields.Items.Add(listViewItem);
        }
      }
      this.ltvPositionFields.EndUpdate();
    }

    private void UpdateAccountOrders(BrokerAccount account)
    {
      this.ltvOrders.BeginUpdate();
      this.ltvOrders.Items.Clear();
      if (account != null)
      {
        foreach (BrokerOrder order in account.GetOrders())
          this.ltvOrders.Items.Add((ListViewItem) new BrokerOrderViewItem(order));
      }
      this.ltvOrders.EndUpdate();
      this.UpdateOrderFields((BrokerOrder) null);
    }

    private void UpdateOrderFields(BrokerOrder order)
    {
      this.ltvOrderFields.BeginUpdate();
      this.ltvOrderFields.Items.Clear();
      if (order != null)
      {
        foreach (BrokerOrderField brokerOrderField in order.GetCustomFields())
        {
          ListViewItem listViewItem = new ListViewItem(new string[2], 0);
          listViewItem.SubItems[0].Text = brokerOrderField.Name;
          listViewItem.SubItems[1].Text = brokerOrderField.Value;
          this.ltvOrderFields.Items.Add(listViewItem);
        }
      }
      this.ltvOrderFields.EndUpdate();
    }
  }
}
