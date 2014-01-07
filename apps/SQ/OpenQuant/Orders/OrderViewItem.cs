// Type: OpenQuant.Orders.OrderViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Execution;
using SmartQuant.FIX;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Orders
{
  public class OrderViewItem : ListViewItem
  {
    private SingleOrder order;

    public SingleOrder Order
    {
      get
      {
        return this.order;
      }
    }

    public OrderViewItem(SingleOrder order)
    {
      this.order = order;
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.SubItems.Add("");
      this.Update();
    }

    public void Update()
    {
      switch (this.order.OrdStatus)
      {
        case OrdStatus.New:
          this.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 230);
          break;
        case OrdStatus.PartiallyFilled:
          this.BackColor = Color.SkyBlue;
          break;
        case OrdStatus.Filled:
          this.BackColor = Color.FromArgb(220, (int) byte.MaxValue, 220);
          break;
        case OrdStatus.Cancelled:
          this.BackColor = Color.FromArgb((int) byte.MaxValue, 230, 230);
          break;
        case OrdStatus.Expired:
          this.BackColor = Color.FromArgb((int) byte.MaxValue, 230, 230);
          break;
      }
      string priceDisplay = this.order.Instrument.PriceDisplay;
      this.SubItems[0].Text = this.order.TransactTime.ToString();
      this.SubItems[1].Text = this.order.Symbol;
      this.SubItems[2].Text = ((object) this.order.Side).ToString();
      this.SubItems[3].Text = ((object) this.order.OrdType).ToString();
      this.SubItems[4].Text = this.order.OrderQty.ToString();
      this.SubItems[5].Text = this.order.AvgPx.ToString(priceDisplay);
      this.SubItems[6].Text = this.order.Price.ToString(priceDisplay);
      this.SubItems[7].Text = this.order.StopPx.ToString(priceDisplay);
      this.SubItems[8].Text = ((object) this.order.OrdStatus).ToString();
      this.SubItems[9].Text = this.order.Text;
    }
  }
}
