// Type: OpenQuant.WindowMenuItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant
{
  internal class WindowMenuItem : ToolStripMenuItem
  {
    private DockControl control;

    public WindowMenuItem(DockControl control)
    {
      this.control = control;
      this.Text = control.get_TabText();
      this.Checked = control.get_IsOpen();
    }

    protected override void OnClick(EventArgs e)
    {
      this.control.Open();
    }
  }
}
