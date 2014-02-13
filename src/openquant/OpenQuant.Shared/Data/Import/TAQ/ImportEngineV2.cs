// Type: OpenQuant.Shared.Data.Import.TAQ.ImportEngineV2
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal class ImportEngineV2 : ImportEngine
  {
    protected override IQuoteRecord ReadQuoteDataRecord(int num)
    {
      return (IQuoteRecord) new QuoteDataRecord2(this.dataReader, num);
    }

    protected override ITradeRecord ReadTradeDataRecord(int num)
    {
      return (ITradeRecord) new TradeDataRecord2(this.dataReader, num);
    }

    protected override DateTime GetDate(int talDate)
    {
      int year = talDate / 10000;
      int month = (talDate - year * 10000) / 100;
      int day = talDate % 100;
      return new DateTime(year, month, day);
    }
  }
}
