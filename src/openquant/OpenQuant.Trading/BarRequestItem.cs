using FreeQuant.Data;

namespace OpenQuant.Trading
{
	internal class BarRequestItem
	{
		public BarType BarType;
		public long BarSize;

		public BarRequestItem(BarType barType, long barSize)
		{
			this.BarType = barType;
			this.BarSize = barSize;
		}
	}
}
