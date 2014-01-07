// Type: OpenQuant.BrokerInfo.BrokerOrderViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Providers;
using System.Windows.Forms;

namespace OpenQuant.BrokerInfo
{
  internal class BrokerOrderViewItem : ListViewItem
  {
    public BrokerOrder Order { get; private set; }

    public BrokerOrderViewItem(BrokerOrder order)
      : base(new string[8], 0)
    {
      this.Order = order;
      this.SubItems[0].Text = order.OrderID;
      this.SubItems[1].Text = order.Symbol;
      this.SubItems[2].Text = ((object) order.Side).ToString();
      this.SubItems[3].Text = ((object) order.OrdType).ToString();
      this.SubItems[4].Text = order.OrderQty.ToString();
      this.SubItems[5].Text = order.Price.ToString();
      this.SubItems[6].Text = order.StopPx.ToString();
      this.SubItems[7].Text = ((object) order.OrdStatus).ToString();
    }
  }
}
