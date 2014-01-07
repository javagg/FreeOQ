// Type: SmartQuant.Charting.TPaintingBitmap
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LF5CHsppRm;
      }
    }

    public int Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tNWCv5YncG;
      }
    }

    public bool Valid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HgMCE3F1vm != null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TPaintingBitmap()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TPaintingBitmap(int W, int H)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.BeginDrawing(W, H);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool BeginDrawing(int W, int H)
    {
      this.LF5CHsppRm = W;
      this.tNWCv5YncG = H;
      this.hZqCU3rUEJ = W * H;
      this.HgMCE3F1vm = new int[this.hZqCU3rUEJ];
      return true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bitmap Get()
    {
      Bitmap bitmap = new Bitmap(this.LF5CHsppRm, this.tNWCv5YncG, PixelFormat.Format32bppRgb);
      Rectangle rect = new Rectangle(0, 0, this.LF5CHsppRm, this.tNWCv5YncG);
      BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
      Marshal.Copy(this.HgMCE3F1vm, 0, bitmapdata.Scan0, this.hZqCU3rUEJ);
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int intGetPixel(int x, int y)
    {
      return this.HgMCE3F1vm[this.LF5CHsppRm * y + x];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color ColorGetPixel(int x, int y)
    {
      return Color.FromArgb(this.HgMCE3F1vm[this.LF5CHsppRm * y + x]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPixel(int x, int y, int c)
    {
      this.HgMCE3F1vm[this.LF5CHsppRm * y + x] = c;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPixel(int x, int y, Color c)
    {
      this.HgMCE3F1vm[this.LF5CHsppRm * y + x] = c.ToArgb();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Fill(int c)
    {
      for (int index = 0; index < this.hZqCU3rUEJ; ++index)
        this.HgMCE3F1vm[index] = c;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Fill(Color c)
    {
      this.Fill(c.ToArgb());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FillRectangle(Color c, int x, int y, int w, int h)
    {
      this.FillRectangle(c.ToArgb(), x, y, w, h);
    }
  }
}
