// Type: OpenQuant.Shared.Data.Import.TAQ.IQuoteRecord
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal interface IQuoteRecord
  {
    int Time { get; }

    double Bid { get; }

    double Ask { get; }

    int BidSize { get; }

    int AskSize { get; }
  }
}
