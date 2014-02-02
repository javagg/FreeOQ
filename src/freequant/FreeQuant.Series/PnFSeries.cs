using FreeQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Series
{
	public class PnFSeries : DoubleSeries
	{
		public new PnF First
		{
			get
			{
				return this[0] as PnF;
			}
		}

		public new PnF Last
		{
			get
			{
				return this[this.Count - 1]  as PnF;
			}
		}

		new  public PnF this [int i]
		{
			get
			{
				return ((TimeSeries)this)[i] as PnF;
			}
		}

		new public PnF this [DateTime DateTime]
		{
			get
			{
				return ((TimeSeries)this)[DateTime] as PnF;
			}
		}

		new public PnF this [DateTime DateTime, EIndexOption Option]
		{
			get
			{
				return ((TimeSeries)this)[DateTime, Option] as PnF;
			}
		}

		public override double this [int Index, int BarData]
		{
			get
			{
				return this[Index][BarData];
			}
		}

		public override double this [int Index, BarData BarData]
		{
			get
			{
				return this[Index][BarData];
			}
		}

		public PnFSeries(string name, string title) : base(name, title)
		{
			this.fArray = (IDataSeries)new MemorySeries<PnF>();
		}

		public PnFSeries(string name) : this(name, String.Empty)
		{

		}

		public PnFSeries() : this("PnFSeries")
		{
		}
		//    public PnFSeries Clone()
		//    {
		//      return base.Clone() as PnFSeries;
		//    }
		//    public PnFSeries Clone(int Index1, int Index2)
		//    {
		//      return base.Clone(Index1, Index2) as PnFSeries;
		//    }
		//
		//    public PnFSeries Clone(DateTime DateTime1, DateTime DateTime2)
		//    {
		//      return base.Clone(DateTime1, DateTime2) as PnFSeries;
		//    }
		public bool Contains(PnF PnF)
		{
			return base.Contains(PnF.DateTime);
		}

		public void Add(PnF pnF)
		{
			this.fArray[pnF.DateTime] = (object)pnF;
			this.EmitItemAdded(pnF.DateTime);
		}

		public void Remove(PnF PnF)
		{
			this.fArray.Remove(PnF.DateTime);
		}
		//
		//    public PnFSeries Shift(int offset)
		//    {
		//      PnFSeries pnFseries = new PnFSeries(this.Name, this.Title);
		//      int num = 0;
		//      if (offset < 0)
		//        num += Math.Abs(offset);
		//      for (int index1 = num; index1 < this.Count; ++index1)
		//      {
		//        int index2 = index1 + offset;
		//        if (index2 < this.Count)
		//        {
		//          DateTime dateTime = this.GetDateTime(index2);
		//          pnFseries.Add(new PnF(this[index1])
		//          {
		//            DateTime = dateTime
		//          });
		//        }
		//        else
		//          break;
		//      }
		//      return pnFseries;
		//    }
		//
		//
		//    public PnF Ago(int n)
		//    {
		//      int index = this.Count - 1 - n;
		//      if (index < 0)
		//        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12490) + (object) n + oK6F3TB73XXXGhdieP.wF6SgrNUO(12532));
		//      else
		//        return this[index];
		//    }
		public DoubleSeries GetArray(BarData BarData)
		{
			return this.GetArray(0, this.Count - 1, BarData);
		}

		public DoubleSeries GetArray(int Index1, int Index2, BarData BarData)
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int index = Index1; index <= Index2; ++index)
				doubleSeries.Add(this.GetDateTime(index), ((TimeSeries)this)[index, BarData]);
			return doubleSeries;
		}

		public DoubleSeries GetArray(DateTime DateTime1, DateTime DateTime2, BarData BarData)
		{
			return this.GetArray(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev), BarData);
		}

		public DoubleSeries GetHighSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this[index].DateTime, this[index].High);
			return doubleSeries;
		}

		public DoubleSeries GetLowSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this[index].DateTime, this[index].Low);
			return doubleSeries;
		}

		public DoubleSeries GetOpenSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this[index].DateTime, this[index].Open);
			return doubleSeries;
		}

		public DoubleSeries GetCloseSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this[index].DateTime, this[index].Close);
			return doubleSeries;
		}

		public DoubleSeries GetVolumeSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this[index].DateTime, (double)this[index].Volume);
			return doubleSeries;
		}

		public DoubleSeries GetOpenIntSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
				doubleSeries.Add(this[index].DateTime, (double)this[index].OpenInt);
			return doubleSeries;
		}

		public DoubleSeries GetHighSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
					doubleSeries.Add(this[index].DateTime, this[index].High);
			}
			return doubleSeries;
		}

		public DoubleSeries GetLowSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
					doubleSeries.Add(this[index].DateTime, this[index].Low);
			}
			return doubleSeries;
		}

		public DoubleSeries GetOpenSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
					doubleSeries.Add(this[index].DateTime, this[index].Open);
			}
			return doubleSeries;
		}

		public DoubleSeries GetCloseSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
					doubleSeries.Add(this[index].DateTime, this[index].Close);
			}
			return doubleSeries;
		}

		public DoubleSeries GetVolumeSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
					doubleSeries.Add(this[index].DateTime, (double)this[index].Volume);
			}
			return doubleSeries;
		}

		public DoubleSeries GetOpenIntSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.Name);
			for (int index = 0; index < this.Count; ++index)
			{
				if (this[index].DateTime >= date1 && this[index].DateTime <= date2)
					doubleSeries.Add(this[index].DateTime, (double)this[index].OpenInt);
			}
			return doubleSeries;
		}

		public PnF HighestHighPnF(int Index1, int Index2)
		{
//      if (this.Count <= 0)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12794));
//      if (Index1 > Index2)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12890));
//      if (Index1 < 0 || Index1 > this.Count - 1)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(12962));
//      if (Index2 < 0 || Index2 > this.Count - 1)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13010));
			PnF pnF = this[Index1];
			for (int index = Index1 + 1; index <= Index2; ++index)
			{
				if (this[index].High > pnF.High)
					pnF = this[index];
			}
			return pnF;
		}

		public PnF HighestHighPnF(DateTime DateTime1, DateTime DateTime2)
		{
			return this.HighestHighPnF(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev));
		}

		public PnF HighestHighPnF()
		{
			return this.HighestHighPnF(0, this.Count - 1);
		}

		public PnF LowestLowPnF(int Index1, int Index2)
		{
//      if (this.Count <= 0)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13058));
//      if (Index1 > Index2)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13150));
//      if (Index1 < 0 || Index1 > this.Count - 1)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13222));
//      if (Index2 < 0 || Index2 > this.Count - 1)
//        throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13270));
			PnF pnF = this[Index1];
			for (int index = Index1 + 1; index <= Index2; ++index)
			{
				if (this[index].Low < pnF.Low)
					pnF = this[index];
			}
			return pnF;
		}

		public PnF LowestLowPnF(DateTime DateTime1, DateTime DateTime2)
		{
			return this.LowestLowPnF(this.GetIndex(DateTime1, EIndexOption.Next), this.GetIndex(DateTime2, EIndexOption.Prev));
		}

		public PnF LowestLowPnF(int nPnFs)
		{
			return this.LowestLowPnF(this.LastIndex - nPnFs + 1, this.LastIndex);
		}

		public PnF HighestHighPnF(int nPnFs)
		{
			return this.HighestHighPnF(this.LastIndex - nPnFs + 1, this.LastIndex);
		}

		public PnF LowestLowPnF()
		{
			return this.LowestLowPnF(0, this.Count - 1);
		}

		public double HighestHigh(int index1, int index2)
		{
			PnF pnF = this.HighestHighPnF(index1, index2);
			if (pnF != null)
				return pnF.High;
			else
				return double.NaN;
		}

		public double LowestLow(int index1, int index2)
		{
			PnF pnF = this.LowestLowPnF(index1, index2);
			if (pnF != null)
				return pnF.Low;
			else
				return double.NaN;
		}

		public double HighestHigh(DateTime dateTime1, DateTime dateTime2)
		{
			PnF pnF = this.HighestHighPnF(dateTime1, dateTime2);
			if (pnF != null)
				return pnF.High;
			else
				return double.NaN;
		}

		public double LowestLow(DateTime dateTime1, DateTime dateTime2)
		{
			PnF pnF = this.LowestLowPnF(dateTime1, dateTime2);
			if (pnF != null)
				return pnF.Low;
			else
				return double.NaN;
		}

		public double HighestHigh(int nPnFs)
		{
			PnF pnF = this.HighestHighPnF(nPnFs);
			if (pnF != null)
				return pnF.High;
			else
				return double.NaN;
		}

		public double LowestLow(int nPnFs)
		{
			PnF pnF = this.LowestLowPnF(nPnFs);
			if (pnF != null)
				return pnF.Low;
			else
				return double.NaN;
		}

		public double HighestHigh()
		{
			PnF pnF = this.HighestHighPnF();
			if (pnF != null)
				return pnF.High;
			else
				return double.NaN;
		}

		public double LowestLow()
		{
			PnF pnF = this.LowestLowPnF();
			if (pnF != null)
				return pnF.Low;
			else
				return double.NaN;
		}

		public override double GetMin(int index1, int index2)
		{
			return this.LowestLowPnF(index1, index2).Low;
		}

		public override double GetMax(int index1, int index2)
		{
			return this.HighestHighPnF(index1, index2).High;
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
			PnF pnF = this[index];
			DateTime dateTime2 = this.GetDateTime(index);
			if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month && dateTime2.Day == dateTime1.Day)
				return pnF.Close;
			else
				return -1.0;
		}

		public double CloseW(DateTime dateTime)
		{
			DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			dateTime = dateTime1.AddDays((double)(7 - dateTime1.DayOfWeek));
			int index = this.GetIndex(dateTime) - 1;
			if (index == -2)
				index = this.GetIndex(dateTime, EIndexOption.Prev);
			if (index == -1)
				return -1.0;
			PnF pnF = this[index];
			DateTime dateTime2 = this.GetDateTime(index);
			if (((!(dateTime1 <= dateTime2) ? 0 : ((DayOfWeek)new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).Subtract(dateTime2).Days <= dateTime1.DayOfWeek ? 1 : 0)) | (!(dateTime1 > dateTime2) ? 0 : ((DayOfWeek)new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime1).Days <= 7 - dateTime1.DayOfWeek ? 1 : 0))) != 0)
				return pnF.Close;
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
			PnF pnF = this[index];
			DateTime dateTime2 = this.GetDateTime(index);
			if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month)
				return pnF.Close;
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
			PnF pnF = this[index];
			if (this.GetDateTime(index).Year == dateTime1.Year)
				return pnF.Close;
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
			return this.CloseD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)-daysAgo));
		}

		public double CloseW(DateTime dateTime, int weeksAgo)
		{
			return this.CloseW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double CloseM(DateTime dateTime, int monthsAgo)
		{
			return this.CloseM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		public double CloseY(DateTime dateTime, int yearsAgo)
		{
			return this.CloseY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		public double CloseD(PnF pnF, int daysAgo)
		{
			return this.CloseD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-daysAgo));
		}

		public double CloseW(PnF pnF, int weeksAgo)
		{
			return this.CloseW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double CloseM(PnF pnF, int monthsAgo)
		{
			return this.CloseM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		public double CloseY(PnF pnF, int yearsAgo)
		{
			return this.CloseY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-yearsAgo));
		}

		public double CloseD(PnF pnF)
		{
			return this.CloseD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double CloseW(PnF pnF)
		{
			return this.CloseW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double CloseM(PnF pnF)
		{
			return this.CloseM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double CloseY(PnF pnF)
		{
			return this.CloseY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
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
			PnF pnF = this[index];
			DateTime dateTime2 = this.GetDateTime(index);
			if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month && dateTime2.Day == dateTime1.Day)
				return pnF.Open;
			else
				return -1.0;
		}

		public double OpenW(DateTime dateTime)
		{
			DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			dateTime = dateTime1.AddDays((double)-(int)dateTime1.DayOfWeek);
			int index = this.GetIndex(dateTime);
			if (index == -1)
				index = this.GetIndex(dateTime, EIndexOption.Next);
			if (index == -1)
				return -1.0;
			PnF pnF = this[index];
			DateTime dateTime2 = this.GetDateTime(index);
			if (((!(dateTime1 <= dateTime2) ? 0 : ((DayOfWeek)new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day).Subtract(dateTime2).Days <= dateTime1.DayOfWeek ? 1 : 0)) | (!(dateTime1 > dateTime2) ? 0 : ((DayOfWeek)new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime1).Days <= 7 - dateTime1.DayOfWeek ? 1 : 0))) != 0)
				return pnF.Open;
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
			PnF pnF = this[index];
			DateTime dateTime2 = this.GetDateTime(index);
			if (dateTime2.Year == dateTime1.Year && dateTime2.Month == dateTime1.Month)
				return pnF.Open;
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
			PnF pnF = this[index];
			if (this.GetDateTime(index).Year == dateTime1.Year)
				return pnF.Open;
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
			return this.OpenD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)-daysAgo));
		}

		public double OpenW(DateTime dateTime, int weeksAgo)
		{
			return this.OpenW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double OpenM(DateTime dateTime, int monthsAgo)
		{
			return this.OpenM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		public double OpenY(DateTime dateTime, int yearsAgo)
		{
			return this.OpenY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		public double OpenD(PnF pnF, int daysAgo)
		{
			return this.OpenD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-daysAgo));
		}

		public double OpenW(PnF pnF, int weeksAgo)
		{
			return this.OpenW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double OpenM(PnF pnF, int monthsAgo)
		{
			return this.OpenM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		public double OpenY(PnF pnF, int yearsAgo)
		{
			return this.OpenY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-yearsAgo));
		}

		public double OpenD(PnF pnF)
		{
			return this.OpenD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double OpenW(PnF pnF)
		{
			return this.OpenW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double OpenM(PnF pnF)
		{
			return this.OpenM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double OpenY(PnF pnF)
		{
			return this.OpenY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

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

		public double HighW(DateTime dateTime)
		{
			DateTime DateTime1 = dateTime.AddDays((double)(7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
			DateTime DateTime2 = dateTime.AddDays((double)(7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
			PnF pnF = this.HighestHighPnF(DateTime1, DateTime2);
			if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
				return pnF.High;
			else
				return -1.0;
		}

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
			return this.HighD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)-daysAgo));
		}

		public double HighW(DateTime dateTime, int weeksAgo)
		{
			return this.HighW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double HighM(DateTime dateTime, int monthsAgo)
		{
			return this.HighM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		public double HighY(DateTime dateTime, int yearsAgo)
		{
			return this.HighY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		public double HighD(PnF pnF, int daysAgo)
		{
			return this.HighD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-daysAgo));
		}

		public double HighW(PnF pnF, int weeksAgo)
		{
			return this.HighW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double HighM(PnF pnF, int monthsAgo)
		{
			return this.HighM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		public double HighY(PnF pnF, int yearsAgo)
		{
			return this.HighY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-yearsAgo));
		}

		public double HighD(PnF pnF)
		{
			return this.HighD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double HighW(PnF pnF)
		{
			return this.HighW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double HighM(PnF pnF)
		{
			return this.HighM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double HighY(PnF pnF)
		{
			return this.HighY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

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

		public double LowW(DateTime dateTime)
		{
			DateTime DateTime1 = dateTime.AddDays((double)(7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
			DateTime DateTime2 = dateTime.AddDays((double)(7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
			PnF pnF = this.LowestLowPnF(DateTime1, DateTime2);
			if (pnF.DateTime >= DateTime1 && pnF.DateTime <= DateTime2)
				return pnF.Low;
			else
				return -1.0;
		}

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
			return this.LowD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)-daysAgo));
		}

		public double LowW(DateTime dateTime, int weeksAgo)
		{
			return this.LowW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double LowM(DateTime dateTime, int monthsAgo)
		{
			return this.LowM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		public double LowY(DateTime dateTime, int yearsAgo)
		{
			return this.LowY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		public double LowD(PnF pnF, int daysAgo)
		{
			return this.LowD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-daysAgo));
		}

		public double LowW(PnF pnF, int weeksAgo)
		{
			return this.LowW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-weeksAgo * 7)));
		}

		public double LowM(PnF pnF, int monthsAgo)
		{
			return this.LowM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		public double LowY(PnF pnF, int yearsAgo)
		{
			return this.LowY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)-yearsAgo));
		}

		public double LowD(PnF pnF)
		{
			return this.LowD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double LowW(PnF pnF)
		{
			return this.LowW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double LowM(PnF pnF)
		{
			return this.LowM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		public double LowY(PnF pnF)
		{
			return this.LowY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}
	}
}
