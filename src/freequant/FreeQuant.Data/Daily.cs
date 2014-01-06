// Type: SmartQuant.Data.Daily
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  [Serializable]
  public class Daily : Bar
  {
    private const byte rDD23jo4i = (byte) 1;

    public DateTime Date
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DateTime;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DateTime = value.Date;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Daily(DateTime date, double open, double high, double low, double close, long volume, long openInt)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector(BarType.Time, 86400L, date.Date, date.Date.AddSeconds(86399.0), open, high, low, close, volume, openInt);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Daily(DateTime date, double open, double high, double low, double close, long volume)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(date, open, high, low, close, volume, 0L);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Daily(Daily daily)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector((Bar) daily);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Daily()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0L);
      this.endTime = DateTime.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Daily();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void WriteTo(BinaryWriter writer)
    {
      base.WriteTo(writer);
      writer.Write((byte) 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ReadFrom(BinaryReader reader)
    {
      base.ReadFrom(reader);
      int num = (int) reader.ReadByte();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object Clone()
    {
      return (object) new Daily(this);
    }
  }
}
