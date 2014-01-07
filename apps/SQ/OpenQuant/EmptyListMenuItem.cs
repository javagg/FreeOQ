// Type: OpenQuant.EmptyListMenuItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant
{
  internal class EmptyListMenuItem : ToolStripMenuItem
  {
    public EmptyListMenuItem(string text)
      : base(text)
    {
      this.Enabled = false;
    }

    public EmptyListMenuItem()
      : this("Empty")
    {
    }
  }
}
