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

		new public double First
		{
			get
			{
				return (double)this[0];
			}
		}

		new public double Last
		{
			get
			{
				return (double)this[this.Count - 1];
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

		new public double this[int index]
		{
			get
			{
				return (double)base[index];
			}
		}

		new public double this [DateTime dateTime]
		{
			get
			{
				object obj = base[dateTime];
				return (double)obj;
			}
			set
			{
				this.Add(dateTime, value);
			}
		}

		new public double this [DateTime dateTime, EIndexOption option]
		{
			get
			{
				object obj = base[dateTime, option];
				if (obj != null)
					return (double)obj;
				throw new Exception("" + dateTime + option);
			}
		}

		public override double this [int col, int row]
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
				return this.toolTipEnabled;
			}
			set
			{
				this.toolTipEnabled = value;
			}
		}

		[Description("")]
		[Category("ToolTip")]
		public string ToolTipFormat
		{
			get
			{
				return this.toolTipFormat;
			}
			set
			{
				this.toolTipFormat = value;
			}
		}

		[Category("ToolTip")]
		[Description("")]
		public string ToolTipDateTimeFormat
		{
			get
			{
				return this.toolTipDateTimeFormat;
			}
			set
			{
				this.toolTipDateTimeFormat = value;
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

//			this.fArray = (IDataSeries)new MemorySeries<double>();
		}

		public DoubleSeries(string name) : this(name, String.Empty)
		{
		}

		public DoubleSeries() : base(string.Empty)
		{
		}

		public static DoubleSeries operator +(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
				throw new ArgumentException("series1=null");
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name + "");
			for (int index = 0; index < series1.Count; ++index)
			{
				DateTime dateTime = series1.GetDateTime(index);
				if (series2.Contains(dateTime))
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] + series2[dateTime, EIndexOption.Null]);
			}
			return doubleSeries;
		}

		public static DoubleSeries operator -(DoubleSeries series1, DoubleSeries series2)
		{
//			if (series1 == null || series2 == null)
//				throw new ArgumentException("series1=null");
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name + "");
			for (int index = 0; index < series1.Count; ++index)
			{
				DateTime dateTime = series1.GetDateTime(index);
				if (series2.Contains(dateTime))
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] - series2[dateTime, EIndexOption.Null]);
			}
			return doubleSeries;
		}

		public static DoubleSeries operator *(DoubleSeries series1, DoubleSeries series2)
		{
//			if (series1 == null || series2 == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9396));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name + "");
			for (int index = 0; index < series1.Count; ++index)
			{
				DateTime dateTime = series1.GetDateTime(index);
				if (series2.Contains(dateTime))
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] * series2[dateTime, EIndexOption.Null]);
			}
			return doubleSeries;
		}

		public static DoubleSeries operator /(DoubleSeries series1, DoubleSeries series2)
		{
//			if (series1 == null || series2 == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9484));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series1.Name + "series2.Name" + series2.Name + "");
			for (int index = 0; index < series1.Count; ++index)
			{
				DateTime dateTime = series1.GetDateTime(index);
				if (series2.Contains(dateTime) && series2[dateTime] != 0.0)
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] / series2[dateTime, EIndexOption.Null]);
			}
			return doubleSeries;
		}

		public static DoubleSeries operator +(DoubleSeries series, double Value)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9572));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), ((TimeSeries)series)[index, 0] + Value);
			return doubleSeries;
		}

		public static DoubleSeries operator -(DoubleSeries series, double Value)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9668));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), ((TimeSeries)series)[index, 0] - Value);
			return doubleSeries;
		}

		public static DoubleSeries operator *(DoubleSeries series, double Value)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9764));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), ((TimeSeries)series)[index, 0] * Value);
			return doubleSeries;
		}

		public static DoubleSeries operator /(DoubleSeries series, double Value)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9860));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), ((TimeSeries)series)[index, 0] / Value);
			return doubleSeries;
		}

		public static DoubleSeries operator +(double Value, DoubleSeries series)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9956));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), Value + ((TimeSeries)series)[index, 0]);
			return doubleSeries;
		}

		public static DoubleSeries operator -(double Value, DoubleSeries series)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10052));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), Value - ((TimeSeries)series)[index, 0]);
			return doubleSeries;
		}

		public static DoubleSeries operator *(double Value, DoubleSeries series)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10148));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
				doubleSeries.Add(series.GetDateTime(index), Value * ((TimeSeries)series)[index, 0]);
			return doubleSeries;
		}

		public static DoubleSeries operator /(double Value, DoubleSeries series)
		{
//			if (series == null)
//				throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10244));
			DoubleSeries doubleSeries = new DoubleSeries("series1.Name" + series.Name);
			for (int index = 0; index < series.Count; ++index)
			{
				if (((TimeSeries)series)[index, 0] != 0.0)
					doubleSeries.Add(series.GetDateTime(index), Value / ((TimeSeries)series)[index, 0]);
			}
			return doubleSeries;
		}

		new public DoubleSeries Clone()
		{
			return base.Clone() as DoubleSeries;
		}

		new public DoubleSeries Clone(int index1, int index2)
		{
			return base.Clone(index1, index2) as DoubleSeries;
		}

		new public DoubleSeries Clone(DateTime DateTime1, DateTime DateTime2)
		{
			return base.Clone(DateTime1, DateTime2) as DoubleSeries;
		}

		public virtual void Add(DateTime DateTime, double Data)
		{
			this.fArray[DateTime] = (object)Data;
			this.changed = true;
			this.EmitItemAdded(DateTime);
		}

		public override double GetMin(int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4516));
			if (this.changed)
			{
				this.fMin = double.MaxValue;
				for (int index = 0; index < this.Count; ++index)
				{
					if (base[index, row] < this.fMin)
						this.fMin = base[index, row];
				}
			}
			return this.fMin;
		}

		public override double GetMax(int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4598));
			if (this.changed)
			{
				this.fMax = double.MinValue;
				for (int index = 0; index < this.Count; ++index)
				{
					if (base[index, row] > this.fMax)
						this.fMax = base[index, row];
				}
			}
			return this.fMax;
		}

		public override double GetMin(int index1, int index2, int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4680));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4762));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4834));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4882));
			double num = double.MaxValue;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] < num)
					num = base[index, row];
			}
			return num;
		}

		public override double GetMax(int index1, int index2, int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4930));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5012));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5084));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5132));
			double num = double.MinValue;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] > num)
					num = base[index, row];
			}
			return num;
		}

		public override int GetMinIndex(int index1, int index2, int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5180));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5280));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5352));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5400));
			int num1 = -1;
			double num2 = double.MaxValue;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] < num2)
				{
					num2 = base[index, row];
					num1 = index;
				}
			}
			return num1;
		}

		public override int GetMaxIndex(int index1, int index2, int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5448));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5548));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5620));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5668));
			int num1 = -1;
			double num2 = double.MinValue;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] > num2)
				{
					num2 = base[index, row];
					num1 = index;
				}
			}
			return num1;
		}

		public override double GetSum()
		{
			if (this.changed)
			{
				this.fSum = 0.0;
				for (int index = 0; index < this.Count; ++index)
					this.fSum += base[index, 0];
			}
			return this.fSum;
		}

		public override double GetSum(int index1, int index2, int row = 0)
		{
//			if (index1 >= index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5716));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5788));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5836));
			double num = 0.0;
			for (int index = index1; index <= index2; ++index)
				num += base[index, row];
			return num;
		}

		public override double GetMean()
		{
			if (this.changed)
				this.fMean = this.GetMean(0, this.Count - 1);
			return this.fMean;
		}

		public override double GetMean(int index1, int index2, int row)
		{
			double num = 0.0;
			for (int index = index1; index <= index2; ++index)
				num += base[index, row];
			return num / (double)(index2 - index1 + 1);
		}

		public override double GetMedian()
		{
			if (this.changed)
				this.fMedian = this.GetMedian(0, this.Count - 1);
			return this.fMedian;
		}

		public override double GetMedian(int index1, int index2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6302));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6384));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6456));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6504));
			ArrayList arrayList = new ArrayList();
			for (int index = index1; index <= index2; ++index)
				arrayList.Add((object)base[index, row]);
			arrayList.Sort();
			return (double)arrayList[arrayList.Count / 2];
		}

		public override double GetVariance()
		{
//			if (this.Count <= 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6552));
			if (this.changed)
			{
				double mean = this.GetMean();
				this.fVariance = 0.0;
				for (int index = 0; index < this.Count; ++index)
					this.fVariance += (mean - base[index, 0]) * (mean - base[index, 0]);
				this.fVariance /= (double)(this.Count - 1);
			}
			return this.fVariance;
		}

		public override double GetVariance(int index1, int index2, int row = 0)
		{
//			if (this.Count <= 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6702));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6852));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6924));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6972));
			double mean = this.GetMean(index1, index2, row);
			double num = 0.0;
			for (int index = index1; index <= index2; ++index)
				num += (mean - base[index, row]) * (mean - base[index, row]);
			return num / (double)(index2 - index1);
		}

		public override double GetPositiveVariance(int index1, int index2, int row = 0)
		{
//			if (this.Count <= 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7020));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7170));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7242));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7290));
			int num1 = 0;
			double num2 = 0.0;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] > 0.0)
				{
					num2 += base[index, row];
					++num1;
				}
			}
			double num3 = num2 / (double)num1;
			double num4 = 0.0;
			for (int index = index1; index <= index2; ++index)
			{
				if (base[index, row] > 0.0)
					num4 += (num3 - base[index, row]) * (num3 - base[index, row]);
			}
			return num4 / (double)num1;
		}

		public override double GetNegativeVariance(int index1, int index2, int row = 0)
		{
//			if (this.Count <= 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7338));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7488));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7560));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7608));
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
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7656) + this.name + oK6F3TB73XXXGhdieP.wF6SgrNUO(7730));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7754));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7826));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7874));
			double num1 = k != 1 ? this.GetMean(index1, index2, row) : 0.0;
			int num2 = 0;
			double num3 = 0.0;
			for (int index = index1; index <= index2; ++index)
			{
				num3 += Math.Pow(base[index, row] - num1, (double)k);
				++num2;
			}
			if (num2 == 0)
				return 0.0;
			else
				return num3 / (double)num2;
		}

		public override double GetAsymmetry(int index1, int index2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7922) + this.name + oK6F3TB73XXXGhdieP.wF6SgrNUO(7998));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8022));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8094));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8142));
			double stdDev = this.GetStdDev(index1, index2, row);
			if (stdDev == 0.0)
				return 0.0;
			else
				return this.GetMoment(3, index1, index2, row) / Math.Pow(stdDev, 3.0);
		}

		public override double GetExcess(int index1, int index2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8190) + this.name + oK6F3TB73XXXGhdieP.wF6SgrNUO(8260));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8284));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8356));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8404));
			double stdDev = this.GetStdDev(index1, index2, row);
			if (stdDev == 0.0)
				return 0.0;
			else
				return this.GetMoment(4, index1, index2, row) / Math.Pow(stdDev, 4.0);
		}

		public override double GetCovariance(int row1, int row2, int index1, int index2)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8452));
