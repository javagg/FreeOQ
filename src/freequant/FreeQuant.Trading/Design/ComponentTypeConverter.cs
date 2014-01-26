using FreeQuant.Trading;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Design
{
  public class ComponentTypeConverter : TypeConverter
  {
    
		public ComponentTypeConverter():base()
    {
    }

    
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      return destinationType == typeof (string);
    }

    
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      IComponentBase componentBase = value as IComponentBase;
      if (componentBase != null)
        return (object) componentBase.Name;
      else
        return (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(2260);
    }
  }
}
