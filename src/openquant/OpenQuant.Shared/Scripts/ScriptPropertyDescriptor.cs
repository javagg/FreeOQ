using System;
using System.ComponentModel;

namespace OpenQuant.Shared.Scripts
{
	class ScriptPropertyDescriptor : PropertyDescriptor
	{
		private ScriptProperty property;

		public override Type ComponentType
		{
			get
			{
				return typeof(ScriptProperty);
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public override Type PropertyType
		{
			get
			{
				return this.property.Type;
			}
		}

		public override string Category
		{
			get
			{
				return this.property.Category;
			}
		}

		public override string Description
		{
			get
			{
				return this.property.Description;
			}
		}

		public ScriptPropertyDescriptor(ScriptProperty property)
      : base(property.Name, null)
		{
			this.property = property;
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override object GetValue(object component)
		{
			return this.property.Value;
		}

		public override void ResetValue(object component)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		public override void SetValue(object component, object value)
		{
			this.property.Value = value;
		}

		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}
	}
}
