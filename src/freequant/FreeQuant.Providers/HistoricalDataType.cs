using System;

namespace FreeQuant.Providers
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
