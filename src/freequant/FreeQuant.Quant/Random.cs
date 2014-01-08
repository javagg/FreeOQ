using System;

namespace FreeQuant.Quant
{
	public class Random
	{
		private static double seed1 = 9876.0;
		private static double seed2 = 54321.0;

		public static double Seed1
		{
			get
			{
				return Random.seed1;
			}
			set
			{
				Random.seed1 = value;
			}
		}

		public static double Seed2
		{
			get
			{
				return Random.seed2;
			}
			set
			{
				Random.seed2 = value;
			}
		}

		public static double Rndm()
		{
			int num1 = (int)Random.seed1 / 53668;
			Random.seed1 = 40014.0 * (Random.seed1 - (double)(num1 * 53668)) - (double)(num1 * 12211);
			if (Random.seed1 < 0.0)
				Random.seed1 += 2147483563.0;
			int num2 = (int)Random.seed2 / 52774;
			Random.seed2 = 40692.0 * (Random.seed2 - (double)(num2 * 52774)) - (double)(num2 * 3791);
			if (Random.seed2 < 0.0)
				Random.seed2 += 2147483399.0;
			double num3 = Random.seed1 - Random.seed2;
			if (num3 <= 0.0)
				num3 += 2147483562.0;
			return num3 * 4.6566128E-10;
		}

		public static int Binomial(int ntot, double prob)
		{
			if (prob < 0.0 || prob > 1.0)
				return 0;
			int num = 0;
			for (int index = 0; index < ntot; ++index)
			{
				if (Random.Rndm() <= prob)
					++num;
			}
			return num;
		}

		public static double Gaus(double mean, double sigma)
		{
			double d;
			do
			{
				d = Random.Rndm();
			}
			while (d == 0.0);
			double a = Random.Rndm() * 6.283185;
			return mean + sigma * Math.Sin(a) * Math.Sqrt(-2.0 * Math.Log(d));
		}

		public static double Gaus()
		{
			return Random.Gaus(0.0, 1.0);
		}

		public static int Poisson(double mean)
		{
			if (mean <= 0.0)
				return 0;
			if (mean > 88.0)
				return (int)(Random.Gaus(0.0, 1.0) * Math.Sqrt(mean) + mean + 0.5);
			double num1 = Math.Exp(-mean);
			double num2 = 1.0;
			int num3 = -1;
			do
			{
				++num3;
				num2 *= Random.Rndm();
			}
			while (num2 > num1);
			return num3;
		}
	}
}
