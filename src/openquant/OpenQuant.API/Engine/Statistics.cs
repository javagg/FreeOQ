using FreeQuant.Instruments;
using System;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  Statistics 
	///</summary>
	public class Statistics
	{
		private PortfolioStatistics statistics;
		private FreeQuant.Instruments.Portfolio portfolio;

		internal bool IsCalculated { get; set; }

		public double InitialWealth
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.InitialWealth;
			}
		}

		public double FinalWealth
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.FinalWealth;
			}
		}

		public double TotalPnL
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.TotalPnL;
			}
		}

		public double TotalReturn
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.TotalReturn;
			}
		}

		public double AnnualReturn
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.AnnualReturn;
			}
		}

		public int TotalTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.TotalTransactions;
			}
		}

		public int LongTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.LongTransactions;
			}
		}

		public int ShortTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.ShortTransactions;
			}
		}

		public int WinningTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.WinningTrades;
			}
		}

		public int LosingTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.LosingTrades;
			}
		}

		public int WinningLongTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.WinningLongTrades;
			}
		}

		public int WinningShortTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.WinningShortTrades;
			}
		}

		public int LosingLongTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.LosingLongTrades;
			}
		}

		public int LosingShortTrades
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.LosingShortTrades;
			}
		}

		public double LongTradesPnL
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.LongTradesPnL;
			}
		}

		public double ShortTradesPnL
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.ShortTradesPnL;
			}
		}

		public double PnLPerTrade
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.PnLPerTransaction;
			}
		}

		public double PnLPerLongTrade
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.PnLPerLongTransaction;
			}
		}

		public double PnLPerShortTrade
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.PnLPerShortTransaction;
			}
		}

		public TimeSpan Duration
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.Duration;
			}
		}

		public TimeSpan TransactionsFrequency
		{
			get
			{
				this.CheckCalculated();
				return this.statistics.TransactionsFrequency;
			}
		}

		internal Statistics(FreeQuant.Instruments.Portfolio portfolio)
		{
			this.portfolio = portfolio;
		}

		private void CheckCalculated()
		{
			if (this.IsCalculated && this.statistics != null)
				return;
			this.statistics = new PortfolioStatistics(this.portfolio);
			this.statistics.Calculate();
			this.IsCalculated = true;
		}
	}
}
