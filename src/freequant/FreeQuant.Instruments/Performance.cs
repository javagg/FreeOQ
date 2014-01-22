using FreeQuant;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class Performance
  {
		private Portfolio portfolio; 
    private bool enabled;
    private DoubleSeries equitySeries;
    private DoubleSeries coreEquitySeries;
    private DoubleSeries pnlSeries;
    private DoubleSeries drawdownSeries;
		private DoubleSeries drawdownPercentSeries; 
    private double equity;
    private double coreEquity;
    private double lowEquity;
    private double highEquity;
    private double pnl;
    private double drawdown;
    private double drawdownPercent;
    private double currentDrawdown;
    private double currentRunUp;
    private double InjBy1lkoo;
    private double MrYBqYV87G;

    [Browsable(false)]
    public Portfolio Portfolio
    {
       get
      {
        return this.portfolio;
      }
    }

    public bool Enabled
    {
       get
      {
				return this.enabled; 
      }
       set
      {
        this.enabled = value;
      }
    }

    public bool CalculatePnL {  get;  set; }

    public bool CalculateDrawdown {  get;  set; }

    public TimeSpan UpdateInterval {  get;  set; }

    public bool UpdateOnIntervalEnabled {  get;  set; }

    [Browsable(false)]
    public DoubleSeries EquitySeries
    {
       get
      {
				return this.equitySeries; 
      }
    }

    [Browsable(false)]
    public DoubleSeries CoreEquitySeries
    {
       get
      {
				return this.coreEquitySeries; 
      }
    }

    [Browsable(false)]
    public DoubleSeries PnLSeries
    {
       get
      {
				return this.pnlSeries; 
      }
    }

    [Browsable(false)]
    public DoubleSeries DrawdownSeries
    {
       get
      {
				return this.drawdownSeries; 
      }
    }

    [Browsable(false)]
    public DoubleSeries DrawdownPercentSeries
    {
       get
      {
				return this.drawdownPercentSeries;   
      }
    }

    [Browsable(false)]
    public double Equity
    {
       get
      {
				return this.equity;  
      }
    }

    [Browsable(false)]
    public double CoreEquity
    {
       get
      {
				return this.coreEquity; 
      }
    }

    [Browsable(false)]
    public double PnL
    {
       get
      {
				return this.pnl; 
      }
    }

    [Browsable(false)]
    public double HighEquity
    {
       get
      {
				return this.highEquity; 
      }
    }

    [Browsable(false)]
    public double LowEquity
    {
       get
      {
				return this.lowEquity; 
      }
    }

    [Browsable(false)]
    public double Drawdown
    {
       get
      {
				return this.drawdown; 
      }
    }

    [Browsable(false)]
    public double DrawdownPercent
    {
       get
      {
				return this.drawdownPercent; 
      }
    }

    [Browsable(false)]
    public double CurrentDrawdown
    {
       get
      {
				return this.currentDrawdown;  
      }
    }

    [Browsable(false)]
    public double CurrentRunUp
    {
       get
      {
				return this.currentRunUp; 
      }
    }

    public event EventHandler EquityChanged;

    
    public Performance(Portfolio portfolio)
    {
      this.enabled = true;
			this.equitySeries = new DoubleSeries("Equity");
			this.coreEquitySeries = new DoubleSeries("CoreEquity");
			this.pnlSeries = new DoubleSeries("PnL");
			this.drawdownSeries = new DoubleSeries("Drawdown");
			this.drawdownPercentSeries = new DoubleSeries("DrawdownPercent");
      this.InjBy1lkoo = double.NaN;
      this.MrYBqYV87G = double.NaN;
      this.portfolio = portfolio;
      this.CalculatePnL = true;
      this.CalculateDrawdown = true;
      this.portfolio.ValueChanged += new PositionEventHandler(this.RLrBXT2waX);
    }

    
    internal void GcxBG7nv0L()
    {
      this.equitySeries.Clear();
      this.coreEquitySeries.Clear();
      this.pnlSeries.Clear();
      this.drawdownSeries.Clear();
      this.drawdownPercentSeries.Clear();
      this.equity = 0.0;
      this.coreEquity = 0.0;
      this.lowEquity = 0.0;
      this.highEquity = 0.0;
      this.pnl = 0.0;
      this.drawdown = 0.0;
      this.drawdownPercent = 0.0;
    }

    
    private void RLrBXT2waX([In] object obj0, [In] PositionEventArgs obj1)
    {
      if (!this.enabled)
        return;
      DateTime dateTime = Clock.Now;
      if (this.UpdateOnIntervalEnabled)
        dateTime = new DateTime(dateTime.Ticks / this.UpdateInterval.Ticks * this.UpdateInterval.Ticks);
      this.FZABJ7ZbGj(dateTime);
      this.SijB3EsC7m(dateTime);
      this.PSxBNlvv0d(dateTime);
//      if (this.VIABfp2hVw == null)
//        return;
//      this.VIABfp2hVw((object) this, EventArgs.Empty);
    }

    
    private void faxB4aWy0q([In] object obj0, [In] EventArgs obj1)
    {
      this.GcxBG7nv0L();
    }

    
    private void FZABJ7ZbGj([In] DateTime obj0)
    {
      if (!double.IsNaN(this.MrYBqYV87G))
      {
        this.FnhBrkOUJ3(obj0.AddTicks(-1L), this.InjBy1lkoo, this.MrYBqYV87G);
        this.InjBy1lkoo = double.NaN;
        this.MrYBqYV87G = double.NaN;
      }
      this.coreEquity = this.portfolio.GetCoreEquity();
      this.equity = this.portfolio.GetTotalEquity();
      this.FnhBrkOUJ3(obj0, this.equity, this.coreEquity);
    }

    
    private void FnhBrkOUJ3([In] DateTime obj0, [In] double obj1, [In] double obj2)
    {
      this.coreEquitySeries[obj0] = obj2;
      this.equitySeries[obj0] = obj1;
      if (this.equitySeries.Count == 1)
      {
        this.lowEquity = obj1;
        this.highEquity = obj1;
      }
      else
      {
        if (this.equity > this.highEquity)
        {
          this.highEquity = obj1;
          this.lowEquity = obj1;
//          this.VpPUJn = 0.0;
        }
        if (this.equity < this.lowEquity)
        {
          this.lowEquity = obj1;
          this.currentRunUp = 0.0;
        }
        if (obj1 <= this.lowEquity || obj1 >= this.highEquity)
          return;
//				this.VpPUJn  = 1.0 - obj1 / this.highEquity;
        this.currentRunUp = obj1 / this.lowEquity - 1.0;
      }
    }

    
    private void SijB3EsC7m([In] DateTime obj0)
    {
      if (!this.CalculatePnL || this.equitySeries.Count < 2)
        return;
      int lastIndex = this.equitySeries.LastIndex;
      int index = lastIndex - 1;
      this.pnl = this.equitySeries[lastIndex] - this.equitySeries[index];
      this.pnlSeries[obj0] = this.pnl;
    }

    
    private void PSxBNlvv0d([In] DateTime obj0)
    {
      if (!this.CalculateDrawdown || this.equitySeries.Count < 2)
        return;
      this.drawdown = this.equity - this.highEquity;
      this.drawdownSeries[obj0] = this.drawdown;
      if (this.highEquity == 0.0)
        return;
      this.drawdownPercent = Math.Abs(this.drawdown / this.highEquity);
      this.drawdownPercentSeries[obj0] = this.drawdownPercent;
    }

    
    public void Init()
    {
      this.MrYBqYV87G = this.Portfolio.GetCoreEquity();
      this.InjBy1lkoo = this.Portfolio.GetTotalEquity();
    }
  }
}
