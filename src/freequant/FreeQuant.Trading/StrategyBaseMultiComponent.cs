
using FreeQuant.Charting;
using FreeQuant.Instruments;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class StrategyBaseMultiComponent : MultiInstrumentComponent, IStrategyComponent
  {
    private StrategyBase J2mpqllssW;

    [Browsable(false)]
    public StrategyBase StrategyBase
    {
      get
      {
        return this.J2mpqllssW;
      }
      internal set
      {
        if (this.J2mpqllssW != null)
          this.Disconnect();
        this.J2mpqllssW = value;
        if (this.J2mpqllssW == null)
          return;
        this.Connect();
      }
    }

    [Browsable(false)]
    public Portfolio Portfolio
    {
      get
      {
        return this.J2mpqllssW.Portfolio;
      }
    }

    [Browsable(false)]
    public BarSeriesList Bars
    {
      get
      {
        return this.StrategyBase.Bars;
      }
    }

    [Browsable(false)]
    public Hashtable Global
    {
      get
      {
        return this.J2mpqllssW.Global;
      }
    }

   
		public StrategyBaseMultiComponent():base()
    {

    }

   
    public virtual void OnPortfolioValueChanged(Position position)
    {
    }

   
    public virtual void OnBarSlice(long size)
    {
    }

   
    public void Draw(Instrument instrument, IDrawable primitive, int padNumber)
    {
      this.J2mpqllssW.MetaStrategyBase.zeFW20hc2d(instrument, primitive, padNumber);
    }
  }
}
