using System;

namespace FreeQuant.Data
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class PriceViewAttribute : ViewAttribute
	{
		public PriceViewAttribute() : base()
		{
		}
	}
}
