using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
  public class ScriptSettings : IEnumerable<KeyValuePair<string, object>>, IEnumerable
  {
    private Dictionary<string, object> settings;

    public int Count
    {
      get
      {
        return this.settings.Count;
      }
    }

    public object this[string name]
    {
      get
      {
        object obj = (object) null;
        this.settings.TryGetValue(name, out obj);
        return obj;
      }
      set
      {
        this.settings[name] = value;
      }
    }

    internal ScriptSettings()
    {
      this.settings = new Dictionary<string, object>();
    }

    public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<string, object>>) this.settings.GetEnumerator();
    }

    public void Add(string name, object data)
    {
      this.settings.Add(name, data);
    }

    public void Remove(string name)
    {
      this.settings.Remove(name);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.settings.GetEnumerator();
    }
  }
}
