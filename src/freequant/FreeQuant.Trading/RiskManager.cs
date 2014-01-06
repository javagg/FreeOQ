// Type: SmartQuant.Trading.RiskManager
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
