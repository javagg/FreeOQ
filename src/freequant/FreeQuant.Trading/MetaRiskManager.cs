using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{521B9C4F-01AE-4488-B4A5-104027D06BB8}", ComponentType.MetaRiskManager, Description = "", Name = "Default_MetaRiskManager")]
  public class MetaRiskManager : MetaStrategyComponent
  {
    public const string GUID = "{521B9C4F-01AE-4488-B4A5-104027D06BB8}";


    
    public virtual double GetPortfolioRisk()
    {
      return 1.0;
    }

    
    public virtual void AddStop(Strategy strategy, double level, StopType type, StopMode mode, bool stopStrategy)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, level, type, mode, stopStrategy);
    }

    
    public virtual void AddStop(Strategy strategy, DateTime time, bool stopStrategy)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, time, stopStrategy);
    }

    
    public virtual void AddStop(Strategy strategy, double level, StopType type, StopMode mode)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, level, type, mode, true);
    }

    
    public virtual void AddStop(Strategy strategy, DateTime time)
    {
      PortfolioStop portfolioStop = new PortfolioStop((StrategyBase) strategy, time, true);
    }

    
    public virtual void OnStrategyPortfolioValueChanged(Strategy strategy)
    {
    }

    
    public virtual void OnMetaStrategyStarted()
    {
    }
  }
}
