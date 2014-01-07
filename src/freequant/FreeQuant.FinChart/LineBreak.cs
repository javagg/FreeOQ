// Type: SmartQuant.FinChart.LineBreak
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using SmartQuant.Data;
using SmartQuant.Series;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class LineBreak : BarSeries
  {
    private int inBKlKXwG;
    private BarSeries lySiCl1si;
    private bool couXtHe2A;
    private int nWoDvrxxo;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBreak(BarSeries BarArray)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.couXtHe2A = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.lySiCl1si = BarArray;
      this.lySiCl1si.ItemAdded += new ItemAddedEventHandler(this.d2ors9hOM);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBreak(BarSeries BarArray, int NumberOfLines)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.couXtHe2A = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.lySiCl1si = BarArray;
      this.inBKlKXwG = NumberOfLines;
      this.lySiCl1si.ItemAdded += new ItemAddedEventHandler(this.d2ors9hOM);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      if (this.lySiCl1si[0].Open < this.lySiCl1si[0].Close)
      {
        this.couXtHe2A = true;
        this.Add(new Bar(this.lySiCl1si.GetDateTime(0), this.lySiCl1si[0].Open, this.lySiCl1si[0].Close, this.lySiCl1si[0].Open, this.lySiCl1si[0].Close, 1L, 1L));
      }
      else
      {
        this.couXtHe2A = false;
        this.Add(new Bar(this.lySiCl1si.GetDateTime(0), this.lySiCl1si[0].Open, this.lySiCl1si[0].Open, this.lySiCl1si[0].Close, this.lySiCl1si[0].Close, 1L, 1L));
      }
      this.nWoDvrxxo = 1;
      for (int index = 1; index < this.lySiCl1si.Count; ++index)
      {
        double num = this.nWoDvrxxo < this.inBKlKXwG ? this[this.Count - 1].Open : this[this.Count - this.inBKlKXwG].Open;
        if (this.couXtHe2A)
        {
          if (this.lySiCl1si[index].Close < num)
          {
            this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Open, this[this.Count - 1].Open, this.lySiCl1si[index].Close, this.lySiCl1si[index].Close, 1L, 1L));
            this.couXtHe2A = false;
            this.nWoDvrxxo = 1;
          }
          if (this.lySiCl1si[index].Close > this[this.Count - 1].Close)
          {
            this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Close, this.lySiCl1si[index].Close, this[this.Count - 1].Close, this.lySiCl1si[index].Close, 1L, 1L));
            ++this.nWoDvrxxo;
          }
        }
        else
        {
          if (this.lySiCl1si[index].Close > num)
          {
            this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Open, this.lySiCl1si[index].Close, this[this.Count - 1].Open, this.lySiCl1si[index].Close, 1L, 1L));
            this.couXtHe2A = true;
            this.nWoDvrxxo = 1;
          }
          if (this.lySiCl1si[index].Close < this[this.Count - 1].Close)
          {
            this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Close, this[this.Count - 1].Close, this.lySiCl1si[index].Close, this.lySiCl1si[index].Close, 1L, 1L));
            ++this.nWoDvrxxo;
          }
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void d2ors9hOM([In] object obj0, [In] DateTimeEventArgs obj1)
    {
      int index = this.lySiCl1si.Count - 1;
      double num = this.nWoDvrxxo < this.inBKlKXwG ? this[this.Count - 1].Open : this[this.Count - this.inBKlKXwG].Open;
      if (this.couXtHe2A)
      {
        if (this.lySiCl1si[index].Close < num)
        {
          this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Open, this[this.Count - 1].Open, this.lySiCl1si[index].Close, this.lySiCl1si[index].Close, 1L, 1L));
          this.couXtHe2A = false;
          this.nWoDvrxxo = 1;
        }
        if (this.lySiCl1si[index].Close <= this[this.Count - 1].Close)
          return;
        this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Close, this.lySiCl1si[index].Close, this[this.Count - 1].Close, this.lySiCl1si[index].Close, 1L, 1L));
        ++this.nWoDvrxxo;
      }
      else
      {
        if (this.lySiCl1si[index].Close > num)
        {
          this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Open, this.lySiCl1si[index].Close, this[this.Count - 1].Open, this.lySiCl1si[index].Close, 1L, 1L));
          this.couXtHe2A = true;
          this.nWoDvrxxo = 1;
        }
        if (this.lySiCl1si[index].Close >= this[this.Count - 1].Close)
          return;
        this.Add(new Bar(this.lySiCl1si.GetDateTime(index), this[this.Count - 1].Close, this[this.Count - 1].Close, this.lySiCl1si[index].Close, this.lySiCl1si[index].Close, 1L, 1L));
        ++this.nWoDvrxxo;
      }
    }
  }
}
