using System;

namespace OpenQuant.API
{
  [Obsolete("Use OpenQuant.API.Route class instead")]
  public static class OrderRoute
  {
    public const byte Simulator = (byte) 2;
    public const byte IB = (byte) 4;
    public const byte TTFIX = (byte) 10;
    public const byte Hotspot = (byte) 26;
    public const byte Currenex = (byte) 28;
    public const byte QUIKFIX = (byte) 31;
    public const byte OSLFIX = (byte) 32;
    public const byte Nordnet = (byte) 33;
    public const byte Integral = (byte) 35;
    public const byte Finam = (byte) 117;
  }
}
