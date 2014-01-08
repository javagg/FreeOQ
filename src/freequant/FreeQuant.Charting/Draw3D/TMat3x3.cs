// Type: SmartQuant.Charting.Draw3D.TMat3x3
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting.Draw3D
{
  public class TMat3x3
  {
    private double[,] a7ECjWrecf;

    public double this[int i, int j]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[i, j];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[i, j] = value;
      }
    }

    public double xx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[0, 0];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[0, 0] = value;
      }
    }

    public double xy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[0, 1];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[0, 0] = value;
      }
    }

    public double xz
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[0, 2];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[0, 0] = value;
      }
    }

    public double yx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[1, 0];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[1, 0] = value;
      }
    }

    public double yy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[1, 1];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[1, 1] = value;
      }
    }

    public double yz
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[1, 2];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[1, 2] = value;
      }
    }

    public double zx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[2, 0];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[2, 0] = value;
      }
    }

    public double zy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[2, 1];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[2, 1] = value;
      }
    }

    public double zz
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a7ECjWrecf[2, 2];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a7ECjWrecf[2, 2] = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMat3x3()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.a7ECjWrecf = new double[3, 3];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMat3x3(double x)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      this.a7ECjWrecf[0, 0] = this.a7ECjWrecf[1, 1] = this.a7ECjWrecf[2, 2] = x;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMat3x3(double a, double b, double c, double d, double e, double f, double g, double h, double i)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      this.a7ECjWrecf[0, 0] = a;
      this.a7ECjWrecf[0, 1] = b;
      this.a7ECjWrecf[0, 2] = c;
      this.a7ECjWrecf[1, 0] = d;
      this.a7ECjWrecf[1, 1] = e;
      this.a7ECjWrecf[1, 2] = f;
      this.a7ECjWrecf[2, 0] = g;
      this.a7ECjWrecf[2, 1] = h;
      this.a7ECjWrecf[2, 2] = i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(TMat3x3 b, TMat3x3 a)
    {
      if (b.xx == a.xx && b.xy == a.xy && (b.xz == a.xz && b.yx == a.yx) && (b.yy == a.yy && b.yz == a.xz && (b.zx == a.zx && b.zy == a.zy)))
        return b.zz == a.xz;
      else
        return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(TMat3x3 b, TMat3x3 a)
    {
      return !(b == a);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TMat3x3 operator -(TMat3x3 m)
    {
      return new TMat3x3(-m.xx, -m.xy, -m.xz, -m.yx, -m.yy, -m.yz, -m.zx, -m.zy, -m.zz);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TMat3x3 operator *(TMat3x3 b, TMat3x3 a)
    {
      TMat3x3 tmat3x3 = new TMat3x3();
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
        {
          for (int index3 = 0; index3 < 3; ++index3)
            tmat3x3[index1, index2] += b[index1, index3] * a[index3, index2];
        }
      }
      return tmat3x3;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TMat3x3 operator *(double k, TMat3x3 m)
    {
      TMat3x3 tmat3x3 = new TMat3x3();
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
          tmat3x3[index1, index2] = k * m[index1, index2];
      }
      return tmat3x3;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TMat3x3 operator *(TMat3x3 m, double k)
    {
      return k * m;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator *(TMat3x3 m, TVec3 v)
    {
      TVec3 tvec3 = new TVec3();
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
          tvec3[index1] += m[index1, index2] * v[index2];
      }
      return tvec3;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TVec3 operator *(TVec3 v, TMat3x3 m)
    {
      TVec3 tvec3 = new TVec3();
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
          tvec3[index2] += v[index1] * m[index1, index2];
      }
      return tvec3;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZero()
    {
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
          this.a7ECjWrecf[index1, index2] = 0.0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumber(double k)
    {
      this.SetZero();
      for (int index = 0; index < 3; ++index)
        this.a7ECjWrecf[index, index] = k;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUnit()
    {
      this.SetNumber(1.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDiagonal(double lx, double ly, double lz)
    {
      this.SetZero();
      this.xx = lx;
      this.yy = ly;
      this.zz = lz;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRot(int i1, int i2, double Angle)
    {
      this.SetUnit();
      this.a7ECjWrecf[i1, i1] = this.a7ECjWrecf[i2, i2] = Math.Cos(Angle);
      this.a7ECjWrecf[i1, i2] = -(this.a7ECjWrecf[i2, i1] = Math.Sin(Angle));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotYZ(double Angle)
    {
      this.SetRot(1, 2, Angle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotZX(double Angle)
    {
      this.SetRot(2, 0, Angle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotXY(double Angle)
    {
      this.SetRot(0, 1, Angle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotX(double Angle)
    {
      this.SetRotYZ(Angle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotY(double Angle)
    {
      this.SetRotZX(Angle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotZ(double Angle)
    {
      this.SetRotXY(Angle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExchangeAxes(int i, int j)
    {
      this.SetUnit();
      this.a7ECjWrecf[i, i] = this.a7ECjWrecf[j, j] = 0.0;
      this.a7ECjWrecf[i, j] = this.a7ECjWrecf[j, i] = 1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExchangeYZ()
    {
      this.SetExchangeAxes(1, 2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSpecialProjection(double Angle)
    {
      this.SetUnit();
      this.zy = Math.Sin(Angle);
    }
  }
}
