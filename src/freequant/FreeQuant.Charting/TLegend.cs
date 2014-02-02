using System;
using System.Collections;
using System.Drawing;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TLegend
	{
		private ArrayList items;
		private int width;
		private int height;

		public Pad Pad { get; set; }

		public int X { get; set; }

		public int Y { get; set; }

		public int Width
		{
			get
			{
				this.width = 0; 
				foreach (TLegendItem tlegendItem in this.items)
				{
					int num = (int)this.Pad.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Width;
					if (num > this.width)
						this.width = num;
				}
				this.width += 12;
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		public int Height
		{
			get
			{
				this.height = 0; 
				foreach (TLegendItem tlegendItem in this.items)
					this.height += (int)this.Pad.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Height + 2;
				this.height += 2;
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		public bool BorderEnabled { get; set; }
		public Color BorderColor { get; set; }
		public Color BackColor { get; set; }

		public ArrayList Items
		{
			get
			{
				return this.items; 
			}
		}

		public TLegend(Pad pad) : base()
		{
			this.Pad = pad;
			this.Init();
		}

		private void Init()
		{
			this.BorderEnabled = true;
			this.BorderColor = Color.Black;
			this.BackColor = Color.LightYellow;
			this.items = new ArrayList();
		}

		public void Add(string text, Color color)
		{
			this.items.Add(new TLegendItem(text, color));
		}

		public void Add(string text, Color color, Font font)
		{
			this.items.Add(new TLegendItem(text, color, font));
		}

		public void Add(TLegendItem item)
		{
			this.items.Add(item);
		}

		public virtual void Paint()
		{
			this.Pad.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.X, this.Y, this.Width, this.Height);
			if (this.BorderEnabled)
				this.Pad.Graphics.DrawRectangle(new Pen(this.BorderColor), this.X, this.Y, this.Width, this.Height);
			int x1 = this.X + 5;
			int num1 = this.Y + 2;
			foreach (TLegendItem tlegendItem in this.items)
			{
				int num2 = (int)this.Pad.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Height;
				this.Pad.Graphics.DrawLine(new Pen(tlegendItem.Color), x1, num1 + num2 / 2, x1 + 5, num1 + num2 / 2);
				this.Pad.Graphics.DrawString(tlegendItem.Text, tlegendItem.Font, (Brush)new SolidBrush(Color.Black), (float)(x1 + 5 + 2), (float)num1);
				num1 += 2 + num2;
			}
		}
	}
}
