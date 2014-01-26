using FreeQuant.FIX;

namespace FreeQuant.Instruments
{
	public class UnderlyingList : FIXGroupList
	{
		new public Underlying this[int index]
		{
			get
			{
				return base[index] as Underlying;
			}
		}
	}
}
