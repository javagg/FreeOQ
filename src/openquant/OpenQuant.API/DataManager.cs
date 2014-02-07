using OpenQuant.API.Compression;
using OpenQuant.Config;
using OpenQuant.ObjectMap;
using FreeQuant.Data;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;

namespace OpenQuant.API
{
	public class DataManager
	{
		public static BarSeries GetHistoricalBars(Instrument instrument, DateTime begin, DateTime end, BarType barType, long barSize)
		{
			FreeQuant.Instruments.Instrument instrument1 = Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument;
			if (barSize == 86400)
				return new BarSeries((FreeQuant.Series.BarSeries)FreeQuant.Instruments.DataManager.GetDailySeries(instrument1, begin, end));
			else
				return new BarSeries(FreeQuant.Instruments.DataManager.GetBarSeries(instrument1, begin, end, EnumConverter.Convert(barType), barSize));
		}

		public static BarSeries GetHistoricalBars(Instrument instrument, BarType barType, long barSize)
		{
			return DataManager.GetHistoricalBars(instrument, DateTime.MinValue, DateTime.MaxValue, barType, barSize);
		}

		public static BarSeries GetHistoricalBars(Instrument instrument)
		{
			return DataManager.GetHistoricalBars(instrument, DateTime.MinValue, DateTime.MaxValue);
		}

		public static BarSeries GetHistoricalBars(Instrument instrument, DateTime begin, DateTime end)
		{
			return new BarSeries(FreeQuant.Instruments.DataManager.GetBarSeries(Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, begin, end));
		}

		public static BarSeries GetHistoricalBars(string provider, Instrument instrument, DateTime begin, DateTime end, int size)
		{
			BarSeries barSeries = new BarSeries();
			if (FreeQuant.Providers.ProviderManager.HistoricalDataProviders.Contains(provider))
			{
				IHistoricalDataProvider provider1 = FreeQuant.Providers.ProviderManager.HistoricalDataProviders[provider];
				foreach (FreeQuant.Data.Bar bar in size != 86400 ? (FreeQuant.Series.TimeSeries) FreeQuant.Instruments.DataManager.GetHistoricalBars(provider1, instrument.instrument, begin, end, (long) size) : (FreeQuant.Series.TimeSeries) FreeQuant.Instruments.DataManager.GetHistoricalDailies(provider1, instrument.instrument, begin, end))
					barSeries.series.Add(bar);
			}
			return barSeries;
		}

		public static TradeSeries GetHistoricalTrades(string provider, Instrument instrument, DateTime begin, DateTime end)
		{
			TradeSeries tradeSeries = new TradeSeries();
			if (FreeQuant.Providers.ProviderManager.HistoricalDataProviders.Contains(provider))
			{
				foreach (FreeQuant.Data.Trade trade in (DataArray) FreeQuant.Instruments.DataManager.GetHistoricalTrades(FreeQuant.Providers.ProviderManager.HistoricalDataProviders[provider], instrument.instrument, begin, end))
					tradeSeries.series.Add((IDataObject)trade);
			}
			return tradeSeries;
		}

		public static QuoteSeries GetHistoricalQuotes(string provider, Instrument instrument, DateTime begin, DateTime end)
		{
			QuoteSeries quoteSeries = new QuoteSeries();
			if (FreeQuant.Providers.ProviderManager.HistoricalDataProviders.Contains(provider))
			{
				foreach (FreeQuant.Data.Quote quote in (DataArray) FreeQuant.Instruments.DataManager.GetHistoricalQuotes(FreeQuant.Providers.ProviderManager.HistoricalDataProviders[provider], instrument.instrument, begin, end))
					quoteSeries.series.Add((IDataObject)quote);
			}
			return quoteSeries;
		}

		public static QuoteSeries GetHistoricalQuotes(Instrument instrument, DateTime begin, DateTime end)
		{
			return new QuoteSeries(FreeQuant.Instruments.DataManager.GetQuoteArray(Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, begin, end));
		}

		public static TradeSeries GetHistoricalTrades(Instrument instrument, DateTime begin, DateTime end)
		{
			return new TradeSeries(FreeQuant.Instruments.DataManager.GetTradeArray(Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, begin, end));
		}

