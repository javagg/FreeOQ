using OpenQuant.API;
using OpenQuant.Shared.Properties;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Instrument = FreeQuant.Instruments.Instrument;

namespace OpenQuant.Shared.Instruments
{
  public class InstrumentSelectorPanel : UserControl
  {
    private GroupMode groupMode;
    private IContainer components;
    private ToolStrip toolStrip;
    private TreeView treeView;
    private ImageList images;
    private ToolStripDropDownButton tsbGroup;
    private ToolStripMenuItem tsbGroup_None;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem tsbGroup_ByInstrumentType;
    private ToolStripMenuItem tsbGroup_ByExchange;
    private ToolStripMenuItem tsbGroup_Alphabetically;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem tsbGroup_ByCurrency;
    private ToolStripMenuItem tsbGroup_ByMaturity;
    private ToolStripMenuItem tsbGroup_ByGroup;
    private ToolStripMenuItem tsbGroup_BySector;

    public Instrument[] Instruments
    {
      get
      {
        Dictionary<Instrument, bool> dictionary = new Dictionary<Instrument, bool>();
        foreach (GroupNode groupNode in this.treeView.Nodes)
        {
          foreach (Instrument index in groupNode.Instruments)
            dictionary[index] = true;
        }
        return new List<Instrument>((IEnumerable<Instrument>) dictionary.Keys).ToArray();
      }
      set
      {
        this.treeView.Nodes.Clear();
        this.AddInstruments(value);
      }
    }

    public Instrument[] SelectedInstruments
    {
      get
      {
        Dictionary<Instrument, bool> dictionary = new Dictionary<Instrument, bool>();
        foreach (TreeNode treeNode in this.treeView.Nodes)
        {
          foreach (InstrumentNode instrumentNode in treeNode.Nodes)
          {
            if (instrumentNode.Checked)
              dictionary[instrumentNode.Instrument] = true;
          }
        }
        return new List<Instrument>((IEnumerable<Instrument>) dictionary.Keys).ToArray();
      }
    }

    public InstrumentSelectorPanel()
    {
      this.InitializeComponent();
      this.treeView.TreeViewNodeSorter = (IComparer) new InstrumentListNodeSorter();
      this.groupMode = GroupMode.None;
    }

    public void AddInstruments(Instrument[] instruments)
    {
      this.treeView.BeginUpdate();
      foreach (Instrument instrument in instruments)
        this.AddInstrument(instrument);
      if (this.treeView.Nodes.Count == 1)
        this.treeView.Nodes[0].Expand();
      this.treeView.EndUpdate();
    }

    public void RemoveInstruments(Instrument[] instruments)
    {
      this.treeView.BeginUpdate();
      foreach (Instrument instrument in instruments)
        this.RemoveInstrument(instrument);
      this.treeView.EndUpdate();
    }

    private void AddInstrument(Instrument instrument)
    {
      List<GroupNode> list = new List<GroupNode>();
      foreach (GroupNode groupNode in this.treeView.Nodes)
      {
        if (groupNode.IsInstrumentValid(instrument))
          list.Add(groupNode);
      }
      if (list.Count == 0)
      {
        switch (this.groupMode)
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
//			list.Add(new InstrumentTypeGroupNode(OpenQuant.Instruments[((FIXInstrument) instrument).Symbol].Type));
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
        this.treeView.Nodes.Add((TreeNode) list[0]);
      }
      foreach (GroupNode groupNode in list)
        groupNode.AddInstrument(instrument);
    }

    private void RemoveInstrument(Instrument instrument)
    {
      GroupNode[] groupNodeArray = new GroupNode[this.treeView.Nodes.Count];
      this.treeView.Nodes.CopyTo((Array) groupNodeArray, 0);
      foreach (GroupNode groupNode in groupNodeArray)
        groupNode.RemoveInstrument(instrument);
    }

    private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
    {
      this.UpdateNode(e.Node);
    }

    private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      this.UpdateNodeIcon(e.Node);
    }

    private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
    {
      this.UpdateNodeIcon(e.Node);
    }

    private void UpdateNode(TreeNode node)
    {
      foreach (TreeNode node1 in node.Nodes)
      {
        node1.Checked = node.Checked;
        this.UpdateNode(node1);
      }
    }

