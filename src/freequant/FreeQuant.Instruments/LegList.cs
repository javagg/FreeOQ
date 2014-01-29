using FreeQuant.FIX;

namespace FreeQuant.Instruments
{
	public class LegList : FIXGroupList
	{
		public Leg this[int index]
		{
			get
			{
				return base[index] as Leg;
			}
		}
	}
}

