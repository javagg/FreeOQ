// Type: OpenQuant.QuantBase.QuantBaseExplorerWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Properties;
using OpenQuant.Shared.Data;
using SmartQuant.Docking.WinForms;
using SmartQuant.Instruments;
using SmartQuant.QuantBaseLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.QuantBase
{
  internal class QuantBaseExplorerWindow : DockControl
  {
    private IContainer components;
    private ToolStrip toolStrip;
    private StatusStrip statusStrip;
    private ToolStripButton tsbRefresh;
    private SplitContainer splitContainer1;
    private TabControl tabDataType;
    private TabPage tabPage1;
    private TreeView trvDataType;
    private ImageList imgDataType;
    private ToolStripStatusLabel tslText;
    private ToolStripButton tsbDisconnect;
    private TabControl tabSeries;
    private TabPage tabPage2;
    private ListView ltvSeries;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ImageList imgSeries;
    private ContextMenuStrip ctxSeries;
    private ToolStripMenuItem ctxSeries_Import;
    private ConnectionSettings connectionSettings;
    private ImportSettings importSettings;
    private IQuantBaseConnection connection;
    private DataSeriesViewItemComparer itemComparer;

    public QuantBaseExplorerWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.itemComparer = new DataSeriesViewItemComparer();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (QuantBaseExplorerWindow));
      this.toolStrip = new ToolStrip();
      this.tsbRefresh = new ToolStripButton();
      this.tsbDisconnect = new ToolStripButton();
      this.statusStrip = new StatusStrip();
      this.tslText = new ToolStripStatusLabel();
      this.splitContainer1 = new SplitContainer();
      this.tabDataType = new TabControl();
      this.tabPage1 = new TabPage();
      this.trvDataType = new TreeView();
      this.imgDataType = new ImageList(this.components);
      this.tabSeries = new TabControl();
      this.tabPage2 = new TabPage();
      this.ltvSeries = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.ctxSeries = new ContextMenuStrip(this.components);
      this.ctxSeries_Import = new ToolStripMenuItem();
      this.imgSeries = new ImageList(this.components);
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabDataType.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabSeries.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.ctxSeries.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.toolStrip.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tsbRefresh,
        (ToolStripItem) this.tsbDisconnect
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(638, 25);
      this.toolStrip.TabIndex = 0;
      this.toolStrip.Text = "toolStrip1";
      this.tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbRefresh.Image = (Image) Resources.qb_refresh;
      this.tsbRefresh.ImageTransparentColor = Color.Magenta;
      this.tsbRefresh.Name = "tsbRefresh";
      this.tsbRefresh.Size = new Size(23, 22);
      this.tsbRefresh.Text = "Refresh series information";
      this.tsbRefresh.Click += new EventHandler(this.tsbRefresh_Click);
      this.tsbDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbDisconnect.Image = (Image) Resources.qb_disconnect;
      this.tsbDisconnect.ImageTransparentColor = Color.Magenta;
      this.tsbDisconnect.Name = "tsbDisconnect";
      this.tsbDisconnect.Size = new Size(23, 22);
      this.tsbDisconnect.Text = "Disconnect";
      this.tsbDisconnect.Click += new EventHandler(this.tsbDisconnect_Click);
      this.statusStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tslText
      });
      this.statusStrip.Location = new Point(0, 361);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(638, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip1";
      this.tslText.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.tslText.Name = "tslText";
      this.tslText.Size = new Size(623, 17);
      this.tslText.Spring = true;
      this.tslText.TextAlign = ContentAlignment.MiddleLeft;
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 25);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.tabDataType);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tabSeries);
      this.splitContainer1.Size = new Size(638, 336);
      this.splitContainer1.SplitterDistance = 135;
      this.splitContainer1.TabIndex = 2;
      this.tabDataType.Controls.Add((Control) this.tabPage1);
      this.tabDataType.Dock = DockStyle.Fill;
      this.tabDataType.Location = new Point(0, 0);
      this.tabDataType.Name = "tabDataType";
      this.tabDataType.SelectedIndex = 0;
      this.tabDataType.Size = new Size(135, 336);
      this.tabDataType.TabIndex = 0;
      this.tabPage1.Controls.Add((Control) this.trvDataType);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size((int) sbyte.MaxValue, 310);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Data Type";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.trvDataType.Dock = DockStyle.Fill;
      this.trvDataType.HideSelection = false;
      this.trvDataType.ImageIndex = 0;
      this.trvDataType.ImageList = this.imgDataType;
      this.trvDataType.Location = new Point(3, 3);
      this.trvDataType.Name = "trvDataType";
      this.trvDataType.SelectedImageIndex = 0;
      this.trvDataType.ShowPlusMinus = false;
      this.trvDataType.ShowRootLines = false;
      this.trvDataType.Size = new Size(121, 304);
      this.trvDataType.TabIndex = 0;
      this.trvDataType.AfterSelect += new TreeViewEventHandler(this.trvDataType_AfterSelect);
      this.imgDataType.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgDataType.ImageStream");
      this.imgDataType.TransparentColor = Color.Transparent;
      this.imgDataType.Images.SetKeyName(0, "data_type.png");
      this.tabSeries.Controls.Add((Control) this.tabPage2);
      this.tabSeries.Dock = DockStyle.Fill;
      this.tabSeries.Location = new Point(0, 0);
      this.tabSeries.Name = "tabSeries";
      this.tabSeries.SelectedIndex = 0;
      this.tabSeries.Size = new Size(499, 336);
      this.tabSeries.TabIndex = 0;
      this.tabPage2.Controls.Add((Control) this.ltvSeries);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(491, 310);
      this.tabPage2.TabIndex = 0;
      this.tabPage2.Text = "Series";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.ltvSeries.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvSeries.ContextMenuStrip = this.ctxSeries;
      this.ltvSeries.Dock = DockStyle.Fill;
      this.ltvSeries.FullRowSelect = true;
      this.ltvSeries.GridLines = true;
      this.ltvSeries.HideSelection = false;
      this.ltvSeries.LabelWrap = false;
      this.ltvSeries.Location = new Point(3, 3);
      this.ltvSeries.Name = "ltvSeries";
      this.ltvSeries.ShowGroups = false;
      this.ltvSeries.ShowItemToolTips = true;
      this.ltvSeries.Size = new Size(485, 304);
      this.ltvSeries.SmallImageList = this.imgSeries;
      this.ltvSeries.TabIndex = 0;
      this.ltvSeries.UseCompatibleStateImageBehavior = false;
      this.ltvSeries.View = View.Details;
      this.ltvSeries.ColumnClick += new ColumnClickEventHandler(this.ltvSeries_ColumnClick);
      this.ltvSeries.ColumnWidthChanged += new ColumnWidthChangedEventHandler(this.ltvSeries_ColumnWidthChanged);
      this.columnHeader1.Text = "Instrument";
      this.columnHeader1.Width = 99;
      this.columnHeader2.Text = "Count";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 99;
      this.columnHeader3.Text = "First DateTime";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 123;
      this.columnHeader4.Text = "Last DateTime";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 132;
      this.ctxSeries.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxSeries_Import
      });
      this.ctxSeries.Name = "ctxSeries";
      this.ctxSeries.Size = new Size(120, 26);
      this.ctxSeries.Opening += new CancelEventHandler(this.ctxSeries_Opening);
      this.ctxSeries_Import.Image = (Image) Resources.data_import;
      this.ctxSeries_Import.Name = "ctxSeries_Import";
      this.ctxSeries_Import.Size = new Size(119, 22);
      this.ctxSeries_Import.Text = "Import...";
      this.ctxSeries_Import.Click += new EventHandler(this.ctxSeries_Import_Click);
      this.imgSeries.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgSeries.ImageStream");
      this.imgSeries.TransparentColor = Color.Transparent;
      this.imgSeries.Images.SetKeyName(0, "data.png");
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.splitContainer1);
      ((Control) this).Controls.Add((Control) this.statusStrip);
      ((Control) this).Controls.Add((Control) this.toolStrip);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "QuantBaseExplorerWindow";
      ((Control) this).Size = new Size(638, 383);
      ((DockControl) this).set_TabImage((Image) Resources.quantbase);
      ((Control) this).Text = "QuantBase Explorer";
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabDataType.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabSeries.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.ctxSeries.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }

    protected virtual void OnInit()
    {
      this.LoadLayout();
      this.connection = (IQuantBaseConnection) null;
      this.connectionSettings = new ConnectionSettings(this.get_Settings());
      this.importSettings = new ImportSettings();
      this.SetInfoText("Press Refresh button to update series information");
      this.UpdateConnectionStatus();
    }

    private void tsbRefresh_Click(object sender, EventArgs e)
    {
      if (this.connection == null)
      {
        ConnectionPromptWindow connectionPromptWindow = new ConnectionPromptWindow();
        connectionPromptWindow.Init(this.connectionSettings);
        if (connectionPromptWindow.ShowDialog() == DialogResult.OK)
        {
          try
          {
            this.SetInfoText("Connecting...");
            this.connection = ((IQuantBase) Activator.GetObject(typeof (IQuantBase), this.connectionSettings.URL)).OpenConnection(new LogonInfo()
            {
              Username = this.connectionSettings.Username,
              Password = this.connectionSettings.Password
            });
          }
          catch (Exception ex)
          {
            this.connection = (IQuantBaseConnection) null;
            this.ShowErrorDialog(ex.Message);
            this.SetInfoText(ex.Message);
          }
        }
      }
      if (this.connection != null)
      {
        try
        {
          string str = string.Empty;
          if (this.trvDataType.SelectedNode != null)
            str = this.trvDataType.SelectedNode.Text;
          HashSet<string> hashSet = new HashSet<string>();
          foreach (ListViewItem listViewItem in this.ltvSeries.SelectedItems)
            hashSet.Add(listViewItem.Text);
          this.trvDataType.Nodes.Clear();
          this.ltvSeries.Items.Clear();
          this.SetInfoText("Getting series information...");
          DataSeriesInfo[] dataSeries = this.connection.GetDataSeries();
          this.SetInfoText("Updating information...");
          List<DataSeriesItem> list = new List<DataSeriesItem>();
          foreach (DataSeriesInfo qbInfo in dataSeries)
            list.Add(new DataSeriesItem(qbInfo, DataSeriesHelper.GetDataSeriesInfo(qbInfo.Name)));
          SortedList<DataTypeKey, DataTypeNode> sortedList = new SortedList<DataTypeKey, DataTypeNode>((IComparer<DataTypeKey>) new DataTypeKeyComparer());
          foreach (DataSeriesItem dataSeriesItem in list)
          {
            DataTypeKey key = new DataTypeKey(dataSeriesItem.SH_Info);
            DataTypeNode dataTypeNode;
            if (!sortedList.TryGetValue(key, out dataTypeNode))
            {
              dataTypeNode = new DataTypeNode(DataSeriesHelper.SeriesNameToString(dataSeriesItem.QB_Info.Name));
              sortedList.Add(key, dataTypeNode);
            }
            dataTypeNode.Items.Add(dataSeriesItem);
          }
          foreach (TreeNode node in (IEnumerable<DataTypeNode>) sortedList.Values)
            this.trvDataType.Nodes.Add(node);
          foreach (TreeNode treeNode in this.trvDataType.Nodes)
          {
            if (treeNode.Text == str)
            {
              this.trvDataType.SelectedNode = treeNode;
              break;
            }
          }
          foreach (ListViewItem listViewItem in this.ltvSeries.Items)
          {
            if (hashSet.Contains(listViewItem.Text))
              listViewItem.Selected = true;
          }
          this.SetInfoText(string.Format("Series: {0:n0}", (object) list.Count));
        }
        catch (Exception ex)
        {
          this.connection = (IQuantBaseConnection) null;
          this.ShowErrorDialog(ex.Message);
          this.SetInfoText(ex.Message);
        }
      }
      this.UpdateConnectionStatus();
    }

    private void tsbDisconnect_Click(object sender, EventArgs e)
    {
      try
      {
        this.trvDataType.Nodes.Clear();
        this.ltvSeries.Items.Clear();
        this.tabSeries.TabPages[0].ResetText();
        this.SetInfoText("Disconnecting...");
        this.connection.Close();
      }
      catch (Exception ex)
      {
        this.ShowErrorDialog(ex.Message);
      }
      finally
      {
        this.connection = (IQuantBaseConnection) null;
      }
      this.SetInfoText("Not connected.");
      this.UpdateConnectionStatus();
    }

    private void trvDataType_AfterSelect(object sender, TreeViewEventArgs e)
    {
      ((Control) this).Cursor = Cursors.WaitCursor;
      this.ltvSeries.BeginUpdate();
      this.ltvSeries.Items.Clear();
      this.ltvSeries.ListViewItemSorter = (IComparer) null;
      if (this.trvDataType.SelectedNode != null)
      {
        List<DataSeriesItem> items = ((DataTypeNode) this.trvDataType.SelectedNode).Items;
        foreach (DataSeriesItem dataSeriesItem in items)
          this.ltvSeries.Items.Add((ListViewItem) new DataSeriesViewItem(dataSeriesItem));
        this.tabSeries.TabPages[0].Text = string.Format("{0:n0} series", (object) items.Count);
      }
      else
        this.tabSeries.TabPages[0].ResetText();
      this.ltvSeries.ListViewItemSorter = (IComparer) this.itemComparer;
      this.ltvSeries.EndUpdate();
      ((Control) this).Cursor = Cursors.Default;
    }

    private void ltvSeries_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      this.itemComparer.SetSortColumn(e.Column);
      this.ltvSeries.Sort();
    }

    private void ltvSeries_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
    {
      this.SaveLayout();
    }

    private void ctxSeries_Opening(object sender, CancelEventArgs e)
    {
      if (this.ltvSeries.SelectedItems.Count == 0)
        this.ctxSeries_Import.Enabled = false;
      else
        this.ctxSeries_Import.Enabled = true;
    }

    private void ctxSeries_Import_Click(object sender, EventArgs e)
    {
      this.importSettings.Items.Clear();
      bool flag = false;
      foreach (DataSeriesViewItem dataSeriesViewItem in this.ltvSeries.SelectedItems)
      {
        this.importSettings.Items.Add(dataSeriesViewItem.Item);
        if (!InstrumentManager.Instruments.Contains(dataSeriesViewItem.Item.SH_Info.get_Symbol()))
          flag = true;
      }
      if (flag)
      {
        CreateInstrumentsPromptWindow instrumentsPromptWindow = new CreateInstrumentsPromptWindow();
        instrumentsPromptWindow.Init(this.importSettings);
        if (instrumentsPromptWindow.ShowDialog() != DialogResult.OK)
          return;
      }
      ImportOptionsWindow importOptionsWindow = new ImportOptionsWindow();
      importOptionsWindow.Init(this.importSettings);
      if (importOptionsWindow.ShowDialog() != DialogResult.OK)
        return;
      ImportWindow importWindow = new ImportWindow();
      importWindow.Init(this.connection, this.importSettings);
      int num = (int) importWindow.ShowDialog();
      importWindow.Dispose();
    }

    private void UpdateConnectionStatus()
    {
      if (this.connection == null)
      {
        this.tsbRefresh.Enabled = true;
        this.tsbDisconnect.Enabled = false;
      }
      else
      {
        this.tsbRefresh.Enabled = true;
        this.tsbDisconnect.Enabled = true;
      }
    }

    private void ShowErrorDialog(string text)
    {
      int num;
      Action action = (Action) (() => num = (int) MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand));
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
        ((Control) this).Invoke((Delegate) action);
      else
        action();
    }

    private void SetInfoText(string text)
    {
      Action action = (Action) (() => this.tslText.Text = text);
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        ((Control) this).Invoke((Delegate) action);
      }
      else
      {
        action();
        Application.DoEvents();
      }
    }

    private void SaveLayout()
    {
      List<int> list = new List<int>();
      foreach (ColumnHeader columnHeader in this.ltvSeries.Columns)
        list.Add(columnHeader.Width);
      this.get_Settings().SetValue("columns.width", list.ToArray());
    }

    private void LoadLayout()
    {
      int[] int32ArrayValue = this.get_Settings().GetInt32ArrayValue("columns.width", new int[0]);
      for (int index = 0; index < int32ArrayValue.Length && index < this.ltvSeries.Columns.Count; ++index)
        this.ltvSeries.Columns[index].Width = int32ArrayValue[index];
    }
  }
}
