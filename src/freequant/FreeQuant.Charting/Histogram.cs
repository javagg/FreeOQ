using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FreeQuant.Quant;

namespace FreeQuant.Charting
{
	[Serializable]
	public class Histogram : IDrawable
	{
		protected int fNBins;
		protected double[] fBins;
		protected double fBinSize;
		protected double fXMin;
		protected double fXMax;
		protected double fYMin;
		protected double fYMax;
		protected double[] fIntegral;
		protected bool fIntegralChanged;
		[NonSerialized]
		private Brush Dea6GTXBpE;

		public string Name { get; set; }

		public string Title { get; set; }

		public bool ToolTipEnabled { get; set; }

		public string ToolTipFormat { get; set; }

		public Color LineColor { get; set; }

		public Color FillColor { get; set; }

		public Histogram(string name, string title, int nBins, double XMin, double XMax) : base()
		{

			this.Name = name;
			this.Title = title;
			this.Init(nBins, XMin, XMax);
		}

		public Histogram(string name, int NBins, double XMin, double XMax) : base()
		{

			this.Name = name;
			this.Init(NBins, XMin, XMax);
		}

		public Histogram(int NBins, double XMin, double XMax) : base()
		{

			this.Init(NBins, XMin, XMax);
		}

		private void Init([In] int obj0, [In] double obj1, [In] double obj2)
		{
			this.fNBins = obj0;
			this.fBins = new double[this.fNBins];
			this.fBinSize = Math.Abs(obj2 - obj1) / (double)obj0;
			for (int index = 0; index < this.fNBins; ++index)
				this.fBins[index] = 0.0;
			if (obj1 < obj2)
			{
				this.fXMin = obj1;
				this.fXMax = obj2;
			}
			else
			{
				this.fXMin = obj2;
				this.fXMax = obj1;
			}
			this.fYMin = 0.0;
			this.fYMax = 0.0;
			this.LineColor = Color.Black;
			this.FillColor = Color.Blue;
			this.Dea6GTXBpE = null;
			this.fIntegral = new double[this.fNBins];
			this.fIntegralChanged = false;
		}

		public void Add(double x)
		{
			if (x < this.fXMin || x >= this.fXMax)
				return;
			int index = (int)((double)this.fNBins * (x - this.fXMin) / (this.fXMax - this.fXMin));
			++this.fBins[index];
			if (this.fBins[index] > this.fYMax)
				this.fYMax = this.fBins[index];
			this.fIntegralChanged = true;
		}

		public void Add(double x, double value)
		{
			if (x < this.fXMin || x >= this.fXMax)
				return;
			int index = (int)((double)this.fNBins * (x - this.fXMin) / (this.fXMax - this.fXMin));
			this.fBins[index] = value;
			if (this.fBins[index] > this.fYMax)
				this.fYMax = this.fBins[index];
			this.fIntegralChanged = true;
		}

		public double GetBinSize()
		{
			return this.fBinSize;
		}

		public double GetBinMin(int index)
		{
			return this.fXMin + this.fBinSize * (double)index;
		}

		public double GetBinMax(int index)
		{
			return this.fXMin + this.fBinSize * (double)(index + 1);
		}

		public double GetBinCentre(int index)
		{
			return this.fXMin + this.fBinSize * ((double)index + 0.5);
		}

		public double[] GetIntegral()
		{
			if (this.fIntegralChanged)
			{
				for (int index = 0; index < this.fNBins; ++index)
					this.fIntegral[index] = index != 0 ? this.fIntegral[index - 1] + this.fBins[index] : this.fBins[index];
				if (this.fIntegral[this.fNBins - 1] == 0.0)
				{
					Console.WriteLine("dddd");
					return null;
				}
				else
				{
					for (int index = 0; index < this.fNBins; ++index)
						this.fIntegral[index] /= this.fIntegral[this.fNBins - 1];
				}
			}
			return this.fIntegral;
		}

		public double GetRandom()
		{
			double SearchValue = FreeQuant.Quant.Random.Rndm();
			int Index = FinMath.BinarySearch(this.fNBins, this.GetIntegral(), SearchValue);
			if (Index >= 0 && Index < this.fNBins)
				return this.GetBinMin(Index) + this.fBinSize * (SearchValue - this.fIntegral[Index]) / (this.fIntegral[Index + 1] - this.fIntegral[Index]);
			Console.WriteLine("Index111" + Index);
			return 0.0;
		}

		public double GetSum()
		{
			double num = 0.0;
			for (int index = 0; index < this.fNBins; ++index)
				num += this.fBins[index];
			return num;
		}

		public double GetMean()
		{
			double num1 = 0.0;
			double num2 = 0.0;
			for (int index = 0; index < this.fNBins; ++index)
			{
				num1 += this.fBins[index];
				num2 += this.GetBinCentre(index) * this.fBins[index];
			}
			if (num1 != 0.0)
				return num2 / num1;
			else
				return 0.0;
		}

		public void Print()
		{
			for (int index = 0; index < this.fNBins; ++index)
				Console.WriteLine(index + "indexs" + (string)(object)this.GetBinMin(index) + "fsdf" + this.GetBinCentre(index) + "fddfs" + this.GetBinMax(index) + " dd" + this.fBins[index].ToString("D"));
		}

		public virtual void Draw()
		{
			this.Draw("");
		}

		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("Ca Name", "Ca Title");
			}
			Chart.Pad.Add(this);
			Chart.Pad.Title.Add(this.Name, this.FillColor);
			Chart.Pad.Legend.Add(this.Name, this.FillColor);
			if (Option.ToLower().IndexOf("what") >= 0)
				return;
			Chart.Pad.SetRange(this.fXMin, this.fXMax, this.fYMin - (this.fYMax - this.fYMin) / 10.0, this.fYMax + (this.fYMax - this.fYMin) / 10.0);
		}

		public virtual void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pen Pen = new Pen(this.LineColor);
			Brush brush = this.Dea6GTXBpE != null ? this.Dea6GTXBpE : (Brush)new SolidBrush(this.FillColor);
			for (int Index = 0; Index < this.fNBins; ++Index)
			{
				pad.Graphics.FillRectangle(brush, pad.ClientX(this.GetBinMin(Index)), pad.ClientY(this.fBins[Index]), Math.Abs(pad.ClientX(this.GetBinMax(Index)) - pad.ClientX(this.GetBinMin(Index))), Math.Abs(pad.ClientY(this.fBins[Index]) - pad.ClientY(0.0)));
				pad.DrawLine(Pen, this.GetBinMin(Index), 0.0, this.GetBinMin(Index), this.fBins[Index]);
				pad.DrawLine(Pen, this.GetBinMin(Index), this.fBins[Index], this.GetBinMax(Index), this.fBins[Index]);
				pad.DrawLine(Pen, this.GetBinMax(Index), this.fBins[Index], this.GetBinMax(Index), 0.0);
			}
		}

		public TDistance Distance(double X, double Y)
		{
			return null;
		}
	}
}
