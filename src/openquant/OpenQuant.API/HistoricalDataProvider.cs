using FreeQuant.Providers;

namespace OpenQuant.API
{
	public class HistoricalDataProvider : Provider
	{
		internal HistoricalDataProvider(IHistoricalDataProvider provider)
      : base((IProvider)provider)
		{
		}
	}
}
