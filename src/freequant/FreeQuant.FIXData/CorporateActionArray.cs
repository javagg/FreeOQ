using FreeQuant.Data;

namespace FreeQuant.FIXData
{
	public class CorporateActionArray : DataArray
	{
		public CorporateAction this[int index]
		{
			get
			{
				return base[index] as CorporateAction;
			}
		}
	}
}
