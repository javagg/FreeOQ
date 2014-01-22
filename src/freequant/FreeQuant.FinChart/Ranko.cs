using SmartQuant.Data;
using SmartQuant.Series;
using System;


namespace FreeQuant.FinChart
{
  public class Ranko : BarSeries
  {
    private double boxSize;
    private BarSeries M0IypMtV6M;

    public double BoxSize
    {
       get
      {
				return this.boxSize; 
      }
    }

    
		public Ranko(BarSeries BarSeries) : base()
    {
      this.M0IypMtV6M = BarSeries;
    }

    
		public Ranko(BarSeries BarSeries, double BoxSize) : base()
    {
      this.M0IypMtV6M = BarSeries;
      this.boxSize = BoxSize;
    }

    
    public void Calculate()
    {
      double num1 = 0.0;
      int index1 = 1;
      while (Math.Abs(this.M0IypMtV6M[index1].Close - this.M0IypMtV6M[0].Close) <= this.boxSize)
        ++index1;
      bool flag = this.M0IypMtV6M[index1].Close > this.M0IypMtV6M[0].Close;
      double num2 = !flag ? this.M0IypMtV6M[0].Close - Math.Floor((this.M0IypMtV6M[0].Close - this.M0IypMtV6M[index1].Close) / this.boxSize) * this.boxSize : this.M0IypMtV6M[0].Close + Math.Floor((this.M0IypMtV6M[index1].Close - this.M0IypMtV6M[0].Close) / this.boxSize) * this.boxSize;
      this.Add(new Bar(this.M0IypMtV6M.GetDateTime(0), this.M0IypMtV6M[0].Close, num1, this.M0IypMtV6M[0].Close, num1, 1L, 1L));
      for (int index2 = index1 + 1; index2 < this.M0IypMtV6M.Count; ++index2)
      {
        if (flag)
        {
          if (this.M0IypMtV6M[index2].Close >= num2 + this.boxSize)
          {
            double num3 = num2 + Math.Floor((this.M0IypMtV6M[index2].Close - num2) / this.boxSize) * this.boxSize;
            this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3, num3, num3, num3, 1L, 1L));
            num2 = num3;
          }
          else if (this.M0IypMtV6M[index2].Close <= num2 - 2.0 * this.boxSize)
          {
            double num3 = num2 - Math.Floor((num2 - this.M0IypMtV6M[index2].Close) / this.boxSize) * this.boxSize;
            this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3 - this.boxSize, num3, num3 - this.boxSize, num3, 1L, 1L));
            flag = false;
            num2 = num3;
          }
        }
        else if (this.M0IypMtV6M[index2].Close >= num2 + 2.0 * this.boxSize)
        {
          double num3 = num2 + Math.Floor((this.M0IypMtV6M[index2].Close - num2) / this.boxSize) * this.boxSize;
          this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3 + this.boxSize, num3, num3 + this.boxSize, num3, 1L, 1L));
          flag = true;
          num2 = num3;
        }
        else if (this.M0IypMtV6M[index2].Close <= num2 - this.boxSize)
        {
          double num3 = num2 - Math.Floor((num2 - this.M0IypMtV6M[index2].Close) / this.boxSize) * this.boxSize;
          this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3, num3, num3, num3, 1L, 1L));
          num2 = num3;
        }
      }
    }
  }
}
