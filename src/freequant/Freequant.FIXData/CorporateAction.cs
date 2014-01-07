// Type: SmartQuant.FIXData.CorporateAction
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
  public class CorporateAction : FIXGroup, IDataObject, ISeriesObject, ICloneable
  {
    private const byte y6V3qyUUX = (byte) 1;
    private DateTime E1FTJm44N;
    private byte nu4GGnN8R;

    public int CorporateActionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(10200);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(10200, value);
      }
    }

    public DateTime DeclaredDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(10201);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(10201, value);
      }
    }

    public DateTime ExDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(230);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(230, value);
      }
    }

    public DateTime RecordDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(10202);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(10202, value);
      }
    }

    public DateTime PayDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(10203);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(10203, value);
      }
    }

    public int DividendType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(10204);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(10204, value);
      }
    }

    public int SplitType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(10205);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(10205, value);
      }
    }

    public int RightsIssueType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(10206);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(10206, value);
      }
    }

    public double NetAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10207);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10207, value);
      }
    }

    public double GrossAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10208);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10208, value);
      }
    }

    public double Percent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10210);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10210, value);
      }
    }

    public double Ratio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10209);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10209, value);
      }
    }

    public double AdjustmentFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10211);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10211, value);
      }
    }

    [FIXField("15", EFieldOption.Optional)]
    public string Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(15);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(15, value);
      }
    }

    public byte ProviderId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nu4GGnN8R;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nu4GGnN8R = value;
      }
    }

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.E1FTJm44N;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.E1FTJm44N = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CorporateAction()
    {
      aHVXF4EQTqOeMK8FH8.jYIb1Y6zBfgK8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject NewInstance()
    {
      return (ISeriesObject) new CorporateAction();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 1);
      writer.Write(this.E1FTJm44N.Ticks);
      writer.Write(this.nu4GGnN8R);
      FIXGroupStreamer.WriteTo(writer, (FIXGroup) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadFrom(BinaryReader reader)
    {
      int num = (int) reader.ReadByte();
      this.E1FTJm44N = new DateTime(reader.ReadInt64());
      this.nu4GGnN8R = reader.ReadByte();
      FIXGroupStreamer.ReadFrom(reader, (FIXGroup) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object Clone()
    {
      return (object) this;
    }
  }
}
