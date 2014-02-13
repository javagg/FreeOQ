using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Import.CSV
{
  class TradeEngine : Engine
  {
    protected override IDataObject Process()
    {
      return new Trade(this.GetDateTime(), this.GetDoubleValue(ColumnType.Price), this.GetInt32Value(ColumnType.Size));
    }
  }
}
