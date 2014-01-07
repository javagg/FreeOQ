// Type: OpenQuant.Portfolios.PositionViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;
using SmartQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Portfolios
{
  internal class PositionViewItem : ListViewItem
  {
    private Position position;

    public Position PortfolioPosition
    {
      get
      {
        return this.position;
      }
    }

    public PositionViewItem(Position position)
      : base(new string[11])
    {
      this.position = position;
      this.UpdateValues();
    }

    public void UpdateValues()
    {
      string format = PriceFormatHelper.GetFormat(this.position.Instrument);
      this.SubItems[0].Text = this.position.Instrument.Symbol;
      this.SubItems[1].Text = ((object) this.position.Side).ToString();
      this.SubItems[2].Text = this.position.Price().ToString(format);
      this.SubItems[3].Text = this.position.Qty.ToString();
      this.SubItems[4].Text = this.position.QtyBought.ToString();
      this.SubItems[5].Text = this.position.QtySold.ToString();
      this.SubItems[6].Text = this.position.QtySoldShort.ToString();
      this.SubItems[7].Text = this.position.Margin.ToString(format);
      this.SubItems[8].Text = this.position.Debt.ToString(format);
      this.SubItems[9].Text = this.position.GetValue().ToString(format);
      this.SubItems[10].Text = this.position.GetPnL().ToString(format);
    }
  }
}
