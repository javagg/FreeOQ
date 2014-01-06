using System.ComponentModel;

namespace OpenQuant.API
{
  public class Performance
  {
    internal Portfolio portfolio;
    private TimeSeries equitySeries;
    private TimeSeries coreEquitySeries;
    private TimeSeries pnLSeries;
    private TimeSeries drawdownSeries;
    private TimeSeries drawdownPercentSeries;

    public bool IsEnabled
    {
      get
      {
        return this.portfolio.portfolio.Performance.Enabled;
      }
      set
      {
        this.portfolio.portfolio.Performance.Enabled = value;
      }
    }

    [Browsable(false)]
    public TimeSeries EquitySeries
    {
      get
      {
        return this.equitySeries;
      }
    }

    [Browsable(false)]
    public TimeSeries CoreEquitySeries
    {
      get
      {
        return this.coreEquitySeries;
      }
    }

    [Browsable(false)]
    public TimeSeries PnLSeries
    {
      get
      {
        return this.pnLSeries;
      }
    }

    [Browsable(false)]
    public TimeSeries DrawdownSeries
    {
      get
      {
        return this.drawdownSeries;
      }
    }

    [Browsable(false)]
    public TimeSeries DrawdownPercentSeries
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
        return this.portfolio.portfolio.Performance.Equity;
      }
    }

    [Browsable(false)]
    public double CoreEquity
    {
      get
      {
        return this.portfolio.portfolio.Performance.CoreEquity;
      }
    }

    [Browsable(false)]
    public double PnL
    {
      get
      {
        return this.portfolio.portfolio.Performance.PnL;
      }
    }

    [Browsable(false)]
    public double HighEquity
    {
      get
      {
        return this.portfolio.portfolio.Performance.HighEquity;
      }
    }

    [Browsable(false)]
    public double LowEquity
    {
      get
      {
        return this.portfolio.portfolio.Performance.LowEquity;
      }
    }

    [Browsable(false)]
    public double Drawdown
    {
      get
      {
        return this.portfolio.portfolio.Performance.Drawdown;
      }
    }

    [Browsable(false)]
    public double DrawdownPercent
    {
      get
      {
        return this.portfolio.portfolio.Performance.DrawdownPercent;
      }
    }

    internal Performance(Portfolio portfolio)
    {
      this.portfolio = portfolio;
      this.equitySeries = new TimeSeries(portfolio.portfolio.Performance.EquitySeries);
      this.coreEquitySeries = new TimeSeries(portfolio.portfolio.Performance.CoreEquitySeries);
      this.pnLSeries = new TimeSeries(portfolio.portfolio.Performance.PnLSeries);
      this.drawdownSeries = new TimeSeries(portfolio.portfolio.Performance.DrawdownSeries);
      this.drawdownPercentSeries = new TimeSeries(portfolio.portfolio.Performance.DrawdownPercentSeries);
    }
  }
}
