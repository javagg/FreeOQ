using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Charting
{
  [Serializable]
  public class Axis
  {
	private Pad pad; 
    private EAxisType jF56ZqlDUA;
    private EAxisPosition gck6XUIeCg;
    private EAxisTitlePosition ejS6gv5Ug7;
    private EVerticalGridStyle QeC6bMjpbe;
    private bool MbS6EH3Dtx;
    private bool fmn6HKQKNH;
    private Color ViX6vvvcDs;
    private bool lD76USPYGZ;
    private string title;
		private Font font; 
    private Color tAw6cjrLwr;
    private int MU36yJxSD6;
    private bool fri6W8mFh9;
    private Font Lju6sLD21e;
    private Color h4w6pXqlP6;
    private int QvE6d9RSdV;
    private string labelFormat;
    private EAxisLabelAlignment H786I1r5BA;
    private bool TRd6qNDWBJ;
    private Color dpi6tMHwuH;
    private float tVA6k6gEgN;
    private DashStyle j8m6uWqvkw;
    private bool nYl6mPBuBs;
    private Color gPe60TWLJ7;
    private float YOf6a5UipH;
    private DashStyle Vel6TAhiZ3;
    private bool zU26hHtq00;
    private Color G1A6VJnjGW;
    private float ovt65ky7fn;
    private int kfw6LStExd;
    private bool raP6AFh3ta;
    private Color oua6QvZpsu;
    private float zte6w2XVbU;
    private int BXj6SnOZlQ;
    private double jiR6jl13Bb;
    private double WvY61ob0Xo;
    private double Eo969HTsnQ;
    private double ied6e07F0D;
    private double CJf67aSqFG;
    private double gDw6zAT8dQ;
    private bool abOYnyZNZl;
    private int uWuYomI9kU;
    private int fsWY3PuyRF;
    private bool J2nYCsqgZK;
    private int Se1Y6TOkWX;
    private int UElYYuNU1W;
    private int zQVYBFCR4C;
    private int ndOYlqa0xS;
    private int ljAYKLwBlc;

    public double X1
    {
       get
      {
        return this.jiR6jl13Bb;
      }
       set
      {
        this.jiR6jl13Bb = value;
      }
    }

    public double Y1
    {
       get
      {
        return this.Eo969HTsnQ;
      }
       set
      {
        this.Eo969HTsnQ = value;
      }
    }

    public double X2
    {
       get
      {
        return this.WvY61ob0Xo;
      }
       set
      {
        this.WvY61ob0Xo = value;
      }
    }

    public double Y2
    {
       get
      {
        return this.ied6e07F0D;
      }
       set
      {
        this.ied6e07F0D = value;
      }
    }

    public Color Color
    {
       get
      {
        return this.ViX6vvvcDs;
      }
       set
      {
        this.ViX6vvvcDs = value;
      }
    }

    public EAxisType Type
    {
       get
      {
        return this.jF56ZqlDUA;
      }
       set
      {
        this.jF56ZqlDUA = value;
      }
    }

    public EAxisPosition Position
    {
       get
      {
        return this.gck6XUIeCg;
      }
       set
      {
        this.gck6XUIeCg = value;
      }
    }

    public EVerticalGridStyle VerticalGridStyle
    {
       get
      {
        return this.QeC6bMjpbe;
      }
       set
      {
        this.QeC6bMjpbe = value;
      }
    }

    public bool MajorTicksEnabled
    {
       get
      {
        return this.zU26hHtq00;
      }
       set
      {
        this.zU26hHtq00 = value;
      }
    }

    public Color MajorTicksColor
    {
       get
      {
        return this.G1A6VJnjGW;
      }
       set
      {
        this.G1A6VJnjGW = value;
      }
    }

    public float MajorTicksWidth
    {
       get
      {
        return this.ovt65ky7fn;
      }
       set
      {
        this.ovt65ky7fn = value;
      }
    }

    public int MajorTicksLength
    {
       get
      {
        return this.kfw6LStExd;
      }
       set
      {
        this.kfw6LStExd = value;
      }
    }

    public bool MinorTicksEnabled
    {
       get
      {
        return this.raP6AFh3ta;
      }
       set
      {
        this.raP6AFh3ta = value;
      }
    }

    public Color MinorTicksColor
    {
       get
      {
        return this.oua6QvZpsu;
      }
       set
      {
        this.oua6QvZpsu = value;
      }
    }

    public float MinorTicksWidth
    {
       get
      {
        return this.zte6w2XVbU;
      }
       set
      {
        this.zte6w2XVbU = value;
      }
    }

    public int MinorTicksLength
    {
       get
      {
        return this.BXj6SnOZlQ;
      }
       set
      {
        this.BXj6SnOZlQ = value;
      }
    }

    public EAxisTitlePosition TitlePosition
    {
       get
      {
        return this.ejS6gv5Ug7;
      }
       set
      {
        this.ejS6gv5Ug7 = value;
      }
    }

    public Font TitleFont
    {
       get
      {
        return this.font;
      }
       set
      {
        this.font = value;
      }
    }

    public Color TitleColor
    {
       get
      {
        return this.tAw6cjrLwr;
      }
       set
      {
        this.tAw6cjrLwr = value;
      }
    }

    public int TitleOffset
    {
       get
      {
        return this.MU36yJxSD6;
      }
       set
      {
        this.MU36yJxSD6 = value;
      }
    }

    public double Min
    {
       get
      {
        return this.CJf67aSqFG;
      }
       set
      {
        this.CJf67aSqFG = value;
      }
    }

    public double Max
    {
       get
      {
        return this.gDw6zAT8dQ;
      }
       set
      {
        this.gDw6zAT8dQ = value;
      }
    }

    public bool Enabled
    {
       get
      {
        return this.MbS6EH3Dtx;
      }
       set
      {
        this.MbS6EH3Dtx = value;
      }
    }

    public bool Zoomed
    {
       get
      {
        return this.fmn6HKQKNH;
      }
       set
      {
        this.fmn6HKQKNH = value;
      }
    }

    public bool GridEnabled
    {
       get
      {
        return this.TRd6qNDWBJ;
      }
       set
      {
        this.TRd6qNDWBJ = value;
      }
    }

    public Color GridColor
    {
       get
      {
        return this.dpi6tMHwuH;
      }
       set
      {
        this.dpi6tMHwuH = value;
      }
    }

    public float GridWidth
    {
       get
      {
        return this.tVA6k6gEgN;
      }
       set
      {
        this.tVA6k6gEgN = value;
      }
    }

    public DashStyle GridDashStyle
    {
       get
      {
        return this.j8m6uWqvkw;
      }
       set
      {
        this.j8m6uWqvkw = value;
      }
    }

    public bool MinorGridEnabled
    {
       get
      {
        return this.nYl6mPBuBs;
      }
       set
      {
        this.nYl6mPBuBs = value;
      }
    }

    public Color MinorGridColor
    {
       get
      {
        return this.gPe60TWLJ7;
      }
       set
      {
        this.gPe60TWLJ7 = value;
      }
    }

    public float MinorGridWidth
    {
       get
      {
        return this.YOf6a5UipH;
      }
       set
      {
        this.YOf6a5UipH = value;
      }
    }

    public DashStyle MinorGridDashStyle
    {
       get
      {
        return this.Vel6TAhiZ3;
      }
       set
      {
        this.Vel6TAhiZ3 = value;
      }
    }

    public bool TitleEnabled
    {
       get
      {
        return this.lD76USPYGZ;
      }
       set
      {
        this.lD76USPYGZ = value;
      }
    }

    public bool LabelEnabled
    {
       get
      {
        return this.fri6W8mFh9;
      }
       set
      {
        this.fri6W8mFh9 = value;
      }
    }

    public Font LabelFont
    {
       get
      {
        return this.Lju6sLD21e;
      }
       set
      {
        this.Lju6sLD21e = value;
      }
    }

    public Color LabelColor
    {
       get
      {
        return this.h4w6pXqlP6;
      }
       set
      {
        this.h4w6pXqlP6 = value;
      }
    }

    public int LabelOffset
    {
       get
      {
        return this.QvE6d9RSdV;
      }
       set
      {
        this.QvE6d9RSdV = value;
      }
    }

    public string LabelFormat
    {
       get
      {
				return this.labelFormat; 
      }
       set
      {
        this.labelFormat = value;
      }
    }

    public EAxisLabelAlignment LabelAlignment
    {
       get
      {
        return this.H786I1r5BA;
      }
       set
      {
        this.H786I1r5BA = value;
      }
    }

    public int Width
    {
       get
      {
        if (!this.MbS6EH3Dtx)
          return 0;
        if (this.ndOYlqa0xS != -1)
          return this.ndOYlqa0xS;
        int num1 = 0;
        int num2 = 0;
        this.zQVYBFCR4C = 0;
        if (this.lD76USPYGZ)
					num1 = (int) ((double) this.MU36yJxSD6 + (double) this.pad.Graphics.MeasureString(this.gDw6zAT8dQ.ToString("%4"), this.font).Height);
        if (this.fri6W8mFh9)
					num2 = this.labelFormat != null ? (int) ((double) this.QvE6d9RSdV + (double) this.pad.Graphics.MeasureString(this.gDw6zAT8dQ.ToString(this.labelFormat), this.Lju6sLD21e).Width) : (int) ((double) this.QvE6d9RSdV + (double) this.pad.Graphics.MeasureString(this.gDw6zAT8dQ.ToString("%4"), this.Lju6sLD21e).Width);
        this.zQVYBFCR4C = num2 + num1 + 2;
        return num2 + num1 + 2;
      }
       set
      {
        this.ndOYlqa0xS = value;
      }
    }

    public int LastValidAxisWidth
    {
       get
      {
        return this.zQVYBFCR4C;
      }
       set
      {
        this.zQVYBFCR4C = value;
      }
    }

    public int Height
    {
       get
      {
        if (!this.MbS6EH3Dtx)
          return 0;
        if (this.ljAYKLwBlc != -1)
          return this.ljAYKLwBlc;
        int num1 = 0;
        int num2 = 0;
        if (this.lD76USPYGZ)
					num1 = (int) ((double) this.MU36yJxSD6 + (double) this.pad.Graphics.MeasureString("ss", this.font).Height);
        if (this.fri6W8mFh9)
					num2 = (int) ((double) this.QvE6d9RSdV + (double) this.pad.Graphics.MeasureString("dd", this.Lju6sLD21e).Height);
        return num2 + num1;
      }
       set
      {
        this.ljAYKLwBlc = value;
      }
    }

    public string Title
    {
       get
      {
				return this.title; 
      }
       set
      {
        this.title = value;
      }
    }

    public Axis(Pad Pad):base()
    {

      this.pad = Pad;
      this.gck6XUIeCg = EAxisPosition.None;
      this.jiR6jl13Bb = 0.0;
      this.WvY61ob0Xo = 0.0;
      this.Eo969HTsnQ = 0.0;
      this.ied6e07F0D = 0.0;
      this.zNh621NQso();
    }

 
    public Axis(Pad Pad, EAxisPosition Position):base()
    {

      this.pad = Pad;
      this.gck6XUIeCg = Position;
      this.jiR6jl13Bb = 0.0;
      this.WvY61ob0Xo = 0.0;
      this.Eo969HTsnQ = 0.0;
      this.ied6e07F0D = 0.0;
      this.zNh621NQso();
    }


    public Axis(Pad Pad, double X1, double Y1, double X2, double Y2):base()
    {

      this.pad = Pad;
      this.gck6XUIeCg = EAxisPosition.None;
      this.jiR6jl13Bb = X1;
      this.WvY61ob0Xo = X2;
      this.Eo969HTsnQ = Y1;
      this.ied6e07F0D = Y2;
      this.zNh621NQso();
    }

    
    private void zNh621NQso()
    {
      this.MbS6EH3Dtx = true;
      this.fmn6HKQKNH = false;
      this.ViX6vvvcDs = Color.Black;
      this.title = "";
      this.lD76USPYGZ = true;
      this.ejS6gv5Ug7 = EAxisTitlePosition.Centre;
			this.font = new Font("Arial", 8);
      this.tAw6cjrLwr = Color.Black;
      this.MU36yJxSD6 = 2;
      this.fri6W8mFh9 = true;
			this.Lju6sLD21e = new Font("Arial", 8);
      this.h4w6pXqlP6 = Color.Black;
      this.labelFormat = (string) null;
      this.QvE6d9RSdV = 2;
      this.H786I1r5BA = EAxisLabelAlignment.Centre;
      this.TRd6qNDWBJ = true;
      this.dpi6tMHwuH = Color.Gray;
      this.j8m6uWqvkw = DashStyle.Solid;
      this.tVA6k6gEgN = 0.5f;
      this.nYl6mPBuBs = false;
      this.gPe60TWLJ7 = Color.Gray;
      this.Vel6TAhiZ3 = DashStyle.Solid;
      this.YOf6a5UipH = 0.5f;
      this.zU26hHtq00 = true;
      this.G1A6VJnjGW = Color.Black;
      this.ovt65ky7fn = 0.5f;
      this.kfw6LStExd = 4;
      this.raP6AFh3ta = true;
      this.oua6QvZpsu = Color.Black;
      this.zte6w2XVbU = 0.5f;
      this.BXj6SnOZlQ = 1;
      this.jF56ZqlDUA = EAxisType.Numeric;
      this.QeC6bMjpbe = EVerticalGridStyle.ByDateTime;
      this.abOYnyZNZl = false;
      this.uWuYomI9kU = 0;
      this.fsWY3PuyRF = 0;
      this.J2nYCsqgZK = false;
      this.Se1Y6TOkWX = 0;
      this.UElYYuNU1W = 0;
      this.ndOYlqa0xS = -1;
      this.ljAYKLwBlc = -1;
    }

    
    public void SetLocation(double X1, double Y1, double X2, double Y2)
    {
      this.jiR6jl13Bb = X1;
      this.WvY61ob0Xo = X2;
      this.Eo969HTsnQ = Y1;
      this.ied6e07F0D = Y2;
    }

    
    public void SetRange(double Min, double Max)
    {
      this.CJf67aSqFG = Min;
      this.gDw6zAT8dQ = Max;
    }

    
    public void Zoom(double Min, double Max)
    {
      this.CJf67aSqFG = Min;
      this.gDw6zAT8dQ = Max;
      this.fmn6HKQKNH = true;
      this.pad.EmitZoom(true);
      if (this.pad.Chart.GroupZoomEnabled)
        return;
      this.pad.Update();
    }

    
    public void Zoom(DateTime Min, DateTime Max)
    {
      this.Zoom((double) Min.Ticks, (double) Max.Ticks);
    }

    
    public void Zoom(string Min, string Max)
    {
      this.Zoom(DateTime.Parse(Min), DateTime.Parse(Max));
    }

    
    public void UnZoom()
    {
      switch (this.gck6XUIeCg)
      {
        case EAxisPosition.Left:
          this.SetRange(this.pad.YMin, this.pad.YMax);
          break;
        case EAxisPosition.Bottom:
          this.SetRange(this.pad.XMin, this.pad.XMax);
          break;
      }
      this.fmn6HKQKNH = false;
      this.pad.EmitZoom(false);
      if (this.pad.Chart.GroupZoomEnabled)
        return;
      this.pad.Update();
    }

    
    public static long GetNextMajor(long PrevMajor, EGridSize GridSize)
    {
      long num;
      switch (GridSize)
      {
        case EGridSize.year5:
          num = new DateTime(PrevMajor).AddYears(5).Ticks;
          break;
        case EGridSize.year10:
          num = new DateTime(PrevMajor).AddYears(10).Ticks;
          break;
        case EGridSize.year20:
          num = new DateTime(PrevMajor).AddYears(20).Ticks;
          break;
        case EGridSize.year2:
          num = new DateTime(PrevMajor).AddYears(2).Ticks;
          break;
        case EGridSize.year3:
          num = new DateTime(PrevMajor).AddYears(3).Ticks;
          break;
        case EGridSize.year4:
          num = new DateTime(PrevMajor).AddYears(4).Ticks;
          break;
        case EGridSize.month4:
          num = new DateTime(PrevMajor).AddMonths(4).Ticks;
          break;
        case EGridSize.month6:
          num = new DateTime(PrevMajor).AddMonths(6).Ticks;
          break;
        case EGridSize.year1:
          num = new DateTime(PrevMajor).AddYears(1).Ticks;
          break;
        case EGridSize.month1:
          num = new DateTime(PrevMajor).AddMonths(1).Ticks;
          break;
        case EGridSize.month2:
          num = new DateTime(PrevMajor).AddMonths(2).Ticks;
          break;
        case EGridSize.month3:
          num = new DateTime(PrevMajor).AddMonths(3).Ticks;
          break;
        default:
          num = (long) (PrevMajor + GridSize);
          break;
      }
      return num;
    }

    
    public static EGridSize CalculateSize(double ticks)
    {
      int num1 = 10;
      int num2 = 3;
      double num3 = Math.Floor(ticks / 600000000.0);
      if (num3 >= (double) num2 && num3 <= (double) num1)
        return EGridSize.min1;
      double num4 = num3 / 2.0;
      if (num4 >= (double) num2 && num4 <= (double) num1)
        return EGridSize.min2;
      double num5 = num4 / 2.5;
      if (num5 >= (double) num2 && num5 <= (double) num1)
        return EGridSize.min5;
      double num6 = num5 / 2.0;
      if (num6 >= (double) num2 && num6 <= (double) num1)
        return EGridSize.min10;
      double num7 = num6 / 1.5;
      if (num7 >= (double) num2 && num7 <= (double) num1)
        return EGridSize.min15;
      double num8 = num7 / (4.0 / 3.0);
      if (num8 >= (double) num2 && num8 <= (double) num1)
        return EGridSize.min20;
      double num9 = num8 / 1.5;
      if (num9 >= (double) num2 && num9 <= (double) num1)
        return EGridSize.min30;
      double num10 = num9 / 2.0;
      if (num10 >= (double) num2 && num10 <= (double) num1)
        return EGridSize.hour1;
      double num11 = num10 / 2.0;
      if (num11 >= (double) num2 && num11 <= (double) num1)
        return EGridSize.hour2;
      double num12 = num11 / 1.5;
      if (num12 >= (double) num2 && num12 <= (double) num1)
        return EGridSize.hour3;
      double num13 = num12 / (4.0 / 3.0);
      if (num13 >= (double) num2 && num13 <= (double) num1)
        return EGridSize.hour4;
      double num14 = num13 / 1.5;
      if (num14 >= (double) num2 && num14 <= (double) num1)
        return EGridSize.hour6;
      double num15 = num14 / 2.0;
      if (num15 >= (double) num2 && num15 <= (double) num1)
        return EGridSize.hour12;
      double num16 = num15 / 2.0;
      if (num16 >= (double) num2 && num16 <= (double) num1)
        return EGridSize.day1;
      double num17 = num16 / 2.0;
      if (num17 >= (double) num2 && num17 <= (double) num1)
        return EGridSize.day2;
      double num18 = num17 / 1.5;
      if (num18 >= (double) num2 && num18 <= (double) num1)
        return EGridSize.day3;
      double num19 = num18 / (5.0 / 3.0);
      if (num19 >= (double) num2 && num19 <= (double) num1)
        return EGridSize.day5;
      double num20 = num19 / 1.4;
      if (num20 >= (double) num2 && num20 <= (double) num1)
        return EGridSize.week1;
      double num21 = num20 / 2.0;
      if (num21 >= (double) num2 && num21 <= (double) num1)
        return EGridSize.week2;
      double num22 = num21 / (15.0 / 7.0);
      if (num22 >= (double) num2 && num22 <= (double) num1)
        return EGridSize.month1;
      double num23 = num22 / 2.0;
      if (num23 >= (double) num2 && num23 <= (double) num1)
        return EGridSize.month2;
      double num24 = num23 / 1.5;
      if (num24 >= (double) num2 && num24 <= (double) num1)
        return EGridSize.month3;
      double num25 = num24 / (4.0 / 3.0);
      if (num25 >= (double) num2 && num25 <= (double) num1)
        return EGridSize.month4;
      double num26 = num25 / 1.5;
      if (num26 >= (double) num2 && num26 <= (double) num1)
        return EGridSize.month6;
      double num27 = num26 / 2.0;
      if (num27 >= (double) num2 && num27 <= (double) num1)
        return EGridSize.year1;
      double num28 = num27 / 2.0;
      if (num28 >= (double) num2 && num28 <= (double) num1)
        return EGridSize.year2;
      double num29 = num28 / 1.5;
      if (num29 >= (double) num2 && num29 <= (double) num1)
        return EGridSize.year3;
      double num30 = num29 / (4.0 / 3.0);
      if (num30 >= (double) num2 && num30 <= (double) num1)
        return EGridSize.year4;
      double num31 = num30 / 0.8;
      if (num31 >= (double) num2 && num31 <= (double) num1)
        return EGridSize.year5;
      double num32 = num31 / 2.0;
      if (num32 >= (double) num2 && num32 <= (double) num1)
        return EGridSize.year10;
      double num33 = num32 / 2.0;
      return num33 >= (double) num2 && num33 <= (double) num1 ? EGridSize.year20 : EGridSize.year20;
    }

    
    public void PaintWithDates()
    {
      if (!this.MbS6EH3Dtx)
        return;
      this.pad.DrawLine(new Pen(this.ViX6vvvcDs), this.jiR6jl13Bb, this.Eo969HTsnQ, this.WvY61ob0Xo, this.ied6e07F0D, false);
      SolidBrush solidBrush1 = new SolidBrush(this.tAw6cjrLwr);
      SolidBrush solidBrush2 = new SolidBrush(this.h4w6pXqlP6);
      Pen Pen1 = new Pen(this.tAw6cjrLwr);
      Pen Pen2 = new Pen(this.dpi6tMHwuH);
      Pen Pen3 = new Pen(this.gPe60TWLJ7);
      Pen Pen4 = new Pen(this.oua6QvZpsu);
      Pen Pen5 = new Pen(this.G1A6VJnjGW);
      Pen2.Width = this.tVA6k6gEgN;
      Pen2.DashStyle = this.j8m6uWqvkw;
      Pen3.Width = this.YOf6a5UipH;
      Pen3.DashStyle = this.Vel6TAhiZ3;
      DateTime FirstDateTime = new DateTime();
      double Min = this.CJf67aSqFG;
      double Max = this.gDw6zAT8dQ;
      FirstDateTime = new DateTime(Math.Max(0L, (long) Min));
      DateTime dateTime1 = new DateTime((long) Max);
      EGridSize GridSize = EGridSize.min1;
      this.pad.GetFirstGridDivision(ref GridSize, ref Min, ref Max, ref FirstDateTime);
      double num1 = 5.0;
      double num2;
      TimeSpan timeSpan;
      DateTime dateTime2;
      switch (GridSize)
      {
        case EGridSize.year10:
          DateTime dateTime3 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime3 = dateTime3.AddYears(1 + (9 - FirstDateTime.Year % 10));
          num2 = (double) dateTime3.Ticks;
          break;
        case EGridSize.year20:
          DateTime dateTime4 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime4 = dateTime4.AddYears(1 + (19 - FirstDateTime.Year % 20));
          num2 = (double) dateTime4.Ticks;
          break;
        case EGridSize.year4:
          DateTime dateTime5 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime5 = dateTime5.AddYears(1 + (3 - FirstDateTime.Year % 4));
          num2 = (double) dateTime5.Ticks;
          break;
        case EGridSize.year5:
          DateTime dateTime6 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime6 = dateTime6.AddYears(1 + (4 - FirstDateTime.Year % 5));
          num2 = (double) dateTime6.Ticks;
          break;
        case EGridSize.year2:
          DateTime dateTime7 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime7 = dateTime7.AddYears(1 + (1 - FirstDateTime.Year % 2));
          num2 = (double) dateTime7.Ticks;
          break;
        case EGridSize.year3:
          DateTime dateTime8 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime8 = dateTime8.AddYears(1 + (2 - FirstDateTime.Year % 3));
          num2 = (double) dateTime8.Ticks;
          break;
        case EGridSize.month6:
          DateTime dateTime9 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, 1);
          dateTime9 = dateTime9.AddMonths(1 + (12 - FirstDateTime.Month) % 6);
          num2 = (double) dateTime9.Ticks;
          break;
        case EGridSize.year1:
          dateTime2 = new DateTime(FirstDateTime.Year, 1, 1);
          dateTime2 = dateTime2.AddYears(1);
          num2 = (double) dateTime2.Ticks;
          break;
        case EGridSize.month3:
          DateTime dateTime10 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, 1);
          dateTime10 = dateTime10.AddMonths(1 + (12 - FirstDateTime.Month) % 3);
          num2 = (double) dateTime10.Ticks;
          break;
        case EGridSize.month4:
          DateTime dateTime11 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, 1);
          dateTime11 = dateTime11.AddMonths(1 + (12 - FirstDateTime.Month) % 4);
          num2 = (double) dateTime11.Ticks;
          break;
        case EGridSize.month1:
          dateTime2 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, 1);
          dateTime2 = dateTime2.AddMonths(1);
          num2 = (double) dateTime2.Ticks;
          break;
        case EGridSize.month2:
          DateTime dateTime12 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, 1);
          dateTime12 = dateTime12.AddMonths(1 + FirstDateTime.Month % 2);
          num2 = (double) dateTime12.Ticks;
          break;
        case EGridSize.week1:
          DateTime dateTime13 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day);
          dateTime13 = dateTime13.AddDays(8.0 - (double) FirstDateTime.DayOfWeek);
          num2 = (double) dateTime13.Ticks;
          break;
        case EGridSize.week2:
          DateTime dateTime14 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day);
          // ISSUE: explicit reference operation
          // ISSUE: variable of a reference type
