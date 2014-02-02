using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TLegendItem
	{
		public string Text { get; set; }
		public Color Color { get; set; }
		public Font Font { get; set; }
		public TLegendItem(string text, Color color, Font font)
		{
			this.Text = text;
			this.Color = color;
			this.Font = font;
		}

		public TLegendItem(string text, Color color)
		{
			this.Text = text;
			this.Color = color;
			this.Font = new Font("Arial", 8);
		}
	}
}
