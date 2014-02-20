using FreeQuant.Data;

namespace FreeQuant.FIXData
{
	public class CorporateActionArray : DataArray
	{
        public new CorporateAction this[int index]
		{
			get
			{
				return base[index] as CorporateAction;
			}
		}
	}
}
