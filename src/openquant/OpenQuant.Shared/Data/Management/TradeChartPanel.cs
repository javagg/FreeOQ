using FreeQuant.Data;
using FreeQuant.Series;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.Shared.Data.Management
{
  internal class TradeChartPanel : IntradayChartPanel
  {
    private IContainer components;

    public TradeChartPanel()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
    }

    protected override void OnUpdateChart(ICollection<IDataObject> objects)
    {
      DoubleSeries doubleSeries = new DoubleSeries("Trade");
      using (IEnumerator<IDataObject> enumerator = ((IEnumerable<IDataObject>) objects).GetEnumerator())
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          Trade trade = (Trade) enumerator.Current;
          doubleSeries.Add(trade.DateTime, trade.Price);
        }
      }
      ((TimeSeries) doubleSeries).Draw(Color.Black);
    }
  }
}
