using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TTitle
	{
		private Pad pad;
		private ArrayList items;
		private int y;

		public ArrayList Items
		{
			get
			{
				return this.items; 
			}
		}

		public bool ItemsEnabled { get; set; }
		public string Text { get; set; }
		public Font Font { get; set; }
		public Color Color { get; set; }
		public ETitlePosition Position { get; set; }
		public int X { get; set; }
		public int Y { get; set; }

		public int Width
		{
			get
			{
				return (int)this.pad.Graphics.MeasureString(this.vsC3u6p1dQ(), this.Font).Width;
			}
		}

		public int Height
		{
			get
			{
				return (int)this.pad.Graphics.MeasureString(this.vsC3u6p1dQ(), this.Font).Height;
			}
		}

		public ETitleStrategy Strategy { get; set; }

		public TTitle(Pad pad) : this(pad, String.Empty)
		{
		}

		public TTitle(Pad pad, string text) : base()
		{
			this.pad = pad;
			this.Text = text;
			this.Init();
		}

		private void Init()
		{
			this.items = new ArrayList();
			this.ItemsEnabled = false;
			this.Font = new Font("Times New Roman", 8);
			this.Color = Color.Black;
			this.Position = ETitlePosition.Left;
			this.Strategy = ETitleStrategy.Smart;
			this.X = 0;
			this.Y = 0;
		}

		public void Add(string text, Color color)
		{
			this.items.Add(new TTitleItem(text, color));
		}

		private string vsC3u6p1dQ()
		{
			string str = this.Text;
			foreach (TTitleItem ttitleItem in this.items)
				str = str + "" + ttitleItem.Text;
			return str;
		}

		public void Paint()
		{
			SolidBrush solidBrush1 = new SolidBrush(this.Color);
			if (this.Text != "")
				this.pad.Graphics.DrawString(this.Text, this.Font, solidBrush1, this.X, this.Y);
			if (this.Strategy == ETitleStrategy.Smart && this.Text == "" && (!this.ItemsEnabled && this.items.Count != 0))
				this.pad.Graphics.DrawString(((TTitleItem)this.items[0]).Text, this.Font, new SolidBrush(this.Color), this.X, this.Y);
			if (!this.ItemsEnabled)
				return;
			string str = this.Text;
			foreach (TTitleItem ttitleItem in this.items)
			{
				SolidBrush solidBrush2 = new SolidBrush(ttitleItem.Color);
				string text = str + "";
				int num = this.X + (int)this.pad.Graphics.MeasureString(text, this.Font).Width;
				this.pad.Graphics.DrawString(ttitleItem.Text, this.Font, solidBrush2, num, this.Y);
				str = text + ttitleItem.Text;
			}
		}
	}
}
