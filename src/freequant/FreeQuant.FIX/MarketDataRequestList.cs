using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class MarketDataRequestList : FIXGroupList
  {
    public FIXMarketDataRequest this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as FIXMarketDataRequest;
      }
    }


    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator FIXMarketDataRequest[](MarketDataRequestList list)
    {
      FIXMarketDataRequest[] marketDataRequestArray = new FIXMarketDataRequest[list.Count];
      for (int index = 0; index < marketDataRequestArray.Length; ++index)
        marketDataRequestArray[index] = list[index];
      return marketDataRequestArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMarketDataRequest GetById(int id)
    {
      return base.GetById(id) as FIXMarketDataRequest;
    }
  }
}
