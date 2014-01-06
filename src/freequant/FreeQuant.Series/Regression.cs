// Type: SmartQuant.Series.Regression
// Assembly: SmartQuant.Series, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: E9488B3A-52DD-4064-9514-4FAD9D0B10AA
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Series.dll

using mXqpVnllGuXP6crdfN;
using NEVPmg8vBnJoRISXwf;
using SmartQuant.Charting;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Series
{
  public class Regression
  {
    private DoubleSeries mCPIoPBIV;
    private DoubleSeries COjwFOKjx;
    private DoubleSeries rYJrndpjL;
    private double XvUJ6WIPv;
    private double lQ1tJYPYu;
    private bool qSDcrlxsM;
    private Graph n0Qatvnka;

    public Graph Graph
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return this.n0Qatvnka;
      }
    }

    public double Alpha
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return this.XvUJ6WIPv;
      }
    }

    public double Beta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return this.lQ1tJYPYu;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Regression(DoubleSeries series1, DoubleSeries series2)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      this.n0Qatvnka = new Graph();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mCPIoPBIV = series1;
      this.COjwFOKjx = series2;
      this.n0Qatvnka.LineEnabled = false;
      this.n0Qatvnka.MarkerSize = 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Regression(DoubleSeries series1, DoubleSeries series2, double alpha, double beta)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      this.n0Qatvnka = new Graph();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mCPIoPBIV = series1;
      this.COjwFOKjx = series2;
      this.n0Qatvnka.LineEnabled = false;
      this.n0Qatvnka.MarkerSize = 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      if (this.qSDcrlxsM)
        return;
      this.lQ1tJYPYu = this.mCPIoPBIV.GetCovariance((TimeSeries) this.COjwFOKjx) / this.mCPIoPBIV.GetVariance();
      this.XvUJ6WIPv = this.COjwFOKjx.GetMean() - this.lQ1tJYPYu * this.mCPIoPBIV.GetMean();
      this.qSDcrlxsM = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate(bool force)
    {
      if (force)
        this.qSDcrlxsM = false;
      this.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRegression(double X)
    {
      this.Calculate();
      return this.XvUJ6WIPv + this.lQ1tJYPYu * X;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetResidualSeries()
    {
      this.Calculate();
      this.rYJrndpjL = new DoubleSeries();
      this.rYJrndpjL.Title = this.mCPIoPBIV.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(13318) + this.COjwFOKjx.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(13328);
      for (int index = 0; index < this.mCPIoPBIV.Count; ++index)
      {
        DateTime dateTime = this.mCPIoPBIV.GetDateTime(index);
        if (this.COjwFOKjx.Contains(dateTime))
        {
          double X = this.mCPIoPBIV[dateTime];
          double num = this.COjwFOKjx[dateTime];
          double regression = this.GetRegression(X);
          this.rYJrndpjL.Add(dateTime, num - regression);
        }
      }
      return this.rYJrndpjL;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(string Option)
    {
      this.Calculate();
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(13374)) != -1)
        this.GetResidualSeries().Draw();
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(13380)) != -1)
      {
        for (int index = 0; index < this.mCPIoPBIV.Count; ++index)
        {
          DateTime dateTime = this.mCPIoPBIV.GetDateTime(index);
          if (this.COjwFOKjx.Contains(dateTime))
            this.n0Qatvnka.Add(this.mCPIoPBIV[dateTime], this.COjwFOKjx[dateTime]);
        }
        this.n0Qatvnka.Draw();
      }
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(13386)) == -1)
        return;
      double min = this.mCPIoPBIV.GetMin();
      double max = this.mCPIoPBIV.GetMax();
      double regression1 = this.GetRegression(min);
      double regression2 = this.GetRegression(max);
      new TLine(min, regression1, max, regression2).Draw();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      this.Draw(oK6F3TB73XXXGhdieP.wF6SgrNUO(13392));
    }
  }
}
