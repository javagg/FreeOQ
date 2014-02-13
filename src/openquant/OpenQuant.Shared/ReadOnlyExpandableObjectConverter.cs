using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace OpenQuant.Shared
{
	internal class ReadOnlyExpandableObjectConverter : ExpandableObjectConverter
	{
		private ExpandableObjectConverter parent;

		public ReadOnlyExpandableObjectConverter(ExpandableObjectConverter parent)
		{
			this.parent = parent;
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return this.parent.CanConvertFrom(context, sourceType);
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return this.parent.CanConvertTo(context, destinationType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return this.parent.ConvertFrom(context, culture, value);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return this.parent.ConvertTo(context, culture, value, destinationType);
		}

		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			return this.parent.CreateInstance(context, propertyValues);
		}

		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return this.parent.GetCreateInstanceSupported(context);
		}

		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return this.parent.GetStandardValues(context);
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return this.parent.GetStandardValuesExclusive(context);
		}

		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return this.parent.GetStandardValuesSupported(context);
		}

		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			return this.parent.IsValid(context, value);
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return this.parent.GetPropertiesSupported(context);
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			PropertyDescriptorCollection descriptorCollection = new PropertyDescriptorCollection((PropertyDescriptor[])null);
			foreach (PropertyDescriptor parent in this.parent.GetProperties(context, value, attributes))
				descriptorCollection.Add((PropertyDescriptor)new ReadOnlyPropertyDescriptor(parent));
			return descriptorCollection;
		}
	}
}
