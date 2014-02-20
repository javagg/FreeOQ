namespace FreeQuant.Charting
{
    public partial class Chart
	{
		protected override void Dispose(bool disposing)
		{
			foreach (Pad pad in this.fPads)
				pad.Monitored = false;
			base.Dispose(disposing);
		}

        protected void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(300, 250);
            this.ResumeLayout(false);
        }
	}
}
