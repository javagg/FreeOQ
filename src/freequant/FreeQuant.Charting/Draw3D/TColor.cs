using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting.Draw3D
{
	public struct TColor
	{
		private double r;
		private double g;
		private double b;

		public Color Color
		{
			get
			{
				return Color.FromArgb((int)((double)byte.MaxValue * this.r), (int)((double)byte.MaxValue * this.g), (int)((double)byte.MaxValue * this.b));
			}
			set
			{
				this = new TColor(value);
			}
		}

		public TColor(double r, double g, double b)
		{
			this.r = r; 
			this.g = g; 
			this.b = b; 
		}

		public TColor(double Gray)
		{
			this.r = this.g = this.b = Gray;
		}

		public TColor(Color c)
		{
			this.r = 1.0 / byte.MaxValue * c.R;
			this.g = 1.0 / byte.MaxValue * c.G;
			this.b = 1.0 / byte.MaxValue * c.B;
		}

		public static implicit operator TColor(Color c)
		{
			return new TColor(c);
		}

		public static TColor operator +(TColor a, TColor b)
		{
			return new TColor(a.r + b.r, a.g + b.g, a.b + b.b);
		}

		public static TColor operator *(TColor a, TColor b)
		{
			return new TColor(a.r * b.r, a.g * b.g, a.b * b.b);
		}

		public static TColor operator *(double k, TColor c)
		{
			return new TColor(k * c.r, k * c.g, k * c.b);
		}

		public static TColor operator *(TColor c, double k)
		{
			return k * c;
		}

		public int Get888()
		{
			return ((int)((double)byte.MaxValue * this.r) << 16) + ((int)((double)byte.MaxValue * this.g) << 8) + (int)((double)byte.MaxValue * this.b);
		}

		private void K7ICoOhHGw([In] ref double obj0)
		{
			if (obj0 < 1.0 / 254.0)
				obj0 = 1.0 / 254.0;
			if (obj0 <= 1.0)
				return;
			obj0 = 1.0;
		}

		public void Clip()
		{
			this.K7ICoOhHGw(ref this.r);
			this.K7ICoOhHGw(ref this.g);
			this.K7ICoOhHGw(ref this.b);
		}

		public static TColor Clip(TColor c)
		{
			TColor tcolor = c;
			tcolor.Clip();
			return tcolor;
		}
	}
}
