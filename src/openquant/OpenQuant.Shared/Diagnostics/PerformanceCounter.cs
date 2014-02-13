using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Diagnostics;
using System.Threading;

namespace OpenQuant.Shared.Diagnostics
{
  internal class PerformanceCounter
  {
    private volatile bool doWork;
    private long countBar;
    private long countTrade;
    private long countQuote;
    private long countMarketDepth;
    private long countMarketDataTotal;
    private long countOrder;
    private long countReport;
    private long countReject;
    private long countExecutionTotal;
    private Process process;

    public PerformanceCounterItem Bar { get; private set; }

    public PerformanceCounterItem Trade { get; private set; }

    public PerformanceCounterItem Quote { get; private set; }

    public PerformanceCounterItem MarketDepth { get; private set; }

    public PerformanceCounterItem MarketDataTotal { get; private set; }

    public PerformanceCounterItem Order { get; private set; }

    public PerformanceCounterItem Report { get; private set; }

    public PerformanceCounterItem Reject { get; private set; }

    public PerformanceCounterItem ExecutionTotal { get; private set; }

    public PerformanceCounterItem MemoryAllocation { get; private set; }

    public PerformanceCounterItem CPUUsageTotal { get; private set; }

    public PerformanceCounterItem CPUUsageCore { get; private set; }

    public event EventHandler Updated;

    public PerformanceCounter()
    {
      this.Bar = new PerformanceCounterItem();
      this.Trade = new PerformanceCounterItem();
      this.Quote = new PerformanceCounterItem();
      this.MarketDepth = new PerformanceCounterItem();
      this.MarketDataTotal = new PerformanceCounterItem();
      this.Order = new PerformanceCounterItem();
      this.Report = new PerformanceCounterItem();
      this.Reject = new PerformanceCounterItem();
      this.ExecutionTotal = new PerformanceCounterItem();
      this.MemoryAllocation = new PerformanceCounterItem();
      this.CPUUsageTotal = new PerformanceCounterItem();
      this.CPUUsageCore = new PerformanceCounterItem();
      this.process = Process.GetCurrentProcess();
      this.UpdateMemoryAllocation();
    }

    public void Start()
    {
      Thread thread = new Thread(new ThreadStart(this.Do));
      thread.Name = "PerfMon";
      thread.IsBackground = true;
      thread.Priority = ThreadPriority.AboveNormal;
      this.doWork = true;
      thread.Start();
    }

    public void Stop()
    {
      this.doWork = false;
    }

    public void Reset()
    {
      lock (this)
      {
        this.Bar.Reset();
        this.Trade.Reset();
        this.Quote.Reset();
        this.MarketDepth.Reset();
        this.MarketDataTotal.Reset();
        this.Order.Reset();
        this.Report.Reset();
        this.Reject.Reset();
        this.ExecutionTotal.Reset();
        this.countBar = 0L;
        this.countTrade = 0L;
        this.countQuote = 0L;
        this.countMarketDepth = 0L;
        this.countMarketDataTotal = 0L;
        this.countOrder = 0L;
        this.countReport = 0L;
        this.countReject = 0L;
        this.countExecutionTotal = 0L;
      }
    }

