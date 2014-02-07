using FreeQuant;
using FreeQuant.Data;
using FreeQuant.File;
using FreeQuant.Series;
using System;

namespace FreeQuant.Instruments
{
	public class FileDataServer : IDataServer
	{
		private DataFile file;

		public DataFile File
		{
			get
			{
				return this.file;
			}
		}

		public FileDataServer()
		{
			this.file = new DataFile("FreeQuant", Framework.Installation.DataDir.FullName);
		}

		public void Add(string series, IDataObject obj)
		{
			(this.file.Series[series] ?? this.file.Series.Add(series)).Add(obj.DateTime, obj);
		}

		public void Remove(string series, DateTime datetime)
		{
			IDataSeries dataSeries = this.file.Series[series];
			if (dataSeries != null)
			{
				dataSeries.Remove(datetime);
			}
		}

		public void Update(string series, IDataObject obj)
		{
			((IDataSeries)this.file.Series[series] ?? (IDataSeries)this.file.Series.Add(series)).Update(obj.DateTime, (object)obj);
		}

		public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
		{
			TradeArray trades = new TradeArray();
			if (this.file.Series[series] != null)
			{
				foreach (Trade trade in this.file.Series[series].GetArray(datetime1, datetime2))
					trades.Add(trade);
			}
			return trades;
		}

		public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
		{
			QuoteArray quotes = new QuoteArray();
			if (this.file.Series[series] != null)
			{
				foreach (Quote quote in this.file.Series[series].GetArray(datetime1, datetime2))
					quotes.Add(quote);
			}
			return quotes;
		}

		public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
		{
			BarSeries bars = new BarSeries();
			if (this.file.Series[series] != null)
			{
				foreach (Bar bar in this.file.Series[series].GetArray(datetime1, datetime2))
					bars.Add(bar);
			}
			return bars;
		}

		public DailySeries GetDailySeries(string seriesName, DateTime datetime1, DateTime datetime2)
		{
			DailySeries dailies = new DailySeries();
			FileSeries fs = this.file.Series[seriesName];
			if (fs != null)
			{
				foreach (Daily daily in fs.GetArray(datetime1, datetime2))
					dailies.Add(daily);
			}
			return dailies;
		}

		public MarketDepthArray GetMarketDepthArray(string seriesName, DateTime datetime1, DateTime datetime2)
		{
			MarketDepthArray array = new MarketDepthArray();
			FileSeries fs = this.file.Series[seriesName];
			if (fs != null)
			{
				foreach (MarketDepth marketDepth in fs.GetArray(datetime1, datetime2))
					array.Add(marketDepth);
			}
			return array;
		}

		public IDataSeries GetDataSeries(string series)
		{
			return this.file.Series[series];
		}

		public IDataSeries AddDataSeries(string series)
		{
			return this.file.Series.Add(series);
		}

		public void Delete(string series)
		{
			this.file.Series.Remove(series);
		}

		public void Clear(string series)
		{
			this.file.Series[series].Clear();
		}

		public void Rename(string oldSeries, string newSeries)
		{
			this.file.Series.Rename(oldSeries, newSeries);
		}

		public DataSeriesList GetDataSeries()
		{
			DataSeriesList list = new DataSeriesList();
			foreach (FileSeries fs in this.file.Series)
				list.Add(fs);
			return list;
		}

		public void Flush()
		{
			foreach (FileSeries fs in this.file.Series)
				fs.Flush();
		}

		public void Close()
		{
			this.file.Close();
		}
	}
}
