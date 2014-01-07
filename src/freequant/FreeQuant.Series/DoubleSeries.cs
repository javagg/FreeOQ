using mXqpVnllGuXP6crdfN;
using NEVPmg8vBnJoRISXwf;
using FreeQuant.Charting;
using FreeQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fDrawStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fDrawStyle = value;
      }
    }

    [IndicatorParameter(1000002)]
    [Category("Chart")]
    [Description("")]
    public int DrawWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fDrawWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fDrawWidth = value;
      }
    }

    [Description("")]
    [Category("Zoom")]
    public virtual bool AutoZoom
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAutoZoom;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAutoZoom = value;
      }
    }

    public double First
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4316));
        else
          return this[0];
      }
    }

    public double Last
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4362));
        else
          return this[this.Count - 1];
      }
    }

    public Color SecondColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.secondColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.secondColor = value;
      }
    }

    public DateTime SplitDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.splitDate;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.splitDate = value;
      }
    }

    public double this[int Index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (double) base[Index];
      }
    }

    public double this[DateTime DateTime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = base[DateTime];
        if (obj == null)
          throw new Exception(oK6F3TB73XXXGhdieP.wF6SgrNUO(4408) + (object) DateTime);
        else
          return (double) obj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Add(DateTime, value);
      }
    }

    public double this[DateTime DateTime, EIndexOption Option]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = base[DateTime, Option];
        if (obj != null)
          return (double) obj;
        throw new Exception(oK6F3TB73XXXGhdieP.wF6SgrNUO(4446) + (object) DateTime + oK6F3TB73XXXGhdieP.wF6SgrNUO(4484) + (string) (object) Option + oK6F3TB73XXXGhdieP.wF6SgrNUO(4510));
      }
    }

    public override double this[int Col, int row]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this[Col];
      }
    }

    [Category("ToolTip")]
    [Description("")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipEnabled = value;
      }
    }

    [Description("")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipFormat = value;
      }
    }

    [Category("ToolTip")]
    [Description("")]
    public string ToolTipDateTimeFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipDateTimeFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipDateTimeFormat = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries(string name, string title)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      this.fDrawWidth = 1;
      this.fAutoZoom = true;
      this.fMin = double.NaN;
      this.fMax = double.NaN;
      this.fSum = double.NaN;
      this.fMean = double.NaN;
      this.fMedian = double.NaN;
      this.fVariance = double.NaN;
      this.splitDate = DateTime.MaxValue;
      // ISSUE: explicit constructor call
      base.\u002Ector(name, title);
      this.fArray = (IDataSeries) new MemorySeries<double>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries(string name)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector("");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator +(DoubleSeries series1, DoubleSeries series2)
    {
      if (series1 == null || series2 == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9220));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9290) + series1.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9296) + series2.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9302));
      for (int index = 0; index < series1.Count; ++index)
      {
        DateTime dateTime = series1.GetDateTime(index);
        if (series2.Contains(dateTime))
          doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] + series2[dateTime, EIndexOption.Null]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator -(DoubleSeries series1, DoubleSeries series2)
    {
      if (series1 == null || series2 == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9308));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9378) + series1.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9384) + series2.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9390));
      for (int index = 0; index < series1.Count; ++index)
      {
        DateTime dateTime = series1.GetDateTime(index);
        if (series2.Contains(dateTime))
          doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] - series2[dateTime, EIndexOption.Null]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator *(DoubleSeries series1, DoubleSeries series2)
    {
      if (series1 == null || series2 == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9396));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9466) + series1.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9472) + series2.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9478));
      for (int index = 0; index < series1.Count; ++index)
      {
        DateTime dateTime = series1.GetDateTime(index);
        if (series2.Contains(dateTime))
          doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] * series2[dateTime, EIndexOption.Null]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator /(DoubleSeries series1, DoubleSeries series2)
    {
      if (series1 == null || series2 == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9484));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9554) + series1.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9560) + series2.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9566));
      for (int index = 0; index < series1.Count; ++index)
      {
        DateTime dateTime = series1.GetDateTime(index);
        if (series2.Contains(dateTime) && series2[dateTime] != 0.0)
          doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] / series2[dateTime, EIndexOption.Null]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator +(DoubleSeries series, double Value)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9572));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9642) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9648) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(9654)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(9662));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), ((TimeSeries) series)[index, 0] + Value);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator -(DoubleSeries series, double Value)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9668));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9738) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9744) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(9750)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(9758));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), ((TimeSeries) series)[index, 0] - Value);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator *(DoubleSeries series, double Value)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9764));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9834) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9840) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(9846)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(9854));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), ((TimeSeries) series)[index, 0] * Value);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator /(DoubleSeries series, double Value)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9860));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(9930) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(9936) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(9942)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(9950));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), ((TimeSeries) series)[index, 0] / Value);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator +(double Value, DoubleSeries series)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9956));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(10026) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(10032)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(10040) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10046));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), Value + ((TimeSeries) series)[index, 0]);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator -(double Value, DoubleSeries series)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10052));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(10122) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(10128)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(10136) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10142));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), Value - ((TimeSeries) series)[index, 0]);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator *(double Value, DoubleSeries series)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10148));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(10218) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(10224)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(10232) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10238));
      for (int index = 0; index < series.Count; ++index)
        doubleSeries.Add(series.GetDateTime(index), Value * ((TimeSeries) series)[index, 0]);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DoubleSeries operator /(double Value, DoubleSeries series)
    {
      if (series == null)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(10244));
      DoubleSeries doubleSeries = new DoubleSeries(oK6F3TB73XXXGhdieP.wF6SgrNUO(10314) + Value.ToString(oK6F3TB73XXXGhdieP.wF6SgrNUO(10320)) + oK6F3TB73XXXGhdieP.wF6SgrNUO(10328) + series.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(10334));
      for (int index = 0; index < series.Count; ++index)
      {
        if (((TimeSeries) series)[index, 0] != 0.0)
          doubleSeries.Add(series.GetDateTime(index), Value / ((TimeSeries) series)[index, 0]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Clone()
    {
      return base.Clone() as DoubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Clone(int index1, int index2)
    {
      return base.Clone(index1, index2) as DoubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Clone(DateTime DateTime1, DateTime DateTime2)
    {
      return base.Clone(DateTime1, DateTime2) as DoubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Add(DateTime DateTime, double Data)
    {
      this.fArray[DateTime] = (object) Data;
      this.fChanged = true;
      this.EmitItemAdded(DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMin(int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4516));
      if (this.fChanged)
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMax(int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4598));
      if (this.fChanged)
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMin(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4680));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4762));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4834));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4882));
      double num = double.MaxValue;
      for (int index = index1; index <= index2; ++index)
      {
        if (base[index, row] < num)
          num = base[index, row];
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMax(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(4930));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5012));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5084));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5132));
      double num = double.MinValue;
      for (int index = index1; index <= index2; ++index)
      {
        if (base[index, row] > num)
          num = base[index, row];
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetMinIndex(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5180));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5280));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5352));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5400));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetMaxIndex(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5448));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5548));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5620));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5668));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetSum()
    {
      if (this.fChanged)
      {
        this.fSum = 0.0;
        for (int index = 0; index < this.Count; ++index)
          this.fSum += base[index, 0];
      }
      return this.fSum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetSum(int index1, int index2, int row)
    {
      if (index1 >= index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5716));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5788));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5836));
      double num = 0.0;
      for (int index = index1; index <= index2; ++index)
        num += base[index, row];
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMean()
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5884));
      if (this.fChanged)
        this.fMean = this.GetMean(0, this.Count - 1);
      return this.fMean;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMean(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(5966));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6048));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6120));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6168));
      double num = 0.0;
      for (int index = index1; index <= index2; ++index)
        num += base[index, row];
      return num / (double) (index2 - index1 + 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMedian()
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6216));
      if (this.fChanged)
        this.fMedian = this.GetMedian(0, this.Count - 1);
      return this.fMedian;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMedian(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6302));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6384));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6456));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6504));
      ArrayList arrayList = new ArrayList();
      for (int index = index1; index <= index2; ++index)
        arrayList.Add((object) base[index, row]);
      arrayList.Sort();
      return (double) arrayList[arrayList.Count / 2];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetVariance()
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6552));
      if (this.fChanged)
      {
        double mean = this.GetMean();
        this.fVariance = 0.0;
        for (int index = 0; index < this.Count; ++index)
          this.fVariance += (mean - base[index, 0]) * (mean - base[index, 0]);
        this.fVariance /= (double) (this.Count - 1);
      }
      return this.fVariance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetVariance(int index1, int index2, int row)
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6702));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6852));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6924));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(6972));
      double mean = this.GetMean(index1, index2, row);
      double num = 0.0;
      for (int index = index1; index <= index2; ++index)
        num += (mean - base[index, row]) * (mean - base[index, row]);
      return num / (double) (index2 - index1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetPositiveVariance(int index1, int index2, int row)
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7020));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7170));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7242));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7290));
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
      double num3 = num2 / (double) num1;
      double num4 = 0.0;
      for (int index = index1; index <= index2; ++index)
      {
        if (base[index, row] > 0.0)
          num4 += (num3 - base[index, row]) * (num3 - base[index, row]);
      }
      return num4 / (double) num1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetNegativeVariance(int index1, int index2, int row)
    {
      if (this.Count <= 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7338));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7488));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7560));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7608));
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
      double num3 = num2 / (double) num1;
      double num4 = 0.0;
      for (int index = index1; index <= index2; ++index)
      {
        if (base[index, row] < 0.0)
          num4 += (num3 - base[index, row]) * (num3 - base[index, row]);
      }
      return num4 / (double) num1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMoment(int k, int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7656) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(7730));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7754));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7826));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7874));
      double num1 = k != 1 ? this.GetMean(index1, index2, row) : 0.0;
      int num2 = 0;
      double num3 = 0.0;
      for (int index = index1; index <= index2; ++index)
      {
        num3 += Math.Pow(base[index, row] - num1, (double) k);
        ++num2;
      }
      if (num2 == 0)
        return 0.0;
      else
        return num3 / (double) num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetAsymmetry(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(7922) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(7998));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8022));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8094));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8142));
      double stdDev = this.GetStdDev(index1, index2, row);
      if (stdDev == 0.0)
        return 0.0;
      else
        return this.GetMoment(3, index1, index2, row) / Math.Pow(stdDev, 3.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetExcess(int index1, int index2, int row)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8190) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(8260));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8284));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8356));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8404));
      double stdDev = this.GetStdDev(index1, index2, row);
      if (stdDev == 0.0)
        return 0.0;
      else
        return this.GetMoment(4, index1, index2, row) / Math.Pow(stdDev, 4.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetCovariance(int row1, int row2, int index1, int index2)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8452));
      if (index1 > index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8546));
      if (index1 < 0 || index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8618));
      if (index2 < 0 || index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8666));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetCorrelation(int row1, int row2, int index1, int index2)
    {
      return this.GetCovariance(row1, row2, index1, index2) / (this.GetStdDev(index1, index2, row1) * this.GetStdDev(index1, index2, row2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetCovariance(TimeSeries series)
    {
      return this.GetCovariance(series, this.FirstDateTime, this.LastDateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetCovariance(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
    {
      if (!(series is DoubleSeries))
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8714));
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
          num2 += (this[index3] - mean1) * ((double) series[dateTime] - mean2);
          ++num1;
        }
      }
      if (num1 <= 1.0)
        return 0.0;
      else
        return num2 / (num1 - 1.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetCorrelation(TimeSeries series)
    {
      return this.GetCovariance(series) / (this.GetStdDev() * series.GetStdDev());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetCorrelation(TimeSeries series, DateTime dateTime1, DateTime dateTime2)
    {
      return this.GetCovariance(series, dateTime1, dateTime2) / (this.GetStdDev(dateTime1, dateTime2) * series.GetStdDev(dateTime1, dateTime2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DoubleSeries Log()
    {
      DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
      doubleSeries.fName = oK6F3TB73XXXGhdieP.wF6SgrNUO(8810) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(8822);
      doubleSeries.fTitle = this.fTitle;
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this.GetDateTime(index), Math.Log(base[index, 0]));
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Log10()
    {
      DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
      doubleSeries.fName = oK6F3TB73XXXGhdieP.wF6SgrNUO(8828) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(8844);
      doubleSeries.fTitle = this.fTitle;
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this.GetDateTime(index), Math.Log10(base[index, 0]));
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Sqrt()
    {
      DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
      doubleSeries.fName = oK6F3TB73XXXGhdieP.wF6SgrNUO(8850) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(8864);
      doubleSeries.fTitle = this.fTitle;
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this.GetDateTime(index), Math.Sqrt(base[index, 0]));
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Exp()
    {
      DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
      doubleSeries.fName = oK6F3TB73XXXGhdieP.wF6SgrNUO(8870) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(8882);
      doubleSeries.fTitle = this.fTitle;
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this.GetDateTime(index), Math.Exp(base[index, 0]));
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Pow(double Pow)
    {
      DoubleSeries doubleSeries = this.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
      doubleSeries.Name = oK6F3TB73XXXGhdieP.wF6SgrNUO(8888) + this.fName + oK6F3TB73XXXGhdieP.wF6SgrNUO(8900);
      doubleSeries.Title = this.fTitle;
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this.GetDateTime(index), Math.Pow(base[index, 0], Pow));
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetAutoCovariance(int Lag)
    {
      if (Lag >= this.Count)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(8906));
      double mean = this.GetMean();
      double num = 0.0;
      for (int index = Lag; index < this.Count; ++index)
        num += (base[index, 0] - mean) * (base[index - Lag, 0] - mean);
      return num / (double) (this.Count - Lag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAutoCorrelation(int Lag)
    {
      return this.GetAutoCovariance(Lag) / this.GetVariance();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Graph GetCorrelogram(int Lag1, int Lag2)
    {
      Graph graph = new Graph();
      for (int Lag = Lag1; Lag <= Lag2; ++Lag)
        graph.Add((double) Lag, this.GetAutoCorrelation(Lag));
      return graph;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Graph GetCorrelogram(int Lag)
    {
      return this.GetCorrelogram(Lag, this.Count / 4);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DoubleSeries GetReturnSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + oK6F3TB73XXXGhdieP.wF6SgrNUO(9038));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DoubleSeries GetPercentReturnSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + oK6F3TB73XXXGhdieP.wF6SgrNUO(9060));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries Shift(int offset)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name, this.Title);
      int num1 = 0;
      if (offset < 0)
        num1 += Math.Abs(offset);
      for (int index1 = num1; index1 < this.Count; ++index1)
      {
        int index2 = index1 + offset;
        if (index2 < this.Count)
        {
          DateTime dateTime = this.GetDateTime(index2);
          double num2 = this[index1];
          doubleSeries[dateTime] = num2;
        }
        else
          break;
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Ago(int n)
    {
      int index = this.Count - 1 - n;
      if (index < 0)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(9086) + (object) n + oK6F3TB73XXXGhdieP.wF6SgrNUO(9138));
      else
        return this[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeX()
    {
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeY()
    {
      return this.fMonitored || this.fAutoZoom;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PadRange GetPadRangeX(Pad pad)
    {
      return (PadRange) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PadRange GetPadRangeY(Pad pad)
    {
      if (this.Count == 0)
        return new PadRange(0.0, 0.0);
      DateTime dateTime1 = new DateTime((long) pad.XMin);
      DateTime dateTime2 = new DateTime((long) pad.XMax);
      return new PadRange(this.GetMin(dateTime1, dateTime2), this.GetMax(dateTime1, dateTime2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw(string Option)
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(oK6F3TB73XXXGhdieP.wF6SgrNUO(10340), oK6F3TB73XXXGhdieP.wF6SgrNUO(10356));
      }
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10372)) != -1)
        this.fDrawStyle = EDrawStyle.Bar;
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10378)) != -1)
        this.fDrawStyle = EDrawStyle.Circle;
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10384)) != -1)
        this.fDrawStyle = EDrawStyle.Line;
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.Title.Add(this.fName, this.fColor);
      Chart.Pad.Legend.Add(this.fName, this.fColor);
      Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
      Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10390);
      if (this.Count <= 0)
        return;
      if ((this.LastDateTime - this.FirstDateTime).TotalSeconds / (double) (this.Count - 1) >= 86400.0)
      {
        Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10426);
        this.fToolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10450);
      }
      else
      {
        Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10474);
        this.fToolTipDateTimeFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(10488);
      }
      if (Option.ToLower().IndexOf(oK6F3TB73XXXGhdieP.wF6SgrNUO(10502)) != -1)
        return;
      Chart.Pad.SetRange((double) this.FirstDateTime.Ticks, (double) this.LastDateTime.Ticks, this.GetMin(), this.GetMax());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw()
    {
      this.Draw("");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pen pen1 = new Pen(this.fColor, (float) this.fDrawWidth);
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
      DateTime dateTime1 = new DateTime((long) XMin);
      DateTime dateTime2 = new DateTime((long) XMax);
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
            double num8 = (double) dateTime3.Ticks;
            double num9 = base[index3, 0];
            if (dateTime3 > this.splitDate)
              pen1 = new Pen(this.secondColor, (float) this.fDrawWidth);
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
            double WorldX = (double) dateTime3.Ticks;
            double WorldY = base[index3, 0];
            if (dateTime3 > this.splitDate)
            {
              Pen pen2 = new Pen(this.secondColor, (float) this.fDrawWidth);
            }
            if (WorldY > 0.0)
              pad.Graphics.FillRectangle((Brush) new SolidBrush(this.fColor), pad.ClientX(WorldX) - (this.fDrawWidth + 1) / 2, pad.ClientY(WorldY), this.fDrawWidth + 1, pad.ClientY(0.0) - pad.ClientY(WorldY));
            else
              pad.Graphics.FillRectangle((Brush) new SolidBrush(this.fColor), pad.ClientX(WorldX) - (this.fDrawWidth + 1) / 2, pad.ClientY(0.0), this.fDrawWidth + 1, pad.ClientY(WorldY) - pad.ClientY(0.0));
          }
          break;
        case EDrawStyle.Circle:
          for (int index3 = index1; index3 <= index2; ++index3)
          {
            DateTime dateTime3 = this.GetDateTime(index3);
            double WorldX = (double) dateTime3.Ticks;
            double WorldY = base[index3, 0];
            SolidBrush solidBrush = !(dateTime3 > this.splitDate) ? new SolidBrush(this.fColor) : new SolidBrush(this.secondColor);
            pad.Graphics.FillEllipse((Brush) solidBrush, pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
          }
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TDistance Distance(double X, double Y)
    {
      if (X < 0.0)
        return (TDistance) null;
      TDistance tdistance = new TDistance();
      int index1 = this.GetIndex(new DateTime((long) X), EIndexOption.Next);
      int index2 = this.GetIndex(new DateTime((long) X), EIndexOption.Prev);
      if (index1 != -1)
      {
        DateTime dateTime = this.GetDateTime(index1);
        tdistance.dX = Math.Abs(X - (double) dateTime.Ticks);
        tdistance.dY = Math.Abs(Y - this[dateTime]);
        tdistance.X = (double) dateTime.Ticks;
        tdistance.Y = this[dateTime];
      }
      if (index2 != -1)
      {
        DateTime dateTime = this.GetDateTime(index2);
        double num1 = Math.Abs(X - (double) dateTime.Ticks);
        double num2 = Math.Abs(Y - this[dateTime]);
        if (num1 < tdistance.dX && num2 < tdistance.dY)
        {
          tdistance.dX = num1;
          tdistance.dY = num2;
          tdistance.X = (double) dateTime.Ticks;
          tdistance.Y = this[dateTime];
        }
      }
      if (tdistance.dX == double.MaxValue || tdistance.dY == double.MaxValue)
        return (TDistance) null;
      DateTime dateTime1 = new DateTime((long) tdistance.X);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.fToolTipFormat != null && this.fToolTipDateTimeFormat != null)
        stringBuilder.AppendFormat(this.fToolTipFormat, (object) this.fName, (object) this.fTitle, (object) dateTime1.ToString(this.fToolTipDateTimeFormat), (object) tdistance.Y);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }
  }
}
