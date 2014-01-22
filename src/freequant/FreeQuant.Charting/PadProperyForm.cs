using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Charting
{
  public class PadProperyForm : Form
  {
    private object KtO3rBrbaI;
    private Pad evD3c4dHMV;
		private PropertyGrid propertyGrid; 
    private Container ahN3WtCyLA;

    
    public PadProperyForm(object Object, Pad Pad):base()
    {

      this.nev3U8bfUe();
      this.KtO3rBrbaI = Object;
      this.evD3c4dHMV = Pad;
			this.Text = Object.GetType().Name + "Pad";
      this.propertyGrid.SelectedObject = Object;
    }

    
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.ahN3WtCyLA != null)
        this.ahN3WtCyLA.Dispose();
      base.Dispose(disposing);
    }

    
    private void nev3U8bfUe()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (PadProperyForm));
      this.propertyGrid = new PropertyGrid();
      this.SuspendLayout();
      this.propertyGrid.CommandsVisibleIfAvailable = true;
      this.propertyGrid.Dock = DockStyle.Fill;
      this.propertyGrid.LargeButtons = false;
      this.propertyGrid.LineColor = SystemColors.ScrollBar;
      this.propertyGrid.Location = new Point(0, 0);
			this.propertyGrid.Name = "Name";
      this.propertyGrid.Size = new Size(336, 381);
      this.propertyGrid.TabIndex = 0;
			this.propertyGrid.Text = "text";
      this.propertyGrid.ViewBackColor = SystemColors.Window;
      this.propertyGrid.ViewForeColor = SystemColors.WindowText;
      this.propertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(this.mV134Z7kpS);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(336, 381);
      this.Controls.Add((Control) this.propertyGrid);
			this.Icon = (Icon)resourceManager.GetObject("PadProperyForm.Icon");
			this.Name = "Name1";
			this.Text = "Text1";
      this.ShowInTaskbar = false;
      this.ResumeLayout(false);
    }

    
    private void mV134Z7kpS([In] object obj0, [In] PropertyValueChangedEventArgs obj1)
    {
      this.evD3c4dHMV.Update();
    }
  }
}
