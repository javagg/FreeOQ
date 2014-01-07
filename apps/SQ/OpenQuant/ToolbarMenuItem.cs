// Type: OpenQuant.ToolbarMenuItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class ToolbarMenuItem : ToolStripMenuItem
  {
    private ToolStrip toolStrip;

    public ToolbarMenuItem(ToolStrip toolStrip)
    {
      this.toolStrip = toolStrip;
      this.Text = toolStrip.Text;
      this.Checked = toolStrip.Visible;
      this.CheckOnClick = true;
    }

    protected override void OnCheckedChanged(EventArgs e)
    {
      this.toolStrip.Visible = this.Checked;
    }
  }
}
