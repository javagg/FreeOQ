using OpenQuant.API;
using System;
using System.ComponentModel;

namespace OpenQuant.API.Design
{
  internal class AltIDGroupPropertyDescriptor : PropertyDescriptor
  {
    private AltIDGroup group;
    private int index;

    public override TypeConverter Converter
    {
      get
      {
        return (TypeConverter) new AltIDGroupTypeConverter();
      }
    }

    public override AttributeCollection Attributes
    {
      get
      {
        return new AttributeCollection((Attribute[]) null);
      }
    }

    public override Type ComponentType
    {
      get
      {
        return typeof (AltIDGroupList);
      }
    }

    public override string DisplayName
    {
      get
      {
        return string.Format("[{0}] {1}", (object) this.index, (object) this.group.AltSource);
      }
    }

    public override string Description
    {
      get
      {
        return this.group.AltSource;
      }
    }

    public override bool IsReadOnly
    {
      get
      {
        return false;
      }
    }

    public override string Name
    {
      get
      {
        return this.group.AltSource;
      }
    }

    public override Type PropertyType
    {
      get
      {
        return typeof (AltIDGroup);
      }
    }

    public AltIDGroupPropertyDescriptor(AltIDGroup group, int index)
      : base(group.AltSource, (Attribute[]) null)
    {
      this.group = group;
      this.index = index;
    }

    public override bool CanResetValue(object component)
    {
      return true;
    }

    public override object GetValue(object component)
    {
      return (object) this.group;
    }

    public override void ResetValue(object component)
    {
    }

    public override bool ShouldSerializeValue(object component)
    {
      return true;
    }

    public override void SetValue(object component, object value)
    {
    }
  }
}
