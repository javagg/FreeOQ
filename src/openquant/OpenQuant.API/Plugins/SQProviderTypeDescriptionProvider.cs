using System.ComponentModel;

namespace OpenQuant.API.Plugins
{
  internal class SQProviderTypeDescriptionProvider : TypeDescriptionProvider
  {
    public SQProviderTypeDescriptionProvider()
      : base(TypeDescriptor.GetProvider(typeof (SQProvider)))
    {
    }

    public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
    {
      if (instance is SQProvider)
        return (ICustomTypeDescriptor) new SQProviderTypeDescriptor(instance as SQProvider);
      else
        return base.GetExtendedTypeDescriptor(instance);
    }
  }
}