    private void UpdateNodeIcon(TreeNode node)
    {
      GroupNode groupNode = node as GroupNode;
      if (groupNode == null)
        return;
      groupNode.UpdateIcon();
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
      switch (this.groupMode)
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
          throw new NotSupportedException(string.Format("Unknown group mode - {0}", (object) this.groupMode));
      }
    }

    private void tsbGroup_Alphabetically_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.Alphabet);
    }

    private void tsbGroup_ByCurrency_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.Currency);
    }

    private void tsbGroup_ByExchange_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.Exchange);
    }

    private void tsbGroup_ByInstrumentType_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.InstrumentType);
    }

    private void tsbGroup_ByMaturity_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.Maturity);
    }

    private void tsbGroup_ByGroup_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.Group);
    }

    private void tsbGroup_BySector_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.Sector);
    }

    private void tsbGroup_None_Click(object sender, EventArgs e)
    {
      this.SetGroupMode(GroupMode.None);
    }

    private void SetGroupMode(GroupMode value)
    {
      this.groupMode = value;
      this.Instruments = this.Instruments;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (InstrumentSelectorPanel));
      this.toolStrip = new ToolStrip();
      this.tsbGroup = new ToolStripDropDownButton();
      this.tsbGroup_None = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.tsbGroup_ByInstrumentType = new ToolStripMenuItem();
      this.tsbGroup_ByExchange = new ToolStripMenuItem();
      this.tsbGroup_Alphabetically = new ToolStripMenuItem();
      this.treeView = new TreeView();
      this.images = new ImageList(this.components);
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.tsbGroup_ByCurrency = new ToolStripMenuItem();
      this.tsbGroup_ByMaturity = new ToolStripMenuItem();
      this.tsbGroup_ByGroup = new ToolStripMenuItem();
      this.tsbGroup_BySector = new ToolStripMenuItem();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      this.toolStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbGroup
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(177, 25);
      this.toolStrip.TabIndex = 0;
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
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.tsbGroup_None
      });
      this.tsbGroup.Image = (Image) Resources.group;
      this.tsbGroup.ImageTransparentColor = Color.Magenta;
      this.tsbGroup.Name = "tsbGroup";
      this.tsbGroup.Size = new Size(29, 22);
      this.tsbGroup.Text = "toolStripDropDownButton1";
      this.tsbGroup.ToolTipText = "Group Instruments";
      this.tsbGroup.DropDownOpening += new EventHandler(this.tsbGroup_DropDownOpening);
      this.tsbGroup_None.Name = "tsbGroup_None";
      this.tsbGroup_None.Size = new Size(180, 22);
      this.tsbGroup_None.Text = "No Group";
      this.tsbGroup_None.Click += new EventHandler(this.tsbGroup_None_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(177, 6);
      this.tsbGroup_ByInstrumentType.Name = "tsbGroup_ByInstrumentType";
      this.tsbGroup_ByInstrumentType.Size = new Size(180, 22);
      this.tsbGroup_ByInstrumentType.Text = "By Instrument Type";
      this.tsbGroup_ByInstrumentType.Click += new EventHandler(this.tsbGroup_ByInstrumentType_Click);
      this.tsbGroup_ByExchange.Name = "tsbGroup_ByExchange";
      this.tsbGroup_ByExchange.Size = new Size(180, 22);
      this.tsbGroup_ByExchange.Text = "By Exchange";
      this.tsbGroup_ByExchange.Click += new EventHandler(this.tsbGroup_ByExchange_Click);
      this.tsbGroup_Alphabetically.Name = "tsbGroup_Alphabetically";
      this.tsbGroup_Alphabetically.Size = new Size(180, 22);
      this.tsbGroup_Alphabetically.Text = "Alphabetically";
      this.tsbGroup_Alphabetically.Click += new EventHandler(this.tsbGroup_Alphabetically_Click);
      this.treeView.CheckBoxes = true;
      this.treeView.Dock = DockStyle.Fill;
      this.treeView.ImageIndex = 0;
      this.treeView.ImageList = this.images;
      this.treeView.Location = new Point(0, 25);
      this.treeView.Name = "treeView";
      this.treeView.SelectedImageIndex = 0;
      this.treeView.Size = new Size(177, 141);
      this.treeView.TabIndex = 1;
      this.treeView.AfterCheck += new TreeViewEventHandler(this.treeView_AfterCheck);
      this.treeView.AfterCollapse += new TreeViewEventHandler(this.treeView_AfterCollapse);
      this.treeView.AfterExpand += new TreeViewEventHandler(this.treeView_AfterExpand);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "");
      this.images.Images.SetKeyName(1, "VSFolder_closed.png");
      this.images.Images.SetKeyName(2, "VSFolder_open.png");
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(177, 6);
      this.tsbGroup_ByCurrency.Name = "tsbGroup_ByCurrency";
      this.tsbGroup_ByCurrency.Size = new Size(180, 22);
      this.tsbGroup_ByCurrency.Text = "By Currency";
      this.tsbGroup_ByCurrency.Click += new EventHandler(this.tsbGroup_ByCurrency_Click);
      this.tsbGroup_ByMaturity.Name = "tsbGroup_ByMaturity";
      this.tsbGroup_ByMaturity.Size = new Size(180, 22);
      this.tsbGroup_ByMaturity.Text = "By Maturity";
      this.tsbGroup_ByMaturity.Click += new EventHandler(this.tsbGroup_ByMaturity_Click);
      this.tsbGroup_ByGroup.Name = "tsbGroup_ByGroup";
      this.tsbGroup_ByGroup.Size = new Size(180, 22);
      this.tsbGroup_ByGroup.Text = "By Industry Group";
      this.tsbGroup_ByGroup.Click += new EventHandler(this.tsbGroup_ByGroup_Click);
      this.tsbGroup_BySector.Name = "tsbGroup_BySector";
      this.tsbGroup_BySector.Size = new Size(180, 22);
      this.tsbGroup_BySector.Text = "By Industry Sector";
      this.tsbGroup_BySector.Click += new EventHandler(this.tsbGroup_BySector_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.treeView);
      this.Controls.Add((Control) this.toolStrip);
      this.Name = "InstrumentSelectorPanel";
      this.Size = new Size(177, 166);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
