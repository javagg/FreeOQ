namespace OpenQuant.Shared.Charting
{
	partial class Chart
	{
        private System.ComponentModel.IContainer components = null;
		

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
		    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
		    this.SuspendLayout();
		    // 
		    // Chart
		    // 
		    this.AllowDrop = true;
		    this.Name = "Chart";
		    this.PrimitiveDeleteImage = ((System.Drawing.Image)(resources.GetObject("$this.PrimitiveDeleteImage")));
		    this.PrimitivePropertiesImage = ((System.Drawing.Image)(resources.GetObject("$this.PrimitivePropertiesImage")));
		    this.Size = new System.Drawing.Size(594, 339);
		    this.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
		    this.ResumeLayout(false);
		}
	}
}
