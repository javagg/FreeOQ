using OpenQuant.Shared.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using TD.SandDock;

namespace OpenQuant.Shared.Logs
{
    public class StrategyMonitorWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private IContainer components;
    private System.Windows.Forms.TabControl tabControl;
    private ImageList imgTabs;
    private ContextMenuStrip ctxTabs;
    private ToolStripMenuItem ctxTabs_New;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxTabs_Rename;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxTabs_Remove;
    private ToolStrip toolStrip;
    private ToolStripDropDownButton tsbLayout;
    private ToolStripMenuItem tsbLayout_Load;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem tsbLayout_Save;
    private ToolStripMenuItem tsbLayout_SaveAs;
    private SaveFileDialog dlgSaveLayout;
    private OpenFileDialog dlgLoadLayout;
    private StrategyLogManager manager;
    private System.Windows.Forms.TabPage draggedTab;
    private string lastUsedLayoutPath;

    public virtual string SolutionName
    {
      get
      {
        return "<SOLUTION>";
      }
    }

    public StrategyMonitorWindow()
    {
      this.InitializeComponent();
      this.draggedTab = (System.Windows.Forms.TabPage) null;
      this.lastUsedLayoutPath = (string) null;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (StrategyMonitorWindow));
      this.tabControl = new System.Windows.Forms.TabControl();
      this.ctxTabs = new ContextMenuStrip(this.components);
      this.ctxTabs_New = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxTabs_Rename = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxTabs_Remove = new ToolStripMenuItem();
      this.imgTabs = new ImageList(this.components);
      this.toolStrip = new ToolStrip();
      this.tsbLayout = new ToolStripDropDownButton();
      this.tsbLayout_Load = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.tsbLayout_Save = new ToolStripMenuItem();
      this.tsbLayout_SaveAs = new ToolStripMenuItem();
      this.dlgSaveLayout = new SaveFileDialog();
      this.dlgLoadLayout = new OpenFileDialog();
      this.ctxTabs.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      this.tabControl.ContextMenuStrip = this.ctxTabs;
      this.tabControl.Dock = DockStyle.Fill;
      this.tabControl.ImageList = this.imgTabs;
      this.tabControl.ItemSize = new Size(58, 18);
      this.tabControl.Location = new Point(0, 25);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new Size(630, 460);
      this.tabControl.TabIndex = 0;
      this.tabControl.MouseDown += new MouseEventHandler(this.tabControl_MouseDown);
      this.tabControl.MouseMove += new MouseEventHandler(this.tabControl_MouseMove);
      this.ctxTabs.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ctxTabs_New,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxTabs_Rename,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxTabs_Remove
      });
      this.ctxTabs.Name = "ctxTabs";
      this.ctxTabs.Size = new Size(124, 82);
      this.ctxTabs.Opening += new CancelEventHandler(this.ctxTabs_Opening);
      this.ctxTabs_New.Name = "ctxTabs_New";
      this.ctxTabs_New.Size = new Size(123, 22);
      this.ctxTabs_New.Text = "Add New";
      this.ctxTabs_New.Click += new EventHandler(this.ctxTabs_New_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(120, 6);
      this.ctxTabs_Rename.Image = (Image) Resources.rename;
      this.ctxTabs_Rename.Name = "ctxTabs_Rename";
      this.ctxTabs_Rename.Size = new Size(123, 22);
      this.ctxTabs_Rename.Text = "Rename";
      this.ctxTabs_Rename.Click += new EventHandler(this.ctxTabs_Rename_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(120, 6);
      this.ctxTabs_Remove.Image = (Image) Resources.delete;
      this.ctxTabs_Remove.Name = "ctxTabs_Remove";
      this.ctxTabs_Remove.Size = new Size(123, 22);
      this.ctxTabs_Remove.Text = "Remove";
      this.ctxTabs_Remove.Click += new EventHandler(this.ctxTabs_Remove_Click);
      this.imgTabs.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgTabs.ImageStream");
      this.imgTabs.TransparentColor = Color.Transparent;
      this.imgTabs.Images.SetKeyName(0, "tab.png");
      this.toolStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbLayout
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(630, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "toolStrip1";
      this.tsbLayout.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.tsbLayout_Load,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.tsbLayout_Save,
        (ToolStripItem) this.tsbLayout_SaveAs
      });
      this.tsbLayout.Image = (Image) componentResourceManager.GetObject("tsbLayout.Image");
      this.tsbLayout.ImageTransparentColor = Color.Magenta;
      this.tsbLayout.Name = "tsbLayout";
      this.tsbLayout.Size = new Size(72, 22);
      this.tsbLayout.Text = "Layout";
      this.tsbLayout.DropDownOpening += new EventHandler(this.tsbLayout_DropDownOpening);
      this.tsbLayout_Load.Name = "tsbLayout_Load";
      this.tsbLayout_Load.Size = new Size(152, 22);
      this.tsbLayout_Load.Text = "Load...";
      this.tsbLayout_Load.Click += new EventHandler(this.tsbLayout_Load_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(159, 6);
      this.tsbLayout_Save.Name = "tsbLayout_Save";
      this.tsbLayout_Save.Size = new Size(152, 22);
      this.tsbLayout_Save.Text = "Save";
      this.tsbLayout_Save.Click += new EventHandler(this.tsbLayout_Save_Click);
      this.tsbLayout_SaveAs.Name = "tsbLayout_SaveAs";
      this.tsbLayout_SaveAs.Size = new Size(152, 22);
      this.tsbLayout_SaveAs.Text = "Save As...";
      this.tsbLayout_SaveAs.Click += new EventHandler(this.tsbLayout_SaveAs_Click);
      this.dlgSaveLayout.DefaultExt = "*.sml";
      this.dlgSaveLayout.Filter = "Layout Files|*.sml|All Files|*.*";
      this.dlgSaveLayout.Title = "Save Layout";
      this.dlgLoadLayout.Filter = "Layout Files|*.sml|All Files|*.*";
      this.dlgLoadLayout.Title = "Load Layout";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.tabControl);
      this.Controls.Add((Control) this.toolStrip);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.Name = "StrategyMonitorWindow";
      this.PersistState = false;
      this.Size = new Size(630, 485);
      this.TabImage = (Image) Resources.strategy_monitor;
      this.Text = "Strategy Monitor";
      this.ctxTabs.ResumeLayout(false);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnInit()
    {
      this.manager = (StrategyLogManager) this.Key;
    }

    protected override void OnLoad(EventArgs e)
    {
      this.ApplyLayout(LayoutInfo.Default);
      base.OnLoad(e);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      this.RemoveAllTabs();
      base.OnClosing(e);
    }

    private void tsbLayout_DropDownOpening(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.lastUsedLayoutPath))
      {
        this.tsbLayout_Save.Text = "Save";
        this.tsbLayout_SaveAs.Text = "Save As...";
      }
      else
      {
        string fileName = Path.GetFileName(this.lastUsedLayoutPath);
        this.tsbLayout_Save.Text = string.Format("Save {0}", (object) fileName);
        this.tsbLayout_SaveAs.Text = string.Format("Save {0} As...", (object) fileName);
      }
    }

    private void tsbLayout_Load_Click(object sender, EventArgs e)
    {
      if (this.dlgLoadLayout.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string fileName = this.dlgLoadLayout.FileName;
      LayoutInfo layout;
      if (!this.LoadLayout(fileName, out layout))
        return;
      this.ApplyLayout(layout);
      this.lastUsedLayoutPath = fileName;
    }

    private void tsbLayout_Save_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.lastUsedLayoutPath))
        this.SaveLayoutAs();
      else
        this.SaveLayout(this.lastUsedLayoutPath, this.GetLayout());
    }

    private void tsbLayout_SaveAs_Click(object sender, EventArgs e)
    {
      this.SaveLayoutAs();
    }

    private void ctxTabs_Opening(object sender, CancelEventArgs e)
    {
      System.Windows.Forms.TabPage tabAt = this.GetTabAt(this.tabControl.PointToClient(Cursor.Position));
      if (tabAt == null)
      {
        e.Cancel = true;
      }
      else
      {
        this.tabControl.SelectedTab = tabAt;
        this.ctxTabs_Remove.Enabled = this.tabControl.TabCount > 1;
      }
    }

    private void ctxTabs_New_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.TabPage selectedTab = this.tabControl.SelectedTab;
      TabNameForm tabNameForm = new TabNameForm();
      tabNameForm.TabName = "New Tab Name";
      tabNameForm.Text = "Add New Tab";
      if (tabNameForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
        this.InsertTab(this.tabControl.TabPages.IndexOf(selectedTab) + 1, tabNameForm.TabName);
      tabNameForm.Dispose();
    }

    private void ctxTabs_Rename_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.TabPage selectedTab = this.tabControl.SelectedTab;
      TabNameForm tabNameForm = new TabNameForm();
      tabNameForm.TabName = selectedTab.Text;
      tabNameForm.Text = "Rename";
      if (tabNameForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
        selectedTab.Text = tabNameForm.TabName;
      tabNameForm.Dispose();
    }

    private void ctxTabs_Remove_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.TabPage selectedTab = this.tabControl.SelectedTab;
      if (MessageBox.Show((IWin32Window) this, string.Format("Do you really want to remove '{0}' tab?", (object) selectedTab.Text), "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.RemoveTab(selectedTab);
    }

    private void tabControl_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.draggedTab = this.GetTabAt(e.Location);
    }

    private void tabControl_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left || this.draggedTab == null)
        return;
      System.Windows.Forms.TabPage tabAt = this.GetTabAt(e.Location);
      if (tabAt == null || tabAt == this.draggedTab)
        return;
      int index1 = this.tabControl.TabPages.IndexOf(this.draggedTab);
      int index2 = this.tabControl.TabPages.IndexOf(tabAt);
      this.tabControl.TabPages[index1] = tabAt;
      this.tabControl.TabPages[index2] = this.draggedTab;
      this.tabControl.SelectedTab = this.draggedTab;
    }

    private void InsertTab(int index, string tabName)
    {
      System.Windows.Forms.TabPage tabPage = new System.Windows.Forms.TabPage(tabName);
      tabPage.ImageIndex = 0;
      StrategyMonitorControl strategyMonitorControl = new StrategyMonitorControl();
      strategyMonitorControl.Dock = DockStyle.Fill;
      strategyMonitorControl.Init(this.manager, this.SolutionName);
      tabPage.Tag = (object) strategyMonitorControl;
      tabPage.Controls.Add((Control) strategyMonitorControl);
      this.tabControl.TabPages.Insert(index, tabPage);
      this.tabControl.SelectedTab = tabPage;
    }

    private void RemoveTab(System.Windows.Forms.TabPage tab)
    {
      ((StrategyMonitorControl) tab.Tag).Detach();
      this.tabControl.TabPages.Remove(tab);
    }

    private void RemoveAllTabs()
    {
      while (this.tabControl.TabCount > 0)
        this.RemoveTab(this.tabControl.TabPages[0]);
    }

    private System.Windows.Forms.TabPage GetTabAt(Point point)
    {
      for (int index = 0; index < this.tabControl.TabCount; ++index)
      {
        if (this.tabControl.GetTabRect(index).Contains(point))
          return this.tabControl.TabPages[index];
      }
      return (System.Windows.Forms.TabPage) null;
    }

    private void SaveLayoutAs()
    {
      if (this.dlgSaveLayout.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string fileName = this.dlgSaveLayout.FileName;
      this.SaveLayout(fileName, this.GetLayout());
      this.lastUsedLayoutPath = fileName;
    }

    private void SaveLayout(string path, LayoutInfo layout)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (LayoutInfo));
        FileStream fileStream = new FileStream(path, FileMode.Create);
        xmlSerializer.Serialize((Stream) fileStream, (object) layout);
        fileStream.Close();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ((object) ex).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool LoadLayout(string path, out LayoutInfo layout)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (LayoutInfo));
        FileStream fileStream = new FileStream(path, FileMode.Open);
        layout = (LayoutInfo) xmlSerializer.Deserialize((Stream) fileStream);
        fileStream.Close();
        return true;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ((object) ex).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        layout = LayoutInfo.Default;
        return false;
      }
    }

    private void ApplyLayout(LayoutInfo layout)
    {
      this.RemoveAllTabs();
      for (int index = 0; index < layout.Tabs.Length; ++index)
      {
        TabLayoutInfo tabLayoutInfo = layout.Tabs[index];
        this.InsertTab(index, tabLayoutInfo.TabName);
        ((StrategyMonitorControl) this.tabControl.TabPages[index].Tag).SetColumnLayout(tabLayoutInfo.StrategyColumns, tabLayoutInfo.InstrumentColumns);
      }
    }

    private LayoutInfo GetLayout()
    {
      LayoutInfo layoutInfo = new LayoutInfo();
      layoutInfo.Tabs = new TabLayoutInfo[this.tabControl.TabCount];
      for (int index = 0; index < this.tabControl.TabCount; ++index)
      {
        System.Windows.Forms.TabPage tabPage = this.tabControl.TabPages[index];
        TabLayoutInfo tabLayoutInfo = new TabLayoutInfo();
        tabLayoutInfo.TabName = tabPage.Text;
        StrategyMonitorControl strategyMonitorControl = (StrategyMonitorControl) tabPage.Tag;
        tabLayoutInfo.StrategyColumns = strategyMonitorControl.GetStrategyColumnLayout();
        tabLayoutInfo.InstrumentColumns = strategyMonitorControl.GetInstrumentColumnLayout();
        layoutInfo.Tabs[index] = tabLayoutInfo;
      }
      return layoutInfo;
    }
  }
}
