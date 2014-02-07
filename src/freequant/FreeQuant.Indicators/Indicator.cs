using FreeQuant.Charting;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.Indicators
{
	[Serializable]
	public class Indicator : DoubleSeries, IDisposable
	{
		protected TimeSeries fInput;
		protected EIndicatorType fType;
		protected bool fCalculate = true;
		protected bool fDrawEnabled = true;
		protected int fFirstIndex;
		protected int fLastIndex;
		protected static bool fSyncIndex;

		private bool inputCalculate;

   	protected int fRealCount
		{
			get
			{
				return this.fLastIndex - this.fFirstIndex + 1;
			}
		}

		[Browsable(false)]
		public override DateTime FirstDateTime
		{
			get
			{
				this.Calculate();
				if (this.fRealCount <= 0)
					throw new ApplicationException("fRealCount <= 0");
				else
					return this.GetDateTime(this.fFirstIndex);
			}
		}

		[Browsable(false)]
		public override DateTime LastDateTime
		{
			get
			{
				this.Calculate();
				if (this.fRealCount <= 0)
					throw new ApplicationException("this.fRealCount <= 0");
				else
					return this.GetDateTime(this.fLastIndex);
			}
		}

		[Category("Description")]
		[Description("")]
		public EIndicatorType Type
		{
			get
			{
				return this.fType;
			}
		}

		[Browsable(false)]
		public override int Count
		{
			get
			{
				this.Calculate();
				return base.Count;
			}
		}

		[Browsable(false)]
		public TimeSeries Input
		{
			get
			{
				return this.fInput;
			}
			set
			{
				if (this.fInput != null)
					this.fInput.Children.Remove((object)this);
				this.fInput = value;
				this.fInput.Children.Add((object)this);
				this.fCalculate = true;
				this.Init();
				this.Connect();
			}
		}

		[Browsable(false)]
		public bool Monitored
		{
			get
			{
				return this.fMonitored;
			}
			set
			{
				this.fMonitored = value;
				if (this.fMonitored)
					this.fInput.ItemAdded += new ItemAddedEventHandler(this.OnInputItemAdded2);
				else
					this.fInput.ItemAdded -= new ItemAddedEventHandler(this.OnInputItemAdded2);
			}
		}

		[Browsable(false)]
		public override int FirstIndex
		{
			get
			{
				return this.fFirstIndex;
			}
		}

		[Browsable(false)]
		public override int LastIndex
		{
			get
			{
				return this.fLastIndex;
			}
		}

		[Browsable(false)]
		public override int RealCount
		{
			get
			{
				return this.fRealCount;
			}
		}

		[Browsable(false)]
		public bool DrawEnabled
		{
			get
			{
				return this.fDrawEnabled;
			}
			set
			{
				this.fDrawEnabled = value;
			}
		}

		public static bool SyncIndex
		{
			get
			{
				return Indicator.fSyncIndex;
			}
			set
			{
				Indicator.fSyncIndex = value;
			}
		}

		public new double this[int index]
		{
			get
			{
				this.Calculate();
				return base[index];
			}
		}

		public new double this[DateTime datetime]
		{
			get
			{
				this.Calculate();
				return base[datetime];
			}
		}

		public new double this[DateTime datetime, EIndexOption option]
		{
			get
			{
				this.Calculate();
				return base[datetime, option];
			}
		}

		public override double this[int col, int row]
		{
			get
			{
				this.Calculate();
				return base[col, row];
			}
		}

		public Indicator() : base()
		{
		}

		public Indicator(TimeSeries Input) : base()
		{
			this.fInput = Input;
			this.fInput.Children.Add(this);
			this.Connect();
		}

		protected virtual void Connect()
		{
			if (this.fInput != null)
				this.fInput.ItemAdded += new ItemAddedEventHandler(this.OnInputItemAdded2);
		}

		protected void Disconnect()
		{
			this.fInput.ItemAdded -= new ItemAddedEventHandler(this.OnInputItemAdded2);
		}

		public virtual void Detach()
		{
			this.Disconnect();
			this.fInput.Children.Remove(this);
		}

		protected virtual void Init()
		{
			this.fFirstIndex = 2 ^ 30 - 1; //1073741823
			this.fLastIndex = -(2 ^ 30);   //-1073741824;
		}

		protected virtual void OnInputItemAdded2(object sender, DateTimeEventArgs e)
		{
			if (this.inputCalculate) return;
			if (this.fCalculate)
				this.Calculate();
			this.OnInputItemAdded(sender, e);
		}

		public virtual void OnInputItemAdded(object sender, DateTimeEventArgs e)
		{
			if (!this.fMonitored) return;

			int index = this.fInput.GetIndex(e.DateTime);
			if (index == -1) return;

			this.Calculate(index);
		}

		public virtual void Calculate()
		{
			if (!this.fCalculate) return;

			this.fCalculate = false;
			this.inputCalculate = true;
			if (this.fInput is Indicator)
			{
				(this.fInput as Indicator).Calculate();
			}
			this.inputCalculate = false;
			for (int i = 0; i < this.fInput.Count; ++i)
			{
				this.Calculate(i);
			}
		}

		public virtual void Calculate(bool force)
		{
			if (force)
			{
				this.fCalculate = true;
			}
			this.Calculate();
		}

		protected virtual void Calculate(int index)
		{
		}

		public override void Add(DateTime datetime, double data)
		{
			if (!Indicator.fSyncIndex && double.IsNaN(data)) return;

			this.fArray.Remove(datetime);
			this.fArray.Add(datetime, data);
			int num = this.fArray.IndexOf(datetime);
			if (num < this.fFirstIndex)
			{
				if (!double.IsNaN(data))
					this.fFirstIndex = num;
				else
					++this.fFirstIndex;
			}
			if (num > this.fLastIndex)
			{
				if (!double.IsNaN(data))
					this.fLastIndex = num;
				else
					--this.fLastIndex;
			}
			this.fChanged = true;
			this.EmitItemAdded(datetime);
		}

		public override void Remove(int index)
		{
			if (index < this.fFirstIndex)
				--this.fFirstIndex;
			if (index <= this.fLastIndex)
				--this.fLastIndex;
			this.fArray.RemoveAt(index);
			this.fChanged = true;
		}

		public override void Clear()
		{
			this.fArray.Clear();
			this.fFirstIndex = 2 ^ 30 - 1; //1073741823
			this.fLastIndex = -(2 ^ 30);   //-1073741824;
			this.fChanged = true;
		}

		public override bool Contains(DateTime datetime)
		{
			this.Calculate();
			return base.Contains(datetime);
		}

		public override bool Contains(int index)
		{
			this.Calculate();
			return base.Contains(index);
		}

		public override DateTime GetDateTime(int index)
		{
			this.Calculate();
			return base.GetDateTime(index);
		}

		public override int GetIndex(DateTime datetime)
		{
			this.Calculate();
			return base.GetIndex(datetime);
		}

		public override int GetIndex(DateTime datetime, EIndexOption option)
		{
			this.Calculate();
			return base.GetIndex(datetime, option);
		}

		public override void Paint(Pad pad, double xMin, double xMax, double yMin, double yMax)
		{
			Pen pen = new Pen(this.Color, this.fDrawWidth);
			Brush brush = new SolidBrush(this.Color);
			int num1 = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			int x1 = 0;
			int x2 = 0;
			int y1 = 0;
			int y2 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			DateTime dateTime1 = new DateTime((long)xMin);
			DateTime dateTime2 = new DateTime((long)xMax);
			int num8 = !(dateTime1 < this.FirstDateTime) ? this.GetIndex(dateTime1, EIndexOption.Next) : this.fFirstIndex;
			int num9 = !(dateTime2 > this.LastDateTime) ? this.GetIndex(dateTime2, EIndexOption.Prev) : this.fLastIndex;
			if (num8 == -1 || num9 == -1)
				return;
			switch (this.fDrawStyle)
			{
				case EDrawStyle.Line:
					for (int index = num8; index <= num9; ++index)
					{
						double num10 = (double)this.GetDateTime(index).Ticks;
						double num11 = ((TimeSeries)this)[index, 0];
						if (num1 != 0)
						{
							x1 = pad.ClientX(num2);
							y1 = pad.ClientY(num3);
							x2 = pad.ClientX(num10);
							y2 = pad.ClientY(num11);
							if ((pad.IsInRange(num10, num11) || pad.IsInRange(num2, num3)) && (x1 != num4 || x2 != num5 || (y1 != num6 || y2 != num7)))
								pad.Graphics.DrawLine(pen, x1, y1, x2, y2);
						}
						num4 = x1;
						num6 = y1;
						num5 = x2;
						num7 = y2;
						num2 = num10;
						num3 = num11;
						++num1;
					}
					break;
				case EDrawStyle.Bar:
					for (int index = num8; index <= num9; ++index)
					{
						double WorldX = (double)this.GetDateTime(index).Ticks;
						double WorldY = ((TimeSeries)this)[index, 0];
						if (WorldY > 0.0)
							pad.Graphics.FillRectangle((Brush)new SolidBrush(this.Color), pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY), this.fDrawWidth, pad.ClientY(0.0) - pad.ClientY(WorldY));
						else
							pad.Graphics.FillRectangle((Brush)new SolidBrush(this.Color), pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(0.0), this.fDrawWidth, pad.ClientY(WorldY) - pad.ClientY(0.0));
					}
					break;
				case EDrawStyle.Circle:
					for (int index = num8; index <= num9; ++index)
					{
						double WorldX = (double)this.GetDateTime(index).Ticks;
						double WorldY = ((TimeSeries)this)[index, 0];
						pad.Graphics.FillEllipse(brush, pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
					}
					break;
			}
		}

		public override double GetSum()
		{
			if (this.fChanged)
			{
				this.fSum = 0.0;
				for (int i = this.fFirstIndex; i < this.fLastIndex; ++i)
				{
					this.fSum +=  this[i, 0];;
				}
			}
			return this.fSum;
		}

		public override double GetSum(int row)
		{
			return this.GetSum(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetMean()
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (this.fChanged)
			{
				this.fMean = this.GetMean(this.fFirstIndex, this.fLastIndex);
			}
			return this.fMean;
		}

		public override double GetMean(int row)
		{
			return this.GetMean(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetMedian()
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (this.fChanged)
			{
				this.fMedian = this.GetMedian(this.fFirstIndex, this.fLastIndex);
			}
			return this.fMedian;
		}

		public override double GetMedian(int row)
		{
			return this.GetMedian(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetVariance()
		{
			if (this.fRealCount <= 1)
				throw new ApplicationException("fRealCount <= 1");

			if (this.fChanged)
			{
				double mean = this.GetMean();
				this.fVariance = 0.0;
				for (int i = this.fFirstIndex; i < this.fLastIndex; ++i)
				{
					this.fVariance += (mean - this[i, 0]) * (mean - this[i, 0]);
				}
				this.fVariance /= (double)(this.fRealCount - 1);
			}
			return this.fVariance;
		}

		public override double GetVariance(int row)
		{
			return this.GetVariance(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetPositiveVariance(int row)
		{
			return this.GetPositiveVariance(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetNegativeVariance(int row)
		{
			return this.GetNegativeVariance(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetMoment(int k, int row)
		{
			return this.GetMoment(k, this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetAsymmetry(int row)
		{
			return this.GetAsymmetry(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetExcess(int row)
		{
			return this.GetExcess(this.fFirstIndex, this.fLastIndex, row);
		}

		public override double GetAutoCovariance(int lag)
		{
			if (lag >= this.fRealCount)
			{
				throw new ApplicationException("lag >= fRealCount");
			}
			double m = this.GetMean();
			double sum = 0.0;
			for (int i = lag + this.fFirstIndex; i < this.fLastIndex; ++i)
			{
				sum += (this[i, 0] - m) * (this[i - lag, 0] - m);
			}
			return sum / (double)(this.fLastIndex - lag);
		}

		public override DoubleSeries GetReturnSeries()
		{
			DoubleSeries ds = new DoubleSeries(this.Name, this.Title);
			if (this.Count > 1)
			{
				double t0 = this[0];
				for (int i = this.fFirstIndex; i < this.fLastIndex; ++i)
				{
					DateTime dt = this.GetDateTime(i);
					double t1 = this[i];
					if (t0 != 0.0)
						ds.Add(dt, t1 / t0);
					else
						ds.Add(dt, 0.0);
					t0 = t1;
				}
			}
			return ds;
		}

		public override DoubleSeries GetPercentReturnSeries()
		{
			DoubleSeries ds = new DoubleSeries(this.Name, this.Title);
			if (this.fRealCount > 1)
			{
				double t0 = this[0];
				for (int i = this.fFirstIndex; i < this.fLastIndex; ++i)
				{
					DateTime dt = this.GetDateTime(i);
					double t1 = this[i];
					if (t0 != 0.0)
						ds.Add(dt, (t1 / t0 - 1.0) * 100.0);
					else
						ds.Add(dt, 0.0);
					t0 = t1;
				}
			}
			return ds;
		}

		public override DoubleSeries GetPositiveSeries()
		{
			DoubleSeries ds = new DoubleSeries();
			for (int i = this.fFirstIndex; i < this.fLastIndex; ++i)
			{
				if (this[i] > 0.0)
				{
					ds.Add(this.GetDateTime(i), this[i]);
				}
			}
			return ds;
		}

		public override DoubleSeries GetNegativeSeries()
		{
			DoubleSeries ds = new DoubleSeries();
			for (int i = this.fFirstIndex; i < this.fLastIndex; ++i)
			{
				if (this[i] < 0.0)
				{
					ds.Add(this.GetDateTime(i), this[i]);
				}
			}
			return ds;
		}

		public void Dispose()
		{
			this.Detach();
		}
	}
}
