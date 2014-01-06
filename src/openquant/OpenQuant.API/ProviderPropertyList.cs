using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
  public class ProviderPropertyList : IEnumerable<ProviderProperty>, IEnumerable
  {
    private Dictionary<string, ProviderProperty> properties;

    public int Count
    {
      get
      {
        return this.properties.Count;
      }
    }

    public ProviderProperty this[string name]
    {
      get
      {
        return this.properties[name];
      }
    }

    internal ProviderPropertyList()
    {
      this.properties = new Dictionary<string, ProviderProperty>();
    }

    public IEnumerator<ProviderProperty> GetEnumerator()
    {
      return (IEnumerator<ProviderProperty>) this.properties.Values.GetEnumerator();
    }

    internal void Add(ProviderProperty property)
    {
      this.properties.Add(property.Name, property);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.properties.GetEnumerator();
    }
  }
}
