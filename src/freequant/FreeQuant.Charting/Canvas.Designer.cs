namespace FreeQuant.Charting
{
    public partial class Canvas
	{
		private System.Windows.Forms.HelpProvider helpProvider;
        private FreeQuant.Charting.Chart chart;
		private System.ComponentModel.IContainer container;

        protected override void Dispose(bool disposing)
        {
            CanvasManager.Remove(this);
            if (disposing && this.container != null)
                this.container.Dispose();
            base.Dispose(disposing);
        }

		private void InitializeComponent()
		{
		    this.container = new System.ComponentModel.Container();
		    this.helpProvider = new System.Windows.Forms.HelpProvider();
		    this.chart = new FreeQuant.Charting.Chart();
		    this.SuspendLayout();
		    // 
		    // chart
		    // 
		    this.chart.AntiAliasingEnabled = false;
		    this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.chart.DoubleBufferingEnabled = true;
		    this.chart.FileName = null;
		    this.chart.GroupLeftMarginEnabled = false;
		    this.chart.GroupRightMarginEnabled = false;
		    this.chart.GroupZoomEnabled = false;
		    this.chart.ImeMode = System.Windows.Forms.ImeMode.Off;
		    this.chart.Location = new System.Drawing.Point(0, 0);
		    this.chart.Name = "chart";
		    this.chart.PadsForeColor = System.Drawing.Color.White;
		    this.chart.PrintAlign = FreeQuant.Charting.EPrintAlign.None;
		    this.chart.PrintHeight = 400;
		    this.chart.PrintLayout = FreeQuant.Charting.EPrintLayout.Portrait;
		    this.chart.PrintWidth = 600;
		    this.chart.PrintX = 10;
		    this.chart.PrintY = 10;
		    this.chart.SessionEnd = System.TimeSpan.Parse("00:00:00");
		    this.chart.SessionGridColor = System.Drawing.Color.Blue;
		    this.chart.SessionGridEnabled = false;
		    this.chart.SessionStart = System.TimeSpan.Parse("00:00:00");
		    this.chart.Size = new System.Drawing.Size(484, 322);
		    this.chart.SmoothingEnabled = false;
		    this.chart.TabIndex = 0;
		    this.chart.TransformationType = FreeQuant.Charting.ETransformationType.Empty;
		    // 
		    // Canvas
		    // 
		    this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		    this.ClientSize = new System.Drawing.Size(484, 322);
		    this.Controls.Add(this.chart);
		    this.Name = "Canvas";
		    this.ResumeLayout(false);
		}
	}
}
