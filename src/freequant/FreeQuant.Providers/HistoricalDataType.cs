// Type: SmartQuant.Providers.HistoricalDataType
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using System;

namespace SmartQuant.Providers
{
  [Flags]
  public enum HistoricalDataType : byte
  {
    Trade = (byte) 1,
    Quote = (byte) 2,
    Bar = (byte) 4,
    Daily = (byte) 8,
    MarketDepth = (byte) 16,
  }
}
