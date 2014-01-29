using System.Collections;

namespace FreeQuant.Charting
{
	public class CanvasManager
	{

		public static CanvasList Canvases { get; private set; }
		static CanvasManager()
		{
			CanvasManager.Canvases = new CanvasList();
		}

		public static void Add(Canvas canvas)
		{
			if (CanvasManager.Canvases[canvas.Name] != null)
				CanvasManager.Canvases.Remove(canvas.Name);
			CanvasManager.Canvases.Add(canvas.Name, canvas);
		}

		public static void Remove(Canvas canvas)
		{
			CanvasManager.Canvases.Remove(canvas.Name);
		}

		public static Canvas GetCanvas(string name)
		{
			return CanvasManager.Canvases[name];
		}
	}
}
