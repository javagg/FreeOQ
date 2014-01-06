// Type: SmartQuant.FIX.OrdType
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

namespace SmartQuant.FIX
{
  public enum OrdType
  {
    Undefined,
    Market,
    Limit,
    Stop,
    StopLimit,
    MarketOnClose,
    WithOrWithout,
    LimitOrBetter,
    LimitWithOrWithout,
    OnBasis,
    OnClose,
    LimitOnClose,
    ForexMarket,
    PreviouslyQuoted,
    PreviouslyIndicated,
    ForexLimit,
    ForexSwap,
    ForexPreviouslyQuoted,
    Funari,
    MIT,
    MarketWithLeftoverAsLimit,
    PreviousFundValuationPoint,
    NextFundValuationPoint,
    Pegged,
    TrailingStop,
    TrailingStopLimit,
  }
}
