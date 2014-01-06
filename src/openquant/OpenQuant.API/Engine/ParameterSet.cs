using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
  public class ParameterSet : IEnumerable
  {
    private Dictionary<string, Parameter> parameters;

    public int Count
    {
      get
      {
        return this.parameters.Count;
      }
    }

    public Parameter this[string name]
    {
      get
      {
        return this.parameters[name];
      }
    }

    internal ParameterSet(List<Parameter> list)
    {
      this.parameters = new Dictionary<string, Parameter>();
      foreach (Parameter parameter in list)
        this.parameters[parameter.Name] = parameter;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.parameters.Values.GetEnumerator();
    }

    public bool Contains(string name)
    {
      return this.parameters.ContainsKey(name);
    }

    public bool TryGetValue(string name, out Parameter parameter)
    {
      return this.parameters.TryGetValue(name, out parameter);
    }
  }
}