//          DateTime& local1 = @dateTime14;
          double num3 = 8.0 - (double) FirstDateTime.DayOfWeek;
          int num4 = 7;
          int num5 = 1;
          timeSpan = new TimeSpan(FirstDateTime.AddDays(8.0 - (double) FirstDateTime.DayOfWeek).Ticks);
          int num6 = (int) Math.Floor(timeSpan.TotalDays) / 7 % 2;
          int num7 = num5 - num6;
          double num8 = (double) (num4 * num7);
          double num9 = num3 + num8;
          // ISSUE: explicit reference operation
//          num2 = (double) (^local1).AddDays(num9).Ticks;
		num2 = (double) dateTime14.AddDays(num9).Ticks;

          break;
        case EGridSize.day3:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day).AddDays((double) (1 + (2 - (int) new TimeSpan(FirstDateTime.Ticks).TotalDays % 3))).Ticks;
          break;
        case EGridSize.day5:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day).AddDays((double) (1 + (4 - (int) new TimeSpan(FirstDateTime.Ticks).TotalDays % 5))).Ticks;
          break;
        case EGridSize.day1:
          dateTime2 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day);
          dateTime2 = dateTime2.AddDays(1.0);
          num2 = (double) dateTime2.Ticks;
          break;
        case EGridSize.day2:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day).AddDays((double) (1 + (int) new TimeSpan(FirstDateTime.Ticks).TotalDays % 2)).Ticks;
          break;
        case EGridSize.hour6:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, 0, 0).AddHours((double) (1 + (5 - (int) new TimeSpan(FirstDateTime.Ticks).TotalHours % 6))).Ticks;
          break;
        case EGridSize.hour12:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, 0, 0).AddHours((double) (1 + (11 - (int) new TimeSpan(FirstDateTime.Ticks).TotalHours % 12))).Ticks;
          break;
        case EGridSize.hour3:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, 0, 0).AddHours((double) (1 + (2 - (int) new TimeSpan(FirstDateTime.Ticks).TotalHours % 3))).Ticks;
          break;
        case EGridSize.hour4:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, 0, 0).AddHours((double) (1 + (3 - (int) new TimeSpan(FirstDateTime.Ticks).TotalHours % 4))).Ticks;
          break;
        case EGridSize.hour1:
          DateTime dateTime15 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, 0, 0);
          dateTime15 = dateTime15.AddHours(1.0);
          num2 = (double) dateTime15.Ticks;
          break;
        case EGridSize.hour2:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, 0, 0).AddHours((double) (1 + (1 - (int) new TimeSpan(FirstDateTime.Ticks).TotalHours % 2))).Ticks;
          break;
        case EGridSize.min20:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0).AddMinutes((double) (1 + (19 - (int) new TimeSpan(FirstDateTime.Ticks).TotalMinutes % 20))).Ticks;
          break;
        case EGridSize.min30:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0).AddMinutes((double) (1 + (29 - (int) new TimeSpan(FirstDateTime.Ticks).TotalMinutes % 30))).Ticks;
          break;
        case EGridSize.min10:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0).AddMinutes((double) (1 + (9 - (int) new TimeSpan(FirstDateTime.Ticks).TotalMinutes % 10))).Ticks;
          break;
        case EGridSize.min15:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0).AddMinutes((double) (1 + (14 - (int) new TimeSpan(FirstDateTime.Ticks).TotalMinutes % 15))).Ticks;
          break;
        case EGridSize.min1:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0).AddMinutes(1.0).Ticks;
          break;
        case EGridSize.min2:
          DateTime dateTime16 = new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0);
          // ISSUE: explicit reference operation
          // ISSUE: variable of a reference type
