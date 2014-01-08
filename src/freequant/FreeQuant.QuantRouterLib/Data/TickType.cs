using System;

namespace FreeQuant.QuantRouterLib.Data
{
  [Flags]
  public enum TickType : byte
  {
    Unknown = (byte) 0,
    Bid = (byte) 1,
    Ask = (byte) 2,
    Trade = (byte) 4,
    Level2 = (byte) 8,
  }
}