    private void Do()
    {
      try
      {
        this.countBar = 0L;
        this.countTrade = 0L;
        this.countQuote = 0L;
        this.countMarketDepth = 0L;
        this.countMarketDataTotal = 0L;
        this.countOrder = 0L;
        this.countReport = 0L;
        this.countReject = 0L;
        this.countExecutionTotal = 0L;
        this.process.Refresh();
        this.CPUUsageTotal.Count = this.process.TotalProcessorTime.Ticks;
        this.CPUUsageCore.Count = this.process.PrivilegedProcessorTime.Ticks;
        // ISSUE: method pointer
				ProviderManager.NewBar += new BarEventHandler(this.ProviderManager_NewBar);
        // ISSUE: method pointer
				ProviderManager.NewTrade += new TradeEventHandler(this.ProviderManager_NewTrade);
        // ISSUE: method pointer
				ProviderManager.NewQuote += new QuoteEventHandler(this.ProviderManager_NewQuote);
        // ISSUE: method pointer
				ProviderManager.NewMarketDepth += new MarketDepthEventHandler(this.ProviderManager_NewMarketDepth);
        // ISSUE: method pointer
				OrderManager.NewOrder += new OrderEventHandler(this.OrderManager_NewOrder);
        // ISSUE: method pointer
				OrderManager.ExecutionReport += new ExecutionReportEventHandler(this.OrderManager_ExecutionReport);
        // ISSUE: method pointer
				OrderManager.OrderCancelReject += new OrderCancelRejectEventHandler(this.OrderManager_OrderCancelReject);
        while (true)
        {
          do
          {
            DateTime utcNow = DateTime.UtcNow;
            Thread.Sleep(1000);
            TimeSpan timeSpan = DateTime.UtcNow - utcNow;
            this.process.Refresh();
            if (this.doWork)
            {
              lock (this)
              {
                this.Bar.Average = (long) ((double) this.countBar / timeSpan.TotalSeconds);
                this.Bar.Peak = Math.Max(this.Bar.Peak, this.Bar.Average);
                this.Bar.Count += this.countBar;
                this.countBar = 0L;
                this.Trade.Average = (long) ((double) this.countTrade / timeSpan.TotalSeconds);
                this.Trade.Peak = Math.Max(this.Trade.Peak, this.Trade.Average);
                this.Trade.Count += this.countTrade;
                this.countTrade = 0L;
                this.Quote.Average = (long) ((double) this.countQuote / timeSpan.TotalSeconds);
                this.Quote.Peak = Math.Max(this.Quote.Peak, this.Quote.Average);
                this.Quote.Count += this.countQuote;
                this.countQuote = 0L;
                this.MarketDepth.Average = (long) ((double) this.countMarketDepth / timeSpan.TotalSeconds);
                this.MarketDepth.Peak = Math.Max(this.MarketDepth.Peak, this.MarketDepth.Average);
                this.MarketDepth.Count += this.countMarketDepth;
                this.countMarketDepth = 0L;
                this.MarketDataTotal.Average = (long) ((double) this.countMarketDataTotal / timeSpan.TotalSeconds);
                this.MarketDataTotal.Peak = Math.Max(this.MarketDataTotal.Peak, this.MarketDataTotal.Average);
                this.MarketDataTotal.Count += this.countMarketDataTotal;
                this.countMarketDataTotal = 0L;
                this.Order.Average = (long) ((double) this.countOrder / timeSpan.TotalSeconds);
                this.Order.Peak = Math.Max(this.Order.Peak, this.Order.Average);
                this.Order.Count += this.countOrder;
                this.countOrder = 0L;
                this.Report.Average = (long) ((double) this.countReport / timeSpan.TotalSeconds);
                this.Report.Peak = Math.Max(this.Report.Peak, this.Report.Average);
                this.Report.Count += this.countReport;
                this.countReport = 0L;
                this.Reject.Average = (long) ((double) this.countReject / timeSpan.TotalSeconds);
                this.Reject.Peak = Math.Max(this.Reject.Peak, this.Reject.Average);
                this.Reject.Count += this.countReject;
                this.countReject = 0L;
                this.ExecutionTotal.Average = (long) ((double) this.countExecutionTotal / timeSpan.TotalSeconds);
                this.ExecutionTotal.Peak = Math.Max(this.ExecutionTotal.Peak, this.ExecutionTotal.Average);
                this.ExecutionTotal.Count += this.countExecutionTotal;
                this.countExecutionTotal = 0L;
                long local_2 = this.process.ProcessorAffinity.ToInt64();
                long local_3 = 0L;
                while (local_2 > 0L)
                {
                  if (local_2 % 2L == 1L)
                    ++local_3;
                  local_2 /= 2L;
                }
                this.CPUUsageTotal.Average = (long) ((double) (this.process.TotalProcessorTime.Ticks - this.CPUUsageTotal.Count) * 100.0 / (double) timeSpan.Ticks / (double) local_3);
                this.CPUUsageTotal.Peak = Math.Max(this.CPUUsageTotal.Peak, this.CPUUsageTotal.Average);
                this.CPUUsageTotal.Count = this.process.TotalProcessorTime.Ticks;
                this.CPUUsageCore.Average = (long) ((double) (this.process.PrivilegedProcessorTime.Ticks - this.CPUUsageCore.Count) * 100.0 / (double) timeSpan.Ticks / (double) local_3);
                this.CPUUsageCore.Peak = Math.Max(this.CPUUsageCore.Peak, this.CPUUsageCore.Average);
                this.CPUUsageCore.Count = this.process.PrivilegedProcessorTime.Ticks;
                this.UpdateMemoryAllocation();
              }
            }
            else
              goto label_14;
          }
          while (this.Updated == null);
          this.Updated(this, EventArgs.Empty);
        }
label_14:;
      }
      finally
      {
        // ISSUE: method pointer
				ProviderManager.NewBar -= new BarEventHandler(this.ProviderManager_NewBar);
        // ISSUE: method pointer
				ProviderManager.NewTrade -= new TradeEventHandler(this.ProviderManager_NewTrade);
        // ISSUE: method pointer
				ProviderManager.NewQuote -= new QuoteEventHandler(this.ProviderManager_NewQuote);
        // ISSUE: method pointer
				ProviderManager.NewMarketDepth -= new MarketDepthEventHandler(this.ProviderManager_NewMarketDepth);
        // ISSUE: method pointer
				OrderManager.NewOrder -= new OrderEventHandler(this.OrderManager_NewOrder);
        // ISSUE: method pointer
				OrderManager.ExecutionReport -= new ExecutionReportEventHandler(this.OrderManager_ExecutionReport);
        // ISSUE: method pointer
				OrderManager.OrderCancelReject -= new OrderCancelRejectEventHandler(this.OrderManager_OrderCancelReject);
      }
    }

