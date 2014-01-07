// Type: OpenQuant.Portfolios.AccountTransactionViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Portfolios
{
  internal class AccountTransactionViewItem : ListViewItem
  {
    public AccountTransactionViewItem(AccountTransaction transaction)
      : base(new string[5])
    {
      string format = "F2";
      this.SubItems[0].Text = transaction.DateTime.ToString();
      this.SubItems[1].Text = ((object) transaction.Action).ToString();
      this.SubItems[2].Text = transaction.Value.ToString(format);
      this.SubItems[3].Text = transaction.Currency.ToString();
      this.SubItems[4].Text = transaction.Text;
    }
  }
}
