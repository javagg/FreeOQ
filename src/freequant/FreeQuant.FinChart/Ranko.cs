using FreeQuant.Data;
using FreeQuant.Series;
using System;

namespace FreeQuant.FinChart
{
	public class Ranko : BarSeries
	{
		private double boxSize;
		private BarSeries barSeries;

		public double BoxSize
		{
			get
			{
				return this.boxSize; 
			}
		}

		public Ranko(BarSeries barSeries) : base()
		{
			this.barSeries = barSeries;
		}

		public Ranko(BarSeries barSeries, double boxSize) : base()
		{
			this.barSeries = barSeries;
			this.boxSize = boxSize;
		}

		public void Calculate()
		{
			double num1 = 0.0;
			int index1 = 1;
			while (Math.Abs(this.barSeries[index1].Close - this.barSeries[0].Close) <= this.boxSize)
				++index1;
			bool flag = this.barSeries[index1].Close > this.barSeries[0].Close;
			double num2 = !flag ? this.barSeries[0].Close - Math.Floor((this.barSeries[0].Close - this.barSeries[index1].Close) / this.boxSize) * this.boxSize : this.barSeries[0].Close + Math.Floor((this.barSeries[index1].Close - this.barSeries[0].Close) / this.boxSize) * this.boxSize;
			this.Add(new Bar(this.barSeries.GetDateTime(0), this.barSeries[0].Close, num1, this.barSeries[0].Close, num1, 1L, 1L));
			for (int index2 = index1 + 1; index2 < this.barSeries.Count; ++index2)
			{
				if (flag)
				{
					if (this.barSeries[index2].Close >= num2 + this.boxSize)
					{
						double num3 = num2 + Math.Floor((this.barSeries[index2].Close - num2) / this.boxSize) * this.boxSize;
						this.Add(new Bar(this.barSeries.GetDateTime(index2), num3, num3, num3, num3, 1L, 1L));
						num2 = num3;
					}
					else if (this.barSeries[index2].Close <= num2 - 2.0 * this.boxSize)
					{
						double num3 = num2 - Math.Floor((num2 - this.barSeries[index2].Close) / this.boxSize) * this.boxSize;
						this.Add(new Bar(this.barSeries.GetDateTime(index2), num3 - this.boxSize, num3, num3 - this.boxSize, num3, 1L, 1L));
						flag = false;
						num2 = num3;
					}
				}
				else if (this.barSeries[index2].Close >= num2 + 2.0 * this.boxSize)
				{
					double num3 = num2 + Math.Floor((this.barSeries[index2].Close - num2) / this.boxSize) * this.boxSize;
					this.Add(new Bar(this.barSeries.GetDateTime(index2), num3 + this.boxSize, num3, num3 + this.boxSize, num3, 1L, 1L));
					flag = true;
					num2 = num3;
				}
				else if (this.barSeries[index2].Close <= num2 - this.boxSize)
				{
					double num3 = num2 - Math.Floor((num2 - this.barSeries[index2].Close) / this.boxSize) * this.boxSize;
					this.Add(new Bar(this.barSeries.GetDateTime(index2), num3, num3, num3, num3, 1L, 1L));
					num2 = num3;
				}
			}
		}
	}
}