		private static bool SeriesNameToBarTypeSize(string name, out BarType barType, out long barSize)
		{
			barType = BarType.Range;
			barSize = -1L;
			string[] strArray = name.Split(new char[1]
			{
				'.'
			});
			if (strArray.Length >= 4 && strArray[strArray.Length - 3] == "Bar" && Enum.IsDefined(typeof(BarType), (object)strArray[strArray.Length - 2]))
			{
				barType = (BarType)Enum.Parse(typeof(BarType), strArray[strArray.Length - 2]);
				if (long.TryParse(strArray[strArray.Length - 1], out barSize))
					return true;
			}
			return false;
		}

		public static BarSeriesInfo[] GetBarSeriesInfoList(Instrument instrument)
		{
			List<BarSeriesInfo> list = new List<BarSeriesInfo>();
			foreach (IDataSeries dataSeries in FreeQuant.Instruments.DataManager.GetDataSeries(instrument.instrument))
			{
				BarType barType;
				long barSize;
				if (DataManager.SeriesNameToBarTypeSize(dataSeries.Name, out barType, out barSize))
					list.Add(new BarSeriesInfo(barType, barSize));
			}
			return list.ToArray();
		}

		public static void Add(Instrument instrument, Bar bar)
		{
			FreeQuant.Instruments.Instrument instrument1 = Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument;
			if (bar.bar.BarType == FreeQuant.Data.BarType.Time && bar.bar.Size == 86400L)
			{
				Daily daily = new Daily(bar.bar.DateTime, bar.bar.Open, bar.bar.High, bar.bar.Low, bar.bar.Close, bar.bar.Volume, bar.bar.OpenInt);
				FreeQuant.Instruments.DataManager.Add(instrument1, daily);
			}
			else
				FreeQuant.Instruments.DataManager.Add(instrument1, bar.bar);
		}

		public static void Add(Instrument instrument, DateTime datetime, double open, double high, double low, double close, long volume, long size)
		{
			DataManager.Add(instrument, new Bar(new FreeQuant.Data.Bar(datetime, open, high, low, close, volume, size)));
		}

		public static void Add(Instrument instrument, Trade trade)
		{
			FreeQuant.Instruments.DataManager.Add(Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, trade.trade);
		}

		public static void Add(Instrument instrument, DateTime datetime, double price, int size)
		{
			DataManager.Add(instrument, new Trade(new FreeQuant.Data.Trade(datetime, price, size)));
		}

		public static void Add(Instrument instrument, Quote quote)
		{
			FreeQuant.Instruments.DataManager.Add(Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, quote.quote);
		}

		public static void Add(Instrument instrument, DateTime datetime, double bid, int bidsize, double ask, int asksize)
		{
			DataManager.Add(instrument, new Quote(new FreeQuant.Data.Quote(datetime, bid, bidsize, ask, asksize)));
		}

		public static void Add(Instrument instrument, OrderBookUpdate update)
		{
			FreeQuant.Instruments.DataManager.Add(Map.OQ_FQ_Instrument[(object)instrument] as FreeQuant.Instruments.Instrument, update.marketDepth);
		}

		public static void Add(Instrument instrument, DateTime datetime, BidAsk side, OrderBookAction action, int position, double price, int size)
		{
			DataManager.Add(instrument, new OrderBookUpdate(new MarketDepth(datetime, string.Empty, position, EnumConverter.Convert(action), EnumConverter.Convert(side), price, size)));
		}

		public static void DeleteTradeSeries(Instrument instrument)
		{
			DataManager.DeleteDataSeries(instrument, new string[1]
			{
				"Trade"
			});
		}

		public static void DeleteQuoteSeries(Instrument instrument)
		{
			DataManager.DeleteDataSeries(instrument, new string[1]
			{
				"Quote"
			});
		}

		public static void DeleteBarSeries(Instrument instrument, BarType barType, long barSize)
		{
			DataManager.DeleteDataSeries(instrument, "Bar", ((object)barType).ToString(), barSize.ToString());
		}

