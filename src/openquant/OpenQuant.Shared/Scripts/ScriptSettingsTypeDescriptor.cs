using System;
using System.ComponentModel;

namespace OpenQuant.Shared.Scripts
{
	class ScriptSettingsTypeDescriptor : ICustomTypeDescriptor
	{
		private ScriptSettings settings;

		public ScriptSettingsTypeDescriptor(ScriptSettings settings)
		{
			this.settings = settings;
		}

		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this.settings, true);
		}

		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this.settings, true);
		}

		public string GetComponentName()
		{
			return TypeDescriptor.GetComponentName((object)this.settings, true);
		}

		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this.settings, true);
		}

		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this.settings, true);
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this.settings, editorBaseType, true);
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this.settings, attributes, true);
		}

		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this.settings, true);
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection descriptorCollection = new PropertyDescriptorCollection((PropertyDescriptor[])null);
			foreach (ScriptProperty property in this.settings.ScriptProperties.Values)
				descriptorCollection.Add((PropertyDescriptor)new ScriptPropertyDescriptor(property));
			return descriptorCollection;
		}

		public PropertyDescriptorCollection GetProperties()
		{
			return this.GetProperties(null);
		}

		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return   this.settings;
		}
	}
}
