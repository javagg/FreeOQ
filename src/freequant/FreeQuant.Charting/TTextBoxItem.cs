using System.Drawing;

namespace FreeQuant.Charting
{
	public class TTextBoxItem
	{
		public string Text { get; set; }
		public Color Color { get; set; }
		public Font Font { get; set; }

		public TTextBoxItem(string text, Color color, Font font = null)
		{
			this.Text = text;
			this.Color = color;
			this.Font = font ?? new Font("Arial", 8);
		}
	}
}
