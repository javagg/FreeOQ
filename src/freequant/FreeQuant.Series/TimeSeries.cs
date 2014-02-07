using FreeQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.Series
{
	[Serializable]
	public class TimeSeries : IEnumerable
	{
		protected EIndexOption fIndexOption;
		protected string fName;
		protected string fTitle;
		protected Color fColor;
		protected bool fMonitored;
		protected bool fChanged;
		protected bool fToolTipEnabled;
		protected string fToolTipFormat;
		protected string fToolTipDateTimeFormat;
		protected ArrayList fChildren;

		public static ENameOption fNameOption;

		protected internal IDataSeries fArray = new MemorySeries<object>();

		[Description("")]
		[Category("Description")]
		public string Name
		{
			get
			{
				return this.fName; 
			}
			set
			{
				this.fName = value;
			}
		}

		[Category("Description")]
		[Description("")]
		public string Title
		{
			get
			{
				return this.fTitle; 
			}
			set
			{
				this.fTitle = value;
			}
		}

		[Category("Chart")]
		[Description("")]
		[IndicatorParameter(1000000)]
		public Color Color
		{
			get
			{
				return this.fColor;
			}
			set
			{
				this.fColor = value;
			}
		}

		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				return this.fArray.Count;
			}
		}

		[Browsable(false)]
		public virtual DateTime FirstDateTime
		{
			get
			{
				return this.GetDateTime(0);
			}
		}

		[Browsable(false)]
		public virtual DateTime LastDateTime
		{
			get
			{
				return this.GetDateTime(this.Count-1);
			}
		}

		[Browsable(false)]
		public virtual DateTime FirstDate
		{
			get
			{
				return this.FirstDateTime.Date;
			}
		}

		[Browsable(false)]
		public virtual DateTime LastDate
		{
			get
			{
				return this.LastDateTime.Date;
			}
		}

		[Browsable(false)]
		public virtual int FirstIndex
		{
			get
			{
				return 0;
			}
		}

		[Browsable(false)]
		public virtual int LastIndex
		{
			get
			{
				return this.Count-1;
			}
		}

		public virtual object First
		{
			get
			{
				return this[0];
			}
		}

		public virtual object Last
		{
			get
			{
				return this[this.Count-1];
			}
		}

		[Browsable(false)]
		public virtual int RealCount
		{
			get
			{
				return this.Count;
			}
		}

		[Browsable(false)]
		public ArrayList Children
		{
			get
			{
				return this.fChildren;
			}
		}

		public IDataSeries DataSeries
		{
			get
			{
				return this.fArray;
			}
			set
			{
				this.fArray = value;
			}
		}

		public virtual object this[int index]
		{
			get
			{
				return this.fArray[index];
			}
		}

		public virtual double this[int index, int row]
		{
			get
			{
				return (double)this.fArray[index];
			}
		}

		public virtual double this[int index, BarData barData]
		{
			get
			{
				return this[index, (int)barData];
			}
		}

		public object this[DateTime datetime]
		{
			get
			{
				int index = this.GetIndex(datetime);
				if (index != -1)
					return this.fArray[index];
				else
					return null;
			}
		}

		public object this[DateTime datetime, EIndexOption option]
		{
			get
			{
				int index = this.GetIndex(datetime, option);
				if (index != -1)
					return this.fArray[index];
				else
					return null;
			}
		}

		public event ItemAddedEventHandler ItemAdded;
		public event EventHandler Cleared;

		public TimeSeries(string name, string title)
		{
			this.fColor = Color.Black;
			this.fMonitored = true;
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "";
			this.fToolTipDateTimeFormat = "";
			this.fChildren = new ArrayList();

			this.fName = name;
			this.fTitle = title;
			this.fArray = new MemorySeries<object>();
		}

		public TimeSeries(string name) : this(name, string.Empty)
		{
		}

		public TimeSeries() : this(string.Empty)
		{
		}

		public virtual TimeSeries Clone()
		{
			return this.Clone(0, this.Count - 1);
		}

		public virtual TimeSeries Clone(int index1, int index2)
		{
			TimeSeries ts = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as TimeSeries;
			ts.fName = this.fName;
			ts.fTitle = this.fTitle;
			for (int i = index1; i <= index2; ++i)
			{
				ts.Add(this.GetDateTime(i), this[i]);
			}
			return ts;
		}

		public virtual TimeSeries Clone(DateTime datetime1, DateTime datetime2)
		{
			int index1 = this.GetIndex(datetime1, EIndexOption.Next);
			int index2 = this.GetIndex(datetime2, EIndexOption.Prev);
			if (index1 == -1) index1 = 0;
			if (index2 == -1) index2 = 0;
			return this.Clone(index1, index2);
		}

		public virtual void Clear()
		{
			this.fArray.Clear();
			this.fChanged = true;
			if (this.Cleared != null)
			{
				this.Cleared(this, EventArgs.Empty);
			}
		}

		public virtual bool Contains(DateTime datetime)
		{
			return this.fArray.Contains(datetime);
		}

		public virtual bool Contains(int index)
		{
			return 0 <= index && index <= this.Count - 1;
		}

		public void Add(DateTime datetime, object value)
		{
			if (this.fArray.Contains(datetime))
			{
				this.fArray.Remove(datetime);
			}
			this.fArray.Add(datetime, value);
			this.fChanged = true;
		}

		public void Remove(DateTime datetime)
		{
			this.fArray.Remove(datetime);
			this.fChanged = true;
		}

		public virtual void Remove(int index)
		{
			this.fArray.RemoveAt(index);
			this.fChanged = true;
		}

		public virtual DateTime GetDateTime(int index)
		{
			return this.fArray.DateTimeAt(index);
		}

		public virtual int GetIndex(DateTime datetime)
		{
			return this.GetIndex(datetime, this.fIndexOption);
		}

		public virtual int GetIndex(DateTime datetime, EIndexOption option)
		{
			int index = this.fArray.IndexOf(datetime);
			if (index == -1 && option != EIndexOption.Null)
			{
				switch (option)
				{
					case EIndexOption.Next:
						index = this.fArray.IndexOf(datetime, SearchOption.Next);
						break;
					case EIndexOption.Prev:
						index = this.fArray.IndexOf(datetime, SearchOption.Prev);
						break;
				}
			}
			return index;
		}

		public virtual DateTime GetMinDateTime()
		{
			return this.GetDateTime(this.GetMinIndex());
		}

		public virtual DateTime GetMaxDateTime()
		{
			return this.GetDateTime(this.GetMaxIndex());
		}

		public virtual double GetMin(DateTime datetime1, DateTime datetime2)
		{
			return this.GetMin(datetime1, datetime2, 0);
		}

		public virtual double GetMax(DateTime datetime1, DateTime datetime2)
		{
			return this.GetMax(datetime1, datetime2, 0);
		}

		public virtual int GetMinIndex(DateTime datetime1, DateTime datetime2)
		{
			return this.GetMinIndex(datetime1, datetime2, 0);
		}

		public virtual int GetMaxIndex(DateTime datetime1, DateTime datetime2)
		{
			return this.GetMaxIndex(datetime1, datetime2, 0);
		}

		public virtual double GetMin()
		{
			return this.GetMin(0);
		}

		public virtual double GetMin(int row)
		{
			return this.GetMin(0, this.Count-1, row);
		}

		public virtual double GetMax()
		{
			return this.GetMax(0);
		}

		public virtual double GetMax(int row)
		{
			return this.GetMax(0, this.Count-1, row);
		}

		public virtual int GetMinIndex(int row = 0)
		{
			return this.GetMinIndex(0, this.Count-1, row);
		}

		public virtual int GetMaxIndex(int row = 0)
		{
			return this.GetMaxIndex(0, this.Count - 1, row);
		}

		public virtual double GetMin(int index1, int index2)
		{
			return this.GetMin(index1, index2, 0);
		}

		public virtual double GetMin(int index1, int index2, int row)
		{
			return double.NaN;
		}

		public virtual double GetMax(int index1, int index2)
		{
			return this.GetMax(index1, index2, 0);
		}

		public virtual double GetMax(int index1, int index2, int row)
		{
			return double.NaN;
		}

		public virtual int GetMinIndex(int index1, int index2, int row = 0)
		{
			return -1;
		}

		public virtual int GetMaxIndex(int index1, int index2, int row = 0)
		{
			return -1;
		}

		public virtual double GetMin(DateTime datetime1, DateTime datetime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1, EIndexOption.Next);
			int index2 = this.GetIndex(datetime2, EIndexOption.Prev);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMin(index1, index2, row);
		}

		public virtual double GetMax(DateTime datetime1, DateTime datetime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1, EIndexOption.Next);
			int index2 = this.GetIndex(datetime2, EIndexOption.Prev);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMax(index1, index2, row);
		}

		public virtual int GetMinIndex(DateTime datetime1, DateTime datetime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 >= datetime2)
				throw new ApplicationException("datetime1 >= datetime2");

			int index1 = this.GetIndex(datetime1, EIndexOption.Next);
			int index2 = this.GetIndex(datetime2, EIndexOption.Prev);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMinIndex(index1, index2, row);
		}

		public virtual int GetMaxIndex(DateTime datetime1, DateTime datetime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 >= datetime2)
				throw new ApplicationException("datetime1 >= datetime2");

			int index1 = this.GetIndex(datetime1, EIndexOption.Next);
			int index2 = this.GetIndex(datetime2, EIndexOption.Prev);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMaxIndex(index1, index2, row);
		}

		public virtual double GetMin(BarData barData)
		{
			return this.GetMin((int)barData);
		}

		public virtual double GetMax(BarData barData)
		{
			return this.GetMax((int)barData);
		}

		public virtual int GetMinIndex(BarData barData)
		{
			return this.GetMinIndex((int)barData);
		}

		public virtual int GetMaxIndex(BarData barData)
		{
			return this.GetMaxIndex((int)barData);
		}

		public virtual double GetMin(int index1, int index2, BarData barData)
		{
			return this.GetMin(index1, index2, (int)barData);
		}

		public virtual double GetMax(int index1, int index2, BarData barData)
		{
			return this.GetMax(index1, index2, (int)barData);
		}

		public virtual int GetMinIndex(int index1, int index2, BarData barData)
		{
			return this.GetMinIndex(index1, index2, (int)barData);
		}

		public virtual int GetMaxIndex(int index1, int index2, BarData barData)
		{
			return this.GetMaxIndex(index1, index2, (int)barData);
		}

		public virtual double GetMin(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMin(dateTime1, dateTime2, (int)barData);
		}

		public virtual double GetMax(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMax(dateTime1, dateTime2, (int)barData);
		}

		public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMinIndex(dateTime1, dateTime2, (int)barData);
		}

		public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMaxIndex(dateTime1, dateTime2, (int)barData);
		}

		public virtual double GetSum()
		{
			return this.GetSum(0);
		}

		public virtual double GetSum(int row)
		{
			return this.GetSum(0, this.Count - 1, row);
		}

		public virtual double GetSum(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetSum(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetSum(index1, index2, row);
		}

		public virtual double GetMean()
		{
			return this.GetMean(0);
		}

		public virtual double GetMean(int row)
		{
			return this.GetMean(0, this.Count - 1, row);
		}

		public virtual double GetMean(int index1, int index2)
		{
			return this.GetMean(index1, index2, 0);
		}

		public virtual double GetMean(int index1, int index2, int row)
		{
			return double.NaN;
		}

		public double GetMean(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMean(index1, index2, row);
		}

		public virtual double GetMedian()
		{
			return this.GetMedian(0);
		}

		public virtual double GetMedian(int row)
		{
			return this.GetMedian(0, this.Count - 1, row);
		}

		public virtual double GetMedian(int index1, int index2)
		{
			return this.GetMedian(index1, index2, 0);
		}

		public virtual double GetMedian(int index1, int index2, int row)
		{
			return double.NaN;
		}

		public double GetMedian(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMedian(index1, index2, row);
		}

		public virtual double GetVariance()
		{
			return this.GetVariance(0);
		}

		public virtual double GetVariance(int row)
		{
			return this.GetVariance(0, this.Count - 1, row);
		}

		public virtual double GetVariance(int index1, int index2)
		{
			return this.GetVariance(0, this.Count - 1, 0);
		}

		public virtual double GetVariance(int index1, int index2, int row)
		{
			return double.NaN;
		}

		public virtual double GetVariance(DateTime datetime1, DateTime datetime2)
		{
			return this.GetVariance(datetime1, datetime2, 0);
		}

		public virtual double GetVariance(DateTime datetime1, DateTime datetime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetVariance(index1, index2, row);
		}

		public virtual double GetPositiveVariance(int row = 0)
		{
			return this.GetPositiveVariance(0, this.Count - 1, row);
		}

		public virtual double GetPositiveVariance(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public virtual double GetPositiveVariance(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetPositiveVariance(index1, index2, row);
		}

		public virtual double GetNegativeVariance(int row = 0)
		{
			return this.GetNegativeVariance(0, this.Count - 1, row);
		}

		public virtual double GetNegativeVariance(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public virtual double GetNegativeVariance(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetNegativeVariance(index1, index2, row);
		}

		public virtual double GetStdDev()
		{
			return Math.Sqrt(this.GetVariance());
		}

		public virtual double GetStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetVariance(index1, index2));
		}

		public virtual double GetStdDev(DateTime datetime1, DateTime datetime2)
		{
			return Math.Sqrt(this.GetVariance(datetime1, datetime2));
		}

		public virtual double GetStdDev(int row)
		{
			return Math.Sqrt(this.GetVariance(row));
		}

		public virtual double GetStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetVariance(index1, index2, row));
		}

		public virtual double GetStdDev(DateTime datetime1, DateTime datetime2, int row)
		{
			return Math.Sqrt(this.GetVariance(datetime1, datetime2, row));
		}

		public virtual double GetPositiveStdDev()
		{
			return Math.Sqrt(this.GetPositiveVariance());
		}

		public virtual double GetPositiveStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetPositiveVariance(index1, index2));
		}

		public virtual double GetPositiveStdDev(DateTime datetime1, DateTime datetime2)
		{
			return Math.Sqrt(this.GetPositiveVariance(datetime1, datetime2));
		}

		public virtual double GetPositiveStdDev(int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(row));
		}

		public virtual double GetPositiveStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(index1, index2, row));
		}

		public virtual double GetPositiveStdDev(DateTime datetime1, DateTime datetime2, int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(datetime1, datetime2, row));
		}

		public virtual double GetNegativeStdDev()
		{
			return Math.Sqrt(this.GetNegativeVariance());
		}

		public virtual double GetNegativeStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetNegativeVariance(index1, index2));
		}

		public virtual double GetNegativeStdDev(DateTime datetime1, DateTime datetime2)
		{
			return Math.Sqrt(this.GetNegativeVariance(datetime1, datetime2));
		}

		public virtual double GetNegativeStdDev(int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(row));
		}

		public virtual double GetNegativeStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(index1, index2, row));
		}

		public virtual double GetNegativeStdDev(DateTime datetime1, DateTime datetime2, int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(datetime1, datetime2, row));
		}

		public virtual double GetMoment(int k, int row = 0)
		{
			return this.GetMoment(k, 0, this.Count - 1, row);
		}

		public virtual double GetMoment(int k, int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetMoment(int k, DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");
			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetMoment(k, index1, index2, row);
		}

		public virtual double GetAsymmetry(int row = 0)
		{
			return this.GetAsymmetry(0, this.Count - 1, row);
		}

		public virtual double GetAsymmetry(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetAsymmetry(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count <= 0");
			if (datetime1 >= datetime2)
				throw new ApplicationException("datetime1 >= datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetAsymmetry(index1, index2, row);
		}

		public virtual double GetExcess(int row = 0)
		{
			return this.GetExcess(0, this.Count - 1, row);
		}

		public virtual double GetExcess(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetExcess(DateTime datetime1, DateTime datetime2, int row = 0)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (datetime1 > datetime2)
				throw new ApplicationException("datetime1 > datetime2");

			int index1 = this.GetIndex(datetime1);
			int index2 = this.GetIndex(datetime2);
			if (index1 == -1)
				throw new ApplicationException("index1 == -1");
			if (index2 == -1)
				throw new ApplicationException("index2 == -1");

			return this.GetExcess(index1, index2, row);
		}

		public virtual double GetCovariance(int row1, int row2)
		{
			return this.GetCovariance(row1, row2, 0, this.Count - 1);
		}

		public virtual double GetCovariance(int row1, int row2, int index1, int index2)
		{
			throw new NotSupportedException();
		}

		public virtual double GetCorrelation(int row1, int row2, int index1, int index2)
		{
			throw new NotSupportedException();
		}

		public virtual double GetCorrelation(int row1, int row2)
		{
			return this.GetCorrelation(row1, row2, 0, this.Count - 1);
		}

		public virtual double GetCovariance(TimeSeries series)
		{
			throw new NotSupportedException();
		}

		public virtual double GetCorrelation(TimeSeries series)
		{
			throw new NotSupportedException();
		}

		public virtual double GetCovariance(TimeSeries series, DateTime datetime1, DateTime datetime2)
		{
			throw new NotSupportedException();
		}

		public virtual double GetCorrelation(TimeSeries series, DateTime datetime1, DateTime datetime2)
		{
			throw new NotSupportedException();
		}

		public virtual TimeSeries Shift(int offset)
		{
			throw new NotSupportedException();
		}

		public virtual void Print()
		{
			for (int index = 0; index < this.Count; ++index)
				Console.WriteLine(this.GetDateTime(index) + ": " + this[index]);
		}

		public virtual void Draw()
		{
		}

		public virtual void Draw(string option)
		{
		}

		public virtual void Draw(Color color)
		{
			this.fColor = color;
			this.Draw();
		}

		public virtual void Draw(string option, Color color)
		{
			this.fColor = color;
			this.Draw(option);
		}

		public ECross Crosses(double level, int index, int row = 0)
		{
			if (index <= 0 || index > this.Count - 1) 
			{
				return ECross.None;
			}
			if (this[index-1, row] <= level && this[index, row] > level)
			{
				return ECross.Above;
			}
			if (this[index-1, row] >= level && this[index, row] < level)
			{
				return ECross.Below;
			}
			return ECross.None;
		}

		public ECross Crosses(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, (int)barData);
		}

		public ECross Crosses(TimeSeries series, DateTime datetime, int row = 0)
		{
			int index1 = this.GetIndex(datetime);
			int index2 = series.GetIndex(datetime);
			if (index1 <= 0 || index1 >= this.Count || index2 <= 0 || index2 >= series.Count)
			{
				return ECross.None;
			}

			DateTime dt1 = this.GetDateTime(index1 - 1);
			DateTime dt2 = series.GetDateTime(index2 - 1);
			if (dt1 == dt2)
			{
				if (this[index1-1, row] <= series[index2 - 1, row] && this[index1, row] > series[index2, row])
					return ECross.Above;
				if (this[index1-1, row] >= series[index2 - 1, row] && this[index1, row] < series[index2, row])
					return ECross.Below;
			}
			else
			{
				double num1;
				double num2;
				if (dt1 < dt2)
				{
					DateTime dateTime3 = this.GetDateTime(index1 - 1);
					num1 = this[index1 - 1, row];
					num2 = series.GetIndex(dateTime3, EIndexOption.Next) == index2 ? series[series.GetIndex(dateTime3, EIndexOption.Prev), row] : series[series.GetIndex(dateTime3, EIndexOption.Next), row];
				}
				else
				{
					DateTime dateTime3 = series.GetDateTime(index2 - 1);
					num2 = series[index2 - 1, row];
					num1 = this.GetIndex(dateTime3, EIndexOption.Next) == index1 ? this[this.GetIndex(dateTime3, EIndexOption.Prev), row] : this[this.GetIndex(dateTime3, EIndexOption.Next), row];
				}
				if (num1 <= num2 && this[index1, row] > series[index2, row])
					return ECross.Above;
				if (num1 >= num2 && this[index1, row] < series[index2, row])
					return ECross.Below;
			}
			return ECross.None;
		}

		public ECross Crosses(TimeSeries series, DateTime dateTime, BarData barData)
		{
			return this.Crosses(series, dateTime, (int)barData);
		}

		public ECross Crosses(TimeSeries series, Bar bar, int row)
		{
			return this.Crosses(series, bar.DateTime, row);
		}

		public ECross Crosses(TimeSeries series, Bar bar, BarData barData)
		{
			return this.Crosses(series, bar.DateTime, barData);
		}

		public ECross Crosses(TimeSeries series, Bar bar)
		{
			return this.Crosses(series, bar.DateTime);
		}

		public bool CrossesBelow(double level, int index, int row)
		{
			return this.Crosses(level, index, row) == ECross.Below;
		}

		public bool CrossesBelow(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, barData) == ECross.Below;
		}

		public bool CrossesBelow(double level, int index)
		{
			return this.Crosses(level, index) == ECross.Below;
		}

		public bool CrossesBelow(TimeSeries series, DateTime dateTime, int row)
		{
			return this.Crosses(series, dateTime, row) == ECross.Below;
		}

		public bool CrossesBelow(TimeSeries series, DateTime dateTime, BarData barData)
		{
			return this.Crosses(series, dateTime, barData) == ECross.Below;
		}

		public bool CrossesBelow(TimeSeries series, DateTime dateTime)
		{
			return this.Crosses(series, dateTime) == ECross.Below;
		}

		public bool CrossesBelow(TimeSeries series, Bar bar, int row)
		{
			return this.Crosses(series, bar.DateTime, row) == ECross.Below;
		}

		public bool CrossesBelow(TimeSeries series, Bar bar, BarData barData)
		{
			return this.Crosses(series, bar.DateTime, barData) == ECross.Below;
		}

		public bool CrossesBelow(TimeSeries series, Bar bar)
		{
			return this.Crosses(series, bar.DateTime) == ECross.Below;
		}

		public bool CrossesAbove(double level, int index, int row)
		{
			return this.Crosses(level, index, row) == ECross.Above;
		}

		public bool CrossesAbove(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, barData) == ECross.Above;
		}

		public bool CrossesAbove(double level, int index)
		{
			return this.Crosses(level, index) == ECross.Above;
		}

		public bool CrossesAbove(TimeSeries series, DateTime dateTime, int row)
		{
			return this.Crosses(series, dateTime, row) == ECross.Above;
		}

		public bool CrossesAbove(TimeSeries series, DateTime dateTime, BarData barData)
		{
			return this.Crosses(series, dateTime, barData) == ECross.Above;
		}

		public bool CrossesAbove(TimeSeries series, DateTime dateTime)
		{
			return this.Crosses(series, dateTime) == ECross.Above;
		}

		public bool CrossesAbove(TimeSeries series, Bar bar, int row)
		{
			return this.Crosses(series, bar.DateTime, row) == ECross.Above;
		}

		public bool CrossesAbove(TimeSeries series, Bar bar, BarData barData)
		{
			return this.Crosses(series, bar.DateTime, barData) == ECross.Above;
		}

		public bool CrossesAbove(TimeSeries series, Bar bar)
		{
			return this.Crosses(series, bar.DateTime) == ECross.Above;
		}

		public virtual void EmitItemAdded(DateTime datetime)
		{
			if (this.ItemAdded != null) 
			{
				this.ItemAdded(this, new DateTimeEventArgs(datetime));
			}
		}

		public IEnumerator GetEnumerator()
		{
			return this.fArray.GetEnumerator();
		}
	}
}
