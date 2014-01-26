using FreeQuant.Charting;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Series
{
	public class Regression
	{
		private DoubleSeries series1;
		private DoubleSeries series2;
		private DoubleSeries rYJrndpjL;
		private double alpha;
		private double beta;
		private bool calculated;
		private Graph graph;

		public Graph Graph
		{
			get
			{
				Calculate();
				return this.graph; 
			}
		}

		public double Alpha
		{
			get
			{
				Calculate();
				return this.alpha; 
			}
		}

		public double Beta
		{
			get
			{
				Calculate();
				return this.beta; 
			}
		}

		public Regression(DoubleSeries series1, DoubleSeries series2)
		{
			this.graph = new Graph();
			this.series1 = series1;
			this.series2 = series2;
			this.graph.LineEnabled = false;
			this.graph.MarkerSize = 1;
		}

		public Regression(DoubleSeries series1, DoubleSeries series2, double alpha, double beta)
		{
			this.graph = new Graph();
			this.series1 = series1;
			this.series2 = series2;
			this.graph.LineEnabled = false;
			this.graph.MarkerSize = 1;
		}

		public void Calculate()
		{
			if (this.calculated)
				return;
			this.beta = this.series1.GetCovariance((TimeSeries)this.series2) / this.series1.GetVariance();
			this.alpha = this.series2.GetMean() - this.beta * this.series1.GetMean();
			this.calculated = true;
		}

		public void Calculate(bool force)
		{
			if (force)
				this.calculated = false;
			Calculate();
		}

		public double GetRegression(double X)
		{
			Calculate();
			return this.alpha + this.beta * X;
		}

		public DoubleSeries GetResidualSeries()
		{
			Calculate();
			this.rYJrndpjL = new DoubleSeries();
			this.rYJrndpjL.Title = this.series1.Name + "" + this.series2.Name + "name";
			for (int index = 0; index < this.series1.Count; ++index)
			{
				DateTime dateTime = this.series1.GetDateTime(index);
				if (this.series2.Contains(dateTime))
				{
					double X = this.series1[dateTime];
					double num = this.series2[dateTime];
					double regression = this.GetRegression(X);
					this.rYJrndpjL.Add(dateTime, num - regression);
				}
			}
			return this.rYJrndpjL;
		}

		public void Draw(string Option)
		{
			Calculate();
			if (Option.ToLower().IndexOf("ss") != -1)
				this.GetResidualSeries().Draw();
			if (Option.ToLower().IndexOf("fd") != -1)
			{
				for (int index = 0; index < this.series1.Count; ++index)
				{
					DateTime dateTime = this.series1.GetDateTime(index);
					if (this.series2.Contains(dateTime))
						this.graph.Add(this.series1[dateTime], this.series2[dateTime]);
				}
				this.graph.Draw();
			}
			if (Option.ToLower().IndexOf("fsd") == -1)
				return;
			double min = this.series1.GetMin();
			double max = this.series1.GetMax();
			double regression1 = this.GetRegression(min);
			double regression2 = this.GetRegression(max);
			new TLine(min, regression1, max, regression2).Draw();
		}

		public void Draw()
		{
			this.Draw("options");
		}
	}
}
