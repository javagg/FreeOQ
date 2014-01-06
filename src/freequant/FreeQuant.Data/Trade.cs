// Type: SmartQuant.Data.Trade
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
  public class Trade : IDataObject, ISeriesObject, ICloneable
  {
    private const byte V4aKdDBEP = (byte) 2;
    protected DateTime datetime;
    protected byte providerId;
    protected double price;
    protected int size;

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

    [PriceView]
    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.price;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.price = value;
      }
    }

    [View]
    public int Size
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Trade(DateTime datetime, double price, int size)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.datetime = datetime;
      this.price = price;
      this.size = size;
      this.providerId = (byte) 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Trade(Trade trade)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(trade.datetime, trade.price, trade.size);
      this.providerId = trade.providerId;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Trade()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(DateTime.MinValue, 0.0, 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(1080), (object) this.datetime, (object) this.price, (object) this.size);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Trade();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object Clone()
    {
      return (object) new Trade(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 2);
      writer.Write(this.datetime.Ticks);
      writer.Write(this.price);
      writer.Write(this.size);
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
          this.price = Math.Round((double) reader.ReadSingle(), 4);
          this.size = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          break;
        case (byte) 2:
          this.datetime = new DateTime(reader.ReadInt64());
          this.price = reader.ReadDouble();
          this.size = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          break;
        default:
          throw new Exception(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(1128) + (object) num);
      }
    }
  }
}
