using System.Collections.Generic;

namespace FreeQuant
{
	public class InfoBase<T> where T : InfoItemBase, new()
	{
		protected List<T> items;

		public T[] Items
		{
			get
			{
				return items.ToArray();
			}
		}
	}
}
