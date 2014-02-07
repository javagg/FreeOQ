using System.Collections;
using System;

namespace FreeQuant.Data
{
	public class MarketDepthArray : DataArray
	{
		public new MarketDepth this[int index]
		{
			get
			{
				return base[index] as MarketDepth;
			}
		}

		public bool AddReplaceItem(MarketDepth item)
		{
			bool flag = false;
			int num = 0;
			IEnumerator enumerator = this.fList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MarketDepth marketDepth = (MarketDepth)enumerator.Current;
					if (marketDepth.Price == item.Price && marketDepth.Size == item.Size && marketDepth.MarketMaker == item.MarketMaker && marketDepth.Side == item.Side)
					{
						this.fList[num] = item;
						flag = true;
					}
					num++;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			if (!flag)
			{
				this.fList.Add(item);
			}
			return flag;
		}
	}
}
