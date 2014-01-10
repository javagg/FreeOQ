using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.IO;

namespace FreeQuant.FIXData
{
  public class News : FIXNews, IDataObject, ISeriesObject, ICloneable
  {
    private const byte PGEwNxMr8 = (byte) 1;
    private byte ovPuBurpw;

    public byte ProviderId
    {
       get
      {
        return this.ovPuBurpw;
      }
       set
      {
        this.ovPuBurpw = value;
      }
    }

    public DateTime DateTime
    {
       get
      {
        return this.OrigTime;
      }
       set
      {
        this.OrigTime = value;
      }
    }

    [View]
    public override string Headline
    {
       get
      {
        return base.Headline;
      }
       set
      {
        base.Headline = value;
      }
    }

    public News()
    {
			this.ovPuBurpw =   0;
    }

    public ISeriesObject NewInstance()
    {
      return (ISeriesObject) new News();
    }

    public void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 1);
      writer.Write(this.DateTime.Ticks);
      writer.Write(this.ovPuBurpw);
      FIXGroupStreamer.WriteTo(writer, (FIXGroup) this);
    }

    public void ReadFrom(BinaryReader reader)
    {
      int num = (int) reader.ReadByte();
      this.DateTime = new DateTime(reader.ReadInt64());
      this.ovPuBurpw = reader.ReadByte();
      FIXGroupStreamer.ReadFrom(reader, (FIXGroup) this);
    }

    public object Clone()
    {
      return (object) this;
    }
  }
}
