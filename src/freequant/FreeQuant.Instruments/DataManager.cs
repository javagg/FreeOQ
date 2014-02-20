using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Providers;
using FreeQuant.Series;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
    public class DataManager
    {
        public const string SUFFIX_TRADE = "Trade";
        public const string SUFFIX_QUOTE = "Quote";
        public const string SUFFIX_BAR = "Bar";
        public const string SUFFIX_DAILY = "Daily";
        public const string SUFFIX_MARKET_DEPTH = "Depth";
        public const string SUFFIX_FUNDAMENTAL = "Fund";
        public const string SUFFIX_CORPORATE_ACTION = "Corp";
        public const char MARKET_DATA_SUBSCRIBE = '1';
        public const char MARKET_DATA_UNSUBSCRIBE = '2';
        public const char SERIES_SEPARATOR = '.';
        //        private const int ORWW6WXlu1 = -1;
        //        private const int lUUWEJvSqM = -1;
        //        private const int YPJWs3OegF = -1;
        //        private const int gfqWdRTr4c = -1;
        //        private const int QO0WPjKdKF = -1;
        private const string CONFIG_FILE = "DataManager.config.xml";
        private static bool initialized;
        private static IDataServer server;
        private static BarType defaultBarType;
        private static long defaultBarSize;
        private static BarSeriesList barSeriesList;
        private static QuoteArrayList quoteArrayList;
        private static TradeArrayList tradeArrayList;
        private static FundamentalArrayList fundamentalArrayList;
        private static CorporateActionArrayList corporateActionArrayList;
        private static int barArrayLength;
        // QboW3t3R6j
        private static int quoteArrayLength;
        // UhSWNDBsKq
        private static int tradeArrayLength;
        // du8WObUg6P
        private static int fundamentalArrayLength;
        // pMXWKXcgvW
        private static int corporateActionArrayLength;
        // V9WW9pFkc0
        private static Hashtable providers;
        private static int reqId;

        private const char MDENTRY_TYPE_BID = '0';
        private const char MDENTRY_TYPE_ASK = '1';
        private const char MDENTRY_TYPE_TRADE = '2';


        public static int BarArrayLength
        {
            get
            {
                return DataManager.barArrayLength;
            }
            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Length Not Valid: {0}", value.ToString());
                DataManager.barArrayLength = value;
                DataManager.Save();
            }
        }

        public static int QuoteArrayLength
        {
            get
            {
                return DataManager.quoteArrayLength;
            }
            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Length Not Valid: {0}", value.ToString());
                DataManager.quoteArrayLength = value;
                DataManager.Save();
            }
        }

        public static int TradeArrayLength
        {
            get
            {
                return DataManager.tradeArrayLength;
            }
            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Length Not Valid: {0}", value.ToString());
                DataManager.tradeArrayLength = value;
                DataManager.Save();
            }
        }

        public static int FundamentalArrayLength
        {
            get
            {
                return DataManager.fundamentalArrayLength;
            }
            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Length Not Valid: {0}", value.ToString());
                DataManager.fundamentalArrayLength = value;
                DataManager.Save();
            }
        }

        public static int CorporateActionArrayLength
        {
            get
            {
                return DataManager.corporateActionArrayLength;  
            }
            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Length Not Valid: {0}", value.ToString());
                DataManager.corporateActionArrayLength = value;
                DataManager.Save();
            }
        }

        public static BarType DefaultBarType
        {
            get
            {
                return DataManager.defaultBarType;
            }
            set
            {
                DataManager.defaultBarType = value;
                DataManager.Save();
            }
        }

        public static long DefaultBarSize
        {
            get
            {
                return DataManager.defaultBarSize;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("BarSize {0} Not Valid", value.ToString());
                DataManager.defaultBarSize = value;
                DataManager.Save();
            }
        }

        public static BarSeriesList Bars
        {
            get
            {
                return DataManager.barSeriesList;
            }
        }

        public static TradeArrayList Trades
        {
            get
            {
                return DataManager.tradeArrayList;
            }
        }

        public static QuoteArrayList Quotes
        {
            get
            {
                return DataManager.quoteArrayList;
            }
        }

        public static FundamentalArrayList Fundamentals
        {
            get
            {
                return DataManager.fundamentalArrayList;
            }
        }

        public static CorporateActionArrayList CorporateActions
        {
            get
            {
                return DataManager.corporateActionArrayList;
            }
        }

        public static IDataServer Server
        {
            get
            {
                return DataManager.server;
            }
            set
            {
                DataManager.server = value;
            }
        }

        static DataManager()
        {
            DataManager.initialized = false;
            DataManager.server = new FileDataServer();
            DataManager.barSeriesList = new BarSeriesList();
            DataManager.quoteArrayList = new QuoteArrayList();
            DataManager.tradeArrayList = new TradeArrayList();
            DataManager.fundamentalArrayList = new FundamentalArrayList();
            DataManager.corporateActionArrayList = new CorporateActionArrayList();
            DataManager.providers = new Hashtable();
            DataManager.reqId = 0;
            DataManager.Init();
        }

        public static void ClearDataArrays()
        {
            DataManager.barSeriesList.Clear();
            DataManager.tradeArrayList.Clear(true);
            DataManager.quoteArrayList.Clear(true);
            DataManager.fundamentalArrayList.Clear(true);
            DataManager.corporateActionArrayList.Clear(true);
        }

        public static void Init()
        {
            if (DataManager.initialized)
                return;

            ProviderManager.NewQuote += new QuoteEventHandler(DataManager.OnNewQuote);
            ProviderManager.NewTrade += new TradeEventHandler(DataManager.OnNewTrade);
            ProviderManager.NewBar += new BarEventHandler(DataManager.OnNewBar);
            ProviderManager.NewBarOpen += new BarEventHandler(DataManager.OnNewBarOpen);
            ProviderManager.NewMarketDepth += new MarketDepthEventHandler(DataManager.OnNewMarketDepth);
            ProviderManager.NewFundamental += new FundamentalEventHandler(DataManager.OnNewFundamental);
            ProviderManager.NewCorporateAction += new CorporateActionEventHandler(DataManager.OnNewCorporateAction);
            ProviderManager.MarketDataRequestReject += new MarketDataRequestRejectEventHandler(DataManager.OnMarketDataRequestReject);
            ProviderManager.Connected += new ProviderEventHandler(DataManager.a9pwYGI8t);
            DataManager.barArrayLength = -1;
            DataManager.tradeArrayLength = -1;
            DataManager.quoteArrayLength = -1;
            DataManager.fundamentalArrayLength = -1;
            DataManager.corporateActionArrayLength = -1;
            DataManager.defaultBarType = BarType.Time;   // DataManager.TrxWldYDwK = BarType.Time;
            DataManager.defaultBarSize = 60;            // DataManager.AK2WYmbanY
            DataManager.Load();
            DataManager.initialized = true;
        }

        public static void Add(string series, Trade trade)
        {
            DataManager.server.Add(series, trade);
        }

        public static void Add(string series, Quote quote)
        {
            DataManager.server.Add(series, quote);
        }

        public static void Add(string series, Bar bar)
        {
            DataManager.server.Update(series, bar);
        }

        public static void Add(string series, MarketDepth marketDepth)
        {
            DataManager.server.Add(series, marketDepth);
        }

        public static void Add(string series, Fundamental fundamental)
        {
            DataManager.server.Add(series, fundamental);
        }

        public static void Add(string series, CorporateAction corporateAction)
        {
            DataManager.server.Add(series, corporateAction);
        }

        public static void Add(Instrument instrument, string suffix, Trade trade)
        {
            DataManager.Add(instrument.Symbol + SERIES_SEPARATOR + suffix, trade);
        }

        public static void Add(Instrument instrument, string suffix, Quote quote)
        {
            DataManager.Add(instrument.Symbol + SERIES_SEPARATOR + suffix, quote);
        }

        public static void Add(Instrument instrument, string suffix, Bar bar)
        {
            DataManager.Add(instrument.Symbol + SERIES_SEPARATOR + suffix, bar);
        }

        public static void Add(Instrument instrument, string suffix, MarketDepth marketDepth)
        {
            DataManager.Add(instrument.Symbol + SERIES_SEPARATOR + suffix, marketDepth);
        }

        public static void Add(Instrument instrument, string suffix, Fundamental fundamental)
        {
            DataManager.Add(instrument.Symbol + SERIES_SEPARATOR + suffix, fundamental);
        }

        public static void Add(Instrument instrument, string suffix, CorporateAction corporateAction)
        {
            DataManager.Add(instrument.Symbol + SERIES_SEPARATOR + suffix, corporateAction);
        }

        public static void Add(Instrument instrument, Trade trade)
        {
            DataManager.Add(instrument, SUFFIX_TRADE, trade);
        }

        public static void Add(Instrument instrument, Quote quote)
        {
            DataManager.Add(instrument, SUFFIX_QUOTE, quote);
        }

        public static void Add(Instrument instrument, Bar bar)
        {
            string suffix = SUFFIX_BAR + SERIES_SEPARATOR + bar.BarType.ToString() + SERIES_SEPARATOR + bar.Size.ToString();
            DataManager.Add(instrument, suffix, bar);
        }

        public static void Add(Instrument instrument, Daily daily)
        {
            DataManager.Add(instrument, SUFFIX_DAILY, daily);
        }

        public static void Add(Instrument instrument, MarketDepth marketDepth)
        {
            DataManager.Add(instrument, SUFFIX_MARKET_DEPTH, marketDepth);
        }

        public static void Add(Instrument instrument, Fundamental fundamental)
        {
            DataManager.Add(instrument, SUFFIX_FUNDAMENTAL, fundamental);
        }

        public static void Add(Instrument instrument, CorporateAction corporateAction)
        {
            DataManager.Add(instrument, SUFFIX_CORPORATE_ACTION, corporateAction);
        }

        public static TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.server.GetTradeArray(series, datetime1, datetime2);
        }

        public static TradeArray GetTradeArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetTradeArray(instrument.Symbol + '.' + suffix, datetime1, datetime2);
        }

        public static TradeArray GetTradeArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetTradeArray(instrument, SUFFIX_TRADE, datetime1, datetime2);
        }

        public static QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.server.GetQuoteArray(series, datetime1, datetime2);
        }

        public static QuoteArray GetQuoteArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetQuoteArray(instrument.Symbol + '.' + suffix, datetime1, datetime2);
        }

        public static QuoteArray GetQuoteArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetQuoteArray(instrument, SUFFIX_QUOTE, datetime1, datetime2);
        }

        public static MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.server.GetMarketDepthArray(series, datetime1, datetime2);
        }

        public static MarketDepthArray GetMarketDepthArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetMarketDepthArray(instrument.Symbol + '.' + suffix, datetime1, datetime2);
        }

        public static MarketDepthArray GetMarketDepthArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetMarketDepthArray(instrument, SUFFIX_MARKET_DEPTH, datetime1, datetime2);
        }

        public static BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.server.GetBarSeries(series, datetime1, datetime2);
        }

        public static BarSeries GetBarSeries(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetBarSeries(instrument.Symbol + SERIES_SEPARATOR + suffix, datetime1, datetime2);
        }

        public static BarSeries GetBarSeries(Instrument instrument, DateTime datetime1, DateTime datetime2, BarType barType, long barSize)
        {
            string suffix = string.Format("{0}{1}{2}{3}{4}", SUFFIX_BAR, SERIES_SEPARATOR, barType, SERIES_SEPARATOR, barSize);
            return DataManager.GetBarSeries(instrument, suffix, datetime1, datetime2);
        }

        public static BarSeries GetBarSeries(Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetBarSeries(instrument, datetime1, datetime2, DataManager.defaultBarType, DataManager.defaultBarSize);
        }

        public static DailySeries GetDailySeries(Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            string series = instrument.Symbol + SERIES_SEPARATOR + SUFFIX_DAILY;
            DailySeries dailySeries = DataManager.server.GetDailySeries(series, datetime1, datetime2);
            dailySeries.Name = instrument.Symbol;
            return dailySeries;
        }

        public static DailySeries GetDailySeries(Instrument instrument)
        {
            return DataManager.GetDailySeries(instrument, DateTime.MinValue, DateTime.MaxValue);
        }

        public static IDataSeries GetDataSeries(Instrument instrument, string suffix)
        {
            return DataManager.server.GetDataSeries(instrument.Symbol + SERIES_SEPARATOR + suffix);
        }

        public static IDataSeries AddDataSeries(Instrument instrument, string suffix)
        {
            return DataManager.server.AddDataSeries(instrument.Symbol + SERIES_SEPARATOR + suffix);
        }

        public static void DeleteDataSeries(string series)
        {
            DataManager.server.Delete(series);
        }

        public static void ClearDataSeries(string series)
        {
            DataManager.server.Clear(series);
        }

        public static IDataSeries GetDataSeries(Instrument instrument, DataManager.EDataSeries series)
        {
            string suffix;
            switch (series)
            {
                case DataManager.EDataSeries.Daily:
                    suffix = SUFFIX_DAILY;
                    break;
                case DataManager.EDataSeries.Trade:
                    suffix = SUFFIX_TRADE;
                    break;
                case DataManager.EDataSeries.Quote:
                    suffix = SUFFIX_QUOTE;
                    break;
                case DataManager.EDataSeries.Bar:
                    suffix = SUFFIX_BAR;
                    break;
                case DataManager.EDataSeries.MarketDepth:
                    suffix = SUFFIX_MARKET_DEPTH;
                    break;
                case DataManager.EDataSeries.Fundamental:
                    suffix = SUFFIX_FUNDAMENTAL;
                    break;
                case DataManager.EDataSeries.CorporateAction:
                    suffix = SUFFIX_CORPORATE_ACTION;
                    break;
                default:
                    throw new ArgumentException("Eerro: {0}" + series.ToString());
            }
            return DataManager.server.GetDataSeries(instrument.Symbol + SERIES_SEPARATOR + suffix);
        }

        public static DataSeriesList GetDataSeries(Instrument instrument)
        {
            DataSeriesList dsList = new DataSeriesList();
            foreach (IDataSeries series in DataManager.server.GetDataSeries())
            {
                if (series.Name.StartsWith(instrument.Symbol + SERIES_SEPARATOR))
                    dsList.Add(series);
            }
            return dsList;
        }

        public static void Close()
        {
            DataManager.server.Close();
        }

        public static void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
        {
            DataManager.DoRequest(provider, instrument, mdType, MARKET_DATA_SUBSCRIBE, suffix);
        }

        public static void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
        {
            DataManager.RequestMarketData(provider, instrument, mdType, SERIES_SEPARATOR + "SUBSCRIBE");
        }

        public static void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
        {
            DataManager.DoRequest(provider, instrument, mdType, MARKET_DATA_UNSUBSCRIBE, suffix);
        }

        public static void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
        {
            DataManager.CancelMarketData(provider, instrument, mdType, SERIES_SEPARATOR + "UNSUBSCRIBE");
        }

        public static bool IsSubscribed(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
        {
            lock (DataManager.providers)
            {
                Hashtable local_0 = DataManager.providers[provider] as Hashtable;
                if (local_0 == null)
                    return false;
                Hashtable local_1 = local_0[instrument] as Hashtable;
                if (local_1 == null)
                    return false;
                else
                    return local_1.ContainsKey(mdType);
            }
        }

        public static MarketDataSubscription[] GetSubscriptions()
        {
            List<MarketDataSubscription> subscriptions = new List<MarketDataSubscription>();
            lock (DataManager.providers)
            {
                foreach (DictionaryEntry entry in DataManager.providers)
                {
                    foreach (DictionaryEntry item_1 in (IDictionary)entry.Value)
                    {
                        foreach (DictionaryEntry item_0 in (IDictionary) item_1.Value)
                        {
                            MarketDataSubscription local_4 = new MarketDataSubscription((IMarketDataProvider)entry.Key, (Instrument)item_1.Key, (MarketDataType)item_0.Key, (int)item_0.Value);
                            subscriptions.Add(local_4);
                        }
                    }
                }
            }
            return subscriptions.ToArray();
        }

        private static void DoRequest(IMarketDataProvider provider, Instrument instrument, MarketDataType type, char subCh, string suffix)
        {
            if ((type & MarketDataType.Trade) == MarketDataType.Trade)
                DataManager.DoFixRequest(provider, instrument, MarketDataType.Trade, subCh, suffix);
            if ((type & MarketDataType.Quote) == MarketDataType.Quote)
                DataManager.DoFixRequest(provider, instrument, MarketDataType.Quote, subCh, suffix);
            if ((type & MarketDataType.MarketDepth) != MarketDataType.MarketDepth)
                return;
            DataManager.DoFixRequest(provider, instrument, MarketDataType.MarketDepth, subCh, suffix);
        }

        private static void DoFixRequest(IMarketDataProvider provider, Instrument instrument, MarketDataType type, char subCh, string suffix)
        {
            FIXMarketDataRequest request = new FIXMarketDataRequest();
            request.MDReqID = DataManager.GetRequestId();
            request.SubscriptionRequestType = subCh;
            switch (type)
            {
                case MarketDataType.Trade:
                    request.AddGroup(new FIXMDEntryTypesGroup('2'));
                    break;
                case MarketDataType.Quote:
                    request.AddGroup(new FIXMDEntryTypesGroup('0'));
                    request.AddGroup(new FIXMDEntryTypesGroup('1'));
                    request.MarketDepth = 1;  // Top of Book
                    break;
                case MarketDataType.MarketDepth:
                    request.AddGroup(new FIXMDEntryTypesGroup('0'));
                    request.AddGroup(new FIXMDEntryTypesGroup('1'));
                    request.MarketDepth = 0;  // Full Book
                    break;
            }
            if (!instrument.ContainsField(15))
                instrument.Currency = Framework.Configuration.DefaultCurrency;
            FIXRelatedSymGroup symGrp = new FIXRelatedSymGroup();
            request.AddGroup(symGrp);
            symGrp.Symbol = instrument.Symbol;
            symGrp.SecurityType = instrument.SecurityType;
            symGrp.SecurityExchange = instrument.SecurityExchange;
            symGrp.Currency = instrument.Currency;
            symGrp.SecurityID = instrument.SecurityID;
            symGrp.SecurityIDSource = instrument.SecurityIDSource;
            symGrp.MaturityDate = instrument.MaturityDate;
            symGrp.MaturityMonthYear = instrument.MaturityMonthYear;
            symGrp.StrikePrice = instrument.StrikePrice;
            symGrp.PutOrCall = ((FIXInstrument)instrument).PutOrCall;
            foreach (FIXSecurityAltIDGroup group2 in instrument.SecurityAltIDGroup)
                symGrp.AddGroup(group2);
            symGrp.SetStringValue(10001, suffix);
            if (provider == ProviderManager.MarketDataSimulator)
            {
                provider.SendMarketDataRequest(request);
            }
            else
            {
                switch (subCh)
                {
                    case MARKET_DATA_SUBSCRIBE:
                        bool flag1 = false;
                        lock (DataManager.providers)
                        {
                            Hashtable local_4 = DataManager.providers[provider] as Hashtable;
                            if (local_4 == null)
                            {
                                local_4 = new Hashtable();
                                DataManager.providers.Add(provider, local_4);
                            }
                            Hashtable local_5 = local_4[instrument] as Hashtable;
                            if (local_5 == null)
                            {
                                local_5 = new Hashtable();
                                local_4.Add(instrument, local_5);
                            }
                            RequestItem local_6 = local_5[type] as RequestItem;
                            if (local_6 == null)
                            {
                                local_6 = new RequestItem(request);
                                local_5.Add(type, local_6);
                                flag1 = true;
                            }
                            RequestItem temp_91 = local_6;
                            int temp_94 = temp_91.GetRequestId() + 1;
                            temp_91.SetRequestId(temp_94);
                        }
                        if (!flag1)
                            break;
                        provider.SendMarketDataRequest(request);
                        break;
                    case MARKET_DATA_UNSUBSCRIBE:
                        bool canSend = false;
                        string msg = null;
                        lock (DataManager.providers)
                        {
                            Hashtable local_10 = DataManager.providers[provider] as Hashtable;
                            if (local_10 != null)
                            {
                                Hashtable local_11 = local_10[instrument] as Hashtable;
                                if (local_11 != null)
                                {
                                    RequestItem local_12 = local_11[type] as RequestItem;
                                    if (local_12 != null)
                                    {
                                        RequestItem temp_152 = local_12;
                                        int temp_155 = temp_152.GetRequestId() - 1;
                                        temp_152.SetRequestId(temp_155);
                                        if (local_12.GetRequestId() == 0)
                                        {
                                            local_11.Remove(type);
                                            if (local_11.Count == 0)
                                            {
                                                local_10.Remove(instrument);
                                                if (local_10.Count == 0)
                                                    DataManager.providers.Remove(provider);
                                            }
                                            canSend = true;
                                        }
                                    }
                                    else
                                        msg = "No this RequestItem";
                                }
                                else
                                    msg = "No Request for this instrument";
                            }
                            else
                                msg = "No Request for this provider";
                        }
                        if (msg != null)
                            DataManager.LogRequestMessage(provider, instrument, type, msg);
                        if (!canSend)
                            break;
                        provider.SendMarketDataRequest(request);
                        break;
                }
            }
        }

        private static void LogRequestMessage(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string obj3)
        {
            if (Trace.IsLevelEnabled(TraceLevel.Warning))
            {
                Trace.WriteLine("" + Environment.NewLine + "" + provider.Name + Environment.NewLine + "Symbol" + instrument.Symbol + Environment.NewLine + "Type:" + mdType.ToString() + Environment.NewLine + "" + obj3);
            }
        }

        private static string GetRequestId()
        {
            return string.Format("{D}", DateTime.Now, DataManager.reqId++);
        }

        private static void OnNewQuote(object sender, QuoteEventArgs e)
        {
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument == null)
                return;

            Quote quote = e.Quote;
            if (DataManager.quoteArrayLength != 0)
            {
                QuoteArray quoteArray = DataManager.quoteArrayList[instrument];
                quoteArray.Add(quote);
                if (DataManager.quoteArrayLength != -1 && quoteArray.Count > DataManager.quoteArrayLength)
                {
                    quoteArray.RemoveAt(0);
                }
            }
            instrument.EmitNewQuote(new QuoteEventArgs(quote, instrument, e.Provider));
        }

        private static void OnNewTrade(object sender, TradeEventArgs e)
        {
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument == null)
                return;

            Trade trade = e.Trade;
            if (DataManager.tradeArrayLength != 0)
            {
                TradeArray tradeArray = DataManager.tradeArrayList[instrument];
                tradeArray.Add(trade);
                if (DataManager.tradeArrayLength != -1 && tradeArray.Count > DataManager.tradeArrayLength)
                {
                    tradeArray.RemoveAt(0);
                }
            }
            instrument.EmitNewTrade(new TradeEventArgs(trade, instrument, e.Provider));
        }

        private static void OnNewBar(object sender, BarEventArgs e)
        {
            if (Trace.IsLevelEnabled(TraceLevel.Verbose))
                Trace.WriteLine("Bar {0}" + e);
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument == null)
                return;
            DataManager.barSeriesList.Add(instrument, e.Bar);
            BarSeries barSeries = DataManager.barSeriesList[instrument, e.Bar.BarType, e.Bar.Size];
            // TODO:HEHEHHE
            if (DataManager.barArrayLength != -1 && barSeries.Count > DataManager.barArrayLength)
                ((TimeSeries)barSeries).Remove(0);
            instrument.EmitNewBar(e);
        }

        private static void OnNewBarOpen(object sender, BarEventArgs e)
        {
            if (Trace.IsLevelEnabled(TraceLevel.Verbose))
                Trace.WriteLine("(Open)Bar {0}" + e);
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument != null)
                  instrument.EmitNewBarOpen(e);
        }

        private static void OnNewMarketDepth(object sender, MarketDepthEventArgs e)
        {
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument != null)
                instrument.EmitNewMarketDepth(e);
        }

        private static void OnNewFundamental(object sender, FundamentalEventArgs e)
        {
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument == null)
                return;
            FundamentalArray array = DataManager.fundamentalArrayList[instrument];
            array.Add(e.Fundamental);
            if (DataManager.fundamentalArrayLength != -1 && array.Count > DataManager.fundamentalArrayLength)
                array.RemoveAt(0);
            instrument.EmitNewFundamental(e);
        }

        private static void OnNewCorporateAction(object sender, CorporateActionEventArgs e)
        {
            Instrument instrument = e.Instrument as Instrument ?? InstrumentManager.Instruments[e.Instrument.Symbol, e.Provider.Name];
            if (instrument == null)
                return;
            CorporateActionArray array = DataManager.corporateActionArrayList[instrument];
            array.Add(e.CorporateAction);
            if (DataManager.corporateActionArrayLength != -1 && array.Count > DataManager.corporateActionArrayLength)
                array.RemoveAt(0);
            instrument.EmitNewCorporateAction(e);
        }

        private static void OnMarketDataRequestReject(object obj0, MarketDataRequestRejectEventArgs obj1)
        {
        }

        private static void a9pwYGI8t(ProviderEventArgs e)
        {
            IMarketDataProvider provider = e.Provider as IMarketDataProvider;
            if (provider == null || provider == ProviderManager.MarketDataSimulator)
                return;
            Hashtable hashtable1 = DataManager.providers[provider] as Hashtable;
            if (hashtable1 == null)
                return;
            foreach (Hashtable hashtable2 in (IEnumerable)hashtable1.Values)
            {
                foreach (RequestItem reqItem in (IEnumerable)hashtable2.Values)
                    provider.SendMarketDataRequest(reqItem.GetFIXMarketDataRequest());
            }
        }

        public static BarSeries GetHistoricalBars(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2, long barSize)
        {
            ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Bar, datetime1, datetime2, barSize);
            BarSeries barSeries = new BarSeries();
            foreach (Bar bar in arrayList)
                barSeries.Add(bar);
            return barSeries;
        }

        public static BarSeries GetHistoricalBars(string providerName, string symbol, DateTime datetime1, DateTime datetime2, long barSize)
        {
            return DataManager.GetHistoricalBars(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2, barSize);
        }

        public static DailySeries GetHistoricalDailies(IHistoricalDataProvider provider, Instrument instrument, DateTime date1, DateTime date2)
        {
            ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Daily, date1, date2, -1L);
            DailySeries dailySeries = new DailySeries();
            foreach (Daily daily in arrayList)
                dailySeries.Add(daily);
            return dailySeries;
        }

        public static DailySeries GetHistoricalDailies(string providerName, string symbol, DateTime date1, DateTime date2)
        {
            return DataManager.GetHistoricalDailies(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], date1, date2);
        }

        public static TradeArray GetHistoricalTrades(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Trade, datetime1, datetime2, -1L);
            TradeArray tradeArray = new TradeArray();
            foreach (Trade trade in arrayList)
                tradeArray.Add(trade);
            return tradeArray;
        }

        public static TradeArray GetHistoricalTrades(string providerName, string symbol, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetHistoricalTrades(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2);
        }

        public static QuoteArray GetHistoricalQuotes(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2)
        {
            ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Quote, datetime1, datetime2, -1L);
            QuoteArray quoteArray = new QuoteArray();
            foreach (Quote quote in arrayList)
                quoteArray.Add(quote);
            return quoteArray;
        }

        public static QuoteArray GetHistoricalQuotes(string providerName, string symbol, DateTime datetime1, DateTime datetime2)
        {
            return DataManager.GetHistoricalQuotes(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2);
        }

        private static ArrayList r6ZT8iFUv(IHistoricalDataProvider provider, Instrument instrument, DataManager.EDataSeries dataType, DateTime beginDate, DateTime endDate, long barSize)
        {
            if (provider == null)
                throw new ArgumentNullException("Provider is null");
            if (instrument == null)
                throw new ArgumentNullException("Instrument is null");

            if (!provider.IsConnected)
            {
                provider.Connect(10000);
                if (!provider.IsConnected)
                    throw new InvalidOperationException("Provider cannot make a connection");
            }

            HistoricalDataRequest request = new HistoricalDataRequest();
            request.Instrument = instrument;
            switch (dataType)
            {
                case DataManager.EDataSeries.Daily:
                    request.DataType = HistoricalDataType.Daily;
                    break;
                case DataManager.EDataSeries.Trade:
                    request.DataType = HistoricalDataType.Trade;
                    break;
                case DataManager.EDataSeries.Quote:
                    request.DataType = HistoricalDataType.Quote;
                    break;
                case DataManager.EDataSeries.Bar:
                    request.DataType = HistoricalDataType.Bar;
                    request.BarSize = barSize; 
                    break;
            }
            request.BeginDate = beginDate;
            request.EndDate = endDate;
            return new HistoricalDataGetter(provider, request).GetData();
        }

        private static void Load()
        {
            FileInfo fileInfo = new FileInfo(Framework.Installation.IniDir.FullName + CONFIG_FILE);
            if (fileInfo.Exists)
            {
                try
                {
//                    puiniRe7DJLOfflhEJ puiniRe7DjlOfflhEj = new puiniRe7DJLOfflhEJ();
//                    puiniRe7DjlOfflhEj.Load(fileInfo.FullName);
//                    DataManager.defaultBarType = puiniRe7DjlOfflhEj.CHCBRumpAl().WdlEXZ7oTe();
//                    DataManager.defaultBarSize = puiniRe7DjlOfflhEj.CHCBRumpAl().XaSErhLB01();
//                    SesaxMXvEcbARH2A9H sesaxMxvEcbArH2A9H = puiniRe7DjlOfflhEj.KtOBnsCKBh();
//                    DataManager.barArrayLength = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(BarArray)).l9DETTpFOp();
//                    DataManager.tradeArrayLength = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(TradeArray)).l9DETTpFOp();
//                    DataManager.quoteArrayLength = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(QuoteArray)).l9DETTpFOp();
//                    DataManager.fundamentalArrayLength = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(FundamentalArray)).l9DETTpFOp();
//                    DataManager.corporateActionArrayLength = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(CorporateActionArray)).l9DETTpFOp();
                }
                catch (Exception ex)
                {
                    if (!Trace.IsLevelEnabled(TraceLevel.Error))
                        return;
                    Trace.WriteLine(ex.ToString());
                }
            }
            else
                DataManager.Save();
        }

        private static void Save()
        {
//            puiniRe7DJLOfflhEJ puiniRe7DjlOfflhEj = new puiniRe7DJLOfflhEJ();
//            puiniRe7DjlOfflhEj.CHCBRumpAl().kjcE4tAU2C(DataManager.defaultBarType);
//            puiniRe7DjlOfflhEj.CHCBRumpAl().hcVE3AoTff(DataManager.defaultBarSize);
//            SesaxMXvEcbARH2A9H sesaxMxvEcbArH2A9H = puiniRe7DjlOfflhEj.KtOBnsCKBh();
//            sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(BarArray)).rTfEzlwNY7(DataManager.barArrayLength);
//            sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(TradeArray)).rTfEzlwNY7(DataManager.tradeArrayLength);
//            sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(QuoteArray)).rTfEzlwNY7(DataManager.quoteArrayLength);
//            sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(FundamentalArray)).rTfEzlwNY7(DataManager.fundamentalArrayLength);
//            sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof(CorporateActionArray)).rTfEzlwNY7(DataManager.corporateActionArrayLength);
            //            puiniRe7DjlOfflhEj.Save(Framework.Installation.IniDir.FullName + CONFIG_FILE);
        }

        public enum EDataSeries
        {
            Daily,
            Trade,
            Quote,
            Bar,
            MarketDepth,
            Fundamental,
            CorporateAction
        }
    }
}
