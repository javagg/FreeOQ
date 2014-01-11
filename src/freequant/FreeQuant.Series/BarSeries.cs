using FreeQuant.Charting;
using FreeQuant.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace FreeQuant.Series
{
  [Serializable]
  public class BarSeries : DoubleSeries
  {
    private ChartStyle uhdhiePNX;
    private Color OpVNnlGuX;
    private int X6cDrdfNL;
    private EWidthStyle zO38ddk50;
    private int c8Ev5W247;
    private EWidthStyle je6AmJnLt;
    private Color akqmISyaZ;
    private Color uguQD88G4;
    private Color L0hs9FwV4;
    private Color f9xTLL17Y;

    [Description("A bar array can be drawn as bar, candle or line chart")]
    [Category("Chart Style")]
    public ChartStyle ChartStyle
    {
       get
      {
        return this.uhdhiePNX;
      }
       set
      {
        this.uhdhiePNX = value;
      }
    }

    [Description("Bar color")]
    [Category("Bar")]
    public Color BarColor
    {
       get
      {
        return this.OpVNnlGuX;
      }
       set
      {
        this.OpVNnlGuX = value;
      }
    }

    [Category("Bar")]
    [Description("Bar width")]
    public int BarWidth
    {
       get
      {
        return this.X6cDrdfNL;
      }
       set
      {
        this.X6cDrdfNL = value;
      }
    }

    [Description("Bar width style")]
    [Category("Bar")]
    public EWidthStyle BarWidthStyle
    {
       get
      {
        return this.zO38ddk50;
      }
       set
      {
        this.zO38ddk50 = value;
      }
    }

    [Category("Candle")]
    [Description("Candle color")]
    public Color CandleColor
    {
       get
      {
        return this.akqmISyaZ;
      }
       set
      {
        this.akqmISyaZ = value;
      }
    }

    [Description("Black candle color on the chart")]
    [Category("Candle")]
    public Color CandleBlackColor
    {
       get
      {
        return this.uguQD88G4;
      }
       set
      {
        this.uguQD88G4 = value;
      }
    }

    [Category("Candle")]
    [Description("White candle color on the chart")]
    public Color CandleWhiteColor
    {
       get
      {
        return this.L0hs9FwV4;
      }
       set
      {
        this.L0hs9FwV4 = value;
      }
    }

    [Category("Candle")]
    [Description("Candle width")]
    public int CandleWidth
    {
       get
      {
        return this.c8Ev5W247;
      }
       set
      {
        this.c8Ev5W247 = value;
      }
    }

    [Description("Candle width style")]
    [Category("Candle")]
    public EWidthStyle CandleWidthStyle
    {
       get
      {
        return this.je6AmJnLt;
      }
       set
      {
        this.je6AmJnLt = value;
      }
    }

    [Description("Candle border color")]
    [Category("Candle")]
    public Color CandleBorderColor
    {
       get
      {
        return this.f9xTLL17Y;
      }
       set
      {
        this.f9xTLL17Y = value;
      }
    }

    public Bar First
    {
       get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10508));
        else
          return this[0];
      }
    }

    public Bar Last
    {
       get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10554));
        else
          return this[this.Count - 1];
      }
    }

    public Bar this[int i]
    {
       get
      {
        return ((TimeSeries) this)[i] as Bar;
      }
    }

    public Bar this[DateTime DateTime]
    {
       get
      {
        return ((TimeSeries) this)[DateTime] as Bar;
      }
    }

    public Bar this[DateTime DateTime, EIndexOption Option]
    {
       get
      {
        return ((TimeSeries) this)[DateTime, Option] as Bar;
      }
    }

    public override double this[int Index, int BarData]
    {
       get
      {
        return this[Index][BarData];
      }
    }

    public override double this[int Index, BarData BarData]
    {
       get
      {
        return this[Index][BarData];
      }
    }

		public BarSeries(string name, string title) : base(name, title)
    {
      this.uhdhiePNX = ChartStyle.Bar;
      this.OpVNnlGuX = Color.Black;
      this.X6cDrdfNL = 5;
      this.zO38ddk50 = EWidthStyle.Auto;
      this.c8Ev5W247 = 5;
      this.je6AmJnLt = EWidthStyle.Auto;
      this.akqmISyaZ = Color.Black;
      this.uguQD88G4 = Color.Black;
      this.L0hs9FwV4 = Color.White;
      this.f9xTLL17Y = Color.Black;
      this.j3Tk73XXX();
      this.fArray = (IDataSeries) new MemorySeries<Bar>();
    }

    
	public BarSeries(string name) :  this(name, "")
    {
    }

    
	public BarSeries() :  this("")
    {
      this.fName = oK6F3TB73XXXGhdieP.wF6SgrNUO(10766);
    }

    
    private void j3Tk73XXX()
    {
      this.fToolTipEnabled = true;
      this.fToolTipFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10600);
      this.fToolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10724);
    }

    
    public BarSeries Clone()
    {
      return base.Clone() as BarSeries;
    }

    
    public BarSeries Clone(int Index1, int Index2)
    {
      return base.Clone(Index1, Index2) as BarSeries;
    }

    
    public BarSeries Clone(DateTime DateTime1, DateTime DateTime2)
    {
      return base.Clone(DateTime1, DateTime2) as BarSeries;
    }

    
    public bool Contains(Bar Bar)
    {
      return base.Contains(Bar.DateTime);
    }

    
    public void Add(Bar bar)
    {
      this.fArray[bar.DateTime] = (object) bar;
      this.EmitItemAdded(bar.DateTime);
    }

    
    public void Remove(Bar Bar)
    {
      this.fArray.Remove(Bar.DateTime);
    }

    
    public BarSeries Shift(int offset)
    {
      BarSeries barSeries = new BarSeries(this.Name, this.Title);
      int num = 0;
      if (offset < 0)
        num += Math.Abs(offset);
      for (int index1 = num; index1 < this.Count; ++index1)
      {
        int index2 = index1 + offset;
        if (index2 < this.Count)
        {
          DateTime dateTime = this.GetDateTime(index2);
          barSeries.Add(new Bar(this[index1])
          {
            DateTime = dateTime
          });
        }
        else
          break;
      }
      return barSeries;
    }

    
    public Bar Ago(int n)
    {
      int index = this.Count - 1 - n;
      if (index < 0)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10780) + (object) n + oK6F3TB73XXXGhdieP.wF6SgrNUO(10822));
      else
        return this[index];
    }

    
    public DoubleSeries GetArray(BarData BarData)
    {
      return this.GetArray(0, this.Count - 1, BarData);
    }

    
    public DoubleSeries GetArray(int Index1, int Index2, BarData BarData)
    {
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index = Index1; index <= Index2; ++index)
        doubleSeries.Add(this.GetDateTime(index), ((TimeSeries) this)[index, BarData]);
      return doubleSeries;
    }

    
    public DoubleSeries GetArray(DateTime DateTime1, DateTime DateTime2, BarData BarData)
    {
      return this.GetArray(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev), BarData);
    }

    
    public DoubleSeries GetHighSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10896));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].High);
      return doubleSeries;
    }

    
    public DoubleSeries GetLowSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10910));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].Low);
      return doubleSeries;
    }

    
    public DoubleSeries GetOpenSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10922));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].Open);
      return doubleSeries;
    }

    
    public DoubleSeries GetCloseSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10936));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].Close);
      return doubleSeries;
    }

    
    public DoubleSeries GetVolumeSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10952));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, (double) this[index].Volume);
      return doubleSeries;
    }

    
    public DoubleSeries GetOpenIntSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10970));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, (double) this[index].OpenInt);
      return doubleSeries;
    }

    
    public DoubleSeries GetHighSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10990));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].High);
      }
      return doubleSeries;
    }

    
    public DoubleSeries GetLowSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(11004));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].Low);
      }
      return doubleSeries;
    }

    
    public DoubleSeries GetOpenSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(11016));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].Open);
      }
      return doubleSeries;
    }

    
    public DoubleSeries GetCloseSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(11030));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].Close);
      }
      return doubleSeries;
    }

    
    public DoubleSeries GetVolumeSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(11046));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, (double) this[index].Volume);
      }
      return doubleSeries;
    }

    
    public DoubleSeries GetOpenIntSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(11064));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, (double) this[index].OpenInt);
      }
      return doubleSeries;
    }

    
    public Bar HighestHighBar(int Index1, int Index2)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11084));
      if (Index1 > Index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11180));
      if (Index1 < 0 || Index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11252));
      if (Index2 < 0 || Index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11300));
      Bar bar = this[Index1];
      for (int index = Index1 + 1; index <= Index2; ++index)
      {
        if (this[index].High > bar.High)
          bar = this[index];
      }
      return bar;
    }

    
    public Bar HighestHighBar(DateTime DateTime1, DateTime DateTime2)
    {
      return this.HighestHighBar(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev));
    }

    
    public Bar HighestHighBar()
    {
      return this.HighestHighBar(0, this.Count - 1);
    }

    
    public Bar LowestLowBar(int Index1, int Index2)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11348));
      if (Index1 > Index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11440));
      if (Index1 < 0 || Index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11512));
      if (Index2 < 0 || Index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11560));
      Bar bar = this[Index1];
      for (int index = Index1 + 1; index <= Index2; ++index)
      {
        if (this[index].Low < bar.Low)
          bar = this[index];
      }
      return bar;
    }

    
    public Bar LowestLowBar(DateTime DateTime1, DateTime DateTime2)
    {
      return this.LowestLowBar(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev));
    }

    
    public Bar LowestLowBar(int nBars)
    {
      return this.LowestLowBar(this.LastIndex - nBars + 1, this.LastIndex);
    }

    
    public Bar HighestHighBar(int nBars)
    {
      return this.HighestHighBar(this.LastIndex - nBars + 1, this.LastIndex);
    }

    
    public Bar LowestLowBar()
    {
      return this.LowestLowBar(0, this.Count - 1);
    }

    
    public double HighestHigh(int index1, int index2)
    {
      Bar bar = this.HighestHighBar(index1, index2);
      if (bar != null)
        return bar.High;
      else
        return double.NaN;
    }

    
    public double LowestLow(int index1, int index2)
    {
      Bar bar = this.LowestLowBar(index1, index2);
      if (bar != null)
        return bar.Low;
      else
        return double.NaN;
    }

    
    public double HighestHigh(DateTime dateTime1, DateTime dateTime2)
    {
      Bar bar = this.HighestHighBar(dateTime1, dateTime2);
      if (bar != null)
        return bar.High;
      else
        return double.NaN;
    }

    
    public double LowestLow(DateTime dateTime1, DateTime dateTime2)
    {
      Bar bar = this.LowestLowBar(dateTime1, dateTime2);
      if (bar != null)
        return bar.Low;
      else
        return double.NaN;
    }

    
    public double HighestHigh(int nBars)
    {
      Bar bar = this.HighestHighBar(nBars);
      if (bar != null)
        return bar.High;
      else
        return double.NaN;
    }

    
    public double LowestLow(int nBars)
    {
      Bar bar = this.LowestLowBar(nBars);
      if (bar != null)
        return bar.Low;
      else
        return double.NaN;
    }

    
    public double HighestHigh()
    {
      Bar bar = this.HighestHighBar();
      if (bar != null)
        return bar.High;
      else
        return double.NaN;
    }

    
    public double LowestLow()
    {
      Bar bar = this.LowestLowBar();
      if (bar != null)
        return bar.Low;
      else
        return double.NaN;
    }

    
    public override double GetMin(int index1, int index2)
    {
      return this.LowestLowBar(index1, index2).Low;
    }

    
    public override double GetMax(int index1, int index2)
    {
      return this.HighestHighBar(index1, index2).High;
    }

    
    public override double GetMin()
    {
      return this.GetMin(0, this.Count - 1);
    }

    
    public override double GetMax()
    {
      return this.GetMax(0, this.Count - 1);
    }

    
    public double CloseD(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1.AddDays(1.0);
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month && dateTime2.Day == dateTime1.Day)
        return bar.Close;
      else
        return -1.0;
    }

    
    public double CloseW(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1.AddDays((double) (7 - dateTime1.DayOfWeek));
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (((!(dateTime1 <= dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).Subtract(dateTime2).Days <= dateTime1.DayOfWeek ? 1 : 0)) | (!(dateTime1 > dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime1).Days <= 7 - dateTime1.DayOfWeek ? 1 : 0))) != 0)
        return bar.Close;
      else
        return -1.0;
    }

    
    public double CloseM(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      dateTime = dateTime1.AddMonths(1);
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month)
        return bar.Close;
      else
        return -1.0;
    }

    
    public double CloseY(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, 1, 1);
      dateTime = dateTime1.AddYears(1);
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      if (this.GetDateTime(index).Year == dateTime1.Year)
        return bar.Close;
      else
        return -1.0;
    }

    
    public double CloseD(int index, int daysAgo)
    {
      return this.CloseD(this.GetDateTime(index), daysAgo);
    }

    
    public double CloseW(int index, int weeksAgo)
    {
      return this.CloseW(this.GetDateTime(index), weeksAgo);
    }

    
    public double CloseM(int index, int monthsAgo)
    {
      return this.CloseM(this.GetDateTime(index), monthsAgo);
    }

    
    public double CloseY(int index, int yearsAgo)
    {
      return this.CloseY(this.GetDateTime(index), yearsAgo);
    }

    
    public double CloseD(DateTime dateTime, int daysAgo)
    {
      return this.CloseD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double CloseW(DateTime dateTime, int weeksAgo)
    {
      return this.CloseW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double CloseM(DateTime dateTime, int monthsAgo)
    {
      return this.CloseM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double CloseY(DateTime dateTime, int yearsAgo)
    {
      return this.CloseY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    
    public double CloseD(Bar bar, int daysAgo)
    {
      return this.CloseD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double CloseW(Bar bar, int weeksAgo)
    {
      return this.CloseW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double CloseM(Bar bar, int monthsAgo)
    {
      return this.CloseM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double CloseY(Bar bar, int yearsAgo)
    {
      return this.CloseY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -yearsAgo));
    }

    
    public double CloseD(Bar bar)
    {
      return this.CloseD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double CloseW(Bar bar)
    {
      return this.CloseW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double CloseM(Bar bar)
    {
      return this.CloseM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double CloseY(Bar bar)
    {
      return this.CloseY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double OpenD(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1;
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month && dateTime2.Day == dateTime1.Day)
        return bar.Open;
      else
        return -1.0;
    }

    
    public double OpenW(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1.AddDays((double) -(int) dateTime1.DayOfWeek);
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (((!(dateTime1 <= dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).Subtract(dateTime2).Days <= dateTime1.DayOfWeek ? 1 : 0)) | (!(dateTime1 > dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime1).Days <= 7 - dateTime1.DayOfWeek ? 1 : 0))) != 0)
        return bar.Open;
      else
        return -1.0;
    }

    
    public double OpenM(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      dateTime = dateTime1;
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month)
        return bar.Open;
      else
        return -1.0;
    }

    
    public double OpenY(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, 1, 1);
      dateTime = dateTime1;
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      Bar bar = this[index];
      if (this.GetDateTime(index).Year == dateTime1.Year)
        return bar.Open;
      else
        return -1.0;
    }

    
    public double OpenD(int index, int daysAgo)
    {
      return this.OpenD(this.GetDateTime(index), daysAgo);
    }

    
    public double OpenW(int index, int weeksAgo)
    {
      return this.OpenW(this.GetDateTime(index), weeksAgo);
    }

    
    public double OpenM(int index, int monthsAgo)
    {
      return this.OpenM(this.GetDateTime(index), monthsAgo);
    }

    
    public double OpenY(int index, int yearsAgo)
    {
      return this.OpenY(this.GetDateTime(index), yearsAgo);
    }

    
    public double OpenD(DateTime dateTime, int daysAgo)
    {
      return this.OpenD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double OpenW(DateTime dateTime, int weeksAgo)
    {
      return this.OpenW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double OpenM(DateTime dateTime, int monthsAgo)
    {
      return this.OpenM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double OpenY(DateTime dateTime, int yearsAgo)
    {
      return this.OpenY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    
    public double OpenD(Bar bar, int daysAgo)
    {
      return this.OpenD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double OpenW(Bar bar, int weeksAgo)
    {
      return this.OpenW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double OpenM(Bar bar, int monthsAgo)
    {
      return this.OpenM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double OpenY(Bar bar, int yearsAgo)
    {
      return this.OpenY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -yearsAgo));
    }

    
    public double OpenD(Bar bar)
    {
      return this.OpenD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double OpenW(Bar bar)
    {
      return this.OpenW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double OpenM(Bar bar)
    {
      return this.OpenM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double OpenY(Bar bar)
    {
      return this.OpenY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double HighD(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
      Bar bar = this.HighestHighBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.High;
      else
        return -1.0;
    }

    
    public double HighW(DateTime dateTime)
    {
      DateTime DateTime1 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
      DateTime DateTime2 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
      Bar bar = this.HighestHighBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.High;
      else
        return -1.0;
    }

    
    public double HighM(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
      Bar bar = this.HighestHighBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.High;
      else
        return -1.0;
    }

    
    public double HighY(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, 1, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
      Bar bar = this.HighestHighBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.High;
      else
        return -1.0;
    }

    
    public double HighD(int index, int daysAgo)
    {
      return this.HighD(this.GetDateTime(index), daysAgo);
    }

    
    public double HighW(int index, int weeksAgo)
    {
      return this.HighW(this.GetDateTime(index), weeksAgo);
    }

    
    public double HighM(int index, int monthsAgo)
    {
      return this.HighM(this.GetDateTime(index), monthsAgo);
    }

    
    public double HighY(int index, int yearsAgo)
    {
      return this.HighY(this.GetDateTime(index), yearsAgo);
    }

    
    public double HighD(DateTime dateTime, int daysAgo)
    {
      return this.HighD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double HighW(DateTime dateTime, int weeksAgo)
    {
      return this.HighW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double HighM(DateTime dateTime, int monthsAgo)
    {
      return this.HighM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double HighY(DateTime dateTime, int yearsAgo)
    {
      return this.HighY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    
    public double HighD(Bar bar, int daysAgo)
    {
      return this.HighD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double HighW(Bar bar, int weeksAgo)
    {
      return this.HighW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double HighM(Bar bar, int monthsAgo)
    {
      return this.HighM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double HighY(Bar bar, int yearsAgo)
    {
      return this.HighY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -yearsAgo));
    }

    
    public double HighD(Bar bar)
    {
      return this.HighD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double HighW(Bar bar)
    {
      return this.HighW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double HighM(Bar bar)
    {
      return this.HighM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double HighY(Bar bar)
    {
      return this.HighY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double LowD(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
      Bar bar = this.LowestLowBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.Low;
      else
        return -1.0;
    }

    
    public double LowW(DateTime dateTime)
    {
      DateTime DateTime1 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
      DateTime DateTime2 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
      Bar bar = this.LowestLowBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.Low;
      else
        return -1.0;
    }

    
    public double LowM(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
      Bar bar = this.LowestLowBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.Low;
      else
        return -1.0;
    }

    
    public double LowY(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, 1, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
      Bar bar = this.LowestLowBar(DateTime1, DateTime2);
      if (bar.DateTime >= DateTime1 && bar.DateTime <= DateTime2)
        return bar.Low;
      else
        return -1.0;
    }

    
    public double LowD(int index, int daysAgo)
    {
      return this.LowD(this.GetDateTime(index), daysAgo);
    }

    
    public double LowW(int index, int weeksAgo)
    {
      return this.LowW(this.GetDateTime(index), weeksAgo);
    }

    
    public double LowM(int index, int monthsAgo)
    {
      return this.LowM(this.GetDateTime(index), monthsAgo);
    }

    
    public double LowY(int index, int yearsAgo)
    {
      return this.LowY(this.GetDateTime(index), yearsAgo);
    }

    
    public double LowD(DateTime dateTime, int daysAgo)
    {
      return this.LowD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double LowW(DateTime dateTime, int weeksAgo)
    {
      return this.LowW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double LowM(DateTime dateTime, int monthsAgo)
    {
      return this.LowM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double LowY(DateTime dateTime, int yearsAgo)
    {
      return this.LowY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    
    public double LowD(Bar bar, int daysAgo)
    {
      return this.LowD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -daysAgo));
    }

    
    public double LowW(Bar bar, int weeksAgo)
    {
      return this.LowW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    
    public double LowM(Bar bar, int monthsAgo)
    {
      return this.LowM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
    }

    
    public double LowY(Bar bar, int yearsAgo)
    {
      return this.LowY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double) -yearsAgo));
    }

    
    public double LowD(Bar bar)
    {
      return this.LowD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double LowW(Bar bar)
    {
      return this.LowW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double LowM(Bar bar)
    {
      return this.LowM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public double LowY(Bar bar)
    {
      return this.LowY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
    }

    
    public virtual BarSeries Compress(long NewBarSize)
    {
      BarSeries barSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as BarSeries;
      if (this.Count <= 0)
        return barSeries;
      long size = this[0].Size;
      if (NewBarSize < size)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11608));
      long result;
      Math.DivRem(NewBarSize, size, out result);
      if (result != 0L)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11728));
      if (NewBarSize == size)
        return this;
      double num1 = 0.0;
      double num2 = 0.0;
      double open = 0.0;
      double close = 0.0;
      long volume = 0L;
      long num3 = 0L;
      bool flag = true;
      int index1 = 0;
      while (flag)
      {
        DateTime dateTime1 = this[index1].DateTime;
        DateTime datetime;
        DateTime dateTime2;
        switch (NewBarSize)
        {
          case 604800L:
            datetime = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).AddDays((double) (-(int) (6 + dateTime1.DayOfWeek) % 7));
            dateTime2 = datetime.AddDays(7.0);
            break;
          case 2419200L:
            datetime = new DateTime(dateTime1.Year, dateTime1.Month, 1);
            dateTime2 = datetime.AddMonths(1);
            break;
          case 29030400L:
            datetime = new DateTime(dateTime1.Year, 1, 1);
            dateTime2 = datetime.AddYears(1);
            break;
          default:
            datetime = new DateTime(dateTime1.Ticks / (10000000L * NewBarSize) * (10000000L * NewBarSize));
            dateTime2 = datetime.AddSeconds((double) NewBarSize);
            break;
        }
        int index2 = this.GetIndex(dateTime2.AddTicks(-1L), EIndexOption.Prev);
        Bar bar = (Bar) null;
        for (int index3 = index1; index3 <= index2; ++index3)
        {
          bar = this[index3];
          if (index3 == index1)
          {
            num1 = bar.High;
            num2 = bar.Low;
            open = bar.Open;
            close = bar.Close;
            volume = bar.Volume;
            num3 = bar.OpenInt;
          }
          else
          {
            num1 = Math.Max(num1, bar.High);
            num2 = Math.Min(num2, bar.Low);
            close = bar.Close;
            volume += bar.Volume;
            num3 += bar.OpenInt;
          }
        }
        if (bar != null)
          barSeries.Add(new Bar(datetime, open, num1, num2, close, volume, (dateTime2 - datetime).Ticks / 10000000L)
          {
            OpenInt = num3
          });
        else
          flag = false;
        index1 = index2 + 1;
        if (index1 > this.Count - 1)
          flag = false;
      }
      return barSeries;
    }

    
    public virtual BarSeries Compress(long newBarSize, TimeSpan sessionStart, TimeSpan sessionEnd)
    {
      return this.Compress(newBarSize, sessionStart, sessionEnd, BarSlycing.Equally);
    }

    
    public virtual BarSeries Compress(long newBarSize, TimeSpan sessionStart, TimeSpan sessionEnd, BarSlycing mode)
    {
      return this.Compress(newBarSize, sessionStart, sessionEnd, mode, true, true);
    }

    
    public virtual BarSeries Compress(long newBarSize, TimeSpan sessionStart, TimeSpan sessionEnd, BarSlycing mode, bool weeklySlicingEnabled, bool clubWithPrevBar)
    {
      BarSeries barSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as BarSeries;
      if (this.Count <= 0)
        return barSeries;
      long size = this[0].Size;
      if (newBarSize < size)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11848));
      if (sessionStart >= sessionEnd)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(11968));
      long result;
      Math.DivRem(newBarSize, size, out result);
      if (result != 0L)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12074));
      if (newBarSize == size)
        return this;
      double num1 = 0.0;
      double num2 = 0.0;
      double open = 0.0;
      double close = 0.0;
      long volume = 0L;
      long num3 = 0L;
      bool flag1 = true;
      DateTime datetime = this[0].DateTime.Date.Add(sessionStart);
      DateTime index1 = DateTime.MaxValue;
      long ticks1 = (sessionEnd - sessionStart).Ticks;
      int num4 = 0;
      bool flag2 = false;
      while (flag1)
      {
        if (flag2)
        {
          datetime = index1.AddDays(2.0).Date.Add(sessionStart);
          flag2 = false;
        }
        index1 = datetime.AddSeconds((double) newBarSize);
        DateTime dateTime = datetime.Date.Add(sessionEnd);
        if (index1 > dateTime)
        {
          long ticks2 = (index1 - dateTime).Ticks;
          index1 = datetime.Date.AddDays(1.0).Add(sessionStart);
          if (mode == BarSlycing.Equally)
          {
            index1 = index1.AddDays((double) (ticks2 / ticks1));
            index1 = index1.AddTicks(ticks2 % ticks1);
          }
          if (this.LastDateTime > index1)
          {
            DateTime date = this[index1, EIndexOption.Next].DateTime.Date;
            while (index1 < date && (index1.DayOfWeek != DayOfWeek.Saturday || !weeklySlicingEnabled))
              index1 = index1.AddDays(1.0);
            if (index1.DayOfWeek == DayOfWeek.Saturday && weeklySlicingEnabled)
              flag2 = true;
          }
        }
        int index2 = this.GetIndex(index1.AddTicks(-1L), EIndexOption.Prev);
        Bar bar1 = (Bar) null;
        for (int index3 = num4; index3 <= index2; ++index3)
        {
          bar1 = this[index3];
          if (index3 == num4)
          {
            num1 = bar1.High;
            num2 = bar1.Low;
            open = bar1.Open;
            close = bar1.Close;
            volume = bar1.Volume;
            num3 = bar1.OpenInt;
          }
          else
          {
            num1 = Math.Max(num1, bar1.High);
            num2 = Math.Min(num2, bar1.Low);
            close = bar1.Close;
            volume += bar1.Volume;
            num3 += bar1.OpenInt;
          }
        }
        if (bar1 != null)
        {
          Bar bar2 = new Bar(datetime, open, num1, num2, close, volume, newBarSize);
          bar2.EndTime = !flag2 ? index1 : index1.Date.AddDays(-1.0).Add(sessionEnd);
          if (mode == BarSlycing.Normal && index1 > dateTime)
            bar2.EndTime = dateTime;
          bar2.OpenInt = num3;
          if (flag2 && clubWithPrevBar && (bar2.Duration.TotalSeconds * 2.0 < (double) newBarSize && barSeries.Count > 0))
          {
            Bar last = barSeries.Last;
            bar2.Open = last.Open;
            bar2.High = Math.Max(bar2.High, last.High);
            bar2.Low = Math.Min(bar2.Low, last.Low);
            bar2.Volume += last.Volume;
            bar2.OpenInt += last.OpenInt;
            bar2.DateTime = last.BeginTime;
          }
          barSeries.Add(bar2);
        }
        num4 = index2 + 1;
        if (num4 > this.Count - 1)
          flag1 = false;
        datetime = index1;
      }
      return barSeries;
    }

    
    public override PadRange GetPadRangeX(Pad pad)
    {
      return (PadRange) null;
    }

    
    public override PadRange GetPadRangeY(Pad pad)
    {
      double min = 0.0;
      double max = 0.0;
      DateTime dateTime1 = new DateTime((long) pad.XMin);
      DateTime dateTime2 = new DateTime((long) pad.XMax);
      Bar bar1 = this.LowestLowBar(dateTime1, dateTime2);
      if (bar1 != null)
        min = bar1.Low;
      if (min == 0.0)
        min = this.GetMin(dateTime1, dateTime2, BarData.Close);
      if (min == 0.0)
        min = this.GetMin(dateTime1, dateTime2, BarData.Open);
      Bar bar2 = this.HighestHighBar(dateTime1, dateTime2);
      if (bar2 != null)
        max = bar2.High;
      if (max == 0.0)
        max = this.GetMax(dateTime1, dateTime2, BarData.Close);
      if (max == 0.0)
        max = this.GetMax(dateTime1, dateTime2, BarData.Open);
      return new PadRange(min, max);
    }

    
    public override void Draw(string Option)
    {
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(12194)) != -1)
        this.uhdhiePNX = ChartStyle.Candle;
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(12200)) != -1)
        this.uhdhiePNX = ChartStyle.Bar;
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(12206)) != -1)
        this.uhdhiePNX = ChartStyle.Line;
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(12212)) == -1 && this.Count > 0)
        Chart.Pad.SetRange((double) this.FirstDateTime.Ticks, (double) (this.LastDateTime.Ticks + this.Last.EndTime.Ticks - this.Last.BeginTime.Ticks), this.LowestLowBar().Low, this.HighestHighBar().High);
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(oK6F3TB73XXXGhdieP.wF6SgrNUO(12218), oK6F3TB73XXXGhdieP.wF6SgrNUO(12234));
      }
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.Title.Add(this.fName, this.fColor);
      Chart.Pad.Legend.Add(this.fName, this.fColor);
      Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
      if (Chart.Pad.AxisBottom.LabelFormat == "")
      {
        Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(12250);
      }
      else
      {
        if (this.Count <= 0)
          return;
        if ((this.LastDateTime - this.FirstDateTime).TotalSeconds / (double) this.Count >= 86400.0)
        {
          Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(12286);
          this.fToolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(12310);
        }
        else
        {
          Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(12334);
          this.fToolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(12348);
        }
      }
    }

    
    public override void Draw()
    {
      this.Draw("");
    }

    
    public override void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pen pen1 = new Pen(this.fColor);
      Pen pen2 = new Pen(this.OpVNnlGuX);
      Pen pen3 = new Pen(this.akqmISyaZ);
      Pen pen4 = new Pen(this.f9xTLL17Y);
      Brush brush1 = (Brush) new SolidBrush(this.L0hs9FwV4);
      Brush brush2 = (Brush) new SolidBrush(this.uguQD88G4);
      int num1 = 0;
      double num2 = 0.0;
      double num3 = 0.0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int x2 = 0;
      long num7 = 0L;
      long num8 = 0L;
      int num9 = 0;
      int num10 = 0;
      DateTime dateTime1 = new DateTime((long) XMin);
      DateTime dateTime2 = new DateTime((long) XMax);
      int num11 = !(dateTime1 < this.FirstDateTime) ? this.GetIndex(dateTime1, EIndexOption.Prev) : 0;
      int num12 = !(dateTime2 > this.LastDateTime) ? this.GetIndex(dateTime2, EIndexOption.Next) : this.Count - 1;
      if (num11 == -1 || num12 == -1)
        return;
      for (int index = num11; index <= num12; ++index)
      {
        Bar bar = this[index];
        long num13 = bar.BeginTime.Ticks;
        long num14 = bar.EndTime.Ticks;
        double num15 = (double) (num13 + (num14 - num13) / 2L);
        int num16 = pad.ClientX(num15);
        double high = bar.High;
        double low = bar.Low;
        double open = bar.Open;
        double close = bar.Close;
        Pen pen5 = pen2;
        if (bar.Color != Color.Empty)
          pen5 = new Pen(bar.Color);
        switch (this.uhdhiePNX)
        {
          case ChartStyle.Line:
            double num17 = close;
            if (num1 != 0)
            {
              num13 = (long) pad.ClientX(num2);
              num4 = pad.ClientY(num3);
              num14 = (long) pad.ClientX(num15);
              num5 = pad.ClientY(num17);
              if ((pad.IsInRange(num15, num17) || pad.IsInRange(num2, num3)) && (num13 != num7 || num14 != num8 || (num4 != num9 || num5 != num10)))
                pad.Graphics.DrawLine(pen1, (float) num13, (float) num4, (float) num14, (float) num5);
            }
            num7 = num13;
            num9 = num4;
            num8 = num14;
            num10 = num5;
            num2 = num15;
            num3 = num17;
            ++num1;
            break;
          case ChartStyle.Bar:
            switch (this.zO38ddk50)
            {
              case EWidthStyle.Pixel:
                num6 = pad.ClientX(num15) - this.X6cDrdfNL / 2;
                x2 = pad.ClientX(num15) + this.X6cDrdfNL / 2;
                break;
              case EWidthStyle.DateTime:
                num6 = pad.ClientX(num15 - (double) ((long) this.X6cDrdfNL * 10000000L / 2L));
                x2 = pad.ClientX(num15 + (double) ((long) this.X6cDrdfNL * 10000000L / 2L));
                break;
              case EWidthStyle.Auto:
                num6 = pad.ClientX((double) num13);
                x2 = pad.ClientX((double) num14);
                break;
            }
            pad.Graphics.DrawLine(pen5, num16, pad.ClientY(low), num16, pad.ClientY(high));
            if (open != 0.0)
              pad.Graphics.DrawLine(pen5, num16, pad.ClientY(open), num6, pad.ClientY(open));
            if (close != 0.0)
            {
              pad.Graphics.DrawLine(pen5, num16, pad.ClientY(close), x2, pad.ClientY(close));
              break;
            }
            else
              break;
          case ChartStyle.Candle:
            switch (this.je6AmJnLt)
            {
              case EWidthStyle.Pixel:
                num6 = pad.ClientX(num15) - this.c8Ev5W247 / 2;
                x2 = pad.ClientX(num15) + this.c8Ev5W247 / 2;
                break;
              case EWidthStyle.DateTime:
                num6 = pad.ClientX(num15 - (double) ((long) this.c8Ev5W247 * 10000000L / 2L));
                x2 = pad.ClientX(num15 + (double) ((long) this.c8Ev5W247 * 10000000L / 2L));
                break;
              case EWidthStyle.Auto:
                num6 = pad.ClientX((double) num13);
                x2 = pad.ClientX((double) num14);
                break;
            }
            pad.Graphics.DrawLine(pen3, num16, pad.ClientY(low), num16, pad.ClientY(high));
            if (open != 0.0 && close != 0.0)
            {
              if (open > close)
              {
                int width = x2 - num6;
                int height = pad.ClientY(close) - pad.ClientY(open);
                if (height == 0)
                  height = 1;
                pad.Graphics.FillRectangle(brush2, num6, pad.ClientY(open), width, height);
                break;
              }
              else
              {
                int width = x2 - num6;
                int height = pad.ClientY(open) - pad.ClientY(close);
                if (height == 0)
                  height = 1;
                if (pad.ForeColor == this.L0hs9FwV4)
                {
                  pad.Graphics.DrawRectangle(pen4, num6, pad.ClientY(close), width, height);
                  pad.Graphics.FillRectangle(brush1, num6 + 1, pad.ClientY(close) + 1, width - 2, height - 1);
                  break;
                }
                else
                {
                  pad.Graphics.FillRectangle(brush1, num6, pad.ClientY(close), width, height);
                  break;
                }
              }
            }
            else
              break;
        }
      }
    }

    
    public override TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      int index = this.GetIndex(new DateTime((long) X), EIndexOption.Prev);
      if (index == -1)
        return (TDistance) null;
      Bar bar = this[index];
      tdistance.dX = X < (double) bar.DateTime.Ticks || X > (double) (bar.DateTime.Ticks + bar.Size * 10000000L) ? double.MaxValue : 0.0;
      tdistance.dY = Y > bar.High || Y < bar.Low ? double.MaxValue : 0.0;
      tdistance.X = (double) bar.DateTime.Ticks;
      tdistance.Y = bar.Close;
      if (tdistance.dX == double.MaxValue || tdistance.dY == double.MaxValue)
        return (TDistance) null;
      DateTime dateTime = new DateTime((long) tdistance.X);
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.fToolTipFormat, (object) this.fName, (object) this.fTitle, (object) bar.DateTime.ToString(this.fToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }
  }
}
