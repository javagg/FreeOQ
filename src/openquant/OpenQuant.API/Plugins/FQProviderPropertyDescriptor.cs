using System;
using System.ComponentModel;

namespace OpenQuant.API.Plugins
{
  internal class FQProviderPropertyDescriptor : PropertyDescriptor
  {
    private PropertyDescriptor parent;

    public override Type ComponentType
    {
      get
      {
        return this.parent.ComponentType;
      }
    }

    public override bool IsReadOnly
    {
      get
      {
        return this.parent.IsReadOnly;
      }
    }

    public override Type PropertyType
    {
      get
      {
        return this.parent.PropertyType;
      }
    }

    public FQProviderPropertyDescriptor(PropertyDescriptor parent)
      : base((MemberDescriptor)parent)
    {
      this.parent = parent;
    }

    public override bool CanResetValue(object component)
    {
      return this.parent.CanResetValue((object)(component as FQProvider).UserProvider);
    }

    public override object GetValue(object component)
    {
      return this.parent.GetValue((object)(component as FQProvider).UserProvider);
    }

    public override void ResetValue(object component)
    {
      this.parent.ResetValue((object)(component as FQProvider).UserProvider);
    }

    public override void SetValue(object component, object value)
    {
      this.parent.SetValue((object)(component as FQProvider).UserProvider, value);
    }

    public override bool ShouldSerializeValue(object component)
    {
      return this.parent.ShouldSerializeValue((object) (component as FQProvider).UserProvider);
    }
  }
}
