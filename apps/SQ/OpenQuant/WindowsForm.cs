// Type: OpenQuant.WindowsForm
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Properties;
using OpenQuant.Shared;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant
{
  internal class WindowsForm : Form
  {
    private IContainer components;
    private Panel panel1;
    private Button btnOk;
    private Button btnCloseWindows;
    private Button btnActivate;
    private Panel panel2;
    private Panel panel3;
    private Panel panel4;
    private ImageList images;
    private ListView ltvWindows;
    private ColumnHeader columnHeader1;

    public WindowsForm()
    {
      this.InitializeComponent();
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
      this.panel1 = new Panel();
      this.btnOk = new Button();
      this.btnCloseWindows = new Button();
      this.panel2 = new Panel();
      this.btnActivate = new Button();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.images = new ImageList(this.components);
      this.ltvWindows = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.btnOk);
      this.panel1.Controls.Add((Control) this.btnCloseWindows);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.btnActivate);
      this.panel1.Dock = DockStyle.Right;
      this.panel1.Location = new Point(337, 8);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(118, 273);
      this.panel1.TabIndex = 0;
      this.btnOk.DialogResult = DialogResult.Cancel;
      this.btnOk.Dock = DockStyle.Bottom;
      this.btnOk.Location = new Point(0, 251);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(118, 22);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnCloseWindows.Dock = DockStyle.Top;
      this.btnCloseWindows.Location = new Point(0, 30);
      this.btnCloseWindows.Name = "btnCloseWindows";
      this.btnCloseWindows.Size = new Size(118, 22);
      this.btnCloseWindows.TabIndex = 1;
      this.btnCloseWindows.Text = "Close Window(s)";
      this.btnCloseWindows.UseVisualStyleBackColor = true;
      this.btnCloseWindows.Click += new EventHandler(this.btnCloseWindows_Click);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(0, 22);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(118, 8);
      this.panel2.TabIndex = 3;
      this.btnActivate.Dock = DockStyle.Top;
      this.btnActivate.Location = new Point(0, 0);
      this.btnActivate.Name = "btnActivate";
      this.btnActivate.Size = new Size(118, 22);
      this.btnActivate.TabIndex = 0;
      this.btnActivate.Text = "Activate";
      this.btnActivate.UseVisualStyleBackColor = true;
      this.btnActivate.Click += new EventHandler(this.btnActivate_Click);
      this.panel3.Dock = DockStyle.Right;
      this.panel3.Location = new Point(329, 8);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(8, 273);
      this.panel3.TabIndex = 1;
      this.panel4.Dock = DockStyle.Bottom;
      this.panel4.Location = new Point(8, 257);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(321, 24);
      this.panel4.TabIndex = 2;
      this.images.ColorDepth = ColorDepth.Depth32Bit;
      this.images.ImageSize = new Size(16, 16);
      this.images.TransparentColor = Color.Transparent;
      this.ltvWindows.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader1
      });
      this.ltvWindows.Dock = DockStyle.Fill;
      this.ltvWindows.FullRowSelect = true;
      this.ltvWindows.HideSelection = false;
      this.ltvWindows.Location = new Point(8, 8);
      this.ltvWindows.Name = "ltvWindows";
      this.ltvWindows.ShowGroups = false;
      this.ltvWindows.ShowItemToolTips = true;
      this.ltvWindows.Size = new Size(321, 249);
      this.ltvWindows.SmallImageList = this.images;
      this.ltvWindows.TabIndex = 3;
      this.ltvWindows.UseCompatibleStateImageBehavior = false;
      this.ltvWindows.View = View.Details;
      this.ltvWindows.DoubleClick += new EventHandler(this.ltvWindows_DoubleClick);
      this.ltvWindows.SelectedIndexChanged += new EventHandler(this.ltvWindows_SelectedIndexChanged);
      this.columnHeader1.Text = "Title";
      this.columnHeader1.Width = 288;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnOk;
      this.ClientSize = new Size(463, 297);
      this.Controls.Add((Control) this.ltvWindows);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new Size(200, 200);
      this.Name = "WindowsForm";
      this.Padding = new Padding(8, 8, 8, 16);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Windows";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnShown(EventArgs e)
    {
      this.Init();
      base.OnShown(e);
    }

    protected override void OnResize(EventArgs e)
    {
      this.ltvWindows.Columns[0].Width = this.ltvWindows.Width - 20;
      base.OnResize(e);
    }

    private void ltvWindows_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateButtonsStatus();
    }

    private void ltvWindows_DoubleClick(object sender, EventArgs e)
    {
      this.ActivateWindow();
    }

    private void btnActivate_Click(object sender, EventArgs e)
    {
      this.ActivateWindow();
    }

    private void btnCloseWindows_Click(object sender, EventArgs e)
    {
      foreach (WindowViewItem windowViewItem in this.ltvWindows.SelectedItems)
        windowViewItem.Control.Close();
      this.Init();
    }

    private void ActivateWindow()
    {
      (this.ltvWindows.SelectedItems[0] as WindowViewItem).Control.Open();
      this.Close();
    }

    private void Init()
    {
      DockControl[] documents = ((SandDockManager) Global.get_DockManager()).get_Documents();
      this.ltvWindows.BeginUpdate();
      this.ltvWindows.Items.Clear();
      this.images.Images.Clear();
      for (int imageIndex = 0; imageIndex < documents.Length; ++imageIndex)
      {
        DockControl control = documents[imageIndex];
        if (control.get_TabImage() == null)
          this.images.Images.Add((Image) Resources.empty);
        else
          this.images.Images.Add(control.get_TabImage());
        this.ltvWindows.Items.Add((ListViewItem) new WindowViewItem(control, imageIndex));
      }
      this.ltvWindows.EndUpdate();
      this.UpdateButtonsStatus();
    }

    private void UpdateButtonsStatus()
    {
      switch (this.ltvWindows.SelectedItems.Count)
      {
        case 0:
          this.btnActivate.Enabled = false;
          this.btnCloseWindows.Enabled = false;
          break;
        case 1:
          this.btnActivate.Enabled = true;
          this.btnCloseWindows.Enabled = true;
          break;
        default:
          this.btnActivate.Enabled = false;
          this.btnCloseWindows.Enabled = true;
          break;
      }
    }
  }
}
