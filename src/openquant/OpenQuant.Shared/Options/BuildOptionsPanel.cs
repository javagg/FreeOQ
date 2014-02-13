using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  internal class BuildOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private GroupBox groupBox1;
    private ListView ltvReferences;
    private ColumnHeader columnHeader1;
    private ImageList images;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private Button btnAdd;
    private Button btnRemove;
    private ContextMenuStrip ctxAddReference;
    private ToolStripMenuItem ctxAddReference_DotNET;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxAddReference_User;
    private OpenFileDialog dlgBrowseUserDll;

    public BuildOptionsPanel()
    {
      this.InitializeComponent();
    }

    protected override void OnInit()
    {
      foreach (BuildReference reference in (List<BuildReference>) ((BuildOptions) this.Options).References)
        this.AddReference(reference, false);
      this.dlgBrowseUserDll.InitialDirectory = ((BuildOptions) this.Options).BinDirectory.FullName;
    }

    protected override void OnCommitChanges()
    {
      BuildOptions buildOptions = (BuildOptions) this.Options;
      buildOptions.References.Clear();
      foreach (BuildReferenceViewItem referenceViewItem in this.ltvReferences.Items)
        buildOptions.References.Add(referenceViewItem.Reference);
      this.Options.Save();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      this.ctxAddReference.Show((Control) this.btnAdd, this.btnAdd.Width / 2, this.btnAdd.Height);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (this.ltvReferences.SelectedItems.Count == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "No references selected.", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (MessageBox.Show((IWin32Window) this, "Are you sure to remove selected references?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        BuildReferenceViewItem[] referenceViewItemArray = new BuildReferenceViewItem[this.ltvReferences.SelectedItems.Count];
        this.ltvReferences.SelectedItems.CopyTo((Array) referenceViewItemArray, 0);
        foreach (BuildReferenceViewItem referenceViewItem in referenceViewItemArray)
        {
          if (referenceViewItem.Reference.Type == BuildReferenceType.API)
          {
            int num2 = (int) MessageBox.Show((IWin32Window) this, "You cannot remove reference to the OpenQuant.API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
            this.ltvReferences.Items.Remove((ListViewItem) referenceViewItem);
        }
        this.OptionsChanged = true;
      }
    }

    private void ctxAddReference_DotNET_Click(object sender, EventArgs e)
    {
      BrowseGACForm browseGacForm = new BrowseGACForm();
      if (browseGacForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        foreach (AssemblyName assemblyName in browseGacForm.SelectedAssemblies)
          this.AddReference((BuildReference) new GACBuildReference(assemblyName.Name, assemblyName.Version), true);
        this.OptionsChanged = true;
      }
      browseGacForm.Dispose();
    }

    private void ctxAddReference_User_Click(object sender, EventArgs e)
    {
      int num1 = (int) MessageBox.Show((IWin32Window) this, string.Format("Warning! You should copy assembly to {0} bin folder:{1}{2}{1}and load the dll from this folder.", (object) Global.Setup.Product.Name, (object) Environment.NewLine, (object) ((BuildOptions) this.Options).BinDirectory.FullName), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      if (this.dlgBrowseUserDll.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      BuildReference reference = (BuildReference) new UserBuildReference(this.dlgBrowseUserDll.FileName);
      if (reference.Valid)
      {
        this.AddReference(reference, true);
        this.OptionsChanged = true;
      }
      else
      {
        int num2 = (int) MessageBox.Show((IWin32Window) this, "The given file is not a valid .NET assembly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dlgBrowseUserDll_FileOk(object sender, CancelEventArgs e)
    {
      if (!this.dlgBrowseUserDll.SafeFileName.StartsWith("SmartQuant.", true, CultureInfo.InvariantCulture))
        return;
      int num = (int) MessageBox.Show((IWin32Window) this, "You cannot add this assembly.", this.dlgBrowseUserDll.SafeFileName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      e.Cancel = true;
    }

    private void AddReference(BuildReference reference, bool checkDuplicate)
    {
      bool flag = true;
      if (checkDuplicate)
      {
        foreach (BuildReferenceViewItem referenceViewItem in this.ltvReferences.Items)
        {
          if (reference.Valid && referenceViewItem.Reference.Valid && string.Compare(referenceViewItem.Reference.Path, reference.Path, true) == 0)
          {
            flag = false;
            break;
          }
        }
      }
      if (!flag)
        return;
      this.ltvReferences.Items.Add((ListViewItem) new BuildReferenceViewItem(reference));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BuildOptionsPanel));
      this.groupBox1 = new GroupBox();
      this.ltvReferences = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.images = new ImageList(this.components);
      this.btnAdd = new Button();
      this.btnRemove = new Button();
      this.ctxAddReference = new ContextMenuStrip(this.components);
      this.ctxAddReference_DotNET = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxAddReference_User = new ToolStripMenuItem();
      this.dlgBrowseUserDll = new OpenFileDialog();
      this.groupBox1.SuspendLayout();
      this.ctxAddReference.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.ltvReferences);
      this.groupBox1.Location = new Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(8, 4, 8, 8);
      this.groupBox1.Size = new Size(384, 193);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "References";
      this.ltvReferences.BorderStyle = BorderStyle.None;
      this.ltvReferences.Columns.AddRange(new ColumnHeader[3]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3
      });
      this.ltvReferences.Dock = DockStyle.Fill;
      this.ltvReferences.FullRowSelect = true;
      this.ltvReferences.GridLines = true;
      this.ltvReferences.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvReferences.HideSelection = false;
      this.ltvReferences.Location = new Point(8, 17);
      this.ltvReferences.Name = "ltvReferences";
      this.ltvReferences.ShowGroups = false;
      this.ltvReferences.ShowItemToolTips = true;
      this.ltvReferences.Size = new Size(368, 168);
      this.ltvReferences.SmallImageList = this.images;
      this.ltvReferences.Sorting = SortOrder.Ascending;
      this.ltvReferences.TabIndex = 0;
      this.ltvReferences.UseCompatibleStateImageBehavior = false;
      this.ltvReferences.View = View.Details;
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 159;
      this.columnHeader2.Text = "Version";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 77;
      this.columnHeader3.Text = "Path";
      this.columnHeader3.Width = 123;
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "VSProject_reference.png");
      this.images.Images.SetKeyName(1, "VSProject_brokenreference.png");
      this.btnAdd.Location = new Point(24, 210);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(64, 22);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.btnRemove.Location = new Point(96, 210);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new Size(64, 22);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
      this.ctxAddReference.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ctxAddReference_DotNET,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxAddReference_User
      });
      this.ctxAddReference.Name = "ctxAddReference";
      this.ctxAddReference.Size = new Size(153, 76);
      this.ctxAddReference_DotNET.Name = "ctxAddReference_DotNET";
      this.ctxAddReference_DotNET.Size = new Size(152, 22);
      this.ctxAddReference_DotNET.Text = ".NET...";
      this.ctxAddReference_DotNET.Click += new EventHandler(this.ctxAddReference_DotNET_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(149, 6);
      this.ctxAddReference_User.Name = "ctxAddReference_User";
      this.ctxAddReference_User.Size = new Size(152, 22);
      this.ctxAddReference_User.Text = "Browse...";
      this.ctxAddReference_User.Click += new EventHandler(this.ctxAddReference_User_Click);
      this.dlgBrowseUserDll.DefaultExt = "dll";
      this.dlgBrowseUserDll.Filter = "Assemblies|*.dll";
      this.dlgBrowseUserDll.Title = "Select assembly to add";
      this.dlgBrowseUserDll.FileOk += new CancelEventHandler(this.dlgBrowseUserDll_FileOk);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.btnRemove);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "BuildOptionsPanel";
      this.groupBox1.ResumeLayout(false);
      this.ctxAddReference.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
