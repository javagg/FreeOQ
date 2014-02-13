using System;
using System.ComponentModel;

namespace OpenQuant.Shared
{
  internal class ReadOnlyPropertyDescriptor : PropertyDescriptor
  {
    private PropertyDescriptor parent;

    public override Type ComponentType
    {
      get
      {
        return this.parent.ComponentType;
      }
    }

    public override TypeConverter Converter
    {
      get
      {
        TypeConverter converter = base.Converter;
        if (converter is ExpandableObjectConverter)
          return (TypeConverter) new ReadOnlyExpandableObjectConverter(converter as ExpandableObjectConverter);
        else
          return converter;
      }
    }

    public override bool IsReadOnly
    {
      get
      {
        return true;
      }
    }

    public override Type PropertyType
    {
      get
      {
        return this.parent.PropertyType;
      }
    }

    public ReadOnlyPropertyDescriptor(PropertyDescriptor parent)      : base((MemberDescriptor) parent)
    {
      this.parent = parent;
    }

    public override bool CanResetValue(object component)
    {
      return this.parent.CanResetValue(component);
    }

    public override object GetValue(object component)
    {
      return this.parent.GetValue(component);
    }

    public override void ResetValue(object component)
    {
      this.parent.ResetValue(component);
    }

    public override void SetValue(object component, object value)
    {
      this.parent.SetValue(component, value);
    }

    public override bool ShouldSerializeValue(object component)
    {
      return this.parent.ShouldSerializeValue(component);
    }
  }
}
