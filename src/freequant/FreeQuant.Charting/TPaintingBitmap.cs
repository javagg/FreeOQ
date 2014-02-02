using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TPaintingBitmap
	{
		public const PixelFormat pixel_format = PixelFormat.Format32bppRgb;
		private int[] data;
		private int size;

		public int Width { get; private set; }
		public int Height { get; private set; }

		public bool Valid
		{
			get
			{
				return this.data != null;
			}
		}

		public TPaintingBitmap(int w, int h)
		{
			this.BeginDrawing(w, h);
		}

		public bool BeginDrawing(int w, int h)
		{
			this.Width = w;
			this.Height = h;
			this.size = w * h;
			this.data = new int[this.size];
			return true;
		}

		public Bitmap Get()
		{
			Bitmap bitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppRgb);
			Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
			BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
			Marshal.Copy(this.data, 0, bitmapdata.Scan0, this.size);
			bitmap.UnlockBits(bitmapdata);
			return bitmap;
		}

		public int intGetPixel(int x, int y)
		{
			return this.data[this.Width * y + x];
		}

		public Color ColorGetPixel(int x, int y)
		{
			return Color.FromArgb(this.data[this.Width * y + x]);
		}

		public void SetPixel(int x, int y, int c)
		{
			this.data[this.Width * y + x] = c;
		}

		public void SetPixel(int x, int y, Color c)
		{
			this.data[this.Width * y + x] = c.ToArgb();
		}

		public void Fill(int c)
		{
			for (int index = 0; index < this.size; ++index)
				this.data[index] = c;
		}

		public void Fill(Color c)
		{
			this.Fill(c.ToArgb());
		}

		public unsafe void FillRectangle(int c, int x, int y, int w, int h)
		{
			if (x + w > this.Width)
				w -= x + w - this.Width;
			if (y + h > this.Height)
				h -= y + h - this.Height;
			if (x < 0)
			{
				w += x;
				x = 0;
			}
			if (y < 0)
			{
				h += y;
				y = 0;
			}
			fixed (int* numPtr1 = this.data)
			{
				int* numPtr2 = numPtr1 + this.Width * y + x;
				int num = y + h;
				while (y < num)
				{
					int* numPtr3 = numPtr2;
					for (int* numPtr4 = numPtr2 + w; numPtr3 < numPtr4; ++numPtr3)
						*numPtr3 = c;
					++y;
					numPtr2 += this.Width;
				}
			}
		}

		public void FillRectangle(Color c, int x, int y, int w, int h)
		{
			this.FillRectangle(c.ToArgb(), x, y, w, h);
		}
	}
}
