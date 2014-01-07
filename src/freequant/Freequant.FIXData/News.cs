// Type: SmartQuant.FIXData.News
// Assembly: SmartQuant.FIXData, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: EFFB17F5-E3EE-4C04-A796-299A152DA0CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIXData.dll

using E8idH0Km5kZBKt6QG5;
using SmartQuant.Data;
using SmartQuant.FIX;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIXData
{
  public class News : FIXNews, IDataObject, ISeriesObject, ICloneable
  {
    private const byte PGEwNxMr8 = (byte) 1;
    private byte ovPuBurpw;

    public byte ProviderId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ovPuBurpw;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ovPuBurpw = value;
      }
    }

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OrigTime;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.OrigTime = value;
      }
    }

    [View]
    public override string Headline
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base.Headline;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.Headline = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public News()
    {
      aHVXF4EQTqOeMK8FH8.jYIb1Y6zBfgK8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ovPuBurpw = (byte) 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject NewInstance()
    {
      return (ISeriesObject) new News();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 1);
      writer.Write(this.DateTime.Ticks);
      writer.Write(this.ovPuBurpw);
      FIXGroupStreamer.WriteTo(writer, (FIXGroup) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadFrom(BinaryReader reader)
    {
      int num = (int) reader.ReadByte();
      this.DateTime = new DateTime(reader.ReadInt64());
      this.ovPuBurpw = reader.ReadByte();
      FIXGroupStreamer.ReadFrom(reader, (FIXGroup) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object Clone()
    {
      return (object) this;
    }
  }
}
