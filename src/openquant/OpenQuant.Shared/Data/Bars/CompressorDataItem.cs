using System;

namespace OpenQuant.Shared.Data.Bars
{
	internal class CompressorDataItem
	{
		public DateTime DateTime { get; private set; }

		public BarDataItemList Items { get; private set; }

		public CompressorDataItem(DateTime datetime, BarDataItemList items)
		{
			this.DateTime = datetime;
			this.Items = items;
		}
	}
}
