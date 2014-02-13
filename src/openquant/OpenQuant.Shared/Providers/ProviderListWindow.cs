using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using OpenQuant.Shared.ToolWindows;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Providers
{
	public class ProviderListWindow : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable
  {
    protected const string CATEGORY_GROUPS = "Groups";
    protected const bool DEFAULT_SHOW_GROUP = true;
    private IContainer components;
    private TreeView trvProviders;
    private ImageList images;
    private ContextMenuStrip ctxProviders;
    private ToolStripMenuItem ctxProviders_Connect;
    private ToolStripMenuItem ctxProviders_Disconnect;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxProviders_Properties;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Groups")]
    [DefaultValue(true)]
    public bool ShowMarketDataGroup { get; set; }

    [DefaultValue(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Groups")]
    public bool ShowExecutionGroup { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(true)]
    [Category("Groups")]
    public bool ShowInstrumentGroup { get; set; }

    [Category("Groups")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(true)]
    public bool ShowHistoricalDataGroup { get; set; }

    public object PropertyObject
    {
      get
      {
        ProviderNode providerNode = this.trvProviders.SelectedNode as ProviderNode;
        if (providerNode != null)
          return (object) providerNode.Provider;
        else
          return (object) null;
      }
    }

    public ProviderListWindow()
    {
      this.InitializeComponent();
      this.ShowMarketDataGroup = true;
      this.ShowExecutionGroup = true;
      this.ShowInstrumentGroup = true;
      this.ShowHistoricalDataGroup = true;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ProviderListWindow));
      this.trvProviders = new TreeView();
      this.ctxProviders = new ContextMenuStrip(this.components);
      this.ctxProviders_Connect = new ToolStripMenuItem();
      this.ctxProviders_Disconnect = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxProviders_Properties = new ToolStripMenuItem();
      this.images = new ImageList(this.components);
      this.ctxProviders.SuspendLayout();
      this.SuspendLayout();
      this.trvProviders.ContextMenuStrip = this.ctxProviders;
      this.trvProviders.Dock = DockStyle.Fill;
      this.trvProviders.HideSelection = false;
      this.trvProviders.ImageIndex = 0;
      this.trvProviders.ImageList = this.images;
      this.trvProviders.Location = new Point(0, 0);
      this.trvProviders.Name = "trvProviders";
      this.trvProviders.SelectedImageIndex = 0;
      this.trvProviders.ShowNodeToolTips = true;
      this.trvProviders.Size = new Size(250, 400);
      this.trvProviders.TabIndex = 0;
      this.trvProviders.AfterCollapse += new TreeViewEventHandler(this.trvProviders_AfterCollapse);
      this.trvProviders.AfterSelect += new TreeViewEventHandler(this.trvProviders_AfterSelect);
      this.trvProviders.AfterExpand += new TreeViewEventHandler(this.trvProviders_AfterExpand);
      this.trvProviders.MouseDown += new MouseEventHandler(this.trvProviders_MouseDown);
      this.ctxProviders.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.ctxProviders_Connect,
        (ToolStripItem) this.ctxProviders_Disconnect,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxProviders_Properties
      });
      this.ctxProviders.Name = "ctxProviders";
      this.ctxProviders.Size = new Size(138, 76);
      this.ctxProviders.Opening += new CancelEventHandler(this.ctxProviders_Opening);
      this.ctxProviders_Connect.Image = (Image) Resources.provider_connected;
      this.ctxProviders_Connect.Name = "ctxProviders_Connect";
      this.ctxProviders_Connect.Size = new Size(137, 22);
      this.ctxProviders_Connect.Text = "Connect";
      this.ctxProviders_Connect.Click += new EventHandler(this.ctxProviders_Connect_Click);
      this.ctxProviders_Disconnect.Image = (Image) Resources.provider_disconnected;
      this.ctxProviders_Disconnect.Name = "ctxProviders_Disconnect";
      this.ctxProviders_Disconnect.Size = new Size(137, 22);
      this.ctxProviders_Disconnect.Text = "Disconnect";
      this.ctxProviders_Disconnect.Click += new EventHandler(this.ctxProviders_Disconnect_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(134, 6);
      this.ctxProviders_Properties.Image = (Image) Resources.properties;
      this.ctxProviders_Properties.Name = "ctxProviders_Properties";
      this.ctxProviders_Properties.Size = new Size(137, 22);
      this.ctxProviders_Properties.Text = "Properties";
      this.ctxProviders_Properties.Click += new EventHandler(this.ctxProviders_Properties_Click);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "client_network.png");
      this.images.Images.SetKeyName(1, "client_network.png");
      this.images.Images.SetKeyName(2, "trafficlight_red.png");
      this.images.Images.SetKeyName(3, "trafficlight_green.png");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.trvProviders);
      this.DefaultDockLocation = ContainerDockLocation.Left;
      this.Name = "ProviderListWindow";
      this.TabImage = (Image) Resources.providers;
      this.Text = "Providers";
      this.ctxProviders.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnInit()
    {
      if (this.ShowMarketDataGroup)
        this.trvProviders.Nodes.Add((TreeNode) new ProviderTypeNode(typeof (IMarketDataProvider), "Market Data"));
      if (this.ShowExecutionGroup)
        this.trvProviders.Nodes.Add((TreeNode) new ProviderTypeNode(typeof (IExecutionProvider), "Execution"));
      if (this.ShowInstrumentGroup)
        this.trvProviders.Nodes.Add((TreeNode) new ProviderTypeNode(typeof (IInstrumentProvider), "Instrument"));
      if (this.ShowHistoricalDataGroup)
        this.trvProviders.Nodes.Add((TreeNode) new ProviderTypeNode(typeof (IHistoricalDataProvider), "Historical Data"));
      this.trvProviders.BeginUpdate();
      IEnumerator enumerator = ProviderManager.Providers.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.AddProvider((IProvider) enumerator.Current);
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      this.trvProviders.Sort();
      this.trvProviders.EndUpdate();
      // ISSUE: method pointer
			ProviderManager.Added += new ProviderEventHandler(this.ProviderManager_Added);
      // ISSUE: method pointer
			ProviderManager.Connected += new ProviderEventHandler(this.ProviderManager_Connected);
      // ISSUE: method pointer
			ProviderManager.Disconnected += new ProviderEventHandler(this.ProviderManager_Disconnected);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      // ISSUE: method pointer
			ProviderManager.Added -= new ProviderEventHandler(this.ProviderManager_Added);
      // ISSUE: method pointer
			ProviderManager.Connected -= new ProviderEventHandler(this.ProviderManager_Connected);
      // ISSUE: method pointer
			ProviderManager.Disconnected -= new ProviderEventHandler(this.ProviderManager_Disconnected);
      base.OnClosing(e);
    }

    private void ProviderManager_Added(ProviderEventArgs args)
    {
      if (this.InvokeRequired)
      {
        // ISSUE: method pointer
        this.BeginInvoke((Delegate) new ProviderEventHandler(this.ProviderManager_Added), new object[]
        {
          (object) args
        });
      }
      else
        this.AddProvider(args.Provider);
    }

    private void ProviderManager_Connected(ProviderEventArgs args)
    {
      if (this.InvokeRequired)
      {
        // ISSUE: method pointer
        this.BeginInvoke((Delegate) new ProviderEventHandler(this.ProviderManager_Connected), new object[]
        {
          (object) args
        });
      }
      else
        this.UpdateProviderStatus(args.Provider);
    }

    private void ProviderManager_Disconnected(ProviderEventArgs args)
    {
      if (this.InvokeRequired)
      {
        // ISSUE: method pointer
        this.BeginInvoke((Delegate) new ProviderEventHandler(this.ProviderManager_Disconnected), new object[] { args });
      }
      else
        this.UpdateProviderStatus(args.Provider);
    }

    private void AddProvider(IProvider provider)
    {
      foreach (ProviderTypeNode providerTypeNode in this.trvProviders.Nodes)
      {
        if (providerTypeNode.IsProviderValid(provider))
          providerTypeNode.AddProvider(provider);
      }
    }

    private void UpdateProviderStatus(IProvider provider)
    {
      foreach (ProviderTypeNode providerTypeNode in this.trvProviders.Nodes)
        providerTypeNode.UpdateProviderStatus(provider);
    }

    private void ctxProviders_Opening(object sender, CancelEventArgs e)
    {
      if (this.trvProviders.SelectedNode is ProviderNode)
      {
        IProvider provider = (this.trvProviders.SelectedNode as ProviderNode).Provider;
        this.ctxProviders_Connect.Enabled = !provider.IsConnected;
        this.ctxProviders_Disconnect.Enabled = provider.IsConnected;
      }
      else
        e.Cancel = true;
    }

    private void ctxProviders_Connect_Click(object sender, EventArgs e)
    {
      Global.ProviderHelper.Connect((this.trvProviders.SelectedNode as ProviderNode).Provider);
    }

    private void ctxProviders_Disconnect_Click(object sender, EventArgs e)
    {
      Global.ProviderHelper.Disconnect((this.trvProviders.SelectedNode as ProviderNode).Provider);
    }

    private void ctxProviders_Properties_Click(object sender, EventArgs e)
    {
      Global.ToolWindowManager.ShowProperties((IPropertyEditable) this, true);
    }

    private void trvProviders_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      this.trvProviders.SelectedNode = this.trvProviders.GetNodeAt(e.Location);
    }

    private void trvProviders_AfterSelect(object sender, TreeViewEventArgs e)
    {
      Global.ToolWindowManager.ShowProperties((IPropertyEditable) this, false);
    }

    private void trvProviders_AfterExpand(object sender, TreeViewEventArgs e)
    {
      ((ProviderTypeNode) e.Node).UpdateIcon();
    }

    private void trvProviders_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      ((ProviderTypeNode) e.Node).UpdateIcon();
    }
  }
}
