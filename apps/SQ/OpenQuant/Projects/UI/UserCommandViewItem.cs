// Type: OpenQuant.Projects.UI.UserCommandViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Trading;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  internal class UserCommandViewItem : ListViewItem
  {
    public UserCommandViewItem(UserCommand command)
      : base(new string[3])
    {
      this.SubItems[0].Text = command.get_Command().get_DateTime().ToString();
      this.SubItems[1].Text = command.get_Strategy() == null ? "-" : command.get_Strategy();
      this.SubItems[2].Text = command.get_Command().get_Text();
    }
  }
}
