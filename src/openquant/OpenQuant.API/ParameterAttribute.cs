using System;

namespace OpenQuant.API
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public class ParameterAttribute : Attribute
  {
    private string category;
    private string description;

    public string Category
    {
      get
      {
        return this.category;
      }
    }

    public string Description
    {
      get
      {
        return this.description;
      }
    }

    public ParameterAttribute(string description, string category)
    {
      this.category = category;
      this.description = description;
    }

    public ParameterAttribute(string description)
      : this(description, "Parameters")
    {
    }

    public ParameterAttribute()
      : this("")
    {
    }
  }
}
