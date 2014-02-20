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
    public partial class InstrumentListWindow : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable
  {
    private const string KEY_GROUP_MODE = "groupMode";
    private const GroupMode DEFAULT_GROUP_MODE = GroupMode.InstrumentType;
 
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
