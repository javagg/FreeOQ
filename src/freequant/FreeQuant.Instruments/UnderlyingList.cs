using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class UnderlyingList : FIXGroupList
	{
		public Underlying this [int index]
		{
			get
			{
				return this.fList[index] as Underlying;
			}
		}
	}
}
