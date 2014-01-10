using System;

namespace FreeQuant.Series
{
	public class IndicatorParameterAttribute : Attribute
	{
		private int number;

		public int Number
		{
			get
			{
				return this.number; 
			}
		}

		public IndicatorParameterAttribute(int Number) : base()
		{
			this.number = Number;
		}
	}
}
