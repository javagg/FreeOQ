namespace OpenQuant.API
{
	///<summary>
	///  Represents bar series information
	///</summary>
	public class BarSeriesInfo
	{
		///<summary>
		///  Gets BarType bar type
		///</summary>
		public BarType BarType { get; private set; }

		///<summary>
		///  Gets bar size
		///</summary>
		public long BarSize { get; private set; }

		internal BarSeriesInfo(BarType barType, long barSize)
		{
			this.BarType = barType;
			this.BarSize = barSize;
		}
	}
}
