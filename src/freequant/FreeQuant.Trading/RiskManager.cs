using FreeQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{BE0176A8-3BBD-407c-814A-D5A3E3437899}", ComponentType.RiskManager, Description = "", Name = "Default_RiskManager")]
  public class RiskManager : StrategySingleComponent
  {
    public const string GUID = "{BE0176A8-3BBD-407c-814A-D5A3E3437899}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RiskManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositionRisk()
    {
      return 1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Validate(Signal signal)
    {
      return true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stop AddStop(Position position, double level, StopType type, StopMode mode)
    {
      if (!this.Strategy.IsInstrumentActive(position.Instrument))
        return (Stop) null;
      else
        return new Stop((StrategyBase) this.Strategy, position, level, type, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stop AddStop(double level, StopType type, StopMode mode)
    {
      if (!this.Strategy.IsInstrumentActive(this.Position.Instrument))
        return (Stop) null;
      else
        return new Stop((StrategyBase) this.Strategy, this.Position, level, type, mode);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stop AddStop(Position position, DateTime time)
    {
      if (!this.Strategy.IsInstrumentActive(position.Instrument))
        return (Stop) null;
      else
        return new Stop((StrategyBase) this.Strategy, position, time);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stop AddStop(DateTime time)
    {
      if (!this.Strategy.IsInstrumentActive(this.Position.Instrument))
        return (Stop) null;
      else
        return new Stop((StrategyBase) this.Strategy, this.Position, time);
    }
  }
}
