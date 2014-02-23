using FreeQuant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  internal class BrowseGACForm : Form
  {
    private IContainer components;
    private Panel panel1;
    private ListView ltvAssemblies;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ImageList imgAssemblies;
    private Button btnCancel;
    private Button btnOk;
    private ColumnHeader columnHeader3;

    public AssemblyName[] SelectedAssemblies
    {
      get
      {
        List<AssemblyName> list = new List<AssemblyName>();
        foreach (AssemblyNameViewItem assemblyNameViewItem in this.ltvAssemblies.SelectedItems)
          list.Add(assemblyNameViewItem.Assembly);
        return list.ToArray();
      }
    }

    public BrowseGACForm()
    {
      this.InitializeComponent();
    }

    protected override void OnShown(EventArgs e)
    {
      this.ltvAssemblies.BeginUpdate();
      this.ltvAssemblies.Items.Clear();
      foreach (AssemblyName assembly in GAC.Assemblies)
        this.ltvAssemblies.Items.Add((ListViewItem) new AssemblyNameViewItem(assembly));
      this.ltvAssemblies.ListViewItemSorter = (IComparer) new AssemblyNameViewItemSorter();
      this.ltvAssemblies.EndUpdate();
      this.UpdateOkButtonStatus();
      base.OnShown(e);
    }

    private void ltvAssemblies_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateOkButtonStatus();
    }

    private void ltvAssemblies_DoubleClick(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void UpdateOkButtonStatus()
    {
      this.btnOk.Enabled = this.ltvAssemblies.SelectedItems.Count > 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseGACForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.ltvAssemblies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgAssemblies = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(243, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(170, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // ltvAssemblies
            // 
            this.ltvAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ltvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvAssemblies.FullRowSelect = true;
            this.ltvAssemblies.GridLines = true;
            this.ltvAssemblies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltvAssemblies.HideSelection = false;
            this.ltvAssemblies.Location = new System.Drawing.Point(0, 0);
            this.ltvAssemblies.Name = "ltvAssemblies";
            this.ltvAssemblies.ShowGroups = false;
            this.ltvAssemblies.ShowItemToolTips = true;
            this.ltvAssemblies.Size = new System.Drawing.Size(453, 329);
            this.ltvAssemblies.SmallImageList = this.imgAssemblies;
            this.ltvAssemblies.TabIndex = 1;
            this.ltvAssemblies.UseCompatibleStateImageBehavior = false;
            this.ltvAssemblies.View = System.Windows.Forms.View.Details;
            this.ltvAssemblies.SelectedIndexChanged += new System.EventHandler(this.ltvAssemblies_SelectedIndexChanged);
            this.ltvAssemblies.DoubleClick += new System.EventHandler(this.ltvAssemblies_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Platform";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 96;
            // 
            // imgAssemblies
            // 
            this.imgAssemblies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAssemblies.ImageStream")));
            this.imgAssemblies.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAssemblies.Images.SetKeyName(0, "reference.png");
            // 
            // BrowseGACForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(453, 377);
            this.Controls.Add(this.ltvAssemblies);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowseGACForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Assembly Cache";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
  }
}
