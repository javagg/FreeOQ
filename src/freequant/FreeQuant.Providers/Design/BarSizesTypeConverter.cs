// Type: SmartQuant.Providers.Design.BarSizesTypeConverter
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Providers.Design
{
  public class BarSizesTypeConverter : TypeConverter
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSizesTypeConverter()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
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
      if (!(destinationType == typeof (string)) || !(value is int[]))
        return base.ConvertTo(context, culture, value, destinationType);
      List<string> list = new List<string>();
      int[] numArray = (int[]) value;
      if (numArray.Length == 0)
      {
        list.Add(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1262));
      }
      else
      {
        foreach (int num in numArray)
          list.Add(this.EOeLijj0q1(num));
      }
      return (object) string.Join(culture.TextInfo.ListSeparator, list.ToArray());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string EOeLijj0q1([In] int obj0)
    {
      if (obj0 % 3600 == 0)
        return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1294), (object) (obj0 / 3600));
      if (obj0 % 60 == 0)
        return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1312), (object) (obj0 / 60));
      else
        return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1328), (object) obj0);
    }
  }
}
