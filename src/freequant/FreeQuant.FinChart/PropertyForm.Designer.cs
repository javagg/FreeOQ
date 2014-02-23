namespace FreeQuant.FinChart
{
    public partial class PropertyForm
  {
		private System.Windows.Forms.PropertyGrid propertyGrid; 
		private System.Windows.Forms.Button btn; 
		private System.ComponentModel.Container container; 


    
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.container != null)
        this.container.Dispose();
      base.Dispose(disposing);
    }

    
    private void InitializeComponent()
    {
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(232, 310);
            this.propertyGrid.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn.Location = new System.Drawing.Point(168, 280);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(56, 24);
            this.btn.TabIndex = 3;
            this.btn.Text = "dddd";
            // 
            // PropertyForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(232, 310);
            this.ControlBox = false;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.propertyGrid);
            this.Name = "PropertyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.ResumeLayout(false);

    }
  }
}
