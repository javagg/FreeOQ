using OpenQuant.API;
using OpenQuant.Config;
using FreeQuant.Instruments;
using System;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  A scenario
	///</summary>
	public class Scenario
	{

		public Solution Solution
		{
			get
			{
				return IDE.Solution;
			}
		}

		public ExecutionProvider ExecutionProvider
		{
			get
			{
				return new ExecutionProvider(Configuration.Active.ExecutionProvider);
			}
		}

		public MarketDataProvider MarketDataProvider
		{
			get
			{
				return new MarketDataProvider(Configuration.Active.MarketDataProvider);
			}
		}

		public OpenQuant.API.PortfolioPricer PortfolioPricer
		{
			set
			{
				PortfolioManager.Pricer = (IPortfolioPricer)new SQPortfolioPricer(value);
			}
		}

		public StrategyMode Mode { get; private set; }

		public bool ResetOnStart { get; set; }

		public bool StartOver { get; set; }

		public event EventHandler StartRequested;
		public event EventHandler StopRequested;

		protected Scenario()
		{
			this.ResetOnStart = true;
			this.StartOver = false;
		}

		///<summary>
		///  Runs the scenario
		///</summary>
		public virtual void Run()
		{
			this.Start();
		}

		protected void Start(StrategyMode mode)
		{
			if (this.StartRequested == null)
				return;
			this.StartRequested((object)mode, EventArgs.Empty);
		}

		protected void Start()
		{
			this.Solution.OnStart();
			if (this.StartRequested == null)
				return;
			this.StartRequested((object)null, EventArgs.Empty);
		}

		protected void Stop()
		{
			if (this.StopRequested == null)
				return;
			this.StopRequested((object)null, EventArgs.Empty);
		}
	}
}
