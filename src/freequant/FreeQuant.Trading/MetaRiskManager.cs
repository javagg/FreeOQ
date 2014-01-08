using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{521B9C4F-01AE-4488-B4A5-104027D06BB8}", ComponentType.MetaRiskManager, Description = "", Name = "Default_MetaRiskManager")]
  public class MetaRiskManager : MetaStrategyComponent
  {
    public const string GUID = "{521B9C4F-01AE-4488-B4A5-104027D06BB8}";


    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPortfolioRisk()
    {
      return 1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AddStop(Strategy strategy, double level, StopType type, StopMode mode, bool stopStrategy)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, level, type, mode, stopStrategy);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AddStop(Strategy strategy, DateTime time, bool stopStrategy)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, time, stopStrategy);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AddStop(Strategy strategy, double level, StopType type, StopMode mode)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, level, type, mode, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AddStop(Strategy strategy, DateTime time)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, time, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStrategyPortfolioValueChanged(Strategy strategy)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMetaStrategyStarted()
    {
    }
  }
}
