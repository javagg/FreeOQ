// Type: SmartQuant.FinChart.Kagi
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using FreeQuant.Data;
using FreeQuant.Series;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart
{
  public class Kagi : BarSeries
  {
    private EKagiStyle R1Tbjal9J;
    private double jHreyxb1W;
    private BarSeries Yq5njBAtJ;
    private bool N9o76Qnve;
    private double hK0RL5ffy;
    private double CQfEJwwjn;
    private double Di0PI2QTl;
    private bool QI6TpeujS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Kagi(BarSeries BarArray)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Yq5njBAtJ = BarArray;
      this.R1Tbjal9J = EKagiStyle.Percent;
      this.Yq5njBAtJ.ItemAdded += new ItemAddedEventHandler(this.zGqhj5LH6);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Kagi(BarSeries BarArray, EKagiStyle Style)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Yq5njBAtJ = BarArray;
      this.R1Tbjal9J = Style;
      this.Yq5njBAtJ.ItemAdded += new ItemAddedEventHandler(this.zGqhj5LH6);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Kagi(BarSeries BarArray, double RevAmount)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Yq5njBAtJ = BarArray;
      this.R1Tbjal9J = EKagiStyle.Percent;
      this.jHreyxb1W = RevAmount;
      this.Yq5njBAtJ.ItemAdded += new ItemAddedEventHandler(this.zGqhj5LH6);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Kagi(BarSeries BarArray, EKagiStyle Style, double RevAmount)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Yq5njBAtJ = BarArray;
      this.R1Tbjal9J = Style;
      this.jHreyxb1W = RevAmount;
      this.Yq5njBAtJ.ItemAdded += new ItemAddedEventHandler(this.zGqhj5LH6);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      this.hK0RL5ffy = this.Yq5njBAtJ[0].Close;
      this.CQfEJwwjn = this.Yq5njBAtJ[0].Close;
      this.Di0PI2QTl = this.R1Tbjal9J != EKagiStyle.Point ? this.CQfEJwwjn * this.jHreyxb1W / 100.0 : this.jHreyxb1W;
      for (int index = 1; index < this.Yq5njBAtJ.Count; ++index)
      {
        this.QI6TpeujS = false;
        if (this.N9o76Qnve)
        {
          double close = this.Yq5njBAtJ[index].Close;
          if (this.Yq5njBAtJ[index].Close <= this.CQfEJwwjn - this.Di0PI2QTl)
          {
            this.Add(new Bar(this.Yq5njBAtJ.GetDateTime(index), this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
            this.QI6TpeujS = true;
            this.N9o76Qnve = false;
            this.hK0RL5ffy = this.CQfEJwwjn;
            this.CQfEJwwjn = this.Yq5njBAtJ[index].Close;
            if (this.R1Tbjal9J == EKagiStyle.Percent)
              this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
          }
          if (this.Yq5njBAtJ[index].Close > this.CQfEJwwjn)
          {
            this.CQfEJwwjn = this.Yq5njBAtJ[index].Close;
            if (this.R1Tbjal9J == EKagiStyle.Percent)
              this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
          }
        }
        else
        {
          if (this.Yq5njBAtJ[index].Close >= this.CQfEJwwjn + this.Di0PI2QTl)
          {
            this.Add(new Bar(this.Yq5njBAtJ.GetDateTime(index), this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
            this.QI6TpeujS = true;
            this.N9o76Qnve = true;
            this.hK0RL5ffy = this.CQfEJwwjn;
            this.CQfEJwwjn = this.Yq5njBAtJ[index].Close;
            if (this.R1Tbjal9J == EKagiStyle.Percent)
              this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
          }
          if (this.Yq5njBAtJ[index].Close < this.CQfEJwwjn)
          {
            this.CQfEJwwjn = this.Yq5njBAtJ[index].Close;
            if (this.R1Tbjal9J == EKagiStyle.Percent)
              this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
          }
        }
      }
      if (this.QI6TpeujS)
        return;
      this.Add(new Bar(this.Yq5njBAtJ.Last.DateTime, this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zGqhj5LH6([In] object obj0, [In] DateTimeEventArgs obj1)
    {
      if (this.N9o76Qnve)
      {
        this.QI6TpeujS = false;
        double close = this.Yq5njBAtJ[obj1.DateTime].Close;
        if (this.Yq5njBAtJ[obj1.DateTime].Close <= this.CQfEJwwjn - this.Di0PI2QTl)
        {
          this.QI6TpeujS = true;
          this.N9o76Qnve = false;
          this.hK0RL5ffy = this.CQfEJwwjn;
          this.CQfEJwwjn = this.Yq5njBAtJ[obj1.DateTime].Close;
          if (this.R1Tbjal9J == EKagiStyle.Percent)
            this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
          this.Add(new Bar(obj1.DateTime, this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
        }
        if (this.Yq5njBAtJ[obj1.DateTime].Close <= this.CQfEJwwjn)
          return;
        this.CQfEJwwjn = this.Yq5njBAtJ[obj1.DateTime].Close;
        if (this.R1Tbjal9J == EKagiStyle.Percent)
          this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
        ((TimeSeries) this).Remove(this.Count - 1);
        this.Add(new Bar(obj1.DateTime, this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
      }
      else
      {
        if (this.Yq5njBAtJ[obj1.DateTime].Close >= this.CQfEJwwjn + this.Di0PI2QTl)
        {
          this.QI6TpeujS = true;
          this.N9o76Qnve = true;
          this.hK0RL5ffy = this.CQfEJwwjn;
          this.CQfEJwwjn = this.Yq5njBAtJ[obj1.DateTime].Close;
          if (this.R1Tbjal9J == EKagiStyle.Percent)
            this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
          this.Add(new Bar(obj1.DateTime, this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
        }
        if (this.Yq5njBAtJ[obj1.DateTime].Close >= this.CQfEJwwjn)
          return;
        this.CQfEJwwjn = this.Yq5njBAtJ[obj1.DateTime].Close;
        if (this.R1Tbjal9J == EKagiStyle.Percent)
          this.Di0PI2QTl = this.CQfEJwwjn * this.jHreyxb1W / 100.0;
        ((TimeSeries) this).Remove(this.Count - 1);
        this.Add(new Bar(obj1.DateTime, this.hK0RL5ffy, this.CQfEJwwjn, this.hK0RL5ffy, this.CQfEJwwjn, 1L, 1L));
      }
    }
  }
}
