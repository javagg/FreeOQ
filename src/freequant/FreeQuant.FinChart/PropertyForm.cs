using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
  public class PropertyForm : Form
  {
		private PropertyGrid propertyGrid; 
		private Button btn; 
		private Container container; 

		public PropertyForm(object properties) : base()
    {

      this.Init();
      this.propertyGrid.SelectedObject = properties;
    }

    
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.container != null)
        this.container.Dispose();
      base.Dispose(disposing);
    }

    
    private void Init()
    {
      this.propertyGrid = new PropertyGrid();
      this.btn = new Button();
      this.SuspendLayout();
      this.propertyGrid.CommandsVisibleIfAvailable = true;
      this.propertyGrid.Dock = DockStyle.Fill;
      this.propertyGrid.LargeButtons = false;
      this.propertyGrid.LineColor = SystemColors.ScrollBar;
      this.propertyGrid.Location = new Point(0, 0);
			this.propertyGrid.Name = "dfdfs";
      this.propertyGrid.Size = new Size(232, 310);
      this.propertyGrid.TabIndex = 2;
			this.propertyGrid.Text = "dfdfs";
      this.propertyGrid.ViewBackColor = SystemColors.Window;
      this.propertyGrid.ViewForeColor = SystemColors.WindowText;
      this.btn.DialogResult = DialogResult.Cancel;
      this.btn.Location = new Point(168, 280);
			this.btn.Name = "dfdfsdfsdfs";
      this.btn.Size = new Size(56, 24);
      this.btn.TabIndex = 3;
			this.btn.Text = "dddd";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(232, 310);
      this.ControlBox = false;
      this.Controls.Add((Control) this.btn);
      this.Controls.Add((Control) this.propertyGrid);
			this.Name = "dsdfssf";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "ddfsdfssf";
      this.ResumeLayout(false);
    }
  }
}
