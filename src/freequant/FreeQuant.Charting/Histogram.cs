using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class Histogram : IDrawable
  {
    private string P6F6OEmA1G;
    private string fcj6JIiZTq;
    protected int fNBins;
    protected double[] fBins;
    protected double fBinSize;
    protected double fXMin;
    protected double fXMax;
    protected double fYMin;
    protected double fYMax;
    protected double[] fIntegral;
    protected bool fIntegralChanged;
    private Color s8O6MasiY2;
    private Color igE6PbVkgQ;
    [NonSerialized]
    private Brush Dea6GTXBpE;
    private bool x7V6RqhcoW;
    private string vOM6NxrdQt;

    public string Name
    {
       get
      {
        return this.P6F6OEmA1G;
      }
       set
      {
        this.P6F6OEmA1G = value;
      }
    }

    public string Title
    {
       get
      {
        return this.fcj6JIiZTq;
      }
       set
      {
        this.fcj6JIiZTq = value;
      }
    }

    public bool ToolTipEnabled
    {
       get
      {
        return this.x7V6RqhcoW;
      }
       set
      {
        this.x7V6RqhcoW = value;
      }
    }

    public string ToolTipFormat
    {
       get
      {
        return this.vOM6NxrdQt;
      }
       set
      {
        this.vOM6NxrdQt = value;
      }
    }

    public Color LineColor
    {
       get
      {
        return this.s8O6MasiY2;
      }
       set
      {
        this.s8O6MasiY2 = value;
      }
    }

    public Color FillColor
    {
       get
      {
        return this.igE6PbVkgQ;
      }
       set
      {
        this.igE6PbVkgQ = value;
      }
    }


    public Histogram(string Name, string Title, int NBins, double XMin, double XMax):base()
    {

      this.P6F6OEmA1G = Name;
      this.fcj6JIiZTq = Title;
      this.aVo6FRVaPQ(NBins, XMin, XMax);
    }

    
    public Histogram(string Name, int NBins, double XMin, double XMax):base()
    {

      this.P6F6OEmA1G = Name;
      this.aVo6FRVaPQ(NBins, XMin, XMax);
    }


    public Histogram(int NBins, double XMin, double XMax):base()
    {

      this.aVo6FRVaPQ(NBins, XMin, XMax);
    }

    
    private void aVo6FRVaPQ([In] int obj0, [In] double obj1, [In] double obj2)
    {
      this.fNBins = obj0;
      this.fBins = new double[this.fNBins];
      this.fBinSize = Math.Abs(obj2 - obj1) / (double) obj0;
      for (int index = 0; index < this.fNBins; ++index)
        this.fBins[index] = 0.0;
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
      this.fYMin = 0.0;
      this.fYMax = 0.0;
      this.s8O6MasiY2 = Color.Black;
      this.igE6PbVkgQ = Color.Blue;
      this.Dea6GTXBpE = (Brush) null;
      this.fIntegral = new double[this.fNBins];
      this.fIntegralChanged = false;
    }

    
    public void Add(double X)
    {
      if (X < this.fXMin || X >= this.fXMax)
        return;
      int index = (int) ((double) this.fNBins * (X - this.fXMin) / (this.fXMax - this.fXMin));
      ++this.fBins[index];
      if (this.fBins[index] > this.fYMax)
        this.fYMax = this.fBins[index];
      this.fIntegralChanged = true;
    }

    
    public void Add(double X, double Value)
    {
      if (X < this.fXMin || X >= this.fXMax)
        return;
      int index = (int) ((double) this.fNBins * (X - this.fXMin) / (this.fXMax - this.fXMin));
      this.fBins[index] = Value;
      if (this.fBins[index] > this.fYMax)
        this.fYMax = this.fBins[index];
      this.fIntegralChanged = true;
    }

    
    public double GetBinSize()
    {
      return this.fBinSize;
    }

    
    public double GetBinMin(int Index)
    {
      return this.fXMin + this.fBinSize * (double) Index;
    }

    
    public double GetBinMax(int Index)
    {
      return this.fXMin + this.fBinSize * (double) (Index + 1);
    }

    
    public double GetBinCentre(int Index)
    {
      return this.fXMin + this.fBinSize * ((double) Index + 0.5);
    }

    
    public double[] GetIntegral()
    {
      if (this.fIntegralChanged)
      {
        for (int index = 0; index < this.fNBins; ++index)
          this.fIntegral[index] = index != 0 ? this.fIntegral[index - 1] + this.fBins[index] : this.fBins[index];
        if (this.fIntegral[this.fNBins - 1] == 0.0)
        {
          Console.WriteLine(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1004));
          return (double[]) null;
        }
        else
        {
          for (int index = 0; index < this.fNBins; ++index)
            this.fIntegral[index] /= this.fIntegral[this.fNBins - 1];
        }
      }
      return this.fIntegral;
    }

    
    public double GetRandom()
    {
      double SearchValue = SmartQuant.Quant.Random.Rndm();
      int Index = FinMath.BinarySearch(this.fNBins, this.GetIntegral(), SearchValue);
      if (Index >= 0 && Index < this.fNBins)
        return this.GetBinMin(Index) + this.fBinSize * (SearchValue - this.fIntegral[Index]) / (this.fIntegral[Index + 1] - this.fIntegral[Index]);
      Console.WriteLine(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1100) + (object) Index);
      return 0.0;
    }

    
    public double GetSum()
    {
      double num = 0.0;
      for (int index = 0; index < this.fNBins; ++index)
        num += this.fBins[index];
      return num;
    }

    
    public double GetMean()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      for (int Index = 0; Index < this.fNBins; ++Index)
      {
        num1 += this.fBins[Index];
        num2 += this.GetBinCentre(Index) * this.fBins[Index];
      }
      if (num1 != 0.0)
        return num2 / num1;
      else
        return 0.0;
    }

    
    public void Print()
    {
      for (int Index = 0; Index < this.fNBins; ++Index)
        Console.WriteLine((string) (object) Index + (object) RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1184) + (string) (object) this.GetBinMin(Index) + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1196) + (string) (object) this.GetBinCentre(Index) + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1202) + (string) (object) this.GetBinMax(Index) + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1208) + this.fBins[Index].ToString(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1220)));
    }

    
    public virtual void Draw()
    {
      this.Draw("");
    }

    
    public virtual void Draw(string Option)
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1228), RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1244));
      }
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.Title.Add(this.P6F6OEmA1G, this.igE6PbVkgQ);
      Chart.Pad.Legend.Add(this.P6F6OEmA1G, this.igE6PbVkgQ);
      if (Option.ToLower().IndexOf(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(1260)) >= 0)
        return;
      Chart.Pad.SetRange(this.fXMin, this.fXMax, this.fYMin - (this.fYMax - this.fYMin) / 10.0, this.fYMax + (this.fYMax - this.fYMin) / 10.0);
    }

    
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pen Pen = new Pen(this.s8O6MasiY2);
      Brush brush = this.Dea6GTXBpE != null ? this.Dea6GTXBpE : (Brush) new SolidBrush(this.igE6PbVkgQ);
      for (int Index = 0; Index < this.fNBins; ++Index)
      {
        Pad.Graphics.FillRectangle(brush, Pad.ClientX(this.GetBinMin(Index)), Pad.ClientY(this.fBins[Index]), Math.Abs(Pad.ClientX(this.GetBinMax(Index)) - Pad.ClientX(this.GetBinMin(Index))), Math.Abs(Pad.ClientY(this.fBins[Index]) - Pad.ClientY(0.0)));
        Pad.DrawLine(Pen, this.GetBinMin(Index), 0.0, this.GetBinMin(Index), this.fBins[Index]);
        Pad.DrawLine(Pen, this.GetBinMin(Index), this.fBins[Index], this.GetBinMax(Index), this.fBins[Index]);
        Pad.DrawLine(Pen, this.GetBinMax(Index), this.fBins[Index], this.GetBinMax(Index), 0.0);
      }
    }

    
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
