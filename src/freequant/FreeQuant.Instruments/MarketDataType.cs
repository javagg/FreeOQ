namespace FreeQuant.Instruments
{
  public enum MarketDataType : byte
  {
    None = (byte) 0,
    Trade = (byte) 1,
    Quote = (byte) 2,
    MarketDepth = (byte) 4,
    All = (byte) 255,
  }
}
