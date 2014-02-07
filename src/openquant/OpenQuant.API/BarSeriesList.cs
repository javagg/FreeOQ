using OpenQuant.ObjectMap;

namespace OpenQuant.API
{
	///<summary>
	///  A list of bar series 
	///</summary>
	public class BarSeriesList
	{
		///<summary>
		///  Initializes a new instance of this class
		///</summary>
		public BarSeriesList() {}

		///<summary>
		///  Gets bar series by instrument, bar type and bar size
		///</summary>
		public BarSeries this [Instrument instrument, BarType barType, long barSize]
		{
			get
			{
				return new BarSeries(FreeQuant.Instruments.DataManager.Bars[Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, EnumConverter.Convert(barType), barSize]);
			}
		}

		///<summary>
		///  Returns bar series by instrument 
		///</summary>
		public BarSeries this [Instrument instrument]
		{
			get
			{
				return new BarSeries(FreeQuant.Instruments.DataManager.Bars[Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument]);
			}
		}
	}
}
