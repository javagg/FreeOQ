using System;
using System.Collections;

namespace FreeQuant.Charting
{
	[Serializable]
	public class CanvasList : SortedList
	{
		public Canvas this[string name]
		{
			get
			{
				return base[name] as Canvas;
			}
		}

		public void Add(Canvas canvas)
		{
			base.Add(canvas.Name, canvas);
		}

		public void Remove(Canvas canvas)
		{
			base.Remove(canvas.Name);
		}

		public void Print()
		{
			foreach (Canvas canvas in this)
				canvas.Print();
		}
	}
}
