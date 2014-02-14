using FreeQuant.Charting.Draw3D;
using System;
using System.Drawing;

namespace FreeQuant.Charting
{
  [Serializable]
  public class Histogram2D : IDrawable
  {
    public const double epsilon = 1E-09;
    protected string fName;
    protected string fTitle;
    protected int fNBinsX;
    protected int fNBinsY;
    protected double fXMin;
    protected double fXMax;
    protected double fYMin;
    protected double fYMax;
    protected double[,] fBins;
    protected double fBinSizeX;
    protected double fBinSizeY;
    protected double fBinMin;
    protected double fBinMax;
    protected double Kx;
    protected double Ky;
    protected double fShowMaxZ;
    protected int fNColors;
    protected Color[] fPalette;
    private Histogram2D.FZPRsSBmTaNrPqwljR kG6oz8rvGU;
    private Histogram2D.jCAh8vlcna2K6CJfbh U4Z3nPEiRp;
    private Histogram2D.a8pjE1K8r7B62oxStB l303o6TYVf;
    private Histogram2D.XD9QjcfMcOLK0nS6xp MUK33qPZeB;
    public ESmoothing Smoothing;
    [NonSerialized]
		private Brush[] brushes; 
    public bool Multicolor3D;

    public EChartLook Look
    {
       get
      {
        return this.kG6oz8rvGU.Look;
      }
       set
      {
        this.MUK33qPZeB.Look = this.l303o6TYVf.Look = this.U4Z3nPEiRp.Look = this.kG6oz8rvGU.Look = value;
      }
    }

    public TSurface Surface3D
    {
       get
      {
        return this.kG6oz8rvGU.Surface;
      }
       set
      {
        this.U4Z3nPEiRp.Surface = this.kG6oz8rvGU.Surface = value;
      }
    }

    public bool Grid3D
    {
       get
      {
        return this.kG6oz8rvGU.Grid;
      }
       set
      {
        this.MUK33qPZeB.Grid = this.l303o6TYVf.Grid = this.U4Z3nPEiRp.Grid = this.kG6oz8rvGU.Grid = value;
      }
    }

    public bool LevelLines3D
    {
       get
      {
        return this.kG6oz8rvGU.LevelLines;
      }
       set
      {
        this.MUK33qPZeB.LevelLines = this.l303o6TYVf.LevelLines = this.U4Z3nPEiRp.LevelLines = this.kG6oz8rvGU.LevelLines = value;
      }
    }

    public string Name
    {
       get
      {
        return this.fName;
      }
       set
      {
        this.fName = value;
      }
    }

    public string Title
    {
       get
      {
        return this.fTitle;
      }
       set
      {
        this.fTitle = value;
      }
    }

		public bool ToolTipEnabled { get; set; }

		public string ToolTipFormat { get; set; }
   
    public double dX
    {
       get
      {
        return (this.fXMax - this.fXMin) / (double) this.fNBinsX;
      }
    }

