using System.ComponentModel;

namespace OpenQuant.API.Plugins
{
	internal class FQProviderTypeDescriptionProvider : TypeDescriptionProvider
	{
		public FQProviderTypeDescriptionProvider() : base(TypeDescriptor.GetProvider(typeof(FQProvider)))
		{
		}

		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{ 
			if (instance is FQProvider)
				return (ICustomTypeDescriptor)new FQProviderTypeDescriptor(instance as FQProvider);
			else
				return base.GetExtendedTypeDescriptor(instance);
		}
	}
}
