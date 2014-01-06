// Type: SmartQuant.Instruments.PortfolioStatistics
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Instruments
{
  public class PortfolioStatistics
  {
    public Portfolio portfolio;

    public double InitialWealth { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double FinalWealth { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double TotalPnL { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double TotalReturn { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double AnnualReturn { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime FirstTransactionDate { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime LastTransactionDate { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int TotalTransactions { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int LongTransactions { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int ShortTransactions { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int WinningTrades { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int LosingTrades { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int WinningLongTrades { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int WinningShortTrades { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int LosingLongTrades { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int LosingShortTrades { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double LongTradesPnL { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double ShortTradesPnL { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double PnLPerTransaction { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double PnLPerLongTransaction { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public double PnLPerShortTransaction { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public TimeSpan Duration { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public TimeSpan TransactionsFrequency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PortfolioStatistics(Portfolio portfolio)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.portfolio = portfolio;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      this.InitialWealth = 0.0;
      this.FinalWealth = 0.0;
      this.TotalPnL = 0.0;
      this.TotalReturn = 0.0;
      this.AnnualReturn = 0.0;
      this.TotalTransactions = 0;
      this.ShortTransactions = 0;
      this.ShortTransactions = 0;
      this.WinningTrades = 0;
      this.LosingTrades = 0;
      this.WinningLongTrades = 0;
      this.WinningShortTrades = 0;
      this.LosingLongTrades = 0;
      this.LosingShortTrades = 0;
      this.LongTradesPnL = 0.0;
      this.ShortTradesPnL = 0.0;
      this.PnLPerTransaction = 0.0;
      this.PnLPerLongTransaction = 0.0;
      this.PnLPerShortTransaction = 0.0;
      if (this.portfolio.Account.Transactions.Count > 0)
        this.InitialWealth = this.portfolio.Account.Transactions[0].Value;
      if (this.portfolio.Transactions.Count <= 0)
        return;
      this.FirstTransactionDate = this.portfolio.Transactions[0].DateTime;
      this.LastTransactionDate = this.portfolio.Transactions[this.portfolio.Transactions.Count - 1].DateTime;
      long ticks = (this.LastTransactionDate - this.FirstTransactionDate).Ticks;
      this.Duration = new TimeSpan(ticks);
      this.TransactionsFrequency = new TimeSpan(ticks / (long) this.portfolio.Transactions.Count);
      this.InitialWealth = this.portfolio.Account.Transactions[0].Value;
      this.FinalWealth = this.portfolio.GetTotalEquity();
      this.TotalPnL = this.FinalWealth - this.InitialWealth;
      this.TotalReturn = (this.FinalWealth / this.InitialWealth - 1.0) * 100.0;
      this.AnnualReturn = (Math.Pow(Math.Abs(this.FinalWealth / this.InitialWealth), 315360000000000.0 / (double) ticks) - 1.0) * 100.0;
      foreach (Position position in this.portfolio.Positions)
      {
        double unrealizedPnL = position.GetUnrealizedPnL();
        if (position.Side == PositionSide.Short)
        {
          ++this.ShortTransactions;
          if (unrealizedPnL > 0.0)
          {
            ++this.WinningTrades;
            ++this.WinningShortTrades;
          }
          if (unrealizedPnL < 0.0)
          {
            ++this.LosingTrades;
            ++this.LosingShortTrades;
          }
          this.ShortTradesPnL += unrealizedPnL;
        }
        else
        {
          ++this.LongTransactions;
          if (unrealizedPnL > 0.0)
          {
            ++this.WinningTrades;
            ++this.WinningLongTrades;
          }
          if (unrealizedPnL < 0.0)
          {
            ++this.LosingTrades;
            ++this.LosingLongTrades;
          }
          this.LongTradesPnL += unrealizedPnL;
        }
      }
      foreach (Transaction transaction in this.portfolio.Transactions)
      {
        if (transaction.Amount > 0.0)
        {
          ++this.ShortTransactions;
          if (transaction.RealizedPnL > 0.0)
          {
            ++this.WinningTrades;
            ++this.WinningShortTrades;
          }
          if (transaction.RealizedPnL < 0.0)
          {
            ++this.LosingTrades;
            ++this.LosingShortTrades;
          }
          this.ShortTradesPnL += transaction.RealizedPnL;
        }
        else
        {
          ++this.LongTransactions;
          if (transaction.RealizedPnL > 0.0)
          {
            ++this.WinningTrades;
            ++this.WinningLongTrades;
          }
          if (transaction.RealizedPnL < 0.0)
          {
            ++this.LosingTrades;
            ++this.LosingLongTrades;
          }
          this.LongTradesPnL += transaction.RealizedPnL;
        }
      }
      this.TotalTransactions = this.portfolio.Transactions.Count;
      this.PnLPerTransaction = this.TotalPnL / (double) (this.WinningTrades + this.LosingTrades);
      this.PnLPerLongTransaction = this.LongTradesPnL / (double) (this.WinningLongTrades + this.LosingLongTrades);
      this.PnLPerShortTransaction = this.ShortTradesPnL / (double) (this.WinningShortTrades + this.LosingShortTrades);
    }
  }
}
