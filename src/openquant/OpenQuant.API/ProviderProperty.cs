using SmartQuant.Providers;
using System;
using System.Reflection;

namespace OpenQuant.API
{
  public class ProviderProperty
  {
    private PropertyInfo property;
    private IProvider provider;

    public string Name
    {
      get
      {
        return this.property.Name;
      }
    }

    public object Value
    {
      get
      {
        return this.property.GetValue((object) this.provider, (object[]) null);
      }
      set
      {
        this.property.SetValue((object) this.provider, value, (object[]) null);
      }
    }

    public Type Type
    {
      get
      {
        return this.property.PropertyType;
      }
    }

    internal ProviderProperty(PropertyInfo property, IProvider provider)
    {
      this.property = property;
      this.provider = provider;
    }
  }
}
