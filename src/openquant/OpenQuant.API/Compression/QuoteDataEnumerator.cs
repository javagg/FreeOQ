using OpenQuant.API;
using System;
using System.Collections.Generic;

namespace OpenQuant.API.Compression
{
	internal class QuoteDataEnumerator : DataEntryEnumerator
	{
		private QuoteSeries series;
		private QuoteData input;

		public override DataEntry Current
		{
			get
			{
				Quote quote = this.series[this.index];
				List<PriceSizeItem> list = new List<PriceSizeItem>();
				switch (this.input)
				{
					case QuoteData.Bid:
						list.Add(new PriceSizeItem(quote.Bid, quote.BidSize));
						break;
					case QuoteData.Ask:
						list.Add(new PriceSizeItem(quote.Ask, quote.AskSize));
						break;
					case QuoteData.BidAsk:
						list.Add(new PriceSizeItem(quote.Bid, quote.BidSize));
						list.Add(new PriceSizeItem(quote.Ask, quote.AskSize));
						break;
					case QuoteData.Middle:
						list.Add(new PriceSizeItem((quote.Bid+quote.Ask)/2.0, (quote.BidSize+quote.AskSize)/2));
						break;
					case QuoteData.Spread:
						list.Add(new PriceSizeItem(quote.Ask - quote.Bid, 0));
						break;
					default:
						throw new ArgumentException(string.Format("Unknown QuoteData - {0}", (object)this.input));
				}
				return new DataEntry(quote.DateTime, list.ToArray());
			}
		}

		public QuoteDataEnumerator(QuoteSeries series, QuoteData input) : base(series.Count)
		{
			this.series = series;
			this.input = input;
		}
	}
}
