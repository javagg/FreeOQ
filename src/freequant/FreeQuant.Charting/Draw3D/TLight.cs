using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting.Draw3D
{
	public class TLight
	{
		public TColor Ambient;
		public TLight.TSource[] ParallelBeams;
		public TLight.TSource[] NearSources;

		public TLight()
		{
			this.Ambient = new TColor(Color.PaleTurquoise);
			this.ParallelBeams = new TLight.TSource[1]
			{
				new TLight.TSource(new TVec3(3, -2, 2), (TColor)Color.LightYellow)
			};
			this.NearSources = new TLight.TSource[0];

			this.SetSfumatoDay();
			this.SetShadowSources(0.25);
		}

		public void SetSfumatoDay()
		{
			this.Ambient = new TColor(0.55, 0.55, 0.7);
			this.ParallelBeams[0].c = 2.05 * new TColor(1.0, 1.0, 0.55);
		}

		public void SetNormalDay()
		{
			this.SetSfumatoDay();
			this.Ambient *= 1.1;
			this.ParallelBeams[0].c *= 1.1;
		}

		public void SetVeryBrightDay()
		{
			this.SetSfumatoDay();
			this.Ambient *= 1.2;
			this.ParallelBeams[0].c *= 1.2;
		}

		public void SetShadowSources(double K)
		{
			TLight.TSource[] tsources = new TLight.TSource[2 * this.ParallelBeams.Length];
			for (int i = 0; i < this.ParallelBeams.Length; ++i)
			{
				int i2 = 2 * i;
				tsources[i2] = this.ParallelBeams[i];
				tsources[i2 + 1].o = -tsources[i2].o;
				tsources[i2 + 1].c = -K * tsources[i2].c;
			}
			this.ParallelBeams = tsources;
		}

		public virtual TColor Result(TVec3 r, TVec3 n, TColor Diffuse)
		{
			TColor tcolor = this.Ambient;
			foreach (TLight.TSource tsource in this.ParallelBeams)
			{
				double num1 = n * tsource.o;
				if (num1 >= 0.0)
				{
					double num2 = num1 * num1 / (n * n * tsource.o * tsource.o);
					tcolor += num2 * tsource.c;
				}
			}
			foreach (TLight.TSource tsource in this.NearSources)
			{
				TVec3 tvec3 = tsource.o - r;
				double num1 = n * tvec3;
				double num2 = tvec3 * tvec3;
				if (num1 >= 0.0)
				{
					double num3 = num1 * num1 / (n * n * num2 * num2);
					tcolor += num3 * tsource.c;
				}
			}
			return Diffuse * tcolor;
		}

		public struct TSource
		{
			public TVec3 o;
			public TColor c;

			public TSource(TVec3 o, TColor c)
			{
				this.o = o;
				this.c = c;
			}
		}
	}
}
