// Type: OpenQuant.Finam.OpenBook
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System.Collections.Generic;
using System.Linq;

namespace OpenQuant.Finam
{
  public class OpenBook
  {
    private List<OpenBookData> openBookBid;
    private List<OpenBookData> openBookAsk;

    public OpenBook()
    {
      this.openBookBid = new List<OpenBookData>();
      this.openBookAsk = new List<OpenBookData>();
    }

    public OpenBookReturn UpdateOpenBook(TransaqOpenBook tob)
    {
      if (tob.Sell == -1)
        return this.Delete(ref tob, ref this.openBookAsk);
      if (tob.Buy == -1)
        return this.Delete(ref tob, ref this.openBookBid);
      if (tob.Sell > 0)
        return this.UpdateOrInsert(ref tob, ref this.openBookAsk, "ASK");
      if (tob.Buy > 0)
        return this.UpdateOrInsert(ref tob, ref this.openBookBid, "DESC");
      else
        return new OpenBookReturn(tob, -1, 0);
    }

    private OpenBookReturn Delete(ref TransaqOpenBook tob, ref List<OpenBookData> openBookData)
    {
      bool flag = true;
      if (openBookData.Count == 0)
        return new OpenBookReturn(tob, -1, 0);
      if (openBookData.Count > 0 && flag)
      {
        for (int index = 0; index < openBookData.Count; ++index)
        {
          if (openBookData[index].Price == tob.Price)
          {
            openBookData.RemoveAt(index);
            return new OpenBookReturn(tob, index, 1);
          }
        }
        flag = false;
      }
      if (openBookData.Count > 0 && !flag)
        return new OpenBookReturn(tob, -1, 0);
      else
        return new OpenBookReturn(tob, -1, 0);
    }

    private OpenBookReturn UpdateOrInsert(ref TransaqOpenBook tob, ref List<OpenBookData> openBookData, string sortType)
    {
      for (int index = 0; index < openBookData.Count; ++index)
      {
        if (openBookData[index].Price == tob.Price)
        {
          openBookData.RemoveAt(index);
          openBookData.Insert(index, new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
          return new OpenBookReturn(tob, index, 3);
        }
      }
      if (openBookData.Count == 0)
      {
        openBookData.Insert(0, new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
        return new OpenBookReturn(tob, 0, 2);
      }
      else
      {
        if (openBookData.Count > 0 && sortType == "ASK")
        {
          if (tob.Price < Enumerable.First<OpenBookData>((IEnumerable<OpenBookData>) openBookData).Price)
          {
            openBookData.Insert(0, new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
            return new OpenBookReturn(tob, 0, 2);
          }
          else if (tob.Price > Enumerable.Last<OpenBookData>((IEnumerable<OpenBookData>) openBookData).Price)
          {
            openBookData.Add(new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
            return new OpenBookReturn(tob, openBookData.Count - 1, 2);
          }
          else
          {
            for (int index = 0; index < openBookData.Count - 1; ++index)
            {
              if (openBookData[index].Price < tob.Price && tob.Price < openBookData[index + 1].Price)
              {
                openBookData.Insert(index + 1, new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
                return new OpenBookReturn(tob, index + 1, 2);
              }
            }
          }
        }
        if (openBookData.Count > 0 && sortType == "DESC")
        {
          if (tob.Price > Enumerable.First<OpenBookData>((IEnumerable<OpenBookData>) openBookData).Price)
          {
            openBookData.Insert(0, new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
            return new OpenBookReturn(tob, 0, 2);
          }
          else if (tob.Price < Enumerable.Last<OpenBookData>((IEnumerable<OpenBookData>) openBookData).Price)
          {
            openBookData.Add(new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
            return new OpenBookReturn(tob, openBookData.Count - 1, 2);
          }
          else
          {
            for (int index = 0; index < openBookData.Count - 1; ++index)
            {
              if (openBookData[index].Price > tob.Price && tob.Price > openBookData[index + 1].Price)
              {
                openBookData.Insert(index + 1, new OpenBookData(tob.Price, tob.Buy == 0 ? tob.Sell : tob.Buy));
                return new OpenBookReturn(tob, index + 1, 2);
              }
            }
          }
        }
        return new OpenBookReturn(tob, -1, 0);
      }
    }
  }
}
