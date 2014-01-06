// Type: SmartQuant.Series.PnFSeries
// Assembly: SmartQuant.Series, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: E9488B3A-52DD-4064-9514-4FAD9D0B10AA
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Series.dll

using mXqpVnllGuXP6crdfN;
using NEVPmg8vBnJoRISXwf;
using SmartQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Series
{
  public class PnFSeries : DoubleSeries
  {
    public PnF First
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12398));
        else
          return this[0];
      }
    }

    public PnF Last
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12444));
        else
          return this[this.Count - 1];
      }
    }

    public PnF this[int i]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ((TimeSeries) this)[i] as PnF;
      }
    }

    public PnF this[DateTime DateTime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ((TimeSeries) this)[DateTime] as PnF;
      }
    }

    public PnF this[DateTime DateTime, EIndexOption Option]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ((TimeSeries) this)[DateTime, Option] as PnF;
      }
    }

    public override double this[int Index, int BarData]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this[Index][BarData];
      }
    }

    public override double this[int Index, BarData BarData]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this[Index][BarData];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries(string name, string title)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, title);
      this.fArray = (IDataSeries) new MemorySeries<PnF>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries(string name)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector(oK6F3TB73XXXGhdieP.wF6SgrNUO(12362));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries Clone()
    {
      return base.Clone() as PnFSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries Clone(int Index1, int Index2)
    {
      return base.Clone(Index1, Index2) as PnFSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries Clone(DateTime DateTime1, DateTime DateTime2)
    {
      return base.Clone(DateTime1, DateTime2) as PnFSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(PnF PnF)
    {
      return base.Contains(PnF.DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(PnF pnF)
    {
      this.fArray[pnF.DateTime] = (object) pnF;
      this.EmitItemAdded(pnF.DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(PnF PnF)
    {
      this.fArray.Remove(PnF.DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFSeries Shift(int offset)
    {
      PnFSeries pnFseries = new PnFSeries(this.Name, this.Title);
      int num = 0;
      if (offset < 0)
        num += Math.Abs(offset);
      for (int index1 = num; index1 < this.Count; ++index1)
      {
        int index2 = index1 + offset;
        if (index2 < this.Count)
        {
          DateTime dateTime = this.GetDateTime(index2);
          pnFseries.Add(new PnF(this[index1])
          {
            DateTime = dateTime
          });
        }
        else
          break;
      }
      return pnFseries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF Ago(int n)
    {
      int index = this.Count - 1 - n;
      if (index < 0)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12490) + (object) n + oK6F3TB73XXXGhdieP.wF6SgrNUO(12532));
      else
        return this[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetArray(BarData BarData)
    {
      return this.GetArray(0, this.Count - 1, BarData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetArray(int Index1, int Index2, BarData BarData)
    {
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index = Index1; index <= Index2; ++index)
        doubleSeries.Add(this.GetDateTime(index), ((TimeSeries) this)[index, BarData]);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetArray(DateTime DateTime1, DateTime DateTime2, BarData BarData)
    {
      return this.GetArray(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev), BarData);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetHighSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12606));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].High);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetLowSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12620));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].Low);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetOpenSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12632));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].Open);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetCloseSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12646));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, this[index].Close);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetVolumeSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12662));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, (double) this[index].Volume);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetOpenIntSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12680));
      for (int index = 0; index < this.Count; ++index)
        doubleSeries.Add(this[index].DateTime, (double) this[index].OpenInt);
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetHighSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12700));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].High);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetLowSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12714));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].Low);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetOpenSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12726));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].Open);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetCloseSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12740));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, this[index].Close);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetVolumeSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12756));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, (double) this[index].Volume);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleSeries GetOpenIntSeries(DateTime date1, DateTime date2)
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.Name + oK6F3TB73XXXGhdieP.wF6SgrNUO(12774));
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
          doubleSeries.Add(this[index].DateTime, (double) this[index].OpenInt);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF HighestHighPnF(int Index1, int Index2)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12794));
      if (Index1 > Index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12890));
      if (Index1 < 0 || Index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12962));
      if (Index2 < 0 || Index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13010));
      PnF pnF = this[Index1];
      for (int index = Index1 + 1; index <= Index2; ++index)
      {
        if (this[index].High > pnF.High)
          pnF = this[index];
      }
      return pnF;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF HighestHighPnF(DateTime DateTime1, DateTime DateTime2)
    {
      return this.HighestHighPnF(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF HighestHighPnF()
    {
      return this.HighestHighPnF(0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF LowestLowPnF(int Index1, int Index2)
    {
      if (this.Count <= 0)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13058));
      if (Index1 > Index2)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13150));
      if (Index1 < 0 || Index1 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13222));
      if (Index2 < 0 || Index2 > this.Count - 1)
        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13270));
      PnF pnF = this[Index1];
      for (int index = Index1 + 1; index <= Index2; ++index)
      {
        if (this[index].Low < pnF.Low)
          pnF = this[index];
      }
      return pnF;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF LowestLowPnF(DateTime DateTime1, DateTime DateTime2)
    {
      return this.LowestLowPnF(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF LowestLowPnF(int nPnFs)
    {
      return this.LowestLowPnF(this.LastIndex - nPnFs + 1, this.LastIndex);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF HighestHighPnF(int nPnFs)
    {
      return this.HighestHighPnF(this.LastIndex - nPnFs + 1, this.LastIndex);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF LowestLowPnF()
    {
      return this.LowestLowPnF(0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighestHigh(int index1, int index2)
    {
      PnF pnF = this.HighestHighPnF(index1, index2);
      if (pnF != null)
        return pnF.High;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowestLow(int index1, int index2)
    {
      PnF pnF = this.LowestLowPnF(index1, index2);
      if (pnF != null)
        return pnF.Low;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighestHigh(DateTime dateTime1, DateTime dateTime2)
    {
      PnF pnF = this.HighestHighPnF(dateTime1, dateTime2);
      if (pnF != null)
        return pnF.High;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowestLow(DateTime dateTime1, DateTime dateTime2)
    {
      PnF pnF = this.LowestLowPnF(dateTime1, dateTime2);
      if (pnF != null)
        return pnF.Low;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighestHigh(int nPnFs)
    {
      PnF pnF = this.HighestHighPnF(nPnFs);
      if (pnF != null)
        return pnF.High;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowestLow(int nPnFs)
    {
      PnF pnF = this.LowestLowPnF(nPnFs);
      if (pnF != null)
        return pnF.Low;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighestHigh()
    {
      PnF pnF = this.HighestHighPnF();
      if (pnF != null)
        return pnF.High;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowestLow()
    {
      PnF pnF = this.LowestLowPnF();
      if (pnF != null)
        return pnF.Low;
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMin(int index1, int index2)
    {
      return this.LowestLowPnF(index1, index2).Low;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMax(int index1, int index2)
    {
      return this.HighestHighPnF(index1, index2).High;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMin()
    {
      return this.GetMin(0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMax()
    {
      return this.GetMax(0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseD(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1.AddDays(1.0);
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month && dateTime2.Day == dateTime1.Day)
        return pnF.Close;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseW(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1.AddDays((double) (7 - dateTime1.DayOfWeek));
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (((!(dateTime1 <= dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).Subtract(dateTime2).Days <= dateTime1.DayOfWeek ? 1 : 0)) | (!(dateTime1 > dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime1).Days <= 7 - dateTime1.DayOfWeek ? 1 : 0))) != 0)
        return pnF.Close;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseM(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      dateTime = dateTime1.AddMonths(1);
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month)
        return pnF.Close;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseY(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, 1, 1);
      dateTime = dateTime1.AddYears(1);
      int index = this.GetIndex(dateTime) - 1;
      if (index == -2)
        index = this.GetIndex(dateTime, EIndexOption.Prev);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      if (this.GetDateTime(index).Year == dateTime1.Year)
        return pnF.Close;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseD(int index, int daysAgo)
    {
      return this.CloseD(this.GetDateTime(index), daysAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseW(int index, int weeksAgo)
    {
      return this.CloseW(this.GetDateTime(index), weeksAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseM(int index, int monthsAgo)
    {
      return this.CloseM(this.GetDateTime(index), monthsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseY(int index, int yearsAgo)
    {
      return this.CloseY(this.GetDateTime(index), yearsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseD(DateTime dateTime, int daysAgo)
    {
      return this.CloseD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseW(DateTime dateTime, int weeksAgo)
    {
      return this.CloseW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseM(DateTime dateTime, int monthsAgo)
    {
      return this.CloseM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseY(DateTime dateTime, int yearsAgo)
    {
      return this.CloseY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseD(PnF pnF, int daysAgo)
    {
      return this.CloseD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseW(PnF pnF, int weeksAgo)
    {
      return this.CloseW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseM(PnF pnF, int monthsAgo)
    {
      return this.CloseM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseY(PnF pnF, int yearsAgo)
    {
      return this.CloseY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseD(PnF pnF)
    {
      return this.CloseD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseW(PnF pnF)
    {
      return this.CloseW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseM(PnF pnF)
    {
      return this.CloseM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CloseY(PnF pnF)
    {
      return this.CloseY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenD(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1;
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month && dateTime2.Day == dateTime1.Day)
        return pnF.Open;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenW(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      dateTime = dateTime1.AddDays((double) -(int) dateTime1.DayOfWeek);
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (((!(dateTime1 <= dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).Subtract(dateTime2).Days <= dateTime1.DayOfWeek ? 1 : 0)) | (!(dateTime1 > dateTime2) ? 0 : ((DayOfWeek) new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime1).Days <= 7 - dateTime1.DayOfWeek ? 1 : 0))) != 0)
        return pnF.Open;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenM(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      dateTime = dateTime1;
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      DateTime dateTime2 = this.GetDateTime(index);
      if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month)
        return pnF.Open;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenY(DateTime dateTime)
    {
      DateTime dateTime1 = new DateTime(dateTime.Year, 1, 1);
      dateTime = dateTime1;
      int index = this.GetIndex(dateTime);
      if (index == -1)
        index = this.GetIndex(dateTime, EIndexOption.Next);
      if (index == -1)
        return -1.0;
      PnF pnF = this[index];
      if (this.GetDateTime(index).Year == dateTime1.Year)
        return pnF.Open;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenD(int index, int daysAgo)
    {
      return this.OpenD(this.GetDateTime(index), daysAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenW(int index, int weeksAgo)
    {
      return this.OpenW(this.GetDateTime(index), weeksAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenM(int index, int monthsAgo)
    {
      return this.OpenM(this.GetDateTime(index), monthsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenY(int index, int yearsAgo)
    {
      return this.OpenY(this.GetDateTime(index), yearsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenD(DateTime dateTime, int daysAgo)
    {
      return this.OpenD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenW(DateTime dateTime, int weeksAgo)
    {
      return this.OpenW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenM(DateTime dateTime, int monthsAgo)
    {
      return this.OpenM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenY(DateTime dateTime, int yearsAgo)
    {
      return this.OpenY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenD(PnF pnF, int daysAgo)
    {
      return this.OpenD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenW(PnF pnF, int weeksAgo)
    {
      return this.OpenW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenM(PnF pnF, int monthsAgo)
    {
      return this.OpenM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenY(PnF pnF, int yearsAgo)
    {
      return this.OpenY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenD(PnF pnF)
    {
      return this.OpenD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenW(PnF pnF)
    {
      return this.OpenW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenM(PnF pnF)
    {
      return this.OpenM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double OpenY(PnF pnF)
    {
      return this.OpenY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighD(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
      PnF pnF = this.HighestHighPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.High;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighW(DateTime dateTime)
    {
      DateTime DateTime1 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
      DateTime DateTime2 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
      PnF pnF = this.HighestHighPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.High;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighM(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
      PnF pnF = this.HighestHighPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.High;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighY(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, 1, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
      PnF pnF = this.HighestHighPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.High;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighD(int index, int daysAgo)
    {
      return this.HighD(this.GetDateTime(index), daysAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighW(int index, int weeksAgo)
    {
      return this.HighW(this.GetDateTime(index), weeksAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighM(int index, int monthsAgo)
    {
      return this.HighM(this.GetDateTime(index), monthsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighY(int index, int yearsAgo)
    {
      return this.HighY(this.GetDateTime(index), yearsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighD(DateTime dateTime, int daysAgo)
    {
      return this.HighD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighW(DateTime dateTime, int weeksAgo)
    {
      return this.HighW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighM(DateTime dateTime, int monthsAgo)
    {
      return this.HighM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighY(DateTime dateTime, int yearsAgo)
    {
      return this.HighY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighD(PnF pnF, int daysAgo)
    {
      return this.HighD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighW(PnF pnF, int weeksAgo)
    {
      return this.HighW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighM(PnF pnF, int monthsAgo)
    {
      return this.HighM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighY(PnF pnF, int yearsAgo)
    {
      return this.HighY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighD(PnF pnF)
    {
      return this.HighD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighW(PnF pnF)
    {
      return this.HighW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighM(PnF pnF)
    {
      return this.HighM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double HighY(PnF pnF)
    {
      return this.HighY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowD(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
      PnF pnF = this.LowestLowPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.Low;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowW(DateTime dateTime)
    {
      DateTime DateTime1 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
      DateTime DateTime2 = dateTime.AddDays((double) (7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
      PnF pnF = this.LowestLowPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.Low;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowM(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, dateTime.Month, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
      PnF pnF = this.LowestLowPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.Low;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowY(DateTime dateTime)
    {
      DateTime DateTime1 = new DateTime(dateTime.Year, 1, 1);
      DateTime DateTime2 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
      PnF pnF = this.LowestLowPnF(DateTime1, DateTime2);
      if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
        return pnF.Low;
      else
        return -1.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowD(int index, int daysAgo)
    {
      return this.LowD(this.GetDateTime(index), daysAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowW(int index, int weeksAgo)
    {
      return this.LowW(this.GetDateTime(index), weeksAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowM(int index, int monthsAgo)
    {
      return this.LowM(this.GetDateTime(index), monthsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowY(int index, int yearsAgo)
    {
      return this.LowY(this.GetDateTime(index), yearsAgo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowD(DateTime dateTime, int daysAgo)
    {
      return this.LowD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowW(DateTime dateTime, int weeksAgo)
    {
      return this.LowW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowM(DateTime dateTime, int monthsAgo)
    {
      return this.LowM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowY(DateTime dateTime, int yearsAgo)
    {
      return this.LowY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowD(PnF pnF, int daysAgo)
    {
      return this.LowD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -daysAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowW(PnF pnF, int weeksAgo)
    {
      return this.LowW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) (-weeksAgo * 7)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowM(PnF pnF, int monthsAgo)
    {
      return this.LowM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowY(PnF pnF, int yearsAgo)
    {
      return this.LowY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double) -yearsAgo));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowD(PnF pnF)
    {
      return this.LowD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowW(PnF pnF)
    {
      return this.LowW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowM(PnF pnF)
    {
      return this.LowM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double LowY(PnF pnF)
    {
      return this.LowY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
    }
  }
}
