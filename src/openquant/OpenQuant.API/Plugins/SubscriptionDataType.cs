using System;

namespace OpenQuant.API.Plugins
{
  [Flags]
  public enum SubscriptionDataType : byte
  {
    Trades = (byte) 1,
    Quotes = (byte) 2,
    OrderBook = (byte) 4,
  }
}
