using System;

namespace FreeQuant.Instruments
{
	public class PortfolioStatistics
	{
		public Portfolio portfolio;

		public double InitialWealth { get; private set; }

		public double FinalWealth { get; private set; }

		public double TotalPnL { get; private set; }

		public double TotalReturn { get; private set; }

		public double AnnualReturn { get; private set; }

		public DateTime FirstTransactionDate { get; private set; }

		public DateTime LastTransactionDate { get; private set; }

		public int TotalTransactions { get; private set; }

		public int LongTransactions { get; private set; }

		public int ShortTransactions { get; private set; }

		public int WinningTrades { get; private set; }

		public int LosingTrades { get; private set; }

		public int WinningLongTrades { get; private set; }

		public int WinningShortTrades { get; private set; }

		public int LosingLongTrades { get; private set; }

		public int LosingShortTrades { get; private set; }

		public double LongTradesPnL { get; private set; }

		public double ShortTradesPnL { get; private set; }

		public double PnLPerTransaction { get; private set; }

		public double PnLPerLongTransaction { get; private set; }

		public double PnLPerShortTransaction { get; private set; }

		public TimeSpan Duration { get; private set; }

		public TimeSpan TransactionsFrequency { get; private set; }

		public PortfolioStatistics(Portfolio portfolio)
		{
			this.portfolio = portfolio;
		}

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
			this.TransactionsFrequency = new TimeSpan(ticks / (long)this.portfolio.Transactions.Count);
			this.InitialWealth = this.portfolio.Account.Transactions[0].Value;
			this.FinalWealth = this.portfolio.GetTotalEquity();
			this.TotalPnL = this.FinalWealth - this.InitialWealth;
			this.TotalReturn = (this.FinalWealth / this.InitialWealth - 1.0) * 100.0;
			this.AnnualReturn = (Math.Pow(Math.Abs(this.FinalWealth / this.InitialWealth), 315360000000000.0 / (double)ticks) - 1.0) * 100.0;
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
			this.PnLPerTransaction = this.TotalPnL / (double)(this.WinningTrades + this.LosingTrades);
			this.PnLPerLongTransaction = this.LongTradesPnL / (double)(this.WinningLongTrades + this.LosingLongTrades);
			this.PnLPerShortTransaction = this.ShortTradesPnL / (double)(this.WinningShortTrades + this.LosingShortTrades);
		}
	}
}
