using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Properties;
using OpenQuant.Shared.ToolWindows;
//using FreeQuant.Docking.WinForms;
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
    public partial class ScriptExplorerWindow : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable
  {
 
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
