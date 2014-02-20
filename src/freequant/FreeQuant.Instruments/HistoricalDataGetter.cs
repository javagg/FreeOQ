using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Providers;
using FreeQuant.Series;

namespace FreeQuant.Instruments
{
    class HistoricalDataGetter
    {
        private ArrayList data;
        private IHistoricalDataProvider provider;
        private HistoricalDataRequest request;
        private ManualResetEventSlim mres;

        public HistoricalDataGetter(IHistoricalDataProvider provider, HistoricalDataRequest request)
        {
            this.provider = provider;
            this.request = request;
        }

        public ArrayList GetData()
        {
            this.data = new ArrayList();
            this.mres = new ManualResetEventSlim(false);
            this.Watch();
            this.provider.SendHistoricalDataRequest(this.request);
            this.mres.Wait();
            this.UnWatch();
            return this.data;
        }

        private void Watch()
        {
            this.provider.NewHistoricalQuote += new HistoricalQuoteEventHandler(this.OnNewHistoricalQuote);
            this.provider.NewHistoricalTrade += new HistoricalTradeEventHandler(this.OnNewHistoricalTrade);
            this.provider.NewHistoricalBar += new HistoricalBarEventHandler(this.OnNewHistoricalBar);
            this.provider.HistoricalDataRequestCompleted += new HistoricalDataEventHandler(this.OnHistoricalDataRequestCompleted);
            this.provider.HistoricalDataRequestCancelled += new HistoricalDataEventHandler(this.OnHistoricalDataRequestCancelled);
            this.provider.HistoricalDataRequestError += new HistoricalDataErrorEventHandler(this.OnHistoricalDataRequestError);
        }

        private void UnWatch()
        {
            this.provider.NewHistoricalQuote -= new HistoricalQuoteEventHandler(this.OnNewHistoricalQuote);
            this.provider.NewHistoricalTrade -= new HistoricalTradeEventHandler(this.OnNewHistoricalTrade);
            this.provider.NewHistoricalBar -= new HistoricalBarEventHandler(this.OnNewHistoricalBar);
            this.provider.HistoricalDataRequestCompleted -= new HistoricalDataEventHandler(this.OnHistoricalDataRequestCompleted);
            this.provider.HistoricalDataRequestCancelled -= new HistoricalDataEventHandler(this.OnHistoricalDataRequestCancelled);
            this.provider.HistoricalDataRequestError -= new HistoricalDataErrorEventHandler(this.OnHistoricalDataRequestError);
        }

        private void OnNewHistoricalQuote(object sender, HistoricalQuoteEventArgs e)
        {
            if (e.RequestId == this.request.RequestId)
                this.data.Add(e.Quote);
        }

        private void OnNewHistoricalTrade(object sender, HistoricalTradeEventArgs e)
        {
            if (e.RequestId == this.request.RequestId)
                this.data.Add(e.Trade);
        }

        private void OnNewHistoricalBar(object sender, HistoricalBarEventArgs e)
        {
            if (e.RequestId == this.request.RequestId)
                this.data.Add(e.Bar);
        }

        private void OnHistoricalDataRequestCompleted(object sender, HistoricalDataEventArgs e)
        {
            if (e.RequestId == this.request.RequestId)
                this.mres.Set();
        }

        private void OnHistoricalDataRequestCancelled(object sender, HistoricalDataEventArgs e)
        {
            if (e.RequestId == this.request.RequestId)
                this.mres.Set();
        }

        private void OnHistoricalDataRequestError(object sender, HistoricalDataErrorEventArgs e)
        {
            if (e.RequestId == this.request.RequestId)
                this.mres.Set();
        }
    }
}
