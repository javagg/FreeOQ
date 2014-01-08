using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Design
{
  public class FlagsEnumTypeConverter : ExpandableObjectConverter
  {
    public FlagsEnumTypeConverter()
    {
    }

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
      return (PropertyDescriptorCollection) null;
    }
  }
}
