// Type: OpenQuant.Instruments.InstrumentListWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Instruments;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Instruments
{
  internal class InstrumentListWindow : InstrumentListWindow
  {
    private IContainer components;

    public InstrumentListWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ((Control) this).SuspendLayout();
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Name = "InstrumentListWindow";
      this.set_ViewChartEnabled(true);
      this.set_ViewDataEnabled(true);
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }
  }
}
