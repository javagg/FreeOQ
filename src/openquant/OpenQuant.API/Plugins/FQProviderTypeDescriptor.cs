using System;
using System.ComponentModel;

namespace OpenQuant.API.Plugins
{
	internal class FQProviderTypeDescriptor : CustomTypeDescriptor
	{
		private FQProvider provider;

		public FQProviderTypeDescriptor(FQProvider provider)
		{
			this.provider = provider;
		}

		public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection descriptorCollection = new PropertyDescriptorCollection((PropertyDescriptor[])null);
			foreach (PropertyDescriptor parent in TypeDescriptor.GetProperties((object) this.provider.UserProvider, attributes, false))
				descriptorCollection.Add((PropertyDescriptor)new FQProviderPropertyDescriptor(parent));
			return descriptorCollection;
		}
	}
}