//			if (index1 > index2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8546));
//			if (index1 < 0 || index1 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8618));
//			if (index2 < 0 || index2 > this.Count - 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8666));
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

		public override double GetCovariance(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
		{
			if (!(series is DoubleSeries))
				throw new ArgumentException("not a DoubleSeries");
			double mean1 = this.GetMean();
			double mean2 = series.GetMean();
			double num1 = 0.0;
			double num2 = 0.0;
			int index1 = series.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = series.GetIndex(dateTime2, EIndexOption.Prev);
			for (int index3 = index1; index3 <= index2; ++index3)
			{
				DateTime dateTime = this.GetDateTime(index3);
				if (series.Contains(dateTime))
				{
					num2 += (this[index3] - mean1) * ((double)series[dateTime] - mean2);
					++num1;
				}
			}
			if (num1 <= 1.0)
				return 0.0;
			else
				return num2 / (num1 - 1.0);
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
			DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.name = this.name;
			doubleSeries.title = this.title;
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this.GetDateTime(index), Math.Log(base[index, 0]));
			return doubleSeries;
		}

		public DoubleSeries Log10()
		{
			DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.name =  this.name;
			doubleSeries.title = this.title;
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this.GetDateTime(index), Math.Log10(base[index, 0]));
			return doubleSeries;
		}

		public DoubleSeries Sqrt()
		{
			DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.name =  this.name;
			doubleSeries.title = this.title;
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this.GetDateTime(index), Math.Sqrt(base[index, 0]));
			return doubleSeries;
		}

		public DoubleSeries Exp()
		{
			DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.name =  this.name;
			doubleSeries.title = this.title;
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this.GetDateTime(index), Math.Exp(base[index, 0]));
			return doubleSeries;
		}

		public DoubleSeries Pow(double Pow)
		{
			DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.name =  this.name;
			doubleSeries.Title = this.title;
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this.GetDateTime(index), Math.Pow(base[index, 0], Pow));
			return doubleSeries;
		}

		public virtual double GetAutoCovariance(int Lag)
		{
			if (Lag >= this.Count)
				throw new ApplicationException("Lag >= this.Count");
			double mean = this.GetMean();
			double num = 0.0;
			for (int index = Lag; index < this.Count; ++index)
				num += (base[index, 0] - mean) * (base[index - Lag, 0] - mean);
			return num / (double)(this.Count - Lag);
		}

		public double GetAutoCorrelation(int Lag)
		{
			return this.GetAutoCovariance(Lag) / this.GetVariance();
		}

		public Graph GetCorrelogram(int Lag1, int Lag2)
		{
			Graph graph = new Graph();
			for (int Lag = Lag1; Lag <= Lag2; ++Lag)
				graph.Add((double)Lag, this.GetAutoCorrelation(Lag));
			return graph;
		}

		public Graph GetCorrelogram(int Lag)
		{
			return this.GetCorrelogram(Lag, this.Count / 4);
		}

		public virtual DoubleSeries GetReturnSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.name, this.title);
			if (this.Count > 1)
			{
				double num1 = this[0];
				for (int index = 0; index < this.Count; ++index)
				{
					DateTime dateTime = this.GetDateTime(index);
					double num2 = this[index];
					if (num1 != 0.0)
						doubleSeries.Add(dateTime, num2 / num1);
					else
						doubleSeries.Add(dateTime, 0.0);
					num1 = num2;
				}
			}
			return doubleSeries;
		}

		public virtual DoubleSeries GetPercentReturnSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.name, this.title);
			if (this.Count > 1)
			{
				double num1 = this[0];
				for (int index = 0; index < this.Count; ++index)
				{
					DateTime dateTime = this.GetDateTime(index);
					double num2 = this[index];
					if (num1 != 0.0)
						doubleSeries.Add(dateTime, (num2 / num1 - 1.0) * 100.0);
					else
						doubleSeries.Add(dateTime, 0.0);
					num1 = num2;
				}
			}
			return doubleSeries;
		}

		public virtual DoubleSeries GetPositiveSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index] > 0.0)
					doubleSeries.Add(this.GetDateTime(index), this[index]);
			}
			return doubleSeries;
		}

		public virtual DoubleSeries GetNegativeSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index] < 0.0)
					doubleSeries.Add(this.GetDateTime(index), this[index]);
			}
			return doubleSeries;
		}

