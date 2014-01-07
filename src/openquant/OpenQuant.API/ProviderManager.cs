using FreeQuant.Providers;

namespace OpenQuant.API
{
  public static class ProviderManager
  {
    public static ProviderList Providers { get; private set; }

    static ProviderManager()
    {
      ProviderManager.Providers = new ProviderList();
      foreach (IProvider provider in FreeQuant.Providers.ProviderManager.Providers)
      {
        if (provider is IMarketDataProvider)
          ProviderManager.Providers.Add((Provider) new MarketDataProvider(provider as IMarketDataProvider));
        else if (provider is IExecutionProvider)
          ProviderManager.Providers.Add((Provider) new ExecutionProvider(provider as IExecutionProvider));
        else if (provider is IHistoricalDataProvider)
          ProviderManager.Providers.Add((Provider) new HistoricalDataProvider(provider as IHistoricalDataProvider));
        else if (provider is IInstrumentProvider)
          ProviderManager.Providers.Add((Provider) new InstrumentProvider(provider as IInstrumentProvider));
      }
      FreeQuant.Providers.ProviderManager.Added += new ProviderEventHandler(ProviderManager.ProviderManager_Added);
    }

    private static void ProviderManager_Added(ProviderEventArgs args)
    {
      ProviderManager.Providers.Add(new Provider(args.Provider));
    }
  }
}
