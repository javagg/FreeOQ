using OpenQuant.Config;
using System;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class IDEHelper
  {
    public static bool DoRunStrategy()
    {
      ConfigurationMode activeMode = Configuration.get_ActiveMode();
      switch ((int) activeMode)
      {
        case 0:
          return true;
        case 1:
        case 2:
          return MessageBox.Show((IWin32Window) Global.MainForm, string.Format("You are about to run strategy in {0} mode.{1}Do you want to continue?", (object) activeMode, (object) Environment.NewLine), string.Format("{0} Mode!", (object) activeMode), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        default:
          throw new ArgumentException(string.Format("Unknown configuration mode - {0}", (object) activeMode));
      }
    }
  }
}
