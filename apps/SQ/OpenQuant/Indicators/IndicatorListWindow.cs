// Type: OpenQuant.Indicators.IndicatorListWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Properties;
using OpenQuant.Shared.Indicators;
using SmartQuant.Docking.WinForms;
using SmartQuant.Indicators;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Indicators
{
  internal class IndicatorListWindow : DockControl
  {
    private IContainer components;
    private TreeView trvIndicators;
    private ImageList images;
    private Rectangle dragBoxFromMouseDown;
    private Point screenOffset;
    private Cursor myNoDropCursor;
    private Cursor myNormalCursor;
    private TreeNode nodeToDrag;

    public IndicatorListWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.Init();
      this.trvIndicators.Sort();
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
      TreeNode treeNode1 = new TreeNode("Price");
      TreeNode treeNode2 = new TreeNode("Oscillator");
      TreeNode treeNode3 = new TreeNode("Volume");
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IndicatorListWindow));
      this.trvIndicators = new TreeView();
      this.images = new ImageList(this.components);
      ((Control) this).SuspendLayout();
      this.trvIndicators.Dock = DockStyle.Fill;
      this.trvIndicators.HideSelection = false;
      this.trvIndicators.ImageIndex = 0;
      this.trvIndicators.ImageList = this.images;
      this.trvIndicators.Location = new Point(0, 0);
      this.trvIndicators.Name = "trvIndicators";
      treeNode1.Name = "priceNode";
      treeNode1.Text = "Price";
      treeNode2.Name = "oscillatorNode";
      treeNode2.Text = "Oscillator";
      treeNode3.Name = "volumeNode";
      treeNode3.Text = "Volume";
      this.trvIndicators.Nodes.AddRange(new TreeNode[3]
      {
        treeNode1,
        treeNode2,
        treeNode3
      });
      this.trvIndicators.SelectedImageIndex = 0;
      this.trvIndicators.Size = new Size(250, 400);
      this.trvIndicators.TabIndex = 1;
      this.trvIndicators.AfterCollapse += new TreeViewEventHandler(this.trvIndicators_AfterCollapse);
      this.trvIndicators.MouseUp += new MouseEventHandler(this.trvIndicators_MouseUp);
      this.trvIndicators.MouseMove += new MouseEventHandler(this.trvIndicators_MouseMove);
      this.trvIndicators.AfterExpand += new TreeViewEventHandler(this.trvIndicators_AfterExpand);
      this.trvIndicators.MouseDown += new MouseEventHandler(this.trvIndicators_MouseDown);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "VSObject_Namespace.png");
      this.images.Images.SetKeyName(1, "VSObject_Namespace.png");
      this.images.Images.SetKeyName(2, "indicator.png");
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((Control) this).Controls.Add((Control) this.trvIndicators);
      this.set_DefaultDockLocation((ContainerDockLocation) 1);
      ((Control) this).Name = "IndicatorListWindow";
      ((DockControl) this).set_TabImage((Image) Resources.indicator);
      ((Control) this).Text = "Indicators";
      ((Control) this).ResumeLayout(false);
    }

    private void Init()
    {
      foreach (System.Type type in Assembly.GetAssembly(typeof (Indicator)).GetTypes())
      {
        if (type.IsSubclassOf(typeof (Indicator)))
        {
          Indicator indicator = Activator.CreateInstance(type) as Indicator;
          IndicatorNode indicatorNode = new IndicatorNode(type);
          switch (indicator.Type)
          {
            case EIndicatorType.Oscillator:
              this.trvIndicators.Nodes["oscillatorNode"].Nodes.Add((TreeNode) indicatorNode);
              continue;
            case EIndicatorType.Price:
              this.trvIndicators.Nodes["priceNode"].Nodes.Add((TreeNode) indicatorNode);
              continue;
            case EIndicatorType.Volume:
              this.trvIndicators.Nodes["volumeNode"].Nodes.Add((TreeNode) indicatorNode);
              continue;
            default:
              continue;
          }
        }
      }
    }

    private void trvIndicators_MouseUp(object sender, MouseEventArgs e)
    {
      this.dragBoxFromMouseDown = Rectangle.Empty;
    }

    private void trvIndicators_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left || !(this.nodeToDrag is IndicatorNode) || !(this.dragBoxFromMouseDown != Rectangle.Empty))
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
        int num = (int) this.trvIndicators.DoDragDrop((object) new IndicatorData((this.nodeToDrag as IndicatorNode).IndicatorType), DragDropEffects.Copy);
      }
    }

    private void trvIndicators_MouseDown(object sender, MouseEventArgs e)
    {
      TreeNode nodeAt = this.trvIndicators.GetNodeAt(e.X, e.Y);
      if (nodeAt != null)
      {
        if (e.Button == MouseButtons.Right)
          this.trvIndicators.SelectedNode = nodeAt;
        this.nodeToDrag = nodeAt;
        Size dragSize = SystemInformation.DragSize;
        this.dragBoxFromMouseDown = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
      }
      else
        this.dragBoxFromMouseDown = Rectangle.Empty;
    }

    private void trvIndicators_AfterExpand(object sender, TreeViewEventArgs e)
    {
      this.UpdateNodeIcon(e.Node);
    }

    private void trvIndicators_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      this.UpdateNodeIcon(e.Node);
    }

    private void UpdateNodeIcon(TreeNode node)
    {
      int num = !node.IsExpanded ? 0 : 1;
      node.ImageIndex = node.SelectedImageIndex = num;
    }
  }
}
