using OpenQuant.Shared.Data;
using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Import.Historical
{
	class BarSizeItem
	{
		public long BarSize { get; private set; }

		public BarSizeItem(long barSize)
		{
			this.BarSize = barSize;
		}

		public override string ToString()
		{
			return DataSeriesHelper.BarTypeSizeToString(BarType.Time, this.BarSize);
		}
	}
}
