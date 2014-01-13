using OpenQuant.ObjectMap;
using FreeQuant.Providers;
using System;

namespace OpenQuant.API
{
	///<summary>
	///  Settings of the historical data request
	///</summary>
	public class HistoricalDataRequest
	{
		internal FreeQuant.Providers.HistoricalDataRequest request;

		///<summary>
		///  Gets instrument
		///</summary>
		public Instrument Instrument
		{
			get
			{
				return Map.SQ_OQ_Instrument[(object)this.request.Instrument] as Instrument;
			}
		}

		///<summary>
		///  Gets DataType
		///</summary>
		public DataType DataType
		{
			get
			{
				switch (this.request.DataType)
				{
					case HistoricalDataType.Trade:
						return DataType.Trade;
					case HistoricalDataType.Quote:
						return DataType.Quote;
					case HistoricalDataType.Bar:
						return DataType.Bar;
					case HistoricalDataType.Daily:
						return DataType.Daily;
					default:
						throw new ArgumentException(string.Format("Not supported data type - {0}", this.request.DataType));
				}
			}
		}

		///<summary>
		///  Gets size of requested bars(in seconds)
		///</summary>
		public long BarSize
		{
			get
			{
				return this.request.BarSize;
			}
		}

		///<summary>
		///  Gets begin datetime 
		///</summary>
		public DateTime BeginDate
		{
			get
			{
				return this.request.BeginDate;
			}
		}

		///<summary>
		///  Gets end datetime
		///</summary>
		public DateTime EndDate
		{
			get
			{
				return this.request.EndDate;
			}
		}

		internal HistoricalDataRequest(FreeQuant.Providers.HistoricalDataRequest request)
		{
			this.request = request;
		}
	}
}
