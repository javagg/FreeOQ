// Type: OpenQuant.Projects.StrategyPropertyDescriptor
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.ComponentModel;

namespace OpenQuant.Projects
{
  internal class StrategyPropertyDescriptor : PropertyDescriptor
  {
    private StrategyProperty property;

    public override Type ComponentType
    {
      get
      {
        return typeof (StrategyProperty);
      }
    }

    public override bool IsReadOnly
    {
      get
      {
        return false;
      }
    }

    public override Type PropertyType
    {
      get
      {
        return this.property.Type;
      }
    }

    public override string Category
    {
      get
      {
        return this.property.Category;
      }
    }

    public override string Description
    {
      get
      {
        return this.property.Description;
      }
    }

    public StrategyPropertyDescriptor(StrategyProperty property)
      : base(property.Name, (Attribute[]) null)
    {
      this.property = property;
    }

    public override bool CanResetValue(object component)
    {
      return false;
    }

    public override object GetValue(object component)
    {
      return this.property.Value;
    }

    public override void ResetValue(object component)
    {
      throw new Exception("The method or operation is not implemented.");
    }

    public override void SetValue(object component, object value)
    {
      this.property.Value = value;
    }

    public override bool ShouldSerializeValue(object component)
    {
      return true;
    }
  }
}
