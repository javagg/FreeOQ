using OpenQuant.API;
using System;
using System.ComponentModel;
using System.Globalization;

namespace OpenQuant.API.Design
{
  internal class AltIDGroupTypeConverter : ExpandableObjectConverter
  {
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (!(destinationType == typeof (string)) || !(value is AltIDGroup))
        return base.ConvertTo(context, culture, value, destinationType);
      AltIDGroup altIdGroup = (AltIDGroup) value;
      if (string.IsNullOrWhiteSpace(altIdGroup.AltExchange) && string.IsNullOrWhiteSpace(altIdGroup.AltSymbol))
        return (object) string.Empty;
      else
        return (object) string.Format("{0}@{1}", (object) altIdGroup.AltSymbol, (object) altIdGroup.AltExchange);
    }
  }
}
