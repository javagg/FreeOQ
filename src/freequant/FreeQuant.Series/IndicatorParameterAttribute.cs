using System;

namespace FreeQuant.Series
{
	public class IndicatorParameterAttribute : Attribute
	{
		public int Number	{ get; private set; }
		public IndicatorParameterAttribute(int Number) : base()
		{
			this.Number = Number;
		}
	}
}
