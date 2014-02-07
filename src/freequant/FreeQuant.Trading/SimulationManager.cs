using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Simulation;
using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace FreeQuant.Trading
{
	[StrategyComponent("{872476E5-3774-4687-828F-34978288A6E0}", ComponentType.SimulationManager, Description = "", Name = "Default_SimulationManager")]
	public class SimulationManager : ComponentBase
	{
		public const string GUID = "{872476E5-3774-4687-828F-34978288A6E0}";
		public const string CATEGORY_SIMULATOR = "Feed Simulator";
		public const string CATEGORY_ACCOUNT = "Account";
		private const string ybG6WIDqCp = "Execution - Fill Data";
		private const string eOv6RNE4DR = "Execution - Fill Mode";
		private const SimulationMode MyR6iyAnMC = SimulationMode.MaxSpeed;
		private const double REZ67HgVP1 = 1.0;
		private const int yvl6HSemmS = 86400;
		private const double q8y6UfVsdD = 10000.0;
		private const bool BLD6OHUvAC = true;
		private const bool KGD6QKWHAP = true;
		private const bool ACQ65nNhVo = true;
		private const FillOnBarMode WG762kw5qb = FillOnBarMode.LastBarClose;
		private const FillOnTradeMode YwS6BaG3GZ = FillOnTradeMode.LastTrade;
		private const FillOnQuoteMode Rgj6M1iVdv = FillOnQuoteMode.LastQuote;
		private RequestList requests;
		private RequestList staticRequests;

		[Description("Commission")]
		[Category("Execution - Commission & Slippage")]
		public ICommissionProvider CommissionProvider
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).CommissionProvider;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).CommissionProvider = value;
			}
		}

		[Category("Execution - Commission & Slippage")]
		[Description("Slippage")]
		public ISlippageProvider SlippageProvider
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).SlippageProvider;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).SlippageProvider = value;
			}
		}

		[DefaultValue(true)]
		[Category("Execution - Fill Data")]
		public bool FillOnQuote
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuote;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuote = value;
			}
		}

		[Category("Execution - Fill Data")]
		[DefaultValue(true)]
		public bool FillOnTrade
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTrade;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTrade = value;
			}
		}

		[DefaultValue(true)]
		[Category("Execution - Fill Data")]
		public bool FillOnBar
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBar;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBar = value;
			}
		}

		[Category("Execution - Fill Mode")]
		[DefaultValue(FillOnTradeMode.LastTrade)]
		public FillOnTradeMode FillOnTradeMode
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTradeMode;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTradeMode = value;
			}
		}

		[Category("Execution - Fill Mode")]
		[DefaultValue(FillOnQuoteMode.LastQuote)]
		public FillOnQuoteMode FillOnQuoteMode
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuoteMode;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuoteMode = value;
			}
		}

		[Category("Execution - Fill Mode")]
		[DefaultValue(FillOnBarMode.LastBarClose)]
		public FillOnBarMode FillOnBarMode
		{
			get
			{
				return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBarMode;
			}
			set
			{
				(ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBarMode = value;
			}
		}

		[Browsable(false)]
		public RequestList Requests
		{
			get
			{
				return this.requests;
			}
		}
		//    [Editor(typeof (dlpOgBSiSH6BDdZEl9), typeof (UITypeEditor))]
		[Category("Feed Simulator")]
		public RequestList StaticRequests
		{
			get
			{
				return this.staticRequests;
			}
		}

		[DefaultValue(SimulationMode.MaxSpeed)]
		[Category("Feed Simulator")]
		public SimulationMode Mode { get; set; }

		[DefaultValue(1.0)]
		[Category("Feed Simulator")]
		public double SpeedMultiplier { get; set; }

		[Category("Feed Simulator")]
		[DefaultValue(86400)]
		[Description("Step size in seconds")]
		public int Step { get; set; }

		[Category("Feed Simulator")]
		[DefaultValue(typeof(DateTime), "01/01/1970")]
		public DateTime EntryDate { get; set; }

		[Category("Feed Simulator")]
		public DateTime ExitDate { get; set; }

		[Category("Account")]
		[DefaultValue(10000.0)]
		public double Cash { get; set; }

		[Category("Account")]
		public FreeQuant.Instruments.Currency Currency { get; set; }
	

		public SimulationManager() : base()
		{
			this.Mode = SimulationMode.MaxSpeed;
			this.SpeedMultiplier = 1.0;
			this.Step = 86400;
			this.EntryDate = new DateTime(1970, 1, 1);
			this.ExitDate = DateTime.Today;
			this.Cash = 10000.0;
			this.Currency = CurrencyManager.DefaultCurrency;
			this.requests = new RequestList();
			this.staticRequests = new RequestList();
		}

		public override void Init()
		{
		}

		public void SendMarketDataRequest(string request)
		{
			if (!this.requests.Contains(request))
			this.requests.Add(request);
		}
	}
}
