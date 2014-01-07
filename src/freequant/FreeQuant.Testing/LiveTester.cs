using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using iA35u4dCToxkZX7vHa;
using FreeQuant;
using FreeQuant.Business;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Series;
using FreeQuant.Testing.MathStatistics;
using FreeQuant.Testing.Pertrac;
using FreeQuant.Testing.RoundTrips;
using FreeQuant.Testing.RoundTripsStatistics;
using FreeQuant.Testing.TesterItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing
{
  public class LiveTester
  {
    protected TransactionList transactions;
    protected Portfolio portfolio;
    protected TimeIntervalSize timeInterval;
    protected TesterItemList components;
    protected Portfolio tempPortfolio;
    protected RoundTripList roundTripList;
    protected RoundTripList longRoundTripList;
    protected RoundTripList shortRoundTripList;
    protected bool isRoundTripsOnly;
    protected bool allowRoundTrips;
    protected Portfolio benchmark;
    protected LiveTester benchmarkTester;
    protected bool isTested;
    protected bool followChanges;
    protected double pnL;
    protected double wealth;
    protected double drawdown;
    protected double percentDrawdown;
    protected double returnValue;
    protected double cost;
    protected double allocation;
    protected double allocationLong;
    protected double allocationShort;
    protected double currentAccount;
    protected double currentWealth;
    protected double maxPreviousWealth;
    protected DoubleSeries pnLSeries;
    protected DoubleSeries wealthSeries;
    protected DoubleSeries returnSeries;
    protected DoubleSeries drawdownSeries;
    protected DoubleSeries percentDrawdownSeries;
    protected DoubleSeries costSeries;
    protected DoubleSeries allocationSeries;
    protected DoubleSeries allocationLongSeries;
    protected DoubleSeries allocationShortSeries;
    protected bool isAllocationLong;
    protected bool isAllocationShort;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected double initialWealth;
    protected double riskFreeRate;
    protected double totalCost;
    protected bool businessDaysOnly;
    protected bool waitingForStart;
    protected DateTime awaitTime;
    protected ReminderEventHandler awaitHandler;
    protected bool isNewData;
    protected bool connected;
    private Dictionary<Instrument, LiveTester> vOUewuUQI7;
    private TesterSettings jHRedeUy4p;

    public Dictionary<Instrument, LiveTester> FriendlyTesters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vOUewuUQI7;
      }
    }

    [Browsable(false)]
    public RoundTripList RoundTripList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.roundTripList;
      }
    }

    [Browsable(false)]
    public RoundTripList LongRoundTripList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.longRoundTripList;
      }
    }

    [Browsable(false)]
    public RoundTripList ShortRoundTripList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.shortRoundTripList;
      }
    }

    [Editor(typeof (soR9ANwsV4tOMEsHP7), typeof (UITypeEditor))]
    public TesterItemList Components
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.components;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.components = value;
      }
    }

    public bool FollowChanges
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.followChanges;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.followChanges != value)
        {
          if (!this.isTested && value)
          {
            DateTime now = Clock.Now;
            this.Test(now, now, value);
          }
          else if (value)
          {
            DateTime intervalEnd = this.GetIntervalEnd(this.wealthSeries.LastDateTime, this.timeInterval);
            if (intervalEnd != this.awaitTime)
            {
              this.awaitTime = intervalEnd;
              Clock.AddReminder(new ReminderEventHandler(this.JKNyi7SDXu), this.awaitTime, (object) null);
            }
          }
          else
            Clock.RemoveReminder(this.awaitHandler);
        }
        this.followChanges = value;
        this.NENyAxCZF4();
      }
    }

    public bool AllowRoundTrips
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.allowRoundTrips;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.allowRoundTrips = value;
        if (!this.allowRoundTrips)
          return;
        this.isRoundTripsOnly = true;
      }
    }

    [Browsable(false)]
    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.portfolio;
      }
    }

    public TimeIntervalSize TimeInterval
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.timeInterval;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.timeInterval = value;
        this.NENyAxCZF4();
      }
    }

    [Browsable(false)]
    public DateTime FirstDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.firstDate;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.firstDate = value;
      }
    }

    [Browsable(false)]
    public DateTime LastDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lastDate;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.lastDate = value;
      }
    }

    [Browsable(false)]
    public double InitialWealth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.initialWealth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.initialWealth = value;
        this.currentWealth = this.initialWealth;
        this.maxPreviousWealth = this.initialWealth;
        this.currentAccount = this.initialWealth;
      }
    }

    [Browsable(false)]
    public double RiskFreeRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.riskFreeRate;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value == this.riskFreeRate)
          return;
        this.riskFreeRate = value;
      }
    }

    [Browsable(false)]
    public double DailyRiskFreeRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Math.Pow(this.riskFreeRate / 100.0 + 1.0, 0.004) - 1.0) * 100.0;
      }
    }

    [Browsable(false)]
    public bool BusinessDaysOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.businessDaysOnly;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.businessDaysOnly = value;
      }
    }

    [Browsable(false)]
    public int TestDays
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.wealthSeries.Count <= 0)
          return 0;
        int days = (this.wealthSeries.LastDateTime - this.wealthSeries.FirstDateTime).Days;
        if (this.wealthSeries.FirstDateTime.AddDays((double) days) < this.wealthSeries.LastDateTime)
          return days + 1;
        else
          return days;
      }
    }

    [Browsable(false)]
    public int TradeDays
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TestDays - Calendar.GetNWeekends(this.firstDate, this.lastDate);
      }
    }

    [Browsable(false)]
    public double FinalWealth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.wealthSeries.Count > 0)
          return this.wealthSeries[this.wealthSeries.Count - 1];
        else
          return this.initialWealth;
      }
    }

    [Browsable(false)]
    public DoubleSeries AllocationSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.allocationSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries AllocationLongSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.allocationLongSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries AllocationShortSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.allocationShortSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries PnLSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pnLSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries DrawdownSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.drawdownSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries PercentDrawdownSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.percentDrawdownSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries WealthSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wealthSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries CostSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.costSeries;
      }
    }

    [Browsable(false)]
    public DoubleSeries ReturnSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.returnSeries;
      }
    }

    public event TesterEventHandler PnLSeriesValueAdded;

    public event TesterEventHandler WealthSeriesValueAdded;

    public event TesterEventHandler DrawdownSeriesValueAdded;

    public event TesterEventHandler CostSeriesValueAdded;

    public event TesterEventHandler ReturnSeriesValueAdded;

    public event TesterEventHandler AllocationSeriesValueAdded;

    public event TesterEventHandler AllocationLongSeriesValueAdded;

    public event TesterEventHandler AllocationShortSeriesValueAdded;

    public event TesterItemEventHandler ComponentChanged;

    public event TesterComponentNameEventHandler ComponentNameChanged;

    public event EventHandler ComponentListChanged;

    public event TesterItemEventHandler ComponentEnabledChanged;

    public event EventHandler Changed;

    public event TesterEventHandler StatisticChanged;

    public event TesterEventHandler RoundTripStatisticChanged;

    public event TesterEventHandler RoundTripsFinished;

    public event TesterEventHandler Reseted;

    internal event TesterEventHandler Osxy2s5d69;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LiveTester(Portfolio portfolio)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      this.allowRoundTrips = true;
      this.vOUewuUQI7 = new Dictionary<Instrument, LiveTester>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.firstDate = new DateTime(0L);
      this.lastDate = new DateTime(0L);
      this.portfolio = portfolio;
      this.transactions = portfolio.Transactions;
      this.C9hyoGWxUi();
      this.Q6By9VekEl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void C9hyoGWxUi()
    {
      this.tempPortfolio = new Portfolio();
      this.tempPortfolio.Performance.Enabled = false;
      this.timeInterval = TimeIntervalSize.day1;
      this.wealthSeries = new DoubleSeries();
      this.drawdownSeries = new DoubleSeries();
      this.percentDrawdownSeries = new DoubleSeries();
      this.costSeries = new DoubleSeries();
      this.pnLSeries = new DoubleSeries();
      this.returnSeries = new DoubleSeries();
      this.allocationSeries = new DoubleSeries();
      this.allocationLongSeries = new DoubleSeries();
      this.allocationShortSeries = new DoubleSeries();
      this.roundTripList = new RoundTripList(this);
      this.longRoundTripList = new RoundTripList(this);
      this.shortRoundTripList = new RoundTripList(this);
      this.isRoundTripsOnly = this.allowRoundTrips;
      this.pnLSeries.Title = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2854);
      this.wealthSeries.Title = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2864);
      this.drawdownSeries.Title = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2880);
      this.percentDrawdownSeries.Title = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2900);
      this.costSeries.Title = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2936);
      this.returnSeries.Title = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2974);
      this.pnLSeries.Name = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2990);
      this.wealthSeries.Name = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3000);
      this.drawdownSeries.Name = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3016);
      this.percentDrawdownSeries.Name = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3036);
      this.costSeries.Name = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3072);
      this.returnSeries.Name = s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3110);
      this.components = new TesterItemList();
      this.components.ComponentListChanged += new EventHandler(this.GvwyC63XLV);
      this.InitialWealth = -1.0;
      this.riskFreeRate = 0.0;
      this.businessDaysOnly = true;
      this.totalCost = 0.0;
      SimpleSeriesItem simpleSeriesItem1 = new SimpleSeriesItem(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3126), this.wealthSeries);
      SimpleSeriesItem simpleSeriesItem2 = new SimpleSeriesItem(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3142), this.drawdownSeries);
      SimpleSeriesItem simpleSeriesItem3 = new SimpleSeriesItem(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3162), this.percentDrawdownSeries);
      SimpleSeriesItem simpleSeriesItem4 = new SimpleSeriesItem(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3198), this.costSeries);
      SimpleSeriesItem simpleSeriesItem5 = new SimpleSeriesItem(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3210), this.pnLSeries);
      SimpleSeriesItem simpleSeriesItem6 = new SimpleSeriesItem(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3220), this.returnSeries);
      this.AddComponent((TesterItem) simpleSeriesItem1);
      this.AddComponent((TesterItem) simpleSeriesItem2);
      this.AddComponent((TesterItem) simpleSeriesItem3);
      this.AddComponent((TesterItem) simpleSeriesItem4);
      this.AddComponent((TesterItem) simpleSeriesItem5);
      this.AddComponent((TesterItem) simpleSeriesItem6);
      this.iLayprxSnG();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iLayprxSnG()
    {
      SimpleSeriesItem simpleSeriesItem1 = this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3236)] as SimpleSeriesItem;
      SimpleSeriesItem simpleSeriesItem2 = this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3252)] as SimpleSeriesItem;
      SimpleSeriesItem simpleSeriesItem3 = this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3272)] as SimpleSeriesItem;
      SimpleSeriesItem simpleSeriesItem4 = this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3308)] as SimpleSeriesItem;
      SimpleSeriesItem simpleSeriesItem5 = this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3320)] as SimpleSeriesItem;
      SimpleSeriesItem simpleSeriesItem6 = this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3330)] as SimpleSeriesItem;
      SimpleMonthlySeries simpleMonthlySeries = new SimpleMonthlySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3346), (SeriesTesterItem) simpleSeriesItem1);
      SimpleAnnualSeries simpleAnnualSeries = new SimpleAnnualSeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3388), (SeriesTesterItem) simpleSeriesItem1);
      SimpleDailySeries simpleDailySeries = new SimpleDailySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3428), (SeriesTesterItem) simpleSeriesItem1);
      this.AddComponent((TesterItem) simpleMonthlySeries);
      this.AddComponent((TesterItem) simpleAnnualSeries);
      this.AddComponent((TesterItem) simpleDailySeries);
      Return return1 = new Return(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3466), (SeriesTesterItem) simpleDailySeries);
      Return return2 = new Return(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3504), (SeriesTesterItem) simpleMonthlySeries);
      Return return3 = new Return(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3546), (SeriesTesterItem) simpleAnnualSeries);
      this.AddComponent((TesterItem) return1);
      this.AddComponent((TesterItem) return2);
      this.AddComponent((TesterItem) return3);
      this.AddComponent((TesterItem) new Median(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3586), (SeriesTesterItem) simpleSeriesItem2));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3620), (SeriesTesterItem) simpleSeriesItem2));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3656), (SeriesTesterItem) return3));
      this.AddComponent((TesterItem) new Median(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3710), (SeriesTesterItem) return3));
      this.AddComponent((TesterItem) new Maximum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3762), (SeriesTesterItem) return3));
      this.AddComponent((TesterItem) new Minimum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3816), (SeriesTesterItem) return3));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3870), (SeriesTesterItem) return1));
      this.AddComponent((TesterItem) new Median(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3922), (SeriesTesterItem) return1));
      this.AddComponent((TesterItem) new Maximum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(3972), (SeriesTesterItem) return1));
      this.AddComponent((TesterItem) new Minimum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4024), (SeriesTesterItem) return1));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4076), (SeriesTesterItem) return2));
      this.AddComponent((TesterItem) new Median(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4132), (SeriesTesterItem) return2));
      this.AddComponent((TesterItem) new Maximum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4186), (SeriesTesterItem) return2));
      this.AddComponent((TesterItem) new Minimum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4242), (SeriesTesterItem) return2));
      this.AddComponent((TesterItem) new SimpleMonthlySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4298), (SeriesTesterItem) simpleSeriesItem2));
      this.AddComponent((TesterItem) new SimpleAnnualSeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4344), (SeriesTesterItem) simpleSeriesItem2));
      this.AddComponent((TesterItem) new SimpleDailySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4388), (SeriesTesterItem) simpleSeriesItem2));
      this.AddComponent((TesterItem) new SimpleMonthlySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4430), (SeriesTesterItem) simpleSeriesItem4));
      this.AddComponent((TesterItem) new SimpleAnnualSeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4468), (SeriesTesterItem) simpleSeriesItem4));
      this.AddComponent((TesterItem) new SimpleDailySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4504), (SeriesTesterItem) simpleSeriesItem4));
      this.AddComponent((TesterItem) new CumulativeMonthlySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4538), (SeriesTesterItem) simpleSeriesItem5));
      this.AddComponent((TesterItem) new CumulativeAnnualSeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4574), (SeriesTesterItem) simpleSeriesItem5));
      this.AddComponent((TesterItem) new CumulativeDailySeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4608), (SeriesTesterItem) simpleSeriesItem5));
      this.AddComponent((TesterItem) new InitialWealth(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4640), this));
      this.AddComponent((TesterItem) new FinalWealth(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4670), this));
      this.AddComponent((TesterItem) new TradeDays(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4696), this));
      this.AddComponent((TesterItem) new TotalDays(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4718), this));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4740), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new GainDays(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4780), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new LossDays(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4800), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new PositiveSeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4820), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new NegativeSeries(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4864), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4908), this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4944)] as SeriesTesterItem));
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(4988), this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5024)] as SeriesTesterItem));
      this.AddComponent((TesterItem) new StandardDeviation(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5068), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new GainStandardDeviation(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5106), this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5152)] as SeriesTesterItem));
      this.AddComponent((TesterItem) new LossStandardDeviation(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5196), this.Components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5242)] as SeriesTesterItem));
      this.AddComponent((TesterItem) new CompoundAverageReturn(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5286), (SeriesTesterItem) return3));
      this.AddComponent((TesterItem) new Skewness(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5332), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new Kurtosis(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5352), (SeriesTesterItem) simpleSeriesItem6));
      this.AddComponent((TesterItem) new SharpeRatio(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5372), (SeriesTesterItem) simpleSeriesItem6, this.RiskFreeRate));
      this.AddComponent((TesterItem) new VaR(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5398), (SeriesTesterItem) simpleSeriesItem5, 95.0));
      this.AddComponent((TesterItem) new VaR(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5412), (SeriesTesterItem) simpleSeriesItem5, 99.0));
      this.ALwyG0kIYg(TimeIntervalSize.year1, TimeIntervalSize.month3);
      this.ALwyG0kIYg(TimeIntervalSize.year1, TimeIntervalSize.month6);
      this.ALwyG0kIYg(TimeIntervalSize.year1, TimeIntervalSize.month9);
      this.ALwyG0kIYg(TimeIntervalSize.year1, TimeIntervalSize.year1);
      this.ALwyG0kIYg(TimeIntervalSize.year1, TimeIntervalSize.year2);
      this.ALwyG0kIYg(TimeIntervalSize.month1, TimeIntervalSize.month3);
      this.ALwyG0kIYg(TimeIntervalSize.month1, TimeIntervalSize.month6);
      this.ALwyG0kIYg(TimeIntervalSize.month1, TimeIntervalSize.month9);
      this.ALwyG0kIYg(TimeIntervalSize.month1, TimeIntervalSize.year1);
      this.ALwyG0kIYg(TimeIntervalSize.month1, TimeIntervalSize.year2);
      this.ALwyG0kIYg(TimeIntervalSize.week1, TimeIntervalSize.month3);
      this.ALwyG0kIYg(TimeIntervalSize.week1, TimeIntervalSize.month6);
      this.ALwyG0kIYg(TimeIntervalSize.week1, TimeIntervalSize.month9);
      this.ALwyG0kIYg(TimeIntervalSize.week1, TimeIntervalSize.year1);
      this.ALwyG0kIYg(TimeIntervalSize.week1, TimeIntervalSize.year2);
      this.ALwyG0kIYg(TimeIntervalSize.day1, TimeIntervalSize.month3);
      this.ALwyG0kIYg(TimeIntervalSize.day1, TimeIntervalSize.month6);
      this.ALwyG0kIYg(TimeIntervalSize.day1, TimeIntervalSize.month9);
      this.ALwyG0kIYg(TimeIntervalSize.day1, TimeIntervalSize.year1);
      this.ALwyG0kIYg(TimeIntervalSize.day1, TimeIntervalSize.year2);
      Minimum minimum = new Minimum(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5426), (SeriesTesterItem) simpleSeriesItem3);
      this.AddComponent((TesterItem) minimum);
      this.AddComponent((TesterItem) new MARRatio(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5462), (SeriesTesterItem) return3, (SeriesTesterItem) minimum));
      this.AddComponent((TesterItem) new ModifiedSharpeRatio(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5484), (SeriesTesterItem) return2));
      this.AddComponent((TesterItem) new SotrinoRatio(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5530), (SeriesTesterItem) return1, 0.05));
      this.FgQyY8DxsR(this.roundTripList, "");
      this.FgQyY8DxsR(this.longRoundTripList, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5560));
      this.FgQyY8DxsR(this.shortRoundTripList, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5578));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ALwyG0kIYg([In] TimeIntervalSize obj0, [In] TimeIntervalSize obj1)
    {
      SimpleSeriesItem simpleSeriesItem = this.components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5598)] as SimpleSeriesItem;
      PercentageOfProfitableForPeriod profitableForPeriod;
      if (this.components.Contains(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5614) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5682) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5700)))
      {
        profitableForPeriod = this.components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5706) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5774) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5792)] as PercentageOfProfitableForPeriod;
      }
      else
      {
        profitableForPeriod = new PercentageOfProfitableForPeriod(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5798) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5866) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5884), (SeriesTesterItem) simpleSeriesItem, obj0, obj1);
        this.AddComponent((TesterItem) profitableForPeriod);
      }
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5890) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5944) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5988), (SeriesTesterItem) profitableForPeriod));
      ReturnForPeriod returnForPeriod;
      if (this.components.Contains(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(5994) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6030) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6048)))
      {
        returnForPeriod = this.components[s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6054) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6090) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6108)] as ReturnForPeriod;
      }
      else
      {
        returnForPeriod = new ReturnForPeriod(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6114) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6150) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6168), (SeriesTesterItem) simpleSeriesItem, obj0, obj1);
        this.AddComponent((TesterItem) returnForPeriod);
      }
      this.AddComponent((TesterItem) new Average(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6174) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6228) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6270), (SeriesTesterItem) returnForPeriod));
      this.AddComponent((TesterItem) new Median(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6276) + ((object) obj1).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6328) + ((object) obj0).ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6370), (SeriesTesterItem) returnForPeriod));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FgQyY8DxsR([In] RoundTripList obj0, [In] string obj1)
    {
      WinningRoundTrips winningRoundTrips = new WinningRoundTrips(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6376));
      this.AddComponent((TesterItem) winningRoundTrips);
      LosingRoundTrips losingRoundTrips = new LosingRoundTrips(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6436));
      this.AddComponent((TesterItem) losingRoundTrips);
      NumberOfRoundTrips numberOfRoundTrips = new NumberOfRoundTrips(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6494));
      this.AddComponent((TesterItem) numberOfRoundTrips);
      this.AddComponent((TesterItem) new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6538), (SeriesTesterItem) winningRoundTrips, (SeriesTesterItem) numberOfRoundTrips, (SeriesTesterItem) numberOfRoundTrips));
      AllRoundTripsTotalPnL roundTripsTotalPnL1 = new AllRoundTripsTotalPnL(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6592));
      this.AddComponent((TesterItem) roundTripsTotalPnL1);
      WinningRoundTripsTotalPnL roundTripsTotalPnL2 = new WinningRoundTripsTotalPnL(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6650));
      this.AddComponent((TesterItem) roundTripsTotalPnL2);
      LosingRoundTripsTotalPnL roundTripsTotalPnL3 = new LosingRoundTripsTotalPnL(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6716));
      this.AddComponent((TesterItem) roundTripsTotalPnL3);
      this.AddComponent((TesterItem) new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6780), (SeriesTesterItem) roundTripsTotalPnL2, (SeriesTesterItem) winningRoundTrips, (SeriesTesterItem) winningRoundTrips));
      this.AddComponent((TesterItem) new LargestWinningRoundTrip(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6832)));
      this.AddComponent((TesterItem) new LargestLosingRoundTrip(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6886)));
      Division division1 = new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6938), (SeriesTesterItem) roundTripsTotalPnL2, (SeriesTesterItem) winningRoundTrips, (SeriesTesterItem) roundTripsTotalPnL2);
      this.AddComponent((TesterItem) division1);
      Division division2 = new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(6992), (SeriesTesterItem) roundTripsTotalPnL3, (SeriesTesterItem) losingRoundTrips, (SeriesTesterItem) roundTripsTotalPnL3);
      this.AddComponent((TesterItem) division2);
      this.AddComponent((TesterItem) new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7044), (SeriesTesterItem) roundTripsTotalPnL1, (SeriesTesterItem) numberOfRoundTrips, (SeriesTesterItem) roundTripsTotalPnL1));
      this.AddComponent((TesterItem) new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7082), (SeriesTesterItem) division1, (SeriesTesterItem) division2, (SeriesTesterItem) roundTripsTotalPnL1, -1.0));
      this.AddComponent((TesterItem) new Division(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7138), (SeriesTesterItem) roundTripsTotalPnL2, (SeriesTesterItem) roundTripsTotalPnL3, (SeriesTesterItem) roundTripsTotalPnL1, -1.0));
      this.AddComponent((TesterItem) new OpenRoundTripValue(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7168)));
      ConsecutiveWinners consecutiveWinners = new ConsecutiveWinners(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7214));
      this.AddComponent((TesterItem) consecutiveWinners);
      this.AddComponent((TesterItem) new Maximum(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7256), (SeriesTesterItem) consecutiveWinners));
      ConsecutiveLosers consecutiveLosers = new ConsecutiveLosers(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7314));
      this.AddComponent((TesterItem) consecutiveLosers);
      this.AddComponent((TesterItem) new Maximum(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7354), (SeriesTesterItem) consecutiveLosers));
      RoundTripsDuration roundTripsDuration1 = new RoundTripsDuration(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7410));
      this.AddComponent((TesterItem) roundTripsDuration1);
      this.AddComponent((TesterItem) new Average(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7466), (SeriesTesterItem) roundTripsDuration1));
      WinningRoundTripsDuration roundTripsDuration2 = new WinningRoundTripsDuration(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7530));
      this.AddComponent((TesterItem) roundTripsDuration2);
      this.AddComponent((TesterItem) new Average(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7602), (SeriesTesterItem) roundTripsDuration2));
      this.AddComponent((TesterItem) new Median(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7682), (SeriesTesterItem) roundTripsDuration2));
      this.AddComponent((TesterItem) new Maximum(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7760), (SeriesTesterItem) roundTripsDuration2));
      this.AddComponent((TesterItem) new Minimum(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7840), (SeriesTesterItem) roundTripsDuration2));
      LosingRoundTripsDuration roundTripsDuration3 = new LosingRoundTripsDuration(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7920));
      this.AddComponent((TesterItem) roundTripsDuration3);
      this.AddComponent((TesterItem) new Average(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(7990), (SeriesTesterItem) roundTripsDuration3));
      this.AddComponent((TesterItem) new Median(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8068), (SeriesTesterItem) roundTripsDuration3));
      this.AddComponent((TesterItem) new Maximum(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8144), (SeriesTesterItem) roundTripsDuration3));
      this.AddComponent((TesterItem) new Minimum(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8222), (SeriesTesterItem) roundTripsDuration3));
      TotalRoundTripsEfficiency roundTripsEfficiency = new TotalRoundTripsEfficiency(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8300));
      this.AddComponent((TesterItem) roundTripsEfficiency);
      this.AddComponent((TesterItem) new Average(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8366), (SeriesTesterItem) roundTripsEfficiency));
      RoundTripsEntryEfficiency tripsEntryEfficiency = new RoundTripsEntryEfficiency(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8418));
      this.AddComponent((TesterItem) tripsEntryEfficiency);
      this.AddComponent((TesterItem) new Average(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8484), (SeriesTesterItem) tripsEntryEfficiency));
      RoundTripsExitEfficiency tripsExitEfficiency = new RoundTripsExitEfficiency(obj0, obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8536));
      this.AddComponent((TesterItem) tripsExitEfficiency);
      this.AddComponent((TesterItem) new Average(obj1 + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8600), (SeriesTesterItem) tripsExitEfficiency));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Q6By9VekEl()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetParameters()
    {
      this.pnL = 0.0;
      this.wealth = 0.0;
      this.drawdown = 0.0;
      this.percentDrawdown = 0.0;
      this.cost = 0.0;
      this.totalCost = 0.0;
      this.returnValue = 0.0;
      this.allocation = 0.0;
      this.allocationLong = 0.0;
      this.allocationShort = 0.0;
      this.isAllocationLong = false;
      this.isAllocationShort = false;
      this.InitialWealth = -1.0;
      this.awaitTime = DateTime.MinValue;
      this.firstDate = DateTime.MinValue;
      this.lastDate = DateTime.MinValue;
      this.isRoundTripsOnly = this.allowRoundTrips;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset()
    {
      this.isTested = false;
      this.tempPortfolio.Clear();
      this.wealthSeries.Clear();
      this.pnLSeries.Clear();
      this.drawdownSeries.Clear();
      this.percentDrawdownSeries.Clear();
      this.costSeries.Clear();
      this.returnSeries.Clear();
      this.roundTripList.Clear();
      this.shortRoundTripList.Clear();
      this.longRoundTripList.Clear();
      this.ResetParameters();
      if (this.connected)
        this.waitingForStart = true;
      foreach (TesterItem testerItem in this.components)
        testerItem.Reset();
      this.EmitReseted();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect()
    {
      this.Connect(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect(bool connectStatistics)
    {
      lock (this)
      {
        this.portfolio.TransactionAdded += new TransactionEventHandler(this.o38yaR1giJ);
        this.portfolio.Cleared += new EventHandler(this.RCnyHI5vxH);
        this.portfolio.ValueChanged += new PositionEventHandler(this.WM4yuesikn);
        this.portfolio.Account.AccountChanged += new EventHandler(this.ER6yOMtUyy);
        this.roundTripList.Connect();
        this.longRoundTripList.Connect();
        this.shortRoundTripList.Connect();
        foreach (TesterItem item_0 in this.components)
        {
          if (connectStatistics)
            item_0.Connect();
          item_0.PropertyChanged += new TesterItemEventHandler(this.YJRyNuAZek);
          item_0.ComponentNameChanged += new TesterComponentNameEventHandler(this.zLlySFoeEa);
          if (item_0 is SeriesTesterItem)
            (item_0 as SeriesTesterItem).ComponentEnabledChanged += new EventHandler(this.gFyyncG26J);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect(bool disconnectStatistics)
    {
      lock (this)
      {
        this.DisconnectPorftolio();
        this.portfolio.TransactionAdded -= new TransactionEventHandler(this.o38yaR1giJ);
        this.portfolio.Cleared -= new EventHandler(this.RCnyHI5vxH);
        this.portfolio.ValueChanged -= new PositionEventHandler(this.WM4yuesikn);
        this.portfolio.Account.AccountChanged -= new EventHandler(this.ER6yOMtUyy);
        Clock.RemoveReminder(this.awaitHandler);
        this.roundTripList.Disconnect();
        this.longRoundTripList.Disconnect();
        this.shortRoundTripList.Disconnect();
        foreach (TesterItem item_0 in this.components)
        {
          if (disconnectStatistics)
            item_0.Disconnect();
          item_0.PropertyChanged -= new TesterItemEventHandler(this.YJRyNuAZek);
          item_0.ComponentNameChanged -= new TesterComponentNameEventHandler(this.zLlySFoeEa);
          if (item_0 is SeriesTesterItem)
            (item_0 as SeriesTesterItem).ComponentEnabledChanged -= new EventHandler(this.gFyyncG26J);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect()
    {
      this.Disconnect(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisconnectPorftolio()
    {
      this.tempPortfolio.Monitored = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetIntervalEnd(DateTime dateTime, TimeIntervalSize intervalSize)
    {
      DateTime dateTime1;
      switch (intervalSize)
      {
        case TimeIntervalSize.year5:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (4 - dateTime.Year % 5));
          break;
        case TimeIntervalSize.year10:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (9 - dateTime.Year % 10));
          break;
        case TimeIntervalSize.year20:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (19 - dateTime.Year % 20));
          break;
        case TimeIntervalSize.year3:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (2 - dateTime.Year % 3));
          break;
        case TimeIntervalSize.year4:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (3 - dateTime.Year % 4));
          break;
        case TimeIntervalSize.year1:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1);
          break;
        case TimeIntervalSize.year2:
          dateTime1 = new DateTime(dateTime.Year, 1, 1).AddYears(1 + (1 - dateTime.Year % 2));
          break;
        case TimeIntervalSize.month4:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 4);
          break;
        case TimeIntervalSize.month6:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 6);
          break;
        case TimeIntervalSize.month1:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1);
          break;
        case TimeIntervalSize.month2:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + dateTime.Month % 2);
          break;
        case TimeIntervalSize.month3:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 3);
          break;
        case TimeIntervalSize.week1:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(8.0 - (double) dateTime.DayOfWeek);
          break;
        case TimeIntervalSize.week2:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(8.0 - (double) dateTime.DayOfWeek + (double) (7 * (1 - (int) Math.Floor(new TimeSpan(dateTime.AddDays(8.0 - (double) dateTime.DayOfWeek).Ticks).TotalDays) / 7 % 2)));
          break;
        case TimeIntervalSize.day3:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (1 + (2 - (int) new TimeSpan(dateTime.Ticks).TotalDays % 3)));
          break;
        case TimeIntervalSize.day5:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (1 + (4 - (int) new TimeSpan(dateTime.Ticks).TotalDays % 5)));
          break;
        case TimeIntervalSize.day1:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0);
          break;
        case TimeIntervalSize.day2:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (1 + (int) new TimeSpan(dateTime.Ticks).TotalDays % 2));
          break;
        case TimeIntervalSize.hour4:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double) (1 + (3 - (int) new TimeSpan(dateTime.Ticks).TotalHours % 4)));
          break;
        case TimeIntervalSize.hour6:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double) (1 + (5 - (int) new TimeSpan(dateTime.Ticks).TotalHours % 6)));
          break;
        case TimeIntervalSize.hour12:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double) (1 + (11 - (int) new TimeSpan(dateTime.Ticks).TotalHours % 12)));
          break;
        case TimeIntervalSize.hour2:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double) (1 + (1 - (int) new TimeSpan(dateTime.Ticks).TotalHours % 2)));
          break;
        case TimeIntervalSize.hour3:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double) (1 + (2 - (int) new TimeSpan(dateTime.Ticks).TotalHours % 3)));
          break;
        case TimeIntervalSize.min30:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double) (1 + (29 - (int) new TimeSpan(dateTime.Ticks).TotalMinutes % 30)));
          break;
        case TimeIntervalSize.hour1:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours(1.0);
          break;
        case TimeIntervalSize.min15:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double) (1 + (14 - (int) new TimeSpan(dateTime.Ticks).TotalMinutes % 15)));
          break;
        case TimeIntervalSize.min20:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double) (1 + (19 - (int) new TimeSpan(dateTime.Ticks).TotalMinutes % 20)));
          break;
        case TimeIntervalSize.min1:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes(1.0);
          break;
        case TimeIntervalSize.min5:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double) (1 + (4 - (int) new TimeSpan(dateTime.Ticks).TotalMinutes % 5)));
          break;
        case TimeIntervalSize.min10:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double) (1 + (9 - (int) new TimeSpan(dateTime.Ticks).TotalMinutes % 10)));
          break;
        case TimeIntervalSize.sec20:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double) (1 + (19 - (int) new TimeSpan(dateTime.Ticks).TotalSeconds % 20)));
          break;
        case TimeIntervalSize.sec30:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double) (1 + (29 - (int) new TimeSpan(dateTime.Ticks).TotalSeconds % 30)));
          break;
        case TimeIntervalSize.sec5:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double) (1 + (4 - (int) new TimeSpan(dateTime.Ticks).TotalSeconds % 5)));
          break;
        case TimeIntervalSize.sec10:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double) (1 + (9 - (int) new TimeSpan(dateTime.Ticks).TotalSeconds % 10)));
          break;
        case TimeIntervalSize.sec1:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds(1.0);
          break;
        case TimeIntervalSize.sec2:
          dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second).AddSeconds((double) (1 + (1 - (int) new TimeSpan(dateTime.Ticks).TotalSeconds % 2)));
          break;
        default:
          dateTime1 = dateTime.AddTicks((long) intervalSize);
          break;
      }
      return dateTime1.AddTicks(-1L);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime AddInterval(DateTime dateTime, TimeIntervalSize intervalSize)
    {
      DateTime dateTime1;
      switch (intervalSize)
      {
        case TimeIntervalSize.year5:
          dateTime1 = dateTime.AddYears(5);
          break;
        case TimeIntervalSize.year10:
          dateTime1 = dateTime.AddYears(10);
          break;
        case TimeIntervalSize.year20:
          dateTime1 = dateTime.AddYears(20);
          break;
        case TimeIntervalSize.year2:
          dateTime1 = dateTime.AddYears(2);
          break;
        case TimeIntervalSize.year3:
          dateTime1 = dateTime.AddYears(3);
          break;
        case TimeIntervalSize.year4:
          dateTime1 = dateTime.AddYears(4);
          break;
        case TimeIntervalSize.month4:
          dateTime1 = dateTime.AddMonths(4);
          break;
        case TimeIntervalSize.month6:
          dateTime1 = dateTime.AddMonths(6);
          break;
        case TimeIntervalSize.year1:
          dateTime1 = dateTime.AddYears(1);
          break;
        case TimeIntervalSize.month1:
          dateTime1 = dateTime.AddMonths(1);
          break;
        case TimeIntervalSize.month2:
          dateTime1 = dateTime.AddMonths(2);
          break;
        case TimeIntervalSize.month3:
          dateTime1 = dateTime.AddMonths(3);
          break;
        default:
          dateTime1 = dateTime.AddTicks((long) intervalSize);
          break;
      }
      return dateTime1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ER6yOMtUyy([In] object obj0, [In] EventArgs obj1)
    {
      if (this.initialWealth != -1.0)
        return;
      this.InitialWealth = this.portfolio.Account.GetValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void o38yaR1giJ([In] object obj0, [In] TransactionEventArgs obj1)
    {
      lock (this)
      {
        if (!this.followChanges)
          return;
        this.tempPortfolio.Add(obj1.Transaction);
        this.tempPortfolio.Monitored = true;
        switch (obj1.Transaction.Side)
        {
          case Side.Buy:
            this.currentAccount -= FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocation += FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocationLong += FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.isAllocationLong = true;
            break;
          case Side.Sell:
            this.currentAccount += FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocation -= FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocationLong -= FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.isAllocationLong = true;
            break;
          case Side.BuyMinus:
            this.currentAccount -= FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocation += FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocationShort += FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.isAllocationShort = true;
            break;
          case Side.SellShort:
            this.currentAccount += FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocation -= FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.allocationShort -= FreeQuant.Instruments.Currency.Convert(obj1.Transaction.Value, obj1.Transaction.Currency, this.portfolio.Account.Currency);
            this.isAllocationShort = true;
            break;
        }
        if (this.isRoundTripsOnly)
        {
          if (!this.tempPortfolio.Positions.Contains(obj1.Transaction.Instrument))
          {
            this.roundTripList.CloseOpenRoundTrip(obj1.Transaction.Instrument, obj1.Transaction.Price, obj1.Transaction.DateTime);
            if (obj1.Transaction.Side == Side.Buy)
              this.shortRoundTripList.CloseOpenRoundTrip(obj1.Transaction.Instrument, obj1.Transaction.Price, obj1.Transaction.DateTime);
            else
              this.longRoundTripList.CloseOpenRoundTrip(obj1.Transaction.Instrument, obj1.Transaction.Price, obj1.Transaction.DateTime);
          }
          else if (this.tempPortfolio.Positions[obj1.Transaction.Instrument].Transactions.Count == 1)
          {
            PositionSide local_0 = PositionSide.Short;
            if (obj1.Transaction.Side == Side.Buy)
              local_0 = PositionSide.Long;
            RoundTrip local_1 = new RoundTrip(this.tempPortfolio.Positions[obj1.Transaction.Instrument], obj1.Transaction.Instrument, local_0, obj1.Transaction.Amount, obj1.Transaction.Price, obj1.Transaction.Price, obj1.Transaction.DateTime, obj1.Transaction.DateTime, RoundTripStatus.Opened);
            this.roundTripList.AddOpenRoundTrip(local_1);
            if (obj1.Transaction.Side == Side.Buy)
              this.longRoundTripList.AddOpenRoundTrip(local_1);
            else
              this.shortRoundTripList.AddOpenRoundTrip(local_1);
          }
          else
          {
            this.isRoundTripsOnly = false;
            this.EmitRoundTripsFinished();
          }
        }
        if (this.isRoundTripsOnly)
          this.roundTripList.UpdateOpenRoundTrips();
        this.currentAccount -= obj1.Transaction.Cost;
        this.cost += obj1.Transaction.Cost;
        if (this.isRoundTripsOnly)
        {
          this.EmitRoundTripsUpdated();
          this.EmitRoundTripStatisticChanged();
        }
        if (!this.waitingForStart)
          return;
        this.waitingForStart = false;
        this.awaitTime = this.GetIntervalEnd(obj1.Transaction.DateTime, this.timeInterval);
        this.awaitHandler = new ReminderEventHandler(this.JKNyi7SDXu);
        Clock.AddReminder(this.awaitHandler, this.awaitTime, (object) null);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JKNyi7SDXu([In] ReminderEventArgs obj0)
    {
      lock (this)
      {
        try
        {
          DateTime local_0 = obj0.SignalTime;
          for (DateTime local_1 = Clock.Now; local_0 <= local_1; local_0 = this.AddInterval(local_0, this.timeInterval))
          {
            this.Cndy1I50JO(local_0);
            this.isNewData = false;
          }
          this.awaitTime = local_0;
          this.awaitHandler = new ReminderEventHandler(this.JKNyi7SDXu);
          Clock.AddReminder(this.awaitHandler, this.awaitTime, (object) null);
        }
        catch (Exception exception_0)
        {
          throw exception_0;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cndy1I50JO([In] DateTime obj0)
    {
      if (this.tempPortfolio.Transactions == null || this.tempPortfolio.Transactions.Count == 0)
        return;
      if (this.isAllocationLong || this.isAllocationShort)
      {
        this.allocationSeries.Add(obj0.AddTicks(1L), this.allocation);
        this.EmitAllocationSeriesValueAdded();
      }
      if (this.isAllocationLong)
      {
        this.allocationLongSeries.Add(obj0.AddTicks(1L), this.allocationLong);
        this.EmitAllocationLongSeriesValueAdded();
      }
      if (this.isAllocationShort)
      {
        this.allocationShortSeries.Add(obj0.AddTicks(1L), this.allocationShort);
        this.EmitAllocationShortSeriesValueAdded();
      }
      this.isAllocationLong = false;
      this.isAllocationShort = false;
      if (this.isRoundTripsOnly)
        this.roundTripList.UpdateOpenRoundTrips();
      double val2 = this.currentWealth;
      if (this.wealthSeries.Count > 0)
        val2 = this.wealthSeries[this.wealthSeries.Count - 1];
      this.currentWealth = this.currentAccount + this.tempPortfolio.GetPositionValue();
      this.pnL = this.currentWealth - val2;
      this.maxPreviousWealth = Math.Max(this.maxPreviousWealth, val2);
      this.drawdown = Math.Min(this.currentWealth - this.maxPreviousWealth, 0.0);
      this.percentDrawdown = this.currentWealth / this.maxPreviousWealth - 1.0;
      this.returnValue = (this.currentWealth / val2 - 1.0) * 100.0;
      this.wealthSeries.Add(obj0.AddTicks(1L), this.currentWealth);
      this.drawdownSeries.Add(obj0.AddTicks(1L), this.drawdown);
      this.percentDrawdownSeries.Add(obj0.AddTicks(1L), this.percentDrawdown);
      this.pnLSeries.Add(obj0.AddTicks(1L), this.pnL);
      this.costSeries.Add(obj0.AddTicks(1L), this.cost);
      this.returnSeries.Add(obj0.AddTicks(1L), this.returnValue);
      this.EmitPnLSeriesValueAdded();
      this.EmitWealthSeriesValueAddedd();
      this.EmitDrawdownSeriesValueAdded();
      this.EmitCostSeriesValueAdded();
      this.EmitReturnSeriesValueAdded();
      this.EmitStatisticChanged();
      if (!this.isRoundTripsOnly)
        return;
      this.EmitRoundTripsUpdated();
      this.EmitRoundTripStatisticChanged();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WM4yuesikn([In] object obj0, [In] PositionEventArgs obj1)
    {
      lock (this)
        this.isNewData = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RCnyHI5vxH([In] object obj0, [In] EventArgs obj1)
    {
      lock (this)
        this.Reset();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Test(DateTime firstDateTime, DateTime lastDateTime, bool followChanges)
    {
      lock (this)
      {
        this.connected = followChanges;
        this.isTested = true;
        int local_0 = this.portfolio.Transactions.Count;
        this.Reset();
        this.Disconnect();
        this.Connect();
        int local_4 = 0;
        for (DateTime local_5 = this.GetIntervalEnd(firstDateTime, this.timeInterval); local_5 <= lastDateTime; local_5 = this.AddInterval(local_5, this.timeInterval))
        {
          bool local_2 = false;
          bool local_3 = false;
          for (int local_6 = local_4; local_6 < local_0; ++local_6)
          {
            Transaction local_1 = this.portfolio.Transactions[local_6];
            if (local_1.DateTime <= local_5)
            {
              switch (local_1.Side)
              {
                case Side.Buy:
                  this.currentAccount -= FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocation += FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocationLong += FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  local_2 = true;
                  break;
                case Side.Sell:
                  this.currentAccount += FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocation -= FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocationLong -= FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  local_2 = true;
                  break;
                case Side.BuyMinus:
                  this.currentAccount -= FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocation += FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocationShort += FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  local_3 = true;
                  break;
                case Side.SellShort:
                  this.currentAccount += FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocation -= FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  this.allocationShort -= FreeQuant.Instruments.Currency.Convert(local_1.Value, local_1.Currency, this.portfolio.Account.Currency);
                  local_3 = true;
                  break;
              }
              if (this.isRoundTripsOnly)
              {
                if (!this.tempPortfolio.Positions.Contains(local_1.Instrument))
                {
                  this.roundTripList.CloseOpenRoundTrip(local_1.Instrument, local_1.Price, local_1.DateTime);
                  if (local_1.Side == Side.Buy)
                    this.shortRoundTripList.CloseOpenRoundTrip(local_1.Instrument, local_1.Price, local_1.DateTime);
                  else
                    this.longRoundTripList.CloseOpenRoundTrip(local_1.Instrument, local_1.Price, local_1.DateTime);
                }
                else if (this.tempPortfolio.Positions[local_1.Instrument].Transactions.Count == 1)
                {
                  PositionSide local_7 = PositionSide.Short;
                  if (local_1.Side == Side.Buy)
                    local_7 = PositionSide.Long;
                  RoundTrip local_8 = new RoundTrip(this.tempPortfolio.Positions[local_1.Instrument], local_1.Instrument, local_7, local_1.Amount, local_1.Price, local_1.Price, local_1.DateTime, local_1.DateTime, RoundTripStatus.Opened);
                  this.roundTripList.AddOpenRoundTrip(local_8);
                  if (local_1.Side == Side.Buy)
                    this.longRoundTripList.AddOpenRoundTrip(local_8);
                  else
                    this.shortRoundTripList.AddOpenRoundTrip(local_8);
                }
                else
                {
                  this.isRoundTripsOnly = false;
                  this.EmitRoundTripsFinished();
                }
              }
              this.currentAccount -= local_1.Cost;
              this.tempPortfolio.Add(local_1);
              this.cost += local_1.Cost;
              local_4 = local_6 + 1;
            }
            else if (local_1.DateTime.Date >= local_5)
              break;
          }
          double local_9 = this.currentWealth;
          this.currentWealth = this.currentAccount + this.tempPortfolio.GetPositionValue(local_5);
          this.pnL = this.currentWealth - local_9;
          this.maxPreviousWealth = Math.Max(this.maxPreviousWealth, local_9);
          this.drawdown = Math.Min(this.currentWealth - this.maxPreviousWealth, 0.0);
          this.percentDrawdown = this.currentWealth / this.maxPreviousWealth - 1.0;
          this.returnValue = (this.currentWealth / local_9 - 1.0) * 100.0;
          this.totalCost += this.cost;
          if (this.businessDaysOnly)
            Calendar.IsWeekend(local_5);
          if (local_5 >= this.FirstDate.Date)
          {
            this.wealthSeries.Add(local_5.AddTicks(1L), this.currentWealth);
            this.drawdownSeries.Add(local_5.AddTicks(1L), this.drawdown);
            this.percentDrawdownSeries.Add(local_5.AddTicks(1L), this.percentDrawdown);
            this.pnLSeries.Add(local_5.AddTicks(1L), this.pnL);
            this.costSeries.Add(local_5.AddTicks(1L), this.cost);
            this.returnSeries.Add(local_5.AddTicks(1L), this.returnValue);
            this.EmitPnLSeriesValueAdded();
            this.EmitWealthSeriesValueAddedd();
            this.EmitDrawdownSeriesValueAdded();
            this.EmitCostSeriesValueAdded();
            this.EmitReturnSeriesValueAdded();
            if (local_2 || local_3)
            {
              this.allocationSeries.Add(local_5.AddTicks(1L), this.allocation);
              this.EmitAllocationSeriesValueAdded();
            }
            if (local_2)
            {
              this.allocationLongSeries.Add(local_5.AddTicks(1L), this.allocationLong);
              this.EmitAllocationLongSeriesValueAdded();
            }
            if (local_3)
            {
              this.allocationShortSeries.Add(local_5.AddTicks(1L), this.allocationShort);
              this.EmitAllocationShortSeriesValueAdded();
            }
          }
        }
        this.EmitStatisticChanged();
        if (!this.isRoundTripsOnly)
          return;
        this.EmitRoundTripsUpdated();
        this.EmitRoundTripStatisticChanged();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Test()
    {
      this.Test(this.followChanges);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Test(bool followChanges)
    {
      this.followChanges = followChanges;
      if (this.portfolio.Transactions.Count > 0 && this.firstDate == DateTime.MinValue && this.lastDate == DateTime.MinValue)
      {
        this.firstDate = this.portfolio.Transactions.First.DateTime;
        this.lastDate = this.AddInterval(this.portfolio.Transactions.Last.DateTime, this.timeInterval);
      }
      else
        this.firstDate = Clock.Now.AddDays(1.0);
      this.Test(this.firstDate, this.lastDate, followChanges);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TestOffline()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddComponent(TesterItem component)
    {
      this.components.f9Ww98OVG(component);
      component.PropertyChanged += new TesterItemEventHandler(this.YJRyNuAZek);
      component.ComponentNameChanged += new TesterComponentNameEventHandler(this.zLlySFoeEa);
      if (!(component is SeriesTesterItem))
        return;
      (component as SeriesTesterItem).ComponentEnabledChanged += new EventHandler(this.gFyyncG26J);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveComponent(TesterItem component)
    {
      this.components.RY4dKuMHX(component.Name);
      component.PropertyChanged -= new TesterItemEventHandler(this.YJRyNuAZek);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearComponents(TesterItem component)
    {
      foreach (TesterItem component1 in new ArrayList((ICollection) this.components))
        this.RemoveComponent(component1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddList(TesterItemList componentList)
    {
      foreach (TesterItem component in componentList)
        this.AddComponent(component);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableComponent(string name)
    {
      TesterItem testerItem = this.components[name];
      if (!(testerItem is SeriesTesterItem))
        return;
      (testerItem as SeriesTesterItem).Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableComponent(string name)
    {
      TesterItem testerItem = this.components[name];
      if (!(testerItem is SeriesTesterItem))
        return;
      (testerItem as SeriesTesterItem).Enabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitAllocationShortSeriesValueAdded()
    {
      if (this.Nn8eIYdy9S == null)
        return;
      this.Nn8eIYdy9S(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitAllocationLongSeriesValueAdded()
    {
      if (this.p5XeeWq9Z2 == null)
        return;
      this.p5XeeWq9Z2(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitAllocationSeriesValueAdded()
    {
      if (this.N01eyHl59X == null)
        return;
      this.N01eyHl59X(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitPnLSeriesValueAdded()
    {
      if (this.e3ly6aoDME == null)
        return;
      this.e3ly6aoDME(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitWealthSeriesValueAddedd()
    {
      if (this.xi9yxswX2E == null)
        return;
      this.xi9yxswX2E(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitDrawdownSeriesValueAdded()
    {
      if (this.HHHyl8HwBJ == null)
        return;
      this.HHHyl8HwBJ(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitCostSeriesValueAdded()
    {
      if (this.sAgyzlHxE5 == null)
        return;
      this.sAgyzlHxE5(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitReturnSeriesValueAdded()
    {
      if (this.HxxerPUYmB == null)
        return;
      this.HxxerPUYmB(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitStatisticChanged()
    {
      if (this.dlIeq5RNS7 == null)
        return;
      this.dlIeq5RNS7(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitRoundTripStatisticChanged()
    {
      if (this.HBjeRriftR == null)
        return;
      this.HBjeRriftR(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitRoundTripsUpdated()
    {
      if (this.rooetfRMGh == null)
        return;
      this.rooetfRMGh(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitRoundTripsFinished()
    {
      if (this.aBNeFTYic6 == null)
        return;
      this.aBNeFTYic6(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitReseted()
    {
      if (this.kFce7Nbiqu == null)
        return;
      this.kFce7Nbiqu(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YJRyNuAZek([In] TesterItem obj0)
    {
      this.IQXyfM7NQ6(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zLlySFoeEa([In] TesterItem obj0, [In] ComponentNameEventArgs obj1)
    {
      this.Udfyv7dk1s(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GvwyC63XLV([In] object obj0, [In] EventArgs obj1)
    {
      this.lRqy00gKm6(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveSettings()
    {
      this.jHRedeUy4p = new TesterSettings(this);
      this.components.ActivateItemOnRequest = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreSettings()
    {
      if (!this.components.ActivateItemOnRequest)
        return;
      this.components.ActivateItemOnRequest = false;
      this.jHRedeUy4p.LoadState();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableComponents()
    {
      foreach (TesterItem testerItem in this.Components)
      {
        SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
        if (seriesTesterItem != null)
        {
          seriesTesterItem.FillSeries = false;
          seriesTesterItem.Enabled = false;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSplitDate(DateTime date, Color color)
    {
      foreach (TesterItem testerItem in this.Components)
      {
        SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
        if (seriesTesterItem != null)
        {
          seriesTesterItem.Series.SecondColor = color;
          seriesTesterItem.Series.SplitDate = date;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gFyyncG26J([In] object obj0, [In] EventArgs obj1)
    {
      this.aJXyPKqwug(obj0 as TesterItem);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IQXyfM7NQ6([In] TesterItem obj0)
    {
      if (this.EuremxNnCx == null)
        return;
      this.EuremxNnCx(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Udfyv7dk1s([In] TesterItem obj0, [In] ComponentNameEventArgs obj1)
    {
      if (this.GJleQFCDgF == null)
        return;
      this.GJleQFCDgF(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lRqy00gKm6([In] object obj0, [In] EventArgs obj1)
    {
      if (this.YM9eWVMbOS == null)
        return;
      this.YM9eWVMbOS(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aJXyPKqwug([In] TesterItem obj0)
    {
      if (this.QiaesADbMF == null)
        return;
      this.QiaesADbMF(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NENyAxCZF4()
    {
      if (this.VRyeXPmb2Q == null)
        return;
      this.VRyeXPmb2Q((object) this, EventArgs.Empty);
    }
  }
}
