using FreeQuant.Charting;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Series
{
  public class Regression
  {
    private DoubleSeries mCPIoPBIV;
    private DoubleSeries COjwFOKjx;
    private DoubleSeries rYJrndpjL;
    private double alpha;
    private double beta;
    private bool qSDcrlxsM;
    private Graph graph;

    public Graph Graph
    {
       get
      {
        this.Calculate();
				return this.graph; 
      }
    }

    public double Alpha
    {
       get
      {
        this.Calculate();
				return this.alpha; 
      }
    }

    public double Beta
    {
       get
      {
        this.Calculate();
				return this.beta; 
      }
    }

    
    public Regression(DoubleSeries series1, DoubleSeries series2)
    {
      this.graph = new Graph();
      this.mCPIoPBIV = series1;
      this.COjwFOKjx = series2;
      this.graph.LineEnabled = false;
      this.graph.MarkerSize = 1;
    }

    
    public Regression(DoubleSeries series1, DoubleSeries series2, double alpha, double beta)
    {
      this.graph = new Graph();
      this.mCPIoPBIV = series1;
      this.COjwFOKjx = series2;
      this.graph.LineEnabled = false;
      this.graph.MarkerSize = 1;
    }

    
    public void Calculate()
    {
      if (this.qSDcrlxsM)
        return;
      this.beta = this.mCPIoPBIV.GetCovariance((TimeSeries) this.COjwFOKjx) / this.mCPIoPBIV.GetVariance();
      this.alpha = this.COjwFOKjx.GetMean() - this.beta * this.mCPIoPBIV.GetMean();
      this.qSDcrlxsM = true;
    }

    
    public void Calculate(bool force)
    {
      if (force)
        this.qSDcrlxsM = false;
      this.Calculate();
    }

    
    public double GetRegression(double X)
    {
      this.Calculate();
      return this.alpha + this.beta * X;
    }

    
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
            this.graph.Add(this.mCPIoPBIV[dateTime], this.COjwFOKjx[dateTime]);
        }
        this.graph.Draw();
      }
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(13386)) == -1)
        return;
      double min = this.mCPIoPBIV.GetMin();
      double max = this.mCPIoPBIV.GetMax();
      double regression1 = this.GetRegression(min);
      double regression2 = this.GetRegression(max);
      new TLine(min, regression1, max, regression2).Draw();
    }

    
    public void Draw()
    {
      this.Draw(oK6F3TB73XXXGhdieP.wF6SgrNUO(13392));
    }
  }
}
