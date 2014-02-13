using FreeQuant.Data;
using FreeQuant.Series;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.Shared.Data.Management
{
  internal class QuoteChartPanel : IntradayChartPanel
  {
    private IContainer components;

    public QuoteChartPanel()
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
      DoubleSeries doubleSeries1 = new DoubleSeries("Bid");
      DoubleSeries doubleSeries2 = new DoubleSeries("Ask");
      using (IEnumerator<IDataObject> enumerator = ((IEnumerable<IDataObject>) objects).GetEnumerator())
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          Quote quote = (Quote) enumerator.Current;
          doubleSeries1.Add(quote.DateTime, quote.Bid);
					doubleSeries2.Add(quote.DateTime, quote.Ask);
        }
      }
      ((TimeSeries) doubleSeries1).Draw(Color.Blue);
      ((TimeSeries) doubleSeries2).Draw(Color.Red);
    }
  }
}