    public double dY
    {
       get
      {
        return (this.fYMax - this.fYMin) / (double) this.fNBinsY;
      }
    }

    
    public Histogram2D(string Name, string Title, int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
    {
      this.kG6oz8rvGU = new Histogram2D.FZPRsSBmTaNrPqwljR();
      this.U4Z3nPEiRp = new Histogram2D.jCAh8vlcna2K6CJfbh();
      this.l303o6TYVf = new Histogram2D.a8pjE1K8r7B62oxStB();
      this.MUK33qPZeB = new Histogram2D.XD9QjcfMcOLK0nS6xp();

      this.fName = Name;
      this.fTitle = Title;
      this.uBuojBImWt(NBinsX, XMin, XMax, NBinsY, YMin, YMax);
    }

    
    public Histogram2D(string Name, int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
    {
      this.kG6oz8rvGU = new Histogram2D.FZPRsSBmTaNrPqwljR();
      this.U4Z3nPEiRp = new Histogram2D.jCAh8vlcna2K6CJfbh();
      this.l303o6TYVf = new Histogram2D.a8pjE1K8r7B62oxStB();
      this.MUK33qPZeB = new Histogram2D.XD9QjcfMcOLK0nS6xp();
      this.fName = Name;
      this.uBuojBImWt(NBinsX, XMin, XMax, NBinsY, YMin, YMax);
    }

    
    public Histogram2D(int NBinsX, double XMin, double XMax, int NBinsY, double YMin, double YMax)
    {
      this.kG6oz8rvGU = new Histogram2D.FZPRsSBmTaNrPqwljR();
      this.U4Z3nPEiRp = new Histogram2D.jCAh8vlcna2K6CJfbh();
      this.l303o6TYVf = new Histogram2D.a8pjE1K8r7B62oxStB();
      this.MUK33qPZeB = new Histogram2D.XD9QjcfMcOLK0nS6xp();
      this.uBuojBImWt(NBinsX, XMin, XMax, NBinsY, YMin, YMax);
    }

    
    private void uBuojBImWt(int obj0, double obj1, double obj2, int obj3, double obj4, double obj5)
    {
      this.fNBinsX = obj0;
      this.fNBinsY = obj3;
      this.fBins = new double[this.fNBinsX, this.fNBinsY];
      for (int index1 = 0; index1 < this.fNBinsX; ++index1)
      {
        for (int index2 = 0; index2 < this.fNBinsY; ++index2)
          this.fBins[index1, index2] = 0.0;
      }
      this.fBinSizeX = Math.Abs(obj2 - obj1) / (double) obj0;
      this.fBinSizeY = Math.Abs(obj5 - obj4) / (double) obj3;
      if (obj1 < obj2)
      {
        this.fXMin = obj1;
        this.fXMax = obj2;
      }
      else
      {
        this.fXMin = obj2;
        this.fXMax = obj1;
      }
      if (obj4 < obj5)
      {
        this.fYMin = obj4;
        this.fYMax = obj5;
      }
      else
      {
        this.fYMin = obj5;
        this.fYMax = obj4;
      }
      this.Kx = (double) this.fNBinsX / (this.fXMax - this.fXMin);
      this.Ky = (double) this.fNBinsY / (this.fYMax - this.fYMin);
      this.fBinMin = double.MaxValue;
      this.fBinMax = double.MinValue;
      this.SetPalette(EPalette.Rainbow);
    }

    
    private int W5Lo1oxP5B(double obj0, double obj1, double obj2)
    {
      return (int) (obj2 * (obj0 - obj1) + 1E-09);
    }

    
    private int QfQo9YbNWy(double obj0)
    {
      return this.W5Lo1oxP5B(obj0, this.fXMin, this.Kx);
    }

    
    private int RgcoeI8LA0(double obj0)
    {
      return this.W5Lo1oxP5B(obj0, this.fYMin, this.Ky);
    }

    
    public void Add(double X, double Y)
    {
      if (X < this.fXMin || X >= this.fXMax || (Y < this.fYMin || Y >= this.fYMax))
        return;
      int index1 = this.QfQo9YbNWy(X);
      int index2 = this.RgcoeI8LA0(Y);
      ++this.fBins[index1, index2];
      if (this.fBins[index1, index2] > this.fBinMax)
        this.fBinMax = this.fBins[index1, index2];
      if (this.fBins[index1, index2] >= this.fBinMin)
        return;
      this.fBinMin = this.fBins[index1, index2];
    }

    
    public void Set(double X, double Y, double Value)
    {
      if (X < this.fXMin || X >= this.fXMax || (Y < this.fYMin || Y >= this.fYMax))
        return;
      int index1 = this.QfQo9YbNWy(X);
      int index2 = this.RgcoeI8LA0(Y);
      this.fBins[index1, index2] = Value;
      if (this.fBins[index1, index2] > this.fBinMax)
        this.fBinMax = this.fBins[index1, index2];
      if (this.fBins[index1, index2] >= this.fBinMin)
        return;
      this.fBinMin = this.fBins[index1, index2];
    }

    
    public double Get(double X, double Y)
    {
      if (X < this.fXMin || X >= this.fXMax || (Y < this.fYMin || Y >= this.fYMax))
        return 0.0;
      else
        return this.fBins[this.QfQo9YbNWy(X), this.RgcoeI8LA0(Y)];
    }

    
    public double GetBinSizeX()
    {
      return this.fBinSizeX;
    }

    
    public double GetBinSizeY()
    {
      return this.fBinSizeY;
    }

    
    public double GetBinMinX(int Index)
    {
      return this.fXMin + this.fBinSizeX * (double) Index;
    }

    
    public double GetBinMinY(int Index)
    {
      return this.fYMin + this.fBinSizeY * (double) Index;
    }

    
    public double GetBinMaxX(int Index)
    {
      return this.fXMin + this.fBinSizeX * (double) (Index + 1);
    }

    
    public double GetBinMaxY(int Index)
    {
      return this.fYMin + this.fBinSizeY * (double) (Index + 1);
    }

    
    public double GetBinCentreX(int Index)
    {
      return this.fXMin + this.fBinSizeX * ((double) Index + 0.5);
    }

    
    public double GetBinCentreY(int Index)
    {
      return this.fYMin + this.fBinSizeY * ((double) Index + 0.5);
    }

    
    public double GetSum()
    {
      double num = 0.0;
      for (int index1 = 0; index1 < this.fNBinsX; ++index1)
      {
        for (int index2 = 0; index2 < this.fNBinsY; ++index2)
          num += this.fBins[index1, index2];
      }
      return num;
    }

    
    public double GetSumSqr()
    {
      double num = 0.0;
      for (int index1 = 0; index1 < this.fNBinsX; ++index1)
      {
        for (int index2 = 0; index2 < this.fNBinsY; ++index2)
          num += this.fBins[index1, index2] * this.fBins[index1, index2];
      }
      return num;
    }

    
    public double GetMin()
    {
      return this.fBinMin;
    }

    
    public double GetMax()
    {
      return this.fBinMax;
    }

    
    public void ShowMaxZ(double MaxZ)
    {
      this.fShowMaxZ = MaxZ;
    }

    
    public void ShowUnnormalizedZ()
    {
      this.ShowMaxZ(this.GetMax());
    }

    
    public bool IsNormalized()
    {
      return this.fShowMaxZ != this.GetMax();
    }

    
    public void ShowNormalizedByMax()
    {
      this.ShowMaxZ(1.0);
    }

    
    public void ShowNormalizedBySum()
    {
      this.ShowMaxZ(this.GetMax() / this.GetSum());
    }

    
    public void ShowDensityUnnormalized()
    {
      this.ShowMaxZ(this.GetMax() / (this.dX * this.dY));
    }

    
    public bool IsDensityNormalized()
    {
      return this.fShowMaxZ != this.GetMax() / (this.dX * this.dY);
    }

    
    public void ShowDensityNormalizedByMax()
    {
      this.ShowMaxZ(1.0);
    }

    
    public void ShowDensityNormalizedBySum()
    {
      this.ShowMaxZ(this.GetMax() / (this.GetSum() * this.dX * this.dY));
    }

    
    public void Print()
    {
      for (int Index1 = 0; Index1 < this.fNBinsX; ++Index1)
      {
        for (int Index2 = 0; Index2 < this.fNBinsY; ++Index2)
        {
          if (this.fBins[Index1, Index2] != 0.0)
						Console.WriteLine(Index1 + "fsd" + Index2 + "dss" + this.GetBinCentreX(Index1) + "sfdfdf" + this.GetBinCentreY(Index2) + "fsfd"+ this.fBins[Index1, Index2].ToString("sss"));
        }
      }
    }

    
    public virtual void Draw()
    {
      this.Draw("");
    }

    
    public virtual void Draw(string Option)
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("Canvas Name", "Canvas Title");
      }
      if (Chart.Pad.View3D == null)
        Chart.Pad.View3D = (object) new TView();
      Chart.Pad.Add((IDrawable) this);
			if (Option.ToLower().IndexOf("waht") >= 0)
        return;
      if (Chart.Pad.For3D)
        new TText(this.fName, this.fXMin, this.fYMax).Draw();
      else
        Chart.Pad.Title.Text = this.fName;
      Chart.Pad.SetRange(this.fXMin, this.fXMax, this.fYMin, this.fYMax);
    }

    
    public Color[] CreatePalette(Color LowColor, Color HighColor, int NColors)
    {
      Color[] colorArray = new Color[NColors];
      double num1 = (double) ((int) HighColor.R - (int) LowColor.R) / (double) NColors;
      double num2 = (double) ((int) HighColor.G - (int) LowColor.G) / (double) NColors;
      double num3 = (double) ((int) HighColor.B - (int) LowColor.B) / (double) NColors;
      double num4 = (double) LowColor.R;
      double num5 = (double) LowColor.G;
      double num6 = (double) LowColor.B;
      colorArray[0] = LowColor;
      for (int index = 1; index < NColors; ++index)
      {
        num4 += num1;
        num5 += num2;
        num6 += num3;
        colorArray[index] = Color.FromArgb((int) num4, (int) num5, (int) num6);
      }
      return colorArray;
    }

    
    public void SetPalette(Color LowColor, Color HighColor, int NColors)
    {
      this.fNColors = NColors;
      this.fPalette = this.CreatePalette(LowColor, HighColor, NColors);
    }

    
    public void SetPalette(Color[] Colors, int NColors)
    {
      this.fNColors = NColors;
      this.fPalette = Colors;
    }

    
    public void SetPalette(EPalette Palette)
    {
      switch (Palette)
      {
        case EPalette.Gray:
          this.SetPalette(Color.White, Color.Black, (int) byte.MaxValue);
          break;
        case EPalette.Rainbow:
          Color[] Colors = new Color[160];
          int num = 0;
          foreach (Color color in this.CreatePalette(Color.Purple, Color.Blue, 32))
            Colors[num++] = color;
          foreach (Color color in this.CreatePalette(Color.Blue, Color.FromArgb(0, 128, (int) byte.MaxValue), 16))
            Colors[num++] = color;
          Color color1 = Color.FromArgb(0, 200, 0);
          foreach (Color color2 in this.CreatePalette(Color.FromArgb(0, 128, (int) byte.MaxValue), color1, 16))
            Colors[num++] = color2;
          foreach (Color color2 in this.CreatePalette(color1, Color.Yellow, 32))
            Colors[num++] = color2;
          foreach (Color color2 in this.CreatePalette(Color.Yellow, Color.Orange, 32))
            Colors[num++] = color2;
          foreach (Color color2 in this.CreatePalette(Color.Orange, Color.Red, 32))
            Colors[num++] = color2;
          this.SetPalette(Colors, 160);
          break;
      }
    }

    
    private void EWno7H6yQR()
    {
      this.brushes = new Brush[this.fNColors];
      for (int index = 0; index < this.fNColors; ++index)
        this.brushes[index] = (Brush) new SolidBrush(this.fPalette[index]);
    }

    
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      if (Pad.For3D)
      {
        int millisecond = DateTime.Now.Millisecond;
        int num1 = Pad.ClientX(XMin);
        int num2 = (Pad.ClientY(YMax) + Pad.Y1) / 2;
        int num3 = Math.Abs(Pad.ClientX(XMax) - Pad.ClientX(XMin));
        int num4 = Math.Abs(Pad.ClientY(YMax) - Pad.ClientY(YMin));
        int H = num3 < num4 ? num3 : num4;
        int Left = num1 + num3 / 2 - H / 2;
        int Top = num2;
        if (this.fShowMaxZ == 0.0)
          this.ShowUnnormalizedZ();
        Pad.AxisZ3D.Min = 0.0;
        Pad.AxisZ3D.Max = this.fShowMaxZ;
        TView.View(Pad).PaintAxes(Pad, Left, Top, H);
        if (!this.Multicolor3D)
        {
          switch (this.Smoothing)
          {
            case ESmoothing.Disabled:
              this.kG6oz8rvGU.umVNE9P5cO(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMax);
              this.kG6oz8rvGU.Paint(Pad);
              break;
            case ESmoothing.Linear:
              this.U4Z3nPEiRp.umVNE9P5cO(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMax);
              this.U4Z3nPEiRp.Paint(Pad);
              break;
          }
        }
        else
        {
          switch (this.Smoothing)
          {
            case ESmoothing.Disabled:
              this.l303o6TYVf.uDx3gBDtTM(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMin, this.fBinMax, this.fPalette);
              this.l303o6TYVf.Paint(Pad);
              break;
            case ESmoothing.Linear:
              this.MUK33qPZeB.uDx3gBDtTM(Pad, this.fBins, this.fNBinsX, this.fNBinsY, this.fXMin, this.fXMax, this.fYMin, this.fYMax, this.fBinMin, this.fBinMax, this.fPalette);
              this.MUK33qPZeB.Paint(Pad);
              break;
          }
        }
        int num5 = DateTime.Now.Millisecond - millisecond;
      }
      else
      {
        int millisecond1 = DateTime.Now.Millisecond;
        int millisecond2 = DateTime.Now.Millisecond;
        int x = Pad.ClientX(this.fXMin);
        int y = Pad.ClientY(this.fYMax);
        int W = Pad.ClientX(this.fXMax) - x;
        int H = Pad.ClientY(this.fYMin) - y;
        int length = this.fPalette.Length;
        int[] numArray = new int[length];
        for (int index = 0; index < length; ++index)
          numArray[index] = this.fPalette[index].ToArgb();
        TPaintingBitmap tpaintingBitmap = new TPaintingBitmap(W, H);
        tpaintingBitmap.Fill(Pad.ForeColor);
        double num1 = (double) W / (double) this.fNBinsX;
        double num2 = (double) H / (double) this.fNBinsY;
        int w = (int) (num1 + 1.0);
        int h = (int) (num2 + 1.0);
        double num3 = (double) (this.fNColors - 1) / (this.fBinMax - this.fBinMin);
        int index1 = 0;
        double num4 = 0.0;
        while (index1 < this.fNBinsX)
        {
          int index2 = 0;
          double num5 = 0.0;
          while (index2 < this.fNBinsY)
          {
            if (this.fBins[index1, index2] != 0.0)
            {
              int index3 = (int) (num3 * (this.fBins[index1, index2] - this.fBinMin));
              tpaintingBitmap.FillRectangle(numArray[index3], (int) num4, H - (int) num5 - h, w, h);
            }
            ++index2;
            num5 += num2;
          }
          ++index1;
          num4 += num1;
        }
        Bitmap bitmap = tpaintingBitmap.Get();
        Pad.Graphics.DrawImage((Image) bitmap, x, y);
        int millisecond3 = DateTime.Now.Millisecond;
        int num6 = millisecond2 - millisecond1;
        int num7 = millisecond3 - millisecond1;
      }
    }

    
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }

    private class FZPRsSBmTaNrPqwljR : TFunction
    {
      protected double[,] pwU3ia0tgu;
      protected double aqv3D4FyQP;
      protected double YGZ38gIuF2;
      protected double drs3Z0OsMo;
      protected double DQY3XkBEnm;

      
			public FZPRsSBmTaNrPqwljR() :base()
      {

      }

      
      public virtual void umVNE9P5cO(Pad obj0, double[,] obj1, int obj2, int obj3, double obj4, double obj5, double obj6, double obj7, double obj8)
      {
        this.pwU3ia0tgu = obj1;
        this.nx = obj2;
        this.ny = obj3;
        this.MinX = obj4;
        this.MaxX = obj5;
        this.MinY = obj6;
        this.MaxY = obj7;
        this.aqv3D4FyQP = obj8;
        this.YGZ38gIuF2 = (double) obj2 / (obj5 - obj4);
        this.drs3Z0OsMo = (double) obj3 / (obj7 - obj6);
        this.DQY3XkBEnm = TView.View(obj0).Lz.NormInf / this.aqv3D4FyQP;
      }

      
      public override double f(double obj0, double obj1)
      {
        if (obj0 < this.MinX || obj0 >= this.MaxX || (obj1 < this.MinY || obj1 >= this.MaxY))
          return 0.0;
        else
          return this.DQY3XkBEnm * this.pwU3ia0tgu[(int) (this.YGZ38gIuF2 * (obj0 - this.MinX)), (int) (this.drs3Z0OsMo * (obj1 - this.MinY))];
      }
    }

    private class jCAh8vlcna2K6CJfbh : Histogram2D.FZPRsSBmTaNrPqwljR
    {
      
		public jCAh8vlcna2K6CJfbh() : base()
      {
      }

      
      public override double f(double obj0, double obj1)
      {
        double num1 = this.YGZ38gIuF2 * (obj0 - this.MinX) - 0.5;
        double num2 = this.drs3Z0OsMo * (obj1 - this.MinY) - 0.5;
        int index1 = (int) num1;
        int index2 = (int) num2;
        int index3 = index1 + 1;
        int index4 = index2 + 1;
        if (index3 >= this.pwU3ia0tgu.GetLength(0))
          index3 = index1;
        if (index4 >= this.pwU3ia0tgu.GetLength(1))
          index4 = index2;
        double num3 = num1 - (double) index1;
        double num4 = num2 - (double) index2;
        if (num3 < 0.0)
          num3 = 0.0;
        if (num4 < 0.0)
          num4 = 0.0;
        double num5 = this.pwU3ia0tgu[index1, index2];
        double num6 = this.pwU3ia0tgu[index3, index2];
        double num7 = this.pwU3ia0tgu[index1, index4];
        double num8 = this.pwU3ia0tgu[index3, index4];
        return this.DQY3XkBEnm * (num5 + (num6 - num5) * num3 + (num7 - num5) * num4 + (num5 - num6 - num7 + num8) * num3 * num4);
      }
    }

    private class a8pjE1K8r7B62oxStB : Histogram2D.FZPRsSBmTaNrPqwljR
    {
      private TColor[] EbV3bis37P;
      private double jaO3EZAeXk;
      private double LSr3HnRJss;

      
		public a8pjE1K8r7B62oxStB() : base()
      {
      }

      
      public override TColor color0(double obj0, double obj1)
      {
        return this.EbV3bis37P[(int) (this.LSr3HnRJss * (this.f(obj0, obj1) - this.jaO3EZAeXk))];
      }

      
      public void uDx3gBDtTM(Pad obj0, double[,] obj1, int obj2, int obj3, double obj4, double obj5, double obj6, double obj7, double obj8, double obj9, Color[] obj10)
      {
        this.umVNE9P5cO(obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj9);
        this.EbV3bis37P = new TColor[obj10.Length];
        for (int index = 0; index < this.EbV3bis37P.Length; ++index)
          this.EbV3bis37P[index] = (TColor) obj10[index];
        this.LSr3HnRJss = (double) (this.EbV3bis37P.Length - 1) / (obj9 - obj8) / this.DQY3XkBEnm;
        this.jaO3EZAeXk = obj8 * this.DQY3XkBEnm;
      }
    }

    private class XD9QjcfMcOLK0nS6xp : Histogram2D.a8pjE1K8r7B62oxStB
    {

      
      public override double f(double obj0, double obj1)
      {
        double num1 = this.YGZ38gIuF2 * (obj0 - this.MinX) - 0.5;
        double num2 = this.drs3Z0OsMo * (obj1 - this.MinY) - 0.5;
        int index1 = (int) num1;
        int index2 = (int) num2;
        int index3 = index1 + 1;
        int index4 = index2 + 1;
        if (index3 >= this.pwU3ia0tgu.GetLength(0))
          index3 = index1;
        if (index4 >= this.pwU3ia0tgu.GetLength(1))
          index4 = index2;
        double num3 = num1 - (double) index1;
        double num4 = num2 - (double) index2;
        if (num3 < 0.0)
          num3 = 0.0;
        if (num4 < 0.0)
          num4 = 0.0;
        double num5 = this.pwU3ia0tgu[index1, index2];
        double num6 = this.pwU3ia0tgu[index3, index2];
        double num7 = this.pwU3ia0tgu[index1, index4];
        double num8 = this.pwU3ia0tgu[index3, index4];
        return this.DQY3XkBEnm * (num5 + (num6 - num5) * num3 + (num7 - num5) * num4 + (num5 - num6 - num7 + num8) * num3 * num4);
      }
    }
  }
}
