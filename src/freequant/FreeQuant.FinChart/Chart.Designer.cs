namespace FreeQuant.FinChart
{
    public partial class Chart
	{
		private System.ComponentModel.IContainer container;
	
		private System.Windows.Forms.HScrollBar hScrollBar;
	
		internal System.Windows.Forms.ToolTip toolTip;


		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container != null)
				this.container.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 463);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(640, 17);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FSOLY9YLw);
            // 
            // Chart
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.hScrollBar);
            this.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(640, 480);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            this.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            this.ResumeLayout(false);

		}

        private System.ComponentModel.IContainer components;


	}
}
