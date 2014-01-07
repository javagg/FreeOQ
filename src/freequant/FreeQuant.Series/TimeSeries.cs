using mXqpVnllGuXP6crdfN;
using NEVPmg8vBnJoRISXwf;
using FreeQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Series
{
  [Serializable]
  public class TimeSeries : IEnumerable
  {
    protected internal IDataSeries fArray;
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

    [Description("")]
    [Category("Description")]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fName;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fName = value;
      }
    }

    [Category("Description")]
    [Description("")]
    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle = value;
      }
    }

    [Category("Chart")]
    [Description("")]
    [IndicatorParameter(1000000)]
    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fColor = value;
      }
    }

    [Browsable(false)]
    public virtual int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fArray.Count;
      }
    }

    [Browsable(false)]
    public virtual DateTime FirstDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(360));
        else
          return this.GetDateTime(0);
      }
    }

    [Browsable(false)]
    public virtual DateTime LastDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(406));
        else
          return this.GetDateTime(this.Count - 1);
      }
    }

    [Browsable(false)]
    public virtual DateTime FirstDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FirstDateTime.Date;
      }
    }

    [Browsable(false)]
    public virtual DateTime LastDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LastDateTime.Date;
      }
    }

    [Browsable(false)]
    public virtual int FirstIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return 0;
      }
    }

    [Browsable(false)]
    public virtual int LastIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Count - 1;
      }
    }

    public virtual object First
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(452));
        else
          return this[0];
      }
    }

    public virtual object Last
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(498));
        else
          return this[this.Count - 1];
      }
    }

    [Browsable(false)]
    public virtual int RealCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Count;
      }
    }

    [Browsable(false)]
    public ArrayList Children
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fChildren;
      }
    }

    public IDataSeries DataSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fArray;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fArray = value;
      }
    }

    public virtual object this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fArray[index];
      }
    }

    public virtual double this[int index, int row]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (double) this.fArray[index];
      }
    }

    public virtual double this[int index, BarData barData]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this[index, (int) barData];
      }
    }

    public object this[DateTime dateTime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        int index = this.GetIndex(dateTime);
        if (index != -1)
          return this.fArray[index];
        else
          return (object) null;
      }
    }

    public object this[DateTime dateTime, EIndexOption option]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        int index = this.GetIndex(dateTime, option);
        if (index != -1)
          return this.fArray[index];
        else
          return (object) null;
      }
    }

    public event ItemAddedEventHandler ItemAdded;

    public event EventHandler Cleared;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TimeSeries()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries(string name, string title)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      this.fColor = Color.Black;
      this.fMonitored = true;
      this.fToolTipEnabled = true;
      this.fToolTipFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(544);
      this.fToolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(580);
      this.fChildren = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fName = name;
      this.fTitle = title;
      this.fArray = (IDataSeries) new MemorySeries<object>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries(string name)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector("");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries Clone()
    {
      return this.Clone(0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries Clone(int index1, int index2)
    {
      TimeSeries timeSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as TimeSeries;
      timeSeries.fName = this.fName;
      timeSeries.fTitle = this.fTitle;
      for (int index = index1; index <= index2; ++index)
        timeSeries.Add(this.GetDateTime(index), this[index]);
      return timeSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Clear()
    {
      this.fArray.Clear();
      this.fChanged = true;
      if (this.LsHOoevK6 == null)
        return;
      this.LsHOoevK6((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Contains(DateTime dateTime)
    {
      return this.fArray.Contains(dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Contains(int index)
    {
      return index >= 0 && index <= this.Count - 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime dateTime, object obj)
    {
      if (this.fArray.Contains(dateTime))
        this.fArray.Remove(dateTime);
      this.fArray.Add(dateTime, obj);
      this.fChanged = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(DateTime dateTime)
    {
      this.fArray.Remove(dateTime);
      this.fChanged = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Remove(int index)
    {
      this.fArray.RemoveAt(index);
      this.fChanged = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DateTime GetDateTime(int index)
    {
      return this.fArray.DateTimeAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetIndex(DateTime dateTime)
    {
      return this.GetIndex(dateTime, this.fIndexOption);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin()
    {
      return this.GetMin(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax()
    {
      return this.GetMax(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex()
    {
      return this.GetMinIndex(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex()
    {
      return this.GetMaxIndex(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DateTime GetMinDateTime()
    {
      return this.GetDateTime(this.GetMinIndex());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DateTime GetMaxDateTime()
    {
      return this.GetDateTime(this.GetMaxIndex());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(int index1, int index2)
    {
      return this.GetMin(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(int index1, int index2)
    {
      return this.GetMax(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(int index1, int index2)
    {
      return this.GetMinIndex(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(int index1, int index2)
    {
      return this.GetMaxIndex(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMin(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMax(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMinIndex(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMaxIndex(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(int row)
    {
      return this.GetMin(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(int row)
    {
      return this.GetMax(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(int row)
    {
      return this.GetMinIndex(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(int row)
    {
      return this.GetMaxIndex(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(int index1, int index2, int row)
    {
      return -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(int index1, int index2, int row)
    {
      return -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(604));
      if (dateTime1 > dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(686));
      int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(770));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(824));
      else
        return this.GetMin(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(878));
      if (dateTime1 > dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(960));
      int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1044));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1098));
      else
        return this.GetMax(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1152));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1234));
      int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1318));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1372));
      else
        return this.GetMinIndex(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1426));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1508));
      int index1 = this.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1592));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1646));
      else
        return this.GetMaxIndex(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(BarData barData)
    {
      return this.GetMin((int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(BarData barData)
    {
      return this.GetMax((int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(BarData barData)
    {
      return this.GetMinIndex((int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(BarData barData)
    {
      return this.GetMaxIndex((int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(int index1, int index2, BarData barData)
    {
      return this.GetMin(index1, index2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(int index1, int index2, BarData barData)
    {
      return this.GetMax(index1, index2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(int index1, int index2, BarData barData)
    {
      return this.GetMinIndex(index1, index2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(int index1, int index2, BarData barData)
    {
      return this.GetMaxIndex(index1, index2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMin(DateTime dateTime1, DateTime dateTime2, BarData barData)
    {
      return this.GetMin(dateTime1, dateTime2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMax(DateTime dateTime1, DateTime dateTime2, BarData barData)
    {
      return this.GetMax(dateTime1, dateTime2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2, BarData barData)
    {
      return this.GetMinIndex(dateTime1, dateTime2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2, BarData barData)
    {
      return this.GetMaxIndex(dateTime1, dateTime2, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetSum()
    {
      return this.GetSum(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetSum(int index1, int index2)
    {
      return this.GetSum(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetSum(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetSum(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetSum(int row)
    {
      return this.GetSum(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetSum(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSum(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1700));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1784));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1838));
      else
        return this.GetSum(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMean()
    {
      return this.GetMean(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMean(int index1, int index2)
    {
      return this.GetMean(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMean(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMean(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMean(int row)
    {
      return this.GetMean(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMean(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMean(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1892));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(1974));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2058));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2112));
      else
        return this.GetMean(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMedian()
    {
      return this.GetMedian(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMedian(int index1, int index2)
    {
      return this.GetMedian(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMedian(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMedian(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMedian(int row)
    {
      return this.GetMedian(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMedian(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMedian(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2166));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2248));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2332));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2386));
      else
        return this.GetMedian(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetVariance()
    {
      return this.GetVariance(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetVariance(int index1, int index2)
    {
      return this.GetVariance(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetVariance(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetVariance(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetVariance(int row)
    {
      return this.GetVariance(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetVariance(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetVariance(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2440));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2590));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2674));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2728));
      else
        return this.GetVariance(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveVariance()
    {
      return this.GetPositiveVariance(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveVariance(int index1, int index2)
    {
      return this.GetPositiveVariance(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetPositiveVariance(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveVariance(int row)
    {
      return this.GetPositiveVariance(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveVariance(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2782));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(2932));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3016));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3070));
      else
        return this.GetPositiveVariance(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeVariance()
    {
      return this.GetNegativeVariance(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeVariance(int index1, int index2)
    {
      return this.GetNegativeVariance(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetNegativeVariance(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeVariance(int row)
    {
      return this.GetNegativeVariance(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeVariance(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3124));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3274));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3358));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3412));
      else
        return this.GetNegativeVariance(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetStdDev()
    {
      return Math.Sqrt(this.GetVariance());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetStdDev(int index1, int index2)
    {
      return Math.Sqrt(this.GetVariance(index1, index2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetStdDev(DateTime dateTime1, DateTime dateTime2)
    {
      return Math.Sqrt(this.GetVariance(dateTime1, dateTime2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetStdDev(int row)
    {
      return Math.Sqrt(this.GetVariance(row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetStdDev(int index1, int index2, int row)
    {
      return Math.Sqrt(this.GetVariance(index1, index2, row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetStdDev(DateTime dateTime1, DateTime dateTime2, int row)
    {
      return Math.Sqrt(this.GetVariance(dateTime1, dateTime2, row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveStdDev()
    {
      return Math.Sqrt(this.GetPositiveVariance());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveStdDev(int index1, int index2)
    {
      return Math.Sqrt(this.GetPositiveVariance(index1, index2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2)
    {
      return Math.Sqrt(this.GetPositiveVariance(dateTime1, dateTime2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveStdDev(int row)
    {
      return Math.Sqrt(this.GetPositiveVariance(row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveStdDev(int index1, int index2, int row)
    {
      return Math.Sqrt(this.GetPositiveVariance(index1, index2, row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2, int row)
    {
      return Math.Sqrt(this.GetPositiveVariance(dateTime1, dateTime2, row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeStdDev()
    {
      return Math.Sqrt(this.GetNegativeVariance());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeStdDev(int index1, int index2)
    {
      return Math.Sqrt(this.GetNegativeVariance(index1, index2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2)
    {
      return Math.Sqrt(this.GetNegativeVariance(dateTime1, dateTime2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeStdDev(int row)
    {
      return Math.Sqrt(this.GetNegativeVariance(row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeStdDev(int index1, int index2, int row)
    {
      return Math.Sqrt(this.GetNegativeVariance(index1, index2, row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2, int row)
    {
      return Math.Sqrt(this.GetNegativeVariance(dateTime1, dateTime2, row));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMoment(int k)
    {
      return this.GetMoment(k, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMoment(int k, int index1, int index2)
    {
      return this.GetMoment(k, index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMoment(int k, DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetMoment(k, dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMoment(int k, int row)
    {
      return this.GetMoment(k, 0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetMoment(int k, int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMoment(int k, DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3466));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3556));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3640));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3694));
      else
        return this.GetMoment(k, index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetAsymmetry()
    {
      return this.GetAsymmetry(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetAsymmetry(int index1, int index2)
    {
      return this.GetAsymmetry(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetAsymmetry(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetAsymmetry(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetAsymmetry(int row)
    {
      return this.GetAsymmetry(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetAsymmetry(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAsymmetry(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3748));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3840));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3924));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(3978));
      else
        return this.GetAsymmetry(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExcess()
    {
      return this.GetExcess(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExcess(int index1, int index2)
    {
      return this.GetExcess(index1, index2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExcess(DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetExcess(dateTime1, dateTime2, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExcess(int row)
    {
      return this.GetExcess(0, this.Count - 1, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExcess(int index1, int index2, int row)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetExcess(DateTime dateTime1, DateTime dateTime2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4032));
      if (dateTime1 >= dateTime2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4118));
      int index1 = this.GetIndex(dateTime1);
      int index2 = this.GetIndex(dateTime2);
      if (index1 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4202));
      if (index2 == -1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4256));
      else
        return this.GetExcess(index1, index2, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCovariance(int row1, int row2)
    {
      return this.GetCovariance(row1, row2, 0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCovariance(int row1, int row2, int index1, int index2)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCorrelation(int row1, int row2, int index1, int index2)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCorrelation(int row1, int row2)
    {
      return this.GetCorrelation(row1, row2, 0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCovariance(TimeSeries series)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCorrelation(TimeSeries series)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCovariance(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCorrelation(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries Shift(int offset)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Print()
    {
      for (int index = 0; index < this.Count; ++index)
        Console.WriteLine((string) (object) this.GetDateTime(index) + (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(4310) + (string) this[index]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw(string option)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw(Color color)
    {
      this.fColor = color;
      this.Draw();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw(string option, Color color)
    {
      this.fColor = color;
      this.Draw(option);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(double level, int index, int row)
    {
      if (index <= 0 || index > this.Count - 1)
        return ECross.None;
      if (this[index - 1, row] <= level && this[index, row] > level)
        return ECross.Above;
      return this[index - 1, row] >= level && this[index, row] < level ? ECross.Below : ECross.None;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(double level, int index, BarData barData)
    {
      return this.Crosses(level, index, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(double level, int index)
    {
      return this.Crosses(level, index, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(TimeSeries series, DateTime dateTime, int row)
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(TimeSeries series, DateTime dateTime, BarData barData)
    {
      return this.Crosses(series, dateTime, (int) barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(TimeSeries series, DateTime dateTime)
    {
      return this.Crosses(series, dateTime, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(TimeSeries series, Bar bar, int row)
    {
      return this.Crosses(series, bar.DateTime, row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(TimeSeries series, Bar bar, BarData barData)
    {
      return this.Crosses(series, bar.DateTime, barData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ECross Crosses(TimeSeries series, Bar bar)
    {
      return this.Crosses(series, bar.DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(double level, int index, int row)
    {
      return this.Crosses(level, index, row) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(double level, int index, BarData barData)
    {
      return this.Crosses(level, index, barData) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(double level, int index)
    {
      return this.Crosses(level, index) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(TimeSeries series, DateTime dateTime, int row)
    {
      return this.Crosses(series, dateTime, row) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(TimeSeries series, DateTime dateTime, BarData barData)
    {
      return this.Crosses(series, dateTime, barData) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(TimeSeries series, DateTime dateTime)
    {
      return this.Crosses(series, dateTime) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(TimeSeries series, Bar bar, int row)
    {
      return this.Crosses(series, bar.DateTime, row) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(TimeSeries series, Bar bar, BarData barData)
    {
      return this.Crosses(series, bar.DateTime, barData) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesBelow(TimeSeries series, Bar bar)
    {
      return this.Crosses(series, bar.DateTime) == ECross.Below;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(double level, int index, int row)
    {
      return this.Crosses(level, index, row) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(double level, int index, BarData barData)
    {
      return this.Crosses(level, index, barData) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(double level, int index)
    {
      return this.Crosses(level, index) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(TimeSeries series, DateTime dateTime, int row)
    {
      return this.Crosses(series, dateTime, row) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(TimeSeries series, DateTime dateTime, BarData barData)
    {
      return this.Crosses(series, dateTime, barData) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(TimeSeries series, DateTime dateTime)
    {
      return this.Crosses(series, dateTime) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(TimeSeries series, Bar bar, int row)
    {
      return this.Crosses(series, bar.DateTime, row) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(TimeSeries series, Bar bar, BarData barData)
    {
      return this.Crosses(series, bar.DateTime, barData) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CrossesAbove(TimeSeries series, Bar bar)
    {
      return this.Crosses(series, bar.DateTime) == ECross.Above;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void EmitItemAdded(DateTime dateTime)
    {
      if (this.JQFFlkZRZ == null)
        return;
      this.JQFFlkZRZ((object) this, new DateTimeEventArgs(dateTime));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.fArray.GetEnumerator();
    }
  }
}
