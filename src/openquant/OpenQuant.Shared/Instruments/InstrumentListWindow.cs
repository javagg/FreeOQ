using OpenQuant.API;
using OpenQuant.Shared;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Data.Management;
using OpenQuant.Shared.Properties;
using OpenQuant.Shared.ToolWindows;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

using Instrument = FreeQuant.Instruments.Instrument;
using InstrumentManager = FreeQuant.Instruments.InstrumentManager;
using InstrumentList = FreeQuant.Instruments.InstrumentList;


namespace OpenQuant.Shared.Instruments
{
    public class InstrumentListWindow : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable
  {
    private const string KEY_GROUP_MODE = "groupMode";
    private const GroupMode DEFAULT_GROUP_MODE = GroupMode.InstrumentType;
    private IContainer components;
    private TreeView trvInstruments;
    private ToolStrip toolStrip;
    private ImageList images;
    private ToolStripDropDownButton tsbGroup;
    private ToolStripMenuItem tsbGroup_None;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem tsbGroup_ByInstrumentType;
    private ToolStripMenuItem tsbGroup_Alphabetically;
    private ContextMenuStrip ctxInstruments;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxInstruments_Properties;
    private ToolStripMenuItem ctxInstruments_AddNew;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ctxInstruments_Delete;
    private ToolStripSeparator tssInstruments_Data;
    private ToolStripMenuItem tsbGroup_ByExchange;
    private ToolStripButton tsbRefresh;
    private ToolStripMenuItem ctxInstruments_Data;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem tsbGroup_ByCurrency;
    private ToolStripMenuItem tsbGroup_ByMaturity;
    private ToolStripMenuItem tsbGroup_ByGroup;
    private ToolStripMenuItem tsbGroup_BySector;
    private ToolStripSeparator tssInstruments_Chart;
    private ToolStripMenuItem ctxInstruments_Chart;
    private Rectangle dragBoxFromMouseDown;
    private Point screenOffset;
    private Cursor myNoDropCursor;
    private Cursor myNormalCursor;
    private TreeNode nodeToDrag;
    private bool viewChartEnabled;
    private bool viewDataEnabled;

    public object PropertyObject
    {
      get
      {
        InstrumentNode instrumentNode = this.trvInstruments.SelectedNode as InstrumentNode;
		if (instrumentNode != null)
			return 	instrumentNode.Instrument;
//			return OpenQuant.Instruments[((FIXInstrument) instrumentNode.Instrument).Symbol];
        else
			return null;
      }
    }

    public bool ViewChartEnabled
    {
      get
      {
        return this.viewChartEnabled;
      }
      set
      {
        this.viewChartEnabled = value;
        this.tssInstruments_Chart.Visible = value;
        this.ctxInstruments_Chart.Visible = value;
      }
    }

    public bool ViewDataEnabled
    {
      get
      {
        return this.viewDataEnabled;
      }
      set
      {
        this.viewDataEnabled = value;
        this.tssInstruments_Data.Visible = value;
        this.ctxInstruments_Data.Visible = value;
      }
    }

    private GroupMode ActiveGroupMode
    {
      get
      {
        return this.Settings.GetEnumValue<GroupMode>("groupMode", GroupMode.InstrumentType);
      }
      set
      {
        if (this.ActiveGroupMode == value)
          return;
        this.Settings.SetEnumValue<GroupMode>("groupMode", value);
        this.MakeTree();
      }
    }

