// Type: OpenQuant.Portfolios.AccountPositionViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Portfolios
{
  internal class AccountPositionViewItem : ListViewItem
  {
    public AccountPositionViewItem(AccountPosition position)
      : base(new string[2])
    {
      string format = "F2";
      this.SubItems[0].Text = position.Currency.ToString();
      this.SubItems[1].Text = position.Value.ToString(format);
    }
  }
}
