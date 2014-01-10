using System;

namespace FreeQuant.FIX
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
	public class FIXFieldAttribute : Attribute
	{
		protected int tag;
		protected bool required;

		public int Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				this.tag = value;
			}
		}

		public bool Required
		{
			get
			{
				return this.required;
			}
			set
			{
				this.required = value;
			}
		}

		public FIXFieldAttribute(int tag) : base()
		{
			this.tag = tag;
		}

		public FIXFieldAttribute(string tag, EFieldOption required) : base()
		{
			this.tag = int.Parse(tag);
			if (required != EFieldOption.Required)
				return;
			this.required = true;
		}
	}
}
