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
		protected EIndexOption indexOption;
		protected string name;
		protected string title;
		protected Color color = Color.Black;
		protected bool monitored = true;
		protected bool changed;
		protected bool toolTipEnabled = true;
		protected string toolTipFormat = "";
		protected string toolTipDateTimeFormat = "";
		protected ArrayList children = new ArrayList();
		public static ENameOption nameOption;

		protected internal IDataSeries fArray = new MemorySeries<object>();

		[Description("")]
		[Category("Description")]
		public string Name { get; set; }

		[Category("Description")]
		[Description("")]
		public string Title
		{
			get
			{
				return this.title; 
			}
			set
			{
				this.title = value;
			}
		}

		[Category("Chart")]
		[Description("")]
		[IndicatorParameter(1000000)]
		public Color Color
		{
			get
			{
				return this.color;
			}
			set
			{
				this.color = value;
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
				return this.GetDateTime(this.Count - 1);
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
				return this.Count - 1;
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
				return this[this.Count - 1];
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
				return this.children;
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
				return this[index, barData];
			}
		}

		public object this[DateTime dateTime]
		{
			get
			{
				int index = this.GetIndex(dateTime);
				if (index != -1)
					return this.fArray[index];
				else
					return null;
			}
		}

		public object this[DateTime dateTime, EIndexOption option]
		{
			get
			{
				int index = this.GetIndex(dateTime, option);
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
			this.name = name;
			this.title = title;
		}

		public TimeSeries(string name) : this(name, String.Empty)
		{
		}

		public virtual TimeSeries Clone()
		{
			return this.Clone(0, this.Count - 1);
		}

		public virtual TimeSeries Clone(int index1, int index2)
		{
			TimeSeries timeSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as TimeSeries;
			timeSeries.name = this.name;
			timeSeries.title = this.title;
			for (int index = index1; index <= index2; ++index)
				timeSeries.Add(this.GetDateTime(index), this[index]);
			return timeSeries;
		}

		public virtual TimeSeries Clone(DateTime dateTime1, DateTime dateTime2)
		{
			int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index1 == -1)
				index1 = 0;
			if (index2 == -1)
				index2 = 0;
			return this.Clone(index1, index2);
		}

		public virtual void Clear()
		{
			this.fArray.Clear();
			this.changed = true;
			if (this.Cleared == null)
				return;
			this.Cleared(this, EventArgs.Empty);
		}

		public virtual bool Contains(DateTime dateTime)
		{
			return this.fArray.Contains(dateTime);
		}

		public virtual bool Contains(int index)
		{
			return index >= 0 && index <= this.Count - 1;
		}

		public void Add(DateTime dateTime, object obj)
		{
			if (this.fArray.Contains(dateTime))
				this.fArray.Remove(dateTime);
			this.fArray.Add(dateTime, obj);
			this.changed = true;
		}

		public void Remove(DateTime dateTime)
		{
			this.fArray.Remove(dateTime);
			this.changed = true;
		}

		public virtual void Remove(int index)
		{
			this.fArray.RemoveAt(index);
			this.changed = true;
		}

		public virtual DateTime GetDateTime(int index)
		{
			return this.fArray.DateTimeAt(index);
		}

		public virtual int GetIndex(DateTime dateTime)
		{
			return this.GetIndex(dateTime, this.indexOption);
		}

		public virtual int GetIndex(DateTime dateTime, EIndexOption option)
		{
			int num = this.fArray.IndexOf(dateTime);
			if (num == -1)
			{
				switch (option)
				{
					case EIndexOption.Next:
						num = this.fArray.IndexOf(dateTime, SearchOption.Next);
						break;
					case EIndexOption.Prev:
						num = this.fArray.IndexOf(dateTime, SearchOption.Prev);
						break;
				}
			}
			return num;
		}

		public virtual DateTime GetMinDateTime()
		{
			return this.GetDateTime(this.GetMinIndex());
		}

		public virtual DateTime GetMaxDateTime()
		{
			return this.GetDateTime(this.GetMaxIndex());
		}

		public virtual double GetMin(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMin(dateTime1, dateTime2, 0);
		}

		public virtual double GetMax(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMax(dateTime1, dateTime2, 0);
		}

		public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMinIndex(dateTime1, dateTime2, 0);
		}

		public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMaxIndex(dateTime1, dateTime2, 0);
		}

		public virtual double GetMin()
		{
			return this.GetMin(0);
		}

		public virtual double GetMin(int row = 0)
		{
			return this.GetMin(0, this.Count - 1, row);
		}

		public virtual double GetMax()
		{
			return this.GetMax(0);
		}

		public virtual double GetMax(int row = 0)
		{
			return this.GetMax(0, this.Count - 1, row);
		}

		public virtual int GetMinIndex(int row = 0)
		{
			return this.GetMinIndex(0, this.Count - 1, row);
		}

		public virtual int GetMaxIndex(int row = 0)
		{
			return this.GetMaxIndex(0, this.Count - 1, row);
		}

		public virtual double GetMin(int index1, int index2)
		{
			return this.GetMin(index1, index2, 0);
		}

		public virtual double GetMin(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public virtual double GetMax(int index1, int index2)
		{
			return this.GetMax(index1, index2, 0);
		}

		public virtual double GetMax(int index1, int index2, int row = 0)
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

		public virtual double GetMin(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (dateTime1 > dateTime2)
				throw new ApplicationException("T1 > T2");
			int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index1 == -1)
				throw new ApplicationException("no such index");
			if (index2 == -1)
				throw new ApplicationException("no such index");
			else
				return this.GetMin(index1, index2, row);
		}

		public virtual double GetMax(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (dateTime1 > dateTime2)
				throw new ApplicationException("T1 > T2");
			int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index1 == -1)
				throw new ApplicationException("no such index");
			if (index2 == -1)
				throw new ApplicationException("no such index");
			else
				return this.GetMax(index1, index2, row);
		}

		public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
				throw new ApplicationException("Count < 0");
			if (dateTime1 >= dateTime2)
				throw new ApplicationException("dateTime1 >= dateTime2");
			int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1318));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1372));
