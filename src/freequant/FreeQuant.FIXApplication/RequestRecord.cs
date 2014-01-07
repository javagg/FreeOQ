using FreeQuant.FIX;

namespace FreeQuant.FIXApplication
{
  public class RequestRecord
  {
    public string Symbol { get; private set; }
    public FIXMarketDataRequest Request { get; private set; }
    public int RequestCount { get; internal set; }
    public RequestRecord(string symbol, FIXMarketDataRequest request)
    {
      this.Symbol = symbol;
      this.Request = request;
      this.RequestCount = 0;
    }
  }
}
