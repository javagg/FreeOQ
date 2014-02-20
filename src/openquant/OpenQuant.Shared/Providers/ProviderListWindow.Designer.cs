namespace OpenQuant.Shared.Providers
{
    public partial class ProviderListWindow
  {

    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.TreeView trvProviders;
    private System.Windows.Forms.ImageList images;
    private System.Windows.Forms.ContextMenuStrip ctxProviders;
    private System.Windows.Forms.ToolStripMenuItem ctxProviders_Connect;
    private System.Windows.Forms.ToolStripMenuItem ctxProviders_Disconnect;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ctxProviders_Properties;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderListWindow));
            this.trvProviders = new System.Windows.Forms.TreeView();
            this.ctxProviders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxProviders_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxProviders_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxProviders_Properties = new System.Windows.Forms.ToolStripMenuItem();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.ctxProviders.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvProviders
            // 
            this.trvProviders.ContextMenuStrip = this.ctxProviders;
            this.trvProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProviders.HideSelection = false;
            this.trvProviders.ImageIndex = 0;
            this.trvProviders.ImageList = this.images;
            this.trvProviders.Location = new System.Drawing.Point(0, 0);
            this.trvProviders.Name = "trvProviders";
            this.trvProviders.SelectedImageIndex = 0;
            this.trvProviders.ShowNodeToolTips = true;
            this.trvProviders.Size = new System.Drawing.Size(250, 400);
            this.trvProviders.TabIndex = 0;
            this.trvProviders.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvProviders_AfterCollapse);
            this.trvProviders.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvProviders_AfterExpand);
            this.trvProviders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProviders_AfterSelect);
            this.trvProviders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvProviders_MouseDown);
            // 
            // ctxProviders
            // 
            this.ctxProviders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxProviders_Connect,
            this.ctxProviders_Disconnect,
            this.toolStripSeparator1,
            this.ctxProviders_Properties});
            this.ctxProviders.Name = "ctxProviders";
            this.ctxProviders.Size = new System.Drawing.Size(134, 76);
            this.ctxProviders.Opening += new System.ComponentModel.CancelEventHandler(this.ctxProviders_Opening);
            // 
            // ctxProviders_Connect
            // 
            this.ctxProviders_Connect.Image = global::OpenQuant.Shared.Properties.Resources.provider_connected;
            this.ctxProviders_Connect.Name = "ctxProviders_Connect";
            this.ctxProviders_Connect.Size = new System.Drawing.Size(133, 22);
            this.ctxProviders_Connect.Text = "Connect";
            this.ctxProviders_Connect.Click += new System.EventHandler(this.ctxProviders_Connect_Click);
            // 
            // ctxProviders_Disconnect
            // 
            this.ctxProviders_Disconnect.Image = global::OpenQuant.Shared.Properties.Resources.provider_disconnected;
            this.ctxProviders_Disconnect.Name = "ctxProviders_Disconnect";
            this.ctxProviders_Disconnect.Size = new System.Drawing.Size(133, 22);
            this.ctxProviders_Disconnect.Text = "Disconnect";
            this.ctxProviders_Disconnect.Click += new System.EventHandler(this.ctxProviders_Disconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // ctxProviders_Properties
            // 
            this.ctxProviders_Properties.Image = global::OpenQuant.Shared.Properties.Resources.properties;
            this.ctxProviders_Properties.Name = "ctxProviders_Properties";
            this.ctxProviders_Properties.Size = new System.Drawing.Size(133, 22);
            this.ctxProviders_Properties.Text = "Properties";
            this.ctxProviders_Properties.Click += new System.EventHandler(this.ctxProviders_Properties_Click);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
                this.images.Images.SetKeyName(0, "client_network.png");
              this.images.Images.SetKeyName(1, "client_network.png");
              this.images.Images.SetKeyName(2, "trafficlight_red.png");
               this.images.Images.SetKeyName(3, "trafficlight_green.png");
            // 
            // ProviderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvProviders);
            this.Name = "ProviderListWindow";
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.providers;
            this.Text = "Providers";
            this.ctxProviders.ResumeLayout(false);
            this.ResumeLayout(false);

    }

  
  }
}