//			else
				return this.GetMinIndex(index1, index2, row);
		}

		public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2, int row)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1426));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1508));
			int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1592));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1646));
//			else
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

		public virtual double GetSum(int row = 0)
		{
			return this.GetSum(0, this.Count - 1, row);
		}

		public virtual double GetSum(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetSum(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1700));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1784));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1838));
//			else
				return this.GetSum(index1, index2, row);
		}

		public virtual double GetMean()
		{
			return this.GetMean(0);
		}

		public virtual double GetMean(int row = 0)
		{
			return this.GetMean(0, this.Count - 1, row);
		}

		public virtual double GetMean(int index1, int index2)
		{
			return this.GetMean(index1, index2, 0);
		}

		public virtual double GetMean(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetMean(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1892));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1974));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2058));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2112));
//			else
				return this.GetMean(index1, index2, row);
		}

		public virtual double GetMedian()
		{
			return this.GetMedian(0);
		}

		public virtual double GetMedian(int row = 0)
		{
			return this.GetMedian(0, this.Count - 1, row);
		}

		public virtual double GetMedian(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetMedian(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2166));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2248));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2332));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2386));
//			else
				return this.GetMedian(index1, index2, row);
		}

		public virtual double GetVariance()
		{
			return this.GetVariance(0);
		}

		public virtual double GetVariance(int row = 0)
		{
			return this.GetVariance(0, this.Count - 1, row);
		}

		public virtual double GetVariance(int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public virtual double GetVariance(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2440));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2590));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2674));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2728));
//			else
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

		public virtual double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3016));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3070));
//			else
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

		public virtual double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3124));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3274));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3358));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3412));
