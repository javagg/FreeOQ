namespace FreeQuant.Charting
{
    public partial class PadProperyForm
  {
		private System.Windows.Forms.PropertyGrid propertyGrid; 
    private System.ComponentModel.IContainer container;

    

    
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.container != null)
        this.container.Dispose();
      base.Dispose(disposing);
    }

    
    private void InitializeComponent()
    {
    	this.container = new System.ComponentModel.Container();
//    	ResourceManager resourceManager = new ResourceManager(typeof (PadProperyForm));
      this.propertyGrid = new System.Windows.Forms.PropertyGrid();
      this.SuspendLayout();
      this.propertyGrid.CommandsVisibleIfAvailable = true;
      this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid.LargeButtons = false;
      this.propertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar;
      this.propertyGrid.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid.Name = "Name";
      this.propertyGrid.Size = new System.Drawing.Size(336, 381);
      this.propertyGrid.TabIndex = 0;
			this.propertyGrid.Text = "text";
      this.propertyGrid.ViewBackColor = System.Drawing.SystemColors.Window;
      this.propertyGrid.ViewForeColor = System.Drawing.SystemColors.WindowText;
      this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.mV134Z7kpS);
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(336, 381);
      this.Controls.Add(this.propertyGrid);
//			this.Icon = (Icon)resourceManager.GetObject("PadProperyForm.Icon");
			this.Name = "Name1";
			this.Text = "Text1";
      this.ShowInTaskbar = false;
      this.ResumeLayout(false);
    }

  }
}
