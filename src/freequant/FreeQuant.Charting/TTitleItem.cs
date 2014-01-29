using System;
using System.Drawing;
using System.ComponentModel;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TTitleItem
	{
		public string Text { get; set; }
		//		[DefaultValue(Color.Black)]
		public Color Color { get; set; }

		public TTitleItem(string text = null, Color color = default(Color))
		{
			this.Text = text ?? String.Empty;
			this.Color = color;
		}
	}
}
