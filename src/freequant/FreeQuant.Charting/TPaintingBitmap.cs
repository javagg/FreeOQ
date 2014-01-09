using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Charting
{
  [Serializable]
  public class TPaintingBitmap
  {
    public const PixelFormat pixel_format = PixelFormat.Format32bppRgb;
    private int[] HgMCE3F1vm;
    private int LF5CHsppRm;
    private int tNWCv5YncG;
    private int hZqCU3rUEJ;

    public int Width
    {
      get
      {
        return this.LF5CHsppRm;
      }
    }

    public int Height
    {
      get
      {
        return this.tNWCv5YncG;
      }
    }

    public bool Valid
    {
      get
      {
        return this.HgMCE3F1vm != null;
      }
    }

    public TPaintingBitmap(int W, int H)
    {
      this.BeginDrawing(W, H);
    }

    public bool BeginDrawing(int W, int H)
    {
      this.LF5CHsppRm = W;
      this.tNWCv5YncG = H;
      this.hZqCU3rUEJ = W * H;
      this.HgMCE3F1vm = new int[this.hZqCU3rUEJ];
      return true;
    }

    public Bitmap Get()
    {
      Bitmap bitmap = new Bitmap(this.LF5CHsppRm, this.tNWCv5YncG, PixelFormat.Format32bppRgb);
      Rectangle rect = new Rectangle(0, 0, this.LF5CHsppRm, this.tNWCv5YncG);
      BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
      Marshal.Copy(this.HgMCE3F1vm, 0, bitmapdata.Scan0, this.hZqCU3rUEJ);
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }

    public int intGetPixel(int x, int y)
    {
      return this.HgMCE3F1vm[this.LF5CHsppRm * y + x];
    }

    public Color ColorGetPixel(int x, int y)
    {
      return Color.FromArgb(this.HgMCE3F1vm[this.LF5CHsppRm * y + x]);
    }

    public void SetPixel(int x, int y, int c)
    {
      this.HgMCE3F1vm[this.LF5CHsppRm * y + x] = c;
    }

    public void SetPixel(int x, int y, Color c)
    {
      this.HgMCE3F1vm[this.LF5CHsppRm * y + x] = c.ToArgb();
    }

    public void Fill(int c)
    {
      for (int index = 0; index < this.hZqCU3rUEJ; ++index)
        this.HgMCE3F1vm[index] = c;
    }

    public void Fill(Color c)
    {
      this.Fill(c.ToArgb());
    }

    public unsafe void FillRectangle(int c, int x, int y, int w, int h)
    {
      if (x + w > this.LF5CHsppRm)
        w -= x + w - this.LF5CHsppRm;
      if (y + h > this.tNWCv5YncG)
        h -= y + h - this.tNWCv5YncG;
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
      fixed (int* numPtr1 = this.HgMCE3F1vm)
      {
        int* numPtr2 = numPtr1 + this.LF5CHsppRm * y + x;
        int num = y + h;
        while (y < num)
        {
          int* numPtr3 = numPtr2;
          for (int* numPtr4 = numPtr2 + w; numPtr3 < numPtr4; ++numPtr3)
            *numPtr3 = c;
          ++y;
          numPtr2 += this.LF5CHsppRm;
        }
      }
    }

    public void FillRectangle(Color c, int x, int y, int w, int h)
    {
      this.FillRectangle(c.ToArgb(), x, y, w, h);
    }
  }
}
