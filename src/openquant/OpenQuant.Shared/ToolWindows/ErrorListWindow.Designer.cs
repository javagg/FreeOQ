namespace OpenQuant.Shared.ToolWindows
{
    public partial class ErrorListWindow
  {
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbErrors;
    private System.Windows.Forms.ToolStripButton tsbWarnings;
    protected System.Windows.Forms.ListView ltvErrors;
    private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ImageList images;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;


    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorListWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbErrors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWarnings = new System.Windows.Forms.ToolStripButton();
            this.ltvErrors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbErrors,
            this.toolStripSeparator1,
            this.tsbWarnings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbErrors
            // 
            this.tsbErrors.Checked = true;
            this.tsbErrors.CheckOnClick = true;
            this.tsbErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbErrors.Image = global::OpenQuant.Shared.Properties.Resources.error;
            this.tsbErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErrors.Name = "tsbErrors";
            this.tsbErrors.Size = new System.Drawing.Size(57, 22);
            this.tsbErrors.Text = "Errors";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbWarnings
            // 
            this.tsbWarnings.Checked = true;
            this.tsbWarnings.CheckOnClick = true;
            this.tsbWarnings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbWarnings.Image = global::OpenQuant.Shared.Properties.Resources.warning;
            this.tsbWarnings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWarnings.Name = "tsbWarnings";
            this.tsbWarnings.Size = new System.Drawing.Size(77, 22);
            this.tsbWarnings.Text = "Warnings";
            // 
            // ltvErrors
            // 
            this.ltvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvErrors.FullRowSelect = true;
            this.ltvErrors.GridLines = true;
            this.ltvErrors.HideSelection = false;
            this.ltvErrors.Location = new System.Drawing.Point(0, 25);
            this.ltvErrors.Name = "ltvErrors";
            this.ltvErrors.ShowItemToolTips = true;
            this.ltvErrors.Size = new System.Drawing.Size(661, 149);
            this.ltvErrors.SmallImageList = this.images;
            this.ltvErrors.TabIndex = 1;
            this.ltvErrors.UseCompatibleStateImageBehavior = false;
            this.ltvErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Line";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Column";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 444;
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
           
               this.images.Images.SetKeyName(0, "error.png");
            this.images.Images.SetKeyName(1, "warning.png");
            // 
            // ErrorListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ltvErrors);
            this.Controls.Add(this.toolStrip1);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Bottom;
            this.Name = "ErrorListWindow";
            this.PersistState = false;
            this.Size = new System.Drawing.Size(661, 174);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.error_list;
            this.Text = "Error List";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

  }
}
