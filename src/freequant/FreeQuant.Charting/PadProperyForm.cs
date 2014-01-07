// Type: SmartQuant.Charting.PadProperyForm
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using gyr6NSGRxNZcTviJZk;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
  public class PadProperyForm : Form
  {
    private object KtO3rBrbaI;
    private Pad evD3c4dHMV;
    private PropertyGrid RwF3yvcan6;
    private Container ahN3WtCyLA;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadProperyForm(object Object, Pad Pad)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nev3U8bfUe();
      this.KtO3rBrbaI = Object;
      this.evD3c4dHMV = Pad;
      this.Text = Object.GetType().Name + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(430);
      this.RwF3yvcan6.SelectedObject = Object;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.ahN3WtCyLA != null)
        this.ahN3WtCyLA.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nev3U8bfUe()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (PadProperyForm));
      this.RwF3yvcan6 = new PropertyGrid();
      this.SuspendLayout();
      this.RwF3yvcan6.CommandsVisibleIfAvailable = true;
      this.RwF3yvcan6.Dock = DockStyle.Fill;
      this.RwF3yvcan6.LargeButtons = false;
      this.RwF3yvcan6.LineColor = SystemColors.ScrollBar;
      this.RwF3yvcan6.Location = new Point(0, 0);
      this.RwF3yvcan6.Name = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(456);
      this.RwF3yvcan6.Size = new Size(336, 381);
      this.RwF3yvcan6.TabIndex = 0;
      this.RwF3yvcan6.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(484);
      this.RwF3yvcan6.ViewBackColor = SystemColors.Window;
      this.RwF3yvcan6.ViewForeColor = SystemColors.WindowText;
      this.RwF3yvcan6.PropertyValueChanged += new PropertyValueChangedEventHandler(this.mV134Z7kpS);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(336, 381);
      this.Controls.Add((Control) this.RwF3yvcan6);
      this.Icon = (Icon) resourceManager.GetObject(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(514));
      this.Name = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(538);
      this.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(570);
      this.ShowInTaskbar = false;
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mV134Z7kpS([In] object obj0, [In] PropertyValueChangedEventArgs obj1)
    {
      this.evD3c4dHMV.Update();
    }
  }
}
