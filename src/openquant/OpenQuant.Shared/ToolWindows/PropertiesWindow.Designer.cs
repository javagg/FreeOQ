namespace OpenQuant.Shared.ToolWindows
{
    public partial class PropertiesWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PropertyGrid propertyGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(253, 400);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // PropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propertyGrid);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Right;
            this.Name = "PropertiesWindow";
            this.Size = new System.Drawing.Size(253, 400);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.properties;
            this.Text = "Properties";
            this.ResumeLayout(false);

        }
    }
}
