using System;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TIntradayTransformation : IChartTransformation
  {
    private long GjZC82n8Jj;
    private long J4aCZhipID;
    private long dthCXcGNNp;
    private long gWjCgJN3TA;
    private bool kQZCbKa8jb;

    public long FirstSessionTick
    {
       get
      {
        return this.GjZC82n8Jj;
      }
       set
      {
        this.GjZC82n8Jj = value;
        this.dthCXcGNNp = this.J4aCZhipID - this.GjZC82n8Jj;
      }
    }

    public long LastSessionTick
    {
       get
      {
        return this.J4aCZhipID;
      }
       set
      {
        this.J4aCZhipID = value;
        this.dthCXcGNNp = this.J4aCZhipID - this.GjZC82n8Jj;
      }
    }

    public long Session
    {
       get
      {
        return this.dthCXcGNNp;
      }
    }

    public bool SessionGridEnabled
    {
       get
      {
        return this.kQZCbKa8jb;
      }
       set
      {
        this.kQZCbKa8jb = value;
      }
    }

    
    public TIntradayTransformation()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.kQZCbKa8jb = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SetSessionBounds(0L, 864000000000L);
    }

    
    public TIntradayTransformation(long FirstSessionTick, long LastSessionTick)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.kQZCbKa8jb = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SetSessionBounds(FirstSessionTick, LastSessionTick);
    }

    
    public void SetSessionBounds(long FirstSessionTick, long LastSessionTick)
    {
      this.GjZC82n8Jj = FirstSessionTick;
      this.J4aCZhipID = LastSessionTick;
      this.dthCXcGNNp = this.J4aCZhipID - this.GjZC82n8Jj;
    }

    
    public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
    {
      if ((Max - Min) / (double) this.dthCXcGNNp <= 10.0)
      {
        GridSize = Axis.CalculateSize(Max - Min);
        Max = Min + this.CalculateRealQuantityOfTicks_Right(Min, Max);
      }
      else
      {
        Max = Min + this.CalculateRealQuantityOfTicks_Right(Min, Max);
        GridSize = Axis.CalculateSize(Max - Min);
      }
      this.gWjCgJN3TA = this.af0CimWcds((long) Min, (long) GridSize);
      if ((long) Min / 864000000000L - (long) ((long) Min + this.gWjCgJN3TA + GridSize) / 864000000000L < 0L && GridSize < (EGridSize) 576000000000)
      {
        Min += (double) this.BOvCDY6BLq((long) Min, (long) GridSize);
        this.gWjCgJN3TA = this.af0CimWcds((long) Min, (long) GridSize);
      }
      if (GridSize < (EGridSize) 576000000000)
        FirstDateTime = new DateTime((long) Min + this.gWjCgJN3TA);
      else
        this.gWjCgJN3TA = -this.GjZC82n8Jj;
    }

    
    public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
    {
      return MajorCount != 0 ? (GridSize >= (EGridSize) 576000000000 ? (double) Axis.GetNextMajor((long) PrevMajor, GridSize) : this.x4KCNJAMeJ(PrevMajor, (long) GridSize)) : (double) this.B63C22nX2q((long) FirstTick - this.gWjCgJN3TA);
    }

    
    private double x4KCNJAMeJ([In] double obj0, [In] long obj1)
    {
      double num1 = 0.0;
      if (obj0 > 10000.0)
      {
        if (obj0 % 864000000000.0 < (double) this.GjZC82n8Jj)
          obj0 = (double) ((long) obj0 / 864000000000L * 864000000000L + this.GjZC82n8Jj);
        else if (obj0 % 864000000000.0 > (double) this.J4aCZhipID)
          obj0 = (double) (((long) obj0 / 864000000000L + 1L) * 864000000000L + this.GjZC82n8Jj);
        double num2 = (double) ((long) obj0 / 864000000000L * 864000000000L + this.J4aCZhipID);
        double num3 = num2 - obj0;
        num1 = num3 >= (double) obj1 ? obj0 + (double) obj1 : num2 + 864000000000.0 - (double) this.dthCXcGNNp - num3 + (double) obj1;
      }
      return num1;
    }

    
    private long B63C22nX2q([In] long obj0)
    {
      long num = 0L;
      if (obj0 > 10000L)
        num = obj0 % 864000000000L < this.GjZC82n8Jj || obj0 % 864000000000L > this.J4aCZhipID ? this.B63C22nX2q(obj0 + 864000000000L - this.dthCXcGNNp) : obj0;
      return num;
    }

    
    public double CalculateRealQuantityOfTicks_Right(double X, double Y)
    {
      long num1 = (long) (Y - X) / this.dthCXcGNNp * 864000000000L;
      long num2 = (long) (Y - X) % this.dthCXcGNNp;
      return (double) ((long) (X + (double) num1) / 864000000000L * 864000000000L + this.J4aCZhipID) - (X + (double) num1) < (double) num2 ? (double) (num1 + num2 + 864000000000L - this.dthCXcGNNp) : (double) (num1 + num2);
    }

    
    public double CalculateRealQuantityOfTicks_Left(double X, double Y)
    {
      long num1 = (long) (X - Y) / this.dthCXcGNNp * 864000000000L;
      long num2 = (long) (X - Y) % this.dthCXcGNNp;
      long num3 = (long) (X - (double) num1) / 864000000000L * 864000000000L + this.GjZC82n8Jj;
      return (double) -(X - (double) num1 - (double) num3 < (double) num2 ? num1 + num2 + 864000000000L - this.dthCXcGNNp : num1 + num2);
    }

    
    private long af0CimWcds([In] long obj0, [In] long obj1)
    {
      obj0 = obj0 / 864000000000L * 864000000000L + this.GjZC82n8Jj;
      return -((obj0 - this.GjZC82n8Jj) / 864000000000L) * ((864000000000L - this.dthCXcGNNp) % obj1) % obj1;
    }

    
    private long BOvCDY6BLq([In] long obj0, [In] long obj1)
    {
      if ((obj0 + obj1) / 864000000000L - obj0 / 864000000000L > 0L && (obj0 + obj1) % 864000000000L > this.GjZC82n8Jj && obj1 < 576000000000L)
        return (obj0 / 864000000000L + 1L) * 864000000000L + this.GjZC82n8Jj - obj0;
      else
        return 0L;
    }

    
    public double CalculateNotInSessionTicks(double X, double Y)
    {
      if (Y <= 10000.0)
        return 0.0;
      long num1 = (long) X % 864000000000L;
      long num2 = (long) Y % 864000000000L;
      double num3 = (double) ((long) X / 864000000000L * 864000000000L);
      double num4 = (double) ((long) Y / 864000000000L * 864000000000L);
      double num5 = 0.0;
      double num6 = 0.0;
      double num7 = num3 + (double) this.J4aCZhipID;
      if (num1 < this.GjZC82n8Jj)
        num5 = (double) (this.GjZC82n8Jj - num1);
      if (num1 > this.J4aCZhipID)
        num5 = (double) (this.GjZC82n8Jj + 864000000000L - num1);
      double num8 = num4 + (double) this.J4aCZhipID;
      if (num2 < this.GjZC82n8Jj)
        num6 = (double) (-this.GjZC82n8Jj + num2);
      if (num2 > this.J4aCZhipID)
        num6 = (double) (num2 - this.J4aCZhipID);
      return num5 + num6 + (double) (864000000000L - this.dthCXcGNNp) * ((num8 - num7) / 864000000000.0);
    }
  }
}