//		public DoubleSeries Shift(int offset)
//		{
//			DoubleSeries doubleSeries = new DoubleSeries(this.Name, this.Title);
//			int num1 = 0;
//			if (offset < 0)
//				num1 += Math.Abs(offset);
//			for (int index1 = num1; index1 < this.Count; ++index1)
//			{
//				int index2 = index1 + offset;
//				if (index2 < this.Count)
//				{
//					DateTime dateTime = this.GetDateTime(index2);
//					double num2 = this[index1];
//					doubleSeries[dateTime] = num2;
//				}
//				else
//					break;
//			}
//			return doubleSeries;
//		}

		public double Ago(int n)
		{
			int index = this.Count - 1 - n;
			return this[index];
		}

		public bool IsPadRangeX()
		{
			return false;
		}

		public bool IsPadRangeY()
		{
			return this.monitored || this.fAutoZoom;
		}

		public virtual PadRange GetPadRangeX(Pad pad)
		{
			return (PadRange)null;
		}

		public virtual PadRange GetPadRangeY(Pad pad)
		{
			if (this.Count == 0)
				return new PadRange(0.0, 0.0);
			DateTime dateTime1 = new DateTime((long)pad.XMin);
			DateTime dateTime2 = new DateTime((long)pad.XMax);
			return new PadRange(this.GetMin(dateTime1, dateTime2), this.GetMax(dateTime1, dateTime2));
		}

