using System;

namespace FreeQuant.Charting.Draw3D
{
	public class TMat3x3
	{
		private double[,] data;

		public double this [int i, int j]
		{
			get
			{
				return this.data[i, j];
			}
			set
			{
				this.data[i, j] = value;
			}
		}

		public double xx
		{
			get
			{
				return this.data[0, 0];
			}
			set
			{
				this.data[0, 0] = value;
			}
		}

		public double xy
		{
			get
			{
				return this.data[0, 1];
			}
			set
			{
				this.data[0, 0] = value;
			}
		}

		public double xz
		{
			get
			{
				return this.data[0, 2];
			}
			set
			{
				this.data[0, 0] = value;
			}
		}

		public double yx
		{
			get
			{
				return this.data[1, 0];
			}
			set
			{
				this.data[1, 0] = value;
			}
		}

		public double yy
		{
			get
			{
				return this.data[1, 1];
			}
			set
			{
				this.data[1, 1] = value;
			}
		}

		public double yz
		{
			get
			{
				return this.data[1, 2];
			}
			set
			{
				this.data[1, 2] = value;
			}
		}

		public double zx
		{
			get
			{
				return this.data[2, 0];
			}
			set
			{
				this.data[2, 0] = value;
			}
		}

		public double zy
		{
			get
			{
				return this.data[2, 1];
			}
			set
			{
				this.data[2, 1] = value;
			}
		}

		public double zz
		{
			get
			{
				return this.data[2, 2];
			}
			set
			{
				this.data[2, 2] = value;
			}
		}

		public TMat3x3()
		{
			this.data = new double[3, 3];
		}

		public TMat3x3(double x)
		{
			this.data[0, 0] = this.data[1, 1] = this.data[2, 2] = x;
		}

		public TMat3x3(double a, double b, double c, double d, double e, double f, double g, double h, double i) : base()
		{
			this.data[0, 0] = a;
			this.data[0, 1] = b;
			this.data[0, 2] = c;
			this.data[1, 0] = d;
			this.data[1, 1] = e;
			this.data[1, 2] = f;
			this.data[2, 0] = g;
			this.data[2, 1] = h;
			this.data[2, 2] = i;
		}

		public static bool operator ==(TMat3x3 b, TMat3x3 a)
		{
			return b.xx == a.xx && b.xy == a.xy && (b.xz == a.xz && b.yx == a.yx) && (b.yy == a.yy && b.yz == a.xz && (b.zx == a.zx && b.zy == a.zy) && b.zz == a.xz);
//			if (b.xx == a.xx && b.xy == a.xy && (b.xz == a.xz && b.yx == a.yx) && (b.yy == a.yy && b.yz == a.xz && (b.zx == a.zx && b.zy == a.zy)))
//				return b.zz == a.xz;
//			else
//				return false;
		}

		public static bool operator !=(TMat3x3 b, TMat3x3 a)
		{
			return !(b == a);
		}

		public static TMat3x3 operator -(TMat3x3 m)
		{
			return new TMat3x3(-m.xx, -m.xy, -m.xz, -m.yx, -m.yy, -m.yz, -m.zx, -m.zy, -m.zz);
		}

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

		public static TMat3x3 operator *(TMat3x3 m, double k)
		{
			return k * m;
		}

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

		public void SetZero()
		{
			for (int index1 = 0; index1 < 3; ++index1)
			{
				for (int index2 = 0; index2 < 3; ++index2)
					this.data[index1, index2] = 0.0;
			}
		}

		public void SetNumber(double k)
		{
			this.SetZero();
			for (int index = 0; index < 3; ++index)
				this.data[index, index] = k;
		}

		public void SetUnit()
		{
			this.SetNumber(1.0);
		}

		public void SetDiagonal(double lx, double ly, double lz)
		{
			this.SetZero();
			this.xx = lx;
			this.yy = ly;
			this.zz = lz;
		}

		public void SetRot(int i1, int i2, double Angle)
		{
			this.SetUnit();
			this.data[i1, i1] = this.data[i2, i2] = Math.Cos(Angle);
			this.data[i1, i2] = -(this.data[i2, i1] = Math.Sin(Angle));
		}

		public void SetRotYZ(double Angle)
		{
			this.SetRot(1, 2, Angle);
		}

		public void SetRotZX(double Angle)
		{
			this.SetRot(2, 0, Angle);
		}

		public void SetRotXY(double Angle)
		{
			this.SetRot(0, 1, Angle);
		}

		public void SetRotX(double Angle)
		{
			this.SetRotYZ(Angle);
		}

		public void SetRotY(double Angle)
		{
			this.SetRotZX(Angle);
		}

		public void SetRotZ(double Angle)
		{
			this.SetRotXY(Angle);
		}

		public void SetExchangeAxes(int i, int j)
		{
			this.SetUnit();
			this.data[i, i] = this.data[j, j] = 0.0;
			this.data[i, j] = this.data[j, i] = 1.0;
		}

		public void SetExchangeYZ()
		{
			this.SetExchangeAxes(1, 2);
		}

		public void SetSpecialProjection(double Angle)
		{
			this.SetUnit();
			this.zy = Math.Sin(Angle);
		}
	}
}
