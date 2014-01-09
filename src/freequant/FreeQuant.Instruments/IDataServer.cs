using FreeQuant.Data;
using FreeQuant.Series;
using System;

namespace FreeQuant.Instruments
{
	public interface IDataServer
	{
		void Add(string series, IDataObject obj);

		void Remove(string series, DateTime dateTime);

		void Update(string series, IDataObject obj);

		TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2);

		QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2);

		BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2);

		DailySeries GetDailySeries(string series, DateTime datetime1, DateTime datetime2);

		MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2);

		IDataSeries AddDataSeries(string series);

		IDataSeries GetDataSeries(string series);

		DataSeriesList GetDataSeries();

		void Delete(string series);

		void Clear(string series);

		void Rename(string oldSeries, string newSeries);

		void Flush();

		void Close();
	}
}
