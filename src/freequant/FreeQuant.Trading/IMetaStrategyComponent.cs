// Type: SmartQuant.Trading.IMetaStrategyComponent
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using SmartQuant.Instruments;

namespace SmartQuant.Trading
{
  public interface IMetaStrategyComponent
  {
    MetaStrategyBase MetaStrategyBase { get; }

    Portfolio Portfolio { get; }
  }
}
