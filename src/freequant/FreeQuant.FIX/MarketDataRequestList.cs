using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
	public class MarketDataRequestList : FIXGroupList
	{
		new public FIXMarketDataRequest this [int index]
		{
			get
			{
				return base[index] as FIXMarketDataRequest;
			}
		}

		public static implicit operator FIXMarketDataRequest[](MarketDataRequestList list)
		{
			var array = new FIXMarketDataRequest[list.Count];
			for (int index = 0; index < array.Length; ++index)
				array[index] = list[index];
			return array;
		}

		new public FIXMarketDataRequest GetById(int id)
		{
			return base.GetById(id) as FIXMarketDataRequest;
		}
	}
}
