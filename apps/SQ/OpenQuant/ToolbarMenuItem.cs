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