		public static void DeleteDailySeries(Instrument instrument)
		{
			DataManager.DeleteDataSeries(instrument, new string[1]
			{
				"Daily"
			});
		}

		private static void DeleteDataSeries(Instrument instrument, params string[] items)
		{
			FreeQuant.Instruments.DataManager.DeleteDataSeries(string.Format("{0}{1}{2}", (object)instrument.Symbol, (object)'.', (object)string.Join('.'.ToString(), items)));
		}

		public static void DeleteTrade(Instrument instrument, DateTime datetime)
		{
			DataManager.DeleteDataObject(instrument, datetime, new string[1]
			{
				"Trade"
			});
		}

		public static void DeleteQuote(Instrument instrument, DateTime datetime)
		{
			DataManager.DeleteDataObject(instrument, datetime, new string[1]
			{
				"Quote"
			});
		}

		public static void DeleteBar(Instrument instrument, DateTime datetime, BarType barType, long barSize)
		{
			DataManager.DeleteDataObject(instrument, datetime, "Bar", ((object)barType).ToString(), barSize.ToString());
		}

		public static void DeleteDaily(Instrument instrument, DateTime date)
		{
			DataManager.DeleteDataObject(instrument, date.Date, new string[1]
			{
				"Daily"
			});
		}

		private static void DeleteDataObject(Instrument instrument, DateTime datetime, params string[] items)
		{
			IDataSeries dataSeries = FreeQuant.Instruments.DataManager.Server.GetDataSeries(string.Format("{0}{1}{2}", (object)instrument.Symbol, (object)'.', (object)string.Join('.'.ToString(), items)));
			if (dataSeries == null)
				return;
			dataSeries.Remove(datetime);
		}

		public static BrokerInfo GetBrokerInfo(string provider, byte route)
		{
			IExecutionProvider executionProvider = FreeQuant.Providers.ProviderManager.ExecutionProviders[provider];
			if (executionProvider == null)
				throw new ArgumentException(string.Format("Provider {0} does not exist.", (object)provider));
			if (!executionProvider.IsConnected)
				throw new ApplicationException(string.Format("Provider {0} is not connected.", (object)provider));
			if ((int)route != 0 && executionProvider is IMultiRouteExecutionProvider)
				return new BrokerInfo((executionProvider as IMultiRouteExecutionProvider).GetBrokerInfo(route));
			else
				return new BrokerInfo(executionProvider.GetBrokerInfo());
		}

		public static BrokerInfo GetBrokerInfo(string provider)
		{
			return DataManager.GetBrokerInfo(provider, (byte)0);
		}

		public static BrokerInfo GetBrokerInfo()
		{
			return DataManager.GetBrokerInfo(Configuration.Active.ExecutionProvider.Name);
		}

		public static BarSeries CompressBars(TradeSeries trades, BarType barType, long barSize)
		{
			return DataManager.CompressBars((DataEntryEnumerator)new TradeDataEnumerator(trades), barType, 1L, barSize);
		}

		public static BarSeries CompressBars(QuoteSeries quotes, QuoteData input, BarType barType, long barSize)
		{
			if (barType == BarType.Range && input == QuoteData.BidAsk)
				throw new ArgumentException(string.Format("Cannot make range bars from {0}", (object)input));
			else
				return DataManager.CompressBars((DataEntryEnumerator)new QuoteDataEnumerator(quotes, input), barType, 1L, barSize);
		}

		public static BarSeries CompressBars(BarSeries bars, long barSize)
		{
			if (bars.Count == 0)
				return new BarSeries();
			Bar bar = bars[0];
			if (bar.Type == BarType.Range)
				throw new ArgumentException("Cannot compress bars with type Range");
			else
				return DataManager.CompressBars((DataEntryEnumerator)new BarDataEnumerator(bars), bar.Type, bar.Size, barSize);
		}

		private static BarSeries CompressBars(DataEntryEnumerator enumerator, BarType barType, long oldBarSize, long newBarSize)
		{
			return BarCompressor.GetCompressor(barType, oldBarSize, newBarSize).Compress(enumerator);
		}

		public static void Flush()
		{
			FreeQuant.Instruments.DataManager.Server.Flush();
		}
	}
}