//		public override void Draw(string Option)
//		{
//			if (Chart.Pad == null)
//			{
//				Canvas canvas = new Canvas("CanName", "CanTtile");
//			}
//			if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10372)) != -1)
//				this.fDrawStyle = EDrawStyle.Bar;
//			if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10378)) != -1)
//				this.fDrawStyle = EDrawStyle.Circle;
//			if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10384)) != -1)
//				this.fDrawStyle = EDrawStyle.Line;
//			Chart.Pad.Add((IDrawable)this);
//			Chart.Pad.Title.Add(this.name, this.color);
//			Chart.Pad.Legend.Add(this.name, this.color);
//			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
//			Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10390);
//			if (this.Count <= 0)
//				return;
//			if ((this.LastDateTime - this.FirstDateTime).TotalSeconds / (double)(this.Count - 1) >= 86400.0)
//			{
//				Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10426);
//				this.toolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10450);
//			}
//			else
//			{
//				Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10474);
//				this.toolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10488);
//			}
//			if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10502)) != -1)
//				return;
//			Chart.Pad.SetRange((double)this.FirstDateTime.Ticks, (double)this.LastDateTime.Ticks, this.GetMin(), this.GetMax());
//		}

		public override void Draw()
		{
			this.Draw(String.Empty);
		}

		public virtual void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pen pen1 = new Pen(this.color, (float)this.fDrawWidth);
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
			DateTime dateTime1 = new DateTime((long)XMin);
			DateTime dateTime2 = new DateTime((long)XMax);
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
							pen1 = new Pen(this.secondColor, (float)this.fDrawWidth);
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
							pad.Graphics.FillRectangle((Brush)new SolidBrush(this.color), pad.ClientX(WorldX) - (this.fDrawWidth + 1) / 2, pad.ClientY(WorldY), this.fDrawWidth + 1, pad.ClientY(0.0) - pad.ClientY(WorldY));
						else
							pad.Graphics.FillRectangle((Brush)new SolidBrush(this.color), pad.ClientX(WorldX) - (this.fDrawWidth + 1) / 2, pad.ClientY(0.0), this.fDrawWidth + 1, pad.ClientY(WorldY) - pad.ClientY(0.0));
					}
					break;
				case EDrawStyle.Circle:
					for (int index3 = index1; index3 <= index2; ++index3)
					{
						DateTime dateTime3 = this.GetDateTime(index3);
						double WorldX = (double)dateTime3.Ticks;
						double WorldY = base[index3, 0];
						SolidBrush solidBrush = !(dateTime3 > this.splitDate) ? new SolidBrush(this.color) : new SolidBrush(this.secondColor);
						pad.Graphics.FillEllipse((Brush)solidBrush, pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
					}
					break;
			}
		}

		public virtual TDistance Distance(double X, double Y)
		{
			if (X < 0.0)
				return (TDistance)null;
			TDistance tdistance = new TDistance();
			int index1 = this.GetIndex(new DateTime((long)X), EIndexOption.Next);
			int index2 = this.GetIndex(new DateTime((long)X), EIndexOption.Prev);
			if (index1 != -1)
			{
				DateTime dateTime = this.GetDateTime(index1);
				tdistance.dX = Math.Abs(X - (double)dateTime.Ticks);
				tdistance.dY = Math.Abs(Y - this[dateTime]);
				tdistance.X = (double)dateTime.Ticks;
				tdistance.Y = this[dateTime];
			}
			if (index2 != -1)
			{
				DateTime dateTime = this.GetDateTime(index2);
				double num1 = Math.Abs(X - (double)dateTime.Ticks);
				double num2 = Math.Abs(Y - this[dateTime]);
				if (num1 < tdistance.dX && num2 < tdistance.dY)
				{
					tdistance.dX = num1;
					tdistance.dY = num2;
					tdistance.X = (double)dateTime.Ticks;
					tdistance.Y = this[dateTime];
				}
			}
			if (tdistance.dX == double.MaxValue || tdistance.dY == double.MaxValue)
				return (TDistance)null;
			DateTime dateTime1 = new DateTime((long)tdistance.X);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.toolTipFormat != null && this.toolTipDateTimeFormat != null)
				stringBuilder.AppendFormat(this.toolTipFormat, (object)this.name, (object)this.title, (object)dateTime1.ToString(this.toolTipDateTimeFormat), (object)tdistance.Y);
			tdistance.ToolTipText = ((object)stringBuilder).ToString();
			return tdistance;
		}
	}
}
