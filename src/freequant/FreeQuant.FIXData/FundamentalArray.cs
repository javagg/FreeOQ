using FreeQuant.Data;

namespace FreeQuant.FIXData
{
	public class FundamentalArray : DataArray
	{
		public Fundamental this[int index]
		{
			get
			{
				return base[index] as Fundamental;
			}
		}
	}
}
