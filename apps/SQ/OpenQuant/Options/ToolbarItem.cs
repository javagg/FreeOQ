// Type: OpenQuant.Options.ToolbarItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant.Options
{
  internal class ToolbarItem
  {
    private ToolStrip toolStrip;

    public ToolStrip ToolStrip
    {
      get
      {
        return this.toolStrip;
      }
    }

    public ToolbarItem(ToolStrip toolStrip)
    {
      this.toolStrip = toolStrip;
    }

    public override string ToString()
    {
      return this.toolStrip.Text;
    }
  }
}
