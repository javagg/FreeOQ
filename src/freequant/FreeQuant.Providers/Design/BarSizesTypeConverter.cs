using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

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
			if (destinationType == typeof(string) && value is int[])
			{
				List<string> list = new List<string>();
				int[] array = (int[])value;
				if (array.Length == 0)
				{
					list.Add("Nothing");
				}
				else
				{
					int[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						int num = array2[i];
						list.Add(this.EOeLijj0q1(num));
					}
				}
				return string.Join(culture.TextInfo.ListSeparator, list.ToArray());
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		private string EOeLijj0q1(int obj0)
		{
			if (obj0 % 3600 == 0)
				return string.Format("Hours", obj0 / 3600);
			if (obj0 % 60 == 0)
				return string.Format("Minutes", obj0 / 60);
			else
				return string.Format("Seconds", obj0);
		}
	}
}
