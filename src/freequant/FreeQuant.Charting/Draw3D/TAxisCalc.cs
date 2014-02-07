using System;

namespace FreeQuant.Charting.Draw3D
{
	public class TAxisCalc
	{
		private TVec3 origin;
		private TVec3 end;
		private double valO;
		private double valE;
		private int nticks;
		private TAxisCalc.TTick[] tticks;
		private double SM2ynsEBp;

		public int nTicks
		{
			get
			{
				return this.nticks; 
			}
		}

		public TAxisCalc(TVec3 origin, TVec3 end, double valO, double valE, int nticks)
		{
			this.tticks = new TAxisCalc.TTick[0];
			this.origin = origin;
			this.end = end;
			this.valO = valO;
			this.valE = valE;
			this.nticks = nticks;
			this.mXvbWEhZj();
			this.CKSEVIHa4();
		}

		public double TickVal(int i)
		{
			return this.tticks[i].Value;
		}

		public TVec3 TickPos(int i)
		{
			return new TVec3(this.tticks[i].Position);
		}

		public bool TickPassed(ref TAxisCalc.TTick tick, double val)
		{
			foreach (TAxisCalc.TTick ttick in this.tticks)
			{
				if (val == ttick.Value || (val - ttick.Value) * (this.SM2ynsEBp - ttick.Value) < 0.0)
				{
					tick = ttick;
					this.SM2ynsEBp = val;
					return true;
				}
			}
			this.SM2ynsEBp = val;
			return false;
		}

		public bool TickPassed(double val)
		{
			foreach (TAxisCalc.TTick ttick in this.tticks)
			{
				if (val == ttick.Value || (val - ttick.Value) * (this.SM2ynsEBp - ttick.Value) < 0.0)
				{
					this.SM2ynsEBp = val;
					return true;
				}
			}
			this.SM2ynsEBp = val;
			return false;
		}

		public static double Round(double x)
		{
			return Math.Pow(10.0, Math.Round(Math.Log10(x)));
		}

		public static double Ceiling(double x, double d)
		{
			if (x < 0.0)
				return d * Math.Floor(x / d);
			else
				return d * Math.Ceiling(x / d);
		}

		private void mXvbWEhZj()
		{
			double d = TAxisCalc.Round(Math.Abs(this.valE - this.valO) / (double)this.nticks);
			double num1 = TAxisCalc.Ceiling(this.valO, d);
			this.nticks = (int)(Math.Abs(this.valE - num1) / d) + 1;
			if (this.nticks < 3)
				this.nticks = 3;
			this.tticks = new TAxisCalc.TTick[this.nticks];
			if (this.nticks == 3)
			{
				this.tticks[0].Value = this.valO;
				this.tticks[1].Value = 0.5 * (this.valO + this.valE);
				this.tticks[2].Value = this.valE;
			}
			else
			{
				double num2 = num1;
				if (this.valE < this.valO)
					d = -d;
				int index = 0;
				while (index < this.nticks)
				{
					this.tticks[index].Value = num2;
					++index;
					num2 += d;
				}
			}
		}

		private void CKSEVIHa4()
		{
			for (int i = 0; i < this.tticks.Length; ++i)
				this.tticks[i].Position = this.origin + (this.end - this.origin) * (this.tticks[i].Value - this.valO) / (this.valE - this.valO);
		}

		public struct TTick
		{
			public double Value;
			public TVec3 Position;
		}
	}
}
