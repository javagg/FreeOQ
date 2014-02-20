
namespace OpenQuant.Shared.Scripts
{
    public partial class ScriptExplorerWindow
  {
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.TreeView treeView;
    private System.Windows.Forms.ContextMenuStrip ctxDirectoryNode;
    private System.Windows.Forms.ToolStripMenuItem ctxDirectoryNode_Add;
    private System.Windows.Forms.ToolStripMenuItem ctxDirectoryNode_Add_NewFolder;
    private System.Windows.Forms.ToolStripMenuItem ctxDirectoryNode_Add_NewScript;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem ctxDirectoryNode_Delete;
    private System.Windows.Forms.ContextMenuStrip ctxFileNode;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_Open;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_Delete;
    private System.Windows.Forms.ImageList images;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_Build;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_Run;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_Stop;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem ctxDirectoryNode_Rename;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_Rename;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem ctxFileNode_IsStartUp;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptExplorerWindow));
            this.treeView = new System.Windows.Forms.TreeView();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.ctxDirectoryNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDirectoryNode_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDirectoryNode_Add_NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDirectoryNode_Add_NewScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxDirectoryNode_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxDirectoryNode_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxFileNode_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFileNode_Build = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFileNode_Run = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileNode_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFileNode_IsStartUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFileNode_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxFileNode_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDirectoryNode.SuspendLayout();
            this.ctxFileNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.images;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(250, 400);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCollapse);
            this.treeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCollapse);
            this.treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "script_explorer.png");
            this.images.Images.SetKeyName(1, "VSFolder_closed.png");
            this.images.Images.SetKeyName(2, "VSFolder_open.png");
            this.images.Images.SetKeyName(3, "code_cs.png");
            this.images.Images.SetKeyName(4, "code_vb.png");
            this.images.Images.SetKeyName(5, "code_unknown.png");
            // 
            // ctxDirectoryNode
            // 
            this.ctxDirectoryNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDirectoryNode_Add,
            this.toolStripMenuItem1,
            this.ctxDirectoryNode_Rename,
            this.toolStripSeparator3,
            this.ctxDirectoryNode_Delete});
            this.ctxDirectoryNode.Name = "ctxDirectoryNode";
            this.ctxDirectoryNode.Size = new System.Drawing.Size(118, 82);
            this.ctxDirectoryNode.Opening += new System.ComponentModel.CancelEventHandler(this.ctxDirectoryNode_Opening);
            // 
            // ctxDirectoryNode_Add
            // 
            this.ctxDirectoryNode_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDirectoryNode_Add_NewFolder,
            this.ctxDirectoryNode_Add_NewScript});
            this.ctxDirectoryNode_Add.Name = "ctxDirectoryNode_Add";
            this.ctxDirectoryNode_Add.Size = new System.Drawing.Size(117, 22);
            this.ctxDirectoryNode_Add.Text = "Add";
            // 
            // ctxDirectoryNode_Add_NewFolder
            // 
            this.ctxDirectoryNode_Add_NewFolder.Image = global::OpenQuant.Shared.Properties.Resources.folder_new;
            this.ctxDirectoryNode_Add_NewFolder.Name = "ctxDirectoryNode_Add_NewFolder";
            this.ctxDirectoryNode_Add_NewFolder.Size = new System.Drawing.Size(134, 22);
            this.ctxDirectoryNode_Add_NewFolder.Text = "New Folder";
            this.ctxDirectoryNode_Add_NewFolder.Click += new System.EventHandler(this.ctxDirectoryNode_Add_NewFolder_Click);
            // 
            // ctxDirectoryNode_Add_NewScript
            // 
            this.ctxDirectoryNode_Add_NewScript.Image = global::OpenQuant.Shared.Properties.Resources.script_new;
            this.ctxDirectoryNode_Add_NewScript.Name = "ctxDirectoryNode_Add_NewScript";
            this.ctxDirectoryNode_Add_NewScript.Size = new System.Drawing.Size(134, 22);
            this.ctxDirectoryNode_Add_NewScript.Text = "New Script";
            this.ctxDirectoryNode_Add_NewScript.Click += new System.EventHandler(this.ctxDirectoryNode_Add_NewScript_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // ctxDirectoryNode_Rename
            // 
            this.ctxDirectoryNode_Rename.Image = global::OpenQuant.Shared.Properties.Resources.rename;
            this.ctxDirectoryNode_Rename.Name = "ctxDirectoryNode_Rename";
            this.ctxDirectoryNode_Rename.Size = new System.Drawing.Size(117, 22);
            this.ctxDirectoryNode_Rename.Text = "Rename";
            this.ctxDirectoryNode_Rename.Click += new System.EventHandler(this.ctxDirectoryNode_Rename_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // ctxDirectoryNode_Delete
            // 
            this.ctxDirectoryNode_Delete.Image = global::OpenQuant.Shared.Properties.Resources.delete;
            this.ctxDirectoryNode_Delete.Name = "ctxDirectoryNode_Delete";
            this.ctxDirectoryNode_Delete.Size = new System.Drawing.Size(117, 22);
            this.ctxDirectoryNode_Delete.Text = "Delete";
            this.ctxDirectoryNode_Delete.Click += new System.EventHandler(this.ctxDirectoryNode_Delete_Click);
            // 
            // ctxFileNode
            // 
            this.ctxFileNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxFileNode_Open,
            this.toolStripSeparator2,
            this.ctxFileNode_Build,
            this.toolStripMenuItem2,
            this.ctxFileNode_Run,
            this.ctxFileNode_Stop,
            this.toolStripMenuItem3,
            this.ctxFileNode_IsStartUp,
            this.toolStripSeparator1,
            this.ctxFileNode_Rename,
            this.toolStripSeparator4,
            this.ctxFileNode_Delete});
            this.ctxFileNode.Name = "ctxDirectoryNode";
            this.ctxFileNode.Size = new System.Drawing.Size(124, 188);
            this.ctxFileNode.Opening += new System.ComponentModel.CancelEventHandler(this.ctxFileNode_Opening);
            // 
            // ctxFileNode_Open
            // 
            this.ctxFileNode_Open.Name = "ctxFileNode_Open";
            this.ctxFileNode_Open.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_Open.Text = "Open";
            this.ctxFileNode_Open.Click += new System.EventHandler(this.ctxFileNode_Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // ctxFileNode_Build
            // 
            this.ctxFileNode_Build.Image = global::OpenQuant.Shared.Properties.Resources.script_build;
            this.ctxFileNode_Build.Name = "ctxFileNode_Build";
            this.ctxFileNode_Build.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_Build.Text = "Build";
            this.ctxFileNode_Build.Click += new System.EventHandler(this.ctxFileNode_Build_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // ctxFileNode_Run
            // 
            this.ctxFileNode_Run.Image = global::OpenQuant.Shared.Properties.Resources.script_run;
            this.ctxFileNode_Run.Name = "ctxFileNode_Run";
            this.ctxFileNode_Run.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_Run.Text = "Run";
            this.ctxFileNode_Run.Click += new System.EventHandler(this.ctxFileNode_Run_Click);
            // 
            // ctxFileNode_Stop
            // 
            this.ctxFileNode_Stop.Image = global::OpenQuant.Shared.Properties.Resources.script_stop;
            this.ctxFileNode_Stop.Name = "ctxFileNode_Stop";
            this.ctxFileNode_Stop.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_Stop.Text = "Stop";
            this.ctxFileNode_Stop.Click += new System.EventHandler(this.ctxFileNode_Stop_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 6);
            // 
            // ctxFileNode_IsStartUp
            // 
            this.ctxFileNode_IsStartUp.CheckOnClick = true;
            this.ctxFileNode_IsStartUp.Name = "ctxFileNode_IsStartUp";
            this.ctxFileNode_IsStartUp.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_IsStartUp.Text = "Is Startup";
            this.ctxFileNode_IsStartUp.Click += new System.EventHandler(this.ctxFileNode_IsStartUp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // ctxFileNode_Rename
            // 
            this.ctxFileNode_Rename.Image = global::OpenQuant.Shared.Properties.Resources.rename;
            this.ctxFileNode_Rename.Name = "ctxFileNode_Rename";
            this.ctxFileNode_Rename.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_Rename.Text = "Rename";
            this.ctxFileNode_Rename.Click += new System.EventHandler(this.ctxFileNode_Rename_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(120, 6);
            // 
            // ctxFileNode_Delete
            // 
            this.ctxFileNode_Delete.Image = global::OpenQuant.Shared.Properties.Resources.delete;
            this.ctxFileNode_Delete.Name = "ctxFileNode_Delete";
            this.ctxFileNode_Delete.Size = new System.Drawing.Size(123, 22);
            this.ctxFileNode_Delete.Text = "Delete";
            this.ctxFileNode_Delete.Click += new System.EventHandler(this.ctxFileNode_Delete_Click);
            // 
            // ScriptExplorerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Right;
            this.Name = "ScriptExplorerWindow";
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.script_explorer;
            this.Text = "Script Explorer";
            this.ctxDirectoryNode.ResumeLayout(false);
            this.ctxFileNode.ResumeLayout(false);
            this.ResumeLayout(false);

    }

 
  }
}
