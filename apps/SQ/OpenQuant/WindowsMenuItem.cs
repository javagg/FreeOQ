// Type: OpenQuant.WindowsMenuItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class WindowsMenuItem : ToolStripMenuItem
  {
    public WindowsMenuItem()
    {
      this.Text = "Windows...";
    }

    protected override void OnClick(EventArgs e)
    {
      WindowsForm windowsForm = new WindowsForm();
      int num = (int) windowsForm.ShowDialog((IWin32Window) Global.MainForm);
      windowsForm.Dispose();
    }
  }
}
