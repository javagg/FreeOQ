namespace FreeQuant.Charting
{
	public interface IDrawable
	{
		bool ToolTipEnabled { get; set; }

		string ToolTipFormat { get; set; }

		void Draw();

		void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY);

		TDistance Distance(double X, double Y);
	}
}
