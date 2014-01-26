using FreeQuant.Providers;

namespace OpenQuant.API
{
  public class MarketDataProvider : Provider
  {
    public BarFactory BarFactory { get; private set; }

    public MarketDataFilter Filter
    {
      set
      {
        (this.provider as IMarketDataProvider).MarketDataFilter = (IMarketDataFilter) value.SQfilter;
      }
    }

    internal MarketDataProvider(IMarketDataProvider provider)
      : base((IProvider) provider)
    {
      this.provider = (IProvider) provider;
      this.BarFactory = new BarFactory(provider.BarFactory);
    }
  }
}
