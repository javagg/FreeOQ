using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TLegendItem
	{
		private Color color;
		private Font font;

		public string Text { get; set; }

		public Color Color { get; set; }

		public Font Font { get; set; }

		public TLegendItem(string Text, Color Color, Font Font) : base()
		{
			this.Text = Text;
			this.Color = Color;
			this.Font = Font;
		}

		public TLegendItem(string Text, Color Color) : base()
		{
			this.Text = Text;
			this.Color = Color;
			this.font = new Font("Arial", 8);
		}
	}
}
