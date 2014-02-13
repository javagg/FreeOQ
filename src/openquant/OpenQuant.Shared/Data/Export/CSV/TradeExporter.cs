using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Export.CSV
{
	class TradeExporter : DataExporter
	{
		public override string[] GetHeader()
		{
			return new string[]
			{
				"DateTime",
				"Price",
				"Size"
			};
		}

		public override string[] DataObjectToString(IDataObject obj)
		{
			Trade trade = (Trade)obj;
			return new string[]
			{
				this.DateTimeToString(trade.DateTime, false),
				this.DoubleToString(trade.Price),
				trade.Size.ToString()
			};
		}
	}
}
