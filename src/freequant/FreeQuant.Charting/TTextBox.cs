using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TTextBox : IDrawable
	{
		private ArrayList items;

		[Category("ToolTip")]
		[Description("")]
		public bool ToolTipEnabled { get; set; }

		[Category("ToolTip")]
		[Description("")]
		public string ToolTipFormat { get; set; }

		public ETextBoxPosition Position { get; set; }

		public int X { get; set; }

		public int Y { get; set; }

		public int Width { get; private set; }

		public int Height { get; private set; }

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

		public TTextBox() : base()
		{
			this.X = 10;
			this.Y = 10;
			this.Init();
		}

		public TTextBox(int x, int y) : base()
		{
			this.X = x;
			this.Y = y;
			this.Init();
		}

		private void Init()
		{
			this.Width = -1;
			this.Height = -1;
			this.Position = ETextBoxPosition.TopRight;
			this.BorderEnabled = true;
			this.BorderColor = Color.Black;
			this.BackColor = Color.LightYellow;
			this.items = new ArrayList();
		}

		public void Add(string text, Color color)
		{
			this.items.Add(new TTextBoxItem(text, color));
		}

		public void Add(string text, Color color, Font font)
		{
			this.items.Add(new TTextBoxItem(text, color, font));
		}

		public void Add(TTextBoxItem item)
		{
			this.items.Add(item);
		}

		public void Clear()
		{
			this.items.Clear();
		}

		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("CName", "CText");
			}
			Chart.Pad.Add(this);
		}

		private float MhmouvgBhg(Pad pad)
		{
			this.Width = 0;
			foreach (TTextBoxItem ttextBoxItem in this.items)
			{
				int num = (int)pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Width;
				if (num > this.Width)
					this.Width = num;
			}
			this.Width += 12;
			return (float)this.Width;
		}

		private float qUZomVYuoh(Pad pad)
		{
			this.Height = 0;
			foreach (TTextBoxItem ttextBoxItem in this.items)
				this.Height += (int)pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Height + 2;
			this.Height += 2;
			return (float)this.Height;
		}

		public virtual void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			float height = this.qUZomVYuoh(Pad);
			float width = this.MhmouvgBhg(Pad);
			float x = 0.0f;
			float y = 0.0f;
			switch (this.Position)
			{
				case ETextBoxPosition.TopRight:
					x = (float)(Pad.ClientX() + Pad.ClientWidth() - this.X) - width;
					y = (float)(Pad.ClientY() + this.X);
					break;
				case ETextBoxPosition.TopLeft:
					x = (float)(Pad.ClientX() + this.X);
					y = (float)(Pad.ClientY() + this.Y);
					break;
				case ETextBoxPosition.BottomRight:
					x = (float)(Pad.ClientX() + Pad.ClientWidth() - this.X) - width;
					y = (float)(Pad.ClientY() + Pad.ClientHeight() - this.Y) - height;
					break;
				case ETextBoxPosition.BottomLeft:
					x = (float)(Pad.ClientX() + this.X);
					y = (float)(Pad.ClientY() + Pad.ClientHeight() - this.Y) - height;
					break;
			}
			Pad.Graphics.FillRectangle(new SolidBrush(this.BackColor), x, y, width, height);
			if (this.BorderEnabled)
				Pad.Graphics.DrawRectangle(new Pen(this.BorderColor), x, y, width, height);
			foreach (TTextBoxItem ttextBoxItem in this.items)
			{
				int num = (int)Pad.Graphics.MeasureString(ttextBoxItem.Text, ttextBoxItem.Font).Height;
				Pad.Graphics.DrawString(ttextBoxItem.Text, ttextBoxItem.Font, new SolidBrush(ttextBoxItem.Color), x + 5f, y);
				y += (float)(2 + num);
			}
		}

		public TDistance Distance(double x, double y)
		{
			return null;
		}
	}
}
