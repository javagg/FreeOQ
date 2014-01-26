namespace FreeQuant.Data
{
	public class MarketDepthArray : DataArray
	{
		new public MarketDepth this[int index]
		{
			get
			{
				return this.list[index] as MarketDepth;
			}
		}

		public bool AddReplaceItem(MarketDepth item)
		{
			bool flag = false;
			int index = 0;
			foreach (MarketDepth marketDepth in this.list)
			{
				if (marketDepth.Price == item.Price && marketDepth.Size == item.Size && (marketDepth.MarketMaker == item.MarketMaker && marketDepth.Side == item.Side))
				{
					this.list[index] = item;
					flag = true;
				}
				++index;
			}
			if (!flag)
				this.list.Add(item);
			return flag;
		}
	}
}
