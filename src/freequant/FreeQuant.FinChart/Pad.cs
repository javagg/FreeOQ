using FreeQuant.Series;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
  public class Pad
  {
    private Chart OLnJZg8KVC;
    private AxisRight rdsJ46FBmo;
    private ArrayList ivSJfNM4Dr;
    private ArrayList yZLJG5pOYp;
    private SortedRangeList gxfJkqLOxH;
    private SortedRangeList F3nJMka9IZ;
    private SortedRangeList xFrJQlHpbJ;
    private bool owcJ6FueEr;
    private int uCaJ93q1Hs;
    private object hsXJONNCSO;
    private int RGwJsE5416;
    private int aGhJLMcbdr;
    private int FWSJqGHFko;
    private int XUIJVA9CIJ;
    private int DlpJ2abUk4;
    private int hlcJgk1Prk;
    private int uVDJHmKJ05;
    private int qY7JYWwYco;
    private double PQBJCXdCaN;
    private double Kh2JmNQxXw;
    private Graphics kc8J3ucGYL;
    private IChartDrawable ikNJNA4EFZ;
    private bool rGBJ83tF8c;
    private bool UYFJBKF5fG;
    private Rectangle iEiJj3XbDD;
    private PadScaleStyle GP7JoNtumu;
    private string XtyJawnxHe;
    private bool k9cJp7IMAe;

    public AxisRight Axis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rdsJ46FBmo;
      }
    }

    internal Chart Chart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OLnJZg8KVC;
      }
    }

    public bool DrawItems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.k9cJp7IMAe;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.k9cJp7IMAe = value;
      }
    }

    public string AxisLabelFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.XtyJawnxHe == null)
          return FJDHryrxb1WIq5jBAt.mT707pbkgT(2594) + this.OLnJZg8KVC.LabelDigitsCount.ToString();
        else
          return this.XtyJawnxHe;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XtyJawnxHe = value;
      }
    }

    public bool DrawGrid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.owcJ6FueEr;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.owcJ6FueEr = value;
      }
    }

    public PadScaleStyle ScaleStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GP7JoNtumu;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GP7JoNtumu = value;
      }
    }

    public int X1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RGwJsE5416;
      }
    }

    public int X2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aGhJLMcbdr;
      }
    }

    public int Y1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FWSJqGHFko;
      }
    }

    public int Y2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XUIJVA9CIJ;
      }
    }

    public double MaxValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PQBJCXdCaN;
      }
    }

    public double MinValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Kh2JmNQxXw;
      }
    }

    public TimeSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OLnJZg8KVC.OkdNNmbiw();
      }
    }

    public TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OLnJZg8KVC.MainSeries;
      }
    }

    public double IntervalWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OLnJZg8KVC.IntervalWidth;
      }
    }

    public int FirstIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OLnJZg8KVC.FirstIndex;
      }
    }

    public int LastIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OLnJZg8KVC.LastIndex;
      }
    }

    public Graphics Graphics
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kc8J3ucGYL;
      }
    }

    public ArrayList Primitives
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ivSJfNM4Dr;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pad(Chart chart, int x1, int x2, int y1, int y2)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.owcJ6FueEr = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OLnJZg8KVC = chart;
      this.SetCanvas(x1, x2, y1, y2);
      this.ivSJfNM4Dr = ArrayList.Synchronized(new ArrayList());
      this.yZLJG5pOYp = new ArrayList();
      this.gxfJkqLOxH = new SortedRangeList();
      this.F3nJMka9IZ = new SortedRangeList();
      this.xFrJQlHpbJ = new SortedRangeList(true);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int QSlJ10KlWj()
    {
      return this.uCaJ93q1Hs;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal IChartDrawable SKDJveno9i()
    {
      return this.ikNJNA4EFZ;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void VdUJdkoHYO(IChartDrawable value)
    {
      this.ikNJNA4EFZ = value;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int o4rJxFpDYw()
    {
      return this.DlpJ2abUk4;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void FtGJAXHCKL(int value)
    {
      this.DlpJ2abUk4 = value;
      this.aGhJLMcbdr = this.RGwJsE5416 + this.DlpJ2abUk4;
      this.rdsJ46FBmo.SetBounds(this.aGhJLMcbdr, this.FWSJqGHFko, this.XUIJVA9CIJ);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCanvas(int x1, int x2, int y1, int y2)
    {
      this.FWSJqGHFko = y1;
      this.XUIJVA9CIJ = y2;
      this.RGwJsE5416 = x1 + this.uVDJHmKJ05;
      this.aGhJLMcbdr = x2 - this.qY7JYWwYco;
      this.DlpJ2abUk4 = this.aGhJLMcbdr - this.RGwJsE5416;
      this.hlcJgk1Prk = this.XUIJVA9CIJ - this.FWSJqGHFko;
      if (this.rdsJ46FBmo == null)
        this.rdsJ46FBmo = new AxisRight(this.OLnJZg8KVC, this, x2, y1, y2);
      else
        this.rdsJ46FBmo.SetBounds(x2, y1, y2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPrimitive(IChartDrawable primitive)
    {
      this.ivSJfNM4Dr.Add((object) primitive);
      if (primitive is IDateDrawable)
        this.gxfJkqLOxH.Add(primitive as IDateDrawable);
      else
        this.yZLJG5pOYp.Add((object) primitive);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePrimitive(IChartDrawable primitive)
    {
      this.ivSJfNM4Dr.Remove((object) primitive);
      if (primitive is IDateDrawable)
        this.gxfJkqLOxH[(primitive as IDateDrawable).DateTime].Remove((object) primitive);
      else
        this.yZLJG5pOYp.Remove((object) primitive);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearPrimitives()
    {
      this.ivSJfNM4Dr.Clear();
      this.gxfJkqLOxH.Clear();
      this.yZLJG5pOYp.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSelectedObject(object obj)
    {
      this.hsXJONNCSO = obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void WudJnsmXyH()
    {
      this.ClearPrimitives();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientX(DateTime dateTime)
    {
      double num = (double) this.DlpJ2abUk4 / (double) (this.LastIndex - this.FirstIndex + 1);
      return this.RGwJsE5416 + (int) ((double) (this.MainSeries.GetIndex(dateTime) - this.FirstIndex) * num + num / 2.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientY(double worldY)
    {
      if (this.GP7JoNtumu == PadScaleStyle.Log)
        return this.FWSJqGHFko + (int) ((1.0 - (Math.Log10(worldY) - Math.Log10(this.Kh2JmNQxXw)) / (Math.Log10(this.PQBJCXdCaN) - Math.Log10(this.Kh2JmNQxXw))) * (double) this.hlcJgk1Prk);
      else
        return this.FWSJqGHFko + (int) ((1.0 - (worldY - this.Kh2JmNQxXw) / (this.PQBJCXdCaN - this.Kh2JmNQxXw)) * (double) this.hlcJgk1Prk);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      foreach (IChartDrawable chartDrawable in this.ivSJfNM4Dr)
        chartDrawable.SetInterval(minDate, maxDate);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawHorizontalGrid(Pen pen, double y)
    {
      if (!this.owcJ6FueEr)
        return;
      this.kc8J3ucGYL.DrawLine(pen, this.RGwJsE5416, this.ClientY(y), this.aGhJLMcbdr, this.ClientY(y));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawHorizontalTick(Pen pen, double x, double y, int length)
    {
      this.kc8J3ucGYL.DrawLine(pen, (int) x, this.ClientY(y), (int) x + length, this.ClientY(y));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void q1WJ72NWjL()
    {
      this.uCaJ93q1Hs = -1;
      if (this.OLnJZg8KVC.MainSeries == null || this.OLnJZg8KVC.MainSeries.Count == 0)
        return;
      this.PQBJCXdCaN = double.MinValue;
      this.Kh2JmNQxXw = double.MaxValue;
      ArrayList arrayList;
      lock (this.ivSJfNM4Dr.SyncRoot)
        arrayList = new ArrayList((ICollection) this.ivSJfNM4Dr);
      foreach (IChartDrawable chartDrawable in arrayList)
      {
        if ((this.k9cJp7IMAe || chartDrawable is SeriesView) && chartDrawable is IZoomable)
        {
          PadRange padRangeY = (chartDrawable as IZoomable).GetPadRangeY(this);
          if (padRangeY.IsValid)
          {
            if (this.PQBJCXdCaN < padRangeY.Max)
              this.PQBJCXdCaN = padRangeY.Max;
            if (this.Kh2JmNQxXw > padRangeY.Min)
              this.Kh2JmNQxXw = padRangeY.Min;
          }
        }
      }
      if (this.Kh2JmNQxXw != double.MaxValue && this.PQBJCXdCaN != double.MinValue)
      {
        this.Kh2JmNQxXw -= (this.PQBJCXdCaN - this.Kh2JmNQxXw) / 10.0;
        this.PQBJCXdCaN += (this.PQBJCXdCaN - this.Kh2JmNQxXw) / 10.0;
        this.uCaJ93q1Hs = this.rdsJ46FBmo.GetAxisGap();
      }
      else
        this.uCaJ93q1Hs = -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void WxfJR1jrge([In] Graphics obj0)
    {
      if (this.OLnJZg8KVC.MainSeries == null || this.OLnJZg8KVC.MainSeries.Count == 0)
        return;
      this.kc8J3ucGYL = obj0;
      if (this.Kh2JmNQxXw != double.MaxValue && this.PQBJCXdCaN != double.MinValue)
      {
        this.rdsJ46FBmo.Paint();
        obj0.SetClip(new Rectangle(this.RGwJsE5416, this.FWSJqGHFko, this.DlpJ2abUk4, this.hlcJgk1Prk));
        foreach (IChartDrawable chartDrawable in this.yZLJG5pOYp)
        {
          if (this.k9cJp7IMAe || chartDrawable is SeriesView)
            chartDrawable.Paint();
        }
        if (this.k9cJp7IMAe)
        {
          int nextIndex = this.gxfJkqLOxH.GetNextIndex(this.OLnJZg8KVC.MainSeries.GetDateTime(this.OLnJZg8KVC.FirstIndex));
          int prevIndex = this.gxfJkqLOxH.GetPrevIndex(this.OLnJZg8KVC.MainSeries.GetDateTime(this.OLnJZg8KVC.LastIndex));
          if (nextIndex != -1 && prevIndex != -1)
          {
            for (int index = nextIndex; index <= prevIndex; ++index)
            {
              foreach (IChartDrawable chartDrawable in this.gxfJkqLOxH[index])
              {
                if (this.hsXJONNCSO != null && chartDrawable is TransactionView && (chartDrawable as TransactionView).Compare(this.hsXJONNCSO))
                {
                  (chartDrawable as TransactionView).GBIw6qlqgC(true);
                  chartDrawable.Paint();
                  (chartDrawable as TransactionView).GBIw6qlqgC(false);
                }
                else
                  chartDrawable.Paint();
              }
            }
          }
        }
        obj0.ResetClip();
      }
      bool flag = true;
      float num = (float) (this.RGwJsE5416 + 2);
      foreach (IChartDrawable chartDrawable in this.yZLJG5pOYp)
      {
        if (chartDrawable is SeriesView)
        {
          SeriesView seriesView = chartDrawable as SeriesView;
          if (seriesView.DisplayNameEnabled)
          {
            string str;
            if (flag)
            {
              str = seriesView.DisplayName;
              flag = false;
            }
            else
              str = FJDHryrxb1WIq5jBAt.mT707pbkgT(2600) + seriesView.DisplayName;
            SizeF sizeF = obj0.MeasureString(str, this.OLnJZg8KVC.Font);
            obj0.FillRectangle((Brush) new SolidBrush(this.OLnJZg8KVC.CanvasColor), num + 2f, (float) (this.FWSJqGHFko + 2), sizeF.Width, sizeF.Height);
            obj0.DrawString(str, this.OLnJZg8KVC.Font, (Brush) new SolidBrush(seriesView.Color), num + 2f, (float) (this.FWSJqGHFko + 2));
            num += sizeF.Width;
          }
        }
      }
      if (!this.UYFJBKF5fG)
        return;
      obj0.DrawRectangle(new Pen(Color.Green), this.iEiJj3XbDD);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetDateTime(int x)
    {
      return this.OLnJZg8KVC.GetDateTime(x);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double WorldY(int y)
    {
      if (this.GP7JoNtumu == PadScaleStyle.Log)
        return Math.Pow(10.0, (double) (this.XUIJVA9CIJ - y) / (double) (this.XUIJVA9CIJ - this.FWSJqGHFko) * (Math.Log10(this.PQBJCXdCaN) - Math.Log10(this.Kh2JmNQxXw))) * this.Kh2JmNQxXw;
      else
        return this.Kh2JmNQxXw + (this.PQBJCXdCaN - this.Kh2JmNQxXw) * (double) (this.XUIJVA9CIJ - y) / (double) (this.XUIJVA9CIJ - this.FWSJqGHFko);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseDown(MouseEventArgs Event)
    {
      if (this.OLnJZg8KVC.MainSeries == null || this.OLnJZg8KVC.MainSeries.Count == 0 || (Event.X <= this.RGwJsE5416 || Event.X >= this.aGhJLMcbdr))
        return;
      double num1 = 10.0;
      double num2 = (this.PQBJCXdCaN - this.Kh2JmNQxXw) / 20.0;
      int x = Event.X;
      double y = this.WorldY(Event.Y);
      foreach (IChartDrawable chartDrawable in this.yZLJG5pOYp)
      {
        if (chartDrawable is DSView)
        {
          Distance distance = chartDrawable.Distance(x, y);
          if (distance != null)
          {
            this.OLnJZg8KVC.UnSelectAll();
            if (distance.DX < num1 && distance.DY < num2)
            {
              chartDrawable.Select();
              this.OLnJZg8KVC.dkEjGbQNc(true);
              this.OLnJZg8KVC.Invalidate();
              this.OLnJZg8KVC.ShowProperties(chartDrawable as DSView, this, false);
              this.ikNJNA4EFZ = chartDrawable;
              if (!this.OLnJZg8KVC.ContextMenuEnabled || Event.Button != MouseButtons.Right)
                break;
              this.R5OJEeLGcr(chartDrawable).Show((Control) this.OLnJZg8KVC, new Point(Event.X, Event.Y));
              break;
            }
          }
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseUp(MouseEventArgs Event)
    {
      this.OLnJZg8KVC.dkEjGbQNc(true);
      this.OLnJZg8KVC.Invalidate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseMove(MouseEventArgs Event)
    {
      if (this.OLnJZg8KVC.MainSeries == null || this.OLnJZg8KVC.MainSeries.Count == 0 || (Event.X <= this.RGwJsE5416 || Event.X >= this.aGhJLMcbdr))
        return;
      double num1 = 10.0;
      double num2 = (this.PQBJCXdCaN - this.Kh2JmNQxXw) / 20.0;
      int x = Event.X;
      double y = this.WorldY(Event.Y);
      bool flag = false;
      string caption = "";
      this.rGBJ83tF8c = false;
      foreach (IChartDrawable chartDrawable in this.yZLJG5pOYp)
      {
        if (this.k9cJp7IMAe || chartDrawable is SeriesView)
        {
          Distance distance = chartDrawable.Distance(x, y);
          if (distance != null && distance.DX < num1 && distance.DY < num2)
          {
            if (chartDrawable.ToolTipEnabled)
            {
              if (caption != "")
                caption = caption + FJDHryrxb1WIq5jBAt.mT707pbkgT(2606);
              caption = caption + distance.ToolTipText;
              flag = true;
            }
            this.rGBJ83tF8c = true;
            if (Cursor.Current != Cursors.Hand)
              Cursor.Current = Cursors.Hand;
          }
        }
      }
      if (this.k9cJp7IMAe)
      {
        int num3 = 0;
        int index1 = this.OLnJZg8KVC.MainSeries.GetIndex(this.GetDateTime(Event.X));
        DateTime dateTime1 = this.OLnJZg8KVC.MainSeries.GetDateTime(index1);
        if (index1 != 0)
        {
          DateTime dateTime2 = this.OLnJZg8KVC.MainSeries.GetDateTime(index1 - 1);
          num3 = this.gxfJkqLOxH.GetNextIndex(dateTime2);
          if (this.gxfJkqLOxH.Contains(dateTime2))
            ++num3;
        }
        int prevIndex = this.gxfJkqLOxH.GetPrevIndex(dateTime1);
        if (num3 != -1 && prevIndex != -1)
        {
          for (int index2 = num3; index2 <= prevIndex; ++index2)
          {
            foreach (IChartDrawable chartDrawable in this.gxfJkqLOxH[index2])
            {
              Distance distance = chartDrawable.Distance(x, y);
              if (distance != null && distance.DX < num1 && distance.DY < num2)
              {
                if (chartDrawable.ToolTipEnabled)
                {
                  if (caption != "")
                    caption = caption + FJDHryrxb1WIq5jBAt.mT707pbkgT(2614);
                  caption = caption + distance.ToolTipText;
                  flag = true;
                }
                this.rGBJ83tF8c = true;
                if (Cursor.Current != Cursors.Hand)
                  Cursor.Current = Cursors.Hand;
              }
            }
          }
        }
      }
      if (flag)
      {
        this.OLnJZg8KVC.RswwSJ5RAW.SetToolTip((Control) this.OLnJZg8KVC, caption);
        this.OLnJZg8KVC.RswwSJ5RAW.Active = true;
      }
      else
        this.OLnJZg8KVC.RswwSJ5RAW.Active = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ContextMenuStrip R5OJEeLGcr([In] IChartDrawable obj0)
    {
      ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
      ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
      ToolStripSeparator toolStripSeparator = new ToolStripSeparator();
      toolStripMenuItem1.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(2622) + (obj0 as DSView).DisplayName;
      toolStripMenuItem1.Click += new EventHandler(this.Tw6JTbZTIn);
      toolStripMenuItem1.Image = this.OLnJZg8KVC.PrimitiveDeleteImage;
      toolStripMenuItem2.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(2640) + (obj0 as DSView).DisplayName;
      toolStripMenuItem2.Click += new EventHandler(this.TyLJPdb2Ng);
      toolStripMenuItem2.Image = this.OLnJZg8KVC.PrimitivePropertiesImage;
      contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem1);
      contextMenuStrip.Items.Add((ToolStripItem) toolStripSeparator);
      contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem2);
      return contextMenuStrip;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TyLJPdb2Ng([In] object obj0, [In] EventArgs obj1)
    {
      this.OLnJZg8KVC.ShowProperties(this.ikNJNA4EFZ as DSView, this, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Tw6JTbZTIn([In] object obj0, [In] EventArgs obj1)
    {
      this.ivSJfNM4Dr.Remove((object) this.ikNJNA4EFZ);
      this.yZLJG5pOYp.Remove((object) this.ikNJNA4EFZ);
      this.OLnJZg8KVC.dkEjGbQNc(true);
      this.OLnJZg8KVC.Invalidate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInRange(double x, double y)
    {
      return x >= (double) this.RGwJsE5416 && x <= (double) this.aGhJLMcbdr && (y >= (double) this.FWSJqGHFko && y <= (double) this.XUIJVA9CIJ);
    }
  }
}
