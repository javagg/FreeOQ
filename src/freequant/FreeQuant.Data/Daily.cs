using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  [Serializable]
  public class Daily : Bar
  {
    private const byte rDD23jo4i = (byte) 1;

    public DateTime Date
    {
      get
      {
        return this.DateTime;
      }
       set
      {
        this.DateTime = value.Date;
      }
    }

    public Daily(DateTime date, double open, double high, double low, double close, long volume, long openInt)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector(BarType.Time, 86400L, date.Date, date.Date.AddSeconds(86399.0), open, high, low, close, volume, openInt);
    }

    public Daily(DateTime date, double open, double high, double low, double close, long volume)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(date, open, high, low, close, volume, 0L);
    }

    public Daily(Daily daily)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector((Bar) daily);
    }

    public Daily()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0L);
      this.endTime = DateTime.MinValue;
    }

    public override ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Daily();
    }

    public override void WriteTo(BinaryWriter writer)
    {
      base.WriteTo(writer);
      writer.Write((byte) 1);
    }

    public override void ReadFrom(BinaryReader reader)
    {
      base.ReadFrom(reader);
      int num = (int) reader.ReadByte();
    }

    public override object Clone()
    {
      return (object) new Daily(this);
    }
  }
}
