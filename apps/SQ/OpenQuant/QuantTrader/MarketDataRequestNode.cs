// Type: OpenQuant.QuantTrader.MarketDataRequestNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Data;
using OpenQuant.Trading;

namespace OpenQuant.QuantTrader
{
  internal class MarketDataRequestNode : ExportItemNode
  {
    public MarketDataRequest Request { get; private set; }

    public MarketDataRequestNode(MarketDataRequest request)
      : base(((object) request).ToString(), 5)
    {
      this.Request = request;
      if (!(request is BarRequest))
        return;
      BarRequest barRequest = (BarRequest) request;
      this.Text = string.Format("Bar {0}", (object) DataSeriesHelper.BarTypeSizeToString(barRequest.get_BarType(), barRequest.get_BarSize()));
    }
  }
}
