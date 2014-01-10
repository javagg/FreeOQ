using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
	public class CanvasManager
	{
		private static CanvasList canvases;  

		public static CanvasList Canvases
		{
			get
			{
				return CanvasManager.canvases;
			}
		}

		static CanvasManager()
		{
			CanvasManager.canvases = new CanvasList();
		}

		public static void Add(Canvas canvas)
		{
			if (CanvasManager.canvases[canvas.Name] != null)
				((SortedList)CanvasManager.canvases).Remove((object)canvas.Name);
			((SortedList)CanvasManager.canvases).Add((object)canvas.Name, (object)canvas);
		}

		public static void Remove(Canvas canvas)
		{
			((SortedList)CanvasManager.canvases).Remove((object)canvas.Name);
		}

		public static Canvas GetCanvas(string name)
		{
			return CanvasManager.canvases[name];
		}
	}
}
