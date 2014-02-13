using OpenQuant.Shared.Data;
using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.TradingTools
{
	class BarSizeInfo : IComparable
	{
		private BarType barType;
		private long barSize;

		public BarSizeInfo(BarType barType, long barSize)
		{
			this.barType = barType;
			this.barSize = barSize;
		}

		public override string ToString()
		{
			if (this.barSize <= 0)
				return string.Empty;
			else
				return DataSeriesHelper.BarTypeSizeToString(this.barType, this.barSize);
		}

		public int CompareTo(object obj)
		{
			if (!(obj is BarSizeInfo))
				return 0;
			BarSizeInfo barSizeInfo = obj as BarSizeInfo;
			if (this.barType == barSizeInfo.barType)
				return this.barSize.CompareTo(barSizeInfo.barSize);
			else
				return string.Compare(this.barType.ToString(), barSizeInfo.barType.ToString());
		}
	}
}
