using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.ToolWindows
{
  public class ErrorListWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private IContainer components;
    private ToolStrip toolStrip1;
    private ToolStripButton tsbErrors;
    private ToolStripButton tsbWarnings;
    protected ListView ltvErrors;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ImageList images;
    private ToolStripSeparator toolStripSeparator1;

    public ErrorListWindow()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ErrorListWindow));
      this.toolStrip1 = new ToolStrip();
      this.tsbErrors = new ToolStripButton();
      this.tsbWarnings = new ToolStripButton();
      this.ltvErrors = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.images = new ImageList(this.components);
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.toolStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.tsbErrors,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.tsbWarnings
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(661, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      this.tsbErrors.Checked = true;
      this.tsbErrors.CheckOnClick = true;
      this.tsbErrors.CheckState = CheckState.Checked;
      this.tsbErrors.Image = (Image) Resources.error;
      this.tsbErrors.ImageTransparentColor = Color.Magenta;
      this.tsbErrors.Name = "tsbErrors";
      this.tsbErrors.Size = new Size(57, 22);
      this.tsbErrors.Text = "Errors";
      this.tsbWarnings.Checked = true;
      this.tsbWarnings.CheckOnClick = true;
      this.tsbWarnings.CheckState = CheckState.Checked;
      this.tsbWarnings.Image = (Image) Resources.warning;
      this.tsbWarnings.ImageTransparentColor = Color.Magenta;
      this.tsbWarnings.Name = "tsbWarnings";
      this.tsbWarnings.Size = new Size(77, 22);
      this.tsbWarnings.Text = "Warnings";
      this.ltvErrors.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvErrors.Dock = DockStyle.Fill;
      this.ltvErrors.FullRowSelect = true;
      this.ltvErrors.GridLines = true;
      this.ltvErrors.HideSelection = false;
      this.ltvErrors.Location = new Point(0, 25);
      this.ltvErrors.Name = "ltvErrors";
      this.ltvErrors.ShowItemToolTips = true;
      this.ltvErrors.Size = new Size(661, 149);
      this.ltvErrors.SmallImageList = this.images;
      this.ltvErrors.TabIndex = 1;
      this.ltvErrors.UseCompatibleStateImageBehavior = false;
      this.ltvErrors.View = View.Details;
      this.columnHeader1.Text = "";
      this.columnHeader1.Width = 32;
      this.columnHeader2.Text = "Line";
      this.columnHeader2.Width = 50;
      this.columnHeader3.Text = "Column";
      this.columnHeader3.Width = 56;
      this.columnHeader4.Text = "Description";
      this.columnHeader4.Width = 444;
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "error.png");
      this.images.Images.SetKeyName(1, "warning.png");
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.ltvErrors);
      this.Controls.Add((Control) this.toolStrip1);
      this.DefaultDockLocation = ContainerDockLocation.Bottom;
      this.Name = "ErrorListWindow";
      this.PersistState = false;
      this.Size = new Size(661, 174);
      this.TabImage = (Image) Resources.error_list;
      this.Text = "Error List";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void SetErrors(Error[] errors)
    {
      this.ltvErrors.BeginUpdate();
      this.ltvErrors.Items.Clear();
      foreach (Error error in errors)
        this.ltvErrors.Items.Add((ListViewItem) new ErrorViewItem(error));
      this.ltvErrors.EndUpdate();
    }

    public void ClearErrors()
    {
      this.ltvErrors.Items.Clear();
    }

    public Error GetSelectedError()
    {
      if (this.ltvErrors.SelectedItems.Count > 0)
        return ((ErrorViewItem) this.ltvErrors.SelectedItems[0]).Error;
      else
        return (Error) null;
    }
  }
}
