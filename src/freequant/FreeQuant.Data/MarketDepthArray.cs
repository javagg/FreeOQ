// Type: SmartQuant.Data.MarketDepthArray
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  public class MarketDepthArray : DataArray
  {
    public MarketDepth this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as MarketDepth;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepthArray()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddReplaceItem(MarketDepth item)
    {
      bool flag = false;
      int index = 0;
      foreach (MarketDepth marketDepth in this.fList)
      {
        if (marketDepth.Price == item.Price && marketDepth.Size == item.Size && (marketDepth.MarketMaker == item.MarketMaker && marketDepth.Side == item.Side))
        {
          this.fList[index] = (object) item;
          flag = true;
        }
        ++index;
      }
      if (!flag)
        this.fList.Add((object) item);
      return flag;
    }
  }
}
