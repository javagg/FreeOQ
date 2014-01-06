using System;

namespace OpenQuant.API.Engine
{
  public class Parameter
  {
    public string Name { get; set; }

    public object Value { get; set; }

    public Type Type { get; private set; }

    public Parameter(string name, object value, Type type)
    {
      this.Name = name;
      this.Value = value;
      this.Type = type;
    }
  }
}
