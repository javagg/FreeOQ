using FreeQuant.Instruments;
using System;

namespace FreeQuant.Trading
{
	[StrategyComponent("{BE0176A8-3BBD-407c-814A-D5A3E3437899}", ComponentType.RiskManager, Description = "", Name = "Default_RiskManager")]
	public class RiskManager : StrategySingleComponent
	{
		public const string GUID = "{BE0176A8-3BBD-407c-814A-D5A3E3437899}";

		public RiskManager() : base()
		{
		}

		public virtual double GetPositionRisk()
		{
			return 1.0;
		}

		public virtual bool Validate(Signal signal)
		{
			return true;
		}

		public virtual Stop AddStop(Position position, double level, StopType type, StopMode mode)
		{
			if (!this.Strategy.IsInstrumentActive(position.Instrument))
				return null;
			else
				return new Stop(this.Strategy, position, level, type, mode);
		}

		public virtual Stop AddStop(double level, StopType type, StopMode mode)
		{
			if (!this.Strategy.IsInstrumentActive(this.Position.Instrument))
				return null;
			else
				return new Stop(this.Strategy, this.Position, level, type, mode);
		}

		public virtual Stop AddStop(Position position, DateTime time)
		{
			if (!this.Strategy.IsInstrumentActive(position.Instrument))
				return null;
			else
				return new Stop(this.Strategy, position, time);
		}

		public virtual Stop AddStop(DateTime time)
		{
			if (!this.Strategy.IsInstrumentActive(this.Position.Instrument))
				return null;
			else
				return new Stop(this.Strategy, this.Position, time);
		}
	}
}
