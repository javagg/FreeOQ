// Type: SmartQuant.Data.SeriesObject
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  public abstract class SeriesObject : ISeriesObject, ICloneable
  {
    protected DateTime datetime;

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.datetime;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SeriesObject(DateTime datetime)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.datetime = datetime;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SeriesObject()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReadFrom(BinaryReader reader)
    {
      this.datetime = new DateTime(reader.ReadInt64());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write(this.datetime.Ticks);
    }

    public abstract ISeriesObject NewInstance();

    public abstract object Clone();
  }
}
