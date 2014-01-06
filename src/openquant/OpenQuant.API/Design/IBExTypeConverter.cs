using System;
using System.ComponentModel;
using System.Globalization;

namespace OpenQuant.API.Design
{
  internal class IBExTypeConverter : ExpandableObjectConverter
  {
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      if (context != null && context.Instance != null && destinationType == typeof (string))
        return true;
      else
        return base.CanConvertTo(context, destinationType);
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (context != null && context.Instance != null && destinationType == typeof (string))
        return (object) "";
      else
        return base.ConvertTo(context, culture, value, destinationType);
    }
  }
}
