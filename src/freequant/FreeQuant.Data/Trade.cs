using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
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
     get
      {
        return this.providerId;
      }
       set
      {
        this.providerId = value;
      }
    }

    public DateTime DateTime
    {
       get
      {
        return this.datetime;
      }
       set
      {
        this.datetime = value;
      }
    }

    [PriceView]
    public double Price
    {
      get
      {
        return this.price;
      }
       set
      {
        this.price = value;
      }
    }

    [View]
    public int Size
    {
      get
      {
        return this.size;
      }
     set
      {
        this.size = value;
      }
    }

    public Trade(DateTime datetime, double price, int size)
    {

      this.datetime = datetime;
      this.price = price;
      this.size = size;
      this.providerId = (byte) 0;
    }

    public Trade(Trade trade)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(trade.datetime, trade.price, trade.size);
      this.providerId = trade.providerId;
    }

    public Trade()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(DateTime.MinValue, 0.0, 0);
    }

    public override string ToString()
    {
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(1080), (object) this.datetime, (object) this.price, (object) this.size);
    }

    public virtual ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Trade();
    }

    public virtual object Clone()
    {
      return (object) new Trade(this);
    }

    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 2);
      writer.Write(this.datetime.Ticks);
      writer.Write(this.price);
      writer.Write(this.size);
      writer.Write(this.providerId);
    }

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
