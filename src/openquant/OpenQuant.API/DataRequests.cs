namespace OpenQuant.API
{
  public class DataRequests
  {
    private BarRequestList barRequests = new BarRequestList();
    private bool hasBarRequests;
    private bool hasQuoteRequest;
    private bool hasTradeRequest;
    private bool hasDailyRequest;
    private bool hasMarketDepthRequst;

    public BarRequestList BarRequests
    {
      get
      {
        return this.barRequests;
      }
    }

    public bool HasBarRequests
    {
      get
      {
        return this.hasBarRequests;
      }
      set
      {
        this.hasBarRequests = value;
      }
    }

    public bool HasQuoteRequest
    {
      get
      {
        return this.hasQuoteRequest;
      }
      set
      {
        this.hasQuoteRequest = value;
      }
    }

    public bool HasTradeRequest
    {
      get
      {
        return this.hasTradeRequest;
      }
      set
      {
        this.hasTradeRequest = value;
      }
    }

    public bool HasDailyRequest
    {
      get
      {
        return this.hasDailyRequest;
      }
      set
      {
        this.hasDailyRequest = value;
      }
    }

    public bool HasMarketDepthRequest
    {
      get
      {
        return this.hasMarketDepthRequst;
      }
      set
      {
        this.hasMarketDepthRequst = value;
      }
    }

    public void AddTrade()
    {
      this.hasTradeRequest = true;
    }

    public void RemoveTrade()
    {
      this.hasTradeRequest = false;
    }

    public void AddQuote()
    {
      this.hasQuoteRequest = true;
    }

    public void RemoveQuote()
    {
      this.hasQuoteRequest = false;
    }

    public void AddDaily()
    {
      this.hasDailyRequest = true;
    }

    public void RemoveDaily()
    {
      this.hasDailyRequest = false;
    }

    public BarRequest Add(BarType barType, long barSize, bool isBarFacroryRequest)
    {
      return this.barRequests.Add(barType, barSize, isBarFacroryRequest);
    }

    public void Remove(BarType barType, long barSize)
    {
      this.barRequests.Remove(barType, barSize);
    }
  }
}
