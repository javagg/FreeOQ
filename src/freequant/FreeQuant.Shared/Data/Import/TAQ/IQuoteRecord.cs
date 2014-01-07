// Type: SmartQuant.Shared.Data.Import.TAQ.IQuoteRecord
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

namespace SmartQuant.Shared.Data.Import.TAQ
{
  public interface IQuoteRecord
  {
    int Time { get; }

    double Bid { get; }

    double Ask { get; }

    int BidSize { get; }

    int AskSize { get; }
  }
}
