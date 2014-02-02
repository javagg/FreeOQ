using FreeQuant.Instruments;

namespace FreeQuant.Trading
{
	public interface IMetaStrategyComponent
	{
		MetaStrategyBase MetaStrategyBase { get; }
		Portfolio Portfolio { get; }
	}
}
