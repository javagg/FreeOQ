// Type: SmartQuant.Data.PnF
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  [Serializable]
  public class PnF
  {
    protected DateTime beginTime;
    protected DateTime endTime;
    protected double high;
    protected double low;
    protected double open;
    protected double close;
    protected long volume;
    protected long openInt;
    protected double boxSize;

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.beginTime;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        throw new NotSupportedException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(486));
      }
    }

    public DateTime BeginTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.beginTime;
      }
    }

    [View]
    public virtual DateTime EndTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.endTime;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.endTime = value;
      }
    }

    [View]
    public TimeSpan Duration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.endTime - this.beginTime;
      }
    }

    public PnFKind Kind
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.open > this.close ? PnFKind.Down : PnFKind.Up;
      }
    }

    public double BoxSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.boxSize;
      }
    }

    public int BoxCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (int) Math.Round(Math.Abs(this.close - this.open) / this.boxSize);
      }
    }

    [PriceView]
    public double Open
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.open;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.open = value;
      }
    }

    [PriceView]
    public double High
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.high;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.high = value;
      }
    }

    [PriceView]
    public double Low
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.low;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.low = value;
      }
    }

    [PriceView]
    public double Close
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.close;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.close = value;
      }
    }

    [View]
    public long Volume
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.volume;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.volume = value;
      }
    }

    public long OpenInt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.openInt;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.openInt = value;
      }
    }

    public double Median
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (this.High + this.Low) / 2.0;
      }
    }

    public double Typical
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (this.High + this.Low + this.Close) / 3.0;
      }
    }

    public double Weighted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (this.High + this.Low + 2.0 * this.Close) / 4.0;
      }
    }

    public double this[int barData]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        switch (barData)
        {
          case 0:
            return this.Close;
          case 1:
            return this.Open;
          case 2:
            return this.High;
          case 3:
            return this.Low;
          case 4:
            return this.Median;
          case 5:
            return this.Typical;
          case 6:
            return this.Weighted;
          case 7:
            return (double) this.volume;
          case 8:
            return (double) this.openInt;
          default:
            return double.NaN;
        }
      }
    }

    public double this[BarData barData]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this[(int) barData];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF(double boxSize, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.boxSize = boxSize;
      this.beginTime = beginTime;
      this.endTime = endTime;
      this.open = open;
      this.high = high;
      this.low = low;
      this.close = close;
      this.volume = volume;
      this.openInt = openInt;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnF(PnF pnF)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(pnF.BoxSize, pnF.beginTime, pnF.endTime, pnF.open, pnF.high, pnF.low, pnF.close, pnF.volume, pnF.openInt);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPrice(BarPrice option)
    {
      double num = 0.0;
      switch (option)
      {
        case BarPrice.High:
          num = this.High;
          break;
        case BarPrice.Low:
          num = this.Low;
          break;
        case BarPrice.Open:
          num = this.Open;
          break;
        case BarPrice.Close:
          num = this.Close;
          break;
        case BarPrice.Median:
          num = this.Median;
          break;
        case BarPrice.Typical:
          num = this.Typical;
          break;
        case BarPrice.Weighted:
          num = this.Weighted;
          break;
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(556), (object) (this.beginTime.ToShortDateString() + SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(746) + this.beginTime.ToLongTimeString()), (object) (this.endTime.ToShortDateString() + SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(752) + this.endTime.ToLongTimeString()), (object) this.boxSize, (object) this.open, (object) this.high, (object) this.low, (object) this.close, (object) this.volume, (object) this.openInt, (object) this.Kind);
    }
  }
}
