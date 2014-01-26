using System;

namespace FreeQuant.FIX
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
	public class FIXFieldAttribute : Attribute
	{
		//		protected int tag;
		//		protected bool required;
		protected int Tag { get; set; }

		public bool Required { get; set; }

		public FIXFieldAttribute(int tag) : base()
		{
			this.Tag = tag;
		}

		public FIXFieldAttribute(string tag, EFieldOption required) : base()
		{
			this.Tag = int.Parse(tag);
			this.Required = required == EFieldOption.Required;
		}
	}
}
