using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  [Serializable]
  public class Bar : IDataObject, ISeriesObject, ICloneable
  {
    private const byte oAfcaJAYg = (byte) 2;
    protected byte providerId;
    protected DateTime beginTime;
    protected DateTime endTime;
    protected double high;
    protected double low;
    protected double open;
    protected double close;
    protected long volume;
    protected long openInt;
    protected long size;
    protected bool isComplete;
    protected Color color;
    protected BarType barType;

    public byte ProviderId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.providerId;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.providerId = value;
      }
    }

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.beginTime;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.beginTime = value;
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
        if (!(this.endTime == DateTime.MinValue))
          return this.endTime;
        if (this.barType == BarType.Time && this.size > 0L)
          return this.beginTime.AddSeconds((double) this.size);
        else
          throw new InvalidOperationException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(192));
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
        return this.EndTime - this.beginTime;
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

    [View]
    public long Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.size;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.size = value;
      }
    }

    public bool IsComplete
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.isComplete;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.isComplete = value;
      }
    }

    [View]
    public BarType BarType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.barType;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.barType = value;
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

    public double Average
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (this.High + this.Low + this.Open + this.Close) / 4.0;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.color;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.color = value;
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
          case 9:
            return this.Average;
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
    public Bar(BarType barType, long size, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.barType = barType;
      this.size = size;
      this.beginTime = beginTime;
      this.endTime = endTime;
      this.open = open;
      this.high = high;
      this.low = low;
      this.close = close;
      this.volume = volume;
      this.openInt = openInt;
      this.providerId = (byte) 0;
      this.color = Color.Empty;
      this.isComplete = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bar(DateTime datetime, double open, double high, double low, double close, long volume, long size)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(BarType.Time, size, datetime, datetime.AddSeconds((double) size), open, high, low, close, volume, 0L);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bar(Bar bar)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(bar.barType, bar.size, bar.beginTime, bar.endTime, bar.open, bar.high, bar.low, bar.close, bar.volume, bar.openInt);
      this.providerId = bar.providerId;
      this.color = bar.color;
      this.isComplete = bar.isComplete;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bar()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0L, 0L);
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
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(266), (object) this.beginTime, (object) this.endTime, (object) this.barType, (object) this.open, (object) this.high, (object) this.low, (object) this.close, (object) this.volume, (object) this.openInt, (object) this.size);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 2);
      writer.Write(this.beginTime.Ticks);
      writer.Write(this.endTime.Ticks);
      writer.Write((byte) this.barType);
      writer.Write(this.size);
      writer.Write(this.high);
      writer.Write(this.low);
      writer.Write(this.open);
      writer.Write(this.close);
      writer.Write(this.volume);
      writer.Write(this.openInt);
      writer.Write(this.providerId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReadFrom(BinaryReader reader)
    {
      byte num = reader.ReadByte();
      switch (num)
      {
        case (byte) 1:
          this.beginTime = new DateTime(reader.ReadInt64());
          this.endTime = new DateTime(reader.ReadInt64());
          this.barType = (BarType) reader.ReadByte();
          this.size = reader.ReadInt64();
          this.high = Math.Round((double) reader.ReadSingle(), 4);
          this.low = Math.Round((double) reader.ReadSingle(), 4);
          this.open = Math.Round((double) reader.ReadSingle(), 4);
          this.close = Math.Round((double) reader.ReadSingle(), 4);
          this.volume = reader.ReadInt64();
          this.openInt = reader.ReadInt64();
          this.providerId = reader.ReadByte();
          break;
        case (byte) 2:
          this.beginTime = new DateTime(reader.ReadInt64());
          this.endTime = new DateTime(reader.ReadInt64());
          this.barType = (BarType) reader.ReadByte();
          this.size = reader.ReadInt64();
          this.high = reader.ReadDouble();
          this.low = reader.ReadDouble();
          this.open = reader.ReadDouble();
          this.close = reader.ReadDouble();
          this.volume = reader.ReadInt64();
          this.openInt = reader.ReadInt64();
          this.providerId = reader.ReadByte();
          break;
        default:
          throw new Exception(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(446) + (object) num);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Bar();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object Clone()
    {
      return (object) new Bar(this);
    }
  }
}
