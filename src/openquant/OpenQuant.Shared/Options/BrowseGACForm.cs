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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BrowseGACForm));
      this.panel1 = new Panel();
      this.btnCancel = new Button();
      this.btnOk = new Button();
      this.ltvAssemblies = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.imgAssemblies = new ImageList(this.components);
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.btnCancel);
      this.panel1.Controls.Add((Control) this.btnOk);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 329);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(453, 48);
      this.panel1.TabIndex = 0;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(243, 14);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(60, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(170, 14);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(60, 23);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.ltvAssemblies.Columns.AddRange(new ColumnHeader[3]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3
      });
      this.ltvAssemblies.Dock = DockStyle.Fill;
      this.ltvAssemblies.FullRowSelect = true;
      this.ltvAssemblies.GridLines = true;
      this.ltvAssemblies.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvAssemblies.HideSelection = false;
      this.ltvAssemblies.Location = new Point(0, 0);
      this.ltvAssemblies.Name = "ltvAssemblies";
      this.ltvAssemblies.ShowGroups = false;
      this.ltvAssemblies.ShowItemToolTips = true;
      this.ltvAssemblies.Size = new Size(453, 329);
      this.ltvAssemblies.SmallImageList = this.imgAssemblies;
      this.ltvAssemblies.TabIndex = 1;
      this.ltvAssemblies.UseCompatibleStateImageBehavior = false;
      this.ltvAssemblies.View = View.Details;
      this.ltvAssemblies.SelectedIndexChanged += new EventHandler(this.ltvAssemblies_SelectedIndexChanged);
      this.ltvAssemblies.DoubleClick += new EventHandler(this.ltvAssemblies_DoubleClick);
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 207;
      this.columnHeader2.Text = "Version";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 98;
      this.columnHeader3.Text = "Platform";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 96;
      this.imgAssemblies.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgAssemblies.ImageStream");
      this.imgAssemblies.TransparentColor = Color.Transparent;
      this.imgAssemblies.Images.SetKeyName(0, "reference.png");
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(453, 377);
      this.Controls.Add((Control) this.ltvAssemblies);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "BrowseGACForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Global Assembly Cache";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