    private void UpdateMemoryAllocation()
    {
      this.MemoryAllocation.Count = this.process.WorkingSet64;
      this.MemoryAllocation.Peak = this.process.PeakWorkingSet64;
    }

    private void ProviderManager_NewBar(object sender, BarEventArgs args)
    {
      lock (this)
      {
        ++this.countBar;
        ++this.countMarketDataTotal;
      }
    }

    private void ProviderManager_NewTrade(object sender, TradeEventArgs args)
    {
      lock (this)
      {
        ++this.countTrade;
        ++this.countMarketDataTotal;
      }
    }

    private void ProviderManager_NewQuote(object sender, QuoteEventArgs args)
    {
      lock (this)
      {
        ++this.countQuote;
        ++this.countMarketDataTotal;
      }
    }

    private void ProviderManager_NewMarketDepth(object sender, MarketDepthEventArgs args)
    {
      lock (this)
      {
        ++this.countMarketDepth;
        ++this.countMarketDataTotal;
      }
    }

    private void OrderManager_NewOrder(OrderEventArgs args)
    {
      lock (this)
      {
        ++this.countOrder;
        ++this.countExecutionTotal;
      }
    }

    private void OrderManager_ExecutionReport(object sender, ExecutionReportEventArgs args)
    {
      lock (this)
      {
        ++this.countReport;
        ++this.countExecutionTotal;
      }
    }

    private void OrderManager_OrderCancelReject(object sender, OrderCancelRejectEventArgs args)
    {
      lock (this)
      {
        ++this.countReject;
        ++this.countExecutionTotal;
      }
    }
  }
}
