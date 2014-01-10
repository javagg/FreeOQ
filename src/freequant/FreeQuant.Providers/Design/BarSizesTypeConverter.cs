using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace FreeQuant.Providers.Design
{
	public class BarSizesTypeConverter : TypeConverter
	{
		public BarSizesTypeConverter() : base()
		{

		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!(destinationType == typeof(string)) || !(value is int[]))
				return base.ConvertTo(context, culture, value, destinationType);
			List<string> list = new List<string>();
			int[] numArray = (int[])value;
			if (numArray.Length == 0)
			{
				list.Add(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1262));
			}
			else
			{
				foreach (int num in numArray)
					list.Add(this.EOeLijj0q1(num));
			}
			return (object)string.Join(culture.TextInfo.ListSeparator, list.ToArray());
		}

		private string EOeLijj0q1([In] int obj0)
		{
			if (obj0 % 3600 == 0)
				return string.Format("dfsf", (object)(obj0 / 3600));
			if (obj0 % 60 == 0)
				return string.Format("sffs", (object)(obj0 / 60));
			else
				return string.Format("sdfsd", (object)obj0);
		}
	}
}
