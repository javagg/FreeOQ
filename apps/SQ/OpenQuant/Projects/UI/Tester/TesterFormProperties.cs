// Type: OpenQuant.Projects.UI.Tester.TesterFormProperties
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Testing;
using SmartQuant.Testing.TesterItems;
using System.ComponentModel;

namespace OpenQuant.Projects.UI.Tester
{
  public class TesterFormProperties
  {
    protected LiveTester tester;
    protected StatisticsViewerContainer singleContainer;
    protected StatisticsViewerContainer roundTripsContainer;
    protected bool followChanges;
    protected bool allowRoundTrips;
    protected TimeIntervalSize timeInterval;
    protected TesterItemList components;
    protected bool singleEnabled;
    protected bool chartEnabled;
    protected bool performanceAnalysisEnabled;
    protected bool riskAnalysisEnabled;
    protected bool rollingStatisticsEnabled;
    protected bool statisticsStatisticsEnabled;
    protected bool dailyStatisticsEnabled;
    protected bool monthlyStatisticsEnabled;
    protected bool annualStatisticsEnabled;
    protected bool roundTripsEnabled;
    protected bool roundTripsStatisticsEnabled;
    protected bool durationStatisticsEnabled;
    protected bool roundTripListEnabled;
    protected bool longRoundTripListEnabled;
    protected bool shortRoundTripListEnabled;

    [Category("Tester")]
    public bool FollowChanges
    {
      get
      {
        return this.followChanges;
      }
      set
      {
        this.followChanges = value;
        this.tester.FollowChanges = value;
      }
    }

    [Category("Tester")]
    public bool AllowRoundTrips
    {
      get
      {
        return this.allowRoundTrips;
      }
      set
      {
        this.allowRoundTrips = value;
        this.tester.AllowRoundTrips = value;
      }
    }

    [Category("Tester")]
    public TesterItemList Components
    {
      get
      {
        return this.components;
      }
      set
      {
        this.components = value;
        this.tester.Components = value;
      }
    }

    [Category("Tester")]
    public TimeIntervalSize TimeInterval
    {
      get
      {
        return this.timeInterval;
      }
      set
      {
        this.timeInterval = value;
        this.tester.TimeInterval = value;
      }
    }

    [Category("Viewers")]
    [Browsable(false)]
    [Description("Single viewer pages enabled")]
    public bool SingleEnabled
    {
      get
      {
        return this.singleEnabled;
      }
      set
      {
        this.singleEnabled = value;
        foreach (StatisticViewer statisticViewer in this.singleContainer.StatisticsViewers)
          statisticViewer.UpdateEnabled = value;
      }
    }

