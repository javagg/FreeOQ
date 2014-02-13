using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Export.CSV
{
	class QuoteExporter : DataExporter
	{
		public override string[] GetHeader()
		{
			return new string[]
			{
				"DateTime",
				"Bid",
				"BidSize",
				"Ask",
				"AskSize"
			};
		}

		public override string[] DataObjectToString(IDataObject obj)
		{
			Quote quote = (Quote)obj;
			return new string[5]
			{
				this.DateTimeToString(obj.DateTime, false),
				this.DoubleToString(quote.Bid),
				quote.BidSize.ToString(),
				this.DoubleToString(quote.Ask),
				quote.AskSize.ToString()
			};
		}
	}
}