//			else
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

		public virtual double GetStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return Math.Sqrt(this.GetVariance(dateTime1, dateTime2));
		}

		public virtual double GetStdDev(int row)
		{
			return Math.Sqrt(this.GetVariance(row));
		}

		public virtual double GetStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetVariance(index1, index2, row));
		}

		public virtual double GetStdDev(DateTime dateTime1, DateTime dateTime2, int row)
		{
			return Math.Sqrt(this.GetVariance(dateTime1, dateTime2, row));
		}

		public virtual double GetPositiveStdDev()
		{
			return Math.Sqrt(this.GetPositiveVariance());
		}

		public virtual double GetPositiveStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetPositiveVariance(index1, index2));
		}

		public virtual double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return Math.Sqrt(this.GetPositiveVariance(dateTime1, dateTime2));
		}

		public virtual double GetPositiveStdDev(int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(row));
		}

		public virtual double GetPositiveStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(index1, index2, row));
		}

		public virtual double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2, int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(dateTime1, dateTime2, row));
		}

		public virtual double GetNegativeStdDev()
		{
			return Math.Sqrt(this.GetNegativeVariance());
		}

		public virtual double GetNegativeStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetNegativeVariance(index1, index2));
		}

		public virtual double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return Math.Sqrt(this.GetNegativeVariance(dateTime1, dateTime2));
		}

		public virtual double GetNegativeStdDev(int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(row));
		}

		public virtual double GetNegativeStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(index1, index2, row));
		}

		public virtual double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2, int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(dateTime1, dateTime2, row));
		}

		public virtual double GetMoment(int k, int row = 0)
		{
			return this.GetMoment(k, 0, this.Count - 1, row);
		}

		public virtual double GetMoment(int k, int index1, int index2, int row = 0)
		{
			return double.NaN;
		}

		public double GetMoment(int k, DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3466));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3556));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3640));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3694));
//			else
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

		public double GetAsymmetry(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3748));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3840));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3924));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3978));
//			else
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

		public double GetExcess(DateTime dateTime1, DateTime dateTime2, int row = 0)
		{
//			if (this.Count <= 0)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4032));
//			if (dateTime1 >= dateTime2)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4118));
			int index1 = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
//			if (index1 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4202));
//			if (index2 == -1)
//				throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4256));
//			else
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

		public virtual double GetCovariance(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
		{
			throw new NotSupportedException();
		}

		public virtual double GetCorrelation(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
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
			this.color = color;
			this.Draw();
		}

		public virtual void Draw(string option, Color color)
		{
			this.color = color;
			this.Draw(option);
		}

		public ECross Crosses(double level, int index, int row = 0)
		{
			if (index <= 0 || index > this.Count - 1)
				return ECross.None;
			if (this[index - 1, row] <= level && this[index, row] > level)
				return ECross.Above;
			return this[index - 1, row] >= level && this[index, row] < level ? ECross.Below : ECross.None;
		}

		public ECross Crosses(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, (int)barData);
		}

		public ECross Crosses(TimeSeries series, DateTime dateTime, int row = 0)
		{
			int index1 = this.GetIndex(dateTime);
			int index2 = series.GetIndex(dateTime);
			if (index1 <= 0 || index1 >= this.Count || (index2 <= 0 || index2 >= series.Count))
				return ECross.None;
			DateTime dateTime1 = this.GetDateTime(index1 - 1);
			DateTime dateTime2 = series.GetDateTime(index2 - 1);
			if (dateTime1 == dateTime2)
			{
				if (this[index1 - 1, row] <= series[index2 - 1, row] && this[index1, row] > series[index2, row])
					return ECross.Above;
				if (this[index1 - 1, row] >= series[index2 - 1, row] && this[index1, row] < series[index2, row])
					return ECross.Below;
			}
			else
			{
				double num1;
				double num2;
				if (dateTime1 < dateTime2)
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

		public virtual void EmitItemAdded(DateTime dateTime)
		{
			if (this.ItemAdded == null)
				return;
			this.ItemAdded(this, new DateTimeEventArgs(dateTime));
		}

		public IEnumerator GetEnumerator()
		{
			return this.fArray.GetEnumerator();
		}
	}
}
