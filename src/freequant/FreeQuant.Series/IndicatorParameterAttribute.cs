using System;

namespace FreeQuant.Series
{
	public class IndicatorParameterAttribute : Attribute
	{
		public int Number	{ get; private set; }
		public IndicatorParameterAttribute(int number) : base()
		{
			this.Number = number;
		}
	}
}
