// Type: SmartQuant.Charting.Draw3D.TVec3
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting.Draw3D
{
  public struct TVec3
  {
    public double x;
    public double y;
    public double z;

    public double this[int i]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (i == 0)
          return this.x;
        if (i != 1)
          return this.z;
        else
          return this.y;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (i == 0)
          this.x = value;
        else if (i == 1)
          this.y = value;
        else
          this.z = value;
      }
    }

    public double Sqr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this * this;
      }
    }

    public double Norm1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Math.Abs(this.x) + Math.Abs(this.y) + Math.Abs(this.z);
      }
    }

    public double Norm2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Math.Sqrt(this.Sqr);
      }
    }

    public double NormInf
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        double num1 = Math.Abs(this.x);
        double num2 = Math.Abs(this.y);
        double num3 = Math.Abs(this.z);
        if (num1 <= num2)
        {
          if (num2 <= num3)
            return num3;
          else
            return num2;
        }
        else if (num1 <= num3)
          return num3;
        else
          return num1;
      }
    }

    public static TVec3 O
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new TVec3(0.0, 0.0, 0.0);
      }
    }

    public static TVec3 ex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new TVec3(1.0, 0.0, 0.0);
      }
    }

    public static TVec3 ey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new TVec3(0.0, 1.0, 0.0);
      }
    }

    public static TVec3 ez
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new TVec3(0.0, 0.0, 1.0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TVec3(double X, double Y, double Z)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.x = X;
      this.y = Y;
      this.z = Z;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TVec3(TVec3 v)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.x = v.x;
      this.y = v.y;
      this.z = v.z;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator Point(TVec3 v)
    {
      return new Point((int) v.x, (int) v.y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator PointF(TVec3 v)
    {
      return new PointF((float) v.x, (float) v.y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator +(TVec3 a)
    {
      return a;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator -(TVec3 a)
    {
      return new TVec3(-a.x, -a.y, -a.z);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator +(TVec3 a, TVec3 b)
    {
      return new TVec3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator -(TVec3 a, TVec3 b)
    {
      return new TVec3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator ^(TVec3 a, TVec3 b)
    {
      return new TVec3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator *(double k, TVec3 a)
    {
      return new TVec3(k * a.x, k * a.y, k * a.z);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator *(TVec3 a, double k)
    {
      return k * a;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator /(TVec3 a, double d)
    {
      return new TVec3(a.x / d, a.y / d, a.z / d);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double operator *(TVec3 a, TVec3 b)
    {
      return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Point[] PointArray(TVec3[] v)
    {
      Point[] pointArray = new Point[v.Length];
      for (int index = 0; index < pointArray.Length; ++index)
        pointArray[index] = (Point) v[index];
      return pointArray;
    }
  }
}