    public InstrumentListWindow()
    {
      this.InitializeComponent();
      this.trvInstruments.TreeViewNodeSorter = (IComparer) new InstrumentListNodeSorter();
      this.ViewChartEnabled = false;
      this.ViewDataEnabled = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (InstrumentListWindow));
      this.trvInstruments = new TreeView();
      this.images = new ImageList(this.components);
      this.toolStrip = new ToolStrip();
      this.tsbGroup = new ToolStripDropDownButton();
      this.tsbGroup_Alphabetically = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.tsbGroup_ByCurrency = new ToolStripMenuItem();
      this.tsbGroup_ByExchange = new ToolStripMenuItem();
      this.tsbGroup_ByInstrumentType = new ToolStripMenuItem();
      this.tsbGroup_ByMaturity = new ToolStripMenuItem();
      this.tsbGroup_ByGroup = new ToolStripMenuItem();
      this.tsbGroup_BySector = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.tsbGroup_None = new ToolStripMenuItem();
      this.tsbRefresh = new ToolStripButton();
      this.ctxInstruments = new ContextMenuStrip(this.components);
      this.ctxInstruments_AddNew = new ToolStripMenuItem();
      this.tssInstruments_Chart = new ToolStripSeparator();
      this.ctxInstruments_Chart = new ToolStripMenuItem();
      this.tssInstruments_Data = new ToolStripSeparator();
      this.ctxInstruments_Data = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.ctxInstruments_Delete = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxInstruments_Properties = new ToolStripMenuItem();
      this.toolStrip.SuspendLayout();
      this.ctxInstruments.SuspendLayout();
      this.SuspendLayout();
      this.trvInstruments.Dock = DockStyle.Fill;
      this.trvInstruments.HideSelection = false;
      this.trvInstruments.ImageIndex = 0;
      this.trvInstruments.ImageList = this.images;
      this.trvInstruments.Location = new Point(0, 25);
      this.trvInstruments.Name = "trvInstruments";
      this.trvInstruments.SelectedImageIndex = 0;
      this.trvInstruments.ShowNodeToolTips = true;
      this.trvInstruments.Size = new Size(250, 375);
      this.trvInstruments.TabIndex = 0;
      this.trvInstruments.AfterCollapse += new TreeViewEventHandler(this.trvInstruments_AfterCollapse);
      this.trvInstruments.AfterExpand += new TreeViewEventHandler(this.trvInstruments_AfterExpand);
      this.trvInstruments.AfterSelect += new TreeViewEventHandler(this.trvInstruments_AfterSelect);
      this.trvInstruments.DoubleClick += new EventHandler(this.trvInstruments_DoubleClick);
      this.trvInstruments.KeyDown += new KeyEventHandler(this.trvInstruments_KeyDown);
      this.trvInstruments.MouseDown += new MouseEventHandler(this.trvInstruments_MouseDown);
      this.trvInstruments.MouseMove += new MouseEventHandler(this.trvInstruments_MouseMove);
      this.trvInstruments.MouseUp += new MouseEventHandler(this.trvInstruments_MouseUp);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "instrument_plain.png");
      this.images.Images.SetKeyName(1, "VSFolder_closed.png");
      this.images.Images.SetKeyName(2, "VSFolder_open.png");
      this.toolStrip.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tsbGroup,
        (ToolStripItem) this.tsbRefresh
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(250, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "toolStrip1";
      this.tsbGroup.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbGroup.DropDownItems.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.tsbGroup_Alphabetically,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.tsbGroup_ByCurrency,
        (ToolStripItem) this.tsbGroup_ByExchange,
        (ToolStripItem) this.tsbGroup_ByInstrumentType,
        (ToolStripItem) this.tsbGroup_ByMaturity,
        (ToolStripItem) this.tsbGroup_ByGroup,
        (ToolStripItem) this.tsbGroup_BySector,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.tsbGroup_None
      });
      this.tsbGroup.Image = (Image) Resources.group;
      this.tsbGroup.ImageTransparentColor = Color.Magenta;
      this.tsbGroup.Name = "tsbGroup";
      this.tsbGroup.Size = new Size(29, 22);
      this.tsbGroup.ToolTipText = "Group Instruments";
      this.tsbGroup.DropDownOpening += new EventHandler(this.tsbGroup_DropDownOpening);
      this.tsbGroup_Alphabetically.Name = "tsbGroup_Alphabetically";
      this.tsbGroup_Alphabetically.Size = new Size(177, 22);
      this.tsbGroup_Alphabetically.Text = "Alphabetically";
      this.tsbGroup_Alphabetically.Click += new EventHandler(this.tsbGroup_Alphabetically_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(174, 6);
      this.tsbGroup_ByCurrency.Name = "tsbGroup_ByCurrency";
      this.tsbGroup_ByCurrency.Size = new Size(177, 22);
      this.tsbGroup_ByCurrency.Text = "By Currency";
      this.tsbGroup_ByCurrency.Click += new EventHandler(this.tsbGroup_ByCurrency_Click);
      this.tsbGroup_ByExchange.Name = "tsbGroup_ByExchange";
      this.tsbGroup_ByExchange.Size = new Size(177, 22);
      this.tsbGroup_ByExchange.Text = "By Exchange";
      this.tsbGroup_ByExchange.Click += new EventHandler(this.tsbGroup_ByExchange_Click);
      this.tsbGroup_ByInstrumentType.Name = "tsbGroup_ByInstrumentType";
      this.tsbGroup_ByInstrumentType.Size = new Size(177, 22);
      this.tsbGroup_ByInstrumentType.Text = "By Instrument Type";
      this.tsbGroup_ByInstrumentType.Click += new EventHandler(this.tsbGroup_ByInstrumentType_Click);
      this.tsbGroup_ByMaturity.Name = "tsbGroup_ByMaturity";
      this.tsbGroup_ByMaturity.Size = new Size(177, 22);
      this.tsbGroup_ByMaturity.Text = "By Maturity";
      this.tsbGroup_ByMaturity.Click += new EventHandler(this.tsbGroup_ByMaturity_Click);
      this.tsbGroup_ByGroup.Name = "tsbGroup_ByGroup";
      this.tsbGroup_ByGroup.Size = new Size(177, 22);
      this.tsbGroup_ByGroup.Text = "By Industry Group";
      this.tsbGroup_ByGroup.Click += new EventHandler(this.tsbGroup_ByGroup_Click);
      this.tsbGroup_BySector.Name = "tsbGroup_BySector";
      this.tsbGroup_BySector.Size = new Size(177, 22);
      this.tsbGroup_BySector.Text = "By Industry Sector";
      this.tsbGroup_BySector.Click += new EventHandler(this.tsbGroup_BySector_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(174, 6);
      this.tsbGroup_None.Name = "tsbGroup_None";
      this.tsbGroup_None.Size = new Size(177, 22);
      this.tsbGroup_None.Text = "No Group";
      this.tsbGroup_None.Click += new EventHandler(this.tsbGroup_None_Click);
      this.tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbRefresh.Image = (Image) Resources.refresh;
      this.tsbRefresh.ImageTransparentColor = Color.Magenta;
      this.tsbRefresh.Name = "tsbRefresh";
      this.tsbRefresh.Size = new Size(23, 22);
      this.tsbRefresh.ToolTipText = "Refresh Instruments";
      this.tsbRefresh.Click += new EventHandler(this.tsbRefresh_Click);
      this.ctxInstruments.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.ctxInstruments_AddNew,
        (ToolStripItem) this.tssInstruments_Chart,
        (ToolStripItem) this.ctxInstruments_Chart,
        (ToolStripItem) this.tssInstruments_Data,
        (ToolStripItem) this.ctxInstruments_Data,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.ctxInstruments_Delete,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxInstruments_Properties
      });
      this.ctxInstruments.Name = "ctxInstruments";
      this.ctxInstruments.Size = new Size(153, 160);
      this.ctxInstruments.Opening += new CancelEventHandler(this.ctxInstruments_Opening);
      this.ctxInstruments_AddNew.Image = (Image) Resources.instrument;
      this.ctxInstruments_AddNew.Name = "ctxInstruments_AddNew";
      this.ctxInstruments_AddNew.Size = new Size(152, 22);
      this.ctxInstruments_AddNew.Text = "Add New...";
      this.ctxInstruments_AddNew.Click += new EventHandler(this.ctxInstruments_AddNew_Click);
      this.tssInstruments_Chart.Name = "tssInstruments_Chart";
      this.tssInstruments_Chart.Size = new Size(149, 6);
      this.ctxInstruments_Chart.Image = (Image) Resources.chart;
      this.ctxInstruments_Chart.Name = "ctxInstruments_Chart";
      this.ctxInstruments_Chart.Size = new Size(152, 22);
      this.ctxInstruments_Chart.Text = "Chart";
      this.ctxInstruments_Chart.Click += new EventHandler(this.ctxInstruments_Chart_Click);
      this.tssInstruments_Data.Name = "tssInstruments_Data";
      this.tssInstruments_Data.Size = new Size(149, 6);
      this.ctxInstruments_Data.Image = (Image) Resources.data;
      this.ctxInstruments_Data.Name = "ctxInstruments_Data";
      this.ctxInstruments_Data.Size = new Size(152, 22);
      this.ctxInstruments_Data.Text = "Data";
      this.ctxInstruments_Data.Click += new EventHandler(this.ctxInstruments_Data_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(149, 6);
      this.ctxInstruments_Delete.Image = (Image) Resources.delete;
      this.ctxInstruments_Delete.Name = "ctxInstruments_Delete";
      this.ctxInstruments_Delete.Size = new Size(152, 22);
      this.ctxInstruments_Delete.Text = "Delete";
      this.ctxInstruments_Delete.Click += new EventHandler(this.ctxInstruments_Delete_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(149, 6);
      this.ctxInstruments_Properties.Image = (Image) Resources.properties;
      this.ctxInstruments_Properties.Name = "ctxInstruments_Properties";
      this.ctxInstruments_Properties.Size = new Size(152, 22);
      this.ctxInstruments_Properties.Text = "Properties";
      this.ctxInstruments_Properties.Click += new EventHandler(this.ctxInstruments_Properties_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ContextMenuStrip = this.ctxInstruments;
      this.Controls.Add((Control) this.trvInstruments);
      this.Controls.Add((Control) this.toolStrip);
      this.Name = "InstrumentListWindow";
      this.TabImage = (Image) Resources.instrument;
      this.Text = "Instruments";
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ctxInstruments.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnInit()
    {
      this.MakeTree();
      // ISSUE: method pointer
			InstrumentManager.InstrumentAdded += new InstrumentEventHandler(this.InstrumentManager_InstrumentAdded);
      // ISSUE: method pointer
			InstrumentManager.InstrumentRemoved += new InstrumentEventHandler(this.InstrumentManager_InstrumentRemoved);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      // ISSUE: method pointer
			InstrumentManager.InstrumentAdded -= new InstrumentEventHandler(this.InstrumentManager_InstrumentAdded);
      // ISSUE: method pointer
			InstrumentManager.InstrumentRemoved -= new InstrumentEventHandler(this.InstrumentManager_InstrumentRemoved);
      base.OnClosing(e);
    }

    private void MakeTree()
    {
      this.trvInstruments.BeginUpdate();
      this.trvInstruments.Nodes.Clear();
      IEnumerator enumerator = ((FIXGroupList) InstrumentManager.Instruments).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.AddInstrument((Instrument) enumerator.Current);
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      this.trvInstruments.EndUpdate();
    }

    private void InstrumentManager_InstrumentAdded(InstrumentEventArgs args)
    {
      if (this.InvokeRequired)
      {
        // ISSUE: method pointer
				this.BeginInvoke((Delegate) new InstrumentEventHandler(this.InstrumentManager_InstrumentAdded), new object[]  {  args    });
      }
      else
        this.AddInstrument(args.Instrument);
    }

    private void InstrumentManager_InstrumentRemoved(InstrumentEventArgs args)
    {
      if (this.InvokeRequired)
      {
        // ISSUE: method pointer
				this.BeginInvoke((Delegate) new InstrumentEventHandler(this.InstrumentManager_InstrumentRemoved), new object[] {args   });
      }
      else
        this.RemoveInstrument(args.Instrument);
    }

    private void AddInstrument(Instrument instrument)
    {
      List<GroupNode> list = new List<GroupNode>();
      foreach (GroupNode groupNode in this.trvInstruments.Nodes)
      {
        if (groupNode.IsInstrumentValid(instrument))
          list.Add(groupNode);
      }
      if (list.Count == 0)
      {
        switch (this.ActiveGroupMode)
        {
          case GroupMode.Alphabet:
            list.Add(new AlphabetGroupNode(((FIXInstrument) instrument).Symbol[0]));
            break;
          case GroupMode.Currency:
            list.Add(new CurrencyGroupNode(instrument.Currency));
            break;
          case GroupMode.Exchange:
            list.Add(new ExchangeGroupNode(((FIXInstrument) instrument).SecurityExchange));
            break;
		case GroupMode.InstrumentType:
			InstrumentType type = OpenQuant.Shared.APITypeConverter.InstrumentType.Convert(instrument.SecurityType);
			list.Add(new InstrumentTypeGroupNode(type));

//            list.Add(new InstrumentTypeGroupNode(OpenQuant.Instruments[((FIXInstrument) instrument).Symbol].Type));
            break;
          case GroupMode.Maturity:
            list.Add(new MaturityGroupNode(((FIXInstrument) instrument).MaturityDate));
            break;
          case GroupMode.Group:
            list.Add(new IndustryGroupGroupNode(instrument.IndustryGroup));
            break;
          case GroupMode.Sector:
            list.Add(new IndustrySectorGroupNode(instrument.IndustrySector));
            break;
          case GroupMode.None:
            list.Add(new AnySymbolGroupNode());
            break;
          default:
            throw new Exception();
        }
        this.trvInstruments.Nodes.Add((TreeNode) list[0]);
      }
      foreach (GroupNode groupNode in list)
        groupNode.AddInstrument(instrument);
    }

    private void RemoveInstrument(Instrument instrument)
    {
      GroupNode[] groupNodeArray = new GroupNode[this.trvInstruments.Nodes.Count];
      this.trvInstruments.Nodes.CopyTo((Array) groupNodeArray, 0);
      foreach (GroupNode groupNode in groupNodeArray)
        groupNode.RemoveInstrument(instrument);
    }

    private void tsbGroup_DropDownOpening(object sender, EventArgs e)
    {
      this.tsbGroup_Alphabetically.Checked = false;
      this.tsbGroup_ByCurrency.Checked = false;
      this.tsbGroup_ByExchange.Checked = false;
      this.tsbGroup_ByInstrumentType.Checked = false;
      this.tsbGroup_ByMaturity.Checked = false;
      this.tsbGroup_ByGroup.Checked = false;
      this.tsbGroup_BySector.Checked = false;
      this.tsbGroup_None.Checked = false;
      switch (this.ActiveGroupMode)
      {
        case GroupMode.Alphabet:
          this.tsbGroup_Alphabetically.Checked = true;
          break;
        case GroupMode.Currency:
          this.tsbGroup_ByCurrency.Checked = true;
          break;
        case GroupMode.Exchange:
          this.tsbGroup_ByExchange.Checked = true;
          break;
        case GroupMode.InstrumentType:
          this.tsbGroup_ByInstrumentType.Checked = true;
          break;
        case GroupMode.Maturity:
          this.tsbGroup_ByMaturity.Checked = true;
          break;
        case GroupMode.Group:
          this.tsbGroup_ByGroup.Checked = true;
          break;
        case GroupMode.Sector:
          this.tsbGroup_BySector.Checked = true;
          break;
        case GroupMode.None:
          this.tsbGroup_None.Checked = true;
          break;
        default:
          throw new Exception();
      }
    }

    private void tsbGroup_Alphabetically_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.Alphabet;
    }

    private void tsbGroup_ByCurrency_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.Currency;
    }

    private void tsbGroup_ByExchange_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.Exchange;
    }

    private void tsbGroup_ByInstrumentType_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.InstrumentType;
    }

    private void tsbGroup_ByMaturity_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.Maturity;
    }

    private void tsbGroup_ByGroup_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.Group;
    }

    private void tsbGroup_BySector_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.Sector;
    }

    private void tsbGroup_None_Click(object sender, EventArgs e)
    {
      this.ActiveGroupMode = GroupMode.None;
    }

    private void tsbRefresh_Click(object sender, EventArgs e)
    {
      this.MakeTree();
    }

    private void trvInstruments_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      this.UpdateIcon(e.Node);
    }

    private void trvInstruments_AfterExpand(object sender, TreeViewEventArgs e)
    {
      this.UpdateIcon(e.Node);
    }

    private void trvInstruments_AfterSelect(object sender, TreeViewEventArgs e)
    {
      Global.ToolWindowManager.ShowProperties((IPropertyEditable) this, false);
    }

    private void trvInstruments_DoubleClick(object sender, EventArgs e)
    {
      this.ViewData();
    }

    private void trvInstruments_MouseDown(object sender, MouseEventArgs e)
    {
      TreeNode nodeAt = this.trvInstruments.GetNodeAt(e.X, e.Y);
      if (nodeAt != null)
      {
        if (e.Button == MouseButtons.Right)
          this.trvInstruments.SelectedNode = nodeAt;
        this.nodeToDrag = nodeAt;
        Size dragSize = SystemInformation.DragSize;
        this.dragBoxFromMouseDown = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
      }
      else
        this.dragBoxFromMouseDown = Rectangle.Empty;
    }

    private void trvInstruments_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Delete)
        return;
      this.DeleteInstruments();
    }

    private void UpdateIcon(TreeNode node)
    {
      GroupNode groupNode = node as GroupNode;
      if (groupNode == null)
        return;
      groupNode.UpdateIcon();
    }

    private void ctxInstruments_Opening(object sender, CancelEventArgs e)
    {
      TreeNode selectedNode = this.trvInstruments.SelectedNode;
      if (selectedNode == null)
      {
        this.ctxInstruments_Chart.Enabled = false;
        this.ctxInstruments_Data.Enabled = false;
        this.ctxInstruments_Delete.Enabled = false;
        this.ctxInstruments_Properties.Enabled = false;
      }
      if (selectedNode is GroupNode)
      {
        this.ctxInstruments_Chart.Enabled = false;
        this.ctxInstruments_Data.Enabled = false;
        this.ctxInstruments_Delete.Enabled = true;
        this.ctxInstruments_Properties.Enabled = false;
      }
      if (!(selectedNode is InstrumentNode))
        return;
      this.ctxInstruments_Chart.Enabled = true;
      this.ctxInstruments_Data.Enabled = true;
      this.ctxInstruments_Delete.Enabled = true;
      this.ctxInstruments_Properties.Enabled = true;
    }

    private void ctxInstruments_AddNew_Click(object sender, EventArgs e)
    {
      NewInstrumentForm newInstrumentForm = new NewInstrumentForm();
      TreeNode selectedNode = this.trvInstruments.SelectedNode;
      string str1 = (string) null;
      if (selectedNode is InstrumentNode)
        str1 = ((FIXInstrument) (selectedNode as InstrumentNode).Instrument).SecurityType;
      if (selectedNode is GroupNode)
      {
        SortedList<string, bool> sortedList = new SortedList<string, bool>();
        foreach (Instrument instrument in (selectedNode as GroupNode).Instruments)
          sortedList[((FIXInstrument) instrument).SecurityType] = true;
        if (sortedList.Count == 1)
          str1 = sortedList.Keys[0];
      }
      if (str1 != null)
        newInstrumentForm.InstrumentType = APITypeConverter.InstrumentType.Convert(str1);
      while (newInstrumentForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        string symbol = newInstrumentForm.Symbol;
        string str2 = APITypeConverter.InstrumentType.Convert(newInstrumentForm.InstrumentType);
        string exchange = newInstrumentForm.Exchange;
        string currency = newInstrumentForm.Currency;
        DateTime maturity = newInstrumentForm.Maturity;
        PutOrCall putOrCall = APITypeConverter.PutCall.Convert(newInstrumentForm.PutCall);
        double strike = newInstrumentForm.Strike;
        if (InstrumentManager.Instruments.Contains(symbol))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, string.Format("Instrument {0} already exists!", symbol), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          Instrument instrument = new Instrument(symbol, str2);
          if (!string.IsNullOrEmpty(exchange))
						((FIXInstrument) instrument).SecurityExchange= exchange;
          if (!string.IsNullOrEmpty(currency))
						instrument.Currency = currency;
          if (str2 == "FUT" || str2 == "OPT" || str2 == "FOP")
          {
						((FIXInstrument) instrument).MaturityDate = maturity;
            if (str2 == "OPT" || str2 == "FOP")
            {
							instrument.PutOrCall = putOrCall;
							((FIXInstrument) instrument).StrikePrice = strike;
            }
          }
          instrument.Save();
          break;
        }
      }
      newInstrumentForm.Dispose();
    }

    private void ctxInstruments_Chart_Click(object sender, EventArgs e)
    {
      this.ViewChart();
    }

    private void ctxInstruments_Data_Click(object sender, EventArgs e)
    {
      this.ViewData();
    }

    private void ctxInstruments_Delete_Click(object sender, EventArgs e)
    {
      this.DeleteInstruments();
    }

    private void ctxInstruments_Properties_Click(object sender, EventArgs e)
    {
      Global.ToolWindowManager.ShowProperties((IPropertyEditable) this, true);
    }

    private void trvInstruments_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left || !(this.dragBoxFromMouseDown != Rectangle.Empty))
        return;
      if (this.dragBoxFromMouseDown.Contains(e.X, e.Y))
        return;
      try
      {
        this.myNormalCursor = Cursors.Arrow;
        this.myNoDropCursor = Cursors.Hand;
      }
      catch
      {
      }
      finally
      {
        this.screenOffset = SystemInformation.WorkingArea.Location;
        InstrumentList instrumentList = new InstrumentList();
        if (this.nodeToDrag is InstrumentNode)
          instrumentList.Add((this.nodeToDrag as InstrumentNode).Instrument);
        if (this.nodeToDrag is GroupNode)
        {
          foreach (InstrumentNode instrumentNode in this.nodeToDrag.Nodes)
            instrumentList.Add(instrumentNode.Instrument);
        }
        int num = (int) this.trvInstruments.DoDragDrop(instrumentList, DragDropEffects.Move);
      }
    }

    private void trvInstruments_MouseUp(object sender, MouseEventArgs e)
    {
      this.dragBoxFromMouseDown = Rectangle.Empty;
    }

    private void ViewChart()
    {
      if (!this.viewChartEnabled)
        return;
      Instrument selectedInstrument = this.GetSelectedInstrument();
      if (selectedInstrument == null)
        return;
      Global.DockManager.Open(typeof (QuickChartForm), selectedInstrument);
    }

    private void ViewData()
    {
      if (!this.viewDataEnabled)
        return;
      Instrument selectedInstrument = this.GetSelectedInstrument();
      if (selectedInstrument == null)
        return;
      Global.DockManager.Open(typeof (InstrumentDataWindow), selectedInstrument);
    }

    protected Instrument GetSelectedInstrument()
    {
      InstrumentNode instrumentNode = this.trvInstruments.SelectedNode as InstrumentNode;
      if (instrumentNode != null)
        return instrumentNode.Instrument;
      else
        return (Instrument) null;
    }

    private void DeleteInstruments()
    {
      if (this.trvInstruments.SelectedNode == null)
        return;
      List<Instrument> list = new List<Instrument>();
      if (this.trvInstruments.SelectedNode is GroupNode)
      {
        foreach (InstrumentNode instrumentNode in this.trvInstruments.SelectedNode.Nodes)
          list.Add(instrumentNode.Instrument);
      }
      if (this.trvInstruments.SelectedNode is InstrumentNode)
        list.Add((this.trvInstruments.SelectedNode as InstrumentNode).Instrument);
      if (MessageBox.Show((IWin32Window) this, "Do you really want to delete selected instrument(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      using (List<Instrument>.Enumerator enumerator = list.GetEnumerator())
      {
        while (enumerator.MoveNext())
          InstrumentManager.Remove(enumerator.Current);
      }
    }
  }
}
