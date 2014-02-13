using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class QuoteEngine : Engine
	{
		protected override IDataObject Process()
		{
			DateTime dateTime = this.GetDateTime();
			double doubleValue1 = this.GetDoubleValue(ColumnType.Bid);
			double doubleValue2 = this.GetDoubleValue(ColumnType.Ask);
			int int32Value1 = this.GetInt32Value(ColumnType.BidSize);
			int int32Value2 = this.GetInt32Value(ColumnType.AskSize);
			return (IDataObject)new Quote(dateTime, doubleValue1, int32Value1, doubleValue2, int32Value2);
		}
	}
}
