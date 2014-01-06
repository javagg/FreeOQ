// Type: OpenQuant.ObjectMap.IObjectConverter
// Assembly: OpenQuant.ObjectMap, Version=1.0.5037.20289, Culture=neutral, PublicKeyToken=null
// MVID: 2281CBD6-B2D3-4F6D-B967-4CB0FC509EFE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.ObjectMap.dll

using SmartQuant.Data;
using SmartQuant.Execution;
using SmartQuant.Instruments;
using SmartQuant.Providers;

namespace OpenQuant.ObjectMap
{
  public interface IObjectConverter
  {
    object Convert(Bar bar);

    object Convert(Portfolio portfolio);

    object Convert(SingleOrder order);

    object Convert(Trade trade);

    object Convert(Quote quote);

    object Convert(ProviderError error);

    object Convert(MarketDepth marketDepth);
  }
}
