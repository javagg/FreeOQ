using FreeQuant.FIX;
using System;
using System.ComponentModel;

namespace OpenQuant.Shared.Data.Import.Instruments
{
	internal class FIXFieldPropertyDescriptor : PropertyDescriptor
	{
		private FIXField field;
		private string category;

		public override Type ComponentType
		{
			get
			{
				return typeof(FIXField);
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		public override Type PropertyType
		{
			get
			{
				return this.field.GetValue().GetType();
			}
		}

		public override string Category
		{
			get
			{
				return this.category;
			}
		}

		public FIXFieldPropertyDescriptor(FIXField field, string category)
      : base(EFIXField.ToString((int)field.Tag), (Attribute[])null)
		{
			this.field = field;
			this.category = category;
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override object GetValue(object component)
		{
			return this.field.GetValue();
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
