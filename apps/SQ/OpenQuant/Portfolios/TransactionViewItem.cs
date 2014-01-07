// Type: OpenQuant.Portfolios.TransactionViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;
using SmartQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Portfolios
{
  internal class TransactionViewItem : ListViewItem
  {
    public TransactionViewItem(Transaction transaction)
      : base(new string[10])
    {
      string format = PriceFormatHelper.GetFormat(transaction.Instrument);
      this.SubItems[0].Text = transaction.DateTime.ToString();
      this.SubItems[1].Text = transaction.Instrument.Symbol;
      this.SubItems[2].Text = ((object) transaction.Side).ToString();
      this.SubItems[3].Text = transaction.Price.ToString(format);
      this.SubItems[4].Text = transaction.Qty.ToString();
      this.SubItems[5].Text = transaction.Value.ToString(format);
      this.SubItems[6].Text = transaction.Cost.ToString(format);
      this.SubItems[7].Text = transaction.PnL.ToString(format);
      this.SubItems[8].Text = transaction.Currency.Code;
      this.SubItems[9].Text = transaction.Text;
    }
  }
}
