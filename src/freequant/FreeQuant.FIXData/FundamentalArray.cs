using FreeQuant.Data;

namespace FreeQuant.FIXData
{
	public class FundamentalArray : DataArray
	{
		public new Fundamental this[int index]
		{
			get
			{
				return base[index] as Fundamental;
			}
		}
	}
}
