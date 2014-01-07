// Type: SmartQuant.Shared.Data.Import.CSV.ColumnType
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

namespace SmartQuant.Shared.Data.Import.CSV
{
  public enum ColumnType
  {
    Symbol = 1,
    DateTime = 2,
    Date = 4,
    Time = 8,
    Price = 16,
    Size = 32,
    Open = 64,
    High = 128,
    Low = 256,
    Close = 512,
    Volume = 1024,
    OpenInt = 2048,
    Bid = 4096,
    BidSize = 8192,
    Ask = 16384,
    AskSize = 32768,
    Skipped = 65536,
  }
}
