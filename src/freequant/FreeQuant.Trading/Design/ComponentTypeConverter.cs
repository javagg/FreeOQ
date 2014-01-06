// Type: SmartQuant.Trading.Design.ComponentTypeConverter
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant.Trading;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Design
{
  public class ComponentTypeConverter : TypeConverter
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComponentTypeConverter()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      return destinationType == typeof (string);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
