using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Properties;
using OpenQuant.Shared.ToolWindows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Scripts
{
  public class ScriptExplorerWindow : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable
  {
    private IContainer components;
    private TreeView treeView;
    private ContextMenuStrip ctxDirectoryNode;
    private ToolStripMenuItem ctxDirectoryNode_Add;
    private ToolStripMenuItem ctxDirectoryNode_Add_NewFolder;
    private ToolStripMenuItem ctxDirectoryNode_Add_NewScript;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem ctxDirectoryNode_Delete;
    private ContextMenuStrip ctxFileNode;
    private ToolStripMenuItem ctxFileNode_Open;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxFileNode_Delete;
    private ImageList images;
    private ToolStripMenuItem ctxFileNode_Build;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripMenuItem ctxFileNode_Run;
    private ToolStripMenuItem ctxFileNode_Stop;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxDirectoryNode_Rename;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ctxFileNode_Rename;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripSeparator toolStripMenuItem3;
    private ToolStripMenuItem ctxFileNode_IsStartUp;
    private FileSystemWatcher watcher;

    protected virtual BuildOptions BuildOptions
    {
      get
      {
        return (BuildOptions) null;
      }
    }

    protected virtual ScriptsOptions ScriptsOptions
    {
      get
      {
        return (ScriptsOptions) null;
      }
    }

    public object PropertyObject { get; private set; }

    public ScriptExplorerWindow()
    {
      this.InitializeComponent();
      this.treeView.TreeViewNodeSorter = (IComparer) new ScriptTreeNodeSorter();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ScriptExplorerWindow));
      this.treeView = new TreeView();
      this.images = new ImageList(this.components);
      this.ctxDirectoryNode = new ContextMenuStrip(this.components);
      this.ctxDirectoryNode_Add = new ToolStripMenuItem();
      this.ctxDirectoryNode_Add_NewFolder = new ToolStripMenuItem();
      this.ctxDirectoryNode_Add_NewScript = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripSeparator();
      this.ctxDirectoryNode_Rename = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.ctxDirectoryNode_Delete = new ToolStripMenuItem();
      this.ctxFileNode = new ContextMenuStrip(this.components);
      this.ctxFileNode_Open = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxFileNode_Build = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripSeparator();
      this.ctxFileNode_Run = new ToolStripMenuItem();
      this.ctxFileNode_Stop = new ToolStripMenuItem();
      this.toolStripMenuItem3 = new ToolStripSeparator();
      this.ctxFileNode_IsStartUp = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxFileNode_Rename = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.ctxFileNode_Delete = new ToolStripMenuItem();
      this.ctxDirectoryNode.SuspendLayout();
      this.ctxFileNode.SuspendLayout();
      this.SuspendLayout();
      this.treeView.Dock = DockStyle.Fill;
      this.treeView.ImageIndex = 0;
      this.treeView.ImageList = this.images;
      this.treeView.Location = new Point(0, 0);
      this.treeView.Name = "treeView";
      this.treeView.SelectedImageIndex = 0;
      this.treeView.ShowRootLines = false;
      this.treeView.Size = new Size(250, 400);
      this.treeView.TabIndex = 1;
      this.treeView.BeforeCollapse += new TreeViewCancelEventHandler(this.treeView_BeforeCollapse);
      this.treeView.AfterCollapse += new TreeViewEventHandler(this.treeView_AfterCollapse);
      this.treeView.AfterExpand += new TreeViewEventHandler(this.treeView_AfterExpand);
      this.treeView.AfterSelect += new TreeViewEventHandler(this.treeView_AfterSelect);
      this.treeView.DoubleClick += new EventHandler(this.treeView_DoubleClick);
      this.treeView.MouseDown += new MouseEventHandler(this.treeView_MouseDown);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "script_explorer.png");
      this.images.Images.SetKeyName(1, "VSFolder_closed.png");
      this.images.Images.SetKeyName(2, "VSFolder_open.png");
      this.images.Images.SetKeyName(3, "code_cs.png");
      this.images.Images.SetKeyName(4, "code_vb.png");
      this.images.Images.SetKeyName(5, "code_unknown.png");
      this.ctxDirectoryNode.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ctxDirectoryNode_Add,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.ctxDirectoryNode_Rename,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.ctxDirectoryNode_Delete
      });
      this.ctxDirectoryNode.Name = "ctxDirectoryNode";
      this.ctxDirectoryNode.Size = new Size(125, 82);
      this.ctxDirectoryNode.Opening += new CancelEventHandler(this.ctxDirectoryNode_Opening);
      this.ctxDirectoryNode_Add.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ctxDirectoryNode_Add_NewFolder,
        (ToolStripItem) this.ctxDirectoryNode_Add_NewScript
      });
      this.ctxDirectoryNode_Add.Name = "ctxDirectoryNode_Add";
      this.ctxDirectoryNode_Add.Size = new Size(124, 22);
      this.ctxDirectoryNode_Add.Text = "Add";
      this.ctxDirectoryNode_Add_NewFolder.Image = (Image) Resources.folder_new;
      this.ctxDirectoryNode_Add_NewFolder.Name = "ctxDirectoryNode_Add_NewFolder";
      this.ctxDirectoryNode_Add_NewFolder.Size = new Size(134, 22);
      this.ctxDirectoryNode_Add_NewFolder.Text = "New Folder";
      this.ctxDirectoryNode_Add_NewFolder.Click += new EventHandler(this.ctxDirectoryNode_Add_NewFolder_Click);
      this.ctxDirectoryNode_Add_NewScript.Image = (Image) Resources.script_new;
      this.ctxDirectoryNode_Add_NewScript.Name = "ctxDirectoryNode_Add_NewScript";
      this.ctxDirectoryNode_Add_NewScript.Size = new Size(134, 22);
      this.ctxDirectoryNode_Add_NewScript.Text = "New Script";
      this.ctxDirectoryNode_Add_NewScript.Click += new EventHandler(this.ctxDirectoryNode_Add_NewScript_Click);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(121, 6);
      this.ctxDirectoryNode_Rename.Image = (Image) Resources.rename;
      this.ctxDirectoryNode_Rename.Name = "ctxDirectoryNode_Rename";
      this.ctxDirectoryNode_Rename.Size = new Size(124, 22);
      this.ctxDirectoryNode_Rename.Text = "Rename";
      this.ctxDirectoryNode_Rename.Click += new EventHandler(this.ctxDirectoryNode_Rename_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(121, 6);
      this.ctxDirectoryNode_Delete.Image = (Image) Resources.delete;
      this.ctxDirectoryNode_Delete.Name = "ctxDirectoryNode_Delete";
      this.ctxDirectoryNode_Delete.Size = new Size(124, 22);
      this.ctxDirectoryNode_Delete.Text = "Delete";
      this.ctxDirectoryNode_Delete.Click += new EventHandler(this.ctxDirectoryNode_Delete_Click);
      this.ctxFileNode.Items.AddRange(new ToolStripItem[12]
      {
        (ToolStripItem) this.ctxFileNode_Open,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxFileNode_Build,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.ctxFileNode_Run,
        (ToolStripItem) this.ctxFileNode_Stop,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.ctxFileNode_IsStartUp,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxFileNode_Rename,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.ctxFileNode_Delete
      });
      this.ctxFileNode.Name = "ctxDirectoryNode";
      this.ctxFileNode.Size = new Size(153, 210);
      this.ctxFileNode.Opening += new CancelEventHandler(this.ctxFileNode_Opening);
      this.ctxFileNode_Open.Name = "ctxFileNode_Open";
      this.ctxFileNode_Open.Size = new Size(152, 22);
      this.ctxFileNode_Open.Text = "Open";
      this.ctxFileNode_Open.Click += new EventHandler(this.ctxFileNode_Open_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(149, 6);
      this.ctxFileNode_Build.Image = (Image) Resources.script_build;
      this.ctxFileNode_Build.Name = "ctxFileNode_Build";
      this.ctxFileNode_Build.Size = new Size(152, 22);
      this.ctxFileNode_Build.Text = "Build";
      this.ctxFileNode_Build.Click += new EventHandler(this.ctxFileNode_Build_Click);
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new Size(149, 6);
      this.ctxFileNode_Run.Image = (Image) Resources.script_run;
      this.ctxFileNode_Run.Name = "ctxFileNode_Run";
      this.ctxFileNode_Run.Size = new Size(152, 22);
      this.ctxFileNode_Run.Text = "Run";
      this.ctxFileNode_Run.Click += new EventHandler(this.ctxFileNode_Run_Click);
      this.ctxFileNode_Stop.Image = (Image) Resources.script_stop;
      this.ctxFileNode_Stop.Name = "ctxFileNode_Stop";
      this.ctxFileNode_Stop.Size = new Size(152, 22);
      this.ctxFileNode_Stop.Text = "Stop";
      this.ctxFileNode_Stop.Click += new EventHandler(this.ctxFileNode_Stop_Click);
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new Size(149, 6);
      this.ctxFileNode_IsStartUp.CheckOnClick = true;
      this.ctxFileNode_IsStartUp.Name = "ctxFileNode_IsStartUp";
      this.ctxFileNode_IsStartUp.Size = new Size(152, 22);
      this.ctxFileNode_IsStartUp.Text = "Is Startup";
      this.ctxFileNode_IsStartUp.Click += new EventHandler(this.ctxFileNode_IsStartUp_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(149, 6);
      this.ctxFileNode_Rename.Image = (Image) Resources.rename;
      this.ctxFileNode_Rename.Name = "ctxFileNode_Rename";
      this.ctxFileNode_Rename.Size = new Size(152, 22);
      this.ctxFileNode_Rename.Text = "Rename";
      this.ctxFileNode_Rename.Click += new EventHandler(this.ctxFileNode_Rename_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(149, 6);
      this.ctxFileNode_Delete.Image = (Image) Resources.delete;
      this.ctxFileNode_Delete.Name = "ctxFileNode_Delete";
      this.ctxFileNode_Delete.Size = new Size(152, 22);
      this.ctxFileNode_Delete.Text = "Delete";
      this.ctxFileNode_Delete.Click += new EventHandler(this.ctxFileNode_Delete_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.treeView);
      this.DefaultDockLocation = ContainerDockLocation.Right;
      this.Name = "ScriptExplorerWindow";
      this.TabImage = (Image) Resources.script_explorer;
      this.Text = "Script Explorer";
      this.ctxDirectoryNode.ResumeLayout(false);
      this.ctxFileNode.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnInit()
    {
      this.InitializeTree();
      this.AttachWatcher();
      base.OnInit();
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      this.DetachWatcher();
      base.OnClosing(e);
    }

    private void AttachWatcher()
    {
      this.watcher = new FileSystemWatcher(Global.ScriptManager.ScriptsDirectory.FullName);
      this.watcher.Deleted += new FileSystemEventHandler(this.watcher_Deleted);
      this.watcher.Renamed += new RenamedEventHandler(this.watcher_Renamed);
      this.watcher.Created += new FileSystemEventHandler(this.watcher_Created);
      this.watcher.IncludeSubdirectories = true;
      this.watcher.EnableRaisingEvents = true;
    }

    private void DetachWatcher()
    {
      this.watcher.EnableRaisingEvents = false;
      this.watcher.Deleted -= new FileSystemEventHandler(this.watcher_Deleted);
      this.watcher.Renamed -= new RenamedEventHandler(this.watcher_Renamed);
      this.watcher.Created -= new FileSystemEventHandler(this.watcher_Created);
    }

    private void InitializeTree()
    {
      DirectoryInfo scriptsDirectory = Global.ScriptManager.ScriptsDirectory;
      ScriptRootNode scriptRootNode = new ScriptRootNode(scriptsDirectory);
      scriptRootNode.ContextMenuStrip = this.ctxDirectoryNode;
      scriptRootNode.Expand();
      this.treeView.Nodes.Add((TreeNode) scriptRootNode);
      this.MapDirectory(scriptsDirectory, (TreeNode) scriptRootNode);
    }

    private void MapDirectory(DirectoryInfo directory, TreeNode node)
    {
      foreach (FileSystemInfo fileSystemInfo in directory.GetFileSystemInfos())
      {
        if (fileSystemInfo is DirectoryInfo)
        {
          DirectoryInfo directory1 = (DirectoryInfo) fileSystemInfo;
          ScriptDirectoryNode scriptDirectoryNode = new ScriptDirectoryNode(directory1.Name);
          scriptDirectoryNode.ContextMenuStrip = this.ctxDirectoryNode;
          node.Nodes.Add((TreeNode) scriptDirectoryNode);
          this.MapDirectory(directory1, (TreeNode) scriptDirectoryNode);
        }
        if (fileSystemInfo is FileInfo)
        {
          FileInfo fileInfo = (FileInfo) fileSystemInfo;
          if (fileInfo.Extension != ".settings")
          {
            ScriptFileNode scriptFileNode = new ScriptFileNode(fileInfo.Name);
            scriptFileNode.File = fileSystemInfo as FileInfo;
            scriptFileNode.ContextMenuStrip = this.ctxFileNode;
            node.Nodes.Add((TreeNode) scriptFileNode);
          }
        }
      }
    }

    private FileSystemEntryNode FindEntryNode(string[] items)
    {
      FileSystemEntryNode fileSystemEntryNode = (FileSystemEntryNode) this.treeView.Nodes[0];
      foreach (string index in items)
      {
        fileSystemEntryNode = (FileSystemEntryNode) fileSystemEntryNode.Nodes[index];
        if (fileSystemEntryNode == null)
          break;
      }
      return fileSystemEntryNode;
    }

    private FileSystemEntryNode FindEntryNode(string name)
    {
      return this.FindEntryNode(this.SplitName(name));
    }

    private string[] SplitName(string name)
    {
      return name.Split(new string[1]
      {
        this.treeView.PathSeparator
      }, StringSplitOptions.RemoveEmptyEntries);
    }

    private ScriptFileNode[] GetFileSubNodes(ScriptDirectoryNode directoryNode)
    {
      List<ScriptFileNode> list = new List<ScriptFileNode>();
      foreach (FileSystemEntryNode fileSystemEntryNode in directoryNode.Nodes)
      {
        if (fileSystemEntryNode is ScriptDirectoryNode)
          list.AddRange((IEnumerable<ScriptFileNode>) this.GetFileSubNodes((ScriptDirectoryNode) fileSystemEntryNode));
        if (fileSystemEntryNode is ScriptFileNode)
          list.Add((ScriptFileNode) fileSystemEntryNode);
      }
      return list.ToArray();
    }

    private void watcher_Created(object sender, FileSystemEventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new FileSystemEventHandler(this.watcher_Created), sender, (object) e);
      }
      else
      {
        List<string> list = new List<string>((IEnumerable<string>) this.SplitName(e.Name));
        string name = Enumerable.Last<string>((IEnumerable<string>) list);
        list.RemoveAt(list.Count - 1);
        FileSystemEntryNode entryNode = this.FindEntryNode(list.ToArray());
        if (entryNode == null)
          return;
        FileSystemEntryNode fileSystemEntryNode = (FileSystemEntryNode) null;
        if (Directory.Exists(e.FullPath))
        {
          fileSystemEntryNode = (FileSystemEntryNode) new ScriptDirectoryNode(name);
          fileSystemEntryNode.ContextMenuStrip = this.ctxDirectoryNode;
        }
        if (File.Exists(e.FullPath) && !e.FullPath.ToLower().EndsWith(".settings"))
        {
          fileSystemEntryNode = (FileSystemEntryNode) new ScriptFileNode(name);
          (fileSystemEntryNode as ScriptFileNode).File = new FileInfo(e.FullPath);
          fileSystemEntryNode.ContextMenuStrip = this.ctxFileNode;
        }
        if (fileSystemEntryNode == null)
          return;
        entryNode.Nodes.Add((TreeNode) fileSystemEntryNode);
      }
    }

    private void watcher_Renamed(object sender, RenamedEventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new RenamedEventHandler(this.watcher_Renamed), sender, (object) e);
      }
      else
      {
        FileSystemEntryNode entryNode = this.FindEntryNode(e.OldName);
        if (entryNode == null)
          return;
        ScriptFileNode[] scriptFileNodeArray = (ScriptFileNode[]) null;
        if (entryNode is ScriptDirectoryNode)
          scriptFileNodeArray = this.GetFileSubNodes((ScriptDirectoryNode) entryNode);
        if (entryNode is ScriptFileNode)
          scriptFileNodeArray = new ScriptFileNode[1]
          {
            (ScriptFileNode) entryNode
          };
        foreach (TreeNode node in scriptFileNodeArray)
          Global.EditorManager.Close(this.GetFullPath(node));
        List<string> list = new List<string>((IEnumerable<string>) this.SplitName(e.Name));
        entryNode.RenameTo(Enumerable.Last<string>((IEnumerable<string>) list));
        this.treeView.Sort();
      }
    }

    private void watcher_Deleted(object sender, FileSystemEventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new FileSystemEventHandler(this.watcher_Deleted), sender, (object) e);
      }
      else
      {
        Global.EditorManager.Close(e.FullPath);
        FileSystemEntryNode entryNode = this.FindEntryNode(e.Name);
        if (entryNode == null)
          return;
        entryNode.Remove();
      }
    }

    private void ctxFileNode_Opening(object sender, CancelEventArgs e)
    {
      FileInfo file = new FileInfo(this.GetFullPath(this.treeView.SelectedNode));
      bool flag1 = false;
      switch (CodeHelper.GetCodeLang(file))
      {
        case CodeLang.None:
          this.ctxFileNode_Open.Image = (Image) Resources.code_unknown;
          flag1 = false;
          break;
        case CodeLang.CSharp:
          this.ctxFileNode_Open.Image = (Image) Resources.code_cs;
          flag1 = true;
          break;
        case CodeLang.VisualBasic:
          this.ctxFileNode_Open.Image = (Image) Resources.code_vb;
          flag1 = true;
          break;
      }
      if (flag1)
      {
        bool flag2 = Global.ScriptManager.IsScriptRunning(file);
        this.ctxFileNode_Open.Enabled = true;
        this.ctxFileNode_IsStartUp.Enabled = true;
        this.ctxFileNode_IsStartUp.Checked = Global.ScriptManager.IsStartupScript(file);
        this.ctxFileNode_Build.Enabled = !flag2;
        this.ctxFileNode_Run.Enabled = !flag2;
        this.ctxFileNode_Build.Enabled = !flag2;
        this.ctxFileNode_Stop.Enabled = flag2;
        this.ctxFileNode_Rename.Enabled = !flag2;
        this.ctxFileNode_Delete.Enabled = !flag2;
      }
      else
      {
        this.ctxFileNode_Open.Enabled = false;
        this.ctxFileNode_IsStartUp.Enabled = false;
        this.ctxFileNode_Build.Enabled = false;
        this.ctxFileNode_Run.Enabled = false;
        this.ctxFileNode_Build.Enabled = false;
        this.ctxFileNode_Stop.Enabled = false;
        this.ctxFileNode_Rename.Enabled = true;
        this.ctxFileNode_Delete.Enabled = true;
      }
    }

    private void ctxFileNode_Open_Click(object sender, EventArgs e)
    {
      this.OpenEditor(new FileInfo(this.GetFullPath(this.treeView.SelectedNode)));
    }

    private void ctxFileNode_Build_Click(object sender, EventArgs e)
    {
      Global.ScriptManager.Build(new FileInfo(this.GetFullPath(this.treeView.SelectedNode)), this.BuildOptions);
    }

    private void ctxFileNode_Run_Click(object sender, EventArgs e)
    {
      Global.ScriptManager.Run(new FileInfo(this.GetFullPath(this.treeView.SelectedNode)), this.BuildOptions, this.ScriptsOptions);
    }

    private void ctxFileNode_Stop_Click(object sender, EventArgs e)
    {
      Global.ScriptManager.Stop(new FileInfo(this.GetFullPath(this.treeView.SelectedNode)));
    }

    private void ctxFileNode_IsStartUp_Click(object sender, EventArgs e)
    {
      FileInfo file = new FileInfo(this.GetFullPath(this.treeView.SelectedNode));
      if (this.ctxFileNode_IsStartUp.Checked)
        Global.ScriptManager.AddStartupScript(file);
      else
        Global.ScriptManager.RemoveStartupScript(file);
    }

    private void ctxFileNode_Rename_Click(object sender, EventArgs e)
    {
      FileInfo fileInfo = new FileInfo(this.GetFullPath(this.treeView.SelectedNode));
      RenameFileSystemEntryForm fileSystemEntryForm = new RenameFileSystemEntryForm();
      fileSystemEntryForm.Init(fileInfo.Name);
      if (fileSystemEntryForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        try
        {
          fileInfo.MoveTo(string.Format("{0}\\{1}", (object) fileInfo.Directory.FullName, (object) fileSystemEntryForm.EntryName));
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, ex.Message);
        }
      }
      fileSystemEntryForm.Dispose();
    }

    private void ctxFileNode_Delete_Click(object sender, EventArgs e)
    {
      FileInfo fileInfo = new FileInfo(this.GetFullPath(this.treeView.SelectedNode));
      if (MessageBox.Show((IWin32Window) this, "Are you sure to delete file " + fileInfo.Name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        fileInfo.Delete();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message);
      }
    }

    private void ctxDirectoryNode_Opening(object sender, CancelEventArgs e)
    {
      if (this.treeView.SelectedNode is ScriptRootNode)
      {
        this.ctxDirectoryNode_Rename.Enabled = false;
        this.ctxDirectoryNode_Delete.Enabled = false;
      }
      else
      {
        this.ctxDirectoryNode_Rename.Enabled = true;
        this.ctxDirectoryNode_Delete.Enabled = true;
      }
    }

    private void ctxDirectoryNode_Add_NewFolder_Click(object sender, EventArgs e)
    {
      DirectoryInfo directory = new DirectoryInfo(this.GetFullPath(this.treeView.SelectedNode));
      NewDirectoryDialog newDirectoryDialog = new NewDirectoryDialog(directory);
      newDirectoryDialog.Text = "Create New Folder";
      if (newDirectoryDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        try
        {
          directory.CreateSubdirectory(newDirectoryDialog.FolderName);
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, ex.Message);
        }
      }
      newDirectoryDialog.Dispose();
    }

    private void ctxDirectoryNode_Add_NewScript_Click(object sender, EventArgs e)
    {
      DirectoryInfo directory = new DirectoryInfo(this.GetFullPath(this.treeView.SelectedNode));
      NewScriptDialog newScriptDialog = new NewScriptDialog(directory);
      newScriptDialog.Text = "Create New Script";
      if (newScriptDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        try
        {
          string fileExtension = CodeHelper.GetFileExtension(newScriptDialog.CodeLang);
          string path = string.Format("{0}\\{1}{2}", (object) directory.FullName, (object) newScriptDialog.ScriptName, (object) fileExtension);
          if (File.Exists(path))
          {
            int num = (int) MessageBox.Show((IWin32Window) this, "File already exists.");
          }
          else
          {
            string scriptCodeTemplate = this.GetScriptCodeTemplate(newScriptDialog.CodeLang);
            File.WriteAllText(path, scriptCodeTemplate);
          }
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, ex.Message);
        }
      }
      newScriptDialog.Dispose();
    }

    private void ctxDirectoryNode_Rename_Click(object sender, EventArgs e)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(this.GetFullPath(this.treeView.SelectedNode));
      RenameFileSystemEntryForm fileSystemEntryForm = new RenameFileSystemEntryForm();
      fileSystemEntryForm.Init(directoryInfo.Name);
      if (fileSystemEntryForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        try
        {
          directoryInfo.MoveTo(string.Format("{0}\\{1}", (object) directoryInfo.Parent.FullName, (object) fileSystemEntryForm.EntryName));
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, ex.Message);
        }
      }
      fileSystemEntryForm.Dispose();
    }

    private void ctxDirectoryNode_Delete_Click(object sender, EventArgs e)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(this.GetFullPath(this.treeView.SelectedNode));
      if (MessageBox.Show((IWin32Window) this, "Are you sure to delete directory " + directoryInfo.Name + " and its content?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        directoryInfo.Delete(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message);
      }
    }

    private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
    {
      if (!(e.Node is ScriptDirectoryNode))
        return;
      ((ScriptDirectoryNode) e.Node).UpdateImage();
    }

    private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
    {
      if (!(e.Node is ScriptRootNode))
        return;
      e.Cancel = true;
    }

    private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      if (!(e.Node is ScriptDirectoryNode))
        return;
      ((ScriptDirectoryNode) e.Node).UpdateImage();
    }

    private void treeView_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      this.treeView.SelectedNode = this.treeView.GetNodeAt(e.X, e.Y);
    }

    private void treeView_DoubleClick(object sender, EventArgs e)
    {
      if (!(this.treeView.SelectedNode is ScriptFileNode))
        return;
      FileInfo file = new FileInfo(this.GetFullPath(this.treeView.SelectedNode));
      switch (CodeHelper.GetCodeLang(file))
      {
        case CodeLang.CSharp:
        case CodeLang.VisualBasic:
          this.OpenEditor(file);
          break;
      }
    }

    private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!(this.treeView.SelectedNode is ScriptFileNode))
        return;
      this.PropertyObject = (object) new ScriptSettingsTypeDescriptor(Global.ScriptManager.GetScriptSettings((this.treeView.SelectedNode as ScriptFileNode).File, this.BuildOptions));
      Global.ToolWindowManager.ShowProperties((IPropertyEditable) this, false);
    }

    protected virtual void OpenEditor(FileInfo file)
    {
      Global.EditorManager.Open(typeof (ScriptEditorWindow), (EditorKey) new ScriptEditorKey(file));
    }

    protected virtual string GetScriptCodeTemplate(CodeLang codeLang)
    {
      return string.Empty;
    }

    private string GetFullPath(TreeNode node)
    {
      List<string> list = new List<string>();
      for (; !(node is ScriptRootNode); node = node.Parent)
        list.Insert(0, node.Text);
      list.Insert(0, Global.ScriptManager.ScriptsDirectory.FullName);
      return string.Join("\\", list.ToArray());
    }
  }
}
