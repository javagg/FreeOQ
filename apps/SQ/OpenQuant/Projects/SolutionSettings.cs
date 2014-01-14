using FreeQuant.Providers;
using FreeQuant.Testing;
using System;
using System.ComponentModel;

namespace OpenQuant.Projects
{
  internal class SolutionSettings
  {
    private MarketDataRequestList requests = new MarketDataRequestList();
    private TimeIntervalSize testingPeriod = TimeIntervalSize.day1;
    private DateTime startDate;
    private DateTime stopDate;
    private double cash;
    private bool reportEnabled;
    private BarFactoryInput barFactoryInput;

    [Description("BarFactory input")]
    [Category("BarFactory")]
    [DefaultValue(BarFactoryInput.Trade)]
    public BarFactoryInput BarFactoryInput
    {
      get
      {
        return this.barFactoryInput;
      }
      set
      {
        this.barFactoryInput = value;
      }
    }

    [Description("Simulation Start Date")]
    [DefaultValue(typeof (DateTime), "1970-01-01")]
    [Category("Simulation")]
    public DateTime StartDate
    {
      get
      {
        return this.startDate;
      }
      set
      {
        this.startDate = value;
      }
    }

    [Category("Simulation")]
    [Description("Simulation Stop Date")]
    [DefaultValue(typeof (DateTime), "2020-01-01")]
    public DateTime StopDate
    {
      get
      {
        return this.stopDate;
      }
      set
      {
        this.stopDate = value;
      }
    }

    [DefaultValue(100000.0)]
    [Description("Initial Cash Allocation")]
    [Category("Simulation")]
    public double Cash
    {
      get
      {
        return this.cash;
      }
      set
      {
        this.cash = value;
      }
    }

    [Description("Report Enabled")]
    [DefaultValue(false)]
    [Category("Reporting")]
    public bool ReportEnabled
    {
      get
      {
        return this.reportEnabled;
      }
      set
      {
        this.reportEnabled = value;
      }
    }

    [Category("Reporting")]
    [DefaultValue(TimeIntervalSize.day1)]
    [Description("Testing Period")]
    public TimeIntervalSize TestingPeriod
    {
      get
      {
        return this.testingPeriod;
      }
      set
      {
        this.testingPeriod = value;
      }
    }

    [Browsable(false)]
    public MarketDataRequestList Requests
    {
      get
      {
        return this.requests;
      }
      set
      {
        this.requests = value;
      }
    }

    public SolutionSettings()
    {
      this.startDate = new DateTime(1970, 1, 1);
      this.stopDate = new DateTime(2020, 1, 1);
      this.cash = 100000.0;
    }
  }
}
