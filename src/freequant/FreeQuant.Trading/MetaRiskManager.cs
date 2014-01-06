// Type: SmartQuant.Trading.MetaRiskManager
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  [StrategyComponent("{521B9C4F-01AE-4488-B4A5-104027D06BB8}", ComponentType.MetaRiskManager, Description = "", Name = "Default_MetaRiskManager")]
  public class MetaRiskManager : MetaStrategyComponent
  {
    public const string GUID = "{521B9C4F-01AE-4488-B4A5-104027D06BB8}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MetaRiskManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

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
