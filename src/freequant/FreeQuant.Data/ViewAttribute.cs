using System;

namespace FreeQuant.Data
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class ViewAttribute : Attribute
	{
		public ViewAttribute() : base()
		{
		}
	}
}
