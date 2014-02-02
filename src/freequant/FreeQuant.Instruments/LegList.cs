using FreeQuant.FIX;

namespace FreeQuant.Instruments
{
	public class LegList : FIXGroupList
	{
		new public Leg this[int index]
		{
			get
			{
				return base[index] as Leg;
			}
		}
	}
}

