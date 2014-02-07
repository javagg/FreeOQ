using FreeQuant.Charting;
using FreeQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace FreeQuant.Series
{
	[Serializable]
	public class DoubleSeries : TimeSeries, IDrawable, IZoomable
	{
		protected EDrawStyle fDrawStyle;
		protected int fDrawWidth;
		protected bool fAutoZoom;
		protected double fMin;
		protected double fMax;
		protected double fSum;
		protected double fMean;
		protected double fMedian;
		protected double fVariance;
		protected Color secondColor;
		protected DateTime splitDate;

		[Category("Chart")]
		[Description("")]
		[IndicatorParameter(1000001)]
		public EDrawStyle DrawStyle
		{
			get
			{
				return this.fDrawStyle;
			}
			set
			{
				this.fDrawStyle = value;
			}
		}

		[IndicatorParameter(1000002)]
		[Category("Chart")]
		[Description("")]
		public int DrawWidth
		{
			get
			{
				return this.fDrawWidth;
			}
			set
			{
				this.fDrawWidth = value;
			}
		}

		[Description("")]
		[Category("Zoom")]
		public virtual bool AutoZoom
		{
			get
			{
				return this.fAutoZoom;
			}
			set
			{
				this.fAutoZoom = value;
			}
		}

		public new double First
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Count <= 0");
				}
				return (double)this[0];
			}
		}

		public new double Last
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Count <= 0");
				}
				return (double)this[this.Count-1];
			}
		}

		public Color SecondColor
		{
			get
			{
				return this.secondColor;
			}
			set
			{
				this.secondColor = value;
			}
		}

		public DateTime SplitDate
		{
			get
			{
				return this.splitDate;
			}
			set
			{
				this.splitDate = value;
			}
		}

		public new double this[int index]
		{
			get
			{
				return (double)base[index];
			}
		}

		public new double this[DateTime datetime]
		{
			get
			{
				object obj = base[datetime];
				if (obj == null)
				{
					throw new Exception("Invalid datetime: " + datetime);
				}
				return (double)obj;
			}
			set
			{
				this.Add(datetime, value);
			}
		}

		public new double this[DateTime datetime, EIndexOption option]
		{
			get
			{
				object obj = base[datetime, option];
				if (obj != null)
					return (double)obj;
				throw new Exception("invalid datetime or option" + datetime + option);
			}
		}

		public override double this[int col, int row]
		{
			get
			{
				return this[col];
			}
		}

		[Category("ToolTip")]
		[Description("")]
		public bool ToolTipEnabled
		{
			get
			{
				return this.fToolTipEnabled;
			}
			set
			{
				this.fToolTipEnabled = value;
			}
		}

		[Description("")]
		[Category("ToolTip")]
		public string ToolTipFormat
		{
			get
			{
				return this.fToolTipFormat;
			}
			set
			{
				this.fToolTipFormat = value;
			}
		}

		[Category("ToolTip")]
		[Description("")]
		public string ToolTipDateTimeFormat
		{
			get
			{
				return this.fToolTipDateTimeFormat;
			}
			set
			{
				this.fToolTipDateTimeFormat = value;
			}
		}

		public DoubleSeries(string name, string title) : base(name, title)
		{
			this.fDrawWidth = 1;
			this.fAutoZoom = true;
			this.fMin = double.NaN;
			this.fMax = double.NaN;
			this.fSum = double.NaN;
			this.fMean = double.NaN;
			this.fMedian = double.NaN;
			this.fVariance = double.NaN;
			this.splitDate = DateTime.MaxValue;

			// This override base definition.
			this.fArray = new MemorySeries<double>();
		}

		public DoubleSeries(string name) : this(name, string.Empty)
		{
		}

		public DoubleSeries() : this(string.Empty)
		{
		}

		public static DoubleSeries operator +(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
				throw new ArgumentException("series1 = null || series2 == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name);
			for (int index = 0; index < series1.Count; ++index)
			{
				DateTime dt = series1.GetDateTime(index);
				if (series2.Contains(dt))
					ds.Add(dt, series1[dt, EIndexOption.Null] + series2[dt, EIndexOption.Null]);
			}
			return ds;
		}

		public static DoubleSeries operator -(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
				throw new ArgumentException("series1 = null || series2 == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name);
			for (int i = 0; i < series1.Count; ++i)
			{
				DateTime dt = series1.GetDateTime(i);
				if (series2.Contains(dt))
					ds.Add(dt, series1[dt, EIndexOption.Null] - series2[dt, EIndexOption.Null]);
			}
			return ds;
		}

		public static DoubleSeries operator *(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
				throw new ArgumentException("series1 = null || series2 == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name);
			for (int i = 0; i < series1.Count; ++i)
			{
				DateTime dt = series1.GetDateTime(i);
				if (series2.Contains(dt))
					ds.Add(dt, series1[dt, EIndexOption.Null] * series2[dt, EIndexOption.Null]);
			}
			return ds;
		}

		public static DoubleSeries operator /(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
				throw new ArgumentException("series1 = null || series2 == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name);
			for (int i = 0; i < series1.Count; ++i)
			{
				DateTime dt = series1.GetDateTime(i);
				if (series2.Contains(dt) && series2[dt] != 0.0)
					ds.Add(dt, series1[dt, EIndexOption.Null] / series2[dt, EIndexOption.Null]);
			}
			return ds;
		}

		public static DoubleSeries operator +(DoubleSeries series, double val)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), series[i, 0] + val);
			return ds;
		}

		public static DoubleSeries operator -(DoubleSeries series, double val)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), series[i, 0] - val);
			return ds;
		}

		public static DoubleSeries operator *(DoubleSeries series, double val)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), series[i, 0] * val);
			return ds;
		}

		public static DoubleSeries operator /(DoubleSeries series, double val)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), series[i, 0] / val);
			return ds;
		}

		public static DoubleSeries operator +(double val, DoubleSeries series)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), val + series[i, 0]);
			return ds;
		}

		public static DoubleSeries operator -(double val, DoubleSeries series)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), val - series[i, 0]);
			return ds;
		}

		public static DoubleSeries operator *(double val, DoubleSeries series)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
				ds.Add(series.GetDateTime(i), val * series[i, 0]);
			return ds;
		}

		public static DoubleSeries operator /(double val, DoubleSeries series)
		{
			if (series == null)
				throw new ArgumentException("series == null");
			DoubleSeries ds = new DoubleSeries("series1.Name" + series.Name);
			for (int i = 0; i < series.Count; ++i)
			{
				if (series[i, 0] != 0.0)
					ds.Add(series.GetDateTime(i), val / series[i, 0]);
			}
			return ds;
		}

		public new DoubleSeries Clone()
		{
			return base.Clone() as DoubleSeries;
		}

		public new DoubleSeries Clone(int index1, int index2)
		{
			return base.Clone(index1, index2) as DoubleSeries;
		}

		public new DoubleSeries Clone(DateTime datetime1, DateTime datetime2)
		{
			return base.Clone(datetime1, datetime2) as DoubleSeries;
		}

		public virtual void Add(DateTime datetime, double data)
		{
			this.fArray[datetime] = data;
			this.fChanged = true;
			this.EmitItemAdded(datetime);
		}

		public override double GetMin(int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");

			if (this.fChanged)
			{
				this.fMin = double.MaxValue;
				for (int i = 0; i < this.Count; i++)
				{
					if (this[i, row] < this.fMin)
						this.fMin = this[i, row];
				}
			}
			return this.fMin;
		}

		public override double GetMax(int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");

			if (this.fChanged)
			{
				this.fMax = double.MinValue;
				for (int i = 0; i < this.Count; ++i)
				{
					if (this[i, row] > this.fMax)
						this.fMax = this[i, row];
				}
			}
			return this.fMax;
		}

		public override double GetMin(int index1, int index2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double min = double.MaxValue;
			for (int i = index1; i <= index2; ++i)
			{
				if (this[i, row] < min)
					min = this[i, row];
			}
			return min;
		}

		public override double GetMax(int index1, int index2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double max = double.MinValue;
			for (int i = index1; i <= index2; ++i)
			{
				if (this[i, row] > max)
					max = this[i, row];
			}
			return max;
		}

		public override int GetMinIndex(int index1, int index2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			int res = -1;
			double min = double.MaxValue;
			for (int i = index1; i <= index2; ++i)
			{
				if (this[i, row] < min)
				{
					min = this[i, row];
					res = i;
				}
			}
			return res;
		}

		public override int GetMaxIndex(int index1, int index2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			int res = -1;
			double max = double.MinValue;
			for (int i = index1; i <= index2; ++i)
			{
				if (this[i, row] > max)
				{
					max = this[i, row];
					res = i;
				}
			}
			return res;
		}

		public override double GetSum()
		{
			if (this.fChanged)
			{
				this.fSum = 0.0;
				for (int i = 0; i < this.Count; ++i)
					this.fSum += this[i, 0];
			}
			return this.fSum;
		}

		public override double GetSum(int index1, int index2, int row = 0)
		{
			if (index1 >= index2)
				throw new ApplicationException("index1 >= index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double sum = 0.0;
			for (int i = index1; i <= index2; ++i)
				sum += this[i, row];
			return sum;
		}

		public override double GetMean()
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");

			if (this.fChanged)
				this.fMean = this.GetMean(0, this.Count - 1);
			return this.fMean;
		}

		public override double GetMean(int index1, int index2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double sum = 0.0;
			for (int i = index1; i <= index2; ++i)
				sum += this[i, row];

			return sum / (index2 - index1 + 1);
		}

		public override double GetMedian()
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");

			if (this.fChanged)
				this.fMedian = this.GetMedian(0, this.Count - 1);

			return this.fMedian;
		}

		public override double GetMedian(int index1, int index2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			ArrayList list = new ArrayList();
			for (int i = index1; i <= index2; ++i)
				list.Add(this[i, row]);
			list.Sort();
			return (double)list[list.Count / 2];
		}

		public override double GetVariance()
		{
			if (this.Count <= 1)
				throw new ApplicationException("Count <= 1");

			if (this.fChanged)
			{
				double mean = this.GetMean();
				this.fVariance = 0.0;
				for (int i = 0; i < this.Count; ++i)
					this.fVariance += (mean - this[i, 0]) * (mean - this[i, 0]);
				this.fVariance /= (double)(this.Count - 1);
			}
			return this.fVariance;
		}

		public override double GetVariance(int index1, int index2, int row)
		{
			if (this.Count <= 1)
				throw new ApplicationException("Count <= 1");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double mean = this.GetMean(index1, index2, row);
			double res = 0.0;
			for (int i = index1; i <= index2; ++i)
				res += (mean - base[i, row]) * (mean - base[i, row]);
			return res / (index2 - index1);
		}

		public override double GetPositiveVariance(int index1, int index2, int row = 0)
		{
			if (this.Count <= 1)
				throw new ApplicationException("Count <= 1");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			int n = 0;
			double sum = 0.0;
			for (int i = index1; i <= index2; ++i)
			{
				if (this[i, row] > 0.0)
				{
					sum += this[i, row];
					++n;
				}
			}
			double mean = sum / n;
			double res = 0.0;
			for (int i = index1; i <= index2; ++i)
			{
				if (base[i, row] > 0.0)
					res += (mean - this[i, row]) * (mean - this[i, row]);
			}
			return res / n;
		}

		public override double GetNegativeVariance(int index1, int index2, int row = 0)
		{
			if (this.Count <= 1)
				throw new ApplicationException("Count <= 1");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			int num1 = 0;
			double num2 = 0.0;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] < 0.0)
				{
					num2 += base[index, row];
					++num1;
				}
			}
			double num3 = num2 / (double)num1;
			double num4 = 0.0;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] < 0.0)
					num4 += (num3 - base[index, row]) * (num3 - base[index, row]);
			}
			return num4 / (double)num1;
		}

		public override double GetMoment(int k, int index1, int index2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double num1 = k != 1 ? this.GetMean(index1, index2, row) : 0.0;
			int num2 = 0;
			double num3 = 0.0;
			for (int i = index1; i <= index2; ++i)
			{
				num3 += Math.Pow(base[i, row] - num1, (double)k);
				++num2;
			}
			if (num2 == 0)
				return 0.0;
			else
				return num3 / (double)num2;
		}

		public override double GetAsymmetry(int index1, int index2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double stdDev = this.GetStdDev(index1, index2, row);
			if (stdDev == 0.0)
				return 0.0;
			else
				return this.GetMoment(3, index1, index2, row) / Math.Pow(stdDev, 3.0);
		}

		public override double GetExcess(int index1, int index2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double stdDev = this.GetStdDev(index1, index2, row);
			if (stdDev == 0.0)
				return 0.0;
			else
				return this.GetMoment(4, index1, index2, row) / Math.Pow(stdDev, 4.0);
		}

		public override double GetCovariance(int row1, int row2, int index1, int index2)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (index1 > index2)
				throw new ApplicationException("index1 > index2");
			if (index1 < 0 || index1 > this.Count - 1)
				throw new ApplicationException("index 1 out of range");
			if (index2 < 0 || index2 > this.Count - 1)
				throw new ApplicationException("index 2 out of range");

			double mean1 = this.GetMean(index1, index2, row1);
			double mean2 = this.GetMean(index1, index2, row2);
			double num1 = 0.0;
			double num2 = 0.0;
			for (int index = index1; index <= index2; ++index)
			{
				num2 += (base[index, row1] - mean1) * (base[index, row2] - mean2);
				++num1;
			}
			if (num1 <= 1.0)
				return 0.0;
			else
				return num2 / (num1 - 1.0);
		}

		public override double GetCorrelation(int row1, int row2, int index1, int index2)
		{
			return this.GetCovariance(row1, row2, index1, index2) / (this.GetStdDev(index1, index2, row1) * this.GetStdDev(index1, index2, row2));
		}

		public override double GetCovariance(TimeSeries series)
		{
			return this.GetCovariance(series, this.FirstDateTime, this.LastDateTime);
		}

		public override double GetCovariance(TimeSeries series, DateTime datetime1, DateTime datetime2)
		{
			if (!(series is DoubleSeries))
				throw new ArgumentException("not a DoubleSeries");

			double mean1 = this.GetMean();
			double mean2 = series.GetMean();
			double n = 0.0;
			double sum = 0.0;
			int index1 = series.GetIndex(datetime1, EIndexOption.Next);
			int index2 = series.GetIndex(datetime2, EIndexOption.Prev);
			for (int i = index1; i <= index2; ++i)
			{
				DateTime dt = this.GetDateTime(i);
				if (series.Contains(dt))
				{
					sum += (this[i] - mean1) * ((double)series[dt] - mean2);
					++n;
				}
			}
			if (n <= 1.0)
				return 0.0;

			return sum / (n - 1.0);
		}

		public override double GetCorrelation(TimeSeries series)
		{
			return this.GetCovariance(series) / (this.GetStdDev() * series.GetStdDev());
		}

		public override double GetCorrelation(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetCovariance(series, dateTime1, dateTime2) / (this.GetStdDev(dateTime1, dateTime2) * series.GetStdDev(dateTime1, dateTime2));
		}

		public virtual DoubleSeries Log()
		{
			DoubleSeries ds = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			ds.fName = this.fName;
			ds.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; ++i)
				ds.Add(this.GetDateTime(i), Math.Log(this[i, 0]));
			return ds;
		}

		public DoubleSeries Log10()
		{
			DoubleSeries ds = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			ds.fName =  this.fName;
			ds.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; ++i)
				ds.Add(this.GetDateTime(i), Math.Log10(this[i, 0]));
			return ds;
		}

		public DoubleSeries Sqrt()
		{
			DoubleSeries ds = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			ds.fName = this.fName;
			ds.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; ++i)
				ds.Add(this.GetDateTime(i), Math.Sqrt(this[i, 0]));
			return ds;
		}

		public DoubleSeries Exp()
		{
			DoubleSeries ds = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			ds.fName = this.fName;
			ds.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; ++i)
				ds.Add(this.GetDateTime(i), Math.Exp(this[i, 0]));
			return ds;
		}

		public DoubleSeries Pow(double Pow)
		{
			DoubleSeries ds = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			ds.fName = this.fName;
			ds.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; ++i)
				ds.Add(this.GetDateTime(i), Math.Pow(this[i, 0], Pow));
			return ds;
		}

		public virtual double GetAutoCovariance(int lag)
		{
			if (lag >= this.Count)
			{
				throw new ApplicationException("lag >= Count");
			}
			double m = this.GetMean();
			double sum = 0.0;
			for (int i = lag; i < this.Count; ++i)
				sum += (this[i, 0] - m) * (this[i - lag, 0] - m);
			return sum / (this.Count - lag);
		}

		public double GetAutoCorrelation(int lag)
		{
			return this.GetAutoCovariance(lag) / this.GetVariance();
		}

		public Graph GetCorrelogram(int lag1, int lag2)
		{
			Graph graph = new Graph();
			for (int i = lag1; i <= lag2; ++i)
				graph.Add((double)i, this.GetAutoCorrelation(i));
			return graph;
		}

		public Graph GetCorrelogram(int lag)
		{
			return this.GetCorrelogram(lag, this.Count / 4);
		}

		public virtual DoubleSeries GetReturnSeries()
		{
			DoubleSeries ds = new DoubleSeries(this.fName, this.fTitle);
			if (this.Count > 1)
			{
				double t0 = this[0];
				for (int i = 0; i < this.Count; ++i)
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

		public virtual DoubleSeries GetPercentReturnSeries()
		{
			DoubleSeries ds = new DoubleSeries(this.fName, this.fTitle);
			if (this.Count > 1)
			{
				double t0 = this[0];
				for (int i = 0; i < this.Count; ++i)
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

		public virtual DoubleSeries GetPositiveSeries()
		{
			DoubleSeries ds = new DoubleSeries();
			for (int i = 0; i < this.Count; ++i)
			{
				if (this[i] > 0.0)
					ds.Add(this.GetDateTime(i), this[i]);
			}
			return ds;
		}

		public virtual DoubleSeries GetNegativeSeries()
		{
			DoubleSeries ds = new DoubleSeries();
			for (int i = 0; i < this.Count; ++i)
			{
				if (this[i] < 0.0)
					ds.Add(this.GetDateTime(i), this[i]);
			}
			return ds;
		}

		public new DoubleSeries Shift(int offset)
		{
			DoubleSeries ds = new DoubleSeries(base.Name, base.Title);
			int num = 0;
			if (offset < 0)
			{
				num += Math.Abs(offset);
			}

			for (int i = num; i < this.Count; i++)
			{
				int num2 = i + offset;
				if (num2 >= this.Count)
				{
					break;
				}
				DateTime dateTime = this.GetDateTime(num2);
				double value = this[i];
				ds[dateTime] = value;
			}
			return ds;
		}

		public double Ago(int n)
		{
			int index = this.Count - 1 - n;
			if (index < 0)
			{
				throw new ArgumentException("count - 1 - n < 0");
			}
			return this[index];
		}

		public bool IsPadRangeX()
		{
			return false;
		}

		public bool IsPadRangeY()
		{
			return this.fMonitored || this.fAutoZoom;
		}

		public virtual PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		public virtual PadRange GetPadRangeY(Pad pad)
		{
			if (this.Count == 0)
				return new PadRange(0.0, 0.0);
			DateTime dt1 = new DateTime((long)pad.XMin);
			DateTime dt2 = new DateTime((long)pad.XMax);
			return new PadRange(this.GetMin(dt1, dt2), this.GetMax(dt1, dt2));
		}

		public override void Draw(string option)
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas Name", "Canvas Title");
			}
			if (option.ToLower().IndexOf("DrawStyle=Bar") != -1)
				this.fDrawStyle = EDrawStyle.Bar;
			if (option.ToLower().IndexOf("DrawStyle=Circle") != -1)
				this.fDrawStyle = EDrawStyle.Circle;
			if (option.ToLower().IndexOf("DrawStyle=Line") != -1)
				this.fDrawStyle = EDrawStyle.Line;
			Chart.Pad.Add(this);
			Chart.Pad.Title.Add(this.Name, this.Color);
			Chart.Pad.Legend.Add(this.Name, this.Color);
			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			Chart.Pad.AxisBottom.LabelFormat = "";
			if (this.Count > 0)
			{
				if ((this.LastDateTime-this.FirstDateTime).TotalSeconds / (double)(this.Count - 1) >= 86400.0)
				{
					Chart.Pad.AxisBottom.LabelFormat = "";
					this.ToolTipDateTimeFormat = "";
				}
				else
				{
					Chart.Pad.AxisBottom.LabelFormat = "";
					this.ToolTipDateTimeFormat = "";
				}

				if (option.ToLower().IndexOf("Range") == -1)
				{
					double xMin = (double)this.FirstDateTime.Ticks;
					double xMax = (double)this.LastDateTime.Ticks;
					double min = this.GetMin();
					double max = this.GetMax();
					Chart.Pad.SetRange(xMin, xMax, min, max);
				}
			}
		}

		public override void Draw()
		{
			this.Draw(string.Empty);
		}

		public virtual void Paint(Pad pad, double xMin, double xMax, double yMin, double yMax)
		{
			Pen pen1 = new Pen(this.Color, (float)this.DrawWidth);
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
			int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index1 == -1 || index2 == -1)
				return;
			switch (this.fDrawStyle)
			{
				case EDrawStyle.Line:
					for (int index3 = index1; index3 <= index2; ++index3)
					{
						DateTime dateTime3 = this.GetDateTime(index3);
						double num8 = (double)dateTime3.Ticks;
						double num9 = base[index3, 0];
						if (dateTime3 > this.splitDate)
							pen1 = new Pen(this.secondColor, (float)this.DrawWidth);
						if (num1 != 0)
						{
							x1 = pad.ClientX(num2);
							y1 = pad.ClientY(num3);
							x2 = pad.ClientX(num8);
							y2 = pad.ClientY(num9);
							if ((pad.IsInRange(num8, num9) || pad.IsInRange(num2, num3)) && (x1 != num4 || x2 != num5 || (y1 != num6 || y2 != num7)))
								pad.Graphics.DrawLine(pen1, x1, y1, x2, y2);
						}
						num4 = x1;
						num6 = y1;
						num5 = x2;
						num7 = y2;
						num2 = num8;
						num3 = num9;
						++num1;
					}
					break;
				case EDrawStyle.Bar:
					for (int index3 = index1; index3 <= index2; ++index3)
					{
						DateTime dateTime3 = this.GetDateTime(index3);
						double WorldX = (double)dateTime3.Ticks;
						double WorldY = base[index3, 0];
						if (dateTime3 > this.splitDate)
						{
							Pen pen2 = new Pen(this.secondColor, (float)this.fDrawWidth);
						}
						if (WorldY > 0.0)
							pad.Graphics.FillRectangle((Brush)new SolidBrush(this.fColor), pad.ClientX(WorldX) - (this.fDrawWidth + 1) / 2, pad.ClientY(WorldY), this.fDrawWidth + 1, pad.ClientY(0.0) - pad.ClientY(WorldY));
						else
							pad.Graphics.FillRectangle((Brush)new SolidBrush(this.fColor), pad.ClientX(WorldX) - (this.fDrawWidth + 1) / 2, pad.ClientY(0.0), this.fDrawWidth + 1, pad.ClientY(WorldY) - pad.ClientY(0.0));
					}
					break;
				case EDrawStyle.Circle:
					for (int index3 = index1; index3 <= index2; ++index3)
					{
						DateTime dateTime3 = this.GetDateTime(index3);
						double WorldX = (double)dateTime3.Ticks;
						double WorldY = base[index3, 0];
						SolidBrush solidBrush = !(dateTime3 > this.splitDate) ? new SolidBrush(this.fColor) : new SolidBrush(this.secondColor);
						pad.Graphics.FillEllipse((Brush)solidBrush, pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
					}
					break;
			}
		}

		public virtual TDistance Distance(double x, double y)
		{
			if (x < 0.0)
				return null;
			TDistance tdistance = new TDistance();
			int index1 = this.GetIndex(new DateTime((long)x), EIndexOption.Next);
			int index2 = this.GetIndex(new DateTime((long)x), EIndexOption.Prev);
			if (index1 != -1)
			{
				DateTime dateTime = this.GetDateTime(index1);
				tdistance.dX = Math.Abs(x - (double)dateTime.Ticks);
				tdistance.dY = Math.Abs(y - this[dateTime]);
				tdistance.X = (double)dateTime.Ticks;
				tdistance.Y = this[dateTime];
			}
			if (index2 != -1)
			{
				DateTime dateTime = this.GetDateTime(index2);
				double num1 = Math.Abs(x - (double)dateTime.Ticks);
				double num2 = Math.Abs(y - this[dateTime]);
				if (num1 < tdistance.dX && num2 < tdistance.dY)
				{
					tdistance.dX = num1;
					tdistance.dY = num2;
					tdistance.X = (double)dateTime.Ticks;
					tdistance.Y = this[dateTime];
				}
			}
			if (tdistance.dX == double.MaxValue || tdistance.dY == double.MaxValue)
				return null;
			DateTime dateTime1 = new DateTime((long)tdistance.X);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.fToolTipFormat != null && this.fToolTipDateTimeFormat != null)
				stringBuilder.AppendFormat(this.fToolTipFormat, (object)this.fName, (object)this.fTitle, (object)dateTime1.ToString(this.fToolTipDateTimeFormat), (object)tdistance.Y);
			tdistance.ToolTipText = ((object)stringBuilder).ToString();
			return tdistance;
		}
	}
}
