using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Design
{
  public class ProviderTypeConverter : TypeConverter
  {
    
    public ProviderTypeConverter()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      return destinationType == typeof (string);
    }

    
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      IProvider provider = value as IProvider;
      if (provider != null)
        return (object) provider.Name;
      else
        return (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(11156);
    }
  }
}
