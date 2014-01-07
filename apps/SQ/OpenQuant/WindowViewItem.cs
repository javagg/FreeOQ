// Type: OpenQuant.WindowViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant
{
  internal class WindowViewItem : ListViewItem
  {
    private DockControl control;

    public DockControl Control
    {
      get
      {
        return this.control;
      }
    }

    public WindowViewItem(DockControl control, int imageIndex)
      : base(new string[1])
    {
      this.control = control;
      this.SubItems[0].Text = control.get_TabText();
      this.ImageIndex = imageIndex;
    }
  }
}
