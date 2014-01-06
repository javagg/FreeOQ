using OpenQuant.API;
using System;
using System.ComponentModel;
using System.Globalization;

namespace OpenQuant.API.Design
{
  internal class AltIDGroupListTypeConverter : ArrayConverter
  {
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (value is AltIDGroupList && destinationType == typeof (string))
        return (object) string.Format("{0} Alt Group(s)", (object) ((AltIDGroupList) value).Count);
      else
        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
      PropertyDescriptorCollection descriptorCollection = new PropertyDescriptorCollection((PropertyDescriptor[]) null);
      AltIDGroupList altIdGroupList = (AltIDGroupList) value;
      int num = 0;
      foreach (AltIDGroup group in altIdGroupList)
      {
        AltIDGroupPropertyDescriptor propertyDescriptor = new AltIDGroupPropertyDescriptor(group, num++);
        descriptorCollection.Add((PropertyDescriptor) propertyDescriptor);
      }
      return descriptorCollection;
    }
  }
}
