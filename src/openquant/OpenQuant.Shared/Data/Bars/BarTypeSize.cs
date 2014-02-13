using OpenQuant.Shared.Data;
using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Bars
{
	class BarTypeSize
	{
		public BarType BarType { get; private set; }

		public long BarSize { get; private set; }

		public BarTypeSize(BarType barType, long barSize)
		{
			this.BarType = barType;
			this.BarSize = barSize;
		}

		public override string ToString()
		{
			if (this.BarSize == 86400)
				return "Daily";
			else
				return string.Format("Bar {0}", DataSeriesHelper.BarTypeSizeToString(this.BarType, this.BarSize));
		}
	}
}
