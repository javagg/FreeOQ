using System;

namespace OpenQuant.Shared.Indicators
{
	public class IndicatorData
	{
		public Type IndicatorType { get; private set; }

		public IndicatorData(Type indicatorType)
		{
			this.IndicatorType = indicatorType;
		}
	}
}
