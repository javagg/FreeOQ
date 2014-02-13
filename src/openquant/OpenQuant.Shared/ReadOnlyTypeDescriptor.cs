using System;
using System.ComponentModel;

namespace OpenQuant.Shared
{
	public class ReadOnlyTypeDescriptor : CustomTypeDescriptor
	{
		private object component;

		public ReadOnlyTypeDescriptor(object component)
		{
			this.component = component;
		}

		public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection descriptorCollection = new PropertyDescriptorCollection((PropertyDescriptor[])null);
			foreach (PropertyDescriptor parent in TypeDescriptor.GetProperties(this.component, attributes, false))
				descriptorCollection.Add((PropertyDescriptor)new ReadOnlyPropertyDescriptor(parent));
			return descriptorCollection;
		}

		public override object GetPropertyOwner(PropertyDescriptor pd)
		{
			return this.component;
		}
	}
}
