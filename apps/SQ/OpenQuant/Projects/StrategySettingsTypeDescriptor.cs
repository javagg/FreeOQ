// Type: OpenQuant.Projects.StrategySettingsTypeDescriptor
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.ComponentModel;

namespace OpenQuant.Projects
{
  internal class StrategySettingsTypeDescriptor : ICustomTypeDescriptor
  {
    private StrategySettings settings;

    public StrategySettingsTypeDescriptor(StrategySettings settings)
    {
      this.settings = settings;
    }

    public AttributeCollection GetAttributes()
    {
      return TypeDescriptor.GetAttributes((object) this.settings, true);
    }

    public string GetClassName()
    {
      return TypeDescriptor.GetClassName((object) this.settings, true);
    }

    public string GetComponentName()
    {
      return TypeDescriptor.GetComponentName((object) this.settings, true);
    }

    public TypeConverter GetConverter()
    {
      return TypeDescriptor.GetConverter((object) this.settings, true);
    }

    public EventDescriptor GetDefaultEvent()
    {
      return TypeDescriptor.GetDefaultEvent((object) this.settings, true);
    }

    public PropertyDescriptor GetDefaultProperty()
    {
      return (PropertyDescriptor) null;
    }

    public object GetEditor(Type editorBaseType)
    {
      return TypeDescriptor.GetEditor((object) this.settings, editorBaseType, true);
    }

    public EventDescriptorCollection GetEvents(Attribute[] attributes)
    {
      return TypeDescriptor.GetEvents((object) this.settings, attributes, true);
    }

    public EventDescriptorCollection GetEvents()
    {
      return TypeDescriptor.GetEvents((object) this.settings, true);
    }

    public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      PropertyDescriptorCollection descriptorCollection = new PropertyDescriptorCollection((PropertyDescriptor[]) null);
      foreach (StrategyProperty property in this.settings.StrategyProperties.Values)
        descriptorCollection.Add((PropertyDescriptor) new StrategyPropertyDescriptor(property));
      return descriptorCollection;
    }

    public PropertyDescriptorCollection GetProperties()
    {
      return this.GetProperties((Attribute[]) null);
    }

    public object GetPropertyOwner(PropertyDescriptor pd)
    {
      return (object) this.settings;
    }
  }
}