    [Description("Chart page enabled")]
    [Browsable(false)]
    [Category("Single Viewers")]
    public bool ChartPageEnabled
    {
      get
      {
        return this.chartEnabled;
      }
      set
      {
        this.chartEnabled = value;
        (this.singleContainer.StatisticsViewers[0] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("Single Viewers")]
    [Description("Performance Analysis page enabled")]
    public bool PerformanceAnalysisPageEnabled
    {
      get
      {
        return this.performanceAnalysisEnabled;
      }
      set
      {
        this.performanceAnalysisEnabled = value;
        (this.singleContainer.StatisticsViewers[1] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Description("Risk Analysis page enabled")]
    [Category("Single Viewers")]
    public bool RiskAnalysisPageEnabled
    {
      get
      {
        return this.riskAnalysisEnabled;
      }
      set
      {
        this.riskAnalysisEnabled = value;
        (this.singleContainer.StatisticsViewers[2] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("Single Viewers")]
    [Description("Rolling Statistics page enabled")]
    public bool RollingStatisticsPageEnabled
    {
      get
      {
        return this.rollingStatisticsEnabled;
      }
      set
      {
        this.rollingStatisticsEnabled = value;
        (this.singleContainer.StatisticsViewers[3] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Description("Statistics page enabled")]
    [Category("Single Viewers")]
    public bool StatisticsPageEnabled
    {
      get
      {
        return this.statisticsStatisticsEnabled;
      }
      set
      {
        this.statisticsStatisticsEnabled = value;
        (this.singleContainer.StatisticsViewers[4] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("Single Viewers")]
    [Description("Daily page enabled")]
    public bool DailyPageEnabled
    {
      get
      {
        return this.dailyStatisticsEnabled;
      }
      set
      {
        this.dailyStatisticsEnabled = value;
        (this.singleContainer.StatisticsViewers[5] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("Single Viewers")]
    [Description("Monthly page enabled")]
    public bool MonthlyPageEnabled
    {
      get
      {
        return this.monthlyStatisticsEnabled;
      }
      set
      {
        this.monthlyStatisticsEnabled = value;
        (this.singleContainer.StatisticsViewers[6] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("Single Viewers")]
    [Description("Annual page enabled")]
    public bool AnnualPageEnabled
    {
      get
      {
        return this.annualStatisticsEnabled;
      }
      set
      {
        this.annualStatisticsEnabled = value;
        (this.singleContainer.StatisticsViewers[7] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("Viewers")]
    [Browsable(false)]
    [Description("RoundTrips viewer pages enabled")]
    public bool RoundTripsEnabled
    {
      get
      {
        return this.roundTripsEnabled;
      }
      set
      {
        this.roundTripsEnabled = value;
        foreach (StatisticViewer statisticViewer in this.roundTripsContainer.StatisticsViewers)
          statisticViewer.UpdateEnabled = value;
      }
    }

    [Description("RoundTrips Statistics page enabled")]
    [Category("RoundTrips Viewers")]
    public bool RoundTripsStatisticsPageEnabled
    {
      get
      {
        return this.roundTripsStatisticsEnabled;
      }
      set
      {
        this.roundTripsStatisticsEnabled = value;
        (this.roundTripsContainer.StatisticsViewers[0] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Description("Duration Statistics page enabled")]
    [Category("RoundTrips Viewers")]
    public bool DurationStatisticsPageEnabled
    {
      get
      {
        return this.durationStatisticsEnabled;
      }
      set
      {
        this.durationStatisticsEnabled = value;
        (this.roundTripsContainer.StatisticsViewers[1] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Category("RoundTrips Viewers")]
    [Description("RoundTrips page enabled")]
    public bool RoundTripListPageEnabled
    {
      get
      {
        return this.roundTripListEnabled;
      }
      set
      {
        this.roundTripListEnabled = value;
        (this.roundTripsContainer.StatisticsViewers[2] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Description("Long RoundTrips page enabled")]
    [Category("RoundTrips Viewers")]
    public bool LongRoundTripListPageEnabled
    {
      get
      {
        return this.longRoundTripListEnabled;
      }
      set
      {
        this.longRoundTripListEnabled = value;
        (this.roundTripsContainer.StatisticsViewers[3] as StatisticViewer).UpdateEnabled = value;
      }
    }

    [Description("Short RoundTrips page enabled")]
    [Category("RoundTrips Viewers")]
    public bool ShortRoundTripListPageEnabled
    {
      get
      {
        return this.shortRoundTripListEnabled;
      }
      set
      {
        this.shortRoundTripListEnabled = value;
        (this.roundTripsContainer.StatisticsViewers[4] as StatisticViewer).UpdateEnabled = value;
      }
    }

    public TesterFormProperties(LiveTester tester, StatisticsViewerContainer singleContainer, StatisticsViewerContainer roundTripsContainer)
    {
      this.tester = tester;
      this.singleContainer = singleContainer;
      this.roundTripsContainer = roundTripsContainer;
      this.followChanges = tester.FollowChanges;
      this.components = tester.Components;
      this.allowRoundTrips = tester.AllowRoundTrips;
      this.timeInterval = tester.TimeInterval;
      this.singleEnabled = true;
      this.chartEnabled = (singleContainer.StatisticsViewers[0] as StatisticViewer).UpdateEnabled;
      this.performanceAnalysisEnabled = (singleContainer.StatisticsViewers[1] as StatisticViewer).UpdateEnabled;
      this.riskAnalysisEnabled = (singleContainer.StatisticsViewers[2] as StatisticViewer).UpdateEnabled;
      this.rollingStatisticsEnabled = (singleContainer.StatisticsViewers[3] as StatisticViewer).UpdateEnabled;
      this.statisticsStatisticsEnabled = (singleContainer.StatisticsViewers[4] as StatisticViewer).UpdateEnabled;
      this.dailyStatisticsEnabled = (singleContainer.StatisticsViewers[5] as StatisticViewer).UpdateEnabled;
      this.monthlyStatisticsEnabled = (singleContainer.StatisticsViewers[6] as StatisticViewer).UpdateEnabled;
      this.annualStatisticsEnabled = (singleContainer.StatisticsViewers[7] as StatisticViewer).UpdateEnabled;
      this.roundTripsEnabled = true;
      this.roundTripsStatisticsEnabled = (roundTripsContainer.StatisticsViewers[0] as StatisticViewer).UpdateEnabled;
      this.durationStatisticsEnabled = (roundTripsContainer.StatisticsViewers[1] as StatisticViewer).UpdateEnabled;
      this.roundTripListEnabled = (roundTripsContainer.StatisticsViewers[2] as StatisticViewer).UpdateEnabled;
      this.longRoundTripListEnabled = (roundTripsContainer.StatisticsViewers[3] as StatisticViewer).UpdateEnabled;
      this.shortRoundTripListEnabled = (roundTripsContainer.StatisticsViewers[4] as StatisticViewer).UpdateEnabled;
    }
  }
}
