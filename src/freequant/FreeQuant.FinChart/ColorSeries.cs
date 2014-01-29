using System;
using System.Collections;
using System.Drawing;

namespace FreeQuant.FinChart
{
	public class ColorSeries : ICollection
	{
		private SortedList colors;

		public bool IsSynchronized
		{
			get
			{
				return this.colors.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.colors.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.colors.SyncRoot;
			}
		}

		public ColorSeries()
		{
			this.colors = new SortedList();
		}

		public void CopyTo(Array array, int index)
		{
			this.colors.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.colors.Values.GetEnumerator();
		}

		public void AddColor(DateTime date, Color color)
		{
			this.colors.Add(date, color);
		}
	}
}
