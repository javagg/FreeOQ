namespace FreeQuant.Data
{
  public class MarketDepthArray : DataArray
  {
//    public MarketDepth this[int index]
//    {
//       get
//      {
//        return this.fList[index] as MarketDepth;
//      }
//    }

    public bool AddReplaceItem(MarketDepth item)
    {
      bool flag = false;
      int index = 0;
      foreach (MarketDepth marketDepth in this.list)
      {
        if (marketDepth.Price == item.Price && marketDepth.Size == item.Size && (marketDepth.MarketMaker == item.MarketMaker && marketDepth.Side == item.Side))
        {
          this.list[index] = (object) item;
          flag = true;
        }
        ++index;
      }
      if (!flag)
        this.list.Add((object) item);
      return flag;
    }
  }
}
