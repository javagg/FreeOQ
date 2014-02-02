using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;

namespace OpenQuant.Config
{
	public class ConfigurationInfo
	{
		private Portfolio portfolio;
		private IMarketDataProvider marketDataProvider;
		private IExecutionProvider executionProvider;
		private byte marketDataProviderId;
		private byte executionProviderId;

		public Portfolio Portfolio
		{
			get
			{
				return this.portfolio;
			}
			set
			{
				if (value == null)
					throw new ArgumentNullException();
				this.portfolio = value;
			}
		}

		public bool Persistent
		{
			get
			{
				return this.portfolio.Persistent;
			}
			set
			{
				this.portfolio.Persistent = value;
			}
		}

		public IMarketDataProvider MarketDataProvider
		{
			get
			{
				return this.marketDataProvider;
			}
			set
			{
				if (value == null)
					throw new ArgumentNullException();
				this.marketDataProvider = value;
			}
		}

		public IExecutionProvider ExecutionProvider
		{
			get
			{
				return this.executionProvider;
			}
			set
			{
				if (value == null)
					throw new ArgumentNullException();
				this.executionProvider = value;
			}
		}

		public ConfigurationInfo() : this("Simulation", ProviderManager.MarketDataSimulator.Id, ProviderManager.ExecutionSimulator.Id)
		{
		}

		public ConfigurationInfo(string portfolioName, byte marketDataProviderId, byte executionProviderId)
		{
			this.portfolio = PortfolioManager.Portfolios[portfolioName];
			if (this.portfolio == null)
				this.portfolio = new Portfolio(portfolioName);
			this.marketDataProvider = ProviderManager.MarketDataProviders[marketDataProviderId];
			this.executionProvider = ProviderManager.ExecutionProviders[executionProviderId];
			this.marketDataProviderId = this.marketDataProvider == null ? marketDataProviderId : (byte)0;
			this.executionProviderId = this.executionProvider == null ? executionProviderId : (byte)0;
		}

		internal void Refresh()
		{
			if (this.marketDataProvider == null)
				this.marketDataProvider = ProviderManager.MarketDataProviders[this.marketDataProviderId];
			if (this.executionProvider != null)
				return;
			this.executionProvider = ProviderManager.ExecutionProviders[this.executionProviderId];
		}
	}
}
