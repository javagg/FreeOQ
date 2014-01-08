
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Simulation;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

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
    private SimulationMode Eua6blN8f6;
    private double pHS6ytvuMg;
    private int ebM6G28i5h;
    private DateTime qsh6ShuQyQ;
    private DateTime RuO6T687cC;
    private double ipu6rgoC4P;
    private SmartQuant.Instruments.Currency NSl6IOdVVo;
    private RequestList arK690bcVd;
    private RequestList HQ26hOnGxh;

    [Description("Commission")]
    [Category("Execution - Commission & Slippage")]
    public ICommissionProvider CommissionProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).CommissionProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).CommissionProvider = value;
      }
    }

    [Category("Execution - Commission & Slippage")]
    [Description("Slippage")]
    public ISlippageProvider SlippageProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).SlippageProvider;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).SlippageProvider = value;
      }
    }

    [DefaultValue(true)]
    [Category("Execution - Fill Data")]
    public bool FillOnQuote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuote;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuote = value;
      }
    }

    [Category("Execution - Fill Data")]
    [DefaultValue(true)]
    public bool FillOnTrade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTrade;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTrade = value;
      }
    }

    [DefaultValue(true)]
    [Category("Execution - Fill Data")]
    public bool FillOnBar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBar;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBar = value;
      }
    }

    [Category("Execution - Fill Mode")]
    [DefaultValue(FillOnTradeMode.LastTrade)]
    public FillOnTradeMode FillOnTradeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTradeMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnTradeMode = value;
      }
    }

    [Category("Execution - Fill Mode")]
    [DefaultValue(FillOnQuoteMode.LastQuote)]
    public FillOnQuoteMode FillOnQuoteMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuoteMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnQuoteMode = value;
      }
    }

    [Category("Execution - Fill Mode")]
    [DefaultValue(FillOnBarMode.LastBarClose)]
    public FillOnBarMode FillOnBarMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBarMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        (ProviderManager.ExecutionSimulator as SimulationExecutionProvider).FillOnBarMode = value;
      }
    }

    [Browsable(false)]
    public RequestList Requests
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.arK690bcVd;
      }
    }

    [Editor(typeof (dlpOgBSiSH6BDdZEl9), typeof (UITypeEditor))]
    [Category("Feed Simulator")]
    public RequestList StaticRequests
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HQ26hOnGxh;
      }
    }

    [DefaultValue(SimulationMode.MaxSpeed)]
    [Category("Feed Simulator")]
    public SimulationMode Mode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Eua6blN8f6;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Eua6blN8f6 = value;
      }
    }

    [DefaultValue(1.0)]
    [Category("Feed Simulator")]
    public double SpeedMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pHS6ytvuMg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.pHS6ytvuMg = value;
      }
    }

    [Category("Feed Simulator")]
    [DefaultValue(86400)]
    [Description("Step size in seconds")]
    public int Step
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ebM6G28i5h;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ebM6G28i5h = value;
      }
    }

    [Category("Feed Simulator")]
    [DefaultValue(typeof (DateTime), "01/01/1970")]
    public DateTime EntryDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qsh6ShuQyQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qsh6ShuQyQ = value;
      }
    }

    [Category("Feed Simulator")]
    public DateTime ExitDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RuO6T687cC;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.RuO6T687cC = value;
      }
    }

    [Category("Account")]
    [DefaultValue(10000.0)]
    public double Cash
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ipu6rgoC4P;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ipu6rgoC4P = value;
      }
    }

    [Category("Account")]
    public SmartQuant.Instruments.Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NSl6IOdVVo;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.NSl6IOdVVo = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.Eua6blN8f6 = SimulationMode.MaxSpeed;
      this.pHS6ytvuMg = 1.0;
      this.ebM6G28i5h = 86400;
      this.qsh6ShuQyQ = new DateTime(1970, 1, 1);
      this.RuO6T687cC = DateTime.Today;
      this.ipu6rgoC4P = 10000.0;
      this.NSl6IOdVVo = CurrencyManager.DefaultCurrency;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.arK690bcVd = new RequestList();
      this.HQ26hOnGxh = new RequestList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Init()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendMarketDataRequest(string request)
    {
      if (this.arK690bcVd.Contains(request))
        return;
      this.arK690bcVd.Add(request);
    }
  }
}
