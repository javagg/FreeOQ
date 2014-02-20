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
    public partial class ProviderListWindow : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable
  {
    protected const string CATEGORY_GROUPS = "Groups";
    protected const bool DEFAULT_SHOW_GROUP = true;
  

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
