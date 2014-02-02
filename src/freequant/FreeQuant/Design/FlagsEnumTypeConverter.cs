using System;
using System.ComponentModel;

namespace FreeQuant.Design
{
  public class FlagsEnumTypeConverter : ExpandableObjectConverter
  {
		public FlagsEnumTypeConverter()
		{
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}
  }
}
