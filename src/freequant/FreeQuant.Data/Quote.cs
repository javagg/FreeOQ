// Type: SmartQuant.Data.Quote
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  [Serializable]
  public class Quote : IDataObject, ISeriesObject, ICloneable
  {
    private const byte IoDDKr799 = (byte) 2;
    protected DateTime datetime;
    protected byte providerId;
    protected double bid;
    protected double ask;
    protected int bidSize;
    protected int askSize;

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
        return this.datetime;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.datetime = value;
      }
    }

    [View]
    public int BidSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.bidSize;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.bidSize = value;
      }
    }

    [PriceView]
    public double Bid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.bid;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.bid = value;
      }
    }

    [PriceView]
    public double Ask
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ask;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ask = value;
      }
    }

    [View]
    public int AskSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.askSize;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.askSize = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quote(DateTime datetime, double bid, int bidSize, double ask, int askSize)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.datetime = datetime;
      this.bid = bid;
      this.ask = ask;
      this.bidSize = bidSize;
      this.askSize = askSize;
      this.providerId = (byte) 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quote(Quote quote)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(quote.datetime, quote.bid, quote.bidSize, quote.ask, quote.askSize);
      this.providerId = quote.providerId;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quote()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(DateTime.MinValue, 0.0, 0, 0.0, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(62), (object) this.datetime, (object) this.bidSize, (object) this.bid, (object) this.ask, (object) this.askSize);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 2);
      writer.Write(this.datetime.Ticks);
      writer.Write(this.bid);
      writer.Write(this.ask);
      writer.Write(this.bidSize);
      writer.Write(this.askSize);
      writer.Write(this.providerId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReadFrom(BinaryReader reader)
    {
      byte num = reader.ReadByte();
      switch (num)
      {
        case (byte) 1:
          this.datetime = new DateTime(reader.ReadInt64());
          this.bid = Math.Round((double) reader.ReadSingle(), 4);
          this.bidSize = reader.ReadInt32();
          this.ask = Math.Round((double) reader.ReadSingle(), 4);
          this.askSize = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          break;
        case (byte) 2:
          this.datetime = new DateTime(reader.ReadInt64());
          this.bid = reader.ReadDouble();
          this.ask = reader.ReadDouble();
          this.bidSize = reader.ReadInt32();
          this.askSize = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          break;
        default:
          throw new Exception(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(152) + (object) num);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Quote();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object Clone()
    {
      return (object) new Quote(this);
    }
  }
}
