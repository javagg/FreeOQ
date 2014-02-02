using FreeQuant.Instruments;

namespace FreeQuant.Trading
{
	public interface IStrategyComponent
	{
		StrategyBase StrategyBase { get; }
		Portfolio Portfolio { get; }
	}
}
