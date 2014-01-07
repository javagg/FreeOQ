// Type: OpenQuant.Options.ProviderItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Providers;

namespace OpenQuant.Options
{
  internal class ProviderItem
  {
    private IProvider provider;

    public IProvider Provider
    {
      get
      {
        return this.provider;
      }
    }

    public IMarketDataProvider MarketDataProvider
    {
      get
      {
        return this.provider as IMarketDataProvider;
      }
    }

    public IExecutionProvider ExecutionProvider
    {
      get
      {
        return this.provider as IExecutionProvider;
      }
    }

    public ProviderItem(IProvider provider)
    {
      this.provider = provider;
    }

    public override string ToString()
    {
      return this.provider.Name;
    }

    public override bool Equals(object obj)
    {
      return this.provider == obj;
    }

    public override int GetHashCode()
    {
      return this.provider.GetHashCode();
    }
  }
}
