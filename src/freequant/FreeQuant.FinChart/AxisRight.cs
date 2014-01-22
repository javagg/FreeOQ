using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart
{
  public class AxisRight : Axis
  {
    protected double x;
    protected double y1;
    protected double y2;
    private Pad ipsc8CkXcd;

    public double X
    {
       get
      {
        return this.x;
      }
       set
      {
        this.x = value;
      }
    }

    public double Y1
    {
       get
      {
        return this.y1;
      }
       set
      {
        this.y1 = value;
      }
    }

    public double Y2
    {
       get
      {
        return this.y2;
      }
       set
      {
        this.y2 = value;
      }
    }

    
		public AxisRight(Chart chart, Pad pad, int x, int y1, int y2):base()
    {
      this.chart = chart;
      this.ipsc8CkXcd = pad;
      this.x = (double) x;
      this.y1 = (double) y1;
      this.y2 = (double) y2;
      this.hTucCxtmDC();
    }

    
    private void hTucCxtmDC()
    {
      this.enabled = true;
      this.zoomed = false;
      this.color = Color.LightGray;
      this.title = "";
      this.titleEnabled = true;
      this.titlePosition = EAxisTitlePosition.Centre;
      this.titleFont = this.chart.Font;
      this.titleColor = Color.Black;
      this.titleOffset = 2;
      this.labelEnabled = true;
      this.labelFont = this.chart.Font;
      this.labelColor = this.chart.RightAxisTextColor;
      this.labelFormat = (string) null;
      this.labelOffset = 2;
      this.labelAlignment = EAxisLabelAlignment.Centre;
      this.gridEnabled = true;
      this.gridColor = this.chart.RightAxisGridColor;
      this.gridDashStyle = DashStyle.Dash;
      this.gridWidth = 0.5f;
      this.minorGridEnabled = false;
      this.minorGridColor = this.chart.RightAxisMinorTicksColor;
      this.minorGridDashStyle = DashStyle.Solid;
      this.minorGridWidth = 0.5f;
      this.majorTicksEnabled = true;
      this.majorTicksColor = this.chart.RightAxisMajorTicksColor;
      this.majorTicksWidth = 0.5f;
      this.majorTicksLength = 4;
      this.minorTicksEnabled = true;
      this.minorTicksColor = Color.LightGray;
      this.minorTicksWidth = 0.5f;
      this.minorTicksLength = 1;
      this.width = -1;
      this.height = -1;
    }

    
    public void SetBounds(int x, int y1, int y2)
    {
      this.x = (double) x;
      this.y1 = (double) y1;
      this.y2 = (double) y2;
    }

    
    public int GetAxisGap()
    {
      double maxValue = this.ipsc8CkXcd.MaxValue;
      double minValue = this.ipsc8CkXcd.MinValue;
      return (int) this.chart.Graphics.MeasureString(maxValue.ToString(this.ipsc8CkXcd.AxisLabelFormat), this.chart.Font).Width;
    }

    
    public void Paint()
    {
      SolidBrush solidBrush1 = new SolidBrush(this.titleColor);
      SolidBrush solidBrush2 = new SolidBrush(this.labelColor);
      Pen pen1 = new Pen(this.titleColor);
      Pen pen2 = new Pen(this.gridColor);
      Pen pen3 = new Pen(this.minorGridColor);
      Pen pen4 = new Pen(this.minorTicksColor);
      Pen pen5 = new Pen(this.majorTicksColor);
      pen2.DashStyle = this.gridDashStyle;
      pen3.DashStyle = this.minorGridDashStyle;
      this.min = this.ipsc8CkXcd.MinValue;
      this.max = this.ipsc8CkXcd.MaxValue;
      int num1 = 10;
      int num2 = 5;
      double num3 = AxisRight.O3Qc3nfpkF(Math.Abs(this.max - this.min) * 0.999999 / (double) num1);
      double num4 = AxisRight.O3Qc3nfpkF(num3 / (double) num2);
      double num5 = Math.Ceiling((this.min - 0.001 * num3) / num3) * num3;
      double num6 = Math.Floor((this.max + 0.001 * num3) / num3) * num3;
      int num7 = 0;
      int num8 = 0;
      if (num3 != 0.0)
        num7 = Math.Min(10000, (int) Math.Floor((num6 - num5) / num3 + 0.5) + 1);
      if (num3 != 0.0)
        num8 = Math.Abs((int) Math.Floor(num3 / num4 + 0.5)) - 1;
      int num9 = 0;
      for (int index1 = 0; index1 < num7; ++index1)
      {
        double num10 = num5 + (double) index1 * num3;
        string str = num10.ToString(this.ipsc8CkXcd.AxisLabelFormat);
        this.ipsc8CkXcd.DrawHorizontalGrid(pen2, num10);
        this.ipsc8CkXcd.DrawHorizontalTick(pen5, this.x - (double) this.majorTicksLength - 1.0, num10, this.majorTicksLength);
        if (this.labelEnabled)
        {
          SizeF sizeF = this.ipsc8CkXcd.Graphics.MeasureString(str, this.labelFont);
          double num11 = (double) sizeF.Width;
          int num12 = this.labelOffset;
          int num13 = (int) sizeF.Height;
          if (this.labelAlignment == EAxisLabelAlignment.Centre)
          {
            int num14 = (int) (this.x + 2.0);
            int num15 = this.ipsc8CkXcd.ClientY(num10) - num13 / 2;
            if (index1 == 0 || num9 - (num15 + num13) >= 1)
            {
              if ((double) num15 > this.y1 && (double) (num15 + num13) < this.y2)
                this.ipsc8CkXcd.Graphics.DrawString(str, this.labelFont, (Brush) solidBrush2, (float) num14, (float) num15);
              num9 = num15;
            }
          }
        }
        for (int index2 = 1; index2 <= num8; ++index2)
        {
          double y = num5 + (double) index1 * num3 + (double) index2 * num4;
          if (y < this.max)
            this.ipsc8CkXcd.DrawHorizontalTick(pen4, this.x - (double) this.minorTicksLength - 1.0, y, this.minorTicksLength);
        }
      }
      for (int index = 1; index <= num8; ++index)
      {
        double y = num5 - (double) index * num4;
        if (y > this.min && this.minorTicksEnabled)
          this.ipsc8CkXcd.DrawHorizontalTick(pen4, this.x - (double) this.minorTicksLength - 1.0, y, this.minorTicksLength);
      }
      foreach (IChartDrawable chartDrawable in this.ipsc8CkXcd.Primitives)
      {
        if (chartDrawable is IAxesMarked)
        {
          IAxesMarked axesMarked = chartDrawable as IAxesMarked;
          if (axesMarked.IsMarkEnable)
          {
            double lastValue = axesMarked.LastValue;
            if (!double.IsNaN(lastValue))
            {
              string str = lastValue.ToString(FJDHryrxb1WIq5jBAt.mT707pbkgT(2138) + axesMarked.LabelDigitsCount.ToString());
              SizeF sizeF = this.chart.Graphics.MeasureString(str, this.chart.Font);
              Color color = Color.FromArgb((int) axesMarked.Color.R ^ 128, (int) axesMarked.Color.G ^ 128, (int) axesMarked.Color.B ^ 128);
              if (this.UvocmIoHmQ(axesMarked.Color, Color.Black))
                color = Color.White;
              if (this.UvocmIoHmQ(axesMarked.Color, Color.White))
                color = Color.Black;
              this.ipsc8CkXcd.Graphics.FillRectangle((Brush) new SolidBrush(axesMarked.Color), (float) this.X, (float) ((double) this.ipsc8CkXcd.ClientY(axesMarked.LastValue) - (double) sizeF.Height / 2.0 - 2.0), sizeF.Width, sizeF.Height + 2f);
              this.ipsc8CkXcd.Graphics.DrawString(str, this.chart.font, (Brush) new SolidBrush(color), (float) this.X + 2f, (float) ((double) this.ipsc8CkXcd.ClientY(axesMarked.LastValue) - (double) sizeF.Height / 2.0 - 1.0));
            }
          }
        }
      }
    }

    
    private bool UvocmIoHmQ([In] Color obj0, [In] Color obj1)
    {
      if ((int) obj0.A == (int) obj1.A && (int) obj0.R == (int) obj1.R && (int) obj0.G == (int) obj1.G)
        return (int) obj0.B == (int) obj1.B;
      else
        return false;
    }

    
    private static double O3Qc3nfpkF([In] double obj0)
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

    
    private static double kBKcNuxFwi([In] double obj0)
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
