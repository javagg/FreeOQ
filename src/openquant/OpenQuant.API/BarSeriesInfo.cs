namespace OpenQuant.API
{
	public class BarSeriesInfo
	{
		public BarType BarType { get; private set; }

		public long BarSize { get; private set; }

		internal BarSeriesInfo(BarType barType, long barSize)
		{
			this.BarType = barType;
			this.BarSize = barSize;
		}
	}
}