//          DateTime& local2 = @dateTime16;
          int num10 = 1;
          int num11 = 1;
          timeSpan = new TimeSpan(FirstDateTime.Ticks);
          int num12 = (int) timeSpan.TotalMinutes % 2;
          int num13 = num11 - num12;
          double num14 = (double) (num10 + num13);
          // ISSUE: explicit reference operation
//          num2 = (double) (^local2).AddMinutes(num14).Ticks;
		num2 = (double) dateTime16.AddMinutes(num14).Ticks;
          
		break;
        case EGridSize.min5:
          num2 = (double) new DateTime(FirstDateTime.Year, FirstDateTime.Month, FirstDateTime.Day, FirstDateTime.Hour, FirstDateTime.Minute, 0).AddMinutes((double) (1 + (4 - (int) new TimeSpan(FirstDateTime.Ticks).TotalMinutes % 5))).Ticks;
          break;
        default:
          num2 = (double) (FirstDateTime.Ticks + GridSize);
          break;
      }
      int num15 = 0;
      int num16 = 0;
      double num17 = 0.0;
      double num18 = 0.0;
      double num19 = 0.0;
      string str = "";
      int MajorCount = 0;
      double num20 = Max;
      FirstDateTime = new DateTime((long) num2);
      DateTime dateTime17 = new DateTime((long) num20);
      while (num17 < num20)
      {
        num17 = this.pad.GetNextGridDivision(num2, num18, MajorCount, GridSize);
        if (num17 < num20)
        {
          if (this.jF56ZqlDUA == EAxisType.DateTime)
          {
            if (this.labelFormat == null)
            {
              dateTime2 = new DateTime((long) num17);
							str = dateTime2.ToString("dss");
            }
            else
            {
              long num21 = (long) num17 % 864000000000L;
              timeSpan = this.pad.SessionStart;
              long ticks1 = timeSpan.Ticks;
              string format;
              if (num21 != ticks1)
              {
                long num22 = (long) num17 % 864000000000L;
                timeSpan = this.pad.SessionEnd;
                long ticks2 = timeSpan.Ticks;
                if (num22 != ticks2)
                {
                  if (num18 == 0.0)
                  {
										format = "fs";
                    goto label_47;
                  }
                  else
                  {
                    DateTime dateTime18 = new DateTime((long) num18);
                    DateTime dateTime19 = new DateTime((long) num17);
										format = "invalid format";
//											dateTime18.Year == dateTime19.Year ? (dateTime18.Month == dateTime19.Month ? (dateTime18.Day == dateTime19.Day ? (dateTime18.Minute != dateTime19.Minute || dateTime18.Hour != dateTime19.Hour ? "ddd" : "kkk");
                    goto label_47;
                  }
                }
              }
							format = num18 != 0.0 ? (new DateTime((long) num18).Year == new DateTime((long) num17).Year ? "leap" :"normal") : "normal";
label_47:
              dateTime2 = new DateTime((long) num17);
              str = dateTime2.ToString(format);
              solidBrush2 = new SolidBrush(Color.Black);
            }
          }
          if (this.gck6XUIeCg == EAxisPosition.Bottom)
          {
            if (this.TRd6qNDWBJ)
              this.pad.DrawVerticalGrid(Pen2, num17);
            if (this.zU26hHtq00)
              this.pad.DrawVerticalTick(Pen1, num17, this.ied6e07F0D, -5);
            if (this.fri6W8mFh9)
            {
              SizeF sizeF = this.pad.Graphics.MeasureString(str, this.Lju6sLD21e);
              int num21 = (int) sizeF.Width;
              int num22 = (int) sizeF.Height;
              if (this.H786I1r5BA == EAxisLabelAlignment.Right)
                this.pad.Graphics.DrawString(str, this.Lju6sLD21e, (Brush) solidBrush2, (float) this.pad.ClientX(num17), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV));
              if (this.H786I1r5BA == EAxisLabelAlignment.Left)
                this.pad.Graphics.DrawString(str, this.Lju6sLD21e, (Brush) solidBrush2, (float) (this.pad.ClientX(num17) - num21), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV));
              if (this.H786I1r5BA == EAxisLabelAlignment.Centre)
              {
                int num23 = this.pad.ClientX(num17) - num21 / 2;
                int num24 = (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV);
                if (MajorCount == 0 || num23 - num15 >= 1)
                {
                  this.pad.Graphics.DrawString(str, this.Lju6sLD21e, (Brush) solidBrush2, (float) num23, (float) num24);
                  num15 = num23 + num21;
                }
              }
            }
          }
          if (this.gck6XUIeCg == EAxisPosition.Left || this.gck6XUIeCg == EAxisPosition.Right)
          {
            if (this.TRd6qNDWBJ)
              this.pad.DrawHorizontalGrid(Pen2, num17);
            if (this.zU26hHtq00)
              this.pad.DrawHorizontalTick(Pen5, this.jiR6jl13Bb, num17, 5);
            if (this.fri6W8mFh9)
            {
              SizeF sizeF = this.pad.Graphics.MeasureString(str, this.Lju6sLD21e);
              int num21 = (int) ((double) sizeF.Width + (double) this.QvE6d9RSdV);
              int num22 = (int) sizeF.Height;
              if (this.H786I1r5BA == EAxisLabelAlignment.Centre)
              {
                int num23 = (int) (this.jiR6jl13Bb - (double) num21);
                int num24 = this.pad.ClientY(num17) - num22 / 2;
                if (MajorCount == 0 || num16 - (num24 + num22) >= 1)
                {
                  this.pad.Graphics.DrawString(str, this.Lju6sLD21e, (Brush) solidBrush2, (float) num23, (float) num24);
                  num16 = num24;
                }
              }
            }
          }
        }
        if (MajorCount != 0)
        {
          if (MajorCount == 1)
            num19 = (num17 - num18 - this.pad.Transformation.CalculateNotInSessionTicks(num18, num17)) / num1;
          for (int index = 1; (double) index <= num1; ++index)
          {
            double num21 = num18 + this.pad.Transformation.CalculateRealQuantityOfTicks_Right(num18, num18 + (double) index * num19);
            if (num21 < Max)
            {
              if (this.gck6XUIeCg == EAxisPosition.Bottom)
              {
                if (this.nYl6mPBuBs)
                  this.pad.DrawVerticalGrid(Pen3, num21);
                if (this.raP6AFh3ta)
                  this.pad.DrawVerticalTick(Pen4, num21, this.ied6e07F0D, -2);
              }
              if (this.gck6XUIeCg == EAxisPosition.Left)
              {
                if (this.nYl6mPBuBs)
                  this.pad.DrawHorizontalGrid(Pen3, num21);
                if (this.raP6AFh3ta)
                  this.pad.DrawHorizontalTick(Pen5, this.jiR6jl13Bb, num21, 2);
                if (this.gck6XUIeCg == EAxisPosition.Right)
                {
                  if (this.nYl6mPBuBs)
                    this.pad.DrawHorizontalGrid(Pen3, num21);
                  if (this.raP6AFh3ta)
                    this.pad.DrawHorizontalTick(Pen4, this.WvY61ob0Xo - 2.0, num21, 2);
                }
              }
            }
          }
        }
        else
          num2 = num17;
        num18 = num17;
        ++MajorCount;
      }
      for (int index = 0; (double) index <= num1; ++index)
      {
        double num21 = num2 + this.pad.Transformation.CalculateRealQuantityOfTicks_Left(num2, num2 - (double) index * num19);
        if (num21 > this.CJf67aSqFG)
        {
          if (this.gck6XUIeCg == EAxisPosition.Bottom)
          {
            if (this.nYl6mPBuBs)
              this.pad.DrawVerticalGrid(Pen3, num21);
            if (this.raP6AFh3ta)
              this.pad.DrawVerticalTick(Pen4, num21, this.ied6e07F0D, -2);
          }
          if (this.gck6XUIeCg == EAxisPosition.Left)
          {
            if (this.nYl6mPBuBs)
              this.pad.DrawHorizontalGrid(Pen3, num21);
            if (this.raP6AFh3ta)
              this.pad.DrawHorizontalTick(Pen4, this.jiR6jl13Bb, num21, 2);
          }
        }
      }
      if (this.pad.SessionGridEnabled && ((TIntradayTransformation) this.pad.Transformation).Session >= 2L * (long) GridSize)
      {
        int num21 = 0;
        double X1;
        for (double X2 = (double) (((long) this.CJf67aSqFG / 864000000000L + 1L) * 864000000000L); (X1 = X2 + this.pad.Transformation.CalculateRealQuantityOfTicks_Right(X2, X2 + (double) ((long) num21 * ((TIntradayTransformation) this.pad.Transformation).Session))) < Max; ++num21)
          this.pad.DrawVerticalGrid(new Pen(this.pad.SessionGridColor), X1);
      }
      if (this.J2nYCsqgZK)
      {
        if (this.gck6XUIeCg == EAxisPosition.Bottom)
        {
          this.pad.DrawVerticalGrid(new Pen(Color.Green), this.pad.WorldX(this.Se1Y6TOkWX));
          this.pad.DrawVerticalGrid(new Pen(Color.Green), this.pad.WorldX(this.UElYYuNU1W));
        }
        if (this.gck6XUIeCg == EAxisPosition.Left)
        {
          this.pad.DrawHorizontalGrid(new Pen(Color.Green), this.pad.WorldY(this.Se1Y6TOkWX));
          this.pad.DrawHorizontalGrid(new Pen(Color.Green), this.pad.WorldY(this.UElYYuNU1W));
        }
      }
      if (!this.lD76USPYGZ)
        return;
			int num25 = (int) this.pad.Graphics.MeasureString("%d", this.Lju6sLD21e).Height;
			int num26 = (int) this.pad.Graphics.MeasureString(this.gDw6zAT8dQ.ToString("%d"), this.Lju6sLD21e).Width;
      int num27 = (int) this.pad.Graphics.MeasureString(this.title, this.font).Height;
      int num28 = (int) this.pad.Graphics.MeasureString(this.title, this.font).Width;
      if (this.gck6XUIeCg == EAxisPosition.Bottom)
      {
        if (this.ejS6gv5Ug7 == EAxisTitlePosition.Left)
          this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) (int) this.jiR6jl13Bb, (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV + (double) num25 + (double) this.MU36yJxSD6));
        if (this.ejS6gv5Ug7 == EAxisTitlePosition.Right)
          this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) ((int) this.WvY61ob0Xo - num28), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV + (double) num25 + (double) this.MU36yJxSD6));
        if (this.ejS6gv5Ug7 == EAxisTitlePosition.Centre)
          this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) (int) (this.jiR6jl13Bb + (this.WvY61ob0Xo - this.jiR6jl13Bb - (double) num28) / 2.0), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV + (double) num25 + (double) this.MU36yJxSD6));
      }
      if (this.gck6XUIeCg != EAxisPosition.Left || this.ejS6gv5Ug7 != EAxisTitlePosition.Centre)
        return;
      this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) (int) (this.jiR6jl13Bb - (double) this.QvE6d9RSdV - (double) num26 - (double) this.MU36yJxSD6 - (double) num27), (float) (int) (this.Eo969HTsnQ + (this.ied6e07F0D - this.Eo969HTsnQ - (double) num28) / 2.0), new StringFormat()
      {
//		FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.DirectionVertical, StringFormatFlags.DirectionVertical
      });
      this.pad.Graphics.ResetTransform();
    }

    
    public virtual void Paint()
    {
      try
      {
        if (!this.MbS6EH3Dtx)
          return;
        if (this.QeC6bMjpbe == EVerticalGridStyle.ByDateTime && this.jF56ZqlDUA == EAxisType.DateTime && this.gDw6zAT8dQ > 100000.0)
        {
          this.PaintWithDates();
        }
        else
        {
          bool flag = false;
          string str1 = "";
          if (this.gDw6zAT8dQ <= 1000000.0 && this.jF56ZqlDUA == EAxisType.DateTime)
          {
            this.jF56ZqlDUA = EAxisType.Numeric;
            flag = true;
            str1 = this.labelFormat;
						this.labelFormat = "labelFormat";
          }
          SolidBrush solidBrush1 = new SolidBrush(this.tAw6cjrLwr);
          SolidBrush solidBrush2 = new SolidBrush(this.h4w6pXqlP6);
          Pen pen = new Pen(this.tAw6cjrLwr);
          Pen Pen1 = new Pen(this.dpi6tMHwuH);
          Pen Pen2 = new Pen(this.gPe60TWLJ7);
          Pen Pen3 = new Pen(this.oua6QvZpsu);
          Pen Pen4 = new Pen(this.G1A6VJnjGW);
          Pen1.DashStyle = this.j8m6uWqvkw;
          Pen2.DashStyle = this.Vel6TAhiZ3;
          this.pad.DrawLine(new Pen(this.ViX6vvvcDs), this.jiR6jl13Bb, this.Eo969HTsnQ, this.WvY61ob0Xo, this.ied6e07F0D, false);
          int num1 = 10;
          int num2 = 5;
          double num3 = Axis.sVI6ietQib(Math.Abs(this.gDw6zAT8dQ - this.CJf67aSqFG) * 0.999999 / (double) num1);
          double num4 = Axis.sVI6ietQib(num3 / (double) num2);
          double num5 = Math.Ceiling((this.CJf67aSqFG - 0.001 * num3) / num3) * num3;
          double num6 = Math.Floor((this.gDw6zAT8dQ + 0.001 * num3) / num3) * num3;
          int num7 = 0;
          int num8 = 0;
          if (num3 != 0.0)
            num7 = Math.Min(10000, (int) Math.Floor((num6 - num5) / num3 + 0.5) + 1);
          if (num3 != 0.0)
            num8 = Math.Abs((int) Math.Floor(num3 / num4 + 0.5)) - 1;
          int num9 = 0;
          int num10 = 0;
          int num11 = 0;
          string str2 = "";
          int num12 = 0;
          for (int index1 = 0; index1 < num7; ++index1)
          {
            double num13 = num5 + (double) index1 * num3;
            switch (this.jF56ZqlDUA)
            {
              case EAxisType.Numeric:
								str2 = this.labelFormat != null ? num13.ToString(this.labelFormat) : num13.ToString("%");
                break;
              case EAxisType.DateTime:
								str2 = this.labelFormat != null ? new DateTime((long) num13).ToString(this.labelFormat) : new DateTime((long)num13).ToString("dss");
                break;
            }
            if (this.gck6XUIeCg == EAxisPosition.Bottom)
            {
              if (this.TRd6qNDWBJ)
                this.pad.DrawVerticalGrid(Pen1, num13);
              if (this.zU26hHtq00)
                this.pad.DrawVerticalTick(Pen4, num13, this.ied6e07F0D - 1.0, -this.kfw6LStExd);
              if (this.fri6W8mFh9)
              {
                SizeF sizeF = this.pad.Graphics.MeasureString(str2, this.Lju6sLD21e);
                int num14 = (int) sizeF.Width;
                num12 = (int) sizeF.Height;
                if (this.H786I1r5BA == EAxisLabelAlignment.Right)
                  this.pad.Graphics.DrawString(str2, this.Lju6sLD21e, (Brush) solidBrush2, (float) this.pad.ClientX(num13), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV));
                if (this.H786I1r5BA == EAxisLabelAlignment.Left)
                  this.pad.Graphics.DrawString(str2, this.Lju6sLD21e, (Brush) solidBrush2, (float) (this.pad.ClientX(num13) - num14), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV));
                if (this.H786I1r5BA == EAxisLabelAlignment.Centre)
                {
                  num9 = this.pad.ClientX(num13) - num14 / 2;
                  int num15 = (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV);
                  if (index1 == 0 || num9 - num10 >= 1)
                  {
                    this.pad.Graphics.DrawString(str2, this.Lju6sLD21e, (Brush) solidBrush2, (float) num9, (float) num15);
                    num10 = num9 + num14;
                  }
                }
              }
            }
            if (this.gck6XUIeCg == EAxisPosition.Left || this.gck6XUIeCg == EAxisPosition.Right)
            {
              if (this.gck6XUIeCg == EAxisPosition.Left && this.TRd6qNDWBJ)
                this.pad.DrawHorizontalGrid(Pen1, num13);
              if (this.gck6XUIeCg == EAxisPosition.Right && (!this.pad.AxisLeft.Enabled || !this.pad.AxisLeft.GridEnabled) && this.TRd6qNDWBJ)
                this.pad.DrawHorizontalGrid(Pen1, num13);
              if (this.zU26hHtq00)
              {
                switch (this.gck6XUIeCg)
                {
                  case EAxisPosition.Left:
                    this.pad.DrawHorizontalTick(Pen4, this.jiR6jl13Bb + 1.0, num13, this.kfw6LStExd);
                    break;
                  case EAxisPosition.Right:
                    this.pad.DrawHorizontalTick(Pen4, this.jiR6jl13Bb - (double) this.kfw6LStExd - 1.0, num13, this.kfw6LStExd);
                    break;
                }
              }
              if (this.fri6W8mFh9)
              {
                SizeF sizeF = this.pad.Graphics.MeasureString(str2, this.Lju6sLD21e);
                int num14 = (int) ((double) sizeF.Width + (double) this.QvE6d9RSdV);
                int num15 = (int) sizeF.Height;
                if (this.H786I1r5BA == EAxisLabelAlignment.Centre)
                {
                  switch (this.gck6XUIeCg)
                  {
                    case EAxisPosition.Left:
                      num9 = (int) (this.jiR6jl13Bb - (double) num14);
                      break;
                    case EAxisPosition.Right:
                      num9 = (int) (this.jiR6jl13Bb + 2.0);
                      break;
                  }
                  int num16 = this.pad.ClientY(num13) - num15 / 2;
                  if (index1 == 0 || num11 - (num16 + num15) >= 1)
                  {
                    if ((double) num16 > this.Eo969HTsnQ && (double) (num16 + num15) < this.ied6e07F0D)
                      this.pad.Graphics.DrawString(str2, this.Lju6sLD21e, (Brush) solidBrush2, (float) num9, (float) num16);
                    num11 = num16;
                  }
                }
              }
            }
            for (int index2 = 1; index2 <= num8; ++index2)
            {
              double num14 = num5 + (double) index1 * num3 + (double) index2 * num4;
              if (num14 < this.gDw6zAT8dQ)
              {
                if (this.gck6XUIeCg == EAxisPosition.Bottom)
                {
                  if (this.nYl6mPBuBs)
                    this.pad.DrawVerticalGrid(Pen2, num14);
                  if (this.raP6AFh3ta)
                    this.pad.DrawVerticalTick(Pen3, num14, this.ied6e07F0D - 1.0, -this.BXj6SnOZlQ);
                }
                if (this.gck6XUIeCg == EAxisPosition.Left || this.gck6XUIeCg == EAxisPosition.Right)
                {
                  if (this.gck6XUIeCg == EAxisPosition.Left && this.nYl6mPBuBs)
                    this.pad.DrawHorizontalGrid(Pen1, num14);
                  if (this.gck6XUIeCg == EAxisPosition.Right && (!this.pad.AxisLeft.Enabled || !this.pad.AxisLeft.MinorGridEnabled) && this.nYl6mPBuBs)
                    this.pad.DrawHorizontalGrid(Pen1, num14);
                  if (this.raP6AFh3ta)
                  {
                    switch (this.gck6XUIeCg)
                    {
                      case EAxisPosition.Left:
                        this.pad.DrawHorizontalTick(Pen3, this.jiR6jl13Bb + 1.0, num14, this.BXj6SnOZlQ);
                        continue;
                      case EAxisPosition.Right:
                        this.pad.DrawHorizontalTick(Pen3, this.jiR6jl13Bb - (double) this.BXj6SnOZlQ - 1.0, num14, this.BXj6SnOZlQ);
                        continue;
                      default:
                        continue;
                    }
                  }
                }
              }
            }
          }
          for (int index = 1; index <= num8; ++index)
          {
            double num13 = num5 - (double) index * num4;
            if (num13 > this.CJf67aSqFG)
            {
              if (this.gck6XUIeCg == EAxisPosition.Bottom)
              {
                if (this.nYl6mPBuBs)
                  this.pad.DrawVerticalGrid(Pen2, num13);
                if (this.raP6AFh3ta)
                  this.pad.DrawVerticalTick(Pen3, num13, this.ied6e07F0D - 1.0, -this.BXj6SnOZlQ);
              }
              if (this.gck6XUIeCg == EAxisPosition.Left || this.gck6XUIeCg == EAxisPosition.Right)
              {
                if (this.gck6XUIeCg == EAxisPosition.Left && this.nYl6mPBuBs)
                  this.pad.DrawHorizontalGrid(Pen1, num13);
                if (this.gck6XUIeCg == EAxisPosition.Right && (!this.pad.AxisLeft.Enabled || !this.pad.AxisLeft.MinorGridEnabled) && this.nYl6mPBuBs)
                  this.pad.DrawHorizontalGrid(Pen1, num13);
                if (this.raP6AFh3ta)
                {
                  switch (this.gck6XUIeCg)
                  {
                    case EAxisPosition.Left:
                      this.pad.DrawHorizontalTick(Pen3, this.jiR6jl13Bb + 1.0, num13, this.BXj6SnOZlQ);
                      continue;
                    case EAxisPosition.Right:
                      this.pad.DrawHorizontalTick(Pen3, this.jiR6jl13Bb - (double) this.BXj6SnOZlQ - 1.0, num13, this.BXj6SnOZlQ);
                      continue;
                    default:
                      continue;
                  }
                }
              }
            }
          }
          if (this.J2nYCsqgZK)
          {
            if (this.gck6XUIeCg == EAxisPosition.Bottom)
            {
              this.pad.DrawVerticalGrid(new Pen(Color.Green), this.pad.WorldX(this.Se1Y6TOkWX));
              this.pad.DrawVerticalGrid(new Pen(Color.Green), this.pad.WorldX(this.UElYYuNU1W));
            }
            if (this.gck6XUIeCg == EAxisPosition.Left)
            {
              this.pad.DrawHorizontalGrid(new Pen(Color.Green), this.pad.WorldY(this.Se1Y6TOkWX));
              this.pad.DrawHorizontalGrid(new Pen(Color.Green), this.pad.WorldY(this.UElYYuNU1W));
            }
          }
          if (this.lD76USPYGZ)
          {
				int num13 = (int) this.pad.Graphics.MeasureString("sss", this.Lju6sLD21e).Height;
				int num14 = (int) this.pad.Graphics.MeasureString(this.gDw6zAT8dQ.ToString("sffs"), this.Lju6sLD21e).Width;
            int num15 = (int) this.pad.Graphics.MeasureString(this.title, this.font).Height;
            int num16 = (int) this.pad.Graphics.MeasureString(this.title, this.font).Width;
            if (this.gck6XUIeCg == EAxisPosition.Bottom)
            {
              if (this.ejS6gv5Ug7 == EAxisTitlePosition.Left)
                this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) (int) this.jiR6jl13Bb, (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV + (double) num13 + (double) this.MU36yJxSD6));
              if (this.ejS6gv5Ug7 == EAxisTitlePosition.Right)
                this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) ((int) this.WvY61ob0Xo - num16), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV + (double) num13 + (double) this.MU36yJxSD6));
              if (this.ejS6gv5Ug7 == EAxisTitlePosition.Centre)
                this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) (int) (this.jiR6jl13Bb + (this.WvY61ob0Xo - this.jiR6jl13Bb - (double) num16) / 2.0), (float) (int) (this.ied6e07F0D + (double) this.QvE6d9RSdV + (double) num13 + (double) this.MU36yJxSD6));
            }
            if (this.gck6XUIeCg == EAxisPosition.Left && this.ejS6gv5Ug7 == EAxisTitlePosition.Centre)
            {
              this.pad.Graphics.DrawString(this.title, this.font, (Brush) solidBrush1, (float) (int) (this.jiR6jl13Bb - (double) this.QvE6d9RSdV - (double) num14 - (double) this.MU36yJxSD6 - (double) num15), (float) (int) (this.Eo969HTsnQ + (this.ied6e07F0D - this.Eo969HTsnQ - (double) num16) / 2.0), new StringFormat()
              {
//                FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.DirectionVertical,
//                FormatFlags = StringFormatFlags.DirectionVertical
              });
              this.pad.Graphics.ResetTransform();
            }
          }
          if (!flag)
            return;
          this.jF56ZqlDUA = EAxisType.DateTime;
          this.labelFormat = str1;
        }
      }
      catch
      {
      }
    }

    
    public virtual void MouseMove(MouseEventArgs Event)
    {
      if (!this.abOYnyZNZl)
        return;
      switch (this.gck6XUIeCg)
      {
        case EAxisPosition.Left:
          if (!this.pad.MouseZoomYAxisEnabled)
            break;
          this.UElYYuNU1W = Event.Y;
          this.pad.Update();
          break;
        case EAxisPosition.Bottom:
          if (!this.pad.MouseZoomXAxisEnabled)
            break;
          this.UElYYuNU1W = Event.X;
          this.pad.Update();
          break;
      }
    }

    
    public virtual void MouseDown(MouseEventArgs Event)
    {
      if (Event.Button != MouseButtons.Left)
        return;
      switch (this.gck6XUIeCg)
      {
        case EAxisPosition.Left:
          if (!this.pad.MouseZoomYAxisEnabled || this.jiR6jl13Bb - 10.0 > (double) Event.X || (this.jiR6jl13Bb < (double) Event.X || this.Eo969HTsnQ > (double) Event.Y) || this.ied6e07F0D < (double) Event.Y)
            break;
          this.abOYnyZNZl = true;
          this.uWuYomI9kU = Event.X;
          this.fsWY3PuyRF = Event.Y;
          this.Se1Y6TOkWX = Event.Y;
          this.J2nYCsqgZK = true;
          break;
        case EAxisPosition.Bottom:
          if (!this.pad.MouseZoomXAxisEnabled || this.jiR6jl13Bb > (double) Event.X || (this.WvY61ob0Xo < (double) Event.X || this.Eo969HTsnQ > (double) Event.Y) || this.Eo969HTsnQ + 10.0 < (double) Event.Y)
            break;
          this.abOYnyZNZl = true;
          this.uWuYomI9kU = Event.X;
          this.fsWY3PuyRF = Event.Y;
          this.Se1Y6TOkWX = Event.X;
          this.J2nYCsqgZK = true;
          break;
      }
    }

    
    public virtual void MouseUp(MouseEventArgs Event)
    {
      this.J2nYCsqgZK = false;
      if (Event.Button == MouseButtons.Right)
      {
        switch (this.gck6XUIeCg)
        {
          case EAxisPosition.Left:
            if (this.jiR6jl13Bb - 10.0 <= (double) Event.X && this.jiR6jl13Bb >= (double) Event.X && (this.Eo969HTsnQ <= (double) Event.Y && this.ied6e07F0D >= (double) Event.Y))
            {
              this.UnZoom();
              break;
            }
            else
              break;
          case EAxisPosition.Bottom:
            if (this.jiR6jl13Bb <= (double) Event.X && this.WvY61ob0Xo >= (double) Event.X && (this.Eo969HTsnQ <= (double) Event.Y && this.Eo969HTsnQ + 10.0 >= (double) Event.Y))
            {
              this.UnZoom();
              break;
            }
            else
              break;
        }
      }
      if (this.abOYnyZNZl && Event.Button == MouseButtons.Left)
      {
        switch (this.gck6XUIeCg)
        {
          case EAxisPosition.Left:
            if (this.pad.MouseZoomYAxisEnabled)
            {
              double num1 = this.pad.WorldY(this.fsWY3PuyRF);
              double num2 = this.pad.WorldY(Event.Y);
              if (num1 < num2)
              {
                this.Zoom(num1, num2);
                break;
              }
              else
              {
                this.Zoom(num2, num1);
                break;
              }
            }
            else
              break;
          case EAxisPosition.Bottom:
            if (this.pad.MouseZoomXAxisEnabled)
            {
              double num1 = this.pad.WorldX(this.uWuYomI9kU);
              double num2 = this.pad.WorldX(Event.X);
              if (num1 < num2)
              {
                this.Zoom(num1, num2);
                break;
              }
              else
              {
                this.Zoom(num2, num1);
                break;
              }
            }
            else
              break;
        }
      }
      this.abOYnyZNZl = false;
    }

    
    private static double sVI6ietQib([In] double obj0)
    {
      double num1 = obj0 > 0.0 ? 1.0 : -1.0;
      if (obj0 == 0.0)
        return 0.0;
      double d = Math.Log10(Math.Abs(obj0));
      double y = Math.Floor(d);
      double num2 = Math.Pow(10.0, d - y);
      double num3 = (num2 > 1.0 ? (num2 > 2.0 ? (num2 > 5.0 ? 10.0 : 5.0) : 2.0) : 1.0) * Math.Pow(10.0, y);
      return num1 * num3;
    }

    
    private static double iIt6DXx2ZI([In] double obj0)
    {
      double num1 = obj0 > 0.0 ? 1.0 : -1.0;
      if (obj0 == 0.0)
        return 0.0;
      double d = Math.Log10(Math.Abs(obj0));
      double y = Math.Floor(d);
      double num2 = Math.Pow(10.0, d - y);
      double num3 = (num2 < 10.0 ? (num2 < 5.0 ? (num2 < 2.0 ? 1.0 : 2.0) : 5.0) : 10.0) * Math.Pow(10.0, y);
      return num1 * num3;
    }
  }
}
