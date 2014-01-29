namespace FreeQuant.Charting
{
	public interface IDrawable
	{
		bool ToolTipEnabled { get; set; }
		string ToolTipFormat { get; set; }
		void Draw();
		void Paint(Pad pad, double minX, double maxX, double minY, double maxY);
		TDistance Distance(double x, double y);
	}
}
