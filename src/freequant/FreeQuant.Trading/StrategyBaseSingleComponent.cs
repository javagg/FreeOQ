
using FreeQuant.Charting;
using FreeQuant.Instruments;
using FreeQuant.Series;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public abstract class StrategyBaseSingleComponent : SingleInstrumentComponent, IStrategyComponent
  {
    private StrategyBase U8ZSiZE1f;

    [Browsable(false)]
    public StrategyBase StrategyBase
    {
      get
      {
        return this.U8ZSiZE1f;
      }
      internal set
      {
        if (this.U8ZSiZE1f != null)
          this.Disconnect();
        this.U8ZSiZE1f = value;
        if (this.U8ZSiZE1f == null)
          return;
        this.Connect();
      }
    }

    [Browsable(false)]
    public Portfolio Portfolio
    {
      get
      {
        return this.U8ZSiZE1f.Portfolio;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
      get
      {
        return this.U8ZSiZE1f.Bars;
      }
    }

    [Browsable(false)]
    public BarSeries Bar
    {
      get
      {
        return this.U8ZSiZE1f.Bars[this.instrument];
      }
    }

    [Browsable(false)]
    public Position Position
    {
      get
      {
        return this.U8ZSiZE1f.Portfolio.Positions[this.instrument];
      }
    }

    [Browsable(false)]
    public bool HasPosition
    {
      get
      {
        return this.Position != null;
      }
    }

    [Browsable(false)]
    public NamedOrderTable Orders
    {
      get
      {
        return this.U8ZSiZE1f.Orders[this.instrument];
      }
    }

    [Browsable(false)]
    public Hashtable Global
    {
      get
      {
        return this.U8ZSiZE1f.Global;
      }
    }

   
		public StrategyBaseSingleComponent():base()
    {

    }

   
    public void Draw(IDrawable primitive, int padNumber)
    {
      this.U8ZSiZE1f.MetaStrategyBase.zeFW20hc2d(this.instrument, primitive, padNumber);
    }

   
    public void Draw(IDrawable primitive, int padNumber, Color color)
    {
      if (primitive is TimeSeries)
        (primitive as TimeSeries).Color = color;
      this.Draw(primitive, padNumber);
    }
  }
}
