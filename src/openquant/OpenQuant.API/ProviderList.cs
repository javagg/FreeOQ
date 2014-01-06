using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
  public class ProviderList : IEnumerable<Provider>, IEnumerable
  {
    private Dictionary<string, Provider> providers;
    private Dictionary<byte, Provider> providersIds;

    public int Count
    {
      get
      {
        return this.providers.Count;
      }
    }

    public Provider this[string name]
    {
      get
      {
        Provider provider = (Provider) null;
        this.providers.TryGetValue(name, out provider);
        return provider;
      }
    }

    public Provider this[byte id]
    {
      get
      {
        return this.providersIds[id];
      }
    }

    internal ProviderList()
    {
      this.providers = new Dictionary<string, Provider>();
      this.providersIds = new Dictionary<byte, Provider>();
    }

    public IEnumerator<Provider> GetEnumerator()
    {
      return (IEnumerator<Provider>) this.providers.Values.GetEnumerator();
    }

    internal void Add(Provider provider)
    {
      this.providers.Add(provider.Name, provider);
      this.providersIds.Add(provider.Id, provider);
    }

    internal void Remove(Provider provider)
    {
      this.providers.Remove(provider.Name);
      this.providersIds.Remove(provider.Id);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.providers.Values.GetEnumerator();
    }
  }
}
